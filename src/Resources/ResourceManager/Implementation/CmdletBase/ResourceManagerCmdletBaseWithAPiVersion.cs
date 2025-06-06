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

using System.Management.Automation;

namespace Microsoft.Azure.Commands.ResourceManager.Cmdlets.Implementation
{
    public abstract class ResourceManagerCmdletBaseWithApiVersion : ResourceManagerCmdletBase
    {
        /// <summary>
        /// Gets or sets the API version.
        /// </summary>
        [Parameter(Mandatory = false, HelpMessage = "When set, indicates the version of the resource provider API to use. If not specified, the API version is automatically determined as the latest available.")]
        [ValidateNotNullOrEmpty]
        public virtual string ApiVersion { get; set; }

        /// <summary>
        /// Determines the API version.
        /// </summary>
        /// <param name="resourceId">The resource Id.</param>
        protected string DetermineApiVersion(string resourceId)
        {
            if (!string.IsNullOrWhiteSpace(ApiVersion))
                return ApiVersion;

            return Components.ApiVersionHelper.DetermineApiVersion(DefaultContext, resourceId, Pre);
        }

        /// <summary>
        /// Determines the API version.
        /// </summary>
        /// <param name="providerNamespace">The provider namespace.</param>
        /// <param name="resourceType">The resource type.</param>
        protected string DetermineApiVersion(string providerNamespace, string resourceType)
        {
            if (!string.IsNullOrWhiteSpace(ApiVersion))
                return ApiVersion;

            return Components.ApiVersionHelper.DetermineApiVersion(DefaultContext, providerNamespace, resourceType, Pre);
        }
    }
}
