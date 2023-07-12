// <copyright file="V2CampaignMetaInfo.cs" company="APIMatic">
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
    /// V2CampaignMetaInfo.
    /// </summary>
    public class V2CampaignMetaInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V2CampaignMetaInfo"/> class.
        /// </summary>
        public V2CampaignMetaInfo()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V2CampaignMetaInfo"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="id">id.</param>
        /// <param name="softwareName">softwareName.</param>
        /// <param name="distributionType">distributionType.</param>
        /// <param name="softwareFrom">softwareFrom.</param>
        /// <param name="softwareTo">softwareTo.</param>
        /// <param name="make">make.</param>
        /// <param name="model">model.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="status">status.</param>
        /// <param name="campaignName">campaignName.</param>
        /// <param name="downloadAfterDate">downloadAfterDate.</param>
        /// <param name="downloadTimeWindowList">downloadTimeWindowList.</param>
        /// <param name="installAfterDate">installAfterDate.</param>
        /// <param name="installTimeWindowList">installTimeWindowList.</param>
        public V2CampaignMetaInfo(
            string accountName,
            string id,
            string softwareName,
            string distributionType,
            string softwareFrom,
            string softwareTo,
            string make,
            string model,
            DateTime startDate,
            DateTime endDate,
            string status,
            string campaignName = null,
            DateTime? downloadAfterDate = null,
            List<Models.V2TimeWindow> downloadTimeWindowList = null,
            DateTime? installAfterDate = null,
            List<Models.V2TimeWindow> installTimeWindowList = null)
        {
            this.AccountName = accountName;
            this.Id = id;
            this.CampaignName = campaignName;
            this.SoftwareName = softwareName;
            this.DistributionType = distributionType;
            this.SoftwareFrom = softwareFrom;
            this.SoftwareTo = softwareTo;
            this.Make = make;
            this.Model = model;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.DownloadAfterDate = downloadAfterDate;
            this.DownloadTimeWindowList = downloadTimeWindowList;
            this.InstallAfterDate = installAfterDate;
            this.InstallTimeWindowList = installTimeWindowList;
            this.Status = status;
        }

        /// <summary>
        /// Account identifier.
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Campaign identifier.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

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

            return $"V2CampaignMetaInfo : ({string.Join(", ", toStringOutput)})";
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
            return obj is V2CampaignMetaInfo other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.CampaignName == null && other.CampaignName == null) || (this.CampaignName?.Equals(other.CampaignName) == true)) &&
                ((this.SoftwareName == null && other.SoftwareName == null) || (this.SoftwareName?.Equals(other.SoftwareName) == true)) &&
                ((this.DistributionType == null && other.DistributionType == null) || (this.DistributionType?.Equals(other.DistributionType) == true)) &&
                ((this.SoftwareFrom == null && other.SoftwareFrom == null) || (this.SoftwareFrom?.Equals(other.SoftwareFrom) == true)) &&
                ((this.SoftwareTo == null && other.SoftwareTo == null) || (this.SoftwareTo?.Equals(other.SoftwareTo) == true)) &&
                ((this.Make == null && other.Make == null) || (this.Make?.Equals(other.Make) == true)) &&
                ((this.Model == null && other.Model == null) || (this.Model?.Equals(other.Model) == true)) &&
                this.StartDate.Equals(other.StartDate) &&
                this.EndDate.Equals(other.EndDate) &&
                ((this.DownloadAfterDate == null && other.DownloadAfterDate == null) || (this.DownloadAfterDate?.Equals(other.DownloadAfterDate) == true)) &&
                ((this.DownloadTimeWindowList == null && other.DownloadTimeWindowList == null) || (this.DownloadTimeWindowList?.Equals(other.DownloadTimeWindowList) == true)) &&
                ((this.InstallAfterDate == null && other.InstallAfterDate == null) || (this.InstallAfterDate?.Equals(other.InstallAfterDate) == true)) &&
                ((this.InstallTimeWindowList == null && other.InstallTimeWindowList == null) || (this.InstallTimeWindowList?.Equals(other.InstallTimeWindowList) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName == string.Empty ? "" : this.AccountName)}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.CampaignName = {(this.CampaignName == null ? "null" : this.CampaignName == string.Empty ? "" : this.CampaignName)}");
            toStringOutput.Add($"this.SoftwareName = {(this.SoftwareName == null ? "null" : this.SoftwareName == string.Empty ? "" : this.SoftwareName)}");
            toStringOutput.Add($"this.DistributionType = {(this.DistributionType == null ? "null" : this.DistributionType == string.Empty ? "" : this.DistributionType)}");
            toStringOutput.Add($"this.SoftwareFrom = {(this.SoftwareFrom == null ? "null" : this.SoftwareFrom == string.Empty ? "" : this.SoftwareFrom)}");
            toStringOutput.Add($"this.SoftwareTo = {(this.SoftwareTo == null ? "null" : this.SoftwareTo == string.Empty ? "" : this.SoftwareTo)}");
            toStringOutput.Add($"this.Make = {(this.Make == null ? "null" : this.Make == string.Empty ? "" : this.Make)}");
            toStringOutput.Add($"this.Model = {(this.Model == null ? "null" : this.Model == string.Empty ? "" : this.Model)}");
            toStringOutput.Add($"this.StartDate = {this.StartDate}");
            toStringOutput.Add($"this.EndDate = {this.EndDate}");
            toStringOutput.Add($"this.DownloadAfterDate = {(this.DownloadAfterDate == null ? "null" : this.DownloadAfterDate.ToString())}");
            toStringOutput.Add($"this.DownloadTimeWindowList = {(this.DownloadTimeWindowList == null ? "null" : $"[{string.Join(", ", this.DownloadTimeWindowList)} ]")}");
            toStringOutput.Add($"this.InstallAfterDate = {(this.InstallAfterDate == null ? "null" : this.InstallAfterDate.ToString())}");
            toStringOutput.Add($"this.InstallTimeWindowList = {(this.InstallTimeWindowList == null ? "null" : $"[{string.Join(", ", this.InstallTimeWindowList)} ]")}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
        }
    }
}