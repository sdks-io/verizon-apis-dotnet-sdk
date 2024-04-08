// <copyright file="DeviceListQueryItem.cs" company="APIMatic">
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
    /// DeviceListQueryItem.
    /// </summary>
    public class DeviceListQueryItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceListQueryItem"/> class.
        /// </summary>
        public DeviceListQueryItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceListQueryItem"/> class.
        /// </summary>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="mdn">mdn.</param>
        /// <param name="model">model.</param>
        /// <param name="make">make.</param>
        /// <param name="firmware">firmware.</param>
        /// <param name="fotaEligible">fotaEligible.</param>
        /// <param name="licenseAssigned">licenseAssigned.</param>
        /// <param name="upgradeTime">upgradeTime.</param>
        public DeviceListQueryItem(
            string deviceId = null,
            string mdn = null,
            string model = null,
            string make = null,
            string firmware = null,
            bool? fotaEligible = null,
            bool? licenseAssigned = null,
            string upgradeTime = null)
        {
            this.DeviceId = deviceId;
            this.Mdn = mdn;
            this.Model = model;
            this.Make = make;
            this.Firmware = firmware;
            this.FotaEligible = fotaEligible;
            this.LicenseAssigned = licenseAssigned;
            this.UpgradeTime = upgradeTime;
        }

        /// <summary>
        /// Device IMEI.
        /// </summary>
        [JsonProperty("deviceId", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceId { get; set; }

        /// <summary>
        /// The MDN (phone number) of the device.
        /// </summary>
        [JsonProperty("mdn", NullValueHandling = NullValueHandling.Ignore)]
        public string Mdn { get; set; }

        /// <summary>
        /// The device model name.
        /// </summary>
        [JsonProperty("model", NullValueHandling = NullValueHandling.Ignore)]
        public string Model { get; set; }

        /// <summary>
        /// The device make.
        /// </summary>
        [JsonProperty("make", NullValueHandling = NullValueHandling.Ignore)]
        public string Make { get; set; }

        /// <summary>
        /// The name of the firmware image currently installed on the device.
        /// </summary>
        [JsonProperty("firmware", NullValueHandling = NullValueHandling.Ignore)]
        public string Firmware { get; set; }

        /// <summary>
        /// True if the device firmware can be upgraded over the air using the Software Management Services API.
        /// </summary>
        [JsonProperty("fotaEligible", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FotaEligible { get; set; }

        /// <summary>
        /// True if an MRC license has been assigned to this device.
        /// </summary>
        [JsonProperty("licenseAssigned", NullValueHandling = NullValueHandling.Ignore)]
        public bool? LicenseAssigned { get; set; }

        /// <summary>
        /// The date and time that the device firmware was last upgraded. If a device has never been upgraded, the upgradeTime will be 01/01/1900 0:0:0.
        /// </summary>
        [JsonProperty("upgradeTime", NullValueHandling = NullValueHandling.Ignore)]
        public string UpgradeTime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeviceListQueryItem : ({string.Join(", ", toStringOutput)})";
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
            return obj is DeviceListQueryItem other &&                ((this.DeviceId == null && other.DeviceId == null) || (this.DeviceId?.Equals(other.DeviceId) == true)) &&
                ((this.Mdn == null && other.Mdn == null) || (this.Mdn?.Equals(other.Mdn) == true)) &&
                ((this.Model == null && other.Model == null) || (this.Model?.Equals(other.Model) == true)) &&
                ((this.Make == null && other.Make == null) || (this.Make?.Equals(other.Make) == true)) &&
                ((this.Firmware == null && other.Firmware == null) || (this.Firmware?.Equals(other.Firmware) == true)) &&
                ((this.FotaEligible == null && other.FotaEligible == null) || (this.FotaEligible?.Equals(other.FotaEligible) == true)) &&
                ((this.LicenseAssigned == null && other.LicenseAssigned == null) || (this.LicenseAssigned?.Equals(other.LicenseAssigned) == true)) &&
                ((this.UpgradeTime == null && other.UpgradeTime == null) || (this.UpgradeTime?.Equals(other.UpgradeTime) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DeviceId = {(this.DeviceId == null ? "null" : this.DeviceId)}");
            toStringOutput.Add($"this.Mdn = {(this.Mdn == null ? "null" : this.Mdn)}");
            toStringOutput.Add($"this.Model = {(this.Model == null ? "null" : this.Model)}");
            toStringOutput.Add($"this.Make = {(this.Make == null ? "null" : this.Make)}");
            toStringOutput.Add($"this.Firmware = {(this.Firmware == null ? "null" : this.Firmware)}");
            toStringOutput.Add($"this.FotaEligible = {(this.FotaEligible == null ? "null" : this.FotaEligible.ToString())}");
            toStringOutput.Add($"this.LicenseAssigned = {(this.LicenseAssigned == null ? "null" : this.LicenseAssigned.ToString())}");
            toStringOutput.Add($"this.UpgradeTime = {(this.UpgradeTime == null ? "null" : this.UpgradeTime)}");
        }
    }
}