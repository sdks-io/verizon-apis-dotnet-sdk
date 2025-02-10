// <copyright file="ProvhistoryRequest.cs" company="APIMatic">
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
    /// ProvhistoryRequest.
    /// </summary>
    public class ProvhistoryRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProvhistoryRequest"/> class.
        /// </summary>
        public ProvhistoryRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProvhistoryRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="deviceFilter">deviceFilter.</param>
        /// <param name="earliest">earliest.</param>
        /// <param name="latest">latest.</param>
        public ProvhistoryRequest(
            string accountName = null,
            List<Models.GIODeviceId> deviceFilter = null,
            DateTime? earliest = null,
            DateTime? latest = null)
        {
            this.AccountName = accountName;
            this.DeviceFilter = deviceFilter;
            this.Earliest = earliest;
            this.Latest = latest;
        }

        /// <summary>
        /// Gets or sets AccountName.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets DeviceFilter.
        /// </summary>
        [JsonProperty("deviceFilter", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.GIODeviceId> DeviceFilter { get; set; }

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
            return $"ProvhistoryRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ProvhistoryRequest other &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.DeviceFilter == null && other.DeviceFilter == null ||
                 this.DeviceFilter?.Equals(other.DeviceFilter) == true) &&
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
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
            toStringOutput.Add($"DeviceFilter = {(this.DeviceFilter == null ? "null" : $"[{string.Join(", ", this.DeviceFilter)} ]")}");
            toStringOutput.Add($"Earliest = {(this.Earliest == null ? "null" : this.Earliest.ToString())}");
            toStringOutput.Add($"Latest = {(this.Latest == null ? "null" : this.Latest.ToString())}");
        }
    }
}