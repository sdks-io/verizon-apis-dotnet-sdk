// <copyright file="DeviceFirmwareUpgrade.cs" company="APIMatic">
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
    /// DeviceFirmwareUpgrade.
    /// </summary>
    public class DeviceFirmwareUpgrade
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceFirmwareUpgrade"/> class.
        /// </summary>
        public DeviceFirmwareUpgrade()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceFirmwareUpgrade"/> class.
        /// </summary>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="campaignId">campaignId.</param>
        /// <param name="accountName">accountName.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="status">status.</param>
        /// <param name="reason">reason.</param>
        /// <param name="firmwareName">firmwareName.</param>
        /// <param name="firmwareFrom">firmwareFrom.</param>
        /// <param name="firmwareTo">firmwareTo.</param>
        /// <param name="reportUpdatedTime">reportUpdatedTime.</param>
        public DeviceFirmwareUpgrade(
            string deviceId,
            string campaignId,
            string accountName,
            DateTime startDate,
            string status,
            string reason,
            string firmwareName = null,
            string firmwareFrom = null,
            string firmwareTo = null,
            string reportUpdatedTime = null)
        {
            this.DeviceId = deviceId;
            this.CampaignId = campaignId;
            this.AccountName = accountName;
            this.FirmwareName = firmwareName;
            this.FirmwareFrom = firmwareFrom;
            this.FirmwareTo = firmwareTo;
            this.StartDate = startDate;
            this.Status = status;
            this.Reason = reason;
            this.ReportUpdatedTime = reportUpdatedTime;
        }

        /// <summary>
        /// Device identifier.
        /// </summary>
        [JsonProperty("deviceId")]
        public string DeviceId { get; set; }

        /// <summary>
        /// Campaign identifier.
        /// </summary>
        [JsonProperty("campaignId")]
        public string CampaignId { get; set; }

        /// <summary>
        /// Account identifier.
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Firmware name.
        /// </summary>
        [JsonProperty("firmwareName", NullValueHandling = NullValueHandling.Ignore)]
        public string FirmwareName { get; set; }

        /// <summary>
        /// Old firmware version.
        /// </summary>
        [JsonProperty("firmwareFrom", NullValueHandling = NullValueHandling.Ignore)]
        public string FirmwareFrom { get; set; }

        /// <summary>
        /// New firmware version.
        /// </summary>
        [JsonProperty("firmwareTo", NullValueHandling = NullValueHandling.Ignore)]
        public string FirmwareTo { get; set; }

        /// <summary>
        /// Firmware upgrade start date.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("startDate")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Firmware upgrade status.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Software upgrade result reason.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Report updated time.
        /// </summary>
        [JsonProperty("reportUpdatedTime", NullValueHandling = NullValueHandling.Ignore)]
        public string ReportUpdatedTime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DeviceFirmwareUpgrade : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DeviceFirmwareUpgrade other &&
                (this.DeviceId == null && other.DeviceId == null ||
                 this.DeviceId?.Equals(other.DeviceId) == true) &&
                (this.CampaignId == null && other.CampaignId == null ||
                 this.CampaignId?.Equals(other.CampaignId) == true) &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.FirmwareName == null && other.FirmwareName == null ||
                 this.FirmwareName?.Equals(other.FirmwareName) == true) &&
                (this.FirmwareFrom == null && other.FirmwareFrom == null ||
                 this.FirmwareFrom?.Equals(other.FirmwareFrom) == true) &&
                (this.FirmwareTo == null && other.FirmwareTo == null ||
                 this.FirmwareTo?.Equals(other.FirmwareTo) == true) &&
                (this.StartDate.Equals(other.StartDate)) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.Reason == null && other.Reason == null ||
                 this.Reason?.Equals(other.Reason) == true) &&
                (this.ReportUpdatedTime == null && other.ReportUpdatedTime == null ||
                 this.ReportUpdatedTime?.Equals(other.ReportUpdatedTime) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"DeviceId = {this.DeviceId ?? "null"}");
            toStringOutput.Add($"CampaignId = {this.CampaignId ?? "null"}");
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
            toStringOutput.Add($"FirmwareName = {this.FirmwareName ?? "null"}");
            toStringOutput.Add($"FirmwareFrom = {this.FirmwareFrom ?? "null"}");
            toStringOutput.Add($"FirmwareTo = {this.FirmwareTo ?? "null"}");
            toStringOutput.Add($"StartDate = {this.StartDate}");
            toStringOutput.Add($"Status = {this.Status ?? "null"}");
            toStringOutput.Add($"Reason = {this.Reason ?? "null"}");
            toStringOutput.Add($"ReportUpdatedTime = {this.ReportUpdatedTime ?? "null"}");
        }
    }
}