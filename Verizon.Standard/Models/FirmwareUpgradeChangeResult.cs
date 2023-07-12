// <copyright file="FirmwareUpgradeChangeResult.cs" company="APIMatic">
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
    /// FirmwareUpgradeChangeResult.
    /// </summary>
    public class FirmwareUpgradeChangeResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FirmwareUpgradeChangeResult"/> class.
        /// </summary>
        public FirmwareUpgradeChangeResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FirmwareUpgradeChangeResult"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="id">id.</param>
        /// <param name="deviceList">deviceList.</param>
        public FirmwareUpgradeChangeResult(
            string accountName = null,
            string id = null,
            List<Models.V1DeviceListItem> deviceList = null)
        {
            this.AccountName = accountName;
            this.Id = id;
            this.DeviceList = deviceList;
        }

        /// <summary>
        /// Account identifier in "##########-#####".
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// The unique identifier for this upgrade.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// A JSON object for each device that was included in the request, showing the device IMEI, the status of the addition or removal, and additional information about the status.
        /// </summary>
        [JsonProperty("deviceList", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.V1DeviceListItem> DeviceList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"FirmwareUpgradeChangeResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is FirmwareUpgradeChangeResult other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.DeviceList == null && other.DeviceList == null) || (this.DeviceList?.Equals(other.DeviceList) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName == string.Empty ? "" : this.AccountName)}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.DeviceList = {(this.DeviceList == null ? "null" : $"[{string.Join(", ", this.DeviceList)} ]")}");
        }
    }
}