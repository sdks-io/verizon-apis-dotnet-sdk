// <copyright file="Firmware.cs" company="APIMatic">
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
    /// Firmware.
    /// </summary>
    public class Firmware
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Firmware"/> class.
        /// </summary>
        public Firmware()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Firmware"/> class.
        /// </summary>
        /// <param name="firmwareName">firmwareName.</param>
        /// <param name="participantName">participantName.</param>
        /// <param name="launchDate">launchDate.</param>
        /// <param name="releaseNote">releaseNote.</param>
        /// <param name="model">model.</param>
        /// <param name="make">make.</param>
        /// <param name="fromVersion">fromVersion.</param>
        /// <param name="toVersion">toVersion.</param>
        public Firmware(
            string firmwareName = null,
            string participantName = null,
            DateTime? launchDate = null,
            string releaseNote = null,
            string model = null,
            string make = null,
            string fromVersion = null,
            string toVersion = null)
        {
            this.FirmwareName = firmwareName;
            this.ParticipantName = participantName;
            this.LaunchDate = launchDate;
            this.ReleaseNote = releaseNote;
            this.Model = model;
            this.Make = make;
            this.FromVersion = fromVersion;
            this.ToVersion = toVersion;
        }

        /// <summary>
        /// The name of the firmware image, provided by the device manufacturer.
        /// </summary>
        [JsonProperty("firmwareName", NullValueHandling = NullValueHandling.Ignore)]
        public string FirmwareName { get; set; }

        /// <summary>
        /// Internal reference; can be ignored.
        /// </summary>
        [JsonProperty("participantName", NullValueHandling = NullValueHandling.Ignore)]
        public string ParticipantName { get; set; }

        /// <summary>
        /// The release date of the firmware image.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("launchDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LaunchDate { get; set; }

        /// <summary>
        /// Additional information about the release.
        /// </summary>
        [JsonProperty("releaseNote", NullValueHandling = NullValueHandling.Ignore)]
        public string ReleaseNote { get; set; }

        /// <summary>
        /// The device model that the firmware applies to.
        /// </summary>
        [JsonProperty("model", NullValueHandling = NullValueHandling.Ignore)]
        public string Model { get; set; }

        /// <summary>
        /// The device make that the firmware applies to.
        /// </summary>
        [JsonProperty("make", NullValueHandling = NullValueHandling.Ignore)]
        public string Make { get; set; }

        /// <summary>
        /// The firmware version that must currently be on the device to upgrade.
        /// </summary>
        [JsonProperty("fromVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string FromVersion { get; set; }

        /// <summary>
        /// The firmware version that will be on the device after an upgrade.
        /// </summary>
        [JsonProperty("toVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string ToVersion { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Firmware : ({string.Join(", ", toStringOutput)})";
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
            return obj is Firmware other &&                ((this.FirmwareName == null && other.FirmwareName == null) || (this.FirmwareName?.Equals(other.FirmwareName) == true)) &&
                ((this.ParticipantName == null && other.ParticipantName == null) || (this.ParticipantName?.Equals(other.ParticipantName) == true)) &&
                ((this.LaunchDate == null && other.LaunchDate == null) || (this.LaunchDate?.Equals(other.LaunchDate) == true)) &&
                ((this.ReleaseNote == null && other.ReleaseNote == null) || (this.ReleaseNote?.Equals(other.ReleaseNote) == true)) &&
                ((this.Model == null && other.Model == null) || (this.Model?.Equals(other.Model) == true)) &&
                ((this.Make == null && other.Make == null) || (this.Make?.Equals(other.Make) == true)) &&
                ((this.FromVersion == null && other.FromVersion == null) || (this.FromVersion?.Equals(other.FromVersion) == true)) &&
                ((this.ToVersion == null && other.ToVersion == null) || (this.ToVersion?.Equals(other.ToVersion) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.FirmwareName = {(this.FirmwareName == null ? "null" : this.FirmwareName == string.Empty ? "" : this.FirmwareName)}");
            toStringOutput.Add($"this.ParticipantName = {(this.ParticipantName == null ? "null" : this.ParticipantName == string.Empty ? "" : this.ParticipantName)}");
            toStringOutput.Add($"this.LaunchDate = {(this.LaunchDate == null ? "null" : this.LaunchDate.ToString())}");
            toStringOutput.Add($"this.ReleaseNote = {(this.ReleaseNote == null ? "null" : this.ReleaseNote == string.Empty ? "" : this.ReleaseNote)}");
            toStringOutput.Add($"this.Model = {(this.Model == null ? "null" : this.Model == string.Empty ? "" : this.Model)}");
            toStringOutput.Add($"this.Make = {(this.Make == null ? "null" : this.Make == string.Empty ? "" : this.Make)}");
            toStringOutput.Add($"this.FromVersion = {(this.FromVersion == null ? "null" : this.FromVersion == string.Empty ? "" : this.FromVersion)}");
            toStringOutput.Add($"this.ToVersion = {(this.ToVersion == null ? "null" : this.ToVersion == string.Empty ? "" : this.ToVersion)}");
        }
    }
}