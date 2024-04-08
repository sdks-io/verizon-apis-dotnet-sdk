// <copyright file="DeviceUsageListResult.cs" company="APIMatic">
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
    /// DeviceUsageListResult.
    /// </summary>
    public class DeviceUsageListResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceUsageListResult"/> class.
        /// </summary>
        public DeviceUsageListResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceUsageListResult"/> class.
        /// </summary>
        /// <param name="hasMoreData">hasMoreData.</param>
        /// <param name="usageHistory">usageHistory.</param>
        public DeviceUsageListResult(
            bool? hasMoreData = null,
            List<Models.Usage> usageHistory = null)
        {
            this.HasMoreData = hasMoreData;
            this.UsageHistory = usageHistory;
        }

        /// <summary>
        /// False for a status 200 response.True for a status 202 response, indicating that there is more data to be retrieved.
        /// </summary>
        [JsonProperty("hasMoreData", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasMoreData { get; set; }

        /// <summary>
        /// Placeholder.
        /// </summary>
        [JsonProperty("usageHistory", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Usage> UsageHistory { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeviceUsageListResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is DeviceUsageListResult other &&                ((this.HasMoreData == null && other.HasMoreData == null) || (this.HasMoreData?.Equals(other.HasMoreData) == true)) &&
                ((this.UsageHistory == null && other.UsageHistory == null) || (this.UsageHistory?.Equals(other.UsageHistory) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.HasMoreData = {(this.HasMoreData == null ? "null" : this.HasMoreData.ToString())}");
            toStringOutput.Add($"this.UsageHistory = {(this.UsageHistory == null ? "null" : $"[{string.Join(", ", this.UsageHistory)} ]")}");
        }
    }
}