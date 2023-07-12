// <copyright file="V1LicensesAssignedRemovedResult.cs" company="APIMatic">
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
    /// V1LicensesAssignedRemovedResult.
    /// </summary>
    public class V1LicensesAssignedRemovedResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1LicensesAssignedRemovedResult"/> class.
        /// </summary>
        public V1LicensesAssignedRemovedResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1LicensesAssignedRemovedResult"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="licCount">licCount.</param>
        /// <param name="licUsedCount">licUsedCount.</param>
        /// <param name="deviceList">deviceList.</param>
        public V1LicensesAssignedRemovedResult(
            string accountName = null,
            int? licCount = null,
            int? licUsedCount = null,
            List<Models.V1DeviceListItem> deviceList = null)
        {
            this.AccountName = accountName;
            this.LicCount = licCount;
            this.LicUsedCount = licUsedCount;
            this.DeviceList = deviceList;
        }

        /// <summary>
        /// Account identifier in "##########-#####".
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// Total number of monthly licenses in an MRC subscription.
        /// </summary>
        [JsonProperty("licCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? LicCount { get; set; }

        /// <summary>
        /// Number of licenses assigned to devices after the request completed.
        /// </summary>
        [JsonProperty("licUsedCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? LicUsedCount { get; set; }

        /// <summary>
        /// A JSON object for each device that was in the request.
        /// </summary>
        [JsonProperty("deviceList", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.V1DeviceListItem> DeviceList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1LicensesAssignedRemovedResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1LicensesAssignedRemovedResult other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.LicCount == null && other.LicCount == null) || (this.LicCount?.Equals(other.LicCount) == true)) &&
                ((this.LicUsedCount == null && other.LicUsedCount == null) || (this.LicUsedCount?.Equals(other.LicUsedCount) == true)) &&
                ((this.DeviceList == null && other.DeviceList == null) || (this.DeviceList?.Equals(other.DeviceList) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName == string.Empty ? "" : this.AccountName)}");
            toStringOutput.Add($"this.LicCount = {(this.LicCount == null ? "null" : this.LicCount.ToString())}");
            toStringOutput.Add($"this.LicUsedCount = {(this.LicUsedCount == null ? "null" : this.LicUsedCount.ToString())}");
            toStringOutput.Add($"this.DeviceList = {(this.DeviceList == null ? "null" : $"[{string.Join(", ", this.DeviceList)} ]")}");
        }
    }
}