// <copyright file="SoftwarePackage.cs" company="APIMatic">
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
    /// SoftwarePackage.
    /// </summary>
    public class SoftwarePackage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoftwarePackage"/> class.
        /// </summary>
        public SoftwarePackage()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SoftwarePackage"/> class.
        /// </summary>
        /// <param name="softwareName">softwareName.</param>
        /// <param name="launchDate">launchDate.</param>
        /// <param name="model">model.</param>
        /// <param name="make">make.</param>
        /// <param name="distributionType">distributionType.</param>
        /// <param name="devicePlatformId">devicePlatformId.</param>
        /// <param name="releaseNote">releaseNote.</param>
        public SoftwarePackage(
            string softwareName,
            DateTime launchDate,
            string model,
            string make,
            string distributionType,
            string devicePlatformId,
            string releaseNote = null)
        {
            this.SoftwareName = softwareName;
            this.LaunchDate = launchDate;
            this.ReleaseNote = releaseNote;
            this.Model = model;
            this.Make = make;
            this.DistributionType = distributionType;
            this.DevicePlatformId = devicePlatformId;
        }

        /// <summary>
        /// Software name.
        /// </summary>
        [JsonProperty("softwareName")]
        public string SoftwareName { get; set; }

        /// <summary>
        /// Software launch date.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("launchDate")]
        public DateTime LaunchDate { get; set; }

        /// <summary>
        /// Software release note reserved for future use.
        /// </summary>
        [JsonProperty("releaseNote", NullValueHandling = NullValueHandling.Ignore)]
        public string ReleaseNote { get; set; }

        /// <summary>
        /// Software applicable device model.
        /// </summary>
        [JsonProperty("model")]
        public string Model { get; set; }

        /// <summary>
        /// Software applicable device make.
        /// </summary>
        [JsonProperty("make")]
        public string Make { get; set; }

        /// <summary>
        /// LWM2M, OMD-DM or HTTP.
        /// </summary>
        [JsonProperty("distributionType")]
        public string DistributionType { get; set; }

        /// <summary>
        /// The platform (Android, iOS, etc.) that the software can be applied to.
        /// </summary>
        [JsonProperty("devicePlatformId")]
        public string DevicePlatformId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SoftwarePackage : ({string.Join(", ", toStringOutput)})";
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
            return obj is SoftwarePackage other &&                ((this.SoftwareName == null && other.SoftwareName == null) || (this.SoftwareName?.Equals(other.SoftwareName) == true)) &&
                this.LaunchDate.Equals(other.LaunchDate) &&
                ((this.ReleaseNote == null && other.ReleaseNote == null) || (this.ReleaseNote?.Equals(other.ReleaseNote) == true)) &&
                ((this.Model == null && other.Model == null) || (this.Model?.Equals(other.Model) == true)) &&
                ((this.Make == null && other.Make == null) || (this.Make?.Equals(other.Make) == true)) &&
                ((this.DistributionType == null && other.DistributionType == null) || (this.DistributionType?.Equals(other.DistributionType) == true)) &&
                ((this.DevicePlatformId == null && other.DevicePlatformId == null) || (this.DevicePlatformId?.Equals(other.DevicePlatformId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SoftwareName = {(this.SoftwareName == null ? "null" : this.SoftwareName)}");
            toStringOutput.Add($"this.LaunchDate = {this.LaunchDate}");
            toStringOutput.Add($"this.ReleaseNote = {(this.ReleaseNote == null ? "null" : this.ReleaseNote)}");
            toStringOutput.Add($"this.Model = {(this.Model == null ? "null" : this.Model)}");
            toStringOutput.Add($"this.Make = {(this.Make == null ? "null" : this.Make)}");
            toStringOutput.Add($"this.DistributionType = {(this.DistributionType == null ? "null" : this.DistributionType)}");
            toStringOutput.Add($"this.DevicePlatformId = {(this.DevicePlatformId == null ? "null" : this.DevicePlatformId)}");
        }
    }
}