
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
Creates or updates an environment.
.Description
Creates or updates an environment.
.Example
{{ Add code here }}
.Example
{{ Add code here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20230401.IEnvironment
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.IDevCenterdataIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IEnvironment>: Properties of an environment.
  CatalogName <String>: Name of the catalog.
  DefinitionName <String>: Name of the environment definition.
  Type <String>: Environment type.
  [Parameter <IAny>]: Parameters object for the environment.
  [Code <String>]: An identifier for the error. Codes are invariant and are intended to be consumed programmatically.
  [Detail <ICloudErrorBody[]>]: A list of additional details about the error.
    Code <String>: An identifier for the error. Codes are invariant and are intended to be consumed programmatically.
    Message <String>: A message describing the error, intended to be suitable for display in a user interface.
    [Detail <ICloudErrorBody[]>]: A list of additional details about the error.
    [Target <String>]: The target of the particular error. For example, the name of the property in error.
  [Message <String>]: A message describing the error, intended to be suitable for display in a user interface.
  [OperationLocation <String>]: 
  [Target <String>]: The target of the particular error. For example, the name of the property in error.

INPUTOBJECT <IDevCenterdataIdentity>: Identity Parameter
  [ActionName <String>]: The name of an action that will take place on a Dev Box.
  [CatalogName <String>]: The name of the catalog
  [DefinitionName <String>]: The name of the environment definition
  [DevBoxName <String>]: The name of a Dev Box.
  [EnvironmentName <String>]: The name of the environment.
  [Id <String>]: Resource identity path
  [PoolName <String>]: The name of a pool of Dev Boxes.
  [ProjectName <String>]: The DevCenter Project upon which to execute operations.
  [ScheduleName <String>]: The name of a schedule.
  [UserId <String>]: The AAD object id of the user. If value is 'me', the identity is taken from the authentication context.
.Link
https://learn.microsoft.com/powershell/module/az.devcenter/new-azdevcenteruserenvironment
#>
function New-AzDevCenterUserEnvironment {
  [OutputType([System.Boolean])]
  [CmdletBinding(DefaultParameterSetName = 'CreateExpanded', PositionalBinding = $false, SupportsShouldProcess, ConfirmImpact = 'Medium')]
  param(
    [Parameter(ParameterSetName = 'CreateExpanded', Mandatory)]
    [Parameter(ParameterSetName = 'CreateViaIdentityExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Category('Uri')]
    [System.String]
    # The DevCenter-specific URI to operate on.
    ${Endpoint},
  
    [Parameter(ParameterSetName = 'CreateViaIdentityExpandedByDevCenter', Mandatory)]
    [Parameter(ParameterSetName = 'CreateExpandedByDevCenter', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Category('Uri')]
    [System.String]
    # The DevCenter upon which to execute operations.
    ${DevCenter},
  
    [Parameter(ParameterSetName = 'CreateExpanded', Mandatory)]
    [Parameter(ParameterSetName = 'CreateExpandedByDevCenter', Mandatory)]
    [Alias('EnvironmentName')]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Category('Path')]
    [System.String]
    # The name of the environment.
    ${Name},
  
    [Parameter(ParameterSetName = 'CreateExpanded', Mandatory)]
    [Parameter(ParameterSetName = 'CreateExpandedByDevCenter', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Category('Path')]
    [System.String]
    # The DevCenter Project upon which to execute operations.
    ${ProjectName},
  
    [Parameter(ParameterSetName = 'CreateExpanded')]
    [Parameter(ParameterSetName = 'CreateExpandedByDevCenter')]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Runtime.DefaultInfo(Script = '"me"')]
    [System.String]
    # The AAD object id of the user.
    # If value is 'me', the identity is taken from the authentication context.
    ${UserId},
  
    [Parameter(ParameterSetName = 'CreateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName = 'CreateViaIdentityExpandedByDevCenter', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.IDevCenterdataIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},
  
    [Parameter(ParameterSetName = 'CreateExpanded', Mandatory)]
    [Parameter(ParameterSetName = 'CreateViaIdentityExpanded', Mandatory)]
    [Parameter(ParameterSetName = 'CreateViaIdentityExpandedByDevCenter', Mandatory)]
    [Parameter(ParameterSetName = 'CreateExpandedByDevCenter', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Category('Body')]
    [System.String]
    # Name of the catalog.
    ${CatalogName},
  
    [Parameter(ParameterSetName = 'CreateExpanded', Mandatory)]
    [Parameter(ParameterSetName = 'CreateViaIdentityExpanded', Mandatory)]
    [Parameter(ParameterSetName = 'CreateViaIdentityExpandedByDevCenter', Mandatory)]
    [Parameter(ParameterSetName = 'CreateExpandedByDevCenter', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Category('Body')]
    [System.String]
    # Name of the environment definition.
    ${EnvironmentDefinitionName},
  
    [Parameter(ParameterSetName = 'CreateExpanded', Mandatory)]
    [Parameter(ParameterSetName = 'CreateViaIdentityExpanded', Mandatory)]
    [Parameter(ParameterSetName = 'CreateViaIdentityExpandedByDevCenter', Mandatory)]
    [Parameter(ParameterSetName = 'CreateExpandedByDevCenter', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Category('Body')]
    [System.String]
    # Environment type.
    ${EnvironmentType},
  
    [Parameter(ParameterSetName = 'CreateExpanded')]
    [Parameter(ParameterSetName = 'CreateViaIdentityExpanded')]
    [Parameter(ParameterSetName = 'CreateViaIdentityExpandedByDevCenter')]
    [Parameter(ParameterSetName = 'CreateExpandedByDevCenter')]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20230401.IEnvironmentUpdatePropertiesParameters]))]
    [System.Collections.Hashtable]
    # Parameters object for the environment.
    ${Parameter},
  
    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},
  
    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},
  
    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},
  
    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},
  
    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},
  
    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},
  
    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},
  
    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},
  
    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
  )

  process {
    if (-not $PSBoundParameters.ContainsKey('Endpoint')) {
      $Endpoint = GetEndpointFromResourceGraph -DevCenter $DevCenter -Project $ProjectName
      $null = $PSBoundParameters.Add("Endpoint", $Endpoint)
      $null = $PSBoundParameters.Remove("DevCenter")

    }
    else {
      $Endpoint = ValidateAndProcessEndpoint -Endpoint $Endpoint
      $PSBoundParameters["Endpoint"] = $Endpoint
    }

    Az.DevCenterdata.internal\New-AzDevCenterUserEnvironment @PSBoundParameters
  }
}
