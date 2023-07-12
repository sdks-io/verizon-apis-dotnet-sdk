// <copyright file="NodeConfiguration.cs" company="APIMatic">
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
    /// NodeConfiguration.
    /// </summary>
    public class NodeConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeConfiguration"/> class.
        /// </summary>
        public NodeConfiguration()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeConfiguration"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="isWavelengthZone">isWavelengthZone.</param>
        /// <param name="isManagedNodeGroup">isManagedNodeGroup.</param>
        /// <param name="isSpotInstanceNeeded">isSpotInstanceNeeded.</param>
        /// <param name="endPointAccessType">endPointAccessType.</param>
        /// <param name="instanceType">instanceType.</param>
        /// <param name="nodes">nodes.</param>
        /// <param name="nodesMin">nodesMin.</param>
        /// <param name="nodesMax">nodesMax.</param>
        /// <param name="nodeVolumeType">nodeVolumeType.</param>
        /// <param name="subnetCidrBlock">subnetCidrBlock.</param>
        /// <param name="nodeAmiFamily">nodeAmiFamily.</param>
        /// <param name="nodeVolumeSize">nodeVolumeSize.</param>
        /// <param name="keyName">keyName.</param>
        /// <param name="maxPodPerNode">maxPodPerNode.</param>
        /// <param name="useVolumeEncryption">useVolumeEncryption.</param>
        /// <param name="nodePrivateNetworking">nodePrivateNetworking.</param>
        /// <param name="instanceProfileArn">instanceProfileArn.</param>
        /// <param name="instanceRoleArn">instanceRoleArn.</param>
        /// <param name="instanceRolePermissionBoundary">instanceRolePermissionBoundary.</param>
        /// <param name="securityGroupIds">securityGroupIds.</param>
        /// <param name="availabilityZoneIds">availabilityZoneIds.</param>
        /// <param name="labels">labels.</param>
        /// <param name="tags">tags.</param>
        /// <param name="autoCreateServiceRoles">autoCreateServiceRoles.</param>
        /// <param name="enableFullAccessToEcr">enableFullAccessToEcr.</param>
        /// <param name="enableAsgAccess">enableAsgAccess.</param>
        /// <param name="enableDnsAccess">enableDnsAccess.</param>
        /// <param name="enableAppMeshAccess">enableAppMeshAccess.</param>
        /// <param name="enableAlbAccess">enableAlbAccess.</param>
        /// <param name="enableEfsAccess">enableEfsAccess.</param>
        public NodeConfiguration(
            string name = null,
            bool? isWavelengthZone = false,
            bool? isManagedNodeGroup = false,
            bool? isSpotInstanceNeeded = false,
            Models.EndPointAccessTypeEnum? endPointAccessType = Models.EndPointAccessTypeEnum.Private,
            string instanceType = "m5.xlarge",
            int? nodes = 2,
            int? nodesMin = null,
            int? nodesMax = null,
            string nodeVolumeType = null,
            string subnetCidrBlock = null,
            string nodeAmiFamily = "AmazonLinux2",
            int? nodeVolumeSize = null,
            string keyName = null,
            int? maxPodPerNode = null,
            bool? useVolumeEncryption = true,
            bool? nodePrivateNetworking = false,
            string instanceProfileArn = null,
            string instanceRoleArn = null,
            string instanceRolePermissionBoundary = null,
            List<Models.IdList> securityGroupIds = null,
            List<Models.IdList> availabilityZoneIds = null,
            Models.NodeConfigurationLabel labels = null,
            Models.NodeConfigurationTag tags = null,
            bool? autoCreateServiceRoles = true,
            bool? enableFullAccessToEcr = null,
            bool? enableAsgAccess = null,
            bool? enableDnsAccess = null,
            bool? enableAppMeshAccess = null,
            bool? enableAlbAccess = null,
            bool? enableEfsAccess = null)
        {
            this.Name = name;
            this.IsWavelengthZone = isWavelengthZone;
            this.IsManagedNodeGroup = isManagedNodeGroup;
            this.IsSpotInstanceNeeded = isSpotInstanceNeeded;
            this.EndPointAccessType = endPointAccessType;
            this.InstanceType = instanceType;
            this.Nodes = nodes;
            this.NodesMin = nodesMin;
            this.NodesMax = nodesMax;
            this.NodeVolumeType = nodeVolumeType;
            this.SubnetCidrBlock = subnetCidrBlock;
            this.NodeAmiFamily = nodeAmiFamily;
            this.NodeVolumeSize = nodeVolumeSize;
            this.KeyName = keyName;
            this.MaxPodPerNode = maxPodPerNode;
            this.UseVolumeEncryption = useVolumeEncryption;
            this.NodePrivateNetworking = nodePrivateNetworking;
            this.InstanceProfileArn = instanceProfileArn;
            this.InstanceRoleArn = instanceRoleArn;
            this.InstanceRolePermissionBoundary = instanceRolePermissionBoundary;
            this.SecurityGroupIds = securityGroupIds;
            this.AvailabilityZoneIds = availabilityZoneIds;
            this.Labels = labels;
            this.Tags = tags;
            this.AutoCreateServiceRoles = autoCreateServiceRoles;
            this.EnableFullAccessToEcr = enableFullAccessToEcr;
            this.EnableAsgAccess = enableAsgAccess;
            this.EnableDnsAccess = enableDnsAccess;
            this.EnableAppMeshAccess = enableAppMeshAccess;
            this.EnableAlbAccess = enableAlbAccess;
            this.EnableEfsAccess = enableEfsAccess;
        }

        /// <summary>
        /// Name of the nodeGroup.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets IsWavelengthZone.
        /// </summary>
        [JsonProperty("isWavelengthZone", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsWavelengthZone { get; set; }

        /// <summary>
        /// Gets or sets IsManagedNodeGroup.
        /// </summary>
        [JsonProperty("isManagedNodeGroup", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsManagedNodeGroup { get; set; }

        /// <summary>
        /// Gets or sets IsSpotInstanceNeeded.
        /// </summary>
        [JsonProperty("isSpotInstanceNeeded", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSpotInstanceNeeded { get; set; }

        /// <summary>
        /// Gets or sets EndPointAccessType.
        /// </summary>
        [JsonProperty("endPointAccessType", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.EndPointAccessTypeEnum? EndPointAccessType { get; set; }

        /// <summary>
        /// Gets or sets InstanceType.
        /// </summary>
        [JsonProperty("instanceType", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceType { get; set; }

        /// <summary>
        /// Gets or sets Nodes.
        /// </summary>
        [JsonProperty("nodes", NullValueHandling = NullValueHandling.Ignore)]
        public int? Nodes { get; set; }

        /// <summary>
        /// Gets or sets NodesMin.
        /// </summary>
        [JsonProperty("nodesMin", NullValueHandling = NullValueHandling.Ignore)]
        public int? NodesMin { get; set; }

        /// <summary>
        /// Gets or sets NodesMax.
        /// </summary>
        [JsonProperty("nodesMax", NullValueHandling = NullValueHandling.Ignore)]
        public int? NodesMax { get; set; }

        /// <summary>
        /// Gets or sets NodeVolumeType.
        /// </summary>
        [JsonProperty("nodeVolumeType", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeVolumeType { get; set; }

        /// <summary>
        /// Gets or sets SubnetCidrBlock.
        /// </summary>
        [JsonProperty("subnetCidrBlock", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetCidrBlock { get; set; }

        /// <summary>
        /// Gets or sets NodeAmiFamily.
        /// </summary>
        [JsonProperty("nodeAmiFamily", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeAmiFamily { get; set; }

        /// <summary>
        /// Gets or sets NodeVolumeSize.
        /// </summary>
        [JsonProperty("nodeVolumeSize", NullValueHandling = NullValueHandling.Ignore)]
        public int? NodeVolumeSize { get; set; }

        /// <summary>
        /// Gets or sets KeyName.
        /// </summary>
        [JsonProperty("keyName", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyName { get; set; }

        /// <summary>
        /// Gets or sets MaxPodPerNode.
        /// </summary>
        [JsonProperty("maxPodPerNode", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxPodPerNode { get; set; }

        /// <summary>
        /// Gets or sets UseVolumeEncryption.
        /// </summary>
        [JsonProperty("useVolumeEncryption", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseVolumeEncryption { get; set; }

        /// <summary>
        /// Gets or sets NodePrivateNetworking.
        /// </summary>
        [JsonProperty("nodePrivateNetworking", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NodePrivateNetworking { get; set; }

        /// <summary>
        /// Gets or sets InstanceProfileArn.
        /// </summary>
        [JsonProperty("instanceProfileArn", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceProfileArn { get; set; }

        /// <summary>
        /// Gets or sets InstanceRoleArn.
        /// </summary>
        [JsonProperty("instanceRoleArn", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceRoleArn { get; set; }

        /// <summary>
        /// Gets or sets InstanceRolePermissionBoundary.
        /// </summary>
        [JsonProperty("instanceRolePermissionBoundary", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceRolePermissionBoundary { get; set; }

        /// <summary>
        /// Gets or sets SecurityGroupIds.
        /// </summary>
        [JsonProperty("securityGroupIds", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.IdList> SecurityGroupIds { get; set; }

        /// <summary>
        /// Gets or sets AvailabilityZoneIds.
        /// </summary>
        [JsonProperty("availabilityZoneIds", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.IdList> AvailabilityZoneIds { get; set; }

        /// <summary>
        /// Gets or sets Labels.
        /// </summary>
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public Models.NodeConfigurationLabel Labels { get; set; }

        /// <summary>
        /// Gets or sets Tags.
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public Models.NodeConfigurationTag Tags { get; set; }

        /// <summary>
        /// Gets or sets AutoCreateServiceRoles.
        /// </summary>
        [JsonProperty("autoCreateServiceRoles", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoCreateServiceRoles { get; set; }

        /// <summary>
        /// Gets or sets EnableFullAccessToEcr.
        /// </summary>
        [JsonProperty("enableFullAccessToEcr", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableFullAccessToEcr { get; set; }

        /// <summary>
        /// Gets or sets EnableAsgAccess.
        /// </summary>
        [JsonProperty("enableAsgAccess", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAsgAccess { get; set; }

        /// <summary>
        /// Gets or sets EnableDnsAccess.
        /// </summary>
        [JsonProperty("enableDnsAccess", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableDnsAccess { get; set; }

        /// <summary>
        /// Gets or sets EnableAppMeshAccess.
        /// </summary>
        [JsonProperty("enableAppMeshAccess", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAppMeshAccess { get; set; }

        /// <summary>
        /// Gets or sets EnableAlbAccess.
        /// </summary>
        [JsonProperty("enableAlbAccess", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAlbAccess { get; set; }

        /// <summary>
        /// Gets or sets EnableEfsAccess.
        /// </summary>
        [JsonProperty("enableEfsAccess", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableEfsAccess { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"NodeConfiguration : ({string.Join(", ", toStringOutput)})";
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
            return obj is NodeConfiguration other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.IsWavelengthZone == null && other.IsWavelengthZone == null) || (this.IsWavelengthZone?.Equals(other.IsWavelengthZone) == true)) &&
                ((this.IsManagedNodeGroup == null && other.IsManagedNodeGroup == null) || (this.IsManagedNodeGroup?.Equals(other.IsManagedNodeGroup) == true)) &&
                ((this.IsSpotInstanceNeeded == null && other.IsSpotInstanceNeeded == null) || (this.IsSpotInstanceNeeded?.Equals(other.IsSpotInstanceNeeded) == true)) &&
                ((this.EndPointAccessType == null && other.EndPointAccessType == null) || (this.EndPointAccessType?.Equals(other.EndPointAccessType) == true)) &&
                ((this.InstanceType == null && other.InstanceType == null) || (this.InstanceType?.Equals(other.InstanceType) == true)) &&
                ((this.Nodes == null && other.Nodes == null) || (this.Nodes?.Equals(other.Nodes) == true)) &&
                ((this.NodesMin == null && other.NodesMin == null) || (this.NodesMin?.Equals(other.NodesMin) == true)) &&
                ((this.NodesMax == null && other.NodesMax == null) || (this.NodesMax?.Equals(other.NodesMax) == true)) &&
                ((this.NodeVolumeType == null && other.NodeVolumeType == null) || (this.NodeVolumeType?.Equals(other.NodeVolumeType) == true)) &&
                ((this.SubnetCidrBlock == null && other.SubnetCidrBlock == null) || (this.SubnetCidrBlock?.Equals(other.SubnetCidrBlock) == true)) &&
                ((this.NodeAmiFamily == null && other.NodeAmiFamily == null) || (this.NodeAmiFamily?.Equals(other.NodeAmiFamily) == true)) &&
                ((this.NodeVolumeSize == null && other.NodeVolumeSize == null) || (this.NodeVolumeSize?.Equals(other.NodeVolumeSize) == true)) &&
                ((this.KeyName == null && other.KeyName == null) || (this.KeyName?.Equals(other.KeyName) == true)) &&
                ((this.MaxPodPerNode == null && other.MaxPodPerNode == null) || (this.MaxPodPerNode?.Equals(other.MaxPodPerNode) == true)) &&
                ((this.UseVolumeEncryption == null && other.UseVolumeEncryption == null) || (this.UseVolumeEncryption?.Equals(other.UseVolumeEncryption) == true)) &&
                ((this.NodePrivateNetworking == null && other.NodePrivateNetworking == null) || (this.NodePrivateNetworking?.Equals(other.NodePrivateNetworking) == true)) &&
                ((this.InstanceProfileArn == null && other.InstanceProfileArn == null) || (this.InstanceProfileArn?.Equals(other.InstanceProfileArn) == true)) &&
                ((this.InstanceRoleArn == null && other.InstanceRoleArn == null) || (this.InstanceRoleArn?.Equals(other.InstanceRoleArn) == true)) &&
                ((this.InstanceRolePermissionBoundary == null && other.InstanceRolePermissionBoundary == null) || (this.InstanceRolePermissionBoundary?.Equals(other.InstanceRolePermissionBoundary) == true)) &&
                ((this.SecurityGroupIds == null && other.SecurityGroupIds == null) || (this.SecurityGroupIds?.Equals(other.SecurityGroupIds) == true)) &&
                ((this.AvailabilityZoneIds == null && other.AvailabilityZoneIds == null) || (this.AvailabilityZoneIds?.Equals(other.AvailabilityZoneIds) == true)) &&
                ((this.Labels == null && other.Labels == null) || (this.Labels?.Equals(other.Labels) == true)) &&
                ((this.Tags == null && other.Tags == null) || (this.Tags?.Equals(other.Tags) == true)) &&
                ((this.AutoCreateServiceRoles == null && other.AutoCreateServiceRoles == null) || (this.AutoCreateServiceRoles?.Equals(other.AutoCreateServiceRoles) == true)) &&
                ((this.EnableFullAccessToEcr == null && other.EnableFullAccessToEcr == null) || (this.EnableFullAccessToEcr?.Equals(other.EnableFullAccessToEcr) == true)) &&
                ((this.EnableAsgAccess == null && other.EnableAsgAccess == null) || (this.EnableAsgAccess?.Equals(other.EnableAsgAccess) == true)) &&
                ((this.EnableDnsAccess == null && other.EnableDnsAccess == null) || (this.EnableDnsAccess?.Equals(other.EnableDnsAccess) == true)) &&
                ((this.EnableAppMeshAccess == null && other.EnableAppMeshAccess == null) || (this.EnableAppMeshAccess?.Equals(other.EnableAppMeshAccess) == true)) &&
                ((this.EnableAlbAccess == null && other.EnableAlbAccess == null) || (this.EnableAlbAccess?.Equals(other.EnableAlbAccess) == true)) &&
                ((this.EnableEfsAccess == null && other.EnableEfsAccess == null) || (this.EnableEfsAccess?.Equals(other.EnableEfsAccess) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.IsWavelengthZone = {(this.IsWavelengthZone == null ? "null" : this.IsWavelengthZone.ToString())}");
            toStringOutput.Add($"this.IsManagedNodeGroup = {(this.IsManagedNodeGroup == null ? "null" : this.IsManagedNodeGroup.ToString())}");
            toStringOutput.Add($"this.IsSpotInstanceNeeded = {(this.IsSpotInstanceNeeded == null ? "null" : this.IsSpotInstanceNeeded.ToString())}");
            toStringOutput.Add($"this.EndPointAccessType = {(this.EndPointAccessType == null ? "null" : this.EndPointAccessType.ToString())}");
            toStringOutput.Add($"this.InstanceType = {(this.InstanceType == null ? "null" : this.InstanceType == string.Empty ? "" : this.InstanceType)}");
            toStringOutput.Add($"this.Nodes = {(this.Nodes == null ? "null" : this.Nodes.ToString())}");
            toStringOutput.Add($"this.NodesMin = {(this.NodesMin == null ? "null" : this.NodesMin.ToString())}");
            toStringOutput.Add($"this.NodesMax = {(this.NodesMax == null ? "null" : this.NodesMax.ToString())}");
            toStringOutput.Add($"this.NodeVolumeType = {(this.NodeVolumeType == null ? "null" : this.NodeVolumeType == string.Empty ? "" : this.NodeVolumeType)}");
            toStringOutput.Add($"this.SubnetCidrBlock = {(this.SubnetCidrBlock == null ? "null" : this.SubnetCidrBlock == string.Empty ? "" : this.SubnetCidrBlock)}");
            toStringOutput.Add($"this.NodeAmiFamily = {(this.NodeAmiFamily == null ? "null" : this.NodeAmiFamily == string.Empty ? "" : this.NodeAmiFamily)}");
            toStringOutput.Add($"this.NodeVolumeSize = {(this.NodeVolumeSize == null ? "null" : this.NodeVolumeSize.ToString())}");
            toStringOutput.Add($"this.KeyName = {(this.KeyName == null ? "null" : this.KeyName == string.Empty ? "" : this.KeyName)}");
            toStringOutput.Add($"this.MaxPodPerNode = {(this.MaxPodPerNode == null ? "null" : this.MaxPodPerNode.ToString())}");
            toStringOutput.Add($"this.UseVolumeEncryption = {(this.UseVolumeEncryption == null ? "null" : this.UseVolumeEncryption.ToString())}");
            toStringOutput.Add($"this.NodePrivateNetworking = {(this.NodePrivateNetworking == null ? "null" : this.NodePrivateNetworking.ToString())}");
            toStringOutput.Add($"this.InstanceProfileArn = {(this.InstanceProfileArn == null ? "null" : this.InstanceProfileArn == string.Empty ? "" : this.InstanceProfileArn)}");
            toStringOutput.Add($"this.InstanceRoleArn = {(this.InstanceRoleArn == null ? "null" : this.InstanceRoleArn == string.Empty ? "" : this.InstanceRoleArn)}");
            toStringOutput.Add($"this.InstanceRolePermissionBoundary = {(this.InstanceRolePermissionBoundary == null ? "null" : this.InstanceRolePermissionBoundary == string.Empty ? "" : this.InstanceRolePermissionBoundary)}");
            toStringOutput.Add($"this.SecurityGroupIds = {(this.SecurityGroupIds == null ? "null" : $"[{string.Join(", ", this.SecurityGroupIds)} ]")}");
            toStringOutput.Add($"this.AvailabilityZoneIds = {(this.AvailabilityZoneIds == null ? "null" : $"[{string.Join(", ", this.AvailabilityZoneIds)} ]")}");
            toStringOutput.Add($"this.Labels = {(this.Labels == null ? "null" : this.Labels.ToString())}");
            toStringOutput.Add($"this.Tags = {(this.Tags == null ? "null" : this.Tags.ToString())}");
            toStringOutput.Add($"this.AutoCreateServiceRoles = {(this.AutoCreateServiceRoles == null ? "null" : this.AutoCreateServiceRoles.ToString())}");
            toStringOutput.Add($"this.EnableFullAccessToEcr = {(this.EnableFullAccessToEcr == null ? "null" : this.EnableFullAccessToEcr.ToString())}");
            toStringOutput.Add($"this.EnableAsgAccess = {(this.EnableAsgAccess == null ? "null" : this.EnableAsgAccess.ToString())}");
            toStringOutput.Add($"this.EnableDnsAccess = {(this.EnableDnsAccess == null ? "null" : this.EnableDnsAccess.ToString())}");
            toStringOutput.Add($"this.EnableAppMeshAccess = {(this.EnableAppMeshAccess == null ? "null" : this.EnableAppMeshAccess.ToString())}");
            toStringOutput.Add($"this.EnableAlbAccess = {(this.EnableAlbAccess == null ? "null" : this.EnableAlbAccess.ToString())}");
            toStringOutput.Add($"this.EnableEfsAccess = {(this.EnableEfsAccess == null ? "null" : this.EnableEfsAccess.ToString())}");
        }
    }
}