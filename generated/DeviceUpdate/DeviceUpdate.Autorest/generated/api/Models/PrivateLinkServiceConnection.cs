// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Extensions;

    /// <summary>Private link service connection details.</summary>
    public partial class PrivateLinkServiceConnection :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IPrivateLinkServiceConnection,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IPrivateLinkServiceConnectionInternal
    {

        /// <summary>Backing field for <see cref="GroupId" /> property.</summary>
        private System.Collections.Generic.List<string> _groupId;

        /// <summary>List of group IDs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> GroupId { get => this._groupId; set => this._groupId = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Private link service connection name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="RequestMessage" /> property.</summary>
        private string _requestMessage;

        /// <summary>Request message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Owned)]
        public string RequestMessage { get => this._requestMessage; set => this._requestMessage = value; }

        /// <summary>Creates an new <see cref="PrivateLinkServiceConnection" /> instance.</summary>
        public PrivateLinkServiceConnection()
        {

        }
    }
    /// Private link service connection details.
    public partial interface IPrivateLinkServiceConnection :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.IJsonSerializable
    {
        /// <summary>List of group IDs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of group IDs.",
        SerializedName = @"groupIds",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> GroupId { get; set; }
        /// <summary>Private link service connection name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Private link service connection name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Request message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Request message.",
        SerializedName = @"requestMessage",
        PossibleTypes = new [] { typeof(string) })]
        string RequestMessage { get; set; }

    }
    /// Private link service connection details.
    internal partial interface IPrivateLinkServiceConnectionInternal

    {
        /// <summary>List of group IDs.</summary>
        System.Collections.Generic.List<string> GroupId { get; set; }
        /// <summary>Private link service connection name.</summary>
        string Name { get; set; }
        /// <summary>Request message.</summary>
        string RequestMessage { get; set; }

    }
}