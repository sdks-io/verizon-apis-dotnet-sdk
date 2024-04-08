// <copyright file="DeviceFirmwareVersion.cs" company="APIMatic">
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
    /// DeviceFirmwareVersion.
    /// </summary>
    public class DeviceFirmwareVersion
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceFirmwareVersion"/> class.
        /// </summary>
        public DeviceFirmwareVersion()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceFirmwareVersion"/> class.
        /// </summary>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="firmwareVersion">firmwareVersion.</param>
        /// <param name="status">status.</param>
        /// <param name="reason">reason.</param>
        /// <param name="firmwareVersionUpdateTime">firmwareVersionUpdateTime.</param>
        public DeviceFirmwareVersion(
            string deviceId,
            string firmwareVersion,
            string status = null,
            string reason = null,
            DateTime? firmwareVersionUpdateTime = null)
        {
            this.Status = status;
            this.Reason = reason;
            this.DeviceId = deviceId;
            this.FirmwareVersion = firmwareVersion;
            this.FirmwareVersionUpdateTime = firmwareVersionUpdateTime;
        }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets Reason.
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <summary>
        /// Device IMEI.
        /// </summary>
        [JsonProperty("deviceId")]
        public string DeviceId { get; set; }

        /// <summary>
        /// Device Firmware Version.
        /// </summary>
        [JsonProperty("firmwareVersion")]
        public string FirmwareVersion { get; set; }

        /// <summary>
        /// Gets or sets FirmwareVersionUpdateTime.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("firmwareVersionUpdateTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FirmwareVersionUpdateTime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeviceFirmwareVersion : ({string.Join(", ", toStringOutput)})";
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
            return obj is DeviceFirmwareVersion other &&                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Reason == null && other.Reason == null) || (this.Reason?.Equals(other.Reason) == true)) &&
                ((this.DeviceId == null && other.DeviceId == null) || (this.DeviceId?.Equals(other.DeviceId) == true)) &&
                ((this.FirmwareVersion == null && other.FirmwareVersion == null) || (this.FirmwareVersion?.Equals(other.FirmwareVersion) == true)) &&
                ((this.FirmwareVersionUpdateTime == null && other.FirmwareVersionUpdateTime == null) || (this.FirmwareVersionUpdateTime?.Equals(other.FirmwareVersionUpdateTime) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status)}");
            toStringOutput.Add($"this.Reason = {(this.Reason == null ? "null" : this.Reason)}");
            toStringOutput.Add($"this.DeviceId = {(this.DeviceId == null ? "null" : this.DeviceId)}");
            toStringOutput.Add($"this.FirmwareVersion = {(this.FirmwareVersion == null ? "null" : this.FirmwareVersion)}");
            toStringOutput.Add($"this.FirmwareVersionUpdateTime = {(this.FirmwareVersionUpdateTime == null ? "null" : this.FirmwareVersionUpdateTime.ToString())}");
        }
    }
}