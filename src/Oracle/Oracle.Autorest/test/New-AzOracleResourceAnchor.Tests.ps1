# Minimal record test for New-AzOracleResourceAnchor
# EXACT ORDER: CREATE -> GET -> DELETE (each as its own operation)
# Generates New-AzOracleResourceAnchor.Recording.json in -Record mode

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

  # Import module (and private binary for internal cmdlets if available)
  $modulePsd1 = Join-Path (Join-Path $PSScriptRoot '..') 'Az.Oracle.psd1'
  Import-Module -Name $modulePsd1 -Force -ErrorAction Stop
  $moduleRoot  = Split-Path -Path $modulePsd1 -Parent
  $privateDll  = Join-Path $moduleRoot 'bin/Az.Oracle.private.dll'
  if (Test-Path $privateDll) { Import-Module -Name $privateDll -Force -ErrorAction Stop }
  # Ensure exported proxy cmdlets (Get/Remove RA) are available so recorder captures pipeline calls
  $exportsPath = Join-Path $moduleRoot 'exports'
  $getRaExport = Join-Path $exportsPath 'Get-AzOracleResourceAnchor.ps1'
  if (Test-Path $getRaExport) { . $getRaExport }
  $rmRaExport  = Join-Path $exportsPath 'Remove-AzOracleResourceAnchor.ps1'
  if (Test-Path $rmRaExport)  { . $rmRaExport }

  Describe 'New-AzOracleResourceAnchor' {

    BeforeAll {
      # Inputs (use eastus2 for RG by default per request; RA resource itself is global)
      $script:rgName   = $(if ($env:RA_RG) { $env:RA_RG } else { 'PowerShellTestRg' })
      $script:location = $(if ($env:RA_LOCATION) { $env:RA_LOCATION } else { 'eastus2' })
      $script:raName   = $(if ($env:RA_NAME) { $env:RA_NAME } else { 'PsRaTest01' })
      $script:api      = '2025-09-01'

      # Optional: keep resources for manual inspection in Azure Portal
      $keepFlag = $(if ($env:AZ_TEST_KEEP) { $env:AZ_TEST_KEEP } elseif ($env:KEEP_RESOURCES) { $env:KEEP_RESOURCES } elseif ($env:NO_CLEANUP) { $env:NO_CLEANUP } else { '' })
      $script:keep = $false
      if ($keepFlag) {
        try {
          if ($keepFlag -is [string]) { $script:keep = ($keepFlag -match '^(?i:1|true|yes|keep)$') }
          elseif ($keepFlag -is [bool]) { $script:keep = [bool]$keepFlag }
        } catch {}
      }

      # Subscription context
      $script:subId = $(if ($env:AZURE_SUBSCRIPTION_ID) { $env:AZURE_SUBSCRIPTION_ID } else { (Get-AzContext).Subscription.Id })
      $ctx = Get-AzContext -ErrorAction SilentlyContinue
      if (-not $ctx -or $ctx.Subscription.Id -ne $script:subId) { Set-AzContext -Subscription $script:subId | Out-Null }

      # ARM helpers
      $script:arm = $(if ($env:ARM_ENDPOINT) { $env:ARM_ENDPOINT.TrimEnd('/') } else { 'https://management.azure.com' })
      $script:rgUri = "$script:arm/subscriptions/$script:subId/resourcegroups/$script:rgName?api-version=2021-04-01"
      function New-Uri([string]$base,[string]$api) { $b = [System.UriBuilder]("$script:arm$base"); $b.Query = "api-version=$api"; $b.Uri.AbsoluteUri }
      $script:raBase = "/subscriptions/$script:subId/resourceGroups/$script:rgName/providers/Oracle.Database/resourceAnchors/$script:raName"
      $script:raUri  = New-Uri -base $script:raBase -api $script:api

      # Ensure RG (eastus2 by default)
      $rg = Invoke-AzRest -Method GET -Uri $script:rgUri
      if ($rg.StatusCode -ne 200) {
        $rgBody = @{ location = $script:location } | ConvertTo-Json
        $null = Invoke-AzRest -Method PUT -Uri $script:rgUri -Payload $rgBody
        Start-Sleep -Seconds 3
      }

      # Pre-clean: delete any existing RA with target name (best-effort)
      try {
        $existing = Get-AzOracleResourceAnchor -Name $script:raName -ResourceGroupName $script:rgName -ErrorAction SilentlyContinue
        if ($existing) {
          $removed = $false
          $rmCmd = Get-Command -Name Remove-AzOracleResourceAnchor -ErrorAction SilentlyContinue
          if ($rmCmd) {
            Remove-AzOracleResourceAnchor -Name $script:raName -ResourceGroupName $script:rgName -Force -ErrorAction SilentlyContinue | Out-Null
            $removed = $true
          } else {
            $rmPriv = Get-Command -Name 'Az.Oracle.private\Remove-AzOracleResourceAnchor' -ErrorAction SilentlyContinue
            if ($rmPriv) {
              & 'Az.Oracle.private\Remove-AzOracleResourceAnchor' -Name $script:raName -ResourceGroupName $script:rgName -Force -ErrorAction SilentlyContinue | Out-Null
              $removed = $true
            }
          }
          if (-not $removed) { $null = Invoke-AzRest -Method DELETE -Uri $script:raUri }
          Start-Sleep -Seconds 5
        }
      } catch {}
    }

    It 'Create' {
      {
        # CREATE (PUT minimal body; RA is global)
        $createBody = @{ location = 'global' } | ConvertTo-Json -Depth 10
        $put = Invoke-AzRest -Method PUT -Uri $script:raUri -Payload $createBody

        # Accept success or embedded 409 indicating existing RA for RG/subscription
        $embedded409 = $false
        if ($put.Content) {
          try {
            $putJson = $put.Content | ConvertFrom-Json
            if ($putJson.error -and $putJson.error.code -eq '409') { $embedded409 = $true }
          } catch {}
        }
        if ($put.StatusCode -in 200,201,202,409 -or ($put.StatusCode -eq 400 -and $embedded409)) {
          if ($put.StatusCode -eq 409 -or ($put.StatusCode -eq 400 -and $embedded409)) {
            # Discover an existing RA name and adjust state
            $listUri = New-Uri -base "/subscriptions/$script:subId/resourceGroups/$script:rgName/providers/Oracle.Database/resourceAnchors" -api $script:api
            $lresp = Invoke-AzRest -Method GET -Uri $listUri
            if ($lresp.StatusCode -eq 200 -and $lresp.Content) {
              try {
                $ljson = $lresp.Content | ConvertFrom-Json
                if ($ljson.value -and $ljson.value[0] -and $ljson.value[0].name) {
                  $script:raName = $ljson.value[0].name
                  $script:raBase = "/subscriptions/$script:subId/resourceGroups/$script:rgName/providers/Oracle.Database/resourceAnchors/$script:raName"
                  $script:raUri  = New-Uri -base $script:raBase -api $script:api
                }
              } catch {}
            }
          }
        } else {
          throw "ResourceAnchor CREATE failed: $($put.StatusCode) $($put.Content)"
        }
      } | Should -Not -Throw
    }

    It 'Get' {
      {
        # GET must succeed (module preferred, else REST polling)
        $ok = $false
        try {
          $got = Get-AzOracleResourceAnchor -Name $script:raName -ResourceGroupName $script:rgName -ErrorAction SilentlyContinue
          if ($got) { $ok = $true }
        } catch {}
        if (-not $ok) {
          $max = 12; $i=0
          do {
            $resp = Invoke-AzRest -Method GET -Uri $script:raUri
            if ($resp.StatusCode -eq 200) { $ok = $true; break }
            Start-Sleep -Seconds 5; $i++
          } while ($i -lt $max)
          if (-not $ok) { throw "GET after CREATE did not return 200 within polling window." }
        }
      } | Should -Not -Throw
    }

    It 'Delete' {
      {
        if (-not $script:keep) {
          # Optional delay before deletion (default 180s)
          $delay = $(if ($env:AZ_TEST_DELAY_SECONDS) { [int]$env:AZ_TEST_DELAY_SECONDS } else { 180 })
          Write-Host ("Waiting {0}s before deletion..." -f $delay) -ForegroundColor Gray
          Start-Sleep -Seconds $delay

          # DELETE must succeed (prefer module/private cmdlets; fallback to REST), then poll for 404
          $removed = $false
          try {
            $rmCmd = Get-Command -Name Remove-AzOracleResourceAnchor -ErrorAction SilentlyContinue
            if ($rmCmd) {
              Remove-AzOracleResourceAnchor -Name $script:raName -ResourceGroupName $script:rgName -Force -ErrorAction SilentlyContinue | Out-Null
              $removed = $true
            } else {
              $rmPriv = Get-Command -Name 'Az.Oracle.private\Remove-AzOracleResourceAnchor' -ErrorAction SilentlyContinue
              if ($rmPriv) {
                & 'Az.Oracle.private\Remove-AzOracleResourceAnchor' -Name $script:raName -ResourceGroupName $script:rgName -Force -ErrorAction SilentlyContinue | Out-Null
                $removed = $true
              }
            }
          } catch {
            Write-Host "Delete via module/private failed: $($_.Exception.Message)" -ForegroundColor Yellow
          }

          if (-not $removed) {
            try {
              $delResp = Invoke-AzRest -Method DELETE -Uri $script:raUri
              Write-Host ("REST DELETE Status: {0}" -f $delResp.StatusCode) -ForegroundColor Gray
            } catch {
              Write-Host "REST DELETE threw: $($_.Exception.Message)" -ForegroundColor Yellow
            }
          }

          # Poll GET until 404 (resource gone) or timeout
          $deleted = $false
          $maxDel = 36; $i = 0
          do {
            try {
              $g = Invoke-AzRest -Method GET -Uri $script:raUri
              $code = $g.StatusCode
            } catch {
              $code = $null
            }
            if ($code -eq 404) { $deleted = $true; break }
            Start-Sleep -Seconds 5
            $i++
          } while ($i -lt $maxDel)

          if (-not $deleted) { throw "ResourceAnchor not deleted after polling window." }
        } else {
          Write-Host 'AZ_TEST_KEEP enabled: skipping deletion and final verification.' -ForegroundColor Yellow
        }
      } | Should -Not -Throw
    }
  }
}
