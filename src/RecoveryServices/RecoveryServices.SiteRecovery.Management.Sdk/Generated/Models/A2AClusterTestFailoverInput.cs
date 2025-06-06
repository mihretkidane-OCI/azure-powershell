// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System.Linq;

    /// <summary>
    /// A2A provider specific input for test cluster failover.
    /// </summary>
    [Newtonsoft.Json.JsonObject("A2A")]
    public partial class A2AClusterTestFailoverInput : ClusterTestFailoverProviderSpecificInput
    {
        /// <summary>
        /// Initializes a new instance of the A2AClusterTestFailoverInput class.
        /// </summary>
        public A2AClusterTestFailoverInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the A2AClusterTestFailoverInput class.
        /// </summary>

        /// <param name="clusterRecoveryPointId">The cluster recovery point id to be passed to failover to a particular
        /// recovery point.
        /// </param>

        /// <param name="individualNodeRecoveryPoints">The list of individual node recovery points.
        /// </param>
        public A2AClusterTestFailoverInput(string clusterRecoveryPointId = default(string), System.Collections.Generic.IList<string> individualNodeRecoveryPoints = default(System.Collections.Generic.IList<string>))

        {
            this.ClusterRecoveryPointId = clusterRecoveryPointId;
            this.IndividualNodeRecoveryPoints = individualNodeRecoveryPoints;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the cluster recovery point id to be passed to failover to a
        /// particular recovery point.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "clusterRecoveryPointId")]
        public string ClusterRecoveryPointId {get; set; }

        /// <summary>
        /// Gets or sets the list of individual node recovery points.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "individualNodeRecoveryPoints")]
        public System.Collections.Generic.IList<string> IndividualNodeRecoveryPoints {get; set; }
    }
}