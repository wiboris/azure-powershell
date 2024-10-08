// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Models.Api20230401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Runtime.Extensions;

    /// <summary>The response from the List SAP monitors operation.</summary>
    public partial class MonitorListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Models.Api20230401.IMonitorListResult,
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Models.Api20230401.IMonitorListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The URL to get the next set of SAP monitors.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Models.Api20230401.IMonitor[] _value;

        /// <summary>The list of SAP monitors.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Models.Api20230401.IMonitor[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="MonitorListResult" /> instance.</summary>
        public MonitorListResult()
        {

        }
    }
    /// The response from the List SAP monitors operation.
    public partial interface IMonitorListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Runtime.IJsonSerializable
    {
        /// <summary>The URL to get the next set of SAP monitors.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The URL to get the next set of SAP monitors.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The list of SAP monitors.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of SAP monitors.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Models.Api20230401.IMonitor) })]
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Models.Api20230401.IMonitor[] Value { get; set; }

    }
    /// The response from the List SAP monitors operation.
    internal partial interface IMonitorListResultInternal

    {
        /// <summary>The URL to get the next set of SAP monitors.</summary>
        string NextLink { get; set; }
        /// <summary>The list of SAP monitors.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Models.Api20230401.IMonitor[] Value { get; set; }

    }
}