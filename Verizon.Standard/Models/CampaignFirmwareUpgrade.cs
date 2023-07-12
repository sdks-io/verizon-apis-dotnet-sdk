// <copyright file="CampaignFirmwareUpgrade.cs" company="APIMatic">
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
    /// CampaignFirmwareUpgrade.
    /// </summary>
    public class CampaignFirmwareUpgrade
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignFirmwareUpgrade"/> class.
        /// </summary>
        public CampaignFirmwareUpgrade()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignFirmwareUpgrade"/> class.
        /// </summary>
        /// <param name="firmwareName">firmwareName.</param>
        /// <param name="firmwareFrom">firmwareFrom.</param>
        /// <param name="firmwareTo">firmwareTo.</param>
        /// <param name="protocol">protocol.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="deviceList">deviceList.</param>
        /// <param name="campaignName">campaignName.</param>
        /// <param name="campaignTimeWindowList">campaignTimeWindowList.</param>
        public CampaignFirmwareUpgrade(
            string firmwareName,
            string firmwareFrom,
            string firmwareTo,
            string protocol,
            DateTime startDate,
            DateTime endDate,
            List<string> deviceList,
            string campaignName = null,
            List<Models.V3TimeWindow> campaignTimeWindowList = null)
        {
            this.CampaignName = campaignName;
            this.FirmwareName = firmwareName;
            this.FirmwareFrom = firmwareFrom;
            this.FirmwareTo = firmwareTo;
            this.Protocol = protocol;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.CampaignTimeWindowList = campaignTimeWindowList;
            this.DeviceList = deviceList;
        }

        /// <summary>
        /// Campaign name.
        /// </summary>
        [JsonProperty("campaignName", NullValueHandling = NullValueHandling.Ignore)]
        public string CampaignName { get; set; }

        /// <summary>
        /// Firmware name to upgrade to.
        /// </summary>
        [JsonProperty("firmwareName")]
        public string FirmwareName { get; set; }

        /// <summary>
        /// Old firmware version.
        /// </summary>
        [JsonProperty("firmwareFrom")]
        public string FirmwareFrom { get; set; }

        /// <summary>
        /// New firmware version.
        /// </summary>
        [JsonProperty("firmwareTo")]
        public string FirmwareTo { get; set; }

        /// <summary>
        /// Valid values include: LWM2M, OMA and HTTP.
        /// </summary>
        [JsonProperty("protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Campaign start date.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("startDate")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Campaign end date.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("endDate")]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// List of allowed campaign time windows.
        /// </summary>
        [JsonProperty("campaignTimeWindowList", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.V3TimeWindow> CampaignTimeWindowList { get; set; }

        /// <summary>
        /// Device IMEI list.
        /// </summary>
        [JsonProperty("deviceList")]
        public List<string> DeviceList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CampaignFirmwareUpgrade : ({string.Join(", ", toStringOutput)})";
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
            return obj is CampaignFirmwareUpgrade other &&                ((this.CampaignName == null && other.CampaignName == null) || (this.CampaignName?.Equals(other.CampaignName) == true)) &&
                ((this.FirmwareName == null && other.FirmwareName == null) || (this.FirmwareName?.Equals(other.FirmwareName) == true)) &&
                ((this.FirmwareFrom == null && other.FirmwareFrom == null) || (this.FirmwareFrom?.Equals(other.FirmwareFrom) == true)) &&
                ((this.FirmwareTo == null && other.FirmwareTo == null) || (this.FirmwareTo?.Equals(other.FirmwareTo) == true)) &&
                ((this.Protocol == null && other.Protocol == null) || (this.Protocol?.Equals(other.Protocol) == true)) &&
                this.StartDate.Equals(other.StartDate) &&
                this.EndDate.Equals(other.EndDate) &&
                ((this.CampaignTimeWindowList == null && other.CampaignTimeWindowList == null) || (this.CampaignTimeWindowList?.Equals(other.CampaignTimeWindowList) == true)) &&
                ((this.DeviceList == null && other.DeviceList == null) || (this.DeviceList?.Equals(other.DeviceList) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CampaignName = {(this.CampaignName == null ? "null" : this.CampaignName == string.Empty ? "" : this.CampaignName)}");
            toStringOutput.Add($"this.FirmwareName = {(this.FirmwareName == null ? "null" : this.FirmwareName == string.Empty ? "" : this.FirmwareName)}");
            toStringOutput.Add($"this.FirmwareFrom = {(this.FirmwareFrom == null ? "null" : this.FirmwareFrom == string.Empty ? "" : this.FirmwareFrom)}");
            toStringOutput.Add($"this.FirmwareTo = {(this.FirmwareTo == null ? "null" : this.FirmwareTo == string.Empty ? "" : this.FirmwareTo)}");
            toStringOutput.Add($"this.Protocol = {(this.Protocol == null ? "null" : this.Protocol == string.Empty ? "" : this.Protocol)}");
            toStringOutput.Add($"this.StartDate = {this.StartDate}");
            toStringOutput.Add($"this.EndDate = {this.EndDate}");
            toStringOutput.Add($"this.CampaignTimeWindowList = {(this.CampaignTimeWindowList == null ? "null" : $"[{string.Join(", ", this.CampaignTimeWindowList)} ]")}");
            toStringOutput.Add($"this.DeviceList = {(this.DeviceList == null ? "null" : $"[{string.Join(", ", this.DeviceList)} ]")}");
        }
    }
}