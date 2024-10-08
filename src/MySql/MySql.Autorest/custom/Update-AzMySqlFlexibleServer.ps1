
# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Updates an existing MySQL flexible server. The request body can contain one to many of the properties present in the normal server definition. Use Update-AzMySqlFlexibleServerConfiguration instead if you want update server parameters such as wait_timeout or net_retry_count.
.Description
Updates an existing MySQL flexible server. The request body can contain one to many of the properties present in the normal server definition. Use Update-AzMySqlFlexibleServerConfiguration instead if you want update server parameters such as wait_timeout or net_retry_count.
#>

function Update-AzMySqlFlexibleServer {
    [OutputType([Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerAutoGenerated])]
    [CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    param(
        [Parameter(ParameterSetName='UpdateExpanded', Mandatory, HelpMessage='The name of the server.')]
        [Alias('ServerName')]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Category('Path')]
        [System.String]
        ${Name},

        [Parameter(ParameterSetName='UpdateExpanded', Mandatory, HelpMessage='The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.')]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Category('Path')]
        [System.String]
        ${ResourceGroupName},

        [Parameter(ParameterSetName='UpdateExpanded', HelpMessage='The subscription ID that identifies an Azure subscription.')]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
        [System.String]
        ${SubscriptionId},

        [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline, HelpMessage='Identity Parameter. To construct, see NOTES section for INPUTOBJECT properties and create a hash table.')]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentity]
        ${InputObject},

        [Parameter(HelpMessage='The password of the administrator login.')]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Category('Body')]
        [System.Security.SecureString]
        ${AdministratorLoginPassword},

        [Parameter(HelpMessage='The replication role of the server.')]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Category('Body')]
        [System.String]
        ${ReplicationRole},

        [Parameter(HelpMessage='The name of the sku, typically, tier + family + cores, e.g. Burstable_B1ms, Standard_D2ds_v4')]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Category('Body')]
        [System.String]
        ${Sku},

        [Parameter(HelpMessage='The tier of the particular SKU. Accepted values: Burstable, GeneralPurpose, Memory Optimized. Default: Burstable.')]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.SkuTier])]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.SkuTier]
        ${SkuTier},

        [Parameter(HelpMessage = 'Enable or disable high availability feature.  Default value is Disabled. Default: Disabled.')]
        [Validateset('ZoneRedundant', 'SameZone', 'Disabled')]
        [Alias('HaEnabled')]
        [System.String]
        ${HighAvailability},

        [Parameter(HelpMessage='Backup retention days for the server. Day count is between 7 and 35.')]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Category('Body')]
        [System.Int32]
        ${BackupRetentionDay},

        [Parameter(HelpMessage='Enable or disable Storage Auto Grow. The default value is Disabled')]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.StorageAutogrow])]
        [Validateset('Enabled', 'Disabled')]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.StorageAutogrow]
        ${StorageAutogrow},

        [Parameter(HelpMessage='Max storage allowed for a server.')]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Category('Body')]
        [System.Int32]
        ${StorageInMb},

        [Parameter(HelpMessage = 'Application-specific metadata in the form of key-value pairs.')]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerForUpdateTags]))]
        [System.Collections.Hashtable]
        ${Tag},

        [Parameter(HelpMessage='Period of time (UTC) designated for maintenance. Examples: "Sun:23:30" to schedule on Sunday, 11:30pm UTC. To set back to default pass in "Disabled"')]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Category('Body')]
        [System.String]
        ${MaintenanceWindow},

        [Parameter(HelpMessage = 'The credentials, account, tenant, and subscription used for communication with Azure.')]
        [Alias('AzureRMContext', 'AzureCredential')]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Category('Azure')]
        [System.Management.Automation.PSObject]
        ${DefaultProfile},

        [Parameter(HelpMessage = 'Run the command as a job.')]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        ${AsJob},

        [Parameter(DontShow, HelpMessage = 'Wait for .NET debugger to attach.')]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        ${Break},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be appended to the front of the pipeline.
        ${HttpPipelineAppend},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be prepended to the front of the pipeline.
        ${HttpPipelinePrepend},

        [Parameter(HelpMessage = 'Run the command asynchronously.')]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        ${NoWait},

        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Category('Runtime')]
        [System.Uri]
        # The URI for the proxy server to use.
        ${Proxy},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Category('Runtime')]
        [System.Management.Automation.PSCredential]
        # Credentials for a proxy server to use for the remote call.
        ${ProxyCredential},

        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Use the default credentials for the proxy.
        ${ProxyUseDefaultCredentials}
    )

    process {
        try {
            if ($PSBoundParameters.ContainsKey('StorageInMb')) {
                $PSBoundParameters.StorageSizeGb = [Math]::floor($PSBoundParameters['StorageInMb'] / 1024)
                $null = $PSBoundParameters.Remove('StorageInMb')
            }

            if ($PSBoundParameters.ContainsKey('Sku')) {
                $PSBoundParameters.SkuName = $PSBoundParameters['Sku']
                $null = $PSBoundParameters.Remove('Sku')
            }

            if ($PSBoundParameters.ContainsKey('StorageAutogrow')){
                if ($PSBoundParameters['StorageAutogrow'] -eq 'Enabled') {
                    $PSBoundParameters.StorageAutoGrow = [Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.StorageAutogrow]::Enabled
                }
                else {
                    $PSBoundParameters.StorageAutoGrow = [Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.StorageAutogrow]::Disabled
                }
                $null = $PSBoundParameters.Remove('StorageAutogrow')
            }

            if ($PSBoundParameters.ContainsKey('Iops')) {
                $PSBoundParameters.StorageIop = $PSBoundParameters.Iops
                $null = $PSBoundParameters.Remove('Iops')
            }

            if ($PSBoundParameters.ContainsKey('HighAvailability')){
                if($PSBoundParameters['HighAvailability'].ToLower() -eq 'disabled'){
                    $PSBoundParameters.HighAvailabilityMode = [Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.HighAvailabilityMode]::Disabled
                }
                elseif($PSBoundParameters['HighAvailability'].ToLower() -eq 'zoneredundant') {
                    $PSBoundParameters.HighAvailabilityMode = [Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.HighAvailabilityMode]::ZoneRedundant
                }
                elseif($PSBoundParameters['HighAvailability'].ToLower() -eq 'samezone') {
                    $PSBoundParameters.HighAvailabilityMode = [Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.HighAvailabilityMode]::SameZone
                }
                $null = $PSBoundParameters.Remove('HighAvailability')
            }

            if ($PSBoundParameters.ContainsKey('MaintenanceWindow')) {
                Write-Host "If you are updating maintenance window, do NOT update other parameters together"
                $PSBoundParameters.MaintenanceWindowDayOfWeek = $null
                $PSBoundParameters.MaintenanceWindowStartHour = $null
                $PSBoundParameters.MaintenanceWindowStartMinute = $null
                
                if ($PSBoundParameters.MaintenanceWindow.ToLower() -eq "disabled"){
                    $PSBoundParameters.MaintenanceWindowDayOfWeek = 0
                    $PSBoundParameters.MaintenanceWindowStartHour = 0
                    $PSBoundParameters.MaintenanceWindowStartMinute = 0
                    $PSBoundParameters.MaintenanceWindowCustomWindow = "Disabled"
                }
                else {
                    $ParsedWindow = $PSBoundParameters.MaintenanceWindow -split ":"
                    $DaytoNumber = @{Mon = 1; Tue = 2; Wed = 3; Thur = 4; Fri = 5; Sat = 6; Sun = 0}
                    
                    if ($ParsedWindow.Length -ge 1){
                        $PSBoundParameters.MaintenanceWindowDayOfWeek =  $DaytoNumber[$ParsedWindow[0]]
                    }
                    
                    if ($ParsedWindow.Length -ge 2){
                        $PSBoundParameters.MaintenanceWindowStartHour = $ParsedWindow[1]
                    }

                    if ($ParsedWindow.Length -ge 3){
                        $PSBoundParameters.MaintenanceWindowStartMinute = $ParsedWindow[2]
                    }
                    
                    $PSBoundParameters.MaintenanceWindowCustomWindow = "Enabled"
                }

                $null = $PSBoundParameters.Remove('MaintenanceWindow')
            }

            Az.MySql.internal\Update-AzMySqlFlexibleServer @PSBoundParameters
        } catch {
            throw
        }
    }
}
