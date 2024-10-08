// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.HDInsight.Models
{
    using System.Linq;

    /// <summary>
    /// The properties of cluster.
    /// </summary>
    public partial class ClusterGetProperties
    {
        /// <summary>
        /// Initializes a new instance of the ClusterGetProperties class.
        /// </summary>
        public ClusterGetProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ClusterGetProperties class.
        /// </summary>

        /// <param name="clusterVersion">The version of the cluster.
        /// </param>

        /// <param name="clusterHdpVersion">The hdp version of the cluster.
        /// </param>

        /// <param name="osType">The type of operating system.
        /// Possible values include: &#39;Windows&#39;, &#39;Linux&#39;</param>

        /// <param name="tier">The cluster tier.
        /// Possible values include: &#39;Standard&#39;, &#39;Premium&#39;</param>

        /// <param name="clusterId">The cluster id.
        /// </param>

        /// <param name="clusterDefinition">The cluster definition.
        /// </param>

        /// <param name="kafkaRestProperties">The cluster kafka rest proxy configuration.
        /// </param>

        /// <param name="securityProfile">The security profile.
        /// </param>

        /// <param name="computeProfile">The compute profile.
        /// </param>

        /// <param name="provisioningState">The provisioning state, which only appears in the response.
        /// Possible values include: &#39;InProgress&#39;, &#39;Failed&#39;, &#39;Succeeded&#39;, &#39;Canceled&#39;,
        /// &#39;Deleting&#39;</param>

        /// <param name="createdDate">The date on which the cluster was created.
        /// </param>

        /// <param name="clusterState">The state of the cluster.
        /// </param>

        /// <param name="quotaInfo">The quota information.
        /// </param>

        /// <param name="errors">The list of errors.
        /// </param>

        /// <param name="connectivityEndpoints">The list of connectivity endpoints.
        /// </param>

        /// <param name="diskEncryptionProperties">The disk encryption properties.
        /// </param>

        /// <param name="encryptionInTransitProperties">The encryption-in-transit properties.
        /// </param>

        /// <param name="storageProfile">The storage profile.
        /// </param>

        /// <param name="minSupportedTlsVersion">The minimal supported tls version.
        /// </param>

        /// <param name="excludedServicesConfig">The excluded services config.
        /// </param>

        /// <param name="networkProperties">The network properties.
        /// </param>

        /// <param name="computeIsolationProperties">The compute isolation properties.
        /// </param>

        /// <param name="privateLinkConfigurations">The private link configurations.
        /// </param>

        /// <param name="privateEndpointConnections">The list of private endpoint connections.
        /// </param>
        public ClusterGetProperties(ClusterDefinition clusterDefinition, string clusterVersion = default(string), string clusterHdpVersion = default(string), string osType = default(string), string tier = default(string), string clusterId = default(string), KafkaRestProperties kafkaRestProperties = default(KafkaRestProperties), SecurityProfile securityProfile = default(SecurityProfile), ComputeProfile computeProfile = default(ComputeProfile), string provisioningState = default(string), string createdDate = default(string), string clusterState = default(string), QuotaInfo quotaInfo = default(QuotaInfo), System.Collections.Generic.IList<Errors> errors = default(System.Collections.Generic.IList<Errors>), System.Collections.Generic.IList<ConnectivityEndpoint> connectivityEndpoints = default(System.Collections.Generic.IList<ConnectivityEndpoint>), DiskEncryptionProperties diskEncryptionProperties = default(DiskEncryptionProperties), EncryptionInTransitProperties encryptionInTransitProperties = default(EncryptionInTransitProperties), StorageProfile storageProfile = default(StorageProfile), string minSupportedTlsVersion = default(string), ExcludedServicesConfig excludedServicesConfig = default(ExcludedServicesConfig), NetworkProperties networkProperties = default(NetworkProperties), ComputeIsolationProperties computeIsolationProperties = default(ComputeIsolationProperties), System.Collections.Generic.IList<PrivateLinkConfiguration> privateLinkConfigurations = default(System.Collections.Generic.IList<PrivateLinkConfiguration>), System.Collections.Generic.IList<PrivateEndpointConnection> privateEndpointConnections = default(System.Collections.Generic.IList<PrivateEndpointConnection>))

        {
            this.ClusterVersion = clusterVersion;
            this.ClusterHdpVersion = clusterHdpVersion;
            this.OsType = osType;
            this.Tier = tier;
            this.ClusterId = clusterId;
            this.ClusterDefinition = clusterDefinition;
            this.KafkaRestProperties = kafkaRestProperties;
            this.SecurityProfile = securityProfile;
            this.ComputeProfile = computeProfile;
            this.ProvisioningState = provisioningState;
            this.CreatedDate = createdDate;
            this.ClusterState = clusterState;
            this.QuotaInfo = quotaInfo;
            this.Errors = errors;
            this.ConnectivityEndpoints = connectivityEndpoints;
            this.DiskEncryptionProperties = diskEncryptionProperties;
            this.EncryptionInTransitProperties = encryptionInTransitProperties;
            this.StorageProfile = storageProfile;
            this.MinSupportedTlsVersion = minSupportedTlsVersion;
            this.ExcludedServicesConfig = excludedServicesConfig;
            this.NetworkProperties = networkProperties;
            this.ComputeIsolationProperties = computeIsolationProperties;
            this.PrivateLinkConfigurations = privateLinkConfigurations;
            this.PrivateEndpointConnections = privateEndpointConnections;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the version of the cluster.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "clusterVersion")]
        public string ClusterVersion {get; set; }

        /// <summary>
        /// Gets or sets the hdp version of the cluster.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "clusterHdpVersion")]
        public string ClusterHdpVersion {get; set; }

        /// <summary>
        /// Gets or sets the type of operating system. Possible values include: &#39;Windows&#39;, &#39;Linux&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "osType")]
        public string OsType {get; set; }

        /// <summary>
        /// Gets or sets the cluster tier. Possible values include: &#39;Standard&#39;, &#39;Premium&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tier")]
        public string Tier {get; set; }

        /// <summary>
        /// Gets or sets the cluster id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "clusterId")]
        public string ClusterId {get; set; }

        /// <summary>
        /// Gets or sets the cluster definition.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "clusterDefinition")]
        public ClusterDefinition ClusterDefinition {get; set; }

        /// <summary>
        /// Gets or sets the cluster kafka rest proxy configuration.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "kafkaRestProperties")]
        public KafkaRestProperties KafkaRestProperties {get; set; }

        /// <summary>
        /// Gets or sets the security profile.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "securityProfile")]
        public SecurityProfile SecurityProfile {get; set; }

        /// <summary>
        /// Gets or sets the compute profile.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "computeProfile")]
        public ComputeProfile ComputeProfile {get; set; }

        /// <summary>
        /// Gets or sets the provisioning state, which only appears in the response. Possible values include: &#39;InProgress&#39;, &#39;Failed&#39;, &#39;Succeeded&#39;, &#39;Canceled&#39;, &#39;Deleting&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState {get; set; }

        /// <summary>
        /// Gets or sets the date on which the cluster was created.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "createdDate")]
        public string CreatedDate {get; set; }

        /// <summary>
        /// Gets or sets the state of the cluster.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "clusterState")]
        public string ClusterState {get; set; }

        /// <summary>
        /// Gets or sets the quota information.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "quotaInfo")]
        public QuotaInfo QuotaInfo {get; set; }

        /// <summary>
        /// Gets or sets the list of errors.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "errors")]
        public System.Collections.Generic.IList<Errors> Errors {get; set; }

        /// <summary>
        /// Gets or sets the list of connectivity endpoints.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "connectivityEndpoints")]
        public System.Collections.Generic.IList<ConnectivityEndpoint> ConnectivityEndpoints {get; set; }

        /// <summary>
        /// Gets or sets the disk encryption properties.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "diskEncryptionProperties")]
        public DiskEncryptionProperties DiskEncryptionProperties {get; set; }

        /// <summary>
        /// Gets or sets the encryption-in-transit properties.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "encryptionInTransitProperties")]
        public EncryptionInTransitProperties EncryptionInTransitProperties {get; set; }

        /// <summary>
        /// Gets or sets the storage profile.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "storageProfile")]
        public StorageProfile StorageProfile {get; set; }

        /// <summary>
        /// Gets or sets the minimal supported tls version.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "minSupportedTlsVersion")]
        public string MinSupportedTlsVersion {get; set; }

        /// <summary>
        /// Gets or sets the excluded services config.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "excludedServicesConfig")]
        public ExcludedServicesConfig ExcludedServicesConfig {get; set; }

        /// <summary>
        /// Gets or sets the network properties.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "networkProperties")]
        public NetworkProperties NetworkProperties {get; set; }

        /// <summary>
        /// Gets or sets the compute isolation properties.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "computeIsolationProperties")]
        public ComputeIsolationProperties ComputeIsolationProperties {get; set; }

        /// <summary>
        /// Gets or sets the private link configurations.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "privateLinkConfigurations")]
        public System.Collections.Generic.IList<PrivateLinkConfiguration> PrivateLinkConfigurations {get; set; }

        /// <summary>
        /// Gets the list of private endpoint connections.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "privateEndpointConnections")]
        public System.Collections.Generic.IList<PrivateEndpointConnection> PrivateEndpointConnections {get; private set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.ClusterDefinition == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "ClusterDefinition");
            }




















            if (this.NetworkProperties != null)
            {
                this.NetworkProperties.Validate();
            }

            if (this.PrivateLinkConfigurations != null)
            {
                foreach (var element in this.PrivateLinkConfigurations)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.PrivateEndpointConnections != null)
            {
                foreach (var element in this.PrivateEndpointConnections)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}