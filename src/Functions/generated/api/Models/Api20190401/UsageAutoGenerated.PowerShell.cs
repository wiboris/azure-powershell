// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401
{
    using Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.PowerShell;

    /// <summary>Describes Storage Resource Usage.</summary>
    [System.ComponentModel.TypeConverter(typeof(UsageAutoGeneratedTypeConverter))]
    public partial class UsageAutoGenerated
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.UsageAutoGenerated"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IUsageAutoGenerated" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IUsageAutoGenerated DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new UsageAutoGenerated(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.UsageAutoGenerated"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IUsageAutoGenerated" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IUsageAutoGenerated DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new UsageAutoGenerated(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="UsageAutoGenerated" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="UsageAutoGenerated" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IUsageAutoGenerated FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.UsageAutoGenerated"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal UsageAutoGenerated(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IUsageAutoGeneratedInternal)this).Name = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IUsageName) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IUsageAutoGeneratedInternal)this).Name, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.UsageNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("Unit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IUsageAutoGeneratedInternal)this).Unit = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.UsageUnit?) content.GetValueForProperty("Unit",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IUsageAutoGeneratedInternal)this).Unit, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.UsageUnit.CreateFrom);
            }
            if (content.Contains("CurrentValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IUsageAutoGeneratedInternal)this).CurrentValue = (int?) content.GetValueForProperty("CurrentValue",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IUsageAutoGeneratedInternal)this).CurrentValue, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Limit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IUsageAutoGeneratedInternal)this).Limit = (int?) content.GetValueForProperty("Limit",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IUsageAutoGeneratedInternal)this).Limit, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("NameValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IUsageAutoGeneratedInternal)this).NameValue = (string) content.GetValueForProperty("NameValue",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IUsageAutoGeneratedInternal)this).NameValue, global::System.Convert.ToString);
            }
            if (content.Contains("NameLocalizedValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IUsageAutoGeneratedInternal)this).NameLocalizedValue = (string) content.GetValueForProperty("NameLocalizedValue",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IUsageAutoGeneratedInternal)this).NameLocalizedValue, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.UsageAutoGenerated"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal UsageAutoGenerated(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IUsageAutoGeneratedInternal)this).Name = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IUsageName) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IUsageAutoGeneratedInternal)this).Name, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.UsageNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("Unit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IUsageAutoGeneratedInternal)this).Unit = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.UsageUnit?) content.GetValueForProperty("Unit",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IUsageAutoGeneratedInternal)this).Unit, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.UsageUnit.CreateFrom);
            }
            if (content.Contains("CurrentValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IUsageAutoGeneratedInternal)this).CurrentValue = (int?) content.GetValueForProperty("CurrentValue",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IUsageAutoGeneratedInternal)this).CurrentValue, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Limit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IUsageAutoGeneratedInternal)this).Limit = (int?) content.GetValueForProperty("Limit",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IUsageAutoGeneratedInternal)this).Limit, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("NameValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IUsageAutoGeneratedInternal)this).NameValue = (string) content.GetValueForProperty("NameValue",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IUsageAutoGeneratedInternal)this).NameValue, global::System.Convert.ToString);
            }
            if (content.Contains("NameLocalizedValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IUsageAutoGeneratedInternal)this).NameLocalizedValue = (string) content.GetValueForProperty("NameLocalizedValue",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190401.IUsageAutoGeneratedInternal)this).NameLocalizedValue, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }
    }
    /// Describes Storage Resource Usage.
    [System.ComponentModel.TypeConverter(typeof(UsageAutoGeneratedTypeConverter))]
    public partial interface IUsageAutoGenerated

    {

    }
}