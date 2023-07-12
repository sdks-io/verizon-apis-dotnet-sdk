// <copyright file="DeviceUsageListRequest.cs" company="APIMatic">
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
    /// DeviceUsageListRequest.
    /// </summary>
    public class DeviceUsageListRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceUsageListRequest"/> class.
        /// </summary>
        public DeviceUsageListRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceUsageListRequest"/> class.
        /// </summary>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="earliest">earliest.</param>
        /// <param name="latest">latest.</param>
        public DeviceUsageListRequest(
            Models.DeviceId deviceId = null,
            string earliest = null,
            string latest = null)
        {
            this.DeviceId = deviceId;
            this.Earliest = earliest;
            this.Latest = latest;
        }

        /// <summary>
        /// An identifier for a single device.
        /// </summary>
        [JsonProperty("deviceId", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DeviceId DeviceId { get; set; }

        /// <summary>
        /// The earliest date for which you want usage data.
        /// </summary>
        [JsonProperty("earliest", NullValueHandling = NullValueHandling.Ignore)]
        public string Earliest { get; set; }

        /// <summary>
        /// The last date for which you want usage data.
        /// </summary>
        [JsonProperty("latest", NullValueHandling = NullValueHandling.Ignore)]
        public string Latest { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeviceUsageListRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is DeviceUsageListRequest other &&                ((this.DeviceId == null && other.DeviceId == null) || (this.DeviceId?.Equals(other.DeviceId) == true)) &&
                ((this.Earliest == null && other.Earliest == null) || (this.Earliest?.Equals(other.Earliest) == true)) &&
                ((this.Latest == null && other.Latest == null) || (this.Latest?.Equals(other.Latest) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DeviceId = {(this.DeviceId == null ? "null" : this.DeviceId.ToString())}");
            toStringOutput.Add($"this.Earliest = {(this.Earliest == null ? "null" : this.Earliest == string.Empty ? "" : this.Earliest)}");
            toStringOutput.Add($"this.Latest = {(this.Latest == null ? "null" : this.Latest == string.Empty ? "" : this.Latest)}");
        }
    }
}