// <copyright file="FirmwareUpgradeRequest.cs" company="APIMatic">
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
    /// FirmwareUpgradeRequest.
    /// </summary>
    public class FirmwareUpgradeRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FirmwareUpgradeRequest"/> class.
        /// </summary>
        public FirmwareUpgradeRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FirmwareUpgradeRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="firmwareName">firmwareName.</param>
        /// <param name="firmwareTo">firmwareTo.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="deviceList">deviceList.</param>
        public FirmwareUpgradeRequest(
            string accountName,
            string firmwareName,
            string firmwareTo,
            DateTime startDate,
            List<string> deviceList)
        {
            this.AccountName = accountName;
            this.FirmwareName = firmwareName;
            this.FirmwareTo = firmwareTo;
            this.StartDate = startDate;
            this.DeviceList = deviceList;
        }

        /// <summary>
        /// Account identifier in "##########-#####".
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// The name of the firmware image that will be used for the upgrade, from a GET /firmware response.
        /// </summary>
        [JsonProperty("firmwareName")]
        public string FirmwareName { get; set; }

        /// <summary>
        /// The name of the firmware version that will be on the devices after a successful upgrade.
        /// </summary>
        [JsonProperty("firmwareTo")]
        public string FirmwareTo { get; set; }

        /// <summary>
        /// The date that the upgrade should begin.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("startDate")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The IMEIs of the devices.
        /// </summary>
        [JsonProperty("deviceList")]
        public List<string> DeviceList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"FirmwareUpgradeRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is FirmwareUpgradeRequest other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.FirmwareName == null && other.FirmwareName == null) || (this.FirmwareName?.Equals(other.FirmwareName) == true)) &&
                ((this.FirmwareTo == null && other.FirmwareTo == null) || (this.FirmwareTo?.Equals(other.FirmwareTo) == true)) &&
                this.StartDate.Equals(other.StartDate) &&
                ((this.DeviceList == null && other.DeviceList == null) || (this.DeviceList?.Equals(other.DeviceList) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.FirmwareName = {(this.FirmwareName == null ? "null" : this.FirmwareName)}");
            toStringOutput.Add($"this.FirmwareTo = {(this.FirmwareTo == null ? "null" : this.FirmwareTo)}");
            toStringOutput.Add($"this.StartDate = {this.StartDate}");
            toStringOutput.Add($"this.DeviceList = {(this.DeviceList == null ? "null" : $"[{string.Join(", ", this.DeviceList)} ]")}");
        }
    }
}