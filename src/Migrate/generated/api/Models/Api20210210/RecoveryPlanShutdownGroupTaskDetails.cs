namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>This class represents the recovery plan shutdown group task details.</summary>
    public partial class RecoveryPlanShutdownGroupTaskDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanShutdownGroupTaskDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanShutdownGroupTaskDetailsInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanGroupTaskDetails"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanGroupTaskDetails __recoveryPlanGroupTaskDetails = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.RecoveryPlanGroupTaskDetails();

        /// <summary>The child tasks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAsrTask[] ChildTask { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IGroupTaskDetailsInternal)__recoveryPlanGroupTaskDetails).ChildTask; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IGroupTaskDetailsInternal)__recoveryPlanGroupTaskDetails).ChildTask = value ?? null /* arrayOf */; }

        /// <summary>The group identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string GroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanGroupTaskDetailsInternal)__recoveryPlanGroupTaskDetails).GroupId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanGroupTaskDetailsInternal)__recoveryPlanGroupTaskDetails).GroupId = value ?? null; }

        /// <summary>The type of task details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IGroupTaskDetailsInternal)__recoveryPlanGroupTaskDetails).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IGroupTaskDetailsInternal)__recoveryPlanGroupTaskDetails).InstanceType = value ?? null; }

        /// <summary>The name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanGroupTaskDetailsInternal)__recoveryPlanGroupTaskDetails).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanGroupTaskDetailsInternal)__recoveryPlanGroupTaskDetails).Name = value ?? null; }

        /// <summary>The group type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string RpGroupType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanGroupTaskDetailsInternal)__recoveryPlanGroupTaskDetails).RpGroupType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanGroupTaskDetailsInternal)__recoveryPlanGroupTaskDetails).RpGroupType = value ?? null; }

        /// <summary>Creates an new <see cref="RecoveryPlanShutdownGroupTaskDetails" /> instance.</summary>
        public RecoveryPlanShutdownGroupTaskDetails()
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
            await eventListener.AssertNotNull(nameof(__recoveryPlanGroupTaskDetails), __recoveryPlanGroupTaskDetails);
            await eventListener.AssertObjectIsValid(nameof(__recoveryPlanGroupTaskDetails), __recoveryPlanGroupTaskDetails);
        }
    }
    /// This class represents the recovery plan shutdown group task details.
    public partial interface IRecoveryPlanShutdownGroupTaskDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanGroupTaskDetails
    {

    }
    /// This class represents the recovery plan shutdown group task details.
    internal partial interface IRecoveryPlanShutdownGroupTaskDetailsInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanGroupTaskDetailsInternal
    {

    }
}