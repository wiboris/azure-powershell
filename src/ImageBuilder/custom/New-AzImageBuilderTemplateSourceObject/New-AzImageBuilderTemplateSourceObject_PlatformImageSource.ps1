
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
Create an in-memory object for ImageTemplateSource.
.Description
Create an in-memory object for ImageTemplateSource.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220701.ImageTemplatePlatformImageSource
.Link
https://learn.microsoft.com/powershell/module/az.ImageBuilder/new-azimagebuildertemplatesourceobject
#>
function New-AzImageBuilderTemplateSourceObject_PlatformImageSource {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220701.ImageTemplatePlatformImageSource')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(HelpMessage="Image offer from the [Azure Gallery Images](https://learn.microsoft.com/en-us/rest/api/compute/virtualmachineimages).")]
        [string]
        $Offer,
        [Parameter(HelpMessage="Name of the purchase plan.")]
        [string]
        $PlanInfoPlanName,
        [Parameter(HelpMessage="Product of the purchase plan.")]
        [string]
        $PlanInfoPlanProduct,
        [Parameter(HelpMessage="Publisher of the purchase plan.")]
        [string]
        $PlanInfoPlanPublisher,
        [Parameter(HelpMessage="Image Publisher in [Azure Gallery Images](https://learn.microsoft.com/en-us/rest/api/compute/virtualmachineimages).")]
        [string]
        $Publisher,
        [Parameter(HelpMessage="Image sku from the [Azure Gallery Images](https://learn.microsoft.com/en-us/rest/api/compute/virtualmachineimages).")]
        [string]
        $Sku,
        [Parameter(HelpMessage="Image version from the [Azure Gallery Images](https://learn.microsoft.com/en-us/rest/api/compute/virtualmachineimages). If 'latest' is specified here, the version is evaluated when the image build takes place, not when the template is submitted.")]
        [string]
        $Version,
        # Change it to switch parameter
        # [Parameter(Mandatory, HelpMessage="Specifies the type of source image you want to start with.")]
        # [string]
        # $Type
        [Parameter(Mandatory, HelpMessage="Describes an image source from [Azure Gallery Images](https://learn.microsoft.com/en-us/rest/api/compute/virtualmachineimages).")]
        [Switch]
        $PlatformImageSource
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220701.ImageTemplatePlatformImageSource]::New()

        if ($PSBoundParameters.ContainsKey('Offer')) {
            $Object.Offer = $Offer
        }
        if ($PSBoundParameters.ContainsKey('PlanInfoPlanName')) {
            $Object.PlanInfoPlanName = $PlanInfoPlanName
        }
        if ($PSBoundParameters.ContainsKey('PlanInfoPlanProduct')) {
            $Object.PlanInfoPlanProduct = $PlanInfoPlanProduct
        }
        if ($PSBoundParameters.ContainsKey('PlanInfoPlanPublisher')) {
            $Object.PlanInfoPlanPublisher = $PlanInfoPlanPublisher
        }
        if ($PSBoundParameters.ContainsKey('Publisher')) {
            $Object.Publisher = $Publisher
        }
        if ($PSBoundParameters.ContainsKey('Sku')) {
            $Object.Sku = $Sku
        }
        if ($PSBoundParameters.ContainsKey('Version')) {
            $Object.Version = $Version
        }
        if ($PlatformImageSource.IsPresent) {
            $Object.Type = "PlatformImage"
        }
        return $Object
    }
}

