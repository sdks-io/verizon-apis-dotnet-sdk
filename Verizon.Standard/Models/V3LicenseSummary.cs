// <copyright file="V3LicenseSummary.cs" company="APIMatic">
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
    /// V3LicenseSummary.
    /// </summary>
    public class V3LicenseSummary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V3LicenseSummary"/> class.
        /// </summary>
        public V3LicenseSummary()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V3LicenseSummary"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="assignedLicenses">assignedLicenses.</param>
        /// <param name="hasMoreData">hasMoreData.</param>
        /// <param name="maxPageSize">maxPageSize.</param>
        /// <param name="totalLicenses">totalLicenses.</param>
        /// <param name="lastSeenDeviceId">lastSeenDeviceId.</param>
        /// <param name="deviceList">deviceList.</param>
        public V3LicenseSummary(
            string accountName,
            int assignedLicenses,
            bool hasMoreData,
            int maxPageSize,
            int? totalLicenses = null,
            string lastSeenDeviceId = null,
            List<Models.V3LicenseDevice> deviceList = null)
        {
            this.AccountName = accountName;
            this.TotalLicenses = totalLicenses;
            this.AssignedLicenses = assignedLicenses;
            this.HasMoreData = hasMoreData;
            this.LastSeenDeviceId = lastSeenDeviceId;
            this.MaxPageSize = maxPageSize;
            this.DeviceList = deviceList;
        }

        /// <summary>
        /// Account identifier.
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Total FOTA license count.
        /// </summary>
        [JsonProperty("totalLicenses", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalLicenses { get; set; }

        /// <summary>
        /// Assigned FOTA license count.
        /// </summary>
        [JsonProperty("assignedLicenses")]
        public int AssignedLicenses { get; set; }

        /// <summary>
        /// True if there are more devices to retrieve.
        /// </summary>
        [JsonProperty("hasMoreData")]
        public bool HasMoreData { get; set; }

        /// <summary>
        /// Last seen device identifier.
        /// </summary>
        [JsonProperty("lastSeenDeviceId", NullValueHandling = NullValueHandling.Ignore)]
        public string LastSeenDeviceId { get; set; }

        /// <summary>
        /// Maximum page size.
        /// </summary>
        [JsonProperty("maxPageSize")]
        public int MaxPageSize { get; set; }

        /// <summary>
        /// Device IMEI list.
        /// </summary>
        [JsonProperty("deviceList", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.V3LicenseDevice> DeviceList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V3LicenseSummary : ({string.Join(", ", toStringOutput)})";
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
            return obj is V3LicenseSummary other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.TotalLicenses == null && other.TotalLicenses == null) || (this.TotalLicenses?.Equals(other.TotalLicenses) == true)) &&
                this.AssignedLicenses.Equals(other.AssignedLicenses) &&
                this.HasMoreData.Equals(other.HasMoreData) &&
                ((this.LastSeenDeviceId == null && other.LastSeenDeviceId == null) || (this.LastSeenDeviceId?.Equals(other.LastSeenDeviceId) == true)) &&
                this.MaxPageSize.Equals(other.MaxPageSize) &&
                ((this.DeviceList == null && other.DeviceList == null) || (this.DeviceList?.Equals(other.DeviceList) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.TotalLicenses = {(this.TotalLicenses == null ? "null" : this.TotalLicenses.ToString())}");
            toStringOutput.Add($"this.AssignedLicenses = {this.AssignedLicenses}");
            toStringOutput.Add($"this.HasMoreData = {this.HasMoreData}");
            toStringOutput.Add($"this.LastSeenDeviceId = {(this.LastSeenDeviceId == null ? "null" : this.LastSeenDeviceId)}");
            toStringOutput.Add($"this.MaxPageSize = {this.MaxPageSize}");
            toStringOutput.Add($"this.DeviceList = {(this.DeviceList == null ? "null" : $"[{string.Join(", ", this.DeviceList)} ]")}");
        }
    }
}