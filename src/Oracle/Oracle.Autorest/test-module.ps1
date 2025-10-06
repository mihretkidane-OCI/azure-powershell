param(
  [Parameter(ValueFromRemainingArguments = $true)]
  [object[]]$Args
)

# Delegate src test-module.ps1 calls to the generated script, preserving args
$here = Split-Path -Path $MyInvocation.MyCommand.Path -Parent
# repo root = ../../../ from src/Oracle/Oracle.Autorest
$repoRoot = Split-Path -Path (Split-Path -Path (Split-Path -Path $here -Parent) -Parent) -Parent
$genScript = Join-Path $repoRoot 'generated/Oracle/Oracle.Autorest/test-module.ps1'
$genDir    = Split-Path -Path $genScript -Parent

if (-not (Test-Path -LiteralPath $genScript)) {
  throw "Generated harness not found at: $genScript"
}

Write-Host "Forwarding to generated harness:" -ForegroundColor DarkCyan
Write-Host "  $genScript $($Args -join ' ')" -ForegroundColor DarkCyan

Push-Location $genDir
try {
  # Run the generated harness with the exact args the user passed in
  & pwsh -NoLogo -NoProfile -File $genScript @Args
} finally {
  Pop-Location
}
