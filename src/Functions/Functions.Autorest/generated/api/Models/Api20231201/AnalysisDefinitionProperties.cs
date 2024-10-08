// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Extensions;

    /// <summary>AnalysisDefinition resource specific properties</summary>
    public partial class AnalysisDefinitionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IAnalysisDefinitionProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IAnalysisDefinitionPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>Description of the Analysis</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public string Description { get => this._description; }

        /// <summary>Internal Acessors for Description</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IAnalysisDefinitionPropertiesInternal.Description { get => this._description; set { {_description = value;} } }

        /// <summary>Creates an new <see cref="AnalysisDefinitionProperties" /> instance.</summary>
        public AnalysisDefinitionProperties()
        {

        }
    }
    /// AnalysisDefinition resource specific properties
    public partial interface IAnalysisDefinitionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IJsonSerializable
    {
        /// <summary>Description of the Analysis</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Description of the Analysis",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get;  }

    }
    /// AnalysisDefinition resource specific properties
    internal partial interface IAnalysisDefinitionPropertiesInternal

    {
        /// <summary>Description of the Analysis</summary>
        string Description { get; set; }

    }
}