// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using System.Linq;

    /// <summary>
    /// File server write settings.
    /// </summary>
    [Newtonsoft.Json.JsonObject("FileServerWriteSettings")]
    public partial class FileServerWriteSettings : StoreWriteSettings
    {
        /// <summary>
        /// Initializes a new instance of the FileServerWriteSettings class.
        /// </summary>
        public FileServerWriteSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FileServerWriteSettings class.
        /// </summary>

        /// <param name="additionalProperties">Connector write settings.
        /// </param>

        /// <param name="maxConcurrentConnections">The maximum concurrent connection count for the source data store. Type:
        /// integer (or Expression with resultType integer).
        /// </param>

        /// <param name="disableMetricsCollection">If true, disable data store metrics collection. Default is false. Type:
        /// boolean (or Expression with resultType boolean).
        /// </param>

        /// <param name="copyBehavior">The type of copy behavior for copy sink.
        /// </param>

        /// <param name="metadata">Specify the custom metadata to be added to sink data. Type: array of
        /// objects (or Expression with resultType array of objects).
        /// </param>
        public FileServerWriteSettings(System.Collections.Generic.IDictionary<string, object> additionalProperties = default(System.Collections.Generic.IDictionary<string, object>), object maxConcurrentConnections = default(object), object disableMetricsCollection = default(object), object copyBehavior = default(object), System.Collections.Generic.IList<MetadataItem> metadata = default(System.Collections.Generic.IList<MetadataItem>))

        : base(additionalProperties, maxConcurrentConnections, disableMetricsCollection, copyBehavior, metadata)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}