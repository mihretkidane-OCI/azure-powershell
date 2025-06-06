// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Extensions;

    public partial class ResourceTypeIdentityManagement :
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IResourceTypeIdentityManagement,
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IResourceTypeIdentityManagementInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IIdentityManagement"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IIdentityManagement __identityManagement = new Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IdentityManagement();

        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IIdentityManagementInternal)__identityManagement).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IIdentityManagementInternal)__identityManagement).Type = value ?? null; }

        /// <summary>Creates an new <see cref="ResourceTypeIdentityManagement" /> instance.</summary>
        public ResourceTypeIdentityManagement()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__identityManagement), __identityManagement);
            await eventListener.AssertObjectIsValid(nameof(__identityManagement), __identityManagement);
        }
    }
    public partial interface IResourceTypeIdentityManagement :
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IIdentityManagement
    {

    }
    internal partial interface IResourceTypeIdentityManagementInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IIdentityManagementInternal
    {

    }
}