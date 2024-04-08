// <copyright file="FirmwarePackage.cs" company="APIMatic">
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
    /// FirmwarePackage.
    /// </summary>
    public class FirmwarePackage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FirmwarePackage"/> class.
        /// </summary>
        public FirmwarePackage()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FirmwarePackage"/> class.
        /// </summary>
        /// <param name="firmwareName">firmwareName.</param>
        /// <param name="firmwareFrom">firmwareFrom.</param>
        /// <param name="firmwareTo">firmwareTo.</param>
        /// <param name="launchDate">launchDate.</param>
        /// <param name="releaseNote">releaseNote.</param>
        /// <param name="model">model.</param>
        /// <param name="make">make.</param>
        /// <param name="protocol">protocol.</param>
        public FirmwarePackage(
            string firmwareName,
            string firmwareFrom,
            string firmwareTo,
            DateTime launchDate,
            string releaseNote,
            string model,
            string make,
            Models.CampaignMetaInfoProtocolEnum protocol)
        {
            this.FirmwareName = firmwareName;
            this.FirmwareFrom = firmwareFrom;
            this.FirmwareTo = firmwareTo;
            this.LaunchDate = launchDate;
            this.ReleaseNote = releaseNote;
            this.Model = model;
            this.Make = make;
            this.Protocol = protocol;
        }

        /// <summary>
        /// Firmware name.
        /// </summary>
        [JsonProperty("firmwareName")]
        public string FirmwareName { get; set; }

        /// <summary>
        /// Firmware from version.
        /// </summary>
        [JsonProperty("firmwareFrom")]
        public string FirmwareFrom { get; set; }

        /// <summary>
        /// Firmware to version.
        /// </summary>
        [JsonProperty("firmwareTo")]
        public string FirmwareTo { get; set; }

        /// <summary>
        /// Firmware launch date.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("launchDate")]
        public DateTime LaunchDate { get; set; }

        /// <summary>
        /// Firmware release note.
        /// </summary>
        [JsonProperty("releaseNote")]
        public string ReleaseNote { get; set; }

        /// <summary>
        /// Firmware applicable device model.
        /// </summary>
        [JsonProperty("model")]
        public string Model { get; set; }

        /// <summary>
        /// Firmware applicable device make.
        /// </summary>
        [JsonProperty("make")]
        public string Make { get; set; }

        /// <summary>
        /// Firmware protocol. Valid values include: LWM2M, OMD-DM.
        /// </summary>
        [JsonProperty("protocol")]
        public Models.CampaignMetaInfoProtocolEnum Protocol { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"FirmwarePackage : ({string.Join(", ", toStringOutput)})";
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
            return obj is FirmwarePackage other &&                ((this.FirmwareName == null && other.FirmwareName == null) || (this.FirmwareName?.Equals(other.FirmwareName) == true)) &&
                ((this.FirmwareFrom == null && other.FirmwareFrom == null) || (this.FirmwareFrom?.Equals(other.FirmwareFrom) == true)) &&
                ((this.FirmwareTo == null && other.FirmwareTo == null) || (this.FirmwareTo?.Equals(other.FirmwareTo) == true)) &&
                this.LaunchDate.Equals(other.LaunchDate) &&
                ((this.ReleaseNote == null && other.ReleaseNote == null) || (this.ReleaseNote?.Equals(other.ReleaseNote) == true)) &&
                ((this.Model == null && other.Model == null) || (this.Model?.Equals(other.Model) == true)) &&
                ((this.Make == null && other.Make == null) || (this.Make?.Equals(other.Make) == true)) &&
                this.Protocol.Equals(other.Protocol);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.FirmwareName = {(this.FirmwareName == null ? "null" : this.FirmwareName)}");
            toStringOutput.Add($"this.FirmwareFrom = {(this.FirmwareFrom == null ? "null" : this.FirmwareFrom)}");
            toStringOutput.Add($"this.FirmwareTo = {(this.FirmwareTo == null ? "null" : this.FirmwareTo)}");
            toStringOutput.Add($"this.LaunchDate = {this.LaunchDate}");
            toStringOutput.Add($"this.ReleaseNote = {(this.ReleaseNote == null ? "null" : this.ReleaseNote)}");
            toStringOutput.Add($"this.Model = {(this.Model == null ? "null" : this.Model)}");
            toStringOutput.Add($"this.Make = {(this.Make == null ? "null" : this.Make)}");
            toStringOutput.Add($"this.Protocol = {this.Protocol}");
        }
    }
}