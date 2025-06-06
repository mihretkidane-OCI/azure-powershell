// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>Defines the url signing action for the delivery rule.</summary>
    public partial class UrlSigningAction :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUrlSigningAction,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUrlSigningActionInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IDeliveryRuleAction" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IDeliveryRuleAction __deliveryRuleAction = new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.DeliveryRuleAction();

        /// <summary>Internal Acessors for Parameter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUrlSigningActionParameters Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUrlSigningActionInternal.Parameter { get => (this._parameter = this._parameter ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.UrlSigningActionParameters()); set { {_parameter = value;} } }

        /// <summary>The name of the action for the delivery rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public string Name { get => "UrlSigning"; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IDeliveryRuleActionInternal)__deliveryRuleAction).Name = "UrlSigning"; }

        /// <summary>Backing field for <see cref="Parameter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUrlSigningActionParameters _parameter;

        /// <summary>Defines the parameters for the action.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUrlSigningActionParameters Parameter { get => (this._parameter = this._parameter ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.UrlSigningActionParameters()); set => this._parameter = value; }

        /// <summary>Algorithm to use for URL signing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string ParameterAlgorithm { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUrlSigningActionParametersInternal)Parameter).Algorithm; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUrlSigningActionParametersInternal)Parameter).Algorithm = value ?? null; }

        /// <summary>
        /// Defines which query string parameters in the url to be considered for expires, key id etc.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUrlSigningParamIdentifier> ParameterNameOverride { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUrlSigningActionParametersInternal)Parameter).ParameterNameOverride; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUrlSigningActionParametersInternal)Parameter).ParameterNameOverride = value ?? null /* arrayOf */; }

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string ParameterTypeName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IDeliveryRuleActionParametersInternal)Parameter).TypeName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IDeliveryRuleActionParametersInternal)Parameter).TypeName = value ; }

        /// <summary>Creates an new <see cref="UrlSigningAction" /> instance.</summary>
        public UrlSigningAction()
        {
            this.__deliveryRuleAction.Name = "UrlSigning";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__deliveryRuleAction), __deliveryRuleAction);
            await eventListener.AssertObjectIsValid(nameof(__deliveryRuleAction), __deliveryRuleAction);
        }
    }
    /// Defines the url signing action for the delivery rule.
    public partial interface IUrlSigningAction :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IDeliveryRuleAction
    {
        /// <summary>Algorithm to use for URL signing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Algorithm to use for URL signing",
        SerializedName = @"algorithm",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Cdn.PSArgumentCompleterAttribute("SHA256")]
        string ParameterAlgorithm { get; set; }
        /// <summary>
        /// Defines which query string parameters in the url to be considered for expires, key id etc.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Defines which query string parameters in the url to be considered for expires, key id etc. ",
        SerializedName = @"parameterNameOverride",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUrlSigningParamIdentifier) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUrlSigningParamIdentifier> ParameterNameOverride { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"typeName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Cdn.PSArgumentCompleterAttribute("DeliveryRuleUrlRedirectActionParameters", "DeliveryRuleUrlSigningActionParameters", "DeliveryRuleOriginGroupOverrideActionParameters", "DeliveryRuleUrlRewriteActionParameters", "DeliveryRuleHeaderActionParameters", "DeliveryRuleCacheExpirationActionParameters", "DeliveryRuleCacheKeyQueryStringBehaviorActionParameters", "DeliveryRuleRouteConfigurationOverrideActionParameters")]
        string ParameterTypeName { get; set; }

    }
    /// Defines the url signing action for the delivery rule.
    internal partial interface IUrlSigningActionInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IDeliveryRuleActionInternal
    {
        /// <summary>Defines the parameters for the action.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUrlSigningActionParameters Parameter { get; set; }
        /// <summary>Algorithm to use for URL signing</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Cdn.PSArgumentCompleterAttribute("SHA256")]
        string ParameterAlgorithm { get; set; }
        /// <summary>
        /// Defines which query string parameters in the url to be considered for expires, key id etc.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUrlSigningParamIdentifier> ParameterNameOverride { get; set; }

        [global::Microsoft.Azure.PowerShell.Cmdlets.Cdn.PSArgumentCompleterAttribute("DeliveryRuleUrlRedirectActionParameters", "DeliveryRuleUrlSigningActionParameters", "DeliveryRuleOriginGroupOverrideActionParameters", "DeliveryRuleUrlRewriteActionParameters", "DeliveryRuleHeaderActionParameters", "DeliveryRuleCacheExpirationActionParameters", "DeliveryRuleCacheKeyQueryStringBehaviorActionParameters", "DeliveryRuleRouteConfigurationOverrideActionParameters")]
        string ParameterTypeName { get; set; }

    }
}