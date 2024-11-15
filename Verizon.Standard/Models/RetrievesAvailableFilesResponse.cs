// <copyright file="RetrievesAvailableFilesResponse.cs" company="APIMatic">
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
    /// RetrievesAvailableFilesResponse.
    /// </summary>
    public class RetrievesAvailableFilesResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RetrievesAvailableFilesResponse"/> class.
        /// </summary>
        public RetrievesAvailableFilesResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrievesAvailableFilesResponse"/> class.
        /// </summary>
        /// <param name="fileName">fileName.</param>
        /// <param name="fileVersion">fileVersion.</param>
        /// <param name="releaseNote">releaseNote.</param>
        /// <param name="make">make.</param>
        /// <param name="model">model.</param>
        /// <param name="localTargetPath">localTargetPath.</param>
        /// <param name="distributionType">distributionType.</param>
        /// <param name="devicePlatformId">devicePlatformId.</param>
        public RetrievesAvailableFilesResponse(
            string fileName = null,
            string fileVersion = null,
            string releaseNote = null,
            string make = null,
            string model = null,
            string localTargetPath = null,
            string distributionType = null,
            string devicePlatformId = null)
        {
            this.FileName = fileName;
            this.FileVersion = fileVersion;
            this.ReleaseNote = releaseNote;
            this.Make = make;
            this.Model = model;
            this.LocalTargetPath = localTargetPath;
            this.DistributionType = distributionType;
            this.DevicePlatformId = devicePlatformId;
        }

        /// <summary>
        /// ThingSpace-generated name of the file. You will use this name when listing or scheduling campaigns for the file.
        /// </summary>
        [JsonProperty("fileName", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        /// <summary>
        /// Version of the file.
        /// </summary>
        [JsonProperty("fileVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string FileVersion { get; set; }

        /// <summary>
        /// Software release note.
        /// </summary>
        [JsonProperty("releaseNote", NullValueHandling = NullValueHandling.Ignore)]
        public string ReleaseNote { get; set; }

        /// <summary>
        /// The software-applicable device make.
        /// </summary>
        [JsonProperty("make", NullValueHandling = NullValueHandling.Ignore)]
        public string Make { get; set; }

        /// <summary>
        /// The software-applicable device model.
        /// </summary>
        [JsonProperty("model", NullValueHandling = NullValueHandling.Ignore)]
        public string Model { get; set; }

        /// <summary>
        /// Local target path on the device.
        /// </summary>
        [JsonProperty("localTargetPath", NullValueHandling = NullValueHandling.Ignore)]
        public string LocalTargetPath { get; set; }

        /// <summary>
        /// Valid values
        /// </summary>
        [JsonProperty("distributionType", NullValueHandling = NullValueHandling.Ignore)]
        public string DistributionType { get; set; }

        /// <summary>
        /// The platform (Android, iOS, etc.,) that the software can be applied to.
        /// </summary>
        [JsonProperty("devicePlatformId", NullValueHandling = NullValueHandling.Ignore)]
        public string DevicePlatformId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RetrievesAvailableFilesResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is RetrievesAvailableFilesResponse other &&                ((this.FileName == null && other.FileName == null) || (this.FileName?.Equals(other.FileName) == true)) &&
                ((this.FileVersion == null && other.FileVersion == null) || (this.FileVersion?.Equals(other.FileVersion) == true)) &&
                ((this.ReleaseNote == null && other.ReleaseNote == null) || (this.ReleaseNote?.Equals(other.ReleaseNote) == true)) &&
                ((this.Make == null && other.Make == null) || (this.Make?.Equals(other.Make) == true)) &&
                ((this.Model == null && other.Model == null) || (this.Model?.Equals(other.Model) == true)) &&
                ((this.LocalTargetPath == null && other.LocalTargetPath == null) || (this.LocalTargetPath?.Equals(other.LocalTargetPath) == true)) &&
                ((this.DistributionType == null && other.DistributionType == null) || (this.DistributionType?.Equals(other.DistributionType) == true)) &&
                ((this.DevicePlatformId == null && other.DevicePlatformId == null) || (this.DevicePlatformId?.Equals(other.DevicePlatformId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.FileName = {(this.FileName == null ? "null" : this.FileName)}");
            toStringOutput.Add($"this.FileVersion = {(this.FileVersion == null ? "null" : this.FileVersion)}");
            toStringOutput.Add($"this.ReleaseNote = {(this.ReleaseNote == null ? "null" : this.ReleaseNote)}");
            toStringOutput.Add($"this.Make = {(this.Make == null ? "null" : this.Make)}");
            toStringOutput.Add($"this.Model = {(this.Model == null ? "null" : this.Model)}");
            toStringOutput.Add($"this.LocalTargetPath = {(this.LocalTargetPath == null ? "null" : this.LocalTargetPath)}");
            toStringOutput.Add($"this.DistributionType = {(this.DistributionType == null ? "null" : this.DistributionType)}");
            toStringOutput.Add($"this.DevicePlatformId = {(this.DevicePlatformId == null ? "null" : this.DevicePlatformId)}");
        }
    }
}