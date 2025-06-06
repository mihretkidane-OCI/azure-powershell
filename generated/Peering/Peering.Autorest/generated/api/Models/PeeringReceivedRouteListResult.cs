// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Peering.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Extensions;

    /// <summary>The paginated list of received routes for the peering.</summary>
    public partial class PeeringReceivedRouteListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringReceivedRouteListResult,
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringReceivedRouteListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to fetch the next page of received routes for the peering.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringReceivedRoute> _value;

        /// <summary>The list of received routes for the peering.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringReceivedRoute> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="PeeringReceivedRouteListResult" /> instance.</summary>
        public PeeringReceivedRouteListResult()
        {

        }
    }
    /// The paginated list of received routes for the peering.
    public partial interface IPeeringReceivedRouteListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.IJsonSerializable
    {
        /// <summary>The link to fetch the next page of received routes for the peering.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The link to fetch the next page of received routes for the peering.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The list of received routes for the peering.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of received routes for the peering.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringReceivedRoute) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringReceivedRoute> Value { get; set; }

    }
    /// The paginated list of received routes for the peering.
    internal partial interface IPeeringReceivedRouteListResultInternal

    {
        /// <summary>The link to fetch the next page of received routes for the peering.</summary>
        string NextLink { get; set; }
        /// <summary>The list of received routes for the peering.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringReceivedRoute> Value { get; set; }

    }
}