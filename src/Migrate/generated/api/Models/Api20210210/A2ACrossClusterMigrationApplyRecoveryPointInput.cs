namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>ApplyRecoveryPoint input specific to A2ACrossClusterMigration provider.</summary>
    public partial class A2ACrossClusterMigrationApplyRecoveryPointInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACrossClusterMigrationApplyRecoveryPointInput,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACrossClusterMigrationApplyRecoveryPointInputInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IApplyRecoveryPointProviderSpecificInput"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IApplyRecoveryPointProviderSpecificInput __applyRecoveryPointProviderSpecificInput = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ApplyRecoveryPointProviderSpecificInput();

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IApplyRecoveryPointProviderSpecificInputInternal)__applyRecoveryPointProviderSpecificInput).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IApplyRecoveryPointProviderSpecificInputInternal)__applyRecoveryPointProviderSpecificInput).InstanceType = value ; }

        /// <summary>
        /// Creates an new <see cref="A2ACrossClusterMigrationApplyRecoveryPointInput" /> instance.
        /// </summary>
        public A2ACrossClusterMigrationApplyRecoveryPointInput()
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
            await eventListener.AssertNotNull(nameof(__applyRecoveryPointProviderSpecificInput), __applyRecoveryPointProviderSpecificInput);
            await eventListener.AssertObjectIsValid(nameof(__applyRecoveryPointProviderSpecificInput), __applyRecoveryPointProviderSpecificInput);
        }
    }
    /// ApplyRecoveryPoint input specific to A2ACrossClusterMigration provider.
    public partial interface IA2ACrossClusterMigrationApplyRecoveryPointInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IApplyRecoveryPointProviderSpecificInput
    {

    }
    /// ApplyRecoveryPoint input specific to A2ACrossClusterMigration provider.
    internal partial interface IA2ACrossClusterMigrationApplyRecoveryPointInputInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IApplyRecoveryPointProviderSpecificInputInternal
    {

    }
}