namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.PowerShell;

    /// <summary>Azure VM unmanaged disk input details.</summary>
    [System.ComponentModel.TypeConverter(typeof(A2AProtectionIntentDiskInputDetailsTypeConverter))]
    public partial class A2AProtectionIntentDiskInputDetails
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
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.A2AProtectionIntentDiskInputDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal A2AProtectionIntentDiskInputDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentDiskInputDetailsInternal)this).RecoveryAzureStorageAccountCustomInput = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IStorageAccountCustomDetails) content.GetValueForProperty("RecoveryAzureStorageAccountCustomInput",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentDiskInputDetailsInternal)this).RecoveryAzureStorageAccountCustomInput, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.StorageAccountCustomDetailsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentDiskInputDetailsInternal)this).PrimaryStagingStorageAccountCustomInput = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IStorageAccountCustomDetails) content.GetValueForProperty("PrimaryStagingStorageAccountCustomInput",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentDiskInputDetailsInternal)this).PrimaryStagingStorageAccountCustomInput, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.StorageAccountCustomDetailsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentDiskInputDetailsInternal)this).DiskUri = (string) content.GetValueForProperty("DiskUri",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentDiskInputDetailsInternal)this).DiskUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentDiskInputDetailsInternal)this).RecoveryAzureStorageAccountCustomInputResourceType = (string) content.GetValueForProperty("RecoveryAzureStorageAccountCustomInputResourceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentDiskInputDetailsInternal)this).RecoveryAzureStorageAccountCustomInputResourceType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentDiskInputDetailsInternal)this).PrimaryStagingStorageAccountCustomInputResourceType = (string) content.GetValueForProperty("PrimaryStagingStorageAccountCustomInputResourceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentDiskInputDetailsInternal)this).PrimaryStagingStorageAccountCustomInputResourceType, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.A2AProtectionIntentDiskInputDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal A2AProtectionIntentDiskInputDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentDiskInputDetailsInternal)this).RecoveryAzureStorageAccountCustomInput = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IStorageAccountCustomDetails) content.GetValueForProperty("RecoveryAzureStorageAccountCustomInput",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentDiskInputDetailsInternal)this).RecoveryAzureStorageAccountCustomInput, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.StorageAccountCustomDetailsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentDiskInputDetailsInternal)this).PrimaryStagingStorageAccountCustomInput = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IStorageAccountCustomDetails) content.GetValueForProperty("PrimaryStagingStorageAccountCustomInput",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentDiskInputDetailsInternal)this).PrimaryStagingStorageAccountCustomInput, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.StorageAccountCustomDetailsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentDiskInputDetailsInternal)this).DiskUri = (string) content.GetValueForProperty("DiskUri",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentDiskInputDetailsInternal)this).DiskUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentDiskInputDetailsInternal)this).RecoveryAzureStorageAccountCustomInputResourceType = (string) content.GetValueForProperty("RecoveryAzureStorageAccountCustomInputResourceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentDiskInputDetailsInternal)this).RecoveryAzureStorageAccountCustomInputResourceType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentDiskInputDetailsInternal)this).PrimaryStagingStorageAccountCustomInputResourceType = (string) content.GetValueForProperty("PrimaryStagingStorageAccountCustomInputResourceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentDiskInputDetailsInternal)this).PrimaryStagingStorageAccountCustomInputResourceType, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.A2AProtectionIntentDiskInputDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentDiskInputDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentDiskInputDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new A2AProtectionIntentDiskInputDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.A2AProtectionIntentDiskInputDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentDiskInputDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentDiskInputDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new A2AProtectionIntentDiskInputDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="A2AProtectionIntentDiskInputDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentDiskInputDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Azure VM unmanaged disk input details.
    [System.ComponentModel.TypeConverter(typeof(A2AProtectionIntentDiskInputDetailsTypeConverter))]
    public partial interface IA2AProtectionIntentDiskInputDetails

    {

    }
}