// <copyright file="FirmwareUpgrade.cs" company="APIMatic">
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
    /// FirmwareUpgrade.
    /// </summary>
    public class FirmwareUpgrade
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FirmwareUpgrade"/> class.
        /// </summary>
        public FirmwareUpgrade()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FirmwareUpgrade"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="accountName">accountName.</param>
        /// <param name="firmwareName">firmwareName.</param>
        /// <param name="firmwareTo">firmwareTo.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="status">status.</param>
        /// <param name="deviceList">deviceList.</param>
        public FirmwareUpgrade(
            string id = null,
            string accountName = null,
            string firmwareName = null,
            string firmwareTo = null,
            string startDate = null,
            string status = null,
            List<Models.FirmwareUpgradeDeviceListItem> deviceList = null)
        {
            this.Id = id;
            this.AccountName = accountName;
            this.FirmwareName = firmwareName;
            this.FirmwareTo = firmwareTo;
            this.StartDate = startDate;
            this.Status = status;
            this.DeviceList = deviceList;
        }

        /// <summary>
        /// The unique identifier for this upgrade.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Account identifier in "##########-#####".
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// The name of the firmware image that will be used for the upgrade.
        /// </summary>
        [JsonProperty("firmwareName", NullValueHandling = NullValueHandling.Ignore)]
        public string FirmwareName { get; set; }

        /// <summary>
        /// The name of the firmware version that will be on the devices after a successful upgrade.
        /// </summary>
        [JsonProperty("firmwareTo", NullValueHandling = NullValueHandling.Ignore)]
        public string FirmwareTo { get; set; }

        /// <summary>
        /// The intended start date for the upgrade.
        /// </summary>
        [JsonProperty("startDate", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDate { get; set; }

        /// <summary>
        /// The current status of the upgrade.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// A JSON object for each device that was included in the upgrade, showing the device IMEI, the status of the upgrade, and additional information about the status.
        /// </summary>
        [JsonProperty("deviceList", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.FirmwareUpgradeDeviceListItem> DeviceList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"FirmwareUpgrade : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is FirmwareUpgrade other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.FirmwareName == null && other.FirmwareName == null ||
                 this.FirmwareName?.Equals(other.FirmwareName) == true) &&
                (this.FirmwareTo == null && other.FirmwareTo == null ||
                 this.FirmwareTo?.Equals(other.FirmwareTo) == true) &&
                (this.StartDate == null && other.StartDate == null ||
                 this.StartDate?.Equals(other.StartDate) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.DeviceList == null && other.DeviceList == null ||
                 this.DeviceList?.Equals(other.DeviceList) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
            toStringOutput.Add($"FirmwareName = {this.FirmwareName ?? "null"}");
            toStringOutput.Add($"FirmwareTo = {this.FirmwareTo ?? "null"}");
            toStringOutput.Add($"StartDate = {this.StartDate ?? "null"}");
            toStringOutput.Add($"Status = {this.Status ?? "null"}");
            toStringOutput.Add($"DeviceList = {(this.DeviceList == null ? "null" : $"[{string.Join(", ", this.DeviceList)} ]")}");
        }
    }
}