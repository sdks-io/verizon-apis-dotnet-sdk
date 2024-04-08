// <copyright file="Campaign.cs" company="APIMatic">
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
    /// Campaign.
    /// </summary>
    public class Campaign
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Campaign"/> class.
        /// </summary>
        public Campaign()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Campaign"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="accountName">accountName.</param>
        /// <param name="protocol">protocol.</param>
        /// <param name="make">make.</param>
        /// <param name="model">model.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="status">status.</param>
        /// <param name="campaignName">campaignName.</param>
        /// <param name="firmwareName">firmwareName.</param>
        /// <param name="firmwareFrom">firmwareFrom.</param>
        /// <param name="firmwareTo">firmwareTo.</param>
        /// <param name="campaignTimeWindowList">campaignTimeWindowList.</param>
        public Campaign(
            string id,
            string accountName,
            string protocol,
            string make,
            string model,
            DateTime startDate,
            DateTime endDate,
            string status,
            string campaignName = null,
            string firmwareName = null,
            string firmwareFrom = null,
            string firmwareTo = null,
            List<Models.V3TimeWindow> campaignTimeWindowList = null)
        {
            this.Id = id;
            this.AccountName = accountName;
            this.CampaignName = campaignName;
            this.FirmwareName = firmwareName;
            this.FirmwareFrom = firmwareFrom;
            this.FirmwareTo = firmwareTo;
            this.Protocol = protocol;
            this.Make = make;
            this.Model = model;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.CampaignTimeWindowList = campaignTimeWindowList;
            this.Status = status;
        }

        /// <summary>
        /// Upgrade identifier.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Account identifier.
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Campaign name.
        /// </summary>
        [JsonProperty("campaignName", NullValueHandling = NullValueHandling.Ignore)]
        public string CampaignName { get; set; }

        /// <summary>
        /// Name of firmware.
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
        /// The protocol of the firmware distribution. Default: LWM2M.
        /// </summary>
        [JsonProperty("protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Applicable make.
        /// </summary>
        [JsonProperty("make")]
        public string Make { get; set; }

        /// <summary>
        /// Applicable model.
        /// </summary>
        [JsonProperty("model")]
        public string Model { get; set; }

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
        /// Firmware upgrade status.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Campaign : ({string.Join(", ", toStringOutput)})";
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
            return obj is Campaign other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.CampaignName == null && other.CampaignName == null) || (this.CampaignName?.Equals(other.CampaignName) == true)) &&
                ((this.FirmwareName == null && other.FirmwareName == null) || (this.FirmwareName?.Equals(other.FirmwareName) == true)) &&
                ((this.FirmwareFrom == null && other.FirmwareFrom == null) || (this.FirmwareFrom?.Equals(other.FirmwareFrom) == true)) &&
                ((this.FirmwareTo == null && other.FirmwareTo == null) || (this.FirmwareTo?.Equals(other.FirmwareTo) == true)) &&
                ((this.Protocol == null && other.Protocol == null) || (this.Protocol?.Equals(other.Protocol) == true)) &&
                ((this.Make == null && other.Make == null) || (this.Make?.Equals(other.Make) == true)) &&
                ((this.Model == null && other.Model == null) || (this.Model?.Equals(other.Model) == true)) &&
                this.StartDate.Equals(other.StartDate) &&
                this.EndDate.Equals(other.EndDate) &&
                ((this.CampaignTimeWindowList == null && other.CampaignTimeWindowList == null) || (this.CampaignTimeWindowList?.Equals(other.CampaignTimeWindowList) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.CampaignName = {(this.CampaignName == null ? "null" : this.CampaignName)}");
            toStringOutput.Add($"this.FirmwareName = {(this.FirmwareName == null ? "null" : this.FirmwareName)}");
            toStringOutput.Add($"this.FirmwareFrom = {(this.FirmwareFrom == null ? "null" : this.FirmwareFrom)}");
            toStringOutput.Add($"this.FirmwareTo = {(this.FirmwareTo == null ? "null" : this.FirmwareTo)}");
            toStringOutput.Add($"this.Protocol = {(this.Protocol == null ? "null" : this.Protocol)}");
            toStringOutput.Add($"this.Make = {(this.Make == null ? "null" : this.Make)}");
            toStringOutput.Add($"this.Model = {(this.Model == null ? "null" : this.Model)}");
            toStringOutput.Add($"this.StartDate = {this.StartDate}");
            toStringOutput.Add($"this.EndDate = {this.EndDate}");
            toStringOutput.Add($"this.CampaignTimeWindowList = {(this.CampaignTimeWindowList == null ? "null" : $"[{string.Join(", ", this.CampaignTimeWindowList)} ]")}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status)}");
        }
    }
}