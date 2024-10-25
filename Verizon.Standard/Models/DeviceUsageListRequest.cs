// <copyright file="DeviceUsageListRequest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
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

namespace Verizon.Standard.Models
{
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
        /// <param name="earliest">earliest.</param>
        /// <param name="latest">latest.</param>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="label">label.</param>
        public DeviceUsageListRequest(
            string earliest,
            string latest,
            Models.DeviceId deviceId = null,
            Models.Label label = null)
        {
            this.Earliest = earliest;
            this.Latest = latest;
            this.DeviceId = deviceId;
            this.Label = label;
        }

        /// <summary>
        /// The earliest date for which you want usage data.
        /// </summary>
        [JsonProperty("earliest")]
        public string Earliest { get; set; }

        /// <summary>
        /// The last date for which you want usage data.
        /// </summary>
        [JsonProperty("latest")]
        public string Latest { get; set; }

        /// <summary>
        /// An identifier for a single device.
        /// </summary>
        [JsonProperty("deviceId", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DeviceId DeviceId { get; set; }

        /// <summary>
        /// Gets or sets Label.
        /// </summary>
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Label Label { get; set; }

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
            return obj is DeviceUsageListRequest other &&                ((this.Earliest == null && other.Earliest == null) || (this.Earliest?.Equals(other.Earliest) == true)) &&
                ((this.Latest == null && other.Latest == null) || (this.Latest?.Equals(other.Latest) == true)) &&
                ((this.DeviceId == null && other.DeviceId == null) || (this.DeviceId?.Equals(other.DeviceId) == true)) &&
                ((this.Label == null && other.Label == null) || (this.Label?.Equals(other.Label) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Earliest = {(this.Earliest == null ? "null" : this.Earliest)}");
            toStringOutput.Add($"this.Latest = {(this.Latest == null ? "null" : this.Latest)}");
            toStringOutput.Add($"this.DeviceId = {(this.DeviceId == null ? "null" : this.DeviceId.ToString())}");
            toStringOutput.Add($"this.Label = {(this.Label == null ? "null" : this.Label.ToString())}");
        }
    }
}