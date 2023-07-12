// <copyright file="ClusterMetadata.cs" company="APIMatic">
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
    /// ClusterMetadata.
    /// </summary>
    public class ClusterMetadata
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterMetadata"/> class.
        /// </summary>
        public ClusterMetadata()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterMetadata"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="clusterType">clusterType.</param>
        /// <param name="cloud">cloud.</param>
        /// <param name="dataCenter">dataCenter.</param>
        /// <param name="labels">labels.</param>
        /// <param name="ingressIps">ingressIps.</param>
        /// <param name="upgradeProtection">upgradeProtection.</param>
        public ClusterMetadata(
            string name = null,
            string description = null,
            Models.ClusterTypeEnum? clusterType = null,
            Models.Cloud cloud = null,
            Models.DataCenter dataCenter = null,
            List<Models.EdgeServiceLaunchParams> labels = null,
            Models.ServiceLaunchClusterAdditionalParams ingressIps = null,
            bool? upgradeProtection = null)
        {
            this.Name = name;
            this.Description = description;
            this.ClusterType = clusterType;
            this.Cloud = cloud;
            this.DataCenter = dataCenter;
            this.Labels = labels;
            this.IngressIps = ingressIps;
            this.UpgradeProtection = upgradeProtection;
        }

        /// <summary>
        /// Name of the cluster to be used.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Description of the cluster.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets ClusterType.
        /// </summary>
        [JsonProperty("clusterType", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.ClusterTypeEnum? ClusterType { get; set; }

        /// <summary>
        /// Gets or sets Cloud.
        /// </summary>
        [JsonProperty("cloud", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Cloud Cloud { get; set; }

        /// <summary>
        /// Gets or sets DataCenter.
        /// </summary>
        [JsonProperty("dataCenter", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DataCenter DataCenter { get; set; }

        /// <summary>
        /// Gets or sets Labels.
        /// </summary>
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.EdgeServiceLaunchParams> Labels { get; set; }

        /// <summary>
        /// Gets or sets IngressIps.
        /// </summary>
        [JsonProperty("ingressIps", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ServiceLaunchClusterAdditionalParams IngressIps { get; set; }

        /// <summary>
        /// Gets or sets UpgradeProtection.
        /// </summary>
        [JsonProperty("upgradeProtection", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UpgradeProtection { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ClusterMetadata : ({string.Join(", ", toStringOutput)})";
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
            return obj is ClusterMetadata other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.ClusterType == null && other.ClusterType == null) || (this.ClusterType?.Equals(other.ClusterType) == true)) &&
                ((this.Cloud == null && other.Cloud == null) || (this.Cloud?.Equals(other.Cloud) == true)) &&
                ((this.DataCenter == null && other.DataCenter == null) || (this.DataCenter?.Equals(other.DataCenter) == true)) &&
                ((this.Labels == null && other.Labels == null) || (this.Labels?.Equals(other.Labels) == true)) &&
                ((this.IngressIps == null && other.IngressIps == null) || (this.IngressIps?.Equals(other.IngressIps) == true)) &&
                ((this.UpgradeProtection == null && other.UpgradeProtection == null) || (this.UpgradeProtection?.Equals(other.UpgradeProtection) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.ClusterType = {(this.ClusterType == null ? "null" : this.ClusterType.ToString())}");
            toStringOutput.Add($"this.Cloud = {(this.Cloud == null ? "null" : this.Cloud.ToString())}");
            toStringOutput.Add($"this.DataCenter = {(this.DataCenter == null ? "null" : this.DataCenter.ToString())}");
            toStringOutput.Add($"this.Labels = {(this.Labels == null ? "null" : $"[{string.Join(", ", this.Labels)} ]")}");
            toStringOutput.Add($"this.IngressIps = {(this.IngressIps == null ? "null" : this.IngressIps.ToString())}");
            toStringOutput.Add($"this.UpgradeProtection = {(this.UpgradeProtection == null ? "null" : this.UpgradeProtection.ToString())}");
        }
    }
}