// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Extensions;

    public partial class OperationsPutContent :
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IOperationsPutContent,
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IOperationsPutContentInternal
    {

        /// <summary>Backing field for <see cref="Content" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IOperationsDefinition> _content;

        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IOperationsDefinition> Content { get => this._content; set => this._content = value; }

        /// <summary>Creates an new <see cref="OperationsPutContent" /> instance.</summary>
        public OperationsPutContent()
        {

        }
    }
    public partial interface IOperationsPutContent :
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"contents",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IOperationsDefinition) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IOperationsDefinition> Content { get; set; }

    }
    internal partial interface IOperationsPutContentInternal

    {
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.IOperationsDefinition> Content { get; set; }

    }
}