// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.PowerShell;

    /// <summary>AFDOrigin group properties needed for origin group creation or update.</summary>
    [System.ComponentModel.TypeConverter(typeof(AfdOriginGroupUpdateParametersTypeConverter))]
    public partial class AfdOriginGroupUpdateParameters
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
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.AfdOriginGroupUpdateParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AfdOriginGroupUpdateParameters(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdOriginGroupUpdateParametersInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdOriginGroupUpdatePropertiesParameters) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdOriginGroupUpdateParametersInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.AfdOriginGroupUpdatePropertiesParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProfileName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdOriginGroupUpdateParametersInternal)this).ProfileName = (string) content.GetValueForProperty("ProfileName",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdOriginGroupUpdateParametersInternal)this).ProfileName, global::System.Convert.ToString);
            }
            if (content.Contains("LoadBalancingSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdOriginGroupUpdateParametersInternal)this).LoadBalancingSetting = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ILoadBalancingSettingsParameters) content.GetValueForProperty("LoadBalancingSetting",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdOriginGroupUpdateParametersInternal)this).LoadBalancingSetting, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.LoadBalancingSettingsParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("HealthProbeSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdOriginGroupUpdateParametersInternal)this).HealthProbeSetting = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IHealthProbeParameters) content.GetValueForProperty("HealthProbeSetting",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdOriginGroupUpdateParametersInternal)this).HealthProbeSetting, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.HealthProbeParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("TrafficRestorationTimeToHealedOrNewEndpointsInMinute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdOriginGroupUpdateParametersInternal)this).TrafficRestorationTimeToHealedOrNewEndpointsInMinute = (int?) content.GetValueForProperty("TrafficRestorationTimeToHealedOrNewEndpointsInMinute",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdOriginGroupUpdateParametersInternal)this).TrafficRestorationTimeToHealedOrNewEndpointsInMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SessionAffinityState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdOriginGroupUpdateParametersInternal)this).SessionAffinityState = (string) content.GetValueForProperty("SessionAffinityState",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdOriginGroupUpdateParametersInternal)this).SessionAffinityState, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.AfdOriginGroupUpdateParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AfdOriginGroupUpdateParameters(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdOriginGroupUpdateParametersInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdOriginGroupUpdatePropertiesParameters) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdOriginGroupUpdateParametersInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.AfdOriginGroupUpdatePropertiesParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProfileName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdOriginGroupUpdateParametersInternal)this).ProfileName = (string) content.GetValueForProperty("ProfileName",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdOriginGroupUpdateParametersInternal)this).ProfileName, global::System.Convert.ToString);
            }
            if (content.Contains("LoadBalancingSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdOriginGroupUpdateParametersInternal)this).LoadBalancingSetting = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ILoadBalancingSettingsParameters) content.GetValueForProperty("LoadBalancingSetting",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdOriginGroupUpdateParametersInternal)this).LoadBalancingSetting, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.LoadBalancingSettingsParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("HealthProbeSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdOriginGroupUpdateParametersInternal)this).HealthProbeSetting = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IHealthProbeParameters) content.GetValueForProperty("HealthProbeSetting",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdOriginGroupUpdateParametersInternal)this).HealthProbeSetting, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.HealthProbeParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("TrafficRestorationTimeToHealedOrNewEndpointsInMinute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdOriginGroupUpdateParametersInternal)this).TrafficRestorationTimeToHealedOrNewEndpointsInMinute = (int?) content.GetValueForProperty("TrafficRestorationTimeToHealedOrNewEndpointsInMinute",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdOriginGroupUpdateParametersInternal)this).TrafficRestorationTimeToHealedOrNewEndpointsInMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SessionAffinityState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdOriginGroupUpdateParametersInternal)this).SessionAffinityState = (string) content.GetValueForProperty("SessionAffinityState",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdOriginGroupUpdateParametersInternal)this).SessionAffinityState, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.AfdOriginGroupUpdateParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdOriginGroupUpdateParameters" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdOriginGroupUpdateParameters DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AfdOriginGroupUpdateParameters(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.AfdOriginGroupUpdateParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdOriginGroupUpdateParameters" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdOriginGroupUpdateParameters DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AfdOriginGroupUpdateParameters(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AfdOriginGroupUpdateParameters" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="AfdOriginGroupUpdateParameters" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdOriginGroupUpdateParameters FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// AFDOrigin group properties needed for origin group creation or update.
    [System.ComponentModel.TypeConverter(typeof(AfdOriginGroupUpdateParametersTypeConverter))]
    public partial interface IAfdOriginGroupUpdateParameters

    {

    }
}