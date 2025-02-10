// <copyright file="SMSEventHistoryRequest.cs" company="APIMatic">
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
    /// SMSEventHistoryRequest.
    /// </summary>
    public class SMSEventHistoryRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SMSEventHistoryRequest"/> class.
        /// </summary>
        public SMSEventHistoryRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SMSEventHistoryRequest"/> class.
        /// </summary>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="earliest">earliest.</param>
        /// <param name="latest">latest.</param>
        public SMSEventHistoryRequest(
            Models.GIODeviceId deviceId,
            DateTime? earliest = null,
            DateTime? latest = null)
        {
            this.DeviceId = deviceId;
            this.Earliest = earliest;
            this.Latest = latest;
        }

        /// <summary>
        /// Gets or sets DeviceId.
        /// </summary>
        [JsonProperty("deviceId")]
        public Models.GIODeviceId DeviceId { get; set; }

        /// <summary>
        /// Gets or sets Earliest.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("earliest", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Earliest { get; set; }

        /// <summary>
        /// Gets or sets Latest.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("latest", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Latest { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SMSEventHistoryRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SMSEventHistoryRequest other &&
                (this.DeviceId == null && other.DeviceId == null ||
                 this.DeviceId?.Equals(other.DeviceId) == true) &&
                (this.Earliest == null && other.Earliest == null ||
                 this.Earliest?.Equals(other.Earliest) == true) &&
                (this.Latest == null && other.Latest == null ||
                 this.Latest?.Equals(other.Latest) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"DeviceId = {(this.DeviceId == null ? "null" : this.DeviceId.ToString())}");
            toStringOutput.Add($"Earliest = {(this.Earliest == null ? "null" : this.Earliest.ToString())}");
            toStringOutput.Add($"Latest = {(this.Latest == null ? "null" : this.Latest.ToString())}");
        }
    }
}