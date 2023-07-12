// <copyright file="ClusterConfiguration.cs" company="APIMatic">
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
    /// ClusterConfiguration.
    /// </summary>
    public class ClusterConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterConfiguration"/> class.
        /// </summary>
        public ClusterConfiguration()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterConfiguration"/> class.
        /// </summary>
        /// <param name="tags">tags.</param>
        /// <param name="endPointAccessType">endPointAccessType.</param>
        /// <param name="autoCreateNetworkInfra">autoCreateNetworkInfra.</param>
        /// <param name="infraIPv4range">infraIPv4range.</param>
        /// <param name="networkNatMode">networkNatMode.</param>
        /// <param name="availabilityZones">availabilityZones.</param>
        /// <param name="privateNetworkInfraIds">privateNetworkInfraIds.</param>
        /// <param name="publicNetworkInfraIds">publicNetworkInfraIds.</param>
        public ClusterConfiguration(
            Models.EdgeServiceLaunchParams tags = null,
            Models.ClusterConfigEndpointAccessTypeEnum? endPointAccessType = Models.ClusterConfigEndpointAccessTypeEnum.PrivateAccess,
            bool? autoCreateNetworkInfra = true,
            string infraIPv4range = "192.168.0.0/16",
            Models.NetworkNatModeEnum? networkNatMode = Models.NetworkNatModeEnum.Single,
            List<Models.IdList> availabilityZones = null,
            List<Models.IdList> privateNetworkInfraIds = null,
            List<Models.IdList> publicNetworkInfraIds = null)
        {
            this.Tags = tags;
            this.EndPointAccessType = endPointAccessType;
            this.AutoCreateNetworkInfra = autoCreateNetworkInfra;
            this.InfraIPv4range = infraIPv4range;
            this.NetworkNatMode = networkNatMode;
            this.AvailabilityZones = availabilityZones;
            this.PrivateNetworkInfraIds = privateNetworkInfraIds;
            this.PublicNetworkInfraIds = publicNetworkInfraIds;
        }

        /// <summary>
        /// Gets or sets Tags.
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public Models.EdgeServiceLaunchParams Tags { get; set; }

        /// <summary>
        /// Gets or sets EndPointAccessType.
        /// </summary>
        [JsonProperty("endPointAccessType", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.ClusterConfigEndpointAccessTypeEnum? EndPointAccessType { get; set; }

        /// <summary>
        /// Gets or sets AutoCreateNetworkInfra.
        /// </summary>
        [JsonProperty("autoCreateNetworkInfra", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoCreateNetworkInfra { get; set; }

        /// <summary>
        /// Gets or sets InfraIPv4range.
        /// </summary>
        [JsonProperty("infraIPv4range", NullValueHandling = NullValueHandling.Ignore)]
        public string InfraIPv4range { get; set; }

        /// <summary>
        /// Gets or sets NetworkNatMode.
        /// </summary>
        [JsonProperty("networkNatMode", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.NetworkNatModeEnum? NetworkNatMode { get; set; }

        /// <summary>
        /// Gets or sets AvailabilityZones.
        /// </summary>
        [JsonProperty("availabilityZones", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.IdList> AvailabilityZones { get; set; }

        /// <summary>
        /// Gets or sets PrivateNetworkInfraIds.
        /// </summary>
        [JsonProperty("privateNetworkInfraIds", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.IdList> PrivateNetworkInfraIds { get; set; }

        /// <summary>
        /// Gets or sets PublicNetworkInfraIds.
        /// </summary>
        [JsonProperty("publicNetworkInfraIds", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.IdList> PublicNetworkInfraIds { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ClusterConfiguration : ({string.Join(", ", toStringOutput)})";
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
            return obj is ClusterConfiguration other &&                ((this.Tags == null && other.Tags == null) || (this.Tags?.Equals(other.Tags) == true)) &&
                ((this.EndPointAccessType == null && other.EndPointAccessType == null) || (this.EndPointAccessType?.Equals(other.EndPointAccessType) == true)) &&
                ((this.AutoCreateNetworkInfra == null && other.AutoCreateNetworkInfra == null) || (this.AutoCreateNetworkInfra?.Equals(other.AutoCreateNetworkInfra) == true)) &&
                ((this.InfraIPv4range == null && other.InfraIPv4range == null) || (this.InfraIPv4range?.Equals(other.InfraIPv4range) == true)) &&
                ((this.NetworkNatMode == null && other.NetworkNatMode == null) || (this.NetworkNatMode?.Equals(other.NetworkNatMode) == true)) &&
                ((this.AvailabilityZones == null && other.AvailabilityZones == null) || (this.AvailabilityZones?.Equals(other.AvailabilityZones) == true)) &&
                ((this.PrivateNetworkInfraIds == null && other.PrivateNetworkInfraIds == null) || (this.PrivateNetworkInfraIds?.Equals(other.PrivateNetworkInfraIds) == true)) &&
                ((this.PublicNetworkInfraIds == null && other.PublicNetworkInfraIds == null) || (this.PublicNetworkInfraIds?.Equals(other.PublicNetworkInfraIds) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Tags = {(this.Tags == null ? "null" : this.Tags.ToString())}");
            toStringOutput.Add($"this.EndPointAccessType = {(this.EndPointAccessType == null ? "null" : this.EndPointAccessType.ToString())}");
            toStringOutput.Add($"this.AutoCreateNetworkInfra = {(this.AutoCreateNetworkInfra == null ? "null" : this.AutoCreateNetworkInfra.ToString())}");
            toStringOutput.Add($"this.InfraIPv4range = {(this.InfraIPv4range == null ? "null" : this.InfraIPv4range == string.Empty ? "" : this.InfraIPv4range)}");
            toStringOutput.Add($"this.NetworkNatMode = {(this.NetworkNatMode == null ? "null" : this.NetworkNatMode.ToString())}");
            toStringOutput.Add($"this.AvailabilityZones = {(this.AvailabilityZones == null ? "null" : $"[{string.Join(", ", this.AvailabilityZones)} ]")}");
            toStringOutput.Add($"this.PrivateNetworkInfraIds = {(this.PrivateNetworkInfraIds == null ? "null" : $"[{string.Join(", ", this.PrivateNetworkInfraIds)} ]")}");
            toStringOutput.Add($"this.PublicNetworkInfraIds = {(this.PublicNetworkInfraIds == null ? "null" : $"[{string.Join(", ", this.PublicNetworkInfraIds)} ]")}");
        }
    }
}