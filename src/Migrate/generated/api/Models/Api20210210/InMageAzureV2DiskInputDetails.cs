namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Disk input details.</summary>
    public partial class InMageAzureV2DiskInputDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2DiskInputDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2DiskInputDetailsInternal
    {

        /// <summary>Backing field for <see cref="DiskEncryptionSetId" /> property.</summary>
        private string _diskEncryptionSetId;

        /// <summary>The DiskEncryptionSet ARM ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string DiskEncryptionSetId { get => this._diskEncryptionSetId; set => this._diskEncryptionSetId = value; }

        /// <summary>Backing field for <see cref="DiskId" /> property.</summary>
        private string _diskId;

        /// <summary>The DiskId.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string DiskId { get => this._diskId; set => this._diskId = value; }

        /// <summary>Backing field for <see cref="DiskType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskAccountType? _diskType;

        /// <summary>The DiskType.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskAccountType? DiskType { get => this._diskType; set => this._diskType = value; }

        /// <summary>Backing field for <see cref="LogStorageAccountId" /> property.</summary>
        private string _logStorageAccountId;

        /// <summary>The LogStorageAccountId.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string LogStorageAccountId { get => this._logStorageAccountId; set => this._logStorageAccountId = value; }

        /// <summary>Creates an new <see cref="InMageAzureV2DiskInputDetails" /> instance.</summary>
        public InMageAzureV2DiskInputDetails()
        {

        }
    }
    /// Disk input details.
    public partial interface IInMageAzureV2DiskInputDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The DiskEncryptionSet ARM ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The DiskEncryptionSet ARM ID.",
        SerializedName = @"diskEncryptionSetId",
        PossibleTypes = new [] { typeof(string) })]
        string DiskEncryptionSetId { get; set; }
        /// <summary>The DiskId.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The DiskId.",
        SerializedName = @"diskId",
        PossibleTypes = new [] { typeof(string) })]
        string DiskId { get; set; }
        /// <summary>The DiskType.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The DiskType.",
        SerializedName = @"diskType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskAccountType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskAccountType? DiskType { get; set; }
        /// <summary>The LogStorageAccountId.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The LogStorageAccountId.",
        SerializedName = @"logStorageAccountId",
        PossibleTypes = new [] { typeof(string) })]
        string LogStorageAccountId { get; set; }

    }
    /// Disk input details.
    internal partial interface IInMageAzureV2DiskInputDetailsInternal

    {
        /// <summary>The DiskEncryptionSet ARM ID.</summary>
        string DiskEncryptionSetId { get; set; }
        /// <summary>The DiskId.</summary>
        string DiskId { get; set; }
        /// <summary>The DiskType.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskAccountType? DiskType { get; set; }
        /// <summary>The LogStorageAccountId.</summary>
        string LogStorageAccountId { get; set; }

    }
}