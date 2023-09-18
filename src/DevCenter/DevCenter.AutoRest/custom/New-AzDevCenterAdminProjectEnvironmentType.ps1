
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Creates or updates a project environment type.
.Description
Creates or updates a project environment type.
.Example
{{ Add code here }}
.Example
{{ Add code here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectEnvironmentType
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.IDevCenterIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectEnvironmentType
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IProjectEnvironmentType>: Represents an environment type.
  [SystemDataCreatedAt <DateTime?>]: The timestamp of resource creation (UTC).
  [SystemDataCreatedBy <String>]: The identity that created the resource.
  [SystemDataCreatedByType <CreatedByType?>]: The type of identity that created the resource.
  [SystemDataLastModifiedAt <DateTime?>]: The timestamp of resource last modification (UTC)
  [SystemDataLastModifiedBy <String>]: The identity that last modified the resource.
  [SystemDataLastModifiedByType <CreatedByType?>]: The type of identity that last modified the resource.
  [CreatorRoleAssignmentRole <IProjectEnvironmentTypeUpdatePropertiesCreatorRoleAssignmentRoles>]: A map of roles to assign to the environment creator.
    [(Any) <IEnvironmentRole>]: This indicates any property can be added to this object.
  [DeploymentTargetId <String>]: Id of a subscription that the environment type will be mapped to. The environment's resources will be deployed into this subscription.
  [IdentityType <ManagedServiceIdentityType?>]: Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).
  [IdentityUserAssignedIdentity <IUserAssignedIdentities>]: The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}. The dictionary values can be empty objects ({}) in requests.
    [(Any) <IUserAssignedIdentity>]: This indicates any property can be added to this object.
  [Location <String>]: The geo-location for the environment type
  [Status <EnvironmentTypeEnableStatus?>]: Defines whether this Environment Type can be used in this Project.
  [Tag <ITags>]: Resource tags.
    [(Any) <String>]: This indicates any property can be added to this object.
  [UserRoleAssignment <IProjectEnvironmentTypeUpdatePropertiesUserRoleAssignments>]: Role Assignments created on environment backing resources. This is a mapping from a user object ID to an object of role definition IDs.
    [(Any) <IUserRoleAssignmentValue>]: This indicates any property can be added to this object.

INPUTOBJECT <IDevCenterIdentity>: Identity Parameter
  [AttachedNetworkConnectionName <String>]: The name of the attached NetworkConnection.
  [CatalogName <String>]: The name of the Catalog.
  [DevBoxDefinitionName <String>]: The name of the Dev Box definition.
  [DevCenterName <String>]: The name of the devcenter.
  [EnvironmentTypeName <String>]: The name of the environment type.
  [GalleryName <String>]: The name of the gallery.
  [Id <String>]: Resource identity path
  [ImageName <String>]: The name of the image.
  [Location <String>]: The Azure region
  [NetworkConnectionName <String>]: Name of the Network Connection that can be applied to a Pool.
  [OperationId <String>]: The ID of an ongoing async operation
  [PoolName <String>]: Name of the pool.
  [ProjectName <String>]: The name of the project.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [ScheduleName <String>]: The name of the schedule that uniquely identifies it.
  [SubscriptionId <String>]: The ID of the target subscription.
  [VersionName <String>]: The version of the image.
.Link
https://learn.microsoft.com/powershell/module/az.devcenter/new-azdevcenteradminprojectenvironmenttype
#>
function New-AzDevCenterAdminProjectEnvironmentType {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectEnvironmentType])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Path')]
    [System.String]
    # The name of the environment type.
    ${EnvironmentTypeName},

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Path')]
    [System.String]
    # The name of the project.
    ${ProjectName},

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='CreateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.IDevCenterIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectEnvironmentTypeUpdatePropertiesCreatorRoleAssignmentRoles]))]
    [System.Collections.Hashtable]
    # A map of roles to assign to the environment creator.
    ${CreatorRoleAssignmentRole},

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Body')]
    [System.String]
    # Id of a subscription that the environment type will be mapped to.
    # The environment's resources will be deployed into this subscription.
    ${DeploymentTargetId},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded')]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ManagedServiceIdentityType])]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ManagedServiceIdentityType]
    # Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).
    ${IdentityType},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api40.IUserAssignedIdentities]))]
    [System.Collections.Hashtable]
    # The set of user assigned identities associated with the resource.
    # The userAssignedIdentities dictionary keys will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.
    # The dictionary values can be empty objects ({}) in requests.
    ${IdentityUserAssignedIdentity},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Body')]
    [System.String]
    # The geo-location for the environment type
    ${Location},

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded', Mandatory)]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.EnvironmentTypeEnableStatus])]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.EnvironmentTypeEnableStatus]
    # Defines whether this Environment Type can be used in this Project.
    ${Status},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.ITags]))]
    [System.Collections.Hashtable]
    # Resource tags.
    ${Tag},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IProjectEnvironmentTypeUpdatePropertiesUserRoleAssignments]))]
    [System.Collections.Hashtable]
    # Role Assignments created on environment backing resources.
    # This is a mapping from a user object ID to an object of role definition IDs.
    ${UserRoleAssignment},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

process {
    Az.DevCenter.internal\New-AzDevCenterAdminProjectEnvironmentType @PSBoundParameters
}

}
