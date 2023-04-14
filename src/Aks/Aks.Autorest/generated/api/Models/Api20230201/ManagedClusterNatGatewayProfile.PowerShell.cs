// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201
{
    using Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.PowerShell;

    /// <summary>Profile of the managed cluster NAT gateway.</summary>
    [System.ComponentModel.TypeConverter(typeof(ManagedClusterNatGatewayProfileTypeConverter))]
    public partial class ManagedClusterNatGatewayProfile
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterNatGatewayProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterNatGatewayProfile"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterNatGatewayProfile DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ManagedClusterNatGatewayProfile(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterNatGatewayProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterNatGatewayProfile"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterNatGatewayProfile DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ManagedClusterNatGatewayProfile(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ManagedClusterNatGatewayProfile" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ManagedClusterNatGatewayProfile" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterNatGatewayProfile FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterNatGatewayProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ManagedClusterNatGatewayProfile(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ManagedOutboundIPProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterNatGatewayProfileInternal)this).ManagedOutboundIPProfile = (Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterManagedOutboundIPProfile) content.GetValueForProperty("ManagedOutboundIPProfile",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterNatGatewayProfileInternal)this).ManagedOutboundIPProfile, Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterManagedOutboundIPProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("EffectiveOutboundIP"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterNatGatewayProfileInternal)this).EffectiveOutboundIP = (Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IResourceReference[]) content.GetValueForProperty("EffectiveOutboundIP",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterNatGatewayProfileInternal)this).EffectiveOutboundIP, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IResourceReference>(__y, Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ResourceReferenceTypeConverter.ConvertFrom));
            }
            if (content.Contains("IdleTimeoutInMinute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterNatGatewayProfileInternal)this).IdleTimeoutInMinute = (int?) content.GetValueForProperty("IdleTimeoutInMinute",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterNatGatewayProfileInternal)this).IdleTimeoutInMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ManagedOutboundIPProfileCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterNatGatewayProfileInternal)this).ManagedOutboundIPProfileCount = (int?) content.GetValueForProperty("ManagedOutboundIPProfileCount",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterNatGatewayProfileInternal)this).ManagedOutboundIPProfileCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterNatGatewayProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ManagedClusterNatGatewayProfile(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ManagedOutboundIPProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterNatGatewayProfileInternal)this).ManagedOutboundIPProfile = (Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterManagedOutboundIPProfile) content.GetValueForProperty("ManagedOutboundIPProfile",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterNatGatewayProfileInternal)this).ManagedOutboundIPProfile, Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterManagedOutboundIPProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("EffectiveOutboundIP"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterNatGatewayProfileInternal)this).EffectiveOutboundIP = (Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IResourceReference[]) content.GetValueForProperty("EffectiveOutboundIP",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterNatGatewayProfileInternal)this).EffectiveOutboundIP, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IResourceReference>(__y, Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ResourceReferenceTypeConverter.ConvertFrom));
            }
            if (content.Contains("IdleTimeoutInMinute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterNatGatewayProfileInternal)this).IdleTimeoutInMinute = (int?) content.GetValueForProperty("IdleTimeoutInMinute",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterNatGatewayProfileInternal)this).IdleTimeoutInMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ManagedOutboundIPProfileCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterNatGatewayProfileInternal)this).ManagedOutboundIPProfileCount = (int?) content.GetValueForProperty("ManagedOutboundIPProfileCount",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterNatGatewayProfileInternal)this).ManagedOutboundIPProfileCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Profile of the managed cluster NAT gateway.
    [System.ComponentModel.TypeConverter(typeof(ManagedClusterNatGatewayProfileTypeConverter))]
    public partial interface IManagedClusterNatGatewayProfile

    {

    }
}