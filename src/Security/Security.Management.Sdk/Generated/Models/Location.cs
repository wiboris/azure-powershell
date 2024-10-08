// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Security.Models
{
    using System.Linq;

    /// <summary>
    /// Describes an Azure resource with location
    /// </summary>
    public partial class Location
    {
        /// <summary>
        /// Initializes a new instance of the Location class.
        /// </summary>
        public Location()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Location class.
        /// </summary>

        /// <param name="locationProperty">Location where the resource is stored
        /// </param>
        public Location(string locationProperty = default(string))

        {
            this.LocationProperty = locationProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets location where the resource is stored
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "location")]
        public string LocationProperty {get; private set; }
    }
}