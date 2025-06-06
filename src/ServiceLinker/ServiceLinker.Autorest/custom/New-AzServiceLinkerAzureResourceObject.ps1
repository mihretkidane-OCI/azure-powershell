
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
Create an in-memory object for AzureResource.
.Description
Create an in-memory object for AzureResource.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.AzureResource
.Link
https://learn.microsoft.com/powershell/module/az.ServiceLinker/new-azservicelinkerazureresourceobject
#>
function New-AzServiceLinkerAzureResourceObject {
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.ModelCmdletAttribute()]
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.AzureResource')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(Mandatory, HelpMessage="The Id of azure resource.")]
        [string]
        $Id,
        # [Parameter(HelpMessage="The azure resource connection related properties.")]
        # [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.IAzureResourcePropertiesBase]
        # $ResourceProperty,
        [Parameter(HelpMessage="True if connect via Kubernetes CSI Driver. Source must be AKS and target must be KeyVault.")]
        [bool]
        $ConnectAsKubernetesCsiDriver,
        [Parameter(DontShow, HelpMessage="The target service type.")]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.DefaultInfo(Script='"AzureResource"')]
        [string]
        $Type
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.AzureResource]::New()

        if ($PSBoundParameters.ContainsKey('Id')) {
            $Pattern = "/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/(?<resourceProvider>[^/]+)(/(?<resourceType>[^/]+)/(?<resourceName>[^/]+))+"
            if($Id -notmatch $Pattern){
                Throw "Target id is not a valid azure resource ID"
            }
            $Object.Id = $Id
        }
        if ($PSBoundParameters.ContainsKey('ConnectAsKubernetesCsiDriver')) {
            $ResourceProperty = [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.AzureKeyVaultProperties]::New()
            $ResourceProperty.ConnectAsKubernetesCsiDriver = $ConnectAsKubernetesCsiDriver
            $Object.ResourceProperty = $ResourceProperty
        }
        if ($PSBoundParameters.ContainsKey('Type')) {
            $Object.Type = $Type
        }
        return $Object
    }
}