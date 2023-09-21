# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for license information.
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create a service config profile.
.Description
Create a service config profile.
.Example
$coreSiteConfigFile=New-AzHDInsightAksClusterConfigFile -FileName "core-site.xml" -Value @{"fs.defaultFS"="abfs://testcontainer@$teststorage.dfs.core.windows.net"}
$yarnComponentConfig= New-AzHdInsightOnAksClusterServiceConfigObject -ComponentName "yarn-config" -File $coreSiteConfigFile
$yarnServiceConfigProfile=New-AzHdInsightOnAksClusterServiceConfigsProfileObject -ServiceName "yarn-service" -Config $yarnComponentConfig

.Inputs
System.String
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterServiceConfig[]
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.ICluster
.Notes

.Link
https://learn.microsoft.com/powershell/module/az.hdinsightonaks/New-AzHdInsightOnAksClusterServiceConfigsProfileObject
#>
function New-AzHdInsightOnAksClusterServiceConfigsProfileObject {
    [OutputType([Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterServiceConfigsProfile])]
    [CmdletBinding(DefaultParameterSetName = 'Create', PositionalBinding = $false, SupportsShouldProcess)]
    param(
        [Parameter(ParameterSetName = 'Create', Mandatory)]
        [Alias('Name')]
        [System.String]
        # Name of the service the configurations should apply to.
        ${ServiceName},

        [Parameter(ParameterSetName = 'Create', Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterServiceConfig[]]
        # List of service configs.
        ${Config}
    )

    process {
        try {
            $clusterServiceConfigsProfile = New-Object Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.ClusterServiceConfigsProfile -Property @{ServiceName = $ServiceName; Config = $Config }
            return $clusterServiceConfigsProfile
        }
        catch {
       
            throw
        }

        finally {
      
        }

    }
}