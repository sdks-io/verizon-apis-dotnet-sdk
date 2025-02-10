// <copyright file="ResponseToUsageQuery.cs" company="APIMatic">
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
    /// ResponseToUsageQuery.
    /// </summary>
    public class ResponseToUsageQuery
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseToUsageQuery"/> class.
        /// </summary>
        public ResponseToUsageQuery()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseToUsageQuery"/> class.
        /// </summary>
        /// <param name="hasmoredata">hasmoredata.</param>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="usageHistory">usageHistory.</param>
        public ResponseToUsageQuery(
            bool? hasmoredata = null,
            Models.ReadySimDeviceId deviceId = null,
            List<Models.UsageHistory> usageHistory = null)
        {
            this.Hasmoredata = hasmoredata;
            this.DeviceId = deviceId;
            this.UsageHistory = usageHistory;
        }

        /// <summary>
        /// Gets or sets Hasmoredata.
        /// </summary>
        [JsonProperty("hasmoredata", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hasmoredata { get; set; }

        /// <summary>
        /// Gets or sets DeviceId.
        /// </summary>
        [JsonProperty("deviceId", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ReadySimDeviceId DeviceId { get; set; }

        /// <summary>
        /// Gets or sets UsageHistory.
        /// </summary>
        [JsonProperty("usageHistory", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.UsageHistory> UsageHistory { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ResponseToUsageQuery : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ResponseToUsageQuery other &&
                (this.Hasmoredata == null && other.Hasmoredata == null ||
                 this.Hasmoredata?.Equals(other.Hasmoredata) == true) &&
                (this.DeviceId == null && other.DeviceId == null ||
                 this.DeviceId?.Equals(other.DeviceId) == true) &&
                (this.UsageHistory == null && other.UsageHistory == null ||
                 this.UsageHistory?.Equals(other.UsageHistory) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Hasmoredata = {(this.Hasmoredata == null ? "null" : this.Hasmoredata.ToString())}");
            toStringOutput.Add($"DeviceId = {(this.DeviceId == null ? "null" : this.DeviceId.ToString())}");
            toStringOutput.Add($"UsageHistory = {(this.UsageHistory == null ? "null" : $"[{string.Join(", ", this.UsageHistory)} ]")}");
        }
    }
}