// <copyright file="DeviceProvisioningHistoryListResult.cs" company="APIMatic">
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
    /// DeviceProvisioningHistoryListResult.
    /// </summary>
    public class DeviceProvisioningHistoryListResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceProvisioningHistoryListResult"/> class.
        /// </summary>
        public DeviceProvisioningHistoryListResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceProvisioningHistoryListResult"/> class.
        /// </summary>
        /// <param name="hasMoreData">hasMoreData.</param>
        /// <param name="provisioningHistory">provisioningHistory.</param>
        public DeviceProvisioningHistoryListResult(
            bool? hasMoreData = null,
            List<Models.ProvisioningHistory> provisioningHistory = null)
        {
            this.HasMoreData = hasMoreData;
            this.ProvisioningHistory = provisioningHistory;
        }

        /// <summary>
        /// False for a status 200 response.True for a status 202 response, indicating that there is more data to be retrieved.
        /// </summary>
        [JsonProperty("hasMoreData", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasMoreData { get; set; }

        /// <summary>
        /// The provisioning history of a specified device during a specified time period.
        /// </summary>
        [JsonProperty("provisioningHistory", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ProvisioningHistory> ProvisioningHistory { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeviceProvisioningHistoryListResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is DeviceProvisioningHistoryListResult other &&                ((this.HasMoreData == null && other.HasMoreData == null) || (this.HasMoreData?.Equals(other.HasMoreData) == true)) &&
                ((this.ProvisioningHistory == null && other.ProvisioningHistory == null) || (this.ProvisioningHistory?.Equals(other.ProvisioningHistory) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.HasMoreData = {(this.HasMoreData == null ? "null" : this.HasMoreData.ToString())}");
            toStringOutput.Add($"this.ProvisioningHistory = {(this.ProvisioningHistory == null ? "null" : $"[{string.Join(", ", this.ProvisioningHistory)} ]")}");
        }
    }
}