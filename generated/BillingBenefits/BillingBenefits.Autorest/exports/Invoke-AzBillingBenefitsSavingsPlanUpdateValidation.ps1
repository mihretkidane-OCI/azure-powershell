
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Validate savings plan patch.
.Description
Validate savings plan patch.
.Example
$model = @{
    AppliedScopeType = "Single"
    AppliedScopePropertiesSubscriptionId = "/subscriptions/eef82110-c91b-4395-9420-fcfcbefc5a47"
}

$models = @($model)

$response = Invoke-AzBillingBenefitsSavingsPlanUpdateValidation -SavingsPlanId "9fde2a72-776b-49fc-869c-dca8859d7d62" -SavingsPlanOrderId "d7ea1620-2bba-46e2-8434-11f31bfb984d" -Benefit $models

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.IBillingBenefitsIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.ISavingsPlanValidateResponse
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BENEFIT <ISavingsPlanUpdateRequestProperties[]>: .
  [AppliedScopePropertyDisplayName <String>]: Display name
  [AppliedScopePropertyManagementGroupId <String>]: Fully-qualified identifier of the management group where the benefit must be applied.
  [AppliedScopePropertyResourceGroupId <String>]: Fully-qualified identifier of the resource group.
  [AppliedScopePropertySubscriptionId <String>]: Fully-qualified identifier of the subscription.
  [AppliedScopePropertyTenantId <String>]: Tenant ID where the benefit is applied.
  [AppliedScopeType <String>]: Type of the Applied Scope.
  [DisplayName <String>]: Display name
  [Renew <Boolean?>]: Setting this to true will automatically purchase a new benefit on the expiration date time.
  [RenewProperty <IRenewProperties>]: 
    [PurchaseProperty <IPurchaseRequest>]: 
      [AppliedScopePropertyDisplayName <String>]: Display name
      [AppliedScopePropertyManagementGroupId <String>]: Fully-qualified identifier of the management group where the benefit must be applied.
      [AppliedScopePropertyResourceGroupId <String>]: Fully-qualified identifier of the resource group.
      [AppliedScopePropertySubscriptionId <String>]: Fully-qualified identifier of the subscription.
      [AppliedScopePropertyTenantId <String>]: Tenant ID where the benefit is applied.
      [AppliedScopeType <String>]: Type of the Applied Scope.
      [BillingPlan <String>]: Represents the billing plan in ISO 8601 format. Required only for monthly billing plans.
      [BillingScopeId <String>]: Subscription that will be charged for purchasing the benefit
      [CommitmentAmount <Double?>]: 
      [CommitmentCurrencyCode <String>]: The ISO 4217 3-letter currency code for the currency used by this purchase record.
      [CommitmentGrain <String>]: Commitment grain.
      [DisplayName <String>]: Friendly name of the savings plan
      [Renew <Boolean?>]: Setting this to true will automatically purchase a new benefit on the expiration date time.
      [SkuName <String>]: Name of the SKU to be applied
      [Term <String>]: Represent benefit term in ISO 8601 format.

INPUTOBJECT <IBillingBenefitsIdentity>: Identity Parameter
  [Id <String>]: Resource identity path
  [ReservationOrderAliasName <String>]: Name of the reservation order alias
  [SavingsPlanId <String>]: ID of the savings plan
  [SavingsPlanOrderAliasName <String>]: Name of the savings plan order alias
  [SavingsPlanOrderId <String>]: Order ID of the savings plan

SAVINGSPLANORDERINPUTOBJECT <IBillingBenefitsIdentity>: Identity Parameter
  [Id <String>]: Resource identity path
  [ReservationOrderAliasName <String>]: Name of the reservation order alias
  [SavingsPlanId <String>]: ID of the savings plan
  [SavingsPlanOrderAliasName <String>]: Name of the savings plan order alias
  [SavingsPlanOrderId <String>]: Order ID of the savings plan
.Link
https://learn.microsoft.com/powershell/module/az.billingbenefits/invoke-azbillingbenefitssavingsplanupdatevalidation
#>
function Invoke-AzBillingBenefitsSavingsPlanUpdateValidation {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.ISavingsPlanValidateResponse])]
[CmdletBinding(DefaultParameterSetName='ValidateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='ValidateExpanded', Mandatory)]
    [Parameter(ParameterSetName='ValidateViaIdentitySavingsPlanOrderExpanded', Mandatory)]
    [Parameter(ParameterSetName='ValidateViaJsonFilePath', Mandatory)]
    [Parameter(ParameterSetName='ValidateViaJsonString', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Category('Path')]
    [System.String]
    # ID of the savings plan
    ${SavingsPlanId},

    [Parameter(ParameterSetName='ValidateExpanded', Mandatory)]
    [Parameter(ParameterSetName='ValidateViaJsonFilePath', Mandatory)]
    [Parameter(ParameterSetName='ValidateViaJsonString', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Category('Path')]
    [System.String]
    # Order ID of the savings plan
    ${SavingsPlanOrderId},

    [Parameter(ParameterSetName='ValidateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.IBillingBenefitsIdentity]
    # Identity Parameter
    ${InputObject},

    [Parameter(ParameterSetName='ValidateViaIdentitySavingsPlanOrderExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.IBillingBenefitsIdentity]
    # Identity Parameter
    ${SavingsPlanOrderInputObject},

    [Parameter(ParameterSetName='ValidateExpanded')]
    [Parameter(ParameterSetName='ValidateViaIdentityExpanded')]
    [Parameter(ParameterSetName='ValidateViaIdentitySavingsPlanOrderExpanded')]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.ISavingsPlanUpdateRequestProperties[]]
    # .
    ${Benefit},

    [Parameter(ParameterSetName='ValidateViaJsonFilePath', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Category('Body')]
    [System.String]
    # Path of Json file supplied to the Validate operation
    ${JsonFilePath},

    [Parameter(ParameterSetName='ValidateViaJsonString', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Category('Body')]
    [System.String]
    # Json string supplied to the Validate operation
    ${JsonString},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        
        $testPlayback = $false
        $PSBoundParameters['HttpPipelinePrepend'] | Foreach-Object { if ($_) { $testPlayback = $testPlayback -or ('Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.PipelineMock' -eq $_.Target.GetType().FullName -and 'Playback' -eq $_.Target.Mode) } }

        $context = Get-AzContext
        if (-not $context -and -not $testPlayback) {
            Write-Error "No Azure login detected. Please run 'Connect-AzAccount' to log in."
            exit
        }

        if ($null -eq [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion) {
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion = $PSVersionTable.PSVersion.ToString()
        }         
        $preTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        if ($preTelemetryId -eq '') {
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId =(New-Guid).ToString()
            [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
        } else {
            $internalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
            if ($internalCalledCmdlets -eq '') {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $MyInvocation.MyCommand.Name
            } else {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets += ',' + $MyInvocation.MyCommand.Name
            }
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = 'internal'
        }

        $mapping = @{
            ValidateExpanded = 'Az.BillingBenefits.private\Invoke-AzBillingBenefitsSavingsPlanUpdateValidation_ValidateExpanded';
            ValidateViaIdentityExpanded = 'Az.BillingBenefits.private\Invoke-AzBillingBenefitsSavingsPlanUpdateValidation_ValidateViaIdentityExpanded';
            ValidateViaIdentitySavingsPlanOrderExpanded = 'Az.BillingBenefits.private\Invoke-AzBillingBenefitsSavingsPlanUpdateValidation_ValidateViaIdentitySavingsPlanOrderExpanded';
            ValidateViaJsonFilePath = 'Az.BillingBenefits.private\Invoke-AzBillingBenefitsSavingsPlanUpdateValidation_ValidateViaJsonFilePath';
            ValidateViaJsonString = 'Az.BillingBenefits.private\Invoke-AzBillingBenefitsSavingsPlanUpdateValidation_ValidateViaJsonString';
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        if ($null -ne $MyInvocation.MyCommand -and [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PromptedPreviewMessageCmdlets -notcontains $MyInvocation.MyCommand.Name -and [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.MessageAttributeHelper]::ContainsPreviewAttribute($cmdInfo, $MyInvocation)){
            [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.MessageAttributeHelper]::ProcessPreviewMessageAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PromptedPreviewMessageCmdlets.Enqueue($MyInvocation.MyCommand.Name)
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        if ($wrappedCmd -eq $null) {
            $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Function)
        }
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }

    finally {
        $backupTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        $backupInternalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
    }

}
end {
    try {
        $steppablePipeline.End()

        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $backupTelemetryId
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $backupInternalCalledCmdlets
        if ($preTelemetryId -eq '') {
            [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
