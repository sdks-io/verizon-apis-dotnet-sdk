// <copyright file="FirmwareUpgradeDeviceListItem.cs" company="APIMatic">
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
    /// FirmwareUpgradeDeviceListItem.
    /// </summary>
    public class FirmwareUpgradeDeviceListItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FirmwareUpgradeDeviceListItem"/> class.
        /// </summary>
        public FirmwareUpgradeDeviceListItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FirmwareUpgradeDeviceListItem"/> class.
        /// </summary>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="status">status.</param>
        /// <param name="resultReason">resultReason.</param>
        public FirmwareUpgradeDeviceListItem(
            string deviceId = null,
            string status = null,
            string resultReason = null)
        {
            this.DeviceId = deviceId;
            this.Status = status;
            this.ResultReason = resultReason;
        }

        /// <summary>
        /// Device IMEI.
        /// </summary>
        [JsonProperty("deviceId", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceId { get; set; }

        /// <summary>
        /// The status of the upgrade for this device.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Additional details about the status. Not included when status='Request Pending.'
        /// </summary>
        [JsonProperty("resultReason", NullValueHandling = NullValueHandling.Ignore)]
        public string ResultReason { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"FirmwareUpgradeDeviceListItem : ({string.Join(", ", toStringOutput)})";
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
            return obj is FirmwareUpgradeDeviceListItem other &&                ((this.DeviceId == null && other.DeviceId == null) || (this.DeviceId?.Equals(other.DeviceId) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.ResultReason == null && other.ResultReason == null) || (this.ResultReason?.Equals(other.ResultReason) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DeviceId = {(this.DeviceId == null ? "null" : this.DeviceId == string.Empty ? "" : this.DeviceId)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.ResultReason = {(this.ResultReason == null ? "null" : this.ResultReason == string.Empty ? "" : this.ResultReason)}");
        }
    }
}