// <copyright file="DataCenter.cs" company="APIMatic">
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
    /// DataCenter.
    /// </summary>
    public class DataCenter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataCenter"/> class.
        /// </summary>
        public DataCenter()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataCenter"/> class.
        /// </summary>
        /// <param name="packageType">packageType.</param>
        /// <param name="distribution">distribution.</param>
        /// <param name="location">location.</param>
        /// <param name="k8sVersion">k8sVersion.</param>
        /// <param name="operatingSystem">operatingSystem.</param>
        /// <param name="tags">tags.</param>
        public DataCenter(
            Models.DataCenterPackageTypeEnum? packageType = null,
            Models.DataCenterDistributionEnum? distribution = null,
            string location = null,
            Models.K8sVersionEnum? k8sVersion = Models.K8sVersionEnum.Enum118,
            string operatingSystem = null,
            List<Models.EdgeServiceLaunchParams> tags = null)
        {
            this.PackageType = packageType;
            this.Distribution = distribution;
            this.Location = location;
            this.K8sVersion = k8sVersion;
            this.OperatingSystem = operatingSystem;
            this.Tags = tags;
        }

        /// <summary>
        /// Packages are optimized for various operating environments. Prepackaged images are available in OVA and QCOW formats.
        /// </summary>
        [JsonProperty("packageType", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.DataCenterPackageTypeEnum? PackageType { get; set; }

        /// <summary>
        /// Supported Kubernetes distribution for the selected cloud provider.
        /// </summary>
        [JsonProperty("distribution", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.DataCenterDistributionEnum? Distribution { get; set; }

        /// <summary>
        /// Indicate geo-location of cluster if you wish to use location based policies.
        /// </summary>
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public string Location { get; set; }

        /// <summary>
        /// Version of K8s platform.
        /// </summary>
        [JsonProperty("k8sVersion", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.K8sVersionEnum? K8sVersion { get; set; }

        /// <summary>
        /// Operating System for the master and worker nodes.
        /// </summary>
        [JsonProperty("operatingSystem", NullValueHandling = NullValueHandling.Ignore)]
        public string OperatingSystem { get; set; }

        /// <summary>
        /// Gets or sets Tags.
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.EdgeServiceLaunchParams> Tags { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DataCenter : ({string.Join(", ", toStringOutput)})";
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
            return obj is DataCenter other &&                ((this.PackageType == null && other.PackageType == null) || (this.PackageType?.Equals(other.PackageType) == true)) &&
                ((this.Distribution == null && other.Distribution == null) || (this.Distribution?.Equals(other.Distribution) == true)) &&
                ((this.Location == null && other.Location == null) || (this.Location?.Equals(other.Location) == true)) &&
                ((this.K8sVersion == null && other.K8sVersion == null) || (this.K8sVersion?.Equals(other.K8sVersion) == true)) &&
                ((this.OperatingSystem == null && other.OperatingSystem == null) || (this.OperatingSystem?.Equals(other.OperatingSystem) == true)) &&
                ((this.Tags == null && other.Tags == null) || (this.Tags?.Equals(other.Tags) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PackageType = {(this.PackageType == null ? "null" : this.PackageType.ToString())}");
            toStringOutput.Add($"this.Distribution = {(this.Distribution == null ? "null" : this.Distribution.ToString())}");
            toStringOutput.Add($"this.Location = {(this.Location == null ? "null" : this.Location == string.Empty ? "" : this.Location)}");
            toStringOutput.Add($"this.K8sVersion = {(this.K8sVersion == null ? "null" : this.K8sVersion.ToString())}");
            toStringOutput.Add($"this.OperatingSystem = {(this.OperatingSystem == null ? "null" : this.OperatingSystem == string.Empty ? "" : this.OperatingSystem)}");
            toStringOutput.Add($"this.Tags = {(this.Tags == null ? "null" : $"[{string.Join(", ", this.Tags)} ]")}");
        }
    }
}