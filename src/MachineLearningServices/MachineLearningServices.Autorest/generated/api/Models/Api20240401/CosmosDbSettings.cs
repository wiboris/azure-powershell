// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    public partial class CosmosDbSettings :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ICosmosDbSettings,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ICosmosDbSettingsInternal
    {

        /// <summary>Backing field for <see cref="CollectionsThroughput" /> property.</summary>
        private int? _collectionsThroughput;

        /// <summary>The throughput of the collections in cosmosdb database</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public int? CollectionsThroughput { get => this._collectionsThroughput; set => this._collectionsThroughput = value; }

        /// <summary>Creates an new <see cref="CosmosDbSettings" /> instance.</summary>
        public CosmosDbSettings()
        {

        }
    }
    public partial interface ICosmosDbSettings :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable
    {
        /// <summary>The throughput of the collections in cosmosdb database</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The throughput of the collections in cosmosdb database",
        SerializedName = @"collectionsThroughput",
        PossibleTypes = new [] { typeof(int) })]
        int? CollectionsThroughput { get; set; }

    }
    internal partial interface ICosmosDbSettingsInternal

    {
        /// <summary>The throughput of the collections in cosmosdb database</summary>
        int? CollectionsThroughput { get; set; }

    }
}