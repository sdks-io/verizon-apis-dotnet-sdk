// <copyright file="V3AccountDevice.cs" company="APIMatic">
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
    /// V3AccountDevice.
    /// </summary>
    public class V3AccountDevice
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V3AccountDevice"/> class.
        /// </summary>
        public V3AccountDevice()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V3AccountDevice"/> class.
        /// </summary>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="mdn">mdn.</param>
        /// <param name="model">model.</param>
        /// <param name="make">make.</param>
        /// <param name="firmware">firmware.</param>
        /// <param name="fotaEligible">fotaEligible.</param>
        /// <param name="status">status.</param>
        /// <param name="licenseAssigned">licenseAssigned.</param>
        /// <param name="protocol">protocol.</param>
        /// <param name="softwareList">softwareList.</param>
        /// <param name="fileList">fileList.</param>
        /// <param name="createTime">createTime.</param>
        /// <param name="upgradeTime">upgradeTime.</param>
        /// <param name="updateTime">updateTime.</param>
        /// <param name="refreshTime">refreshTime.</param>
        public V3AccountDevice(
            string deviceId,
            string mdn,
            string model,
            string make,
            string firmware,
            bool fotaEligible,
            string status,
            bool licenseAssigned,
            string protocol,
            List<Models.V3SoftwareInfo> softwareList,
            List<Models.V3SoftwareInfo> fileList = null,
            string createTime = null,
            string upgradeTime = null,
            string updateTime = null,
            string refreshTime = null)
        {
            this.DeviceId = deviceId;
            this.Mdn = mdn;
            this.Model = model;
            this.Make = make;
            this.Firmware = firmware;
            this.FotaEligible = fotaEligible;
            this.Status = status;
            this.LicenseAssigned = licenseAssigned;
            this.Protocol = protocol;
            this.SoftwareList = softwareList;
            this.FileList = fileList;
            this.CreateTime = createTime;
            this.UpgradeTime = upgradeTime;
            this.UpdateTime = updateTime;
            this.RefreshTime = refreshTime;
        }

        /// <summary>
        /// Device identifier.
        /// </summary>
        [JsonProperty("deviceId")]
        public string DeviceId { get; set; }

        /// <summary>
        /// MDN.
        /// </summary>
        [JsonProperty("mdn")]
        public string Mdn { get; set; }

        /// <summary>
        /// Device model.
        /// </summary>
        [JsonProperty("model")]
        public string Model { get; set; }

        /// <summary>
        /// Device make.
        /// </summary>
        [JsonProperty("make")]
        public string Make { get; set; }

        /// <summary>
        /// Device firmware version.
        /// </summary>
        [JsonProperty("firmware")]
        public string Firmware { get; set; }

        /// <summary>
        /// Value=true if the device software can be upgraded over the air using the Software Management Services API.
        /// </summary>
        [JsonProperty("fotaEligible")]
        public bool FotaEligible { get; set; }

        /// <summary>
        /// Device status.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// License assigned device.
        /// </summary>
        [JsonProperty("licenseAssigned")]
        public bool LicenseAssigned { get; set; }

        /// <summary>
        /// Firmware protocol. Valid values include: LWM2M, OMADM, HTTP or NONE.
        /// </summary>
        [JsonProperty("protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// List of sofware.
        /// </summary>
        [JsonProperty("softwareList")]
        public List<Models.V3SoftwareInfo> SoftwareList { get; set; }

        /// <summary>
        /// List of files.
        /// </summary>
        [JsonProperty("fileList", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.V3SoftwareInfo> FileList { get; set; }

        /// <summary>
        /// The date and time of when the device is created.
        /// </summary>
        [JsonProperty("createTime", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The date and time of when the device firmware or software is updated.
        /// </summary>
        [JsonProperty("upgradeTime", NullValueHandling = NullValueHandling.Ignore)]
        public string UpgradeTime { get; set; }

        /// <summary>
        /// The date and time of when the device is updated.
        /// </summary>
        [JsonProperty("updateTime", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// The date and time of when the device is refreshed.
        /// </summary>
        [JsonProperty("refreshTime", NullValueHandling = NullValueHandling.Ignore)]
        public string RefreshTime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"V3AccountDevice : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is V3AccountDevice other &&
                (this.DeviceId == null && other.DeviceId == null ||
                 this.DeviceId?.Equals(other.DeviceId) == true) &&
                (this.Mdn == null && other.Mdn == null ||
                 this.Mdn?.Equals(other.Mdn) == true) &&
                (this.Model == null && other.Model == null ||
                 this.Model?.Equals(other.Model) == true) &&
                (this.Make == null && other.Make == null ||
                 this.Make?.Equals(other.Make) == true) &&
                (this.Firmware == null && other.Firmware == null ||
                 this.Firmware?.Equals(other.Firmware) == true) &&
                (this.FotaEligible.Equals(other.FotaEligible)) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.LicenseAssigned.Equals(other.LicenseAssigned)) &&
                (this.Protocol == null && other.Protocol == null ||
                 this.Protocol?.Equals(other.Protocol) == true) &&
                (this.SoftwareList == null && other.SoftwareList == null ||
                 this.SoftwareList?.Equals(other.SoftwareList) == true) &&
                (this.FileList == null && other.FileList == null ||
                 this.FileList?.Equals(other.FileList) == true) &&
                (this.CreateTime == null && other.CreateTime == null ||
                 this.CreateTime?.Equals(other.CreateTime) == true) &&
                (this.UpgradeTime == null && other.UpgradeTime == null ||
                 this.UpgradeTime?.Equals(other.UpgradeTime) == true) &&
                (this.UpdateTime == null && other.UpdateTime == null ||
                 this.UpdateTime?.Equals(other.UpdateTime) == true) &&
                (this.RefreshTime == null && other.RefreshTime == null ||
                 this.RefreshTime?.Equals(other.RefreshTime) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"DeviceId = {this.DeviceId ?? "null"}");
            toStringOutput.Add($"Mdn = {this.Mdn ?? "null"}");
            toStringOutput.Add($"Model = {this.Model ?? "null"}");
            toStringOutput.Add($"Make = {this.Make ?? "null"}");
            toStringOutput.Add($"Firmware = {this.Firmware ?? "null"}");
            toStringOutput.Add($"FotaEligible = {this.FotaEligible}");
            toStringOutput.Add($"Status = {this.Status ?? "null"}");
            toStringOutput.Add($"LicenseAssigned = {this.LicenseAssigned}");
            toStringOutput.Add($"Protocol = {this.Protocol ?? "null"}");
            toStringOutput.Add($"SoftwareList = {(this.SoftwareList == null ? "null" : $"[{string.Join(", ", this.SoftwareList)} ]")}");
            toStringOutput.Add($"FileList = {(this.FileList == null ? "null" : $"[{string.Join(", ", this.FileList)} ]")}");
            toStringOutput.Add($"CreateTime = {this.CreateTime ?? "null"}");
            toStringOutput.Add($"UpgradeTime = {this.UpgradeTime ?? "null"}");
            toStringOutput.Add($"UpdateTime = {this.UpdateTime ?? "null"}");
            toStringOutput.Add($"RefreshTime = {this.RefreshTime ?? "null"}");
        }
    }
}