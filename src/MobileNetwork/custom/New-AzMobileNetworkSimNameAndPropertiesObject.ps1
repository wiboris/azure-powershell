
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
Create an in-memory object for SimNameAndProperties.
.Description
Create an in-memory object for SimNameAndProperties.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.SimNameAndProperties
.Link
https://learn.microsoft.com/powershell/module/az.MobileNetwork/new-AzMobileNetworkSimNameAndPropertiesObject
#>
function New-AzMobileNetworkSimNameAndPropertiesObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.SimNameAndProperties')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(HelpMessage="The Ki value for the SIM.")]
        [string]
        $AuthenticationKey,
        [Parameter(HelpMessage="An optional free-form text field that can be used to record the device type this SIM is associated with, for example 'Video camera'. The Azure portal allows SIMs to be grouped and filtered based on this value.")]
        [string]
        $DeviceType,
        [Parameter(HelpMessage="The integrated circuit card ID (ICCID) for the SIM.")]
        [string]
        $IntegratedCircuitCardIdentifier,
        [Parameter(Mandatory, HelpMessage="The international mobile subscriber identity (IMSI) for the SIM.")]
        [string]
        $InternationalMobileSubscriberIdentity,
        [Parameter(Mandatory, HelpMessage="The name of the SIM.")]
        [string]
        $Name,
        [Parameter(HelpMessage="The Opc value for the SIM.")]
        [string]
        $OperatorKeyCode,
        [Parameter(HelpMessage="SIM policy resource ID.")]
        [string]
        $SimPolicyId,
        [Parameter(HelpMessage="A list of static IP addresses assigned to this SIM. Each address is assigned at a defined network scope, made up of {attached data network, slice}.")]
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISimStaticIPProperties[]]
        $StaticIPConfiguration
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.SimNameAndProperties]::New()

        if ($PSBoundParameters.ContainsKey('AuthenticationKey')) {
            $Object.AuthenticationKey = $AuthenticationKey
        }
        if ($PSBoundParameters.ContainsKey('DeviceType')) {
            $Object.DeviceType = $DeviceType
        }
        if ($PSBoundParameters.ContainsKey('IntegratedCircuitCardIdentifier')) {
            $Object.IntegratedCircuitCardIdentifier = $IntegratedCircuitCardIdentifier
        }
        if ($PSBoundParameters.ContainsKey('InternationalMobileSubscriberIdentity')) {
            $Object.InternationalMobileSubscriberIdentity = $InternationalMobileSubscriberIdentity
        }
        if ($PSBoundParameters.ContainsKey('Name')) {
            $Object.Name = $Name
        }
        if ($PSBoundParameters.ContainsKey('OperatorKeyCode')) {
            $Object.OperatorKeyCode = $OperatorKeyCode
        }
        if ($PSBoundParameters.ContainsKey('SimPolicyId')) {
            $Object.SimPolicyId = $SimPolicyId
        }
        if ($PSBoundParameters.ContainsKey('StaticIPConfiguration')) {
            $Object.StaticIPConfiguration = $StaticIPConfiguration
        }
        return $Object
    }
}

