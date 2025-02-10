// <copyright file="SchedulesSoftwareUpgradeRequest.cs" company="APIMatic">
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
    /// SchedulesSoftwareUpgradeRequest.
    /// </summary>
    public class SchedulesSoftwareUpgradeRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulesSoftwareUpgradeRequest"/> class.
        /// </summary>
        public SchedulesSoftwareUpgradeRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulesSoftwareUpgradeRequest"/> class.
        /// </summary>
        /// <param name="campaignName">campaignName.</param>
        /// <param name="softwareName">softwareName.</param>
        /// <param name="softwareFrom">softwareFrom.</param>
        /// <param name="softwareTo">softwareTo.</param>
        /// <param name="distributionType">distributionType.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="downloadAfterDate">downloadAfterDate.</param>
        /// <param name="downloadTimeWindowList">downloadTimeWindowList.</param>
        /// <param name="installAfterDate">installAfterDate.</param>
        /// <param name="installTimeWindowList">installTimeWindowList.</param>
        /// <param name="deviceList">deviceList.</param>
        public SchedulesSoftwareUpgradeRequest(
            string campaignName = null,
            string softwareName = null,
            string softwareFrom = null,
            string softwareTo = null,
            string distributionType = null,
            string startDate = null,
            string endDate = null,
            string downloadAfterDate = null,
            List<Models.DownloadTimeWindow> downloadTimeWindowList = null,
            string installAfterDate = null,
            List<Models.DownloadTimeWindow> installTimeWindowList = null,
            List<string> deviceList = null)
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
        /// The campaign name.
        /// </summary>
        [JsonProperty("campaignName", NullValueHandling = NullValueHandling.Ignore)]
        public string CampaignName { get; set; }

        /// <summary>
        /// Software name.
        /// </summary>
        [JsonProperty("softwareName", NullValueHandling = NullValueHandling.Ignore)]
        public string SoftwareName { get; set; }

        /// <summary>
        /// Old software name.
        /// </summary>
        [JsonProperty("softwareFrom", NullValueHandling = NullValueHandling.Ignore)]
        public string SoftwareFrom { get; set; }

        /// <summary>
        /// New software name.
        /// </summary>
        [JsonProperty("softwareTo", NullValueHandling = NullValueHandling.Ignore)]
        public string SoftwareTo { get; set; }

        /// <summary>
        /// Valid values
        /// </summary>
        [JsonProperty("distributionType", NullValueHandling = NullValueHandling.Ignore)]
        public string DistributionType { get; set; }

        /// <summary>
        /// Campaign start date.
        /// </summary>
        [JsonProperty("startDate", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDate { get; set; }

        /// <summary>
        /// Campaign end date.
        /// </summary>
        [JsonProperty("endDate", NullValueHandling = NullValueHandling.Ignore)]
        public string EndDate { get; set; }

        /// <summary>
        /// Specifies the starting date the client should download the package. If null, client downloads as soon as possible.
        /// </summary>
        [JsonProperty("downloadAfterDate", NullValueHandling = NullValueHandling.Ignore)]
        public string DownloadAfterDate { get; set; }

        /// <summary>
        /// List of allowed download time windows.
        /// </summary>
        [JsonProperty("downloadTimeWindowList", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DownloadTimeWindow> DownloadTimeWindowList { get; set; }

        /// <summary>
        /// The date after which you install the package. If null, install as soon as possible.
        /// </summary>
        [JsonProperty("installAfterDate", NullValueHandling = NullValueHandling.Ignore)]
        public string InstallAfterDate { get; set; }

        /// <summary>
        /// List of allowed install time windows.
        /// </summary>
        [JsonProperty("installTimeWindowList", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DownloadTimeWindow> InstallTimeWindowList { get; set; }

        /// <summary>
        /// Device IMEI list.
        /// </summary>
        [JsonProperty("deviceList", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DeviceList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SchedulesSoftwareUpgradeRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SchedulesSoftwareUpgradeRequest other &&
                (this.CampaignName == null && other.CampaignName == null ||
                 this.CampaignName?.Equals(other.CampaignName) == true) &&
                (this.SoftwareName == null && other.SoftwareName == null ||
                 this.SoftwareName?.Equals(other.SoftwareName) == true) &&
                (this.SoftwareFrom == null && other.SoftwareFrom == null ||
                 this.SoftwareFrom?.Equals(other.SoftwareFrom) == true) &&
                (this.SoftwareTo == null && other.SoftwareTo == null ||
                 this.SoftwareTo?.Equals(other.SoftwareTo) == true) &&
                (this.DistributionType == null && other.DistributionType == null ||
                 this.DistributionType?.Equals(other.DistributionType) == true) &&
                (this.StartDate == null && other.StartDate == null ||
                 this.StartDate?.Equals(other.StartDate) == true) &&
                (this.EndDate == null && other.EndDate == null ||
                 this.EndDate?.Equals(other.EndDate) == true) &&
                (this.DownloadAfterDate == null && other.DownloadAfterDate == null ||
                 this.DownloadAfterDate?.Equals(other.DownloadAfterDate) == true) &&
                (this.DownloadTimeWindowList == null && other.DownloadTimeWindowList == null ||
                 this.DownloadTimeWindowList?.Equals(other.DownloadTimeWindowList) == true) &&
                (this.InstallAfterDate == null && other.InstallAfterDate == null ||
                 this.InstallAfterDate?.Equals(other.InstallAfterDate) == true) &&
                (this.InstallTimeWindowList == null && other.InstallTimeWindowList == null ||
                 this.InstallTimeWindowList?.Equals(other.InstallTimeWindowList) == true) &&
                (this.DeviceList == null && other.DeviceList == null ||
                 this.DeviceList?.Equals(other.DeviceList) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CampaignName = {this.CampaignName ?? "null"}");
            toStringOutput.Add($"SoftwareName = {this.SoftwareName ?? "null"}");
            toStringOutput.Add($"SoftwareFrom = {this.SoftwareFrom ?? "null"}");
            toStringOutput.Add($"SoftwareTo = {this.SoftwareTo ?? "null"}");
            toStringOutput.Add($"DistributionType = {this.DistributionType ?? "null"}");
            toStringOutput.Add($"StartDate = {this.StartDate ?? "null"}");
            toStringOutput.Add($"EndDate = {this.EndDate ?? "null"}");
            toStringOutput.Add($"DownloadAfterDate = {this.DownloadAfterDate ?? "null"}");
            toStringOutput.Add($"DownloadTimeWindowList = {(this.DownloadTimeWindowList == null ? "null" : $"[{string.Join(", ", this.DownloadTimeWindowList)} ]")}");
            toStringOutput.Add($"InstallAfterDate = {this.InstallAfterDate ?? "null"}");
            toStringOutput.Add($"InstallTimeWindowList = {(this.InstallTimeWindowList == null ? "null" : $"[{string.Join(", ", this.InstallTimeWindowList)} ]")}");
            toStringOutput.Add($"DeviceList = {(this.DeviceList == null ? "null" : $"[{string.Join(", ", this.DeviceList)} ]")}");
        }
    }
}