// <copyright file="Cloud.cs" company="APIMatic">
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
    /// Cloud.
    /// </summary>
    public class Cloud
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cloud"/> class.
        /// </summary>
        public Cloud()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Cloud"/> class.
        /// </summary>
        /// <param name="provider">provider.</param>
        /// <param name="distribution">distribution.</param>
        /// <param name="commonConfig">commonConfig.</param>
        /// <param name="clusterConfig">clusterConfig.</param>
        /// <param name="nodeConfig">nodeConfig.</param>
        /// <param name="nodeConfigs">nodeConfigs.</param>
        /// <param name="advanceConfig">advanceConfig.</param>
        public Cloud(
            Models.CloudProviderEnum? provider = null,
            Models.CloudDestributionEnum? distribution = null,
            Models.CommonConfiguration commonConfig = null,
            Models.ClusterConfiguration clusterConfig = null,
            Models.NodeConfiguration nodeConfig = null,
            List<Models.NodeConfiguration> nodeConfigs = null,
            Models.AdvanceConfiguration advanceConfig = null)
        {
            this.Provider = provider;
            this.Distribution = distribution;
            this.CommonConfig = commonConfig;
            this.ClusterConfig = clusterConfig;
            this.NodeConfig = nodeConfig;
            this.NodeConfigs = nodeConfigs;
            this.AdvanceConfig = advanceConfig;
        }

        /// <summary>
        /// Cloud provider where you plan to provision and operate your Kubernetes cluster.
        /// </summary>
        [JsonProperty("provider", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.CloudProviderEnum? Provider { get; set; }

        /// <summary>
        /// Supported Kubernetes distribution for the selected cloud provider.
        /// </summary>
        [JsonProperty("distribution", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.CloudDestributionEnum? Distribution { get; set; }

        /// <summary>
        /// Gets or sets CommonConfig.
        /// </summary>
        [JsonProperty("commonConfig", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CommonConfiguration CommonConfig { get; set; }

        /// <summary>
        /// Gets or sets ClusterConfig.
        /// </summary>
        [JsonProperty("clusterConfig", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ClusterConfiguration ClusterConfig { get; set; }

        /// <summary>
        /// Gets or sets NodeConfig.
        /// </summary>
        [JsonProperty("nodeConfig", NullValueHandling = NullValueHandling.Ignore)]
        public Models.NodeConfiguration NodeConfig { get; set; }

        /// <summary>
        /// Gets or sets NodeConfigs.
        /// </summary>
        [JsonProperty("nodeConfigs", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.NodeConfiguration> NodeConfigs { get; set; }

        /// <summary>
        /// Gets or sets AdvanceConfig.
        /// </summary>
        [JsonProperty("advanceConfig", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AdvanceConfiguration AdvanceConfig { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Cloud : ({string.Join(", ", toStringOutput)})";
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
            return obj is Cloud other &&                ((this.Provider == null && other.Provider == null) || (this.Provider?.Equals(other.Provider) == true)) &&
                ((this.Distribution == null && other.Distribution == null) || (this.Distribution?.Equals(other.Distribution) == true)) &&
                ((this.CommonConfig == null && other.CommonConfig == null) || (this.CommonConfig?.Equals(other.CommonConfig) == true)) &&
                ((this.ClusterConfig == null && other.ClusterConfig == null) || (this.ClusterConfig?.Equals(other.ClusterConfig) == true)) &&
                ((this.NodeConfig == null && other.NodeConfig == null) || (this.NodeConfig?.Equals(other.NodeConfig) == true)) &&
                ((this.NodeConfigs == null && other.NodeConfigs == null) || (this.NodeConfigs?.Equals(other.NodeConfigs) == true)) &&
                ((this.AdvanceConfig == null && other.AdvanceConfig == null) || (this.AdvanceConfig?.Equals(other.AdvanceConfig) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Provider = {(this.Provider == null ? "null" : this.Provider.ToString())}");
            toStringOutput.Add($"this.Distribution = {(this.Distribution == null ? "null" : this.Distribution.ToString())}");
            toStringOutput.Add($"this.CommonConfig = {(this.CommonConfig == null ? "null" : this.CommonConfig.ToString())}");
            toStringOutput.Add($"this.ClusterConfig = {(this.ClusterConfig == null ? "null" : this.ClusterConfig.ToString())}");
            toStringOutput.Add($"this.NodeConfig = {(this.NodeConfig == null ? "null" : this.NodeConfig.ToString())}");
            toStringOutput.Add($"this.NodeConfigs = {(this.NodeConfigs == null ? "null" : $"[{string.Join(", ", this.NodeConfigs)} ]")}");
            toStringOutput.Add($"this.AdvanceConfig = {(this.AdvanceConfig == null ? "null" : this.AdvanceConfig.ToString())}");
        }
    }
}