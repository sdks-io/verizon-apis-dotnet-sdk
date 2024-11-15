// <copyright file="UploadAndScheduleFileResponse.cs" company="APIMatic">
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
    /// UploadAndScheduleFileResponse.
    /// </summary>
    public class UploadAndScheduleFileResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadAndScheduleFileResponse"/> class.
        /// </summary>
        public UploadAndScheduleFileResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadAndScheduleFileResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="accountName">accountName.</param>
        /// <param name="campaignName">campaignName.</param>
        /// <param name="softwareName">softwareName.</param>
        /// <param name="softwareFrom">softwareFrom.</param>
        /// <param name="softwareTo">softwareTo.</param>
        /// <param name="fileName">fileName.</param>
        /// <param name="fileVersion">fileVersion.</param>
        /// <param name="distributionType">distributionType.</param>
        /// <param name="make">make.</param>
        /// <param name="model">model.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="downloadAfterDate">downloadAfterDate.</param>
        /// <param name="downloadTimeWindowList">downloadTimeWindowList.</param>
        /// <param name="installAfterDate">installAfterDate.</param>
        /// <param name="installTimeWindowList">installTimeWindowList.</param>
        /// <param name="deviceList">deviceList.</param>
        /// <param name="status">status.</param>
        public UploadAndScheduleFileResponse(
            string id = null,
            string accountName = null,
            string campaignName = null,
            string softwareName = null,
            string softwareFrom = null,
            string softwareTo = null,
            string fileName = null,
            string fileVersion = null,
            string distributionType = null,
            string make = null,
            string model = null,
            string startDate = null,
            string endDate = null,
            string downloadAfterDate = null,
            List<Models.DownloadTimeWindow> downloadTimeWindowList = null,
            string installAfterDate = null,
            List<Models.DownloadTimeWindow> installTimeWindowList = null,
            List<string> deviceList = null,
            string status = null)
        {
            this.Id = id;
            this.AccountName = accountName;
            this.CampaignName = campaignName;
            this.SoftwareName = softwareName;
            this.SoftwareFrom = softwareFrom;
            this.SoftwareTo = softwareTo;
            this.FileName = fileName;
            this.FileVersion = fileVersion;
            this.DistributionType = distributionType;
            this.Make = make;
            this.Model = model;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.DownloadAfterDate = downloadAfterDate;
            this.DownloadTimeWindowList = downloadTimeWindowList;
            this.InstallAfterDate = installAfterDate;
            this.InstallTimeWindowList = installTimeWindowList;
            this.DeviceList = deviceList;
            this.Status = status;
        }

        /// <summary>
        /// Updgrade identifier.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Account identifer.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

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
        /// The name of the file you are upgrading to.
        /// </summary>
        [JsonProperty("fileName", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        /// <summary>
        /// The version of the file you are upgrading to.
        /// </summary>
        [JsonProperty("fileVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string FileVersion { get; set; }

        /// <summary>
        /// Valid values
        /// </summary>
        [JsonProperty("distributionType", NullValueHandling = NullValueHandling.Ignore)]
        public string DistributionType { get; set; }

        /// <summary>
        /// Applicable make.
        /// </summary>
        [JsonProperty("make", NullValueHandling = NullValueHandling.Ignore)]
        public string Make { get; set; }

        /// <summary>
        /// Applicable model.
        /// </summary>
        [JsonProperty("model", NullValueHandling = NullValueHandling.Ignore)]
        public string Model { get; set; }

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

        /// <summary>
        /// Software update status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UploadAndScheduleFileResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is UploadAndScheduleFileResponse other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.CampaignName == null && other.CampaignName == null) || (this.CampaignName?.Equals(other.CampaignName) == true)) &&
                ((this.SoftwareName == null && other.SoftwareName == null) || (this.SoftwareName?.Equals(other.SoftwareName) == true)) &&
                ((this.SoftwareFrom == null && other.SoftwareFrom == null) || (this.SoftwareFrom?.Equals(other.SoftwareFrom) == true)) &&
                ((this.SoftwareTo == null && other.SoftwareTo == null) || (this.SoftwareTo?.Equals(other.SoftwareTo) == true)) &&
                ((this.FileName == null && other.FileName == null) || (this.FileName?.Equals(other.FileName) == true)) &&
                ((this.FileVersion == null && other.FileVersion == null) || (this.FileVersion?.Equals(other.FileVersion) == true)) &&
                ((this.DistributionType == null && other.DistributionType == null) || (this.DistributionType?.Equals(other.DistributionType) == true)) &&
                ((this.Make == null && other.Make == null) || (this.Make?.Equals(other.Make) == true)) &&
                ((this.Model == null && other.Model == null) || (this.Model?.Equals(other.Model) == true)) &&
                ((this.StartDate == null && other.StartDate == null) || (this.StartDate?.Equals(other.StartDate) == true)) &&
                ((this.EndDate == null && other.EndDate == null) || (this.EndDate?.Equals(other.EndDate) == true)) &&
                ((this.DownloadAfterDate == null && other.DownloadAfterDate == null) || (this.DownloadAfterDate?.Equals(other.DownloadAfterDate) == true)) &&
                ((this.DownloadTimeWindowList == null && other.DownloadTimeWindowList == null) || (this.DownloadTimeWindowList?.Equals(other.DownloadTimeWindowList) == true)) &&
                ((this.InstallAfterDate == null && other.InstallAfterDate == null) || (this.InstallAfterDate?.Equals(other.InstallAfterDate) == true)) &&
                ((this.InstallTimeWindowList == null && other.InstallTimeWindowList == null) || (this.InstallTimeWindowList?.Equals(other.InstallTimeWindowList) == true)) &&
                ((this.DeviceList == null && other.DeviceList == null) || (this.DeviceList?.Equals(other.DeviceList) == true)) &&
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
            toStringOutput.Add($"this.SoftwareName = {(this.SoftwareName == null ? "null" : this.SoftwareName)}");
            toStringOutput.Add($"this.SoftwareFrom = {(this.SoftwareFrom == null ? "null" : this.SoftwareFrom)}");
            toStringOutput.Add($"this.SoftwareTo = {(this.SoftwareTo == null ? "null" : this.SoftwareTo)}");
            toStringOutput.Add($"this.FileName = {(this.FileName == null ? "null" : this.FileName)}");
            toStringOutput.Add($"this.FileVersion = {(this.FileVersion == null ? "null" : this.FileVersion)}");
            toStringOutput.Add($"this.DistributionType = {(this.DistributionType == null ? "null" : this.DistributionType)}");
            toStringOutput.Add($"this.Make = {(this.Make == null ? "null" : this.Make)}");
            toStringOutput.Add($"this.Model = {(this.Model == null ? "null" : this.Model)}");
            toStringOutput.Add($"this.StartDate = {(this.StartDate == null ? "null" : this.StartDate)}");
            toStringOutput.Add($"this.EndDate = {(this.EndDate == null ? "null" : this.EndDate)}");
            toStringOutput.Add($"this.DownloadAfterDate = {(this.DownloadAfterDate == null ? "null" : this.DownloadAfterDate)}");
            toStringOutput.Add($"this.DownloadTimeWindowList = {(this.DownloadTimeWindowList == null ? "null" : $"[{string.Join(", ", this.DownloadTimeWindowList)} ]")}");
            toStringOutput.Add($"this.InstallAfterDate = {(this.InstallAfterDate == null ? "null" : this.InstallAfterDate)}");
            toStringOutput.Add($"this.InstallTimeWindowList = {(this.InstallTimeWindowList == null ? "null" : $"[{string.Join(", ", this.InstallTimeWindowList)} ]")}");
            toStringOutput.Add($"this.DeviceList = {(this.DeviceList == null ? "null" : $"[{string.Join(", ", this.DeviceList)} ]")}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status)}");
        }
    }
}