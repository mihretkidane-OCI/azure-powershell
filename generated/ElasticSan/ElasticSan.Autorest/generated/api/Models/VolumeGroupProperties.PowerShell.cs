// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.PowerShell;

    /// <summary>VolumeGroup response properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(VolumeGroupPropertiesTypeConverter))]
    public partial class VolumeGroupProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.VolumeGroupProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new VolumeGroupProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.VolumeGroupProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new VolumeGroupProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="VolumeGroupProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="VolumeGroupProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.SerializationMode.IncludeAll)?.ToString();

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

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.VolumeGroupProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal VolumeGroupProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("EncryptionProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).EncryptionProperty = (Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IEncryptionProperties) content.GetValueForProperty("EncryptionProperty",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).EncryptionProperty, Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.EncryptionPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("NetworkAcls"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).NetworkAcls = (Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.INetworkRuleSet) content.GetValueForProperty("NetworkAcls",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).NetworkAcls, Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.NetworkRuleSetTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("ProtocolType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).ProtocolType = (string) content.GetValueForProperty("ProtocolType",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).ProtocolType, global::System.Convert.ToString);
            }
            if (content.Contains("Encryption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).Encryption = (string) content.GetValueForProperty("Encryption",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).Encryption, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateEndpointConnection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).PrivateEndpointConnection = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IPrivateEndpointConnection>) content.GetValueForProperty("PrivateEndpointConnection",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).PrivateEndpointConnection, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IPrivateEndpointConnection>(__y, Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.PrivateEndpointConnectionTypeConverter.ConvertFrom));
            }
            if (content.Contains("EnforceDataIntegrityCheckForIscsi"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).EnforceDataIntegrityCheckForIscsi = (bool?) content.GetValueForProperty("EnforceDataIntegrityCheckForIscsi",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).EnforceDataIntegrityCheckForIscsi, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("EncryptionPropertyEncryptionIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).EncryptionPropertyEncryptionIdentity = (Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IEncryptionIdentity) content.GetValueForProperty("EncryptionPropertyEncryptionIdentity",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).EncryptionPropertyEncryptionIdentity, Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.EncryptionIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("EncryptionPropertyKeyVaultProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).EncryptionPropertyKeyVaultProperty = (Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IKeyVaultProperties) content.GetValueForProperty("EncryptionPropertyKeyVaultProperty",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).EncryptionPropertyKeyVaultProperty, Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.KeyVaultPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("KeyVaultPropertyKeyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).KeyVaultPropertyKeyName = (string) content.GetValueForProperty("KeyVaultPropertyKeyName",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).KeyVaultPropertyKeyName, global::System.Convert.ToString);
            }
            if (content.Contains("KeyVaultPropertyKeyVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).KeyVaultPropertyKeyVersion = (string) content.GetValueForProperty("KeyVaultPropertyKeyVersion",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).KeyVaultPropertyKeyVersion, global::System.Convert.ToString);
            }
            if (content.Contains("NetworkAclsVirtualNetworkRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).NetworkAclsVirtualNetworkRule = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVirtualNetworkRule>) content.GetValueForProperty("NetworkAclsVirtualNetworkRule",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).NetworkAclsVirtualNetworkRule, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVirtualNetworkRule>(__y, Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.VirtualNetworkRuleTypeConverter.ConvertFrom));
            }
            if (content.Contains("KeyVaultPropertyKeyVaultUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).KeyVaultPropertyKeyVaultUri = (string) content.GetValueForProperty("KeyVaultPropertyKeyVaultUri",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).KeyVaultPropertyKeyVaultUri, global::System.Convert.ToString);
            }
            if (content.Contains("KeyVaultPropertyCurrentVersionedKeyIdentifier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).KeyVaultPropertyCurrentVersionedKeyIdentifier = (string) content.GetValueForProperty("KeyVaultPropertyCurrentVersionedKeyIdentifier",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).KeyVaultPropertyCurrentVersionedKeyIdentifier, global::System.Convert.ToString);
            }
            if (content.Contains("KeyVaultPropertyLastKeyRotationTimestamp"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).KeyVaultPropertyLastKeyRotationTimestamp = (global::System.DateTime?) content.GetValueForProperty("KeyVaultPropertyLastKeyRotationTimestamp",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).KeyVaultPropertyLastKeyRotationTimestamp, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("KeyVaultPropertyCurrentVersionedKeyExpirationTimestamp"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).KeyVaultPropertyCurrentVersionedKeyExpirationTimestamp = (global::System.DateTime?) content.GetValueForProperty("KeyVaultPropertyCurrentVersionedKeyExpirationTimestamp",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).KeyVaultPropertyCurrentVersionedKeyExpirationTimestamp, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("EncryptionIdentityEncryptionUserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).EncryptionIdentityEncryptionUserAssignedIdentity = (string) content.GetValueForProperty("EncryptionIdentityEncryptionUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).EncryptionIdentityEncryptionUserAssignedIdentity, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.VolumeGroupProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal VolumeGroupProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("EncryptionProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).EncryptionProperty = (Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IEncryptionProperties) content.GetValueForProperty("EncryptionProperty",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).EncryptionProperty, Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.EncryptionPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("NetworkAcls"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).NetworkAcls = (Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.INetworkRuleSet) content.GetValueForProperty("NetworkAcls",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).NetworkAcls, Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.NetworkRuleSetTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("ProtocolType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).ProtocolType = (string) content.GetValueForProperty("ProtocolType",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).ProtocolType, global::System.Convert.ToString);
            }
            if (content.Contains("Encryption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).Encryption = (string) content.GetValueForProperty("Encryption",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).Encryption, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateEndpointConnection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).PrivateEndpointConnection = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IPrivateEndpointConnection>) content.GetValueForProperty("PrivateEndpointConnection",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).PrivateEndpointConnection, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IPrivateEndpointConnection>(__y, Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.PrivateEndpointConnectionTypeConverter.ConvertFrom));
            }
            if (content.Contains("EnforceDataIntegrityCheckForIscsi"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).EnforceDataIntegrityCheckForIscsi = (bool?) content.GetValueForProperty("EnforceDataIntegrityCheckForIscsi",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).EnforceDataIntegrityCheckForIscsi, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("EncryptionPropertyEncryptionIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).EncryptionPropertyEncryptionIdentity = (Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IEncryptionIdentity) content.GetValueForProperty("EncryptionPropertyEncryptionIdentity",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).EncryptionPropertyEncryptionIdentity, Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.EncryptionIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("EncryptionPropertyKeyVaultProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).EncryptionPropertyKeyVaultProperty = (Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IKeyVaultProperties) content.GetValueForProperty("EncryptionPropertyKeyVaultProperty",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).EncryptionPropertyKeyVaultProperty, Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.KeyVaultPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("KeyVaultPropertyKeyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).KeyVaultPropertyKeyName = (string) content.GetValueForProperty("KeyVaultPropertyKeyName",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).KeyVaultPropertyKeyName, global::System.Convert.ToString);
            }
            if (content.Contains("KeyVaultPropertyKeyVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).KeyVaultPropertyKeyVersion = (string) content.GetValueForProperty("KeyVaultPropertyKeyVersion",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).KeyVaultPropertyKeyVersion, global::System.Convert.ToString);
            }
            if (content.Contains("NetworkAclsVirtualNetworkRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).NetworkAclsVirtualNetworkRule = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVirtualNetworkRule>) content.GetValueForProperty("NetworkAclsVirtualNetworkRule",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).NetworkAclsVirtualNetworkRule, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVirtualNetworkRule>(__y, Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.VirtualNetworkRuleTypeConverter.ConvertFrom));
            }
            if (content.Contains("KeyVaultPropertyKeyVaultUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).KeyVaultPropertyKeyVaultUri = (string) content.GetValueForProperty("KeyVaultPropertyKeyVaultUri",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).KeyVaultPropertyKeyVaultUri, global::System.Convert.ToString);
            }
            if (content.Contains("KeyVaultPropertyCurrentVersionedKeyIdentifier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).KeyVaultPropertyCurrentVersionedKeyIdentifier = (string) content.GetValueForProperty("KeyVaultPropertyCurrentVersionedKeyIdentifier",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).KeyVaultPropertyCurrentVersionedKeyIdentifier, global::System.Convert.ToString);
            }
            if (content.Contains("KeyVaultPropertyLastKeyRotationTimestamp"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).KeyVaultPropertyLastKeyRotationTimestamp = (global::System.DateTime?) content.GetValueForProperty("KeyVaultPropertyLastKeyRotationTimestamp",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).KeyVaultPropertyLastKeyRotationTimestamp, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("KeyVaultPropertyCurrentVersionedKeyExpirationTimestamp"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).KeyVaultPropertyCurrentVersionedKeyExpirationTimestamp = (global::System.DateTime?) content.GetValueForProperty("KeyVaultPropertyCurrentVersionedKeyExpirationTimestamp",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).KeyVaultPropertyCurrentVersionedKeyExpirationTimestamp, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("EncryptionIdentityEncryptionUserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).EncryptionIdentityEncryptionUserAssignedIdentity = (string) content.GetValueForProperty("EncryptionIdentityEncryptionUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IVolumeGroupPropertiesInternal)this).EncryptionIdentityEncryptionUserAssignedIdentity, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }
    }
    /// VolumeGroup response properties.
    [System.ComponentModel.TypeConverter(typeof(VolumeGroupPropertiesTypeConverter))]
    public partial interface IVolumeGroupProperties

    {

    }
}