// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.PowerShell;

    /// <summary>Request to validate create order limit for current subscription.</summary>
    [System.ComponentModel.TypeConverter(typeof(CreateOrderLimitForSubscriptionValidationRequestTypeConverter))]
    public partial class CreateOrderLimitForSubscriptionValidationRequest
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.CreateOrderLimitForSubscriptionValidationRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal CreateOrderLimitForSubscriptionValidationRequest(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DeviceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ICreateOrderLimitForSubscriptionValidationRequestInternal)this).DeviceType = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.SkuName) content.GetValueForProperty("DeviceType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ICreateOrderLimitForSubscriptionValidationRequestInternal)this).DeviceType, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.SkuName.CreateFrom);
            }
            if (content.Contains("Model"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ICreateOrderLimitForSubscriptionValidationRequestInternal)this).Model = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ModelName?) content.GetValueForProperty("Model",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ICreateOrderLimitForSubscriptionValidationRequestInternal)this).Model, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ModelName.CreateFrom);
            }
            if (content.Contains("ValidationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IValidationInputRequestInternal)this).ValidationType = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ValidationInputDiscriminator) content.GetValueForProperty("ValidationType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IValidationInputRequestInternal)this).ValidationType, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ValidationInputDiscriminator.CreateFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.CreateOrderLimitForSubscriptionValidationRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal CreateOrderLimitForSubscriptionValidationRequest(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DeviceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ICreateOrderLimitForSubscriptionValidationRequestInternal)this).DeviceType = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.SkuName) content.GetValueForProperty("DeviceType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ICreateOrderLimitForSubscriptionValidationRequestInternal)this).DeviceType, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.SkuName.CreateFrom);
            }
            if (content.Contains("Model"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ICreateOrderLimitForSubscriptionValidationRequestInternal)this).Model = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ModelName?) content.GetValueForProperty("Model",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ICreateOrderLimitForSubscriptionValidationRequestInternal)this).Model, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ModelName.CreateFrom);
            }
            if (content.Contains("ValidationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IValidationInputRequestInternal)this).ValidationType = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ValidationInputDiscriminator) content.GetValueForProperty("ValidationType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IValidationInputRequestInternal)this).ValidationType, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ValidationInputDiscriminator.CreateFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.CreateOrderLimitForSubscriptionValidationRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ICreateOrderLimitForSubscriptionValidationRequest"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ICreateOrderLimitForSubscriptionValidationRequest DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new CreateOrderLimitForSubscriptionValidationRequest(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.CreateOrderLimitForSubscriptionValidationRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ICreateOrderLimitForSubscriptionValidationRequest"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ICreateOrderLimitForSubscriptionValidationRequest DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new CreateOrderLimitForSubscriptionValidationRequest(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="CreateOrderLimitForSubscriptionValidationRequest" />, deserializing the content from
        /// a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="CreateOrderLimitForSubscriptionValidationRequest" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ICreateOrderLimitForSubscriptionValidationRequest FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Request to validate create order limit for current subscription.
    [System.ComponentModel.TypeConverter(typeof(CreateOrderLimitForSubscriptionValidationRequestTypeConverter))]
    public partial interface ICreateOrderLimitForSubscriptionValidationRequest

    {

    }
}