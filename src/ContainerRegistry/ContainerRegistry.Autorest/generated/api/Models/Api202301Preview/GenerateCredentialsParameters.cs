// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Extensions;

    /// <summary>
    /// The parameters used to generate credentials for a specified token or user of a container registry.
    /// </summary>
    public partial class GenerateCredentialsParameters :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IGenerateCredentialsParameters,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IGenerateCredentialsParametersInternal
    {

        /// <summary>Backing field for <see cref="Expiry" /> property.</summary>
        private global::System.DateTime? _expiry;

        /// <summary>
        /// The expiry date of the generated credentials after which the credentials become invalid.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public global::System.DateTime? Expiry { get => this._expiry; set => this._expiry = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TokenPasswordName? _name;

        /// <summary>
        /// Specifies name of the password which should be regenerated if any -- password1 or password2.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TokenPasswordName? Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="TokenId" /> property.</summary>
        private string _tokenId;

        /// <summary>The resource ID of the token for which credentials have to be generated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string TokenId { get => this._tokenId; set => this._tokenId = value; }

        /// <summary>Creates an new <see cref="GenerateCredentialsParameters" /> instance.</summary>
        public GenerateCredentialsParameters()
        {

        }
    }
    /// The parameters used to generate credentials for a specified token or user of a container registry.
    public partial interface IGenerateCredentialsParameters :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The expiry date of the generated credentials after which the credentials become invalid.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The expiry date of the generated credentials after which the credentials become invalid.",
        SerializedName = @"expiry",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? Expiry { get; set; }
        /// <summary>
        /// Specifies name of the password which should be regenerated if any -- password1 or password2.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies name of the password which should be regenerated if any -- password1 or password2.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TokenPasswordName) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TokenPasswordName? Name { get; set; }
        /// <summary>The resource ID of the token for which credentials have to be generated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource ID of the token for which credentials have to be generated.",
        SerializedName = @"tokenId",
        PossibleTypes = new [] { typeof(string) })]
        string TokenId { get; set; }

    }
    /// The parameters used to generate credentials for a specified token or user of a container registry.
    internal partial interface IGenerateCredentialsParametersInternal

    {
        /// <summary>
        /// The expiry date of the generated credentials after which the credentials become invalid.
        /// </summary>
        global::System.DateTime? Expiry { get; set; }
        /// <summary>
        /// Specifies name of the password which should be regenerated if any -- password1 or password2.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TokenPasswordName? Name { get; set; }
        /// <summary>The resource ID of the token for which credentials have to be generated.</summary>
        string TokenId { get; set; }

    }
}