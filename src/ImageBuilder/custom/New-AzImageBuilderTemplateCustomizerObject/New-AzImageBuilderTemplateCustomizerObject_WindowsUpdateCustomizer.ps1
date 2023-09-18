
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
Create an in-memory object for ImageTemplateCustomizer.
.Description
Create an in-memory object for ImageTemplateCustomizer.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220701.ImageTemplateWindowsUpdateCustomizer
.Link
https://learn.microsoft.com/powershell/module/az.ImageBuilder/new-azimagebuildertemplatecustomizerobject
#>
function New-AzImageBuilderTemplateCustomizerObject_WindowsUpdateCustomizer {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220701.ImageTemplateWindowsUpdateCustomizer')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(HelpMessage="Array of filters to select updates to apply. Omit or specify empty array to use the default (no filter). Refer to above link for examples and detailed description of this field.")]
        [string[]]
        $Filter,
        [Parameter(HelpMessage="Criteria to search updates. Omit or specify empty string to use the default (search all). Refer to above link for examples and detailed description of this field.")]
        [string]
        $SearchCriterion,
        [Parameter(HelpMessage="Maximum number of updates to apply at a time. Omit or specify 0 to use the default (1000).")]
        [int]
        $UpdateLimit,
        [Parameter(HelpMessage="Friendly Name to provide context on what this customization step does.")]
        [string]
        $Name,
        # Change it to switch parameter
        # [Parameter(Mandatory, HelpMessage="The type of customization tool you want to use on the Image. For example, `"Shell`" can be shell customizer.")]
        # [string]
        # $Type
        [Parameter(Mandatory, HelpMessage="Installs Windows Updates. Corresponds to Packer Windows Update Provisioner (https://github.com/rgl/packer-provisioner-windows-update)")]
        [Switch]
        $WindowsUpdateCustomizer
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220701.ImageTemplateWindowsUpdateCustomizer]::New()

        if ($PSBoundParameters.ContainsKey('Filter')) {
            $Object.Filter = $Filter
        }
        if ($PSBoundParameters.ContainsKey('SearchCriterion')) {
            $Object.SearchCriterion = $SearchCriterion
        }
        if ($PSBoundParameters.ContainsKey('UpdateLimit')) {
            $Object.UpdateLimit = $UpdateLimit
        }
        if ($PSBoundParameters.ContainsKey('Name')) {
            $Object.Name = $Name
        }
        if ($WindowsUpdateCustomizer.IsPresent) {
            $Object.Type = "WindowsUpdate"
        }
        return $Object
    }
}

