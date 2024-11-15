// <copyright file="CampaignSoftwareUpgrade.cs" company="APIMatic">
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
    /// CampaignSoftwareUpgrade.
    /// </summary>
    public class CampaignSoftwareUpgrade
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignSoftwareUpgrade"/> class.
        /// </summary>
        public CampaignSoftwareUpgrade()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignSoftwareUpgrade"/> class.
        /// </summary>
        /// <param name="softwareName">softwareName.</param>
        /// <param name="softwareFrom">softwareFrom.</param>
        /// <param name="softwareTo">softwareTo.</param>
        /// <param name="distributionType">distributionType.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="deviceList">deviceList.</param>
        /// <param name="campaignName">campaignName.</param>
        /// <param name="downloadAfterDate">downloadAfterDate.</param>
        /// <param name="downloadTimeWindowList">downloadTimeWindowList.</param>
        /// <param name="installAfterDate">installAfterDate.</param>
        /// <param name="installTimeWindowList">installTimeWindowList.</param>
        public CampaignSoftwareUpgrade(
            string softwareName,
            string softwareFrom,
            string softwareTo,
            string distributionType,
            DateTime startDate,
            DateTime endDate,
            List<string> deviceList,
            string campaignName = null,
            DateTime? downloadAfterDate = null,
            List<Models.V2TimeWindow> downloadTimeWindowList = null,
            DateTime? installAfterDate = null,
            List<Models.V2TimeWindow> installTimeWindowList = null)
        {
            this.CampaignName = campaignName;
            this.SoftwareName = softwareName;
            this.SoftwareFrom = softwareFrom;
            this.SoftwareTo = softwareTo;
            this.DistributionType = distributionType;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.DownloadAfterDate = downloadAfterDate;
            this.DownloadTimeWindowList = downloadTimeWindowList;
            this.InstallAfterDate = installAfterDate;
            this.InstallTimeWindowList = installTimeWindowList;
            this.DeviceList = deviceList;
        }

        /// <summary>
        /// Campaign name.
        /// </summary>
        [JsonProperty("campaignName", NullValueHandling = NullValueHandling.Ignore)]
        public string CampaignName { get; set; }

        /// <summary>
        /// Software name to upgrade to.
        /// </summary>
        [JsonProperty("softwareName")]
        public string SoftwareName { get; set; }

        /// <summary>
        /// Old software name.
        /// </summary>
        [JsonProperty("softwareFrom")]
        public string SoftwareFrom { get; set; }

        /// <summary>
        /// New software name.
        /// </summary>
        [JsonProperty("softwareTo")]
        public string SoftwareTo { get; set; }

        /// <summary>
        /// OMA or HTTP.
        /// </summary>
        [JsonProperty("distributionType")]
        public string DistributionType { get; set; }

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
        /// Specifies starting date client should download package. If null, client will download as soon as possible.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("downloadAfterDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DownloadAfterDate { get; set; }

        /// <summary>
        /// List of allowed download time windows.
        /// </summary>
        [JsonProperty("downloadTimeWindowList", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.V2TimeWindow> DownloadTimeWindowList { get; set; }

        /// <summary>
        /// Client will install package after date. If null, client will install as soon as possible.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("installAfterDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? InstallAfterDate { get; set; }

        /// <summary>
        /// List of allowed install time windows.
        /// </summary>
        [JsonProperty("installTimeWindowList", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.V2TimeWindow> InstallTimeWindowList { get; set; }

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

            return $"CampaignSoftwareUpgrade : ({string.Join(", ", toStringOutput)})";
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
            return obj is CampaignSoftwareUpgrade other &&                ((this.CampaignName == null && other.CampaignName == null) || (this.CampaignName?.Equals(other.CampaignName) == true)) &&
                ((this.SoftwareName == null && other.SoftwareName == null) || (this.SoftwareName?.Equals(other.SoftwareName) == true)) &&
                ((this.SoftwareFrom == null && other.SoftwareFrom == null) || (this.SoftwareFrom?.Equals(other.SoftwareFrom) == true)) &&
                ((this.SoftwareTo == null && other.SoftwareTo == null) || (this.SoftwareTo?.Equals(other.SoftwareTo) == true)) &&
                ((this.DistributionType == null && other.DistributionType == null) || (this.DistributionType?.Equals(other.DistributionType) == true)) &&
                this.StartDate.Equals(other.StartDate) &&
                this.EndDate.Equals(other.EndDate) &&
                ((this.DownloadAfterDate == null && other.DownloadAfterDate == null) || (this.DownloadAfterDate?.Equals(other.DownloadAfterDate) == true)) &&
                ((this.DownloadTimeWindowList == null && other.DownloadTimeWindowList == null) || (this.DownloadTimeWindowList?.Equals(other.DownloadTimeWindowList) == true)) &&
                ((this.InstallAfterDate == null && other.InstallAfterDate == null) || (this.InstallAfterDate?.Equals(other.InstallAfterDate) == true)) &&
                ((this.InstallTimeWindowList == null && other.InstallTimeWindowList == null) || (this.InstallTimeWindowList?.Equals(other.InstallTimeWindowList) == true)) &&
                ((this.DeviceList == null && other.DeviceList == null) || (this.DeviceList?.Equals(other.DeviceList) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CampaignName = {(this.CampaignName == null ? "null" : this.CampaignName)}");
            toStringOutput.Add($"this.SoftwareName = {(this.SoftwareName == null ? "null" : this.SoftwareName)}");
            toStringOutput.Add($"this.SoftwareFrom = {(this.SoftwareFrom == null ? "null" : this.SoftwareFrom)}");
            toStringOutput.Add($"this.SoftwareTo = {(this.SoftwareTo == null ? "null" : this.SoftwareTo)}");
            toStringOutput.Add($"this.DistributionType = {(this.DistributionType == null ? "null" : this.DistributionType)}");
            toStringOutput.Add($"this.StartDate = {this.StartDate}");
            toStringOutput.Add($"this.EndDate = {this.EndDate}");
            toStringOutput.Add($"this.DownloadAfterDate = {(this.DownloadAfterDate == null ? "null" : this.DownloadAfterDate.ToString())}");
            toStringOutput.Add($"this.DownloadTimeWindowList = {(this.DownloadTimeWindowList == null ? "null" : $"[{string.Join(", ", this.DownloadTimeWindowList)} ]")}");
            toStringOutput.Add($"this.InstallAfterDate = {(this.InstallAfterDate == null ? "null" : this.InstallAfterDate.ToString())}");
            toStringOutput.Add($"this.InstallTimeWindowList = {(this.InstallTimeWindowList == null ? "null" : $"[{string.Join(", ", this.InstallTimeWindowList)} ]")}");
            toStringOutput.Add($"this.DeviceList = {(this.DeviceList == null ? "null" : $"[{string.Join(", ", this.DeviceList)} ]")}");
        }
    }
}