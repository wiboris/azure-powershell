// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Extensions;

    public partial class ResourceIdListResultValueItem :
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IResourceIdListResultValueItem,
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.IResourceIdListResultValueItemInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The Azure Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Creates an new <see cref="ResourceIdListResultValueItem" /> instance.</summary>
        public ResourceIdListResultValueItem()
        {

        }
    }
    public partial interface IResourceIdListResultValueItem :
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.IJsonSerializable
    {
        /// <summary>The Azure Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Azure Resource ID.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

    }
    internal partial interface IResourceIdListResultValueItemInternal

    {
        /// <summary>The Azure Resource ID.</summary>
        string Id { get; set; }

    }
}