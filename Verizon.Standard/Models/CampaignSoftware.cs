// <copyright file="CampaignSoftware.cs" company="APIMatic">
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
    /// CampaignSoftware.
    /// </summary>
    public class CampaignSoftware
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignSoftware"/> class.
        /// </summary>
        public CampaignSoftware()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignSoftware"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="accountName">accountName.</param>
        /// <param name="softwareName">softwareName.</param>
        /// <param name="distributionType">distributionType.</param>
        /// <param name="make">make.</param>
        /// <param name="model">model.</param>
        /// <param name="softwareFrom">softwareFrom.</param>
        /// <param name="softwareTo">softwareTo.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="status">status.</param>
        /// <param name="campaignName">campaignName.</param>
        /// <param name="downloadAfterDate">downloadAfterDate.</param>
        /// <param name="downloadTimeWindowList">downloadTimeWindowList.</param>
        /// <param name="installAfterDate">installAfterDate.</param>
        /// <param name="installTimeWindowList">installTimeWindowList.</param>
        public CampaignSoftware(
            string id,
            string accountName,
            string softwareName,
            string distributionType,
            string make,
            string model,
            string softwareFrom,
            string softwareTo,
            DateTime startDate,
            DateTime endDate,
            string status,
            string campaignName = null,
            DateTime? downloadAfterDate = null,
            List<Models.V2TimeWindow> downloadTimeWindowList = null,
            DateTime? installAfterDate = null,
            List<Models.V2TimeWindow> installTimeWindowList = null)
        {
            this.Id = id;
            this.AccountName = accountName;
            this.CampaignName = campaignName;
            this.SoftwareName = softwareName;
            this.DistributionType = distributionType;
            this.Make = make;
            this.Model = model;
            this.SoftwareFrom = softwareFrom;
            this.SoftwareTo = softwareTo;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.DownloadAfterDate = downloadAfterDate;
            this.DownloadTimeWindowList = downloadTimeWindowList;
            this.InstallAfterDate = installAfterDate;
            this.InstallTimeWindowList = installTimeWindowList;
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
        /// Software name.
        /// </summary>
        [JsonProperty("softwareName")]
        public string SoftwareName { get; set; }

        /// <summary>
        /// LWM2M, OMD-DM or HTTP.
        /// </summary>
        [JsonProperty("distributionType")]
        public string DistributionType { get; set; }

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
        /// Software upgrade status.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CampaignSoftware : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CampaignSoftware other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.CampaignName == null && other.CampaignName == null ||
                 this.CampaignName?.Equals(other.CampaignName) == true) &&
                (this.SoftwareName == null && other.SoftwareName == null ||
                 this.SoftwareName?.Equals(other.SoftwareName) == true) &&
                (this.DistributionType == null && other.DistributionType == null ||
                 this.DistributionType?.Equals(other.DistributionType) == true) &&
                (this.Make == null && other.Make == null ||
                 this.Make?.Equals(other.Make) == true) &&
                (this.Model == null && other.Model == null ||
                 this.Model?.Equals(other.Model) == true) &&
                (this.SoftwareFrom == null && other.SoftwareFrom == null ||
                 this.SoftwareFrom?.Equals(other.SoftwareFrom) == true) &&
                (this.SoftwareTo == null && other.SoftwareTo == null ||
                 this.SoftwareTo?.Equals(other.SoftwareTo) == true) &&
                (this.StartDate.Equals(other.StartDate)) &&
                (this.EndDate.Equals(other.EndDate)) &&
                (this.DownloadAfterDate == null && other.DownloadAfterDate == null ||
                 this.DownloadAfterDate?.Equals(other.DownloadAfterDate) == true) &&
                (this.DownloadTimeWindowList == null && other.DownloadTimeWindowList == null ||
                 this.DownloadTimeWindowList?.Equals(other.DownloadTimeWindowList) == true) &&
                (this.InstallAfterDate == null && other.InstallAfterDate == null ||
                 this.InstallAfterDate?.Equals(other.InstallAfterDate) == true) &&
                (this.InstallTimeWindowList == null && other.InstallTimeWindowList == null ||
                 this.InstallTimeWindowList?.Equals(other.InstallTimeWindowList) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
            toStringOutput.Add($"CampaignName = {this.CampaignName ?? "null"}");
            toStringOutput.Add($"SoftwareName = {this.SoftwareName ?? "null"}");
            toStringOutput.Add($"DistributionType = {this.DistributionType ?? "null"}");
            toStringOutput.Add($"Make = {this.Make ?? "null"}");
            toStringOutput.Add($"Model = {this.Model ?? "null"}");
            toStringOutput.Add($"SoftwareFrom = {this.SoftwareFrom ?? "null"}");
            toStringOutput.Add($"SoftwareTo = {this.SoftwareTo ?? "null"}");
            toStringOutput.Add($"StartDate = {this.StartDate}");
            toStringOutput.Add($"EndDate = {this.EndDate}");
            toStringOutput.Add($"DownloadAfterDate = {(this.DownloadAfterDate == null ? "null" : this.DownloadAfterDate.ToString())}");
            toStringOutput.Add($"DownloadTimeWindowList = {(this.DownloadTimeWindowList == null ? "null" : $"[{string.Join(", ", this.DownloadTimeWindowList)} ]")}");
            toStringOutput.Add($"InstallAfterDate = {(this.InstallAfterDate == null ? "null" : this.InstallAfterDate.ToString())}");
            toStringOutput.Add($"InstallTimeWindowList = {(this.InstallTimeWindowList == null ? "null" : $"[{string.Join(", ", this.InstallTimeWindowList)} ]")}");
            toStringOutput.Add($"Status = {this.Status ?? "null"}");
        }
    }
}