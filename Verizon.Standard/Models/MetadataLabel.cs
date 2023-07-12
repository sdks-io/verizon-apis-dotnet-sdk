// <copyright file="MetadataLabel.cs" company="APIMatic">
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
    /// MetadataLabel.
    /// </summary>
    public class MetadataLabel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataLabel"/> class.
        /// </summary>
        public MetadataLabel()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataLabel"/> class.
        /// </summary>
        /// <param name="alphaRafayIoClusterName">alpha.rafay.io/cluster-name.</param>
        /// <param name="alphaRafayIoInstanceId">alpha.rafay.io/instance-id.</param>
        /// <param name="alphaRafayIoNodegroupName">alpha.rafay.io/nodegroup-name.</param>
        /// <param name="betaKubernetesIoArch">beta.kubernetes.io/arch.</param>
        /// <param name="betaKubernetesIoInstanceType">beta.kubernetes.io/instance-type.</param>
        /// <param name="betaKubernetesIoOs">beta.kubernetes.io/os.</param>
        /// <param name="failureDomainBetaKubernetesIoRegion">failure-domain.beta.kubernetes.io/region.</param>
        /// <param name="failureDomainBetaKubernetesIoZone">failure-domain.beta.kubernetes.io/zone.</param>
        /// <param name="kubernetesIoArch">kubernetes.io/arch.</param>
        /// <param name="kubernetesIoHostname">kubernetes.io/hostname.</param>
        /// <param name="kubernetesIoOs">kubernetes.io/os.</param>
        /// <param name="nodeLifecycle">node-lifecycle.</param>
        /// <param name="nodeKubernetesIoInstanceType">node.kubernetes.io/instance-type.</param>
        /// <param name="topologyKubernetesIoRegion">topology.kubernetes.io/region.</param>
        /// <param name="topologyKubernetesIoZone">topology.kubernetes.io/zone.</param>
        public MetadataLabel(
            string alphaRafayIoClusterName = null,
            string alphaRafayIoInstanceId = null,
            string alphaRafayIoNodegroupName = null,
            string betaKubernetesIoArch = null,
            string betaKubernetesIoInstanceType = null,
            string betaKubernetesIoOs = null,
            string failureDomainBetaKubernetesIoRegion = null,
            string failureDomainBetaKubernetesIoZone = null,
            string kubernetesIoArch = null,
            string kubernetesIoHostname = null,
            string kubernetesIoOs = null,
            string nodeLifecycle = null,
            string nodeKubernetesIoInstanceType = null,
            string topologyKubernetesIoRegion = null,
            string topologyKubernetesIoZone = null)
        {
            this.AlphaRafayIoClusterName = alphaRafayIoClusterName;
            this.AlphaRafayIoInstanceId = alphaRafayIoInstanceId;
            this.AlphaRafayIoNodegroupName = alphaRafayIoNodegroupName;
            this.BetaKubernetesIoArch = betaKubernetesIoArch;
            this.BetaKubernetesIoInstanceType = betaKubernetesIoInstanceType;
            this.BetaKubernetesIoOs = betaKubernetesIoOs;
            this.FailureDomainBetaKubernetesIoRegion = failureDomainBetaKubernetesIoRegion;
            this.FailureDomainBetaKubernetesIoZone = failureDomainBetaKubernetesIoZone;
            this.KubernetesIoArch = kubernetesIoArch;
            this.KubernetesIoHostname = kubernetesIoHostname;
            this.KubernetesIoOs = kubernetesIoOs;
            this.NodeLifecycle = nodeLifecycle;
            this.NodeKubernetesIoInstanceType = nodeKubernetesIoInstanceType;
            this.TopologyKubernetesIoRegion = topologyKubernetesIoRegion;
            this.TopologyKubernetesIoZone = topologyKubernetesIoZone;
        }

        /// <summary>
        /// Gets or sets AlphaRafayIoClusterName.
        /// </summary>
        [JsonProperty("alpha.rafay.io/cluster-name", NullValueHandling = NullValueHandling.Ignore)]
        public string AlphaRafayIoClusterName { get; set; }

        /// <summary>
        /// Gets or sets AlphaRafayIoInstanceId.
        /// </summary>
        [JsonProperty("alpha.rafay.io/instance-id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlphaRafayIoInstanceId { get; set; }

        /// <summary>
        /// Gets or sets AlphaRafayIoNodegroupName.
        /// </summary>
        [JsonProperty("alpha.rafay.io/nodegroup-name", NullValueHandling = NullValueHandling.Ignore)]
        public string AlphaRafayIoNodegroupName { get; set; }

        /// <summary>
        /// Gets or sets BetaKubernetesIoArch.
        /// </summary>
        [JsonProperty("beta.kubernetes.io/arch", NullValueHandling = NullValueHandling.Ignore)]
        public string BetaKubernetesIoArch { get; set; }

        /// <summary>
        /// Gets or sets BetaKubernetesIoInstanceType.
        /// </summary>
        [JsonProperty("beta.kubernetes.io/instance-type", NullValueHandling = NullValueHandling.Ignore)]
        public string BetaKubernetesIoInstanceType { get; set; }

        /// <summary>
        /// Gets or sets BetaKubernetesIoOs.
        /// </summary>
        [JsonProperty("beta.kubernetes.io/os", NullValueHandling = NullValueHandling.Ignore)]
        public string BetaKubernetesIoOs { get; set; }

        /// <summary>
        /// Gets or sets FailureDomainBetaKubernetesIoRegion.
        /// </summary>
        [JsonProperty("failure-domain.beta.kubernetes.io/region", NullValueHandling = NullValueHandling.Ignore)]
        public string FailureDomainBetaKubernetesIoRegion { get; set; }

        /// <summary>
        /// Gets or sets FailureDomainBetaKubernetesIoZone.
        /// </summary>
        [JsonProperty("failure-domain.beta.kubernetes.io/zone", NullValueHandling = NullValueHandling.Ignore)]
        public string FailureDomainBetaKubernetesIoZone { get; set; }

        /// <summary>
        /// Gets or sets KubernetesIoArch.
        /// </summary>
        [JsonProperty("kubernetes.io/arch", NullValueHandling = NullValueHandling.Ignore)]
        public string KubernetesIoArch { get; set; }

        /// <summary>
        /// Gets or sets KubernetesIoHostname.
        /// </summary>
        [JsonProperty("kubernetes.io/hostname", NullValueHandling = NullValueHandling.Ignore)]
        public string KubernetesIoHostname { get; set; }

        /// <summary>
        /// Gets or sets KubernetesIoOs.
        /// </summary>
        [JsonProperty("kubernetes.io/os", NullValueHandling = NullValueHandling.Ignore)]
        public string KubernetesIoOs { get; set; }

        /// <summary>
        /// Gets or sets NodeLifecycle.
        /// </summary>
        [JsonProperty("node-lifecycle", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeLifecycle { get; set; }

        /// <summary>
        /// Gets or sets NodeKubernetesIoInstanceType.
        /// </summary>
        [JsonProperty("node.kubernetes.io/instance-type", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeKubernetesIoInstanceType { get; set; }

        /// <summary>
        /// Gets or sets TopologyKubernetesIoRegion.
        /// </summary>
        [JsonProperty("topology.kubernetes.io/region", NullValueHandling = NullValueHandling.Ignore)]
        public string TopologyKubernetesIoRegion { get; set; }

        /// <summary>
        /// Gets or sets TopologyKubernetesIoZone.
        /// </summary>
        [JsonProperty("topology.kubernetes.io/zone", NullValueHandling = NullValueHandling.Ignore)]
        public string TopologyKubernetesIoZone { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MetadataLabel : ({string.Join(", ", toStringOutput)})";
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
            return obj is MetadataLabel other &&                ((this.AlphaRafayIoClusterName == null && other.AlphaRafayIoClusterName == null) || (this.AlphaRafayIoClusterName?.Equals(other.AlphaRafayIoClusterName) == true)) &&
                ((this.AlphaRafayIoInstanceId == null && other.AlphaRafayIoInstanceId == null) || (this.AlphaRafayIoInstanceId?.Equals(other.AlphaRafayIoInstanceId) == true)) &&
                ((this.AlphaRafayIoNodegroupName == null && other.AlphaRafayIoNodegroupName == null) || (this.AlphaRafayIoNodegroupName?.Equals(other.AlphaRafayIoNodegroupName) == true)) &&
                ((this.BetaKubernetesIoArch == null && other.BetaKubernetesIoArch == null) || (this.BetaKubernetesIoArch?.Equals(other.BetaKubernetesIoArch) == true)) &&
                ((this.BetaKubernetesIoInstanceType == null && other.BetaKubernetesIoInstanceType == null) || (this.BetaKubernetesIoInstanceType?.Equals(other.BetaKubernetesIoInstanceType) == true)) &&
                ((this.BetaKubernetesIoOs == null && other.BetaKubernetesIoOs == null) || (this.BetaKubernetesIoOs?.Equals(other.BetaKubernetesIoOs) == true)) &&
                ((this.FailureDomainBetaKubernetesIoRegion == null && other.FailureDomainBetaKubernetesIoRegion == null) || (this.FailureDomainBetaKubernetesIoRegion?.Equals(other.FailureDomainBetaKubernetesIoRegion) == true)) &&
                ((this.FailureDomainBetaKubernetesIoZone == null && other.FailureDomainBetaKubernetesIoZone == null) || (this.FailureDomainBetaKubernetesIoZone?.Equals(other.FailureDomainBetaKubernetesIoZone) == true)) &&
                ((this.KubernetesIoArch == null && other.KubernetesIoArch == null) || (this.KubernetesIoArch?.Equals(other.KubernetesIoArch) == true)) &&
                ((this.KubernetesIoHostname == null && other.KubernetesIoHostname == null) || (this.KubernetesIoHostname?.Equals(other.KubernetesIoHostname) == true)) &&
                ((this.KubernetesIoOs == null && other.KubernetesIoOs == null) || (this.KubernetesIoOs?.Equals(other.KubernetesIoOs) == true)) &&
                ((this.NodeLifecycle == null && other.NodeLifecycle == null) || (this.NodeLifecycle?.Equals(other.NodeLifecycle) == true)) &&
                ((this.NodeKubernetesIoInstanceType == null && other.NodeKubernetesIoInstanceType == null) || (this.NodeKubernetesIoInstanceType?.Equals(other.NodeKubernetesIoInstanceType) == true)) &&
                ((this.TopologyKubernetesIoRegion == null && other.TopologyKubernetesIoRegion == null) || (this.TopologyKubernetesIoRegion?.Equals(other.TopologyKubernetesIoRegion) == true)) &&
                ((this.TopologyKubernetesIoZone == null && other.TopologyKubernetesIoZone == null) || (this.TopologyKubernetesIoZone?.Equals(other.TopologyKubernetesIoZone) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AlphaRafayIoClusterName = {(this.AlphaRafayIoClusterName == null ? "null" : this.AlphaRafayIoClusterName == string.Empty ? "" : this.AlphaRafayIoClusterName)}");
            toStringOutput.Add($"this.AlphaRafayIoInstanceId = {(this.AlphaRafayIoInstanceId == null ? "null" : this.AlphaRafayIoInstanceId == string.Empty ? "" : this.AlphaRafayIoInstanceId)}");
            toStringOutput.Add($"this.AlphaRafayIoNodegroupName = {(this.AlphaRafayIoNodegroupName == null ? "null" : this.AlphaRafayIoNodegroupName == string.Empty ? "" : this.AlphaRafayIoNodegroupName)}");
            toStringOutput.Add($"this.BetaKubernetesIoArch = {(this.BetaKubernetesIoArch == null ? "null" : this.BetaKubernetesIoArch == string.Empty ? "" : this.BetaKubernetesIoArch)}");
            toStringOutput.Add($"this.BetaKubernetesIoInstanceType = {(this.BetaKubernetesIoInstanceType == null ? "null" : this.BetaKubernetesIoInstanceType == string.Empty ? "" : this.BetaKubernetesIoInstanceType)}");
            toStringOutput.Add($"this.BetaKubernetesIoOs = {(this.BetaKubernetesIoOs == null ? "null" : this.BetaKubernetesIoOs == string.Empty ? "" : this.BetaKubernetesIoOs)}");
            toStringOutput.Add($"this.FailureDomainBetaKubernetesIoRegion = {(this.FailureDomainBetaKubernetesIoRegion == null ? "null" : this.FailureDomainBetaKubernetesIoRegion == string.Empty ? "" : this.FailureDomainBetaKubernetesIoRegion)}");
            toStringOutput.Add($"this.FailureDomainBetaKubernetesIoZone = {(this.FailureDomainBetaKubernetesIoZone == null ? "null" : this.FailureDomainBetaKubernetesIoZone == string.Empty ? "" : this.FailureDomainBetaKubernetesIoZone)}");
            toStringOutput.Add($"this.KubernetesIoArch = {(this.KubernetesIoArch == null ? "null" : this.KubernetesIoArch == string.Empty ? "" : this.KubernetesIoArch)}");
            toStringOutput.Add($"this.KubernetesIoHostname = {(this.KubernetesIoHostname == null ? "null" : this.KubernetesIoHostname == string.Empty ? "" : this.KubernetesIoHostname)}");
            toStringOutput.Add($"this.KubernetesIoOs = {(this.KubernetesIoOs == null ? "null" : this.KubernetesIoOs == string.Empty ? "" : this.KubernetesIoOs)}");
            toStringOutput.Add($"this.NodeLifecycle = {(this.NodeLifecycle == null ? "null" : this.NodeLifecycle == string.Empty ? "" : this.NodeLifecycle)}");
            toStringOutput.Add($"this.NodeKubernetesIoInstanceType = {(this.NodeKubernetesIoInstanceType == null ? "null" : this.NodeKubernetesIoInstanceType == string.Empty ? "" : this.NodeKubernetesIoInstanceType)}");
            toStringOutput.Add($"this.TopologyKubernetesIoRegion = {(this.TopologyKubernetesIoRegion == null ? "null" : this.TopologyKubernetesIoRegion == string.Empty ? "" : this.TopologyKubernetesIoRegion)}");
            toStringOutput.Add($"this.TopologyKubernetesIoZone = {(this.TopologyKubernetesIoZone == null ? "null" : this.TopologyKubernetesIoZone == string.Empty ? "" : this.TopologyKubernetesIoZone)}");
        }
    }
}