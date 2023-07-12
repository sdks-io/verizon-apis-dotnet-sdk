// <copyright file="AccountLicenseInfo.cs" company="APIMatic">
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
    /// AccountLicenseInfo.
    /// </summary>
    public class AccountLicenseInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountLicenseInfo"/> class.
        /// </summary>
        public AccountLicenseInfo()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountLicenseInfo"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="totalLicenses">totalLicenses.</param>
        /// <param name="assignedLicenses">assignedLicenses.</param>
        /// <param name="hasMoreData">hasMoreData.</param>
        /// <param name="lastSeenDeviceId">lastSeenDeviceId.</param>
        /// <param name="deviceList">deviceList.</param>
        public AccountLicenseInfo(
            string accountName = null,
            int? totalLicenses = null,
            int? assignedLicenses = null,
            bool? hasMoreData = null,
            int? lastSeenDeviceId = null,
            List<Models.AccountLicenseDeviceListItem> deviceList = null)
        {
            this.AccountName = accountName;
            this.TotalLicenses = totalLicenses;
            this.AssignedLicenses = assignedLicenses;
            this.HasMoreData = hasMoreData;
            this.LastSeenDeviceId = lastSeenDeviceId;
            this.DeviceList = deviceList;
        }

        /// <summary>
        /// Account identifier in "##########-#####".
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// Number of monthly licenses in an MRC subscription.
        /// </summary>
        [JsonProperty("totalLicenses", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalLicenses { get; set; }

        /// <summary>
        /// Number of licenses currently assigned to devices.
        /// </summary>
        [JsonProperty("assignedLicenses", NullValueHandling = NullValueHandling.Ignore)]
        public int? AssignedLicenses { get; set; }

        /// <summary>
        /// True if there are more devices to retrieve.
        /// </summary>
        [JsonProperty("hasMoreData", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasMoreData { get; set; }

        /// <summary>
        /// If hasMoreData=true, the startIndex to use for the next request. 0 if hasMoreData=false.
        /// </summary>
        [JsonProperty("lastSeenDeviceId", NullValueHandling = NullValueHandling.Ignore)]
        public int? LastSeenDeviceId { get; set; }

        /// <summary>
        /// The list of devices that have licenses assigned, including the date and time of when each license was assigned.
        /// </summary>
        [JsonProperty("deviceList", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.AccountLicenseDeviceListItem> DeviceList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AccountLicenseInfo : ({string.Join(", ", toStringOutput)})";
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
            return obj is AccountLicenseInfo other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.TotalLicenses == null && other.TotalLicenses == null) || (this.TotalLicenses?.Equals(other.TotalLicenses) == true)) &&
                ((this.AssignedLicenses == null && other.AssignedLicenses == null) || (this.AssignedLicenses?.Equals(other.AssignedLicenses) == true)) &&
                ((this.HasMoreData == null && other.HasMoreData == null) || (this.HasMoreData?.Equals(other.HasMoreData) == true)) &&
                ((this.LastSeenDeviceId == null && other.LastSeenDeviceId == null) || (this.LastSeenDeviceId?.Equals(other.LastSeenDeviceId) == true)) &&
                ((this.DeviceList == null && other.DeviceList == null) || (this.DeviceList?.Equals(other.DeviceList) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName == string.Empty ? "" : this.AccountName)}");
            toStringOutput.Add($"this.TotalLicenses = {(this.TotalLicenses == null ? "null" : this.TotalLicenses.ToString())}");
            toStringOutput.Add($"this.AssignedLicenses = {(this.AssignedLicenses == null ? "null" : this.AssignedLicenses.ToString())}");
            toStringOutput.Add($"this.HasMoreData = {(this.HasMoreData == null ? "null" : this.HasMoreData.ToString())}");
            toStringOutput.Add($"this.LastSeenDeviceId = {(this.LastSeenDeviceId == null ? "null" : this.LastSeenDeviceId.ToString())}");
            toStringOutput.Add($"this.DeviceList = {(this.DeviceList == null ? "null" : $"[{string.Join(", ", this.DeviceList)} ]")}");
        }
    }
}