// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using System.Linq;

    /// <summary>
    /// A Rest service dataset.
    /// </summary>
    [Newtonsoft.Json.JsonObject("RestResource")]
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class RestResourceDataset : Dataset
    {
        /// <summary>
        /// Initializes a new instance of the RestResourceDataset class.
        /// </summary>
        public RestResourceDataset()
        {
            this.LinkedServiceName = new LinkedServiceReference();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RestResourceDataset class.
        /// </summary>

        /// <param name="additionalProperties">The Azure Data Factory nested object which identifies data within different
        /// data stores, such as tables, files, folders, and documents.
        /// </param>

        /// <param name="description">Dataset description.
        /// </param>

        /// <param name="structure">Columns that define the structure of the dataset. Type: array (or
        /// Expression with resultType array), itemType: DatasetDataElement.
        /// </param>

        /// <param name="schema">Columns that define the physical type schema of the dataset. Type: array
        /// (or Expression with resultType array), itemType: DatasetSchemaDataElement.
        /// </param>

        /// <param name="linkedServiceName">Linked service reference.
        /// </param>

        /// <param name="parameters">Parameters for dataset.
        /// </param>

        /// <param name="annotations">List of tags that can be used for describing the Dataset.
        /// </param>

        /// <param name="folder">The folder that this Dataset is in. If not specified, Dataset will appear
        /// at the root level.
        /// </param>

        /// <param name="relativeUrl">The relative URL to the resource that the RESTful API provides. Type:
        /// string (or Expression with resultType string).
        /// </param>

        /// <param name="requestMethod">The HTTP method used to call the RESTful API. The default is GET. Type:
        /// string (or Expression with resultType string).
        /// </param>

        /// <param name="requestBody">The HTTP request body to the RESTful API if requestMethod is POST. Type:
        /// string (or Expression with resultType string).
        /// </param>

        /// <param name="additionalHeaders">The additional HTTP headers in the request to the RESTful API.
        /// </param>

        /// <param name="paginationRules">The pagination rules to compose next page requests.
        /// </param>
        public RestResourceDataset(LinkedServiceReference linkedServiceName, System.Collections.Generic.IDictionary<string, object> additionalProperties = default(System.Collections.Generic.IDictionary<string, object>), string description = default(string), object structure = default(object), object schema = default(object), System.Collections.Generic.IDictionary<string, ParameterSpecification> parameters = default(System.Collections.Generic.IDictionary<string, ParameterSpecification>), System.Collections.Generic.IList<object> annotations = default(System.Collections.Generic.IList<object>), DatasetFolder folder = default(DatasetFolder), object relativeUrl = default(object), object requestMethod = default(object), object requestBody = default(object), System.Collections.Generic.IDictionary<string, object> additionalHeaders = default(System.Collections.Generic.IDictionary<string, object>), System.Collections.Generic.IDictionary<string, object> paginationRules = default(System.Collections.Generic.IDictionary<string, object>))

        : base(linkedServiceName, additionalProperties, description, structure, schema, parameters, annotations, folder)
        {
            this.RelativeUrl = relativeUrl;
            this.RequestMethod = requestMethod;
            this.RequestBody = requestBody;
            this.AdditionalHeaders = additionalHeaders;
            this.PaginationRules = paginationRules;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the relative URL to the resource that the RESTful API
        /// provides. Type: string (or Expression with resultType string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.relativeUrl")]
        public object RelativeUrl {get; set; }

        /// <summary>
        /// Gets or sets the HTTP method used to call the RESTful API. The default is
        /// GET. Type: string (or Expression with resultType string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.requestMethod")]
        public object RequestMethod {get; set; }

        /// <summary>
        /// Gets or sets the HTTP request body to the RESTful API if requestMethod is
        /// POST. Type: string (or Expression with resultType string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.requestBody")]
        public object RequestBody {get; set; }

        /// <summary>
        /// Gets or sets the additional HTTP headers in the request to the RESTful API.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.additionalHeaders")]
        public System.Collections.Generic.IDictionary<string, object> AdditionalHeaders {get; set; }

        /// <summary>
        /// Gets or sets the pagination rules to compose next page requests.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.paginationRules")]
        public System.Collections.Generic.IDictionary<string, object> PaginationRules {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();





        }
    }
}