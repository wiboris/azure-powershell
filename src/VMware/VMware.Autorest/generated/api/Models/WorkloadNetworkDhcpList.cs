// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.VMware.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Extensions;

    /// <summary>The response of a WorkloadNetworkDhcp list operation.</summary>
    public partial class WorkloadNetworkDhcpList :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IWorkloadNetworkDhcpList,
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IWorkloadNetworkDhcpListInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IWorkloadNetworkDhcp> _value;

        /// <summary>The WorkloadNetworkDhcp items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IWorkloadNetworkDhcp> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="WorkloadNetworkDhcpList" /> instance.</summary>
        public WorkloadNetworkDhcpList()
        {

        }
    }
    /// The response of a WorkloadNetworkDhcp list operation.
    public partial interface IWorkloadNetworkDhcpList :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IJsonSerializable
    {
        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The link to the next page of items",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The WorkloadNetworkDhcp items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The WorkloadNetworkDhcp items on this page",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IWorkloadNetworkDhcp) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IWorkloadNetworkDhcp> Value { get; set; }

    }
    /// The response of a WorkloadNetworkDhcp list operation.
    internal partial interface IWorkloadNetworkDhcpListInternal

    {
        /// <summary>The link to the next page of items</summary>
        string NextLink { get; set; }
        /// <summary>The WorkloadNetworkDhcp items on this page</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IWorkloadNetworkDhcp> Value { get; set; }

    }
}