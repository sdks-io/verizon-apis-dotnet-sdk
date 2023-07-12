// <copyright file="ClusterInfra.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Verizon.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Verizon.Standard;
    using Verizon.Standard.Utilities;

    /// <summary>
    /// ClusterInfra.
    /// </summary>
    public class ClusterInfra
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterInfra"/> class.
        /// </summary>
        public ClusterInfra()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterInfra"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="modifiedAt">modified_at.</param>
        /// <param name="organizationId">organization_id.</param>
        /// <param name="partnerId">partner_id.</param>
        /// <param name="country">country.</param>
        /// <param name="city">city.</param>
        /// <param name="latitude">latitude.</param>
        /// <param name="longitude">longitude.</param>
        /// <param name="clusterId">cluster_id.</param>
        /// <param name="status">status.</param>
        /// <param name="cert">cert.</param>
        /// <param name="passphrase">passphrase.</param>
        /// <param name="id">id.</param>
        /// <param name="cname">cname.</param>
        /// <param name="arecord">arecord.</param>
        /// <param name="baseRatio">base_ratio.</param>
        /// <param name="haEnabled">ha_enabled.</param>
        /// <param name="displayName">display_name.</param>
        /// <param name="upgradeStatus">upgradeStatus.</param>
        /// <param name="providerId">provider_id.</param>
        /// <param name="autoCreate">auto_create.</param>
        /// <param name="autoApproveNodes">auto_approve_nodes.</param>
        /// <param name="provisionId">provision_id.</param>
        /// <param name="isMonitorEnabled">is_monitor_enabled.</param>
        /// <param name="health">health.</param>
        /// <param name="healthStatusModifiedAt">health_status_modified_at.</param>
        /// <param name="manufacturer">manufacturer.</param>
        /// <param name="clusterType">cluster_type.</param>
        /// <param name="clusterBlueprint">cluster_blueprint.</param>
        /// <param name="gimageUsed">gimage_used.</param>
        /// <param name="reason">reason.</param>
        /// <param name="isMasterDedicated">is_master_dedicated.</param>
        /// <param name="projectId">project_id.</param>
        /// <param name="provisionOs">provision_os.</param>
        /// <param name="defaultStorageClass">default_storage_class.</param>
        /// <param name="storageClassMap">storage_class_map.</param>
        /// <param name="cniProvider">cni_provider.</param>
        /// <param name="provisionK8s">provision_k8s.</param>
        /// <param name="etcdVersion">etcd_version.</param>
        /// <param name="consulVersion">consul_version.</param>
        /// <param name="clusterBlueprintVersion">cluster_blueprint_version.</param>
        /// <param name="upgradeProtection">upgrade_protection.</param>
        /// <param name="provision">provision.</param>
        /// <param name="metro">Metro.</param>
        /// <param name="nodes">nodes.</param>
        /// <param name="clusterProviderParams">cluster_provider_params.</param>
        /// <param name="nodegroups">nodegroups.</param>
        /// <param name="clusterVersionInfo">cluster_version_info.</param>
        /// <param name="projects">projects.</param>
        /// <param name="cluster">cluster.</param>
        public ClusterInfra(
            string name = null,
            string createdAt = null,
            string modifiedAt = null,
            string organizationId = null,
            string partnerId = null,
            string country = null,
            string city = null,
            string latitude = null,
            string longitude = null,
            string clusterId = null,
            string status = null,
            string cert = null,
            string passphrase = null,
            string id = null,
            string cname = null,
            string arecord = null,
            double? baseRatio = null,
            bool? haEnabled = null,
            string displayName = null,
            string upgradeStatus = null,
            string providerId = null,
            bool? autoCreate = null,
            bool? autoApproveNodes = null,
            string provisionId = null,
            bool? isMonitorEnabled = null,
            int? health = null,
            string healthStatusModifiedAt = null,
            string manufacturer = null,
            string clusterType = null,
            string clusterBlueprint = null,
            string gimageUsed = null,
            string reason = null,
            bool? isMasterDedicated = null,
            string projectId = null,
            string provisionOs = null,
            string defaultStorageClass = null,
            Models.StorageClassMap storageClassMap = null,
            string cniProvider = null,
            string provisionK8s = null,
            string etcdVersion = null,
            string consulVersion = null,
            string clusterBlueprintVersion = null,
            bool? upgradeProtection = null,
            Models.ClusterInfraProvision provision = null,
            Models.Metro metro = null,
            List<Models.Node> nodes = null,
            Models.ClusterProviderParams clusterProviderParams = null,
            List<Models.NodeGroupItem> nodegroups = null,
            Models.ClusterVersionInfo clusterVersionInfo = null,
            List<Models.ProjectItem> projects = null,
            Models.Cluster cluster = null)
        {
            this.Name = name;
            this.CreatedAt = createdAt;
            this.ModifiedAt = modifiedAt;
            this.OrganizationId = organizationId;
            this.PartnerId = partnerId;
            this.Country = country;
            this.City = city;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.ClusterId = clusterId;
            this.Status = status;
            this.Cert = cert;
            this.Passphrase = passphrase;
            this.Id = id;
            this.Cname = cname;
            this.Arecord = arecord;
            this.BaseRatio = baseRatio;
            this.HaEnabled = haEnabled;
            this.DisplayName = displayName;
            this.UpgradeStatus = upgradeStatus;
            this.ProviderId = providerId;
            this.AutoCreate = autoCreate;
            this.AutoApproveNodes = autoApproveNodes;
            this.ProvisionId = provisionId;
            this.IsMonitorEnabled = isMonitorEnabled;
            this.Health = health;
            this.HealthStatusModifiedAt = healthStatusModifiedAt;
            this.Manufacturer = manufacturer;
            this.ClusterType = clusterType;
            this.ClusterBlueprint = clusterBlueprint;
            this.GimageUsed = gimageUsed;
            this.Reason = reason;
            this.IsMasterDedicated = isMasterDedicated;
            this.ProjectId = projectId;
            this.ProvisionOs = provisionOs;
            this.DefaultStorageClass = defaultStorageClass;
            this.StorageClassMap = storageClassMap;
            this.CniProvider = cniProvider;
            this.ProvisionK8s = provisionK8s;
            this.EtcdVersion = etcdVersion;
            this.ConsulVersion = consulVersion;
            this.ClusterBlueprintVersion = clusterBlueprintVersion;
            this.UpgradeProtection = upgradeProtection;
            this.Provision = provision;
            this.Metro = metro;
            this.Nodes = nodes;
            this.ClusterProviderParams = clusterProviderParams;
            this.Nodegroups = nodegroups;
            this.ClusterVersionInfo = clusterVersionInfo;
            this.Projects = projects;
            this.Cluster = cluster;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets ModifiedAt.
        /// </summary>
        [JsonProperty("modified_at", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedAt { get; set; }

        /// <summary>
        /// Gets or sets OrganizationId.
        /// </summary>
        [JsonProperty("organization_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Gets or sets PartnerId.
        /// </summary>
        [JsonProperty("partner_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PartnerId { get; set; }

        /// <summary>
        /// Gets or sets Country.
        /// </summary>
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets City.
        /// </summary>
        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets Latitude.
        /// </summary>
        [JsonProperty("latitude", NullValueHandling = NullValueHandling.Ignore)]
        public string Latitude { get; set; }

        /// <summary>
        /// Gets or sets Longitude.
        /// </summary>
        [JsonProperty("longitude", NullValueHandling = NullValueHandling.Ignore)]
        public string Longitude { get; set; }

        /// <summary>
        /// Gets or sets ClusterId.
        /// </summary>
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets Cert.
        /// </summary>
        [JsonProperty("cert", NullValueHandling = NullValueHandling.Ignore)]
        public string Cert { get; set; }

        /// <summary>
        /// Gets or sets Passphrase.
        /// </summary>
        [JsonProperty("passphrase", NullValueHandling = NullValueHandling.Ignore)]
        public string Passphrase { get; set; }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets Cname.
        /// </summary>
        [JsonProperty("cname", NullValueHandling = NullValueHandling.Ignore)]
        public string Cname { get; set; }

        /// <summary>
        /// Gets or sets Arecord.
        /// </summary>
        [JsonProperty("arecord", NullValueHandling = NullValueHandling.Ignore)]
        public string Arecord { get; set; }

        /// <summary>
        /// Gets or sets BaseRatio.
        /// </summary>
        [JsonProperty("base_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public double? BaseRatio { get; set; }

        /// <summary>
        /// Gets or sets HaEnabled.
        /// </summary>
        [JsonProperty("ha_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaEnabled { get; set; }

        /// <summary>
        /// Gets or sets DisplayName.
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets UpgradeStatus.
        /// </summary>
        [JsonProperty("upgradeStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string UpgradeStatus { get; set; }

        /// <summary>
        /// Gets or sets ProviderId.
        /// </summary>
        [JsonProperty("provider_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderId { get; set; }

        /// <summary>
        /// Gets or sets AutoCreate.
        /// </summary>
        [JsonProperty("auto_create", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoCreate { get; set; }

        /// <summary>
        /// Gets or sets AutoApproveNodes.
        /// </summary>
        [JsonProperty("auto_approve_nodes", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoApproveNodes { get; set; }

        /// <summary>
        /// Gets or sets ProvisionId.
        /// </summary>
        [JsonProperty("provision_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProvisionId { get; set; }

        /// <summary>
        /// Gets or sets IsMonitorEnabled.
        /// </summary>
        [JsonProperty("is_monitor_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMonitorEnabled { get; set; }

        /// <summary>
        /// Gets or sets Health.
        /// </summary>
        [JsonProperty("health", NullValueHandling = NullValueHandling.Ignore)]
        public int? Health { get; set; }

        /// <summary>
        /// Gets or sets HealthStatusModifiedAt.
        /// </summary>
        [JsonProperty("health_status_modified_at", NullValueHandling = NullValueHandling.Ignore)]
        public string HealthStatusModifiedAt { get; set; }

        /// <summary>
        /// Gets or sets Manufacturer.
        /// </summary>
        [JsonProperty("manufacturer", NullValueHandling = NullValueHandling.Ignore)]
        public string Manufacturer { get; set; }

        /// <summary>
        /// Gets or sets ClusterType.
        /// </summary>
        [JsonProperty("cluster_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterType { get; set; }

        /// <summary>
        /// Gets or sets ClusterBlueprint.
        /// </summary>
        [JsonProperty("cluster_blueprint", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterBlueprint { get; set; }

        /// <summary>
        /// Gets or sets GimageUsed.
        /// </summary>
        [JsonProperty("gimage_used", NullValueHandling = NullValueHandling.Ignore)]
        public string GimageUsed { get; set; }

        /// <summary>
        /// Gets or sets Reason.
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or sets IsMasterDedicated.
        /// </summary>
        [JsonProperty("is_master_dedicated", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMasterDedicated { get; set; }

        /// <summary>
        /// Gets or sets ProjectId.
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// Gets or sets ProvisionOs.
        /// </summary>
        [JsonProperty("provision_os", NullValueHandling = NullValueHandling.Ignore)]
        public string ProvisionOs { get; set; }

        /// <summary>
        /// Gets or sets DefaultStorageClass.
        /// </summary>
        [JsonProperty("default_storage_class", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultStorageClass { get; set; }

        /// <summary>
        /// Gets or sets StorageClassMap.
        /// </summary>
        [JsonProperty("storage_class_map", NullValueHandling = NullValueHandling.Ignore)]
        public Models.StorageClassMap StorageClassMap { get; set; }

        /// <summary>
        /// Gets or sets CniProvider.
        /// </summary>
        [JsonProperty("cni_provider", NullValueHandling = NullValueHandling.Ignore)]
        public string CniProvider { get; set; }

        /// <summary>
        /// Gets or sets ProvisionK8s.
        /// </summary>
        [JsonProperty("provision_k8s", NullValueHandling = NullValueHandling.Ignore)]
        public string ProvisionK8s { get; set; }

        /// <summary>
        /// Gets or sets EtcdVersion.
        /// </summary>
        [JsonProperty("etcd_version", NullValueHandling = NullValueHandling.Ignore)]
        public string EtcdVersion { get; set; }

        /// <summary>
        /// Gets or sets ConsulVersion.
        /// </summary>
        [JsonProperty("consul_version", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsulVersion { get; set; }

        /// <summary>
        /// Gets or sets ClusterBlueprintVersion.
        /// </summary>
        [JsonProperty("cluster_blueprint_version", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterBlueprintVersion { get; set; }

        /// <summary>
        /// Gets or sets UpgradeProtection.
        /// </summary>
        [JsonProperty("upgrade_protection", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UpgradeProtection { get; set; }

        /// <summary>
        /// Gets or sets Provision.
        /// </summary>
        [JsonProperty("provision", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ClusterInfraProvision Provision { get; set; }

        /// <summary>
        /// Gets or sets Metro.
        /// </summary>
        [JsonProperty("Metro", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Metro Metro { get; set; }

        /// <summary>
        /// Gets or sets Nodes.
        /// </summary>
        [JsonProperty("nodes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Node> Nodes { get; set; }

        /// <summary>
        /// Gets or sets ClusterProviderParams.
        /// </summary>
        [JsonProperty("cluster_provider_params", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ClusterProviderParams ClusterProviderParams { get; set; }

        /// <summary>
        /// Gets or sets Nodegroups.
        /// </summary>
        [JsonProperty("nodegroups", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.NodeGroupItem> Nodegroups { get; set; }

        /// <summary>
        /// Gets or sets ClusterVersionInfo.
        /// </summary>
        [JsonProperty("cluster_version_info", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ClusterVersionInfo ClusterVersionInfo { get; set; }

        /// <summary>
        /// Gets or sets Projects.
        /// </summary>
        [JsonProperty("projects", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ProjectItem> Projects { get; set; }

        /// <summary>
        /// Gets or sets Cluster.
        /// </summary>
        [JsonProperty("cluster", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Cluster Cluster { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ClusterInfra : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is ClusterInfra other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.ModifiedAt == null && other.ModifiedAt == null) || (this.ModifiedAt?.Equals(other.ModifiedAt) == true)) &&
                ((this.OrganizationId == null && other.OrganizationId == null) || (this.OrganizationId?.Equals(other.OrganizationId) == true)) &&
                ((this.PartnerId == null && other.PartnerId == null) || (this.PartnerId?.Equals(other.PartnerId) == true)) &&
                ((this.Country == null && other.Country == null) || (this.Country?.Equals(other.Country) == true)) &&
                ((this.City == null && other.City == null) || (this.City?.Equals(other.City) == true)) &&
                ((this.Latitude == null && other.Latitude == null) || (this.Latitude?.Equals(other.Latitude) == true)) &&
                ((this.Longitude == null && other.Longitude == null) || (this.Longitude?.Equals(other.Longitude) == true)) &&
                ((this.ClusterId == null && other.ClusterId == null) || (this.ClusterId?.Equals(other.ClusterId) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Cert == null && other.Cert == null) || (this.Cert?.Equals(other.Cert) == true)) &&
                ((this.Passphrase == null && other.Passphrase == null) || (this.Passphrase?.Equals(other.Passphrase) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Cname == null && other.Cname == null) || (this.Cname?.Equals(other.Cname) == true)) &&
                ((this.Arecord == null && other.Arecord == null) || (this.Arecord?.Equals(other.Arecord) == true)) &&
                ((this.BaseRatio == null && other.BaseRatio == null) || (this.BaseRatio?.Equals(other.BaseRatio) == true)) &&
                ((this.HaEnabled == null && other.HaEnabled == null) || (this.HaEnabled?.Equals(other.HaEnabled) == true)) &&
                ((this.DisplayName == null && other.DisplayName == null) || (this.DisplayName?.Equals(other.DisplayName) == true)) &&
                ((this.UpgradeStatus == null && other.UpgradeStatus == null) || (this.UpgradeStatus?.Equals(other.UpgradeStatus) == true)) &&
                ((this.ProviderId == null && other.ProviderId == null) || (this.ProviderId?.Equals(other.ProviderId) == true)) &&
                ((this.AutoCreate == null && other.AutoCreate == null) || (this.AutoCreate?.Equals(other.AutoCreate) == true)) &&
                ((this.AutoApproveNodes == null && other.AutoApproveNodes == null) || (this.AutoApproveNodes?.Equals(other.AutoApproveNodes) == true)) &&
                ((this.ProvisionId == null && other.ProvisionId == null) || (this.ProvisionId?.Equals(other.ProvisionId) == true)) &&
                ((this.IsMonitorEnabled == null && other.IsMonitorEnabled == null) || (this.IsMonitorEnabled?.Equals(other.IsMonitorEnabled) == true)) &&
                ((this.Health == null && other.Health == null) || (this.Health?.Equals(other.Health) == true)) &&
                ((this.HealthStatusModifiedAt == null && other.HealthStatusModifiedAt == null) || (this.HealthStatusModifiedAt?.Equals(other.HealthStatusModifiedAt) == true)) &&
                ((this.Manufacturer == null && other.Manufacturer == null) || (this.Manufacturer?.Equals(other.Manufacturer) == true)) &&
                ((this.ClusterType == null && other.ClusterType == null) || (this.ClusterType?.Equals(other.ClusterType) == true)) &&
                ((this.ClusterBlueprint == null && other.ClusterBlueprint == null) || (this.ClusterBlueprint?.Equals(other.ClusterBlueprint) == true)) &&
                ((this.GimageUsed == null && other.GimageUsed == null) || (this.GimageUsed?.Equals(other.GimageUsed) == true)) &&
                ((this.Reason == null && other.Reason == null) || (this.Reason?.Equals(other.Reason) == true)) &&
                ((this.IsMasterDedicated == null && other.IsMasterDedicated == null) || (this.IsMasterDedicated?.Equals(other.IsMasterDedicated) == true)) &&
                ((this.ProjectId == null && other.ProjectId == null) || (this.ProjectId?.Equals(other.ProjectId) == true)) &&
                ((this.ProvisionOs == null && other.ProvisionOs == null) || (this.ProvisionOs?.Equals(other.ProvisionOs) == true)) &&
                ((this.DefaultStorageClass == null && other.DefaultStorageClass == null) || (this.DefaultStorageClass?.Equals(other.DefaultStorageClass) == true)) &&
                ((this.StorageClassMap == null && other.StorageClassMap == null) || (this.StorageClassMap?.Equals(other.StorageClassMap) == true)) &&
                ((this.CniProvider == null && other.CniProvider == null) || (this.CniProvider?.Equals(other.CniProvider) == true)) &&
                ((this.ProvisionK8s == null && other.ProvisionK8s == null) || (this.ProvisionK8s?.Equals(other.ProvisionK8s) == true)) &&
                ((this.EtcdVersion == null && other.EtcdVersion == null) || (this.EtcdVersion?.Equals(other.EtcdVersion) == true)) &&
                ((this.ConsulVersion == null && other.ConsulVersion == null) || (this.ConsulVersion?.Equals(other.ConsulVersion) == true)) &&
                ((this.ClusterBlueprintVersion == null && other.ClusterBlueprintVersion == null) || (this.ClusterBlueprintVersion?.Equals(other.ClusterBlueprintVersion) == true)) &&
                ((this.UpgradeProtection == null && other.UpgradeProtection == null) || (this.UpgradeProtection?.Equals(other.UpgradeProtection) == true)) &&
                ((this.Provision == null && other.Provision == null) || (this.Provision?.Equals(other.Provision) == true)) &&
                ((this.Metro == null && other.Metro == null) || (this.Metro?.Equals(other.Metro) == true)) &&
                ((this.Nodes == null && other.Nodes == null) || (this.Nodes?.Equals(other.Nodes) == true)) &&
                ((this.ClusterProviderParams == null && other.ClusterProviderParams == null) || (this.ClusterProviderParams?.Equals(other.ClusterProviderParams) == true)) &&
                ((this.Nodegroups == null && other.Nodegroups == null) || (this.Nodegroups?.Equals(other.Nodegroups) == true)) &&
                ((this.ClusterVersionInfo == null && other.ClusterVersionInfo == null) || (this.ClusterVersionInfo?.Equals(other.ClusterVersionInfo) == true)) &&
                ((this.Projects == null && other.Projects == null) || (this.Projects?.Equals(other.Projects) == true)) &&
                ((this.Cluster == null && other.Cluster == null) || (this.Cluster?.Equals(other.Cluster) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt == string.Empty ? "" : this.CreatedAt)}");
            toStringOutput.Add($"this.ModifiedAt = {(this.ModifiedAt == null ? "null" : this.ModifiedAt == string.Empty ? "" : this.ModifiedAt)}");
            toStringOutput.Add($"this.OrganizationId = {(this.OrganizationId == null ? "null" : this.OrganizationId == string.Empty ? "" : this.OrganizationId)}");
            toStringOutput.Add($"this.PartnerId = {(this.PartnerId == null ? "null" : this.PartnerId == string.Empty ? "" : this.PartnerId)}");
            toStringOutput.Add($"this.Country = {(this.Country == null ? "null" : this.Country == string.Empty ? "" : this.Country)}");
            toStringOutput.Add($"this.City = {(this.City == null ? "null" : this.City == string.Empty ? "" : this.City)}");
            toStringOutput.Add($"this.Latitude = {(this.Latitude == null ? "null" : this.Latitude == string.Empty ? "" : this.Latitude)}");
            toStringOutput.Add($"this.Longitude = {(this.Longitude == null ? "null" : this.Longitude == string.Empty ? "" : this.Longitude)}");
            toStringOutput.Add($"this.ClusterId = {(this.ClusterId == null ? "null" : this.ClusterId == string.Empty ? "" : this.ClusterId)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.Cert = {(this.Cert == null ? "null" : this.Cert == string.Empty ? "" : this.Cert)}");
            toStringOutput.Add($"this.Passphrase = {(this.Passphrase == null ? "null" : this.Passphrase == string.Empty ? "" : this.Passphrase)}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.Cname = {(this.Cname == null ? "null" : this.Cname == string.Empty ? "" : this.Cname)}");
            toStringOutput.Add($"this.Arecord = {(this.Arecord == null ? "null" : this.Arecord == string.Empty ? "" : this.Arecord)}");
            toStringOutput.Add($"this.BaseRatio = {(this.BaseRatio == null ? "null" : this.BaseRatio.ToString())}");
            toStringOutput.Add($"this.HaEnabled = {(this.HaEnabled == null ? "null" : this.HaEnabled.ToString())}");
            toStringOutput.Add($"this.DisplayName = {(this.DisplayName == null ? "null" : this.DisplayName == string.Empty ? "" : this.DisplayName)}");
            toStringOutput.Add($"this.UpgradeStatus = {(this.UpgradeStatus == null ? "null" : this.UpgradeStatus == string.Empty ? "" : this.UpgradeStatus)}");
            toStringOutput.Add($"this.ProviderId = {(this.ProviderId == null ? "null" : this.ProviderId == string.Empty ? "" : this.ProviderId)}");
            toStringOutput.Add($"this.AutoCreate = {(this.AutoCreate == null ? "null" : this.AutoCreate.ToString())}");
            toStringOutput.Add($"this.AutoApproveNodes = {(this.AutoApproveNodes == null ? "null" : this.AutoApproveNodes.ToString())}");
            toStringOutput.Add($"this.ProvisionId = {(this.ProvisionId == null ? "null" : this.ProvisionId == string.Empty ? "" : this.ProvisionId)}");
            toStringOutput.Add($"this.IsMonitorEnabled = {(this.IsMonitorEnabled == null ? "null" : this.IsMonitorEnabled.ToString())}");
            toStringOutput.Add($"this.Health = {(this.Health == null ? "null" : this.Health.ToString())}");
            toStringOutput.Add($"this.HealthStatusModifiedAt = {(this.HealthStatusModifiedAt == null ? "null" : this.HealthStatusModifiedAt == string.Empty ? "" : this.HealthStatusModifiedAt)}");
            toStringOutput.Add($"this.Manufacturer = {(this.Manufacturer == null ? "null" : this.Manufacturer == string.Empty ? "" : this.Manufacturer)}");
            toStringOutput.Add($"this.ClusterType = {(this.ClusterType == null ? "null" : this.ClusterType == string.Empty ? "" : this.ClusterType)}");
            toStringOutput.Add($"this.ClusterBlueprint = {(this.ClusterBlueprint == null ? "null" : this.ClusterBlueprint == string.Empty ? "" : this.ClusterBlueprint)}");
            toStringOutput.Add($"this.GimageUsed = {(this.GimageUsed == null ? "null" : this.GimageUsed == string.Empty ? "" : this.GimageUsed)}");
            toStringOutput.Add($"this.Reason = {(this.Reason == null ? "null" : this.Reason == string.Empty ? "" : this.Reason)}");
            toStringOutput.Add($"this.IsMasterDedicated = {(this.IsMasterDedicated == null ? "null" : this.IsMasterDedicated.ToString())}");
            toStringOutput.Add($"this.ProjectId = {(this.ProjectId == null ? "null" : this.ProjectId == string.Empty ? "" : this.ProjectId)}");
            toStringOutput.Add($"this.ProvisionOs = {(this.ProvisionOs == null ? "null" : this.ProvisionOs == string.Empty ? "" : this.ProvisionOs)}");
            toStringOutput.Add($"this.DefaultStorageClass = {(this.DefaultStorageClass == null ? "null" : this.DefaultStorageClass == string.Empty ? "" : this.DefaultStorageClass)}");
            toStringOutput.Add($"this.StorageClassMap = {(this.StorageClassMap == null ? "null" : this.StorageClassMap.ToString())}");
            toStringOutput.Add($"this.CniProvider = {(this.CniProvider == null ? "null" : this.CniProvider == string.Empty ? "" : this.CniProvider)}");
            toStringOutput.Add($"this.ProvisionK8s = {(this.ProvisionK8s == null ? "null" : this.ProvisionK8s == string.Empty ? "" : this.ProvisionK8s)}");
            toStringOutput.Add($"this.EtcdVersion = {(this.EtcdVersion == null ? "null" : this.EtcdVersion == string.Empty ? "" : this.EtcdVersion)}");
            toStringOutput.Add($"this.ConsulVersion = {(this.ConsulVersion == null ? "null" : this.ConsulVersion == string.Empty ? "" : this.ConsulVersion)}");
            toStringOutput.Add($"this.ClusterBlueprintVersion = {(this.ClusterBlueprintVersion == null ? "null" : this.ClusterBlueprintVersion == string.Empty ? "" : this.ClusterBlueprintVersion)}");
            toStringOutput.Add($"this.UpgradeProtection = {(this.UpgradeProtection == null ? "null" : this.UpgradeProtection.ToString())}");
            toStringOutput.Add($"this.Provision = {(this.Provision == null ? "null" : this.Provision.ToString())}");
            toStringOutput.Add($"this.Metro = {(this.Metro == null ? "null" : this.Metro.ToString())}");
            toStringOutput.Add($"this.Nodes = {(this.Nodes == null ? "null" : $"[{string.Join(", ", this.Nodes)} ]")}");
            toStringOutput.Add($"this.ClusterProviderParams = {(this.ClusterProviderParams == null ? "null" : this.ClusterProviderParams.ToString())}");
            toStringOutput.Add($"this.Nodegroups = {(this.Nodegroups == null ? "null" : $"[{string.Join(", ", this.Nodegroups)} ]")}");
            toStringOutput.Add($"this.ClusterVersionInfo = {(this.ClusterVersionInfo == null ? "null" : this.ClusterVersionInfo.ToString())}");
            toStringOutput.Add($"this.Projects = {(this.Projects == null ? "null" : $"[{string.Join(", ", this.Projects)} ]")}");
            toStringOutput.Add($"this.Cluster = {(this.Cluster == null ? "null" : this.Cluster.ToString())}");
        }
    }
}