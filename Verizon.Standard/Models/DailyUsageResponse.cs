// <copyright file="DailyUsageResponse.cs" company="APIMatic">
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
    /// DailyUsageResponse.
    /// </summary>
    public class DailyUsageResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DailyUsageResponse"/> class.
        /// </summary>
        public DailyUsageResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DailyUsageResponse"/> class.
        /// </summary>
        /// <param name="hasMoreData">hasMoreData.</param>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="usageHistory">usageHistory.</param>
        public DailyUsageResponse(
            bool? hasMoreData = null,
            Models.GIODeviceId deviceId = null,
            List<Models.DailyUsageHistory> usageHistory = null)
        {
            this.HasMoreData = hasMoreData;
            this.DeviceId = deviceId;
            this.UsageHistory = usageHistory;
        }

        /// <summary>
        /// A flag set to indicate if there is more than one page of data returned by the query (true) or if only one page of data returned (false)
        /// </summary>
        [JsonProperty("hasMoreData", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasMoreData { get; set; }

        /// <summary>
        /// Gets or sets DeviceId.
        /// </summary>
        [JsonProperty("deviceId", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GIODeviceId DeviceId { get; set; }

        /// <summary>
        /// Gets or sets UsageHistory.
        /// </summary>
        [JsonProperty("usageHistory", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DailyUsageHistory> UsageHistory { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DailyUsageResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DailyUsageResponse other &&
                (this.HasMoreData == null && other.HasMoreData == null ||
                 this.HasMoreData?.Equals(other.HasMoreData) == true) &&
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
            toStringOutput.Add($"HasMoreData = {(this.HasMoreData == null ? "null" : this.HasMoreData.ToString())}");
            toStringOutput.Add($"DeviceId = {(this.DeviceId == null ? "null" : this.DeviceId.ToString())}");
            toStringOutput.Add($"UsageHistory = {(this.UsageHistory == null ? "null" : $"[{string.Join(", ", this.UsageHistory)} ]")}");
        }
    }
}