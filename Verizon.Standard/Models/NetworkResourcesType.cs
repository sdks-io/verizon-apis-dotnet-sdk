// <copyright file="NetworkResourcesType.cs" company="APIMatic">
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
    using APIMatic.Core.Utilities.Converters;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Verizon.Standard;
    using Verizon.Standard.Utilities;

    /// <summary>
    /// NetworkResourcesType.
    /// </summary>
    public class NetworkResourcesType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkResourcesType"/> class.
        /// </summary>
        public NetworkResourcesType()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkResourcesType"/> class.
        /// </summary>
        /// <param name="maxLatencyMs">maxLatencyMs.</param>
        /// <param name="minBandwidthKbits">minBandwidthKbits.</param>
        /// <param name="serviceContinuitySupport">serviceContinuitySupport.</param>
        /// <param name="maxRequestRate">maxRequestRate.</param>
        /// <param name="minAvailability">minAvailability.</param>
        public NetworkResourcesType(
            int maxLatencyMs,
            int? minBandwidthKbits = null,
            bool? serviceContinuitySupport = null,
            int? maxRequestRate = null,
            int? minAvailability = null)
        {
            this.MinBandwidthKbits = minBandwidthKbits;
            this.ServiceContinuitySupport = serviceContinuitySupport;
            this.MaxRequestRate = maxRequestRate;
            this.MaxLatencyMs = maxLatencyMs;
            this.MinAvailability = minAvailability;
        }

        /// <summary>
        /// Minimum required connection bandwidth in Kbit/s for the application.
        /// </summary>
        [JsonProperty("minBandwidthKbits", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinBandwidthKbits { get; set; }

        /// <summary>
        /// Indicates if service continuity support is required or not for the application.
        /// </summary>
        [JsonProperty("serviceContinuitySupport", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ServiceContinuitySupport { get; set; }

        /// <summary>
        /// Maximum request rate that the application can handle.
        /// </summary>
        [JsonProperty("maxRequestRate", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxRequestRate { get; set; }

        /// <summary>
        /// Maximum response time or latency that the application can handle, in milliseconds. Note: this value must be in multiples of 5.
        /// </summary>
        [JsonProperty("maxLatencyMs")]
        public int MaxLatencyMs { get; set; }

        /// <summary>
        /// Minimum availability required for the server.
        /// </summary>
        [JsonProperty("minAvailability", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinAvailability { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"NetworkResourcesType : ({string.Join(", ", toStringOutput)})";
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
            return obj is NetworkResourcesType other &&                ((this.MinBandwidthKbits == null && other.MinBandwidthKbits == null) || (this.MinBandwidthKbits?.Equals(other.MinBandwidthKbits) == true)) &&
                ((this.ServiceContinuitySupport == null && other.ServiceContinuitySupport == null) || (this.ServiceContinuitySupport?.Equals(other.ServiceContinuitySupport) == true)) &&
                ((this.MaxRequestRate == null && other.MaxRequestRate == null) || (this.MaxRequestRate?.Equals(other.MaxRequestRate) == true)) &&
                this.MaxLatencyMs.Equals(other.MaxLatencyMs) &&
                ((this.MinAvailability == null && other.MinAvailability == null) || (this.MinAvailability?.Equals(other.MinAvailability) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MinBandwidthKbits = {(this.MinBandwidthKbits == null ? "null" : this.MinBandwidthKbits.ToString())}");
            toStringOutput.Add($"this.ServiceContinuitySupport = {(this.ServiceContinuitySupport == null ? "null" : this.ServiceContinuitySupport.ToString())}");
            toStringOutput.Add($"this.MaxRequestRate = {(this.MaxRequestRate == null ? "null" : this.MaxRequestRate.ToString())}");
            toStringOutput.Add($"this.MaxLatencyMs = {this.MaxLatencyMs}");
            toStringOutput.Add($"this.MinAvailability = {(this.MinAvailability == null ? "null" : this.MinAvailability.ToString())}");
        }
    }
}