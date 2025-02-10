// <copyright file="DeviceListIP.cs" company="APIMatic">
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
    /// DeviceListIP.
    /// </summary>
    public class DeviceListIP
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceListIP"/> class.
        /// </summary>
        public DeviceListIP()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceListIP"/> class.
        /// </summary>
        /// <param name="deviceIds">deviceIds.</param>
        /// <param name="ipaddress">ipAddress.</param>
        public DeviceListIP(
            List<Models.PWNDeviceId> deviceIds,
            string ipaddress)
        {
            this.DeviceIds = deviceIds;
            this.Ipaddress = ipaddress;
        }

        /// <summary>
        /// Gets or sets DeviceIds.
        /// </summary>
        [JsonProperty("deviceIds")]
        public List<Models.PWNDeviceId> DeviceIds { get; set; }

        /// <summary>
        /// Gets or sets Ipaddress.
        /// </summary>
        [JsonProperty("ipAddress")]
        public string Ipaddress { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DeviceListIP : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DeviceListIP other &&
                (this.DeviceIds == null && other.DeviceIds == null ||
                 this.DeviceIds?.Equals(other.DeviceIds) == true) &&
                (this.Ipaddress == null && other.Ipaddress == null ||
                 this.Ipaddress?.Equals(other.Ipaddress) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"DeviceIds = {(this.DeviceIds == null ? "null" : $"[{string.Join(", ", this.DeviceIds)} ]")}");
            toStringOutput.Add($"Ipaddress = {this.Ipaddress ?? "null"}");
        }
    }
}