
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
Create an in-memory object for IPSecurityRestrictionRule.
.Description
Create an in-memory object for IPSecurityRestrictionRule.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.App.Models.IPSecurityRestrictionRule
.Link
https://learn.microsoft.com/powershell/module/Az.App/new-azappipsecurityrestrictionruleobject
#>
function New-AzAppIPSecurityRestrictionRuleObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.App.Models.IPSecurityRestrictionRule')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(Mandatory, HelpMessage="Allow or Deny rules to determine for incoming IP. Note: Rules can only consist of ALL Allow or ALL Deny.")]
        [Microsoft.Azure.PowerShell.Cmdlets.App.PSArgumentCompleterAttribute("Allow", "Deny")]
        [string]
        $Action,
        [Parameter(HelpMessage="Describe the IP restriction rule that is being sent to the container-app. This is an optional field.")]
        [string]
        $Description,
        [Parameter(Mandatory, HelpMessage="CIDR notation to match incoming IP address.")]
        [string]
        $IPAddressRange,
        [Parameter(Mandatory, HelpMessage="Name for the IP restriction rule.")]
        [string]
        $Name
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.App.Models.IPSecurityRestrictionRule]::New()

        if ($PSBoundParameters.ContainsKey('Action')) {
            $Object.Action = $Action
        }
        if ($PSBoundParameters.ContainsKey('Description')) {
            $Object.Description = $Description
        }
        if ($PSBoundParameters.ContainsKey('IPAddressRange')) {
            $Object.IPAddressRange = $IPAddressRange
        }
        if ($PSBoundParameters.ContainsKey('Name')) {
            $Object.Name = $Name
        }
        return $Object
    }
}

