// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101
{
    using Microsoft.Azure.PowerShell.Cmdlets.Relay.Runtime.PowerShell;

    /// <summary>Description of hybrid connection resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(HybridConnectionTypeConverter))]
    public partial class HybridConnection
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
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.HybridConnection"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnection" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnection DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new HybridConnection(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.HybridConnection"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnection" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnection DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new HybridConnection(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="HybridConnection" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="HybridConnection" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnection FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Relay.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.HybridConnection"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal HybridConnection(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.HybridConnectionPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api30.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api30.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20170401.IProxyResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20170401.IProxyResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20170401.IProxyResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20170401.IProxyResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20170401.IProxyResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20170401.IProxyResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20170401.IProxyResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20170401.IProxyResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("CreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).CreatedAt = (global::System.DateTime?) content.GetValueForProperty("CreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).CreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("UpdatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).UpdatedAt = (global::System.DateTime?) content.GetValueForProperty("UpdatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).UpdatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ListenerCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).ListenerCount = (int?) content.GetValueForProperty("ListenerCount",((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).ListenerCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("RequiresClientAuthorization"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).RequiresClientAuthorization = (bool?) content.GetValueForProperty("RequiresClientAuthorization",((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).RequiresClientAuthorization, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("UserMetadata"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).UserMetadata = (string) content.GetValueForProperty("UserMetadata",((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).UserMetadata, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.Relay.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.Relay.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.Relay.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.Relay.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.HybridConnection"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal HybridConnection(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.HybridConnectionPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api30.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api30.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20170401.IProxyResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20170401.IProxyResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20170401.IProxyResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20170401.IProxyResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20170401.IProxyResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20170401.IProxyResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20170401.IProxyResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20170401.IProxyResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("CreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).CreatedAt = (global::System.DateTime?) content.GetValueForProperty("CreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).CreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("UpdatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).UpdatedAt = (global::System.DateTime?) content.GetValueForProperty("UpdatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).UpdatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ListenerCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).ListenerCount = (int?) content.GetValueForProperty("ListenerCount",((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).ListenerCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("RequiresClientAuthorization"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).RequiresClientAuthorization = (bool?) content.GetValueForProperty("RequiresClientAuthorization",((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).RequiresClientAuthorization, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("UserMetadata"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).UserMetadata = (string) content.GetValueForProperty("UserMetadata",((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).UserMetadata, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.Relay.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.Relay.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.Relay.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.Relay.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IHybridConnectionInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Relay.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// Description of hybrid connection resource.
    [System.ComponentModel.TypeConverter(typeof(HybridConnectionTypeConverter))]
    public partial interface IHybridConnection

    {

    }
}