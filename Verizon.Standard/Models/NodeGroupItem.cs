// <copyright file="NodeGroupItem.cs" company="APIMatic">
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
    /// NodeGroupItem.
    /// </summary>
    public class NodeGroupItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeGroupItem"/> class.
        /// </summary>
        public NodeGroupItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeGroupItem"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="modifiedAt">modified_at.</param>
        /// <param name="organizationId">organization_id.</param>
        /// <param name="partnerId">partner_id.</param>
        /// <param name="instanceType">instance_type.</param>
        /// <param name="edgeId">edge_id.</param>
        /// <param name="id">id.</param>
        /// <param name="provisionId">provision_id.</param>
        /// <param name="nodeType">node_type.</param>
        /// <param name="nodes">nodes.</param>
        /// <param name="nodesMin">nodes_min.</param>
        /// <param name="nodesMax">nodes_max.</param>
        /// <param name="nodeVolumeSize">node_volume_size.</param>
        /// <param name="nodeVolumeType">node_volume_type.</param>
        /// <param name="nodePrivateNetworking">node_private_networking.</param>
        /// <param name="nodeZones">node_zones.</param>
        /// <param name="nodeAmiFamily">node_ami_family.</param>
        /// <param name="nodeLabels">node_labels.</param>
        /// <param name="nodegroupType">nodegroup_type.</param>
        /// <param name="enableAsgAccess">enable_asg_access.</param>
        /// <param name="enableFullAccessToEcr">enable_full_access_to_ecr.</param>
        /// <param name="versionInfoId">version_info_id.</param>
        /// <param name="upgradeInfoId">upgrade_info_id.</param>
        /// <param name="tags">tags.</param>
        /// <param name="configFileContent">config_file_content.</param>
        /// <param name="provision">provision.</param>
        /// <param name="versionInfo">version_info.</param>
        /// <param name="upgradeInfo">upgrade_info.</param>
        public NodeGroupItem(
            string name = null,
            string createdAt = null,
            string modifiedAt = null,
            string organizationId = null,
            string partnerId = null,
            string instanceType = null,
            string edgeId = null,
            string id = null,
            string provisionId = null,
            string nodeType = null,
            int? nodes = null,
            int? nodesMin = null,
            int? nodesMax = null,
            int? nodeVolumeSize = null,
            string nodeVolumeType = null,
            bool? nodePrivateNetworking = null,
            List<string> nodeZones = null,
            string nodeAmiFamily = null,
            Models.NodeLabel nodeLabels = null,
            int? nodegroupType = null,
            bool? enableAsgAccess = null,
            bool? enableFullAccessToEcr = null,
            string versionInfoId = null,
            string upgradeInfoId = null,
            Models.NodeGroupItemTag tags = null,
            string configFileContent = null,
            Models.Provision provision = null,
            Models.VersionInfo versionInfo = null,
            Models.UpgradeInfo upgradeInfo = null)
        {
            this.Name = name;
            this.CreatedAt = createdAt;
            this.ModifiedAt = modifiedAt;
            this.OrganizationId = organizationId;
            this.PartnerId = partnerId;
            this.InstanceType = instanceType;
            this.EdgeId = edgeId;
            this.Id = id;
            this.ProvisionId = provisionId;
            this.NodeType = nodeType;
            this.Nodes = nodes;
            this.NodesMin = nodesMin;
            this.NodesMax = nodesMax;
            this.NodeVolumeSize = nodeVolumeSize;
            this.NodeVolumeType = nodeVolumeType;
            this.NodePrivateNetworking = nodePrivateNetworking;
            this.NodeZones = nodeZones;
            this.NodeAmiFamily = nodeAmiFamily;
            this.NodeLabels = nodeLabels;
            this.NodegroupType = nodegroupType;
            this.EnableAsgAccess = enableAsgAccess;
            this.EnableFullAccessToEcr = enableFullAccessToEcr;
            this.VersionInfoId = versionInfoId;
            this.UpgradeInfoId = upgradeInfoId;
            this.Tags = tags;
            this.ConfigFileContent = configFileContent;
            this.Provision = provision;
            this.VersionInfo = versionInfo;
            this.UpgradeInfo = upgradeInfo;
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
        /// Gets or sets InstanceType.
        /// </summary>
        [JsonProperty("instance_type", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceType { get; set; }

        /// <summary>
        /// Gets or sets EdgeId.
        /// </summary>
        [JsonProperty("edge_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EdgeId { get; set; }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets ProvisionId.
        /// </summary>
        [JsonProperty("provision_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProvisionId { get; set; }

        /// <summary>
        /// Gets or sets NodeType.
        /// </summary>
        [JsonProperty("node_type", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeType { get; set; }

        /// <summary>
        /// Gets or sets Nodes.
        /// </summary>
        [JsonProperty("nodes", NullValueHandling = NullValueHandling.Ignore)]
        public int? Nodes { get; set; }

        /// <summary>
        /// Gets or sets NodesMin.
        /// </summary>
        [JsonProperty("nodes_min", NullValueHandling = NullValueHandling.Ignore)]
        public int? NodesMin { get; set; }

        /// <summary>
        /// Gets or sets NodesMax.
        /// </summary>
        [JsonProperty("nodes_max", NullValueHandling = NullValueHandling.Ignore)]
        public int? NodesMax { get; set; }

        /// <summary>
        /// Gets or sets NodeVolumeSize.
        /// </summary>
        [JsonProperty("node_volume_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? NodeVolumeSize { get; set; }

        /// <summary>
        /// Gets or sets NodeVolumeType.
        /// </summary>
        [JsonProperty("node_volume_type", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeVolumeType { get; set; }

        /// <summary>
        /// Gets or sets NodePrivateNetworking.
        /// </summary>
        [JsonProperty("node_private_networking", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NodePrivateNetworking { get; set; }

        /// <summary>
        /// Gets or sets NodeZones.
        /// </summary>
        [JsonProperty("node_zones", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NodeZones { get; set; }

        /// <summary>
        /// Gets or sets NodeAmiFamily.
        /// </summary>
        [JsonProperty("node_ami_family", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeAmiFamily { get; set; }

        /// <summary>
        /// Gets or sets NodeLabels.
        /// </summary>
        [JsonProperty("node_labels", NullValueHandling = NullValueHandling.Ignore)]
        public Models.NodeLabel NodeLabels { get; set; }

        /// <summary>
        /// Gets or sets NodegroupType.
        /// </summary>
        [JsonProperty("nodegroup_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? NodegroupType { get; set; }

        /// <summary>
        /// Gets or sets EnableAsgAccess.
        /// </summary>
        [JsonProperty("enable_asg_access", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAsgAccess { get; set; }

        /// <summary>
        /// Gets or sets EnableFullAccessToEcr.
        /// </summary>
        [JsonProperty("enable_full_access_to_ecr", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableFullAccessToEcr { get; set; }

        /// <summary>
        /// Gets or sets VersionInfoId.
        /// </summary>
        [JsonProperty("version_info_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionInfoId { get; set; }

        /// <summary>
        /// Gets or sets UpgradeInfoId.
        /// </summary>
        [JsonProperty("upgrade_info_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UpgradeInfoId { get; set; }

        /// <summary>
        /// Gets or sets Tags.
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public Models.NodeGroupItemTag Tags { get; set; }

        /// <summary>
        /// Gets or sets ConfigFileContent.
        /// </summary>
        [JsonProperty("config_file_content", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigFileContent { get; set; }

        /// <summary>
        /// Gets or sets Provision.
        /// </summary>
        [JsonProperty("provision", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Provision Provision { get; set; }

        /// <summary>
        /// Gets or sets VersionInfo.
        /// </summary>
        [JsonProperty("version_info", NullValueHandling = NullValueHandling.Ignore)]
        public Models.VersionInfo VersionInfo { get; set; }

        /// <summary>
        /// Gets or sets UpgradeInfo.
        /// </summary>
        [JsonProperty("upgrade_info", NullValueHandling = NullValueHandling.Ignore)]
        public Models.UpgradeInfo UpgradeInfo { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"NodeGroupItem : ({string.Join(", ", toStringOutput)})";
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
            return obj is NodeGroupItem other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.ModifiedAt == null && other.ModifiedAt == null) || (this.ModifiedAt?.Equals(other.ModifiedAt) == true)) &&
                ((this.OrganizationId == null && other.OrganizationId == null) || (this.OrganizationId?.Equals(other.OrganizationId) == true)) &&
                ((this.PartnerId == null && other.PartnerId == null) || (this.PartnerId?.Equals(other.PartnerId) == true)) &&
                ((this.InstanceType == null && other.InstanceType == null) || (this.InstanceType?.Equals(other.InstanceType) == true)) &&
                ((this.EdgeId == null && other.EdgeId == null) || (this.EdgeId?.Equals(other.EdgeId) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.ProvisionId == null && other.ProvisionId == null) || (this.ProvisionId?.Equals(other.ProvisionId) == true)) &&
                ((this.NodeType == null && other.NodeType == null) || (this.NodeType?.Equals(other.NodeType) == true)) &&
                ((this.Nodes == null && other.Nodes == null) || (this.Nodes?.Equals(other.Nodes) == true)) &&
                ((this.NodesMin == null && other.NodesMin == null) || (this.NodesMin?.Equals(other.NodesMin) == true)) &&
                ((this.NodesMax == null && other.NodesMax == null) || (this.NodesMax?.Equals(other.NodesMax) == true)) &&
                ((this.NodeVolumeSize == null && other.NodeVolumeSize == null) || (this.NodeVolumeSize?.Equals(other.NodeVolumeSize) == true)) &&
                ((this.NodeVolumeType == null && other.NodeVolumeType == null) || (this.NodeVolumeType?.Equals(other.NodeVolumeType) == true)) &&
                ((this.NodePrivateNetworking == null && other.NodePrivateNetworking == null) || (this.NodePrivateNetworking?.Equals(other.NodePrivateNetworking) == true)) &&
                ((this.NodeZones == null && other.NodeZones == null) || (this.NodeZones?.Equals(other.NodeZones) == true)) &&
                ((this.NodeAmiFamily == null && other.NodeAmiFamily == null) || (this.NodeAmiFamily?.Equals(other.NodeAmiFamily) == true)) &&
                ((this.NodeLabels == null && other.NodeLabels == null) || (this.NodeLabels?.Equals(other.NodeLabels) == true)) &&
                ((this.NodegroupType == null && other.NodegroupType == null) || (this.NodegroupType?.Equals(other.NodegroupType) == true)) &&
                ((this.EnableAsgAccess == null && other.EnableAsgAccess == null) || (this.EnableAsgAccess?.Equals(other.EnableAsgAccess) == true)) &&
                ((this.EnableFullAccessToEcr == null && other.EnableFullAccessToEcr == null) || (this.EnableFullAccessToEcr?.Equals(other.EnableFullAccessToEcr) == true)) &&
                ((this.VersionInfoId == null && other.VersionInfoId == null) || (this.VersionInfoId?.Equals(other.VersionInfoId) == true)) &&
                ((this.UpgradeInfoId == null && other.UpgradeInfoId == null) || (this.UpgradeInfoId?.Equals(other.UpgradeInfoId) == true)) &&
                ((this.Tags == null && other.Tags == null) || (this.Tags?.Equals(other.Tags) == true)) &&
                ((this.ConfigFileContent == null && other.ConfigFileContent == null) || (this.ConfigFileContent?.Equals(other.ConfigFileContent) == true)) &&
                ((this.Provision == null && other.Provision == null) || (this.Provision?.Equals(other.Provision) == true)) &&
                ((this.VersionInfo == null && other.VersionInfo == null) || (this.VersionInfo?.Equals(other.VersionInfo) == true)) &&
                ((this.UpgradeInfo == null && other.UpgradeInfo == null) || (this.UpgradeInfo?.Equals(other.UpgradeInfo) == true));
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
            toStringOutput.Add($"this.InstanceType = {(this.InstanceType == null ? "null" : this.InstanceType == string.Empty ? "" : this.InstanceType)}");
            toStringOutput.Add($"this.EdgeId = {(this.EdgeId == null ? "null" : this.EdgeId == string.Empty ? "" : this.EdgeId)}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.ProvisionId = {(this.ProvisionId == null ? "null" : this.ProvisionId == string.Empty ? "" : this.ProvisionId)}");
            toStringOutput.Add($"this.NodeType = {(this.NodeType == null ? "null" : this.NodeType == string.Empty ? "" : this.NodeType)}");
            toStringOutput.Add($"this.Nodes = {(this.Nodes == null ? "null" : this.Nodes.ToString())}");
            toStringOutput.Add($"this.NodesMin = {(this.NodesMin == null ? "null" : this.NodesMin.ToString())}");
            toStringOutput.Add($"this.NodesMax = {(this.NodesMax == null ? "null" : this.NodesMax.ToString())}");
            toStringOutput.Add($"this.NodeVolumeSize = {(this.NodeVolumeSize == null ? "null" : this.NodeVolumeSize.ToString())}");
            toStringOutput.Add($"this.NodeVolumeType = {(this.NodeVolumeType == null ? "null" : this.NodeVolumeType == string.Empty ? "" : this.NodeVolumeType)}");
            toStringOutput.Add($"this.NodePrivateNetworking = {(this.NodePrivateNetworking == null ? "null" : this.NodePrivateNetworking.ToString())}");
            toStringOutput.Add($"this.NodeZones = {(this.NodeZones == null ? "null" : $"[{string.Join(", ", this.NodeZones)} ]")}");
            toStringOutput.Add($"this.NodeAmiFamily = {(this.NodeAmiFamily == null ? "null" : this.NodeAmiFamily == string.Empty ? "" : this.NodeAmiFamily)}");
            toStringOutput.Add($"this.NodeLabels = {(this.NodeLabels == null ? "null" : this.NodeLabels.ToString())}");
            toStringOutput.Add($"this.NodegroupType = {(this.NodegroupType == null ? "null" : this.NodegroupType.ToString())}");
            toStringOutput.Add($"this.EnableAsgAccess = {(this.EnableAsgAccess == null ? "null" : this.EnableAsgAccess.ToString())}");
            toStringOutput.Add($"this.EnableFullAccessToEcr = {(this.EnableFullAccessToEcr == null ? "null" : this.EnableFullAccessToEcr.ToString())}");
            toStringOutput.Add($"this.VersionInfoId = {(this.VersionInfoId == null ? "null" : this.VersionInfoId == string.Empty ? "" : this.VersionInfoId)}");
            toStringOutput.Add($"this.UpgradeInfoId = {(this.UpgradeInfoId == null ? "null" : this.UpgradeInfoId == string.Empty ? "" : this.UpgradeInfoId)}");
            toStringOutput.Add($"this.Tags = {(this.Tags == null ? "null" : this.Tags.ToString())}");
            toStringOutput.Add($"this.ConfigFileContent = {(this.ConfigFileContent == null ? "null" : this.ConfigFileContent == string.Empty ? "" : this.ConfigFileContent)}");
            toStringOutput.Add($"this.Provision = {(this.Provision == null ? "null" : this.Provision.ToString())}");
            toStringOutput.Add($"this.VersionInfo = {(this.VersionInfo == null ? "null" : this.VersionInfo.ToString())}");
            toStringOutput.Add($"this.UpgradeInfo = {(this.UpgradeInfo == null ? "null" : this.UpgradeInfo.ToString())}");
        }
    }
}