// <copyright file="DevicesConsentResult.cs" company="APIMatic">
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
    /// DevicesConsentResult.
    /// </summary>
    public class DevicesConsentResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DevicesConsentResult"/> class.
        /// </summary>
        public DevicesConsentResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DevicesConsentResult"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="allDevice">allDevice.</param>
        /// <param name="hasMoreData">hasMoreData.</param>
        /// <param name="totalCount">totalCount.</param>
        /// <param name="updateTime">updateTime.</param>
        /// <param name="exclusion">exclusion.</param>
        public DevicesConsentResult(
            string accountName = null,
            bool? allDevice = null,
            bool? hasMoreData = null,
            int? totalCount = null,
            string updateTime = null,
            List<string> exclusion = null)
        {
            this.AccountName = accountName;
            this.AllDevice = allDevice;
            this.HasMoreData = hasMoreData;
            this.TotalCount = totalCount;
            this.UpdateTime = updateTime;
            this.Exclusion = exclusion;
        }

        /// <summary>
        /// Account identifier in "##########-#####".
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// Exclude all devices or not?
        /// </summary>
        [JsonProperty("allDevice", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllDevice { get; set; }

        /// <summary>
        /// Are there more devices to retrieve or not?
        /// </summary>
        [JsonProperty("hasMoreData", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasMoreData { get; set; }

        /// <summary>
        /// Total number of excluded devices in the account.
        /// </summary>
        [JsonProperty("totalCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Last update time.
        /// </summary>
        [JsonProperty("updateTime", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// Device ID list.
        /// </summary>
        [JsonProperty("exclusion", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Exclusion { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DevicesConsentResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is DevicesConsentResult other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.AllDevice == null && other.AllDevice == null) || (this.AllDevice?.Equals(other.AllDevice) == true)) &&
                ((this.HasMoreData == null && other.HasMoreData == null) || (this.HasMoreData?.Equals(other.HasMoreData) == true)) &&
                ((this.TotalCount == null && other.TotalCount == null) || (this.TotalCount?.Equals(other.TotalCount) == true)) &&
                ((this.UpdateTime == null && other.UpdateTime == null) || (this.UpdateTime?.Equals(other.UpdateTime) == true)) &&
                ((this.Exclusion == null && other.Exclusion == null) || (this.Exclusion?.Equals(other.Exclusion) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName == string.Empty ? "" : this.AccountName)}");
            toStringOutput.Add($"this.AllDevice = {(this.AllDevice == null ? "null" : this.AllDevice.ToString())}");
            toStringOutput.Add($"this.HasMoreData = {(this.HasMoreData == null ? "null" : this.HasMoreData.ToString())}");
            toStringOutput.Add($"this.TotalCount = {(this.TotalCount == null ? "null" : this.TotalCount.ToString())}");
            toStringOutput.Add($"this.UpdateTime = {(this.UpdateTime == null ? "null" : this.UpdateTime == string.Empty ? "" : this.UpdateTime)}");
            toStringOutput.Add($"this.Exclusion = {(this.Exclusion == null ? "null" : $"[{string.Join(", ", this.Exclusion)} ]")}");
        }
    }
}