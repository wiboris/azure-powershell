// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20230701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Extensions;

    /// <summary>
    /// AgentPoolPatchProperties represents the properties of an agent pool that can be modified.
    /// </summary>
    public partial class AgentPoolPatchProperties :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20230701.IAgentPoolPatchProperties,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20230701.IAgentPoolPatchPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Count" /> property.</summary>
        private long? _count;

        /// <summary>The number of virtual machines that use this configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public long? Count { get => this._count; set => this._count = value; }

        /// <summary>Internal Acessors for UpgradeSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20230701.IAgentPoolUpgradeSettings Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20230701.IAgentPoolPatchPropertiesInternal.UpgradeSetting { get => (this._upgradeSetting = this._upgradeSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20230701.AgentPoolUpgradeSettings()); set { {_upgradeSetting = value;} } }

        /// <summary>Backing field for <see cref="UpgradeSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20230701.IAgentPoolUpgradeSettings _upgradeSetting;

        /// <summary>The configuration of the agent pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20230701.IAgentPoolUpgradeSettings UpgradeSetting { get => (this._upgradeSetting = this._upgradeSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20230701.AgentPoolUpgradeSettings()); set => this._upgradeSetting = value; }

        /// <summary>
        /// The maximum number or percentage of nodes that are surged during upgrade. This can either be set to an integer (e.g. '5')
        /// or a percentage (e.g. '50%'). If a percentage is specified, it is the percentage of the total agent pool size at the time
        /// of the upgrade. For percentages, fractional nodes are rounded up. If not specified, the default is 1.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Inlined)]
        public string UpgradeSettingMaxSurge { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20230701.IAgentPoolUpgradeSettingsInternal)UpgradeSetting).MaxSurge; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20230701.IAgentPoolUpgradeSettingsInternal)UpgradeSetting).MaxSurge = value ?? null; }

        /// <summary>Creates an new <see cref="AgentPoolPatchProperties" /> instance.</summary>
        public AgentPoolPatchProperties()
        {

        }
    }
    /// AgentPoolPatchProperties represents the properties of an agent pool that can be modified.
    public partial interface IAgentPoolPatchProperties :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.IJsonSerializable
    {
        /// <summary>The number of virtual machines that use this configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of virtual machines that use this configuration.",
        SerializedName = @"count",
        PossibleTypes = new [] { typeof(long) })]
        long? Count { get; set; }
        /// <summary>
        /// The maximum number or percentage of nodes that are surged during upgrade. This can either be set to an integer (e.g. '5')
        /// or a percentage (e.g. '50%'). If a percentage is specified, it is the percentage of the total agent pool size at the time
        /// of the upgrade. For percentages, fractional nodes are rounded up. If not specified, the default is 1.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The maximum number or percentage of nodes that are surged during upgrade. This can either be set to an integer (e.g. '5') or a percentage (e.g. '50%'). If a percentage is specified, it is the percentage of the total agent pool size at the time of the upgrade. For percentages, fractional nodes are rounded up. If not specified, the default is 1.",
        SerializedName = @"maxSurge",
        PossibleTypes = new [] { typeof(string) })]
        string UpgradeSettingMaxSurge { get; set; }

    }
    /// AgentPoolPatchProperties represents the properties of an agent pool that can be modified.
    internal partial interface IAgentPoolPatchPropertiesInternal

    {
        /// <summary>The number of virtual machines that use this configuration.</summary>
        long? Count { get; set; }
        /// <summary>The configuration of the agent pool.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20230701.IAgentPoolUpgradeSettings UpgradeSetting { get; set; }
        /// <summary>
        /// The maximum number or percentage of nodes that are surged during upgrade. This can either be set to an integer (e.g. '5')
        /// or a percentage (e.g. '50%'). If a percentage is specified, it is the percentage of the total agent pool size at the time
        /// of the upgrade. For percentages, fractional nodes are rounded up. If not specified, the default is 1.
        /// </summary>
        string UpgradeSettingMaxSurge { get; set; }

    }
}