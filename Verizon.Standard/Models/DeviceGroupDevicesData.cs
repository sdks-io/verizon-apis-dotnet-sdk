// <copyright file="DeviceGroupDevicesData.cs" company="APIMatic">
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
    /// DeviceGroupDevicesData.
    /// </summary>
    public class DeviceGroupDevicesData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceGroupDevicesData"/> class.
        /// </summary>
        public DeviceGroupDevicesData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceGroupDevicesData"/> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="devices">devices.</param>
        /// <param name="hasMoreData">hasMoreData.</param>
        /// <param name="name">name.</param>
        public DeviceGroupDevicesData(
            string description = null,
            List<Models.AccountDeviceList> devices = null,
            bool? hasMoreData = null,
            string name = null)
        {
            this.Description = description;
            this.Devices = devices;
            this.HasMoreData = hasMoreData;
            this.Name = name;
        }

        /// <summary>
        /// The description of the device group.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// The devices in the device group.
        /// </summary>
        [JsonProperty("devices", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.AccountDeviceList> Devices { get; set; }

        /// <summary>
        /// False for a status 200 response.True for a status 202 response, indicating that there is more data to be retrieved.
        /// </summary>
        [JsonProperty("hasMoreData", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasMoreData { get; set; }

        /// <summary>
        /// The name of the device group.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DeviceGroupDevicesData : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DeviceGroupDevicesData other &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.Devices == null && other.Devices == null ||
                 this.Devices?.Equals(other.Devices) == true) &&
                (this.HasMoreData == null && other.HasMoreData == null ||
                 this.HasMoreData?.Equals(other.HasMoreData) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"Devices = {(this.Devices == null ? "null" : $"[{string.Join(", ", this.Devices)} ]")}");
            toStringOutput.Add($"HasMoreData = {(this.HasMoreData == null ? "null" : this.HasMoreData.ToString())}");
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
        }
    }
}