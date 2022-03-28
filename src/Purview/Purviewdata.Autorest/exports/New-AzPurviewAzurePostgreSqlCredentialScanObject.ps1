
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
Create an in-memory object for AzurePostgreSqlCredentialScan.
.Description
Create an in-memory object for AzurePostgreSqlCredentialScan.
.Example
PS C:\> New-AzPurviewAzurePostgreSqlCredentialScanObject -Kind 'AzurePostgreSqlCredential' -CollectionReferenceName 'parv-brs-2' -CollectionType 'CollectionReference' -CredentialReferenceName 'sqlauth' -CredentialType 'SqlAuth' -DatabaseName 'db' -Port 5432 -SslMode 1 -ScanRulesetName 'AzurePostgreSql' -ScanRulesetType 'System' -ServerEndpoint 'anstzn.postgres.database.azure.com'

CollectionLastModifiedAt  :
CollectionReferenceName   : parv-brs-2
CollectionType            : CollectionReference
ConnectedViaReferenceName :
CreatedAt                 :
CredentialReferenceName   : sqlauth
CredentialType            : SqlAuth
DatabaseName              : db
Id                        :
Kind                      : AzurePostgreSqlCredential
LastModifiedAt            :
Name                      :
Port                      : 5432
Result                    :
ScanRulesetName           : AzurePostgreSql
ScanRulesetType           : System
ServerEndpoint            : anstzn.postgres.database.azure.com
SslMode                   : 1
Worker                    :

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.AzurePostgreSqlCredentialScan
.Link
https://docs.microsoft.com/powershell/module/az.Purview/new-AzPurviewAzurePostgreSqlCredentialScanObject
#>
function New-AzPurviewAzurePostgreSqlCredentialScanObject {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.AzurePostgreSqlCredentialScan])]
[CmdletBinding(PositionalBinding=$false)]
param(
    [Parameter(Mandatory)]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.ScanAuthorizationType])]
    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.ScanAuthorizationType]
    ${Kind},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Category('Body')]
    [System.String]
    ${CollectionReferenceName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Category('Body')]
    [System.String]
    ${CollectionType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Category('Body')]
    [System.String]
    ${ConnectedViaReferenceName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Category('Body')]
    [System.String]
    ${CredentialReferenceName},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.CredentialType])]
    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.CredentialType]
    ${CredentialType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Category('Body')]
    [System.String]
    ${DatabaseName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Category('Body')]
    [System.Int32]
    ${Port},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Category('Body')]
    [System.String]
    ${ScanRulesetName},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.ScanRulesetType])]
    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.ScanRulesetType]
    ${ScanRulesetType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Category('Body')]
    [System.String]
    ${ServerEndpoint},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Category('Body')]
    [System.Int32]
    ${SslMode},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Category('Body')]
    [System.Int32]
    ${Worker}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            __AllParameterSets = 'Az.Purviewdata.custom\New-AzPurviewAzurePostgreSqlCredentialScanObject';
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}
