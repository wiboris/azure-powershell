namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>A2A create protection intent input.</summary>
    public partial class A2ACreateProtectionIntentInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACreateProtectionIntentInput,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACreateProtectionIntentInputInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateProtectionIntentProviderSpecificDetails"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateProtectionIntentProviderSpecificDetails __createProtectionIntentProviderSpecificDetails = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.CreateProtectionIntentProviderSpecificDetails();

        /// <summary>Backing field for <see cref="AutoProtectionOfDataDisk" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AutoProtectionOfDataDisk? _autoProtectionOfDataDisk;

        /// <summary>A value indicating whether the auto protection is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AutoProtectionOfDataDisk? AutoProtectionOfDataDisk { get => this._autoProtectionOfDataDisk; set => this._autoProtectionOfDataDisk = value; }

        /// <summary>Backing field for <see cref="DiskEncryptionInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionInfo _diskEncryptionInfo;

        /// <summary>The recovery disk encryption information (for two pass flows).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionInfo DiskEncryptionInfo { get => (this._diskEncryptionInfo = this._diskEncryptionInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.DiskEncryptionInfo()); set => this._diskEncryptionInfo = value; }

        /// <summary>The KeyVault resource ARM id for secret.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string DiskEncryptionKeyInfoKeyVaultResourceArmId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionInfoInternal)DiskEncryptionInfo).DiskEncryptionKeyInfoKeyVaultResourceArmId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionInfoInternal)DiskEncryptionInfo).DiskEncryptionKeyInfoKeyVaultResourceArmId = value ?? null; }

        /// <summary>The secret url / identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string DiskEncryptionKeyInfoSecretIdentifier { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionInfoInternal)DiskEncryptionInfo).DiskEncryptionKeyInfoSecretIdentifier; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionInfoInternal)DiskEncryptionInfo).DiskEncryptionKeyInfoSecretIdentifier = value ?? null; }

        /// <summary>Backing field for <see cref="FabricObjectId" /> property.</summary>
        private string _fabricObjectId;

        /// <summary>The fabric specific object Id of the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string FabricObjectId { get => this._fabricObjectId; set => this._fabricObjectId = value; }

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateProtectionIntentProviderSpecificDetailsInternal)__createProtectionIntentProviderSpecificDetails).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateProtectionIntentProviderSpecificDetailsInternal)__createProtectionIntentProviderSpecificDetails).InstanceType = value ?? null; }

        /// <summary>The key URL / identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string KeyEncryptionKeyInfoKeyIdentifier { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionInfoInternal)DiskEncryptionInfo).KeyEncryptionKeyInfoKeyIdentifier; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionInfoInternal)DiskEncryptionInfo).KeyEncryptionKeyInfoKeyIdentifier = value ?? null; }

        /// <summary>The KeyVault resource ARM Id for key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string KeyEncryptionKeyInfoKeyVaultResourceArmId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionInfoInternal)DiskEncryptionInfo).KeyEncryptionKeyInfoKeyVaultResourceArmId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionInfoInternal)DiskEncryptionInfo).KeyEncryptionKeyInfoKeyVaultResourceArmId = value ?? null; }

        /// <summary>Internal Acessors for DiskEncryptionInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionInfo Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACreateProtectionIntentInputInternal.DiskEncryptionInfo { get => (this._diskEncryptionInfo = this._diskEncryptionInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.DiskEncryptionInfo()); set { {_diskEncryptionInfo = value;} } }

        /// <summary>Internal Acessors for DiskEncryptionInfoDiskEncryptionKeyInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionKeyInfo Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACreateProtectionIntentInputInternal.DiskEncryptionInfoDiskEncryptionKeyInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionInfoInternal)DiskEncryptionInfo).DiskEncryptionKeyInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionInfoInternal)DiskEncryptionInfo).DiskEncryptionKeyInfo = value; }

        /// <summary>Internal Acessors for DiskEncryptionInfoKeyEncryptionKeyInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IKeyEncryptionKeyInfo Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACreateProtectionIntentInputInternal.DiskEncryptionInfoKeyEncryptionKeyInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionInfoInternal)DiskEncryptionInfo).KeyEncryptionKeyInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionInfoInternal)DiskEncryptionInfo).KeyEncryptionKeyInfo = value; }

        /// <summary>Internal Acessors for PrimaryStagingStorageAccountCustomInput</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IStorageAccountCustomDetails Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACreateProtectionIntentInputInternal.PrimaryStagingStorageAccountCustomInput { get => (this._primaryStagingStorageAccountCustomInput = this._primaryStagingStorageAccountCustomInput ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.StorageAccountCustomDetails()); set { {_primaryStagingStorageAccountCustomInput = value;} } }

        /// <summary>Internal Acessors for ProtectionProfileCustomInput</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProtectionProfileCustomDetails Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACreateProtectionIntentInputInternal.ProtectionProfileCustomInput { get => (this._protectionProfileCustomInput = this._protectionProfileCustomInput ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ProtectionProfileCustomDetails()); set { {_protectionProfileCustomInput = value;} } }

        /// <summary>Internal Acessors for RecoveryAvailabilitySetCustomInput</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryAvailabilitySetCustomDetails Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACreateProtectionIntentInputInternal.RecoveryAvailabilitySetCustomInput { get => (this._recoveryAvailabilitySetCustomInput = this._recoveryAvailabilitySetCustomInput ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.RecoveryAvailabilitySetCustomDetails()); set { {_recoveryAvailabilitySetCustomInput = value;} } }

        /// <summary>Internal Acessors for RecoveryBootDiagStorageAccount</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IStorageAccountCustomDetails Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACreateProtectionIntentInputInternal.RecoveryBootDiagStorageAccount { get => (this._recoveryBootDiagStorageAccount = this._recoveryBootDiagStorageAccount ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.StorageAccountCustomDetails()); set { {_recoveryBootDiagStorageAccount = value;} } }

        /// <summary>Internal Acessors for RecoveryProximityPlacementGroupCustomInput</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryProximityPlacementGroupCustomDetails Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACreateProtectionIntentInputInternal.RecoveryProximityPlacementGroupCustomInput { get => (this._recoveryProximityPlacementGroupCustomInput = this._recoveryProximityPlacementGroupCustomInput ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.RecoveryProximityPlacementGroupCustomDetails()); set { {_recoveryProximityPlacementGroupCustomInput = value;} } }

        /// <summary>Internal Acessors for RecoveryVirtualNetworkCustomInput</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryVirtualNetworkCustomDetails Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACreateProtectionIntentInputInternal.RecoveryVirtualNetworkCustomInput { get => (this._recoveryVirtualNetworkCustomInput = this._recoveryVirtualNetworkCustomInput ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.RecoveryVirtualNetworkCustomDetails()); set { {_recoveryVirtualNetworkCustomInput = value;} } }

        /// <summary>Backing field for <see cref="MultiVMGroupId" /> property.</summary>
        private string _multiVMGroupId;

        /// <summary>The multi vm group id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string MultiVMGroupId { get => this._multiVMGroupId; set => this._multiVMGroupId = value; }

        /// <summary>Backing field for <see cref="MultiVMGroupName" /> property.</summary>
        private string _multiVMGroupName;

        /// <summary>The multi vm group name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string MultiVMGroupName { get => this._multiVMGroupName; set => this._multiVMGroupName = value; }

        /// <summary>Backing field for <see cref="PrimaryLocation" /> property.</summary>
        private string _primaryLocation;

        /// <summary>The primary location for the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string PrimaryLocation { get => this._primaryLocation; set => this._primaryLocation = value; }

        /// <summary>
        /// Backing field for <see cref="PrimaryStagingStorageAccountCustomInput" /> property.
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IStorageAccountCustomDetails _primaryStagingStorageAccountCustomInput;

        /// <summary>The primary staging storage account input.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IStorageAccountCustomDetails PrimaryStagingStorageAccountCustomInput { get => (this._primaryStagingStorageAccountCustomInput = this._primaryStagingStorageAccountCustomInput ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.StorageAccountCustomDetails()); set => this._primaryStagingStorageAccountCustomInput = value; }

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string PrimaryStagingStorageAccountCustomInputResourceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IStorageAccountCustomDetailsInternal)PrimaryStagingStorageAccountCustomInput).ResourceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IStorageAccountCustomDetailsInternal)PrimaryStagingStorageAccountCustomInput).ResourceType = value ?? null; }

        /// <summary>Backing field for <see cref="ProtectionProfileCustomInput" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProtectionProfileCustomDetails _protectionProfileCustomInput;

        /// <summary>The protection profile custom inputs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProtectionProfileCustomDetails ProtectionProfileCustomInput { get => (this._protectionProfileCustomInput = this._protectionProfileCustomInput ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ProtectionProfileCustomDetails()); set => this._protectionProfileCustomInput = value; }

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ProtectionProfileCustomInputResourceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProtectionProfileCustomDetailsInternal)ProtectionProfileCustomInput).ResourceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProtectionProfileCustomDetailsInternal)ProtectionProfileCustomInput).ResourceType = value ?? null; }

        /// <summary>Backing field for <see cref="RecoveryAvailabilitySetCustomInput" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryAvailabilitySetCustomDetails _recoveryAvailabilitySetCustomInput;

        /// <summary>The recovery availability set input.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryAvailabilitySetCustomDetails RecoveryAvailabilitySetCustomInput { get => (this._recoveryAvailabilitySetCustomInput = this._recoveryAvailabilitySetCustomInput ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.RecoveryAvailabilitySetCustomDetails()); set => this._recoveryAvailabilitySetCustomInput = value; }

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string RecoveryAvailabilitySetCustomInputResourceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryAvailabilitySetCustomDetailsInternal)RecoveryAvailabilitySetCustomInput).ResourceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryAvailabilitySetCustomDetailsInternal)RecoveryAvailabilitySetCustomInput).ResourceType = value ?? null; }

        /// <summary>Backing field for <see cref="RecoveryAvailabilityType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.A2ARecoveryAvailabilityType _recoveryAvailabilityType;

        /// <summary>The recovery availability type of the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.A2ARecoveryAvailabilityType RecoveryAvailabilityType { get => this._recoveryAvailabilityType; set => this._recoveryAvailabilityType = value; }

        /// <summary>Backing field for <see cref="RecoveryAvailabilityZone" /> property.</summary>
        private string _recoveryAvailabilityZone;

        /// <summary>The recovery availability zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RecoveryAvailabilityZone { get => this._recoveryAvailabilityZone; set => this._recoveryAvailabilityZone = value; }

        /// <summary>Backing field for <see cref="RecoveryBootDiagStorageAccount" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IStorageAccountCustomDetails _recoveryBootDiagStorageAccount;

        /// <summary>The boot diagnostic storage account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IStorageAccountCustomDetails RecoveryBootDiagStorageAccount { get => (this._recoveryBootDiagStorageAccount = this._recoveryBootDiagStorageAccount ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.StorageAccountCustomDetails()); set => this._recoveryBootDiagStorageAccount = value; }

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string RecoveryBootDiagStorageAccountResourceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IStorageAccountCustomDetailsInternal)RecoveryBootDiagStorageAccount).ResourceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IStorageAccountCustomDetailsInternal)RecoveryBootDiagStorageAccount).ResourceType = value ?? null; }

        /// <summary>Backing field for <see cref="RecoveryLocation" /> property.</summary>
        private string _recoveryLocation;

        /// <summary>The recovery location for the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RecoveryLocation { get => this._recoveryLocation; set => this._recoveryLocation = value; }

        /// <summary>
        /// Backing field for <see cref="RecoveryProximityPlacementGroupCustomInput" /> property.
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryProximityPlacementGroupCustomDetails _recoveryProximityPlacementGroupCustomInput;

        /// <summary>The recovery proximity placement group custom input.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryProximityPlacementGroupCustomDetails RecoveryProximityPlacementGroupCustomInput { get => (this._recoveryProximityPlacementGroupCustomInput = this._recoveryProximityPlacementGroupCustomInput ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.RecoveryProximityPlacementGroupCustomDetails()); set => this._recoveryProximityPlacementGroupCustomInput = value; }

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string RecoveryProximityPlacementGroupCustomInputResourceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryProximityPlacementGroupCustomDetailsInternal)RecoveryProximityPlacementGroupCustomInput).ResourceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryProximityPlacementGroupCustomDetailsInternal)RecoveryProximityPlacementGroupCustomInput).ResourceType = value ?? null; }

        /// <summary>Backing field for <see cref="RecoveryResourceGroupId" /> property.</summary>
        private string _recoveryResourceGroupId;

        /// <summary>The recovery resource group Id. Valid for V2 scenarios.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RecoveryResourceGroupId { get => this._recoveryResourceGroupId; set => this._recoveryResourceGroupId = value; }

        /// <summary>Backing field for <see cref="RecoverySubscriptionId" /> property.</summary>
        private string _recoverySubscriptionId;

        /// <summary>The recovery subscription Id of the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RecoverySubscriptionId { get => this._recoverySubscriptionId; set => this._recoverySubscriptionId = value; }

        /// <summary>Backing field for <see cref="RecoveryVirtualNetworkCustomInput" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryVirtualNetworkCustomDetails _recoveryVirtualNetworkCustomInput;

        /// <summary>The recovery virtual network input.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryVirtualNetworkCustomDetails RecoveryVirtualNetworkCustomInput { get => (this._recoveryVirtualNetworkCustomInput = this._recoveryVirtualNetworkCustomInput ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.RecoveryVirtualNetworkCustomDetails()); set => this._recoveryVirtualNetworkCustomInput = value; }

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string RecoveryVirtualNetworkCustomInputResourceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryVirtualNetworkCustomDetailsInternal)RecoveryVirtualNetworkCustomInput).ResourceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryVirtualNetworkCustomDetailsInternal)RecoveryVirtualNetworkCustomInput).ResourceType = value ?? null; }

        /// <summary>Backing field for <see cref="VMDisk" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentDiskInputDetails[] _vMDisk;

        /// <summary>The list of vm disk inputs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentDiskInputDetails[] VMDisk { get => this._vMDisk; set => this._vMDisk = value; }

        /// <summary>Backing field for <see cref="VMManagedDisk" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentManagedDiskInputDetails[] _vMManagedDisk;

        /// <summary>The list of vm managed disk inputs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentManagedDiskInputDetails[] VMManagedDisk { get => this._vMManagedDisk; set => this._vMManagedDisk = value; }

        /// <summary>Creates an new <see cref="A2ACreateProtectionIntentInput" /> instance.</summary>
        public A2ACreateProtectionIntentInput()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__createProtectionIntentProviderSpecificDetails), __createProtectionIntentProviderSpecificDetails);
            await eventListener.AssertObjectIsValid(nameof(__createProtectionIntentProviderSpecificDetails), __createProtectionIntentProviderSpecificDetails);
        }
    }
    /// A2A create protection intent input.
    public partial interface IA2ACreateProtectionIntentInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateProtectionIntentProviderSpecificDetails
    {
        /// <summary>A value indicating whether the auto protection is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value indicating whether the auto protection is enabled.",
        SerializedName = @"autoProtectionOfDataDisk",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AutoProtectionOfDataDisk) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AutoProtectionOfDataDisk? AutoProtectionOfDataDisk { get; set; }
        /// <summary>The KeyVault resource ARM id for secret.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The KeyVault resource ARM id for secret.",
        SerializedName = @"keyVaultResourceArmId",
        PossibleTypes = new [] { typeof(string) })]
        string DiskEncryptionKeyInfoKeyVaultResourceArmId { get; set; }
        /// <summary>The secret url / identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The secret url / identifier.",
        SerializedName = @"secretIdentifier",
        PossibleTypes = new [] { typeof(string) })]
        string DiskEncryptionKeyInfoSecretIdentifier { get; set; }
        /// <summary>The fabric specific object Id of the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The fabric specific object Id of the virtual machine.",
        SerializedName = @"fabricObjectId",
        PossibleTypes = new [] { typeof(string) })]
        string FabricObjectId { get; set; }
        /// <summary>The key URL / identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The key URL / identifier.",
        SerializedName = @"keyIdentifier",
        PossibleTypes = new [] { typeof(string) })]
        string KeyEncryptionKeyInfoKeyIdentifier { get; set; }
        /// <summary>The KeyVault resource ARM Id for key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The KeyVault resource ARM Id for key.",
        SerializedName = @"keyVaultResourceArmId",
        PossibleTypes = new [] { typeof(string) })]
        string KeyEncryptionKeyInfoKeyVaultResourceArmId { get; set; }
        /// <summary>The multi vm group id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The multi vm group id.",
        SerializedName = @"multiVmGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string MultiVMGroupId { get; set; }
        /// <summary>The multi vm group name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The multi vm group name.",
        SerializedName = @"multiVmGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string MultiVMGroupName { get; set; }
        /// <summary>The primary location for the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The primary location for the virtual machine.",
        SerializedName = @"primaryLocation",
        PossibleTypes = new [] { typeof(string) })]
        string PrimaryLocation { get; set; }
        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The class type.",
        SerializedName = @"resourceType",
        PossibleTypes = new [] { typeof(string) })]
        string PrimaryStagingStorageAccountCustomInputResourceType { get; set; }
        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The class type.",
        SerializedName = @"resourceType",
        PossibleTypes = new [] { typeof(string) })]
        string ProtectionProfileCustomInputResourceType { get; set; }
        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The class type.",
        SerializedName = @"resourceType",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryAvailabilitySetCustomInputResourceType { get; set; }
        /// <summary>The recovery availability type of the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The recovery availability type of the virtual machine.",
        SerializedName = @"recoveryAvailabilityType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.A2ARecoveryAvailabilityType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.A2ARecoveryAvailabilityType RecoveryAvailabilityType { get; set; }
        /// <summary>The recovery availability zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The recovery availability zone.",
        SerializedName = @"recoveryAvailabilityZone",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryAvailabilityZone { get; set; }
        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The class type.",
        SerializedName = @"resourceType",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryBootDiagStorageAccountResourceType { get; set; }
        /// <summary>The recovery location for the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The recovery location for the virtual machine.",
        SerializedName = @"recoveryLocation",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryLocation { get; set; }
        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The class type.",
        SerializedName = @"resourceType",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryProximityPlacementGroupCustomInputResourceType { get; set; }
        /// <summary>The recovery resource group Id. Valid for V2 scenarios.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The recovery resource group Id. Valid for V2 scenarios.",
        SerializedName = @"recoveryResourceGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryResourceGroupId { get; set; }
        /// <summary>The recovery subscription Id of the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The recovery subscription Id of the virtual machine.",
        SerializedName = @"recoverySubscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string RecoverySubscriptionId { get; set; }
        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The class type.",
        SerializedName = @"resourceType",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryVirtualNetworkCustomInputResourceType { get; set; }
        /// <summary>The list of vm disk inputs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of vm disk inputs.",
        SerializedName = @"vmDisks",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentDiskInputDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentDiskInputDetails[] VMDisk { get; set; }
        /// <summary>The list of vm managed disk inputs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of vm managed disk inputs.",
        SerializedName = @"vmManagedDisks",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentManagedDiskInputDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentManagedDiskInputDetails[] VMManagedDisk { get; set; }

    }
    /// A2A create protection intent input.
    internal partial interface IA2ACreateProtectionIntentInputInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateProtectionIntentProviderSpecificDetailsInternal
    {
        /// <summary>A value indicating whether the auto protection is enabled.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AutoProtectionOfDataDisk? AutoProtectionOfDataDisk { get; set; }
        /// <summary>The recovery disk encryption information (for two pass flows).</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionInfo DiskEncryptionInfo { get; set; }
        /// <summary>The recovery KeyVault reference for secret.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionKeyInfo DiskEncryptionInfoDiskEncryptionKeyInfo { get; set; }
        /// <summary>The recovery KeyVault reference for key.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IKeyEncryptionKeyInfo DiskEncryptionInfoKeyEncryptionKeyInfo { get; set; }
        /// <summary>The KeyVault resource ARM id for secret.</summary>
        string DiskEncryptionKeyInfoKeyVaultResourceArmId { get; set; }
        /// <summary>The secret url / identifier.</summary>
        string DiskEncryptionKeyInfoSecretIdentifier { get; set; }
        /// <summary>The fabric specific object Id of the virtual machine.</summary>
        string FabricObjectId { get; set; }
        /// <summary>The key URL / identifier.</summary>
        string KeyEncryptionKeyInfoKeyIdentifier { get; set; }
        /// <summary>The KeyVault resource ARM Id for key.</summary>
        string KeyEncryptionKeyInfoKeyVaultResourceArmId { get; set; }
        /// <summary>The multi vm group id.</summary>
        string MultiVMGroupId { get; set; }
        /// <summary>The multi vm group name.</summary>
        string MultiVMGroupName { get; set; }
        /// <summary>The primary location for the virtual machine.</summary>
        string PrimaryLocation { get; set; }
        /// <summary>The primary staging storage account input.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IStorageAccountCustomDetails PrimaryStagingStorageAccountCustomInput { get; set; }
        /// <summary>The class type.</summary>
        string PrimaryStagingStorageAccountCustomInputResourceType { get; set; }
        /// <summary>The protection profile custom inputs.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProtectionProfileCustomDetails ProtectionProfileCustomInput { get; set; }
        /// <summary>The class type.</summary>
        string ProtectionProfileCustomInputResourceType { get; set; }
        /// <summary>The recovery availability set input.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryAvailabilitySetCustomDetails RecoveryAvailabilitySetCustomInput { get; set; }
        /// <summary>The class type.</summary>
        string RecoveryAvailabilitySetCustomInputResourceType { get; set; }
        /// <summary>The recovery availability type of the virtual machine.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.A2ARecoveryAvailabilityType RecoveryAvailabilityType { get; set; }
        /// <summary>The recovery availability zone.</summary>
        string RecoveryAvailabilityZone { get; set; }
        /// <summary>The boot diagnostic storage account.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IStorageAccountCustomDetails RecoveryBootDiagStorageAccount { get; set; }
        /// <summary>The class type.</summary>
        string RecoveryBootDiagStorageAccountResourceType { get; set; }
        /// <summary>The recovery location for the virtual machine.</summary>
        string RecoveryLocation { get; set; }
        /// <summary>The recovery proximity placement group custom input.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryProximityPlacementGroupCustomDetails RecoveryProximityPlacementGroupCustomInput { get; set; }
        /// <summary>The class type.</summary>
        string RecoveryProximityPlacementGroupCustomInputResourceType { get; set; }
        /// <summary>The recovery resource group Id. Valid for V2 scenarios.</summary>
        string RecoveryResourceGroupId { get; set; }
        /// <summary>The recovery subscription Id of the virtual machine.</summary>
        string RecoverySubscriptionId { get; set; }
        /// <summary>The recovery virtual network input.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryVirtualNetworkCustomDetails RecoveryVirtualNetworkCustomInput { get; set; }
        /// <summary>The class type.</summary>
        string RecoveryVirtualNetworkCustomInputResourceType { get; set; }
        /// <summary>The list of vm disk inputs.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentDiskInputDetails[] VMDisk { get; set; }
        /// <summary>The list of vm managed disk inputs.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentManagedDiskInputDetails[] VMManagedDisk { get; set; }

    }
}