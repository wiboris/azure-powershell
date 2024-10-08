// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201
{
    using Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.PowerShell;

    /// <summary>CustomHostnameSites resource specific properties</summary>
    [System.ComponentModel.TypeConverter(typeof(CustomHostnameSitesPropertiesTypeConverter))]
    public partial class CustomHostnameSitesProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.CustomHostnameSitesProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal CustomHostnameSitesProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("CustomHostname"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ICustomHostnameSitesPropertiesInternal)this).CustomHostname = (string) content.GetValueForProperty("CustomHostname",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ICustomHostnameSitesPropertiesInternal)this).CustomHostname, global::System.Convert.ToString);
            }
            if (content.Contains("Region"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ICustomHostnameSitesPropertiesInternal)this).Region = (string) content.GetValueForProperty("Region",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ICustomHostnameSitesPropertiesInternal)this).Region, global::System.Convert.ToString);
            }
            if (content.Contains("SiteResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ICustomHostnameSitesPropertiesInternal)this).SiteResourceId = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IIdentifier[]) content.GetValueForProperty("SiteResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ICustomHostnameSitesPropertiesInternal)this).SiteResourceId, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IIdentifier>(__y, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IdentifierTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.CustomHostnameSitesProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal CustomHostnameSitesProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("CustomHostname"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ICustomHostnameSitesPropertiesInternal)this).CustomHostname = (string) content.GetValueForProperty("CustomHostname",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ICustomHostnameSitesPropertiesInternal)this).CustomHostname, global::System.Convert.ToString);
            }
            if (content.Contains("Region"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ICustomHostnameSitesPropertiesInternal)this).Region = (string) content.GetValueForProperty("Region",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ICustomHostnameSitesPropertiesInternal)this).Region, global::System.Convert.ToString);
            }
            if (content.Contains("SiteResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ICustomHostnameSitesPropertiesInternal)this).SiteResourceId = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IIdentifier[]) content.GetValueForProperty("SiteResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ICustomHostnameSitesPropertiesInternal)this).SiteResourceId, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IIdentifier>(__y, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IdentifierTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.CustomHostnameSitesProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ICustomHostnameSitesProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ICustomHostnameSitesProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new CustomHostnameSitesProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.CustomHostnameSitesProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ICustomHostnameSitesProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ICustomHostnameSitesProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new CustomHostnameSitesProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="CustomHostnameSitesProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="CustomHostnameSitesProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ICustomHostnameSitesProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// CustomHostnameSites resource specific properties
    [System.ComponentModel.TypeConverter(typeof(CustomHostnameSitesPropertiesTypeConverter))]
    public partial interface ICustomHostnameSitesProperties

    {

    }
}