namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.PowerShell;

    /// <summary>InMageRcmFailback provider specific details.</summary>
    [System.ComponentModel.TypeConverter(typeof(InMageRcmFailbackReplicationDetailsTypeConverter))]
    public partial class InMageRcmFailbackReplicationDetails
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmFailbackReplicationDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new InMageRcmFailbackReplicationDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmFailbackReplicationDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new InMageRcmFailbackReplicationDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="InMageRcmFailbackReplicationDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmFailbackReplicationDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal InMageRcmFailbackReplicationDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MobilityAgentDetail = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackMobilityAgentDetails) content.GetValueForProperty("MobilityAgentDetail",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MobilityAgentDetail, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmFailbackMobilityAgentDetailsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).InternalIdentifier = (string) content.GetValueForProperty("InternalIdentifier",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).InternalIdentifier, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).AzureVirtualMachineId = (string) content.GetValueForProperty("AzureVirtualMachineId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).AzureVirtualMachineId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MultiVMGroupName = (string) content.GetValueForProperty("MultiVMGroupName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MultiVMGroupName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).ReprotectAgentId = (string) content.GetValueForProperty("ReprotectAgentId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).ReprotectAgentId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).ReprotectAgentName = (string) content.GetValueForProperty("ReprotectAgentName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).ReprotectAgentName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).OSType = (string) content.GetValueForProperty("OSType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).OSType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).LogStorageAccountId = (string) content.GetValueForProperty("LogStorageAccountId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).LogStorageAccountId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).TargetvCenterId = (string) content.GetValueForProperty("TargetvCenterId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).TargetvCenterId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).TargetDataStoreName = (string) content.GetValueForProperty("TargetDataStoreName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).TargetDataStoreName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).TargetVMName = (string) content.GetValueForProperty("TargetVMName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).TargetVMName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).InitialReplicationProgressPercentage = (int?) content.GetValueForProperty("InitialReplicationProgressPercentage",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).InitialReplicationProgressPercentage, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).InitialReplicationProcessedByte = (long?) content.GetValueForProperty("InitialReplicationProcessedByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).InitialReplicationProcessedByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).InitialReplicationTransferredByte = (long?) content.GetValueForProperty("InitialReplicationTransferredByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).InitialReplicationTransferredByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).InitialReplicationProgressHealth = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.VMReplicationProgressHealth?) content.GetValueForProperty("InitialReplicationProgressHealth",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).InitialReplicationProgressHealth, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.VMReplicationProgressHealth.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).ResyncProgressPercentage = (int?) content.GetValueForProperty("ResyncProgressPercentage",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).ResyncProgressPercentage, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).ResyncProcessedByte = (long?) content.GetValueForProperty("ResyncProcessedByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).ResyncProcessedByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).ResyncTransferredByte = (long?) content.GetValueForProperty("ResyncTransferredByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).ResyncTransferredByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).ResyncProgressHealth = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.VMReplicationProgressHealth?) content.GetValueForProperty("ResyncProgressHealth",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).ResyncProgressHealth, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.VMReplicationProgressHealth.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).ResyncRequired = (string) content.GetValueForProperty("ResyncRequired",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).ResyncRequired, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).ResyncState = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ResyncState?) content.GetValueForProperty("ResyncState",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).ResyncState, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ResyncState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).ProtectedDisk = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetails[]) content.GetValueForProperty("ProtectedDisk",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).ProtectedDisk, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmFailbackProtectedDiskDetailsTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).VMNic = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackNicDetails[]) content.GetValueForProperty("VMNic",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).VMNic, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackNicDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmFailbackNicDetailsTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProviderSpecificSettingsInternal)this).InstanceType = (string) content.GetValueForProperty("InstanceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProviderSpecificSettingsInternal)this).InstanceType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MobilityAgentDetailVersion = (string) content.GetValueForProperty("MobilityAgentDetailVersion",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MobilityAgentDetailVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MobilityAgentDetailLatestVersion = (string) content.GetValueForProperty("MobilityAgentDetailLatestVersion",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MobilityAgentDetailLatestVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MobilityAgentDetailDriverVersion = (string) content.GetValueForProperty("MobilityAgentDetailDriverVersion",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MobilityAgentDetailDriverVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MobilityAgentDetailLatestUpgradableVersionWithoutReboot = (string) content.GetValueForProperty("MobilityAgentDetailLatestUpgradableVersionWithoutReboot",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MobilityAgentDetailLatestUpgradableVersionWithoutReboot, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MobilityAgentDetailAgentVersionExpiryDate = (global::System.DateTime?) content.GetValueForProperty("MobilityAgentDetailAgentVersionExpiryDate",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MobilityAgentDetailAgentVersionExpiryDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MobilityAgentDetailDriverVersionExpiryDate = (global::System.DateTime?) content.GetValueForProperty("MobilityAgentDetailDriverVersionExpiryDate",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MobilityAgentDetailDriverVersionExpiryDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MobilityAgentDetailLastHeartbeatUtc = (global::System.DateTime?) content.GetValueForProperty("MobilityAgentDetailLastHeartbeatUtc",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MobilityAgentDetailLastHeartbeatUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MobilityAgentDetailReasonsBlockingUpgrade = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AgentUpgradeBlockedReason[]) content.GetValueForProperty("MobilityAgentDetailReasonsBlockingUpgrade",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MobilityAgentDetailReasonsBlockingUpgrade, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AgentUpgradeBlockedReason>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AgentUpgradeBlockedReason.CreateFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MobilityAgentDetailIsUpgradeable = (string) content.GetValueForProperty("MobilityAgentDetailIsUpgradeable",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MobilityAgentDetailIsUpgradeable, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmFailbackReplicationDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal InMageRcmFailbackReplicationDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MobilityAgentDetail = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackMobilityAgentDetails) content.GetValueForProperty("MobilityAgentDetail",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MobilityAgentDetail, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmFailbackMobilityAgentDetailsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).InternalIdentifier = (string) content.GetValueForProperty("InternalIdentifier",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).InternalIdentifier, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).AzureVirtualMachineId = (string) content.GetValueForProperty("AzureVirtualMachineId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).AzureVirtualMachineId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MultiVMGroupName = (string) content.GetValueForProperty("MultiVMGroupName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MultiVMGroupName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).ReprotectAgentId = (string) content.GetValueForProperty("ReprotectAgentId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).ReprotectAgentId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).ReprotectAgentName = (string) content.GetValueForProperty("ReprotectAgentName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).ReprotectAgentName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).OSType = (string) content.GetValueForProperty("OSType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).OSType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).LogStorageAccountId = (string) content.GetValueForProperty("LogStorageAccountId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).LogStorageAccountId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).TargetvCenterId = (string) content.GetValueForProperty("TargetvCenterId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).TargetvCenterId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).TargetDataStoreName = (string) content.GetValueForProperty("TargetDataStoreName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).TargetDataStoreName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).TargetVMName = (string) content.GetValueForProperty("TargetVMName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).TargetVMName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).InitialReplicationProgressPercentage = (int?) content.GetValueForProperty("InitialReplicationProgressPercentage",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).InitialReplicationProgressPercentage, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).InitialReplicationProcessedByte = (long?) content.GetValueForProperty("InitialReplicationProcessedByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).InitialReplicationProcessedByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).InitialReplicationTransferredByte = (long?) content.GetValueForProperty("InitialReplicationTransferredByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).InitialReplicationTransferredByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).InitialReplicationProgressHealth = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.VMReplicationProgressHealth?) content.GetValueForProperty("InitialReplicationProgressHealth",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).InitialReplicationProgressHealth, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.VMReplicationProgressHealth.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).ResyncProgressPercentage = (int?) content.GetValueForProperty("ResyncProgressPercentage",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).ResyncProgressPercentage, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).ResyncProcessedByte = (long?) content.GetValueForProperty("ResyncProcessedByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).ResyncProcessedByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).ResyncTransferredByte = (long?) content.GetValueForProperty("ResyncTransferredByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).ResyncTransferredByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).ResyncProgressHealth = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.VMReplicationProgressHealth?) content.GetValueForProperty("ResyncProgressHealth",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).ResyncProgressHealth, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.VMReplicationProgressHealth.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).ResyncRequired = (string) content.GetValueForProperty("ResyncRequired",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).ResyncRequired, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).ResyncState = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ResyncState?) content.GetValueForProperty("ResyncState",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).ResyncState, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ResyncState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).ProtectedDisk = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetails[]) content.GetValueForProperty("ProtectedDisk",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).ProtectedDisk, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmFailbackProtectedDiskDetailsTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).VMNic = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackNicDetails[]) content.GetValueForProperty("VMNic",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).VMNic, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackNicDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmFailbackNicDetailsTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProviderSpecificSettingsInternal)this).InstanceType = (string) content.GetValueForProperty("InstanceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProviderSpecificSettingsInternal)this).InstanceType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MobilityAgentDetailVersion = (string) content.GetValueForProperty("MobilityAgentDetailVersion",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MobilityAgentDetailVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MobilityAgentDetailLatestVersion = (string) content.GetValueForProperty("MobilityAgentDetailLatestVersion",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MobilityAgentDetailLatestVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MobilityAgentDetailDriverVersion = (string) content.GetValueForProperty("MobilityAgentDetailDriverVersion",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MobilityAgentDetailDriverVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MobilityAgentDetailLatestUpgradableVersionWithoutReboot = (string) content.GetValueForProperty("MobilityAgentDetailLatestUpgradableVersionWithoutReboot",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MobilityAgentDetailLatestUpgradableVersionWithoutReboot, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MobilityAgentDetailAgentVersionExpiryDate = (global::System.DateTime?) content.GetValueForProperty("MobilityAgentDetailAgentVersionExpiryDate",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MobilityAgentDetailAgentVersionExpiryDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MobilityAgentDetailDriverVersionExpiryDate = (global::System.DateTime?) content.GetValueForProperty("MobilityAgentDetailDriverVersionExpiryDate",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MobilityAgentDetailDriverVersionExpiryDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MobilityAgentDetailLastHeartbeatUtc = (global::System.DateTime?) content.GetValueForProperty("MobilityAgentDetailLastHeartbeatUtc",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MobilityAgentDetailLastHeartbeatUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MobilityAgentDetailReasonsBlockingUpgrade = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AgentUpgradeBlockedReason[]) content.GetValueForProperty("MobilityAgentDetailReasonsBlockingUpgrade",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MobilityAgentDetailReasonsBlockingUpgrade, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AgentUpgradeBlockedReason>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AgentUpgradeBlockedReason.CreateFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MobilityAgentDetailIsUpgradeable = (string) content.GetValueForProperty("MobilityAgentDetailIsUpgradeable",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal)this).MobilityAgentDetailIsUpgradeable, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// InMageRcmFailback provider specific details.
    [System.ComponentModel.TypeConverter(typeof(InMageRcmFailbackReplicationDetailsTypeConverter))]
    public partial interface IInMageRcmFailbackReplicationDetails

    {

    }
}