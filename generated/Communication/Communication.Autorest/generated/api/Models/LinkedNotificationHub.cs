// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Communication.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Communication.Runtime.Extensions;

    /// <summary>A notification hub that has been linked to the communication service</summary>
    public partial class LinkedNotificationHub :
        Microsoft.Azure.PowerShell.Cmdlets.Communication.Models.ILinkedNotificationHub,
        Microsoft.Azure.PowerShell.Cmdlets.Communication.Models.ILinkedNotificationHubInternal
    {

        /// <summary>Backing field for <see cref="ResourceId" /> property.</summary>
        private string _resourceId;

        /// <summary>The resource ID of the notification hub</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Communication.Origin(Microsoft.Azure.PowerShell.Cmdlets.Communication.PropertyOrigin.Owned)]
        public string ResourceId { get => this._resourceId; set => this._resourceId = value; }

        /// <summary>Creates an new <see cref="LinkedNotificationHub" /> instance.</summary>
        public LinkedNotificationHub()
        {

        }
    }
    /// A notification hub that has been linked to the communication service
    public partial interface ILinkedNotificationHub :
        Microsoft.Azure.PowerShell.Cmdlets.Communication.Runtime.IJsonSerializable
    {
        /// <summary>The resource ID of the notification hub</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Communication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The resource ID of the notification hub",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceId { get; set; }

    }
    /// A notification hub that has been linked to the communication service
    internal partial interface ILinkedNotificationHubInternal

    {
        /// <summary>The resource ID of the notification hub</summary>
        string ResourceId { get; set; }

    }
}