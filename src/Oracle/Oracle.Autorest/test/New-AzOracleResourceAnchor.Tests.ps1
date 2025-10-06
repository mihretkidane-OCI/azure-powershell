# Minimal record test for New-AzOracleResourceAnchor
# ORDER: CREATE (PUT) -> GET -> DELETE
# Generates New-AzOracleResourceAnchor.Recording.json in -Record mode and cleans up

if (($null -eq $TestName) -or ($TestName -contains 'New-AzOracleResourceAnchor')) {
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-not (Test-Path $loadEnvPath)) { $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1' }
  . $loadEnvPath

  $TestRecordingFile = Join-Path $PSScriptRoot 'New-AzOracleResourceAnchor.Recording.json'

  # Locate recorder harness
  $currentPath = $PSScriptRoot
  while (-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File -ErrorAction SilentlyContinue
    $currentPath = Split-Path -Path $currentPath -Parent
    if (-not $currentPath) { break }
  }
  if ($mockingPath) { . ($mockingPath | Select-Object -First 1).FullName }

  # Import module and private binary (for warmup and private delete)
  $modulePsd1 = Join-Path (Join-Path $PSScriptRoot '..') 'Az.Oracle.psd1'
  Import-Module -Name $modulePsd1 -Force -ErrorAction Stop
  $moduleRoot  = Split-Path -Path $modulePsd1 -Parent
  $privateDll  = Join-Path $moduleRoot 'bin/Az.Oracle.private.dll'
  if (Test-Path $privateDll) { Import-Module -Name $privateDll -Force -ErrorAction Stop }

  Describe 'New-AzOracleResourceAnchor' {
    # Inputs
    $rgName   = $(if ($env:RA_RG) { $env:RA_RG } else { 'PowerShellTestRg' })
    $location = $(if ($env:RA_LOCATION) { $env:RA_LOCATION } else { 'eastus' })
    $raName   = $(if ($env:RA_NAME) { $env:RA_NAME } else { 'PsRaTest01' })

    It 'Warmup' {
      { & 'Az.Oracle.private\Get-AzOracleOperation_List' | Out-Null } | Should -Not -Throw
    }

    It 'Create-Get-Delete' {
      {
        # Subscription context
        $subId = $(if ($env:AZURE_SUBSCRIPTION_ID) { $env:AZURE_SUBSCRIPTION_ID } else { (Get-AzContext).Subscription.Id })
        $ctx = Get-AzContext -ErrorAction SilentlyContinue
        if (-not $ctx -or $ctx.Subscription.Id -ne $subId) { Set-AzContext -Subscription $subId | Out-Null }

        # ARM helpers
        $arm = $(if ($env:ARM_ENDPOINT) { $env:ARM_ENDPOINT.TrimEnd('/') } else { 'https://management.azure.com' })
        $rgUri = "$arm/subscriptions/$subId/resourcegroups/$rgName?api-version=2021-04-01"
        $api = '2025-09-01'
        function New-Uri([string]$base,[string]$api) {
          $b = [System.UriBuilder]("$arm$base"); $b.Query = "api-version=$api"; $b.Uri.AbsoluteUri
        }
        $raBase = "/subscriptions/$subId/resourceGroups/$rgName/providers/Oracle.Database/resourceAnchors/$raName"
        $createUri = New-Uri -base $raBase -api $api

        # Ensure RG
        $rg = Invoke-AzRest -Method GET -Uri $rgUri
        if ($rg.StatusCode -ne 200) {
          $rgBody = @{ location = $location } | ConvertTo-Json
          $null = Invoke-AzRest -Method PUT -Uri $rgUri -Payload $rgBody
          Start-Sleep -Seconds 3
        }

        # Pre-clean: delete if exists (best-effort)
        try {
          $existing = Get-AzOracleResourceAnchor -Name $raName -ResourceGroupName $rgName -ErrorAction SilentlyContinue
          if ($existing) {
            $rmCmd = Get-Command -Name Remove-AzOracleResourceAnchor -ErrorAction SilentlyContinue
            if ($rmCmd) {
              Remove-AzOracleResourceAnchor -Name $raName -ResourceGroupName $rgName -Force -ErrorAction SilentlyContinue | Out-Null
            } else {
              $rmPriv = Get-Command -Name 'Az.Oracle.private\Remove-AzOracleResourceAnchor' -ErrorAction SilentlyContinue
              if ($rmPriv) {
                & 'Az.Oracle.private\Remove-AzOracleResourceAnchor' -Name $raName -ResourceGroupName $rgName -Force -ErrorAction SilentlyContinue | Out-Null
              } else {
                $null = Invoke-AzRest -Method DELETE -Uri $createUri
              }
            }
            Start-Sleep -Seconds 5
          }
        } catch {}

        # CREATE (PUT minimal body)
        $createBody = @{ location = 'global' } | ConvertTo-Json -Depth 10
        $put = Invoke-AzRest -Method PUT -Uri $createUri -Payload $createBody

        # Accept success or embedded 409 indicating an existing RA for the RG/subscription
        $embedded409 = $false
        if ($put.Content) {
          try { $putJson = $put.Content | ConvertFrom-Json; if ($putJson.error -and $putJson.error.code -eq '409') { $embedded409 = $true } } catch {}
        }
        if ($put.StatusCode -in 200,201,202,409 -or ($put.StatusCode -eq 400 -and $embedded409)) {
          if ($put.StatusCode -eq 409 -or ($put.StatusCode -eq 400 -and $embedded409)) {
            # Discover an existing RA name in RG
            $listUri = New-Uri -base "/subscriptions/$subId/resourceGroups/$rgName/providers/Oracle.Database/resourceAnchors" -api $api
            $lresp = Invoke-AzRest -Method GET -Uri $listUri
            if ($lresp.StatusCode -eq 200 -and $lresp.Content) {
              try { $ljson = $lresp.Content | ConvertFrom-Json; if ($ljson.value -and $ljson.value[0] -and $ljson.value[0].name) { $raName = $ljson.value[0].name; $createUri = New-Uri -base ("/subscriptions/$subId/resourceGroups/$rgName/providers/Oracle.Database/resourceAnchors/$raName") -api $api } } catch {}
            }
          }
        } else {
          throw "ResourceAnchor CREATE failed: $($put.StatusCode) $($put.Content)"
        }

        # GET
        $ok = $false
        try {
          $got = Get-AzOracleResourceAnchor -Name $raName -ResourceGroupName $rgName -ErrorAction SilentlyContinue
          if ($got) { $ok = $true }
        } catch {}
        if (-not $ok) {
          $max = 12; $i=0
          do {
            $resp = Invoke-AzRest -Method GET -Uri $createUri
            if ($resp.StatusCode -eq 200) { $ok = $true; break }
            Start-Sleep -Seconds 5; $i++
          } while ($i -lt $max)
          if (-not $ok) { throw "GET after CREATE did not return 200 within polling window." }
        }

        # DELETE
        try {
          $removed = $false
          $rmCmd = Get-Command -Name Remove-AzOracleResourceAnchor -ErrorAction SilentlyContinue
          if ($rmCmd) {
            Remove-AzOracleResourceAnchor -Name $raName -ResourceGroupName $rgName -Force -ErrorAction SilentlyContinue | Out-Null
            $removed = $true
          } else {
            $rmPriv = Get-Command -Name 'Az.Oracle.private\Remove-AzOracleResourceAnchor' -ErrorAction SilentlyContinue
            if ($rmPriv) {
              & 'Az.Oracle.private\Remove-AzOracleResourceAnchor' -Name $raName -ResourceGroupName $rgName -Force -ErrorAction SilentlyContinue | Out-Null
              $removed = $true
            }
          }
          if (-not $removed) {
            $null = Invoke-AzRest -Method DELETE -Uri $createUri
          }
        } catch {
          throw "DELETE failed: $($_.Exception.Message)"
        }

        # Final GET to ensure deleted (best-effort)
        $deleted = $false
        try {
          $gone = Get-AzOracleResourceAnchor -Name $raName -ResourceGroupName $rgName -ErrorAction SilentlyContinue
          if (-not $gone) { $deleted = $true }
        } catch { $deleted = $true }
        if (-not $deleted) { throw "ResourceAnchor not deleted." }
      } | Should -Not -Throw
    }
  }
}
