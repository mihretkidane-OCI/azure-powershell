// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Extensions;

    /// <summary>Rollout details.</summary>
    public partial class CustomRollout :
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ICustomRollout,
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ICustomRolloutInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IProxyResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ProxyResource();

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IResourceInternal)__proxyResource).Id; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ICustomRolloutProperties Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ICustomRolloutInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.CustomRolloutProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Specification</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ICustomRolloutPropertiesSpecification Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ICustomRolloutInternal.Specification { get => ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ICustomRolloutPropertiesAutoGeneratedInternal)Property).Specification; set => ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ICustomRolloutPropertiesAutoGeneratedInternal)Property).Specification = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SpecificationCanary</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ICustomRolloutSpecificationCanary Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ICustomRolloutInternal.SpecificationCanary { get => ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ICustomRolloutPropertiesAutoGeneratedInternal)Property).SpecificationCanary; set => ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ICustomRolloutPropertiesAutoGeneratedInternal)Property).SpecificationCanary = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ICustomRolloutPropertiesStatus Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ICustomRolloutInternal.Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ICustomRolloutPropertiesAutoGeneratedInternal)Property).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ICustomRolloutPropertiesAutoGeneratedInternal)Property).Status = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IResourceInternal)__proxyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IResourceInternal)__proxyResource).Id = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IResourceInternal)__proxyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IResourceInternal)__proxyResource).Name = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IResourceInternal)__proxyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IResourceInternal)__proxyResource).Type = value ?? null; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IResourceInternal)__proxyResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ICustomRolloutProperties _property;

        /// <summary>Properties of the rollout.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ICustomRolloutProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.CustomRolloutProperties()); set => this._property = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ICustomRolloutPropertiesAutoGeneratedInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ICustomRolloutPropertiesAutoGeneratedInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> SpecificationCanaryRegion { get => ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ICustomRolloutPropertiesAutoGeneratedInternal)Property).SpecificationCanaryRegion; set => ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ICustomRolloutPropertiesAutoGeneratedInternal)Property).SpecificationCanaryRegion = value ?? null /* arrayOf */; }

        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ICustomRolloutSpecificationProviderRegistration SpecificationProviderRegistration { get => ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ICustomRolloutPropertiesAutoGeneratedInternal)Property).SpecificationProviderRegistration; set => ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ICustomRolloutPropertiesAutoGeneratedInternal)Property).SpecificationProviderRegistration = value ?? null /* model class */; }

        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IResourceTypeRegistration> SpecificationResourceTypeRegistration { get => ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ICustomRolloutPropertiesAutoGeneratedInternal)Property).SpecificationResourceTypeRegistration; set => ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ICustomRolloutPropertiesAutoGeneratedInternal)Property).SpecificationResourceTypeRegistration = value ?? null /* arrayOf */; }

        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> StatusCompletedRegion { get => ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ICustomRolloutPropertiesAutoGeneratedInternal)Property).StatusCompletedRegion; set => ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ICustomRolloutPropertiesAutoGeneratedInternal)Property).StatusCompletedRegion = value ?? null /* arrayOf */; }

        /// <summary>Dictionary of <ExtendedErrorInfo></summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ICustomRolloutStatusFailedOrSkippedRegions StatusFailedOrSkippedRegion { get => ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ICustomRolloutPropertiesAutoGeneratedInternal)Property).StatusFailedOrSkippedRegion; set => ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ICustomRolloutPropertiesAutoGeneratedInternal)Property).StatusFailedOrSkippedRegion = value ?? null /* model class */; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IResourceInternal)__proxyResource).Type; }

        /// <summary>Creates an new <see cref="CustomRollout" /> instance.</summary>
        public CustomRollout()
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
            await eventListener.AssertNotNull(nameof(__proxyResource), __proxyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyResource), __proxyResource);
        }
    }
    /// Rollout details.
    public partial interface ICustomRollout :
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IProxyResource
    {
        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.PSArgumentCompleterAttribute("NotSpecified", "Accepted", "Running", "Creating", "Created", "Deleting", "Deleted", "Canceled", "Failed", "Succeeded", "MovingResources", "TransientFailure", "RolloutInProgress")]
        string ProvisioningState { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"regions",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> SpecificationCanaryRegion { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"providerRegistration",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ICustomRolloutSpecificationProviderRegistration) })]
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ICustomRolloutSpecificationProviderRegistration SpecificationProviderRegistration { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"resourceTypeRegistrations",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IResourceTypeRegistration) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IResourceTypeRegistration> SpecificationResourceTypeRegistration { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"completedRegions",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> StatusCompletedRegion { get; set; }
        /// <summary>Dictionary of <ExtendedErrorInfo></summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Dictionary of <ExtendedErrorInfo>",
        SerializedName = @"failedOrSkippedRegions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ICustomRolloutStatusFailedOrSkippedRegions) })]
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ICustomRolloutStatusFailedOrSkippedRegions StatusFailedOrSkippedRegion { get; set; }

    }
    /// Rollout details.
    internal partial interface ICustomRolloutInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IProxyResourceInternal
    {
        /// <summary>Properties of the rollout.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ICustomRolloutProperties Property { get; set; }

        [global::Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.PSArgumentCompleterAttribute("NotSpecified", "Accepted", "Running", "Creating", "Created", "Deleting", "Deleted", "Canceled", "Failed", "Succeeded", "MovingResources", "TransientFailure", "RolloutInProgress")]
        string ProvisioningState { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ICustomRolloutPropertiesSpecification Specification { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ICustomRolloutSpecificationCanary SpecificationCanary { get; set; }

        System.Collections.Generic.List<string> SpecificationCanaryRegion { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ICustomRolloutSpecificationProviderRegistration SpecificationProviderRegistration { get; set; }

        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IResourceTypeRegistration> SpecificationResourceTypeRegistration { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ICustomRolloutPropertiesStatus Status { get; set; }

        System.Collections.Generic.List<string> StatusCompletedRegion { get; set; }
        /// <summary>Dictionary of <ExtendedErrorInfo></summary>
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.ICustomRolloutStatusFailedOrSkippedRegions StatusFailedOrSkippedRegion { get; set; }

    }
}