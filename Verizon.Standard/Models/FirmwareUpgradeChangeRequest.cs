// <copyright file="FirmwareUpgradeChangeRequest.cs" company="APIMatic">
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
    /// FirmwareUpgradeChangeRequest.
    /// </summary>
    public class FirmwareUpgradeChangeRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FirmwareUpgradeChangeRequest"/> class.
        /// </summary>
        public FirmwareUpgradeChangeRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FirmwareUpgradeChangeRequest"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="deviceList">deviceList.</param>
        public FirmwareUpgradeChangeRequest(
            Models.FirmwareTypeListEnum type,
            List<string> deviceList)
        {
            this.Type = type;
            this.DeviceList = deviceList;
        }

        /// <summary>
        /// Possible values are `append` or `remove`
        /// </summary>
        [JsonProperty("type")]
        public Models.FirmwareTypeListEnum Type { get; set; }

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
            return $"FirmwareUpgradeChangeRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is FirmwareUpgradeChangeRequest other &&
                (this.Type.Equals(other.Type)) &&
                (this.DeviceList == null && other.DeviceList == null ||
                 this.DeviceList?.Equals(other.DeviceList) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Type = {this.Type}");
            toStringOutput.Add($"DeviceList = {(this.DeviceList == null ? "null" : $"[{string.Join(", ", this.DeviceList)} ]")}");
        }
    }
}