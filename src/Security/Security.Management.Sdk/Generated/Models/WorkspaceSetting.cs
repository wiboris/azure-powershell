// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Security.Models
{
    using System.Linq;

    /// <summary>
    /// Configures where to store the OMS agent data for workspaces under a scope
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class WorkspaceSetting : Resource
    {
        /// <summary>
        /// Initializes a new instance of the WorkspaceSetting class.
        /// </summary>
        public WorkspaceSetting()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkspaceSetting class.
        /// </summary>

        /// <param name="id">Resource Id
        /// </param>

        /// <param name="name">Resource name
        /// </param>

        /// <param name="type">Resource type
        /// </param>

        /// <param name="workspaceId">The full Azure ID of the workspace to save the data in
        /// </param>

        /// <param name="scope">All the VMs in this scope will send their security data to the mentioned
        /// workspace unless overridden by a setting with more specific scope
        /// </param>
        public WorkspaceSetting(string id = default(string), string name = default(string), string type = default(string), string workspaceId = default(string), string scope = default(string))

        : base(id, name, type)
        {
            this.WorkspaceId = workspaceId;
            this.Scope = scope;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the full Azure ID of the workspace to save the data in
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.workspaceId")]
        public string WorkspaceId {get; set; }

        /// <summary>
        /// Gets or sets all the VMs in this scope will send their security data to the
        /// mentioned workspace unless overridden by a setting with more specific scope
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.scope")]
        public string Scope {get; set; }
    }
}