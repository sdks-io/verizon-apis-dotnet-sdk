// <copyright file="UploadConfigurationFilesResponse.cs" company="APIMatic">
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
    /// UploadConfigurationFilesResponse.
    /// </summary>
    public class UploadConfigurationFilesResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadConfigurationFilesResponse"/> class.
        /// </summary>
        public UploadConfigurationFilesResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadConfigurationFilesResponse"/> class.
        /// </summary>
        /// <param name="fileName">fileName.</param>
        /// <param name="fileVersion">fileVersion.</param>
        /// <param name="launchDate">launchDate.</param>
        /// <param name="releaseNote">releaseNote.</param>
        /// <param name="model">model.</param>
        /// <param name="make">make.</param>
        /// <param name="distributionType">distributionType.</param>
        /// <param name="devicePlatformId">devicePlatformId.</param>
        /// <param name="localTargetPath">localTargetPath.</param>
        public UploadConfigurationFilesResponse(
            string fileName = null,
            string fileVersion = null,
            DateTime? launchDate = null,
            string releaseNote = null,
            string model = null,
            string make = null,
            string distributionType = null,
            string devicePlatformId = null,
            string localTargetPath = null)
        {
            this.FileName = fileName;
            this.FileVersion = fileVersion;
            this.LaunchDate = launchDate;
            this.ReleaseNote = releaseNote;
            this.Model = model;
            this.Make = make;
            this.DistributionType = distributionType;
            this.DevicePlatformId = devicePlatformId;
            this.LocalTargetPath = localTargetPath;
        }

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
        /// Software launch date.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("launchDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LaunchDate { get; set; }

        /// <summary>
        /// Software release note.
        /// </summary>
        [JsonProperty("releaseNote", NullValueHandling = NullValueHandling.Ignore)]
        public string ReleaseNote { get; set; }

        /// <summary>
        /// Software applicable device model.
        /// </summary>
        [JsonProperty("model", NullValueHandling = NullValueHandling.Ignore)]
        public string Model { get; set; }

        /// <summary>
        /// Software applicable device make.
        /// </summary>
        [JsonProperty("make", NullValueHandling = NullValueHandling.Ignore)]
        public string Make { get; set; }

        /// <summary>
        /// LWM2M, OMD-DM or HTTP.
        /// </summary>
        [JsonProperty("distributionType", NullValueHandling = NullValueHandling.Ignore)]
        public string DistributionType { get; set; }

        /// <summary>
        /// The platform (Android, iOS, etc.) that the software can be applied to.
        /// </summary>
        [JsonProperty("devicePlatformId", NullValueHandling = NullValueHandling.Ignore)]
        public string DevicePlatformId { get; set; }

        /// <summary>
        /// Local target path on the device.
        /// </summary>
        [JsonProperty("localTargetPath", NullValueHandling = NullValueHandling.Ignore)]
        public string LocalTargetPath { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UploadConfigurationFilesResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is UploadConfigurationFilesResponse other &&                ((this.FileName == null && other.FileName == null) || (this.FileName?.Equals(other.FileName) == true)) &&
                ((this.FileVersion == null && other.FileVersion == null) || (this.FileVersion?.Equals(other.FileVersion) == true)) &&
                ((this.LaunchDate == null && other.LaunchDate == null) || (this.LaunchDate?.Equals(other.LaunchDate) == true)) &&
                ((this.ReleaseNote == null && other.ReleaseNote == null) || (this.ReleaseNote?.Equals(other.ReleaseNote) == true)) &&
                ((this.Model == null && other.Model == null) || (this.Model?.Equals(other.Model) == true)) &&
                ((this.Make == null && other.Make == null) || (this.Make?.Equals(other.Make) == true)) &&
                ((this.DistributionType == null && other.DistributionType == null) || (this.DistributionType?.Equals(other.DistributionType) == true)) &&
                ((this.DevicePlatformId == null && other.DevicePlatformId == null) || (this.DevicePlatformId?.Equals(other.DevicePlatformId) == true)) &&
                ((this.LocalTargetPath == null && other.LocalTargetPath == null) || (this.LocalTargetPath?.Equals(other.LocalTargetPath) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.FileName = {(this.FileName == null ? "null" : this.FileName == string.Empty ? "" : this.FileName)}");
            toStringOutput.Add($"this.FileVersion = {(this.FileVersion == null ? "null" : this.FileVersion == string.Empty ? "" : this.FileVersion)}");
            toStringOutput.Add($"this.LaunchDate = {(this.LaunchDate == null ? "null" : this.LaunchDate.ToString())}");
            toStringOutput.Add($"this.ReleaseNote = {(this.ReleaseNote == null ? "null" : this.ReleaseNote == string.Empty ? "" : this.ReleaseNote)}");
            toStringOutput.Add($"this.Model = {(this.Model == null ? "null" : this.Model == string.Empty ? "" : this.Model)}");
            toStringOutput.Add($"this.Make = {(this.Make == null ? "null" : this.Make == string.Empty ? "" : this.Make)}");
            toStringOutput.Add($"this.DistributionType = {(this.DistributionType == null ? "null" : this.DistributionType == string.Empty ? "" : this.DistributionType)}");
            toStringOutput.Add($"this.DevicePlatformId = {(this.DevicePlatformId == null ? "null" : this.DevicePlatformId == string.Empty ? "" : this.DevicePlatformId)}");
            toStringOutput.Add($"this.LocalTargetPath = {(this.LocalTargetPath == null ? "null" : this.LocalTargetPath == string.Empty ? "" : this.LocalTargetPath)}");
        }
    }
}