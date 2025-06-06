﻿// ----------------------------------------------------------------------------------
// 
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using System.Management.Automation;
using Microsoft.Azure.Commands.RecoveryServices.SiteRecovery.Properties;

namespace Microsoft.Azure.Commands.RecoveryServices.SiteRecovery
{
    /// <summary>
    ///     Deletes the specified Azure Site Recovery Replication Protection Cluster.
    /// </summary>
    [Cmdlet("Remove", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "RecoveryServicesAsrReplicationProtectionCluster", DefaultParameterSetName = ASRParameterSets.ByObject, SupportsShouldProcess = true)]
    [Alias("Remove-ASRReplicationProtectionCluster")]
    [OutputType(typeof(ASRJob))]
    public class RemoveAzureRmRecoveryServicesAsrReplicationProtectionCluster : SiteRecoveryCmdletBase
    {
        #region Parameters

        /// <summary>
        /// Gets or sets the protection cluster to be removed.
        /// </summary>
        [Parameter(ParameterSetName = ASRParameterSets.ByObject, Mandatory = true, ValueFromPipeline = true)]
        [ValidateNotNullOrEmpty]
        [Alias("ReplicationProtectionCluster")]
        public ASRReplicationProtectionCluster InputObject { get; set; }

        #endregion Parameters

        /// <summary>
        /// ProcessRecord of the command.
        /// </summary>
        public override void ExecuteSiteRecoveryCmdlet()
        {
            base.ExecuteSiteRecoveryCmdlet();

            if (this.ShouldProcess(this.InputObject.Name, VerbsCommon.Remove))
            {
                var protectionCluster =
                    this.RecoveryServicesClient.GetAzureSiteRecoveryReplicationProtectionCluster(
                        Utilities.GetValueFromArmId(this.InputObject.ID, ARMResourceTypeConstants.ReplicationFabrics),
                        Utilities.GetValueFromArmId(this.InputObject.ID, ARMResourceTypeConstants.ReplicationProtectionContainers),
                        this.InputObject.Name);
                if (protectionCluster == null)
                {
                    throw new Exception(
                        string.Format(
                            Resources.ProtectionClusterNotFound,
                            this.InputObject.Name,
                            PSRecoveryServicesClient.asrVaultCreds.ResourceName));
                }

                var response = this.RecoveryServicesClient.RemoveAzureSiteRecoveryReplicationProtectionCluster(
                    Utilities.GetValueFromArmId(this.InputObject.ID, ARMResourceTypeConstants.ReplicationFabrics),
                    Utilities.GetValueFromArmId(this.InputObject.ID, ARMResourceTypeConstants.ReplicationProtectionContainers),
                    protectionCluster.Name);

                var jobResponse = this.RecoveryServicesClient.GetAzureSiteRecoveryJobDetails(
                    PSRecoveryServicesClient.GetJobIdFromReponseLocation(response.Location));

                this.WriteObject(new ASRJob(jobResponse));
            }
        }
    }
}
