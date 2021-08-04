namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>VMM fabric provider specific VM settings.</summary>
    public partial class VmmVirtualMachineDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVmmVirtualMachineDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVmmVirtualMachineDetailsInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVVirtualMachineDetails"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVVirtualMachineDetails __hyperVVirtualMachineDetails = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.HyperVVirtualMachineDetails();

        /// <summary>The Last successful failover time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskDetails[] DiskDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVVirtualMachineDetailsInternal)__hyperVVirtualMachineDetails).DiskDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVVirtualMachineDetailsInternal)__hyperVVirtualMachineDetails).DiskDetail = value ?? null /* arrayOf */; }

        /// <summary>The id of the object in fabric.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string Generation { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVVirtualMachineDetailsInternal)__hyperVVirtualMachineDetails).Generation; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVVirtualMachineDetailsInternal)__hyperVVirtualMachineDetails).Generation = value ?? null; }

        /// <summary>
        /// A value indicating whether the VM has a fibre channel adapter attached. String value of SrsDataContract.PresenceStatus
        /// enum.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.PresenceStatus? HasFibreChannelAdapter { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVVirtualMachineDetailsInternal)__hyperVVirtualMachineDetails).HasFibreChannelAdapter; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVVirtualMachineDetailsInternal)__hyperVVirtualMachineDetails).HasFibreChannelAdapter = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.PresenceStatus)""); }

        /// <summary>
        /// A value indicating whether the VM has a physical disk attached. String value of SrsDataContract.PresenceStatus enum.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.PresenceStatus? HasPhysicalDisk { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVVirtualMachineDetailsInternal)__hyperVVirtualMachineDetails).HasPhysicalDisk; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVVirtualMachineDetailsInternal)__hyperVVirtualMachineDetails).HasPhysicalDisk = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.PresenceStatus)""); }

        /// <summary>
        /// A value indicating whether the VM has a shared VHD attached. String value of SrsDataContract.PresenceStatus enum.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.PresenceStatus? HasSharedVhd { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVVirtualMachineDetailsInternal)__hyperVVirtualMachineDetails).HasSharedVhd; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVVirtualMachineDetailsInternal)__hyperVVirtualMachineDetails).HasSharedVhd = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.PresenceStatus)""); }

        /// <summary>Gets the class type. Overridden in derived classes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IConfigurationSettingsInternal)__hyperVVirtualMachineDetails).InstanceType; }

        /// <summary>Internal Acessors for InstanceType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IConfigurationSettingsInternal.InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IConfigurationSettingsInternal)__hyperVVirtualMachineDetails).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IConfigurationSettingsInternal)__hyperVVirtualMachineDetails).InstanceType = value; }

        /// <summary>The Last replication time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IOSDetails OSDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVVirtualMachineDetailsInternal)__hyperVVirtualMachineDetails).OSDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVVirtualMachineDetailsInternal)__hyperVVirtualMachineDetails).OSDetail = value ?? null /* model class */; }

        /// <summary>The OSEdition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string OSDetailOsedition { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVVirtualMachineDetailsInternal)__hyperVVirtualMachineDetails).OSDetailOsedition; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVVirtualMachineDetailsInternal)__hyperVVirtualMachineDetails).OSDetailOsedition = value ?? null; }

        /// <summary>The OS Major Version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string OSDetailOsmajorVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVVirtualMachineDetailsInternal)__hyperVVirtualMachineDetails).OSDetailOsmajorVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVVirtualMachineDetailsInternal)__hyperVVirtualMachineDetails).OSDetailOsmajorVersion = value ?? null; }

        /// <summary>The OS Minor Version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string OSDetailOsminorVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVVirtualMachineDetailsInternal)__hyperVVirtualMachineDetails).OSDetailOsminorVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVVirtualMachineDetailsInternal)__hyperVVirtualMachineDetails).OSDetailOsminorVersion = value ?? null; }

        /// <summary>VM Disk details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string OSDetailOstype { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVVirtualMachineDetailsInternal)__hyperVVirtualMachineDetails).OSDetailOstype; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVVirtualMachineDetailsInternal)__hyperVVirtualMachineDetails).OSDetailOstype = value ?? null; }

        /// <summary>The OS Version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string OSDetailOsversion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVVirtualMachineDetailsInternal)__hyperVVirtualMachineDetails).OSDetailOsversion; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVVirtualMachineDetailsInternal)__hyperVVirtualMachineDetails).OSDetailOsversion = value ?? null; }

        /// <summary>Product type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string OSDetailProductType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVVirtualMachineDetailsInternal)__hyperVVirtualMachineDetails).OSDetailProductType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVVirtualMachineDetailsInternal)__hyperVVirtualMachineDetails).OSDetailProductType = value ?? null; }

        /// <summary>The source id of the object.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string SourceItemId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVVirtualMachineDetailsInternal)__hyperVVirtualMachineDetails).SourceItemId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVVirtualMachineDetailsInternal)__hyperVVirtualMachineDetails).SourceItemId = value ?? null; }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__hyperVVirtualMachineDetails), __hyperVVirtualMachineDetails);
            await eventListener.AssertObjectIsValid(nameof(__hyperVVirtualMachineDetails), __hyperVVirtualMachineDetails);
        }

        /// <summary>Creates an new <see cref="VmmVirtualMachineDetails" /> instance.</summary>
        public VmmVirtualMachineDetails()
        {

        }
    }
    /// VMM fabric provider specific VM settings.
    public partial interface IVmmVirtualMachineDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVVirtualMachineDetails
    {

    }
    /// VMM fabric provider specific VM settings.
    internal partial interface IVmmVirtualMachineDetailsInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVVirtualMachineDetailsInternal
    {

    }
}