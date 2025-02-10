// <copyright file="V3CampaignDevice.cs" company="APIMatic">
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
    /// V3CampaignDevice.
    /// </summary>
    public class V3CampaignDevice
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V3CampaignDevice"/> class.
        /// </summary>
        public V3CampaignDevice()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V3CampaignDevice"/> class.
        /// </summary>
        /// <param name="hasMoreData">hasMoreData.</param>
        /// <param name="maxPageSize">maxPageSize.</param>
        /// <param name="deviceList">deviceList.</param>
        /// <param name="totalDevice">totalDevice.</param>
        /// <param name="lastSeenDeviceId">lastSeenDeviceId.</param>
        public V3CampaignDevice(
            bool hasMoreData,
            int maxPageSize,
            List<Models.V3DeviceStatus> deviceList,
            int? totalDevice = null,
            string lastSeenDeviceId = null)
        {
            this.TotalDevice = totalDevice;
            this.HasMoreData = hasMoreData;
            this.LastSeenDeviceId = lastSeenDeviceId;
            this.MaxPageSize = maxPageSize;
            this.DeviceList = deviceList;
        }

        /// <summary>
        /// Total device count.
        /// </summary>
        [JsonProperty("totalDevice", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalDevice { get; set; }

        /// <summary>
        /// Has more report flag.
        /// </summary>
        [JsonProperty("hasMoreData")]
        public bool HasMoreData { get; set; }

        /// <summary>
        /// Device identifier.
        /// </summary>
        [JsonProperty("lastSeenDeviceId", NullValueHandling = NullValueHandling.Ignore)]
        public string LastSeenDeviceId { get; set; }

        /// <summary>
        /// Maximum page size.
        /// </summary>
        [JsonProperty("maxPageSize")]
        public int MaxPageSize { get; set; }

        /// <summary>
        /// List of devices with id in IMEI.
        /// </summary>
        [JsonProperty("deviceList")]
        public List<Models.V3DeviceStatus> DeviceList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"V3CampaignDevice : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is V3CampaignDevice other &&
                (this.TotalDevice == null && other.TotalDevice == null ||
                 this.TotalDevice?.Equals(other.TotalDevice) == true) &&
                (this.HasMoreData.Equals(other.HasMoreData)) &&
                (this.LastSeenDeviceId == null && other.LastSeenDeviceId == null ||
                 this.LastSeenDeviceId?.Equals(other.LastSeenDeviceId) == true) &&
                (this.MaxPageSize.Equals(other.MaxPageSize)) &&
                (this.DeviceList == null && other.DeviceList == null ||
                 this.DeviceList?.Equals(other.DeviceList) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"TotalDevice = {(this.TotalDevice == null ? "null" : this.TotalDevice.ToString())}");
            toStringOutput.Add($"HasMoreData = {this.HasMoreData}");
            toStringOutput.Add($"LastSeenDeviceId = {this.LastSeenDeviceId ?? "null"}");
            toStringOutput.Add($"MaxPageSize = {this.MaxPageSize}");
            toStringOutput.Add($"DeviceList = {(this.DeviceList == null ? "null" : $"[{string.Join(", ", this.DeviceList)} ]")}");
        }
    }
}