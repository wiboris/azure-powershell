namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.PowerShell;

    /// <summary>A2A provider specific settings.</summary>
    [System.ComponentModel.TypeConverter(typeof(A2AReplicationIntentDetailsTypeConverter))]
    public partial class A2AReplicationIntentDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.A2AReplicationIntentDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal A2AReplicationIntentDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).ProtectionProfile = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProtectionProfileCustomDetails) content.GetValueForProperty("ProtectionProfile",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).ProtectionProfile, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ProtectionProfileCustomDetailsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).PrimaryStagingStorageAccount = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IStorageAccountCustomDetails) content.GetValueForProperty("PrimaryStagingStorageAccount",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).PrimaryStagingStorageAccount, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.StorageAccountCustomDetailsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryAvailabilitySet = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryAvailabilitySetCustomDetails) content.GetValueForProperty("RecoveryAvailabilitySet",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryAvailabilitySet, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.RecoveryAvailabilitySetCustomDetailsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryVirtualNetwork = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryVirtualNetworkCustomDetails) content.GetValueForProperty("RecoveryVirtualNetwork",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryVirtualNetwork, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.RecoveryVirtualNetworkCustomDetailsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryProximityPlacementGroup = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryProximityPlacementGroupCustomDetails) content.GetValueForProperty("RecoveryProximityPlacementGroup",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryProximityPlacementGroup, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.RecoveryProximityPlacementGroupCustomDetailsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryBootDiagStorageAccount = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IStorageAccountCustomDetails) content.GetValueForProperty("RecoveryBootDiagStorageAccount",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryBootDiagStorageAccount, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.StorageAccountCustomDetailsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).DiskEncryptionInfo = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionInfo) content.GetValueForProperty("DiskEncryptionInfo",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).DiskEncryptionInfo, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.DiskEncryptionInfoTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).FabricObjectId = (string) content.GetValueForProperty("FabricObjectId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).FabricObjectId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).PrimaryLocation = (string) content.GetValueForProperty("PrimaryLocation",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).PrimaryLocation, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryLocation = (string) content.GetValueForProperty("RecoveryLocation",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryLocation, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoverySubscriptionId = (string) content.GetValueForProperty("RecoverySubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoverySubscriptionId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).VMDisk = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentDiskInputDetails[]) content.GetValueForProperty("VMDisk",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).VMDisk, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentDiskInputDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.A2AProtectionIntentDiskInputDetailsTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).VMManagedDisk = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentManagedDiskInputDetails[]) content.GetValueForProperty("VMManagedDisk",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).VMManagedDisk, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentManagedDiskInputDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.A2AProtectionIntentManagedDiskInputDetailsTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryResourceGroupId = (string) content.GetValueForProperty("RecoveryResourceGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryResourceGroupId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).AutoProtectionOfDataDisk = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AutoProtectionOfDataDisk?) content.GetValueForProperty("AutoProtectionOfDataDisk",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).AutoProtectionOfDataDisk, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AutoProtectionOfDataDisk.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).MultiVMGroupName = (string) content.GetValueForProperty("MultiVMGroupName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).MultiVMGroupName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).MultiVMGroupId = (string) content.GetValueForProperty("MultiVMGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).MultiVMGroupId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryAvailabilityZone = (string) content.GetValueForProperty("RecoveryAvailabilityZone",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryAvailabilityZone, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryAvailabilityType = (string) content.GetValueForProperty("RecoveryAvailabilityType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryAvailabilityType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProtectionIntentProviderSpecificSettingsInternal)this).InstanceType = (string) content.GetValueForProperty("InstanceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProtectionIntentProviderSpecificSettingsInternal)this).InstanceType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).ProtectionProfileResourceType = (string) content.GetValueForProperty("ProtectionProfileResourceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).ProtectionProfileResourceType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).PrimaryStagingStorageAccountResourceType = (string) content.GetValueForProperty("PrimaryStagingStorageAccountResourceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).PrimaryStagingStorageAccountResourceType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryAvailabilitySetResourceType = (string) content.GetValueForProperty("RecoveryAvailabilitySetResourceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryAvailabilitySetResourceType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryVirtualNetworkResourceType = (string) content.GetValueForProperty("RecoveryVirtualNetworkResourceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryVirtualNetworkResourceType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryProximityPlacementGroupResourceType = (string) content.GetValueForProperty("RecoveryProximityPlacementGroupResourceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryProximityPlacementGroupResourceType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryBootDiagStorageAccountResourceType = (string) content.GetValueForProperty("RecoveryBootDiagStorageAccountResourceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryBootDiagStorageAccountResourceType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).DiskEncryptionInfoDiskEncryptionKeyInfo = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionKeyInfo) content.GetValueForProperty("DiskEncryptionInfoDiskEncryptionKeyInfo",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).DiskEncryptionInfoDiskEncryptionKeyInfo, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.DiskEncryptionKeyInfoTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).DiskEncryptionInfoKeyEncryptionKeyInfo = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IKeyEncryptionKeyInfo) content.GetValueForProperty("DiskEncryptionInfoKeyEncryptionKeyInfo",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).DiskEncryptionInfoKeyEncryptionKeyInfo, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.KeyEncryptionKeyInfoTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).DiskEncryptionKeyInfoSecretIdentifier = (string) content.GetValueForProperty("DiskEncryptionKeyInfoSecretIdentifier",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).DiskEncryptionKeyInfoSecretIdentifier, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).KeyEncryptionKeyInfoKeyIdentifier = (string) content.GetValueForProperty("KeyEncryptionKeyInfoKeyIdentifier",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).KeyEncryptionKeyInfoKeyIdentifier, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).DiskEncryptionKeyInfoKeyVaultResourceArmId = (string) content.GetValueForProperty("DiskEncryptionKeyInfoKeyVaultResourceArmId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).DiskEncryptionKeyInfoKeyVaultResourceArmId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).KeyEncryptionKeyInfoKeyVaultResourceArmId = (string) content.GetValueForProperty("KeyEncryptionKeyInfoKeyVaultResourceArmId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).KeyEncryptionKeyInfoKeyVaultResourceArmId, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.A2AReplicationIntentDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal A2AReplicationIntentDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).ProtectionProfile = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProtectionProfileCustomDetails) content.GetValueForProperty("ProtectionProfile",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).ProtectionProfile, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ProtectionProfileCustomDetailsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).PrimaryStagingStorageAccount = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IStorageAccountCustomDetails) content.GetValueForProperty("PrimaryStagingStorageAccount",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).PrimaryStagingStorageAccount, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.StorageAccountCustomDetailsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryAvailabilitySet = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryAvailabilitySetCustomDetails) content.GetValueForProperty("RecoveryAvailabilitySet",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryAvailabilitySet, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.RecoveryAvailabilitySetCustomDetailsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryVirtualNetwork = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryVirtualNetworkCustomDetails) content.GetValueForProperty("RecoveryVirtualNetwork",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryVirtualNetwork, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.RecoveryVirtualNetworkCustomDetailsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryProximityPlacementGroup = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryProximityPlacementGroupCustomDetails) content.GetValueForProperty("RecoveryProximityPlacementGroup",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryProximityPlacementGroup, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.RecoveryProximityPlacementGroupCustomDetailsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryBootDiagStorageAccount = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IStorageAccountCustomDetails) content.GetValueForProperty("RecoveryBootDiagStorageAccount",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryBootDiagStorageAccount, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.StorageAccountCustomDetailsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).DiskEncryptionInfo = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionInfo) content.GetValueForProperty("DiskEncryptionInfo",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).DiskEncryptionInfo, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.DiskEncryptionInfoTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).FabricObjectId = (string) content.GetValueForProperty("FabricObjectId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).FabricObjectId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).PrimaryLocation = (string) content.GetValueForProperty("PrimaryLocation",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).PrimaryLocation, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryLocation = (string) content.GetValueForProperty("RecoveryLocation",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryLocation, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoverySubscriptionId = (string) content.GetValueForProperty("RecoverySubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoverySubscriptionId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).VMDisk = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentDiskInputDetails[]) content.GetValueForProperty("VMDisk",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).VMDisk, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentDiskInputDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.A2AProtectionIntentDiskInputDetailsTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).VMManagedDisk = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentManagedDiskInputDetails[]) content.GetValueForProperty("VMManagedDisk",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).VMManagedDisk, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentManagedDiskInputDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.A2AProtectionIntentManagedDiskInputDetailsTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryResourceGroupId = (string) content.GetValueForProperty("RecoveryResourceGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryResourceGroupId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).AutoProtectionOfDataDisk = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AutoProtectionOfDataDisk?) content.GetValueForProperty("AutoProtectionOfDataDisk",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).AutoProtectionOfDataDisk, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AutoProtectionOfDataDisk.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).MultiVMGroupName = (string) content.GetValueForProperty("MultiVMGroupName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).MultiVMGroupName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).MultiVMGroupId = (string) content.GetValueForProperty("MultiVMGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).MultiVMGroupId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryAvailabilityZone = (string) content.GetValueForProperty("RecoveryAvailabilityZone",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryAvailabilityZone, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryAvailabilityType = (string) content.GetValueForProperty("RecoveryAvailabilityType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryAvailabilityType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProtectionIntentProviderSpecificSettingsInternal)this).InstanceType = (string) content.GetValueForProperty("InstanceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProtectionIntentProviderSpecificSettingsInternal)this).InstanceType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).ProtectionProfileResourceType = (string) content.GetValueForProperty("ProtectionProfileResourceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).ProtectionProfileResourceType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).PrimaryStagingStorageAccountResourceType = (string) content.GetValueForProperty("PrimaryStagingStorageAccountResourceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).PrimaryStagingStorageAccountResourceType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryAvailabilitySetResourceType = (string) content.GetValueForProperty("RecoveryAvailabilitySetResourceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryAvailabilitySetResourceType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryVirtualNetworkResourceType = (string) content.GetValueForProperty("RecoveryVirtualNetworkResourceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryVirtualNetworkResourceType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryProximityPlacementGroupResourceType = (string) content.GetValueForProperty("RecoveryProximityPlacementGroupResourceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryProximityPlacementGroupResourceType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryBootDiagStorageAccountResourceType = (string) content.GetValueForProperty("RecoveryBootDiagStorageAccountResourceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).RecoveryBootDiagStorageAccountResourceType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).DiskEncryptionInfoDiskEncryptionKeyInfo = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionKeyInfo) content.GetValueForProperty("DiskEncryptionInfoDiskEncryptionKeyInfo",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).DiskEncryptionInfoDiskEncryptionKeyInfo, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.DiskEncryptionKeyInfoTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).DiskEncryptionInfoKeyEncryptionKeyInfo = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IKeyEncryptionKeyInfo) content.GetValueForProperty("DiskEncryptionInfoKeyEncryptionKeyInfo",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).DiskEncryptionInfoKeyEncryptionKeyInfo, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.KeyEncryptionKeyInfoTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).DiskEncryptionKeyInfoSecretIdentifier = (string) content.GetValueForProperty("DiskEncryptionKeyInfoSecretIdentifier",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).DiskEncryptionKeyInfoSecretIdentifier, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).KeyEncryptionKeyInfoKeyIdentifier = (string) content.GetValueForProperty("KeyEncryptionKeyInfoKeyIdentifier",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).KeyEncryptionKeyInfoKeyIdentifier, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).DiskEncryptionKeyInfoKeyVaultResourceArmId = (string) content.GetValueForProperty("DiskEncryptionKeyInfoKeyVaultResourceArmId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).DiskEncryptionKeyInfoKeyVaultResourceArmId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).KeyEncryptionKeyInfoKeyVaultResourceArmId = (string) content.GetValueForProperty("KeyEncryptionKeyInfoKeyVaultResourceArmId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetailsInternal)this).KeyEncryptionKeyInfoKeyVaultResourceArmId, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.A2AReplicationIntentDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new A2AReplicationIntentDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.A2AReplicationIntentDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new A2AReplicationIntentDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="A2AReplicationIntentDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// A2A provider specific settings.
    [System.ComponentModel.TypeConverter(typeof(A2AReplicationIntentDetailsTypeConverter))]
    public partial interface IA2AReplicationIntentDetails

    {

    }
}