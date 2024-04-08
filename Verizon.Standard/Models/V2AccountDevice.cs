// <copyright file="V2AccountDevice.cs" company="APIMatic">
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
    /// V2AccountDevice.
    /// </summary>
    public class V2AccountDevice
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V2AccountDevice"/> class.
        /// </summary>
        public V2AccountDevice()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V2AccountDevice"/> class.
        /// </summary>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="mdn">mdn.</param>
        /// <param name="model">model.</param>
        /// <param name="make">make.</param>
        /// <param name="fotaEligible">fotaEligible.</param>
        /// <param name="appFotaEligible">appFotaEligible.</param>
        /// <param name="licenseAssigned">licenseAssigned.</param>
        /// <param name="distributionType">distributionType.</param>
        /// <param name="softwareList">softwareList.</param>
        /// <param name="createTime">createTime.</param>
        /// <param name="upgradeTime">upgradeTime.</param>
        /// <param name="updateTime">updateTime.</param>
        /// <param name="refreshTime">refreshTime.</param>
        public V2AccountDevice(
            string deviceId,
            string mdn,
            string model,
            string make,
            bool fotaEligible,
            bool appFotaEligible,
            bool licenseAssigned,
            string distributionType,
            List<Models.V2SoftwareInfo> softwareList,
            string createTime = null,
            string upgradeTime = null,
            string updateTime = null,
            string refreshTime = null)
        {
            this.DeviceId = deviceId;
            this.Mdn = mdn;
            this.Model = model;
            this.Make = make;
            this.FotaEligible = fotaEligible;
            this.AppFotaEligible = appFotaEligible;
            this.LicenseAssigned = licenseAssigned;
            this.DistributionType = distributionType;
            this.SoftwareList = softwareList;
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
        /// Device FOTA capable.
        /// </summary>
        [JsonProperty("fotaEligible")]
        public bool FotaEligible { get; set; }

        /// <summary>
        /// Device application FOTA capable.
        /// </summary>
        [JsonProperty("appFotaEligible")]
        public bool AppFotaEligible { get; set; }

        /// <summary>
        /// License assigned device.
        /// </summary>
        [JsonProperty("licenseAssigned")]
        public bool LicenseAssigned { get; set; }

        /// <summary>
        /// LWM2M, OMD-DM or HTTP.
        /// </summary>
        [JsonProperty("distributionType")]
        public string DistributionType { get; set; }

        /// <summary>
        /// List of sofware.
        /// </summary>
        [JsonProperty("softwareList")]
        public List<Models.V2SoftwareInfo> SoftwareList { get; set; }

        /// <summary>
        /// The date and time of when the device is created.
        /// </summary>
        [JsonProperty("createTime", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The date and time of when the device firmware or software is upgraded.
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

            return $"V2AccountDevice : ({string.Join(", ", toStringOutput)})";
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
            return obj is V2AccountDevice other &&                ((this.DeviceId == null && other.DeviceId == null) || (this.DeviceId?.Equals(other.DeviceId) == true)) &&
                ((this.Mdn == null && other.Mdn == null) || (this.Mdn?.Equals(other.Mdn) == true)) &&
                ((this.Model == null && other.Model == null) || (this.Model?.Equals(other.Model) == true)) &&
                ((this.Make == null && other.Make == null) || (this.Make?.Equals(other.Make) == true)) &&
                this.FotaEligible.Equals(other.FotaEligible) &&
                this.AppFotaEligible.Equals(other.AppFotaEligible) &&
                this.LicenseAssigned.Equals(other.LicenseAssigned) &&
                ((this.DistributionType == null && other.DistributionType == null) || (this.DistributionType?.Equals(other.DistributionType) == true)) &&
                ((this.SoftwareList == null && other.SoftwareList == null) || (this.SoftwareList?.Equals(other.SoftwareList) == true)) &&
                ((this.CreateTime == null && other.CreateTime == null) || (this.CreateTime?.Equals(other.CreateTime) == true)) &&
                ((this.UpgradeTime == null && other.UpgradeTime == null) || (this.UpgradeTime?.Equals(other.UpgradeTime) == true)) &&
                ((this.UpdateTime == null && other.UpdateTime == null) || (this.UpdateTime?.Equals(other.UpdateTime) == true)) &&
                ((this.RefreshTime == null && other.RefreshTime == null) || (this.RefreshTime?.Equals(other.RefreshTime) == true));
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
            toStringOutput.Add($"this.FotaEligible = {this.FotaEligible}");
            toStringOutput.Add($"this.AppFotaEligible = {this.AppFotaEligible}");
            toStringOutput.Add($"this.LicenseAssigned = {this.LicenseAssigned}");
            toStringOutput.Add($"this.DistributionType = {(this.DistributionType == null ? "null" : this.DistributionType)}");
            toStringOutput.Add($"this.SoftwareList = {(this.SoftwareList == null ? "null" : $"[{string.Join(", ", this.SoftwareList)} ]")}");
            toStringOutput.Add($"this.CreateTime = {(this.CreateTime == null ? "null" : this.CreateTime)}");
            toStringOutput.Add($"this.UpgradeTime = {(this.UpgradeTime == null ? "null" : this.UpgradeTime)}");
            toStringOutput.Add($"this.UpdateTime = {(this.UpdateTime == null ? "null" : this.UpdateTime)}");
            toStringOutput.Add($"this.RefreshTime = {(this.RefreshTime == null ? "null" : this.RefreshTime)}");
        }
    }
}