// <copyright file="AccountDeviceList.cs" company="APIMatic">
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
    /// AccountDeviceList.
    /// </summary>
    public class AccountDeviceList
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDeviceList"/> class.
        /// </summary>
        public AccountDeviceList()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDeviceList"/> class.
        /// </summary>
        /// <param name="deviceIds">deviceIds.</param>
        /// <param name="ipAddress">ipAddress.</param>
        public AccountDeviceList(
            List<Models.DeviceId> deviceIds,
            string ipAddress = null)
        {
            this.DeviceIds = deviceIds;
            this.IpAddress = ipAddress;
        }

        /// <summary>
        /// All identifiers for the device.
        /// </summary>
        [JsonProperty("deviceIds")]
        public List<Models.DeviceId> DeviceIds { get; set; }

        /// <summary>
        /// Gets or sets IpAddress.
        /// </summary>
        [JsonProperty("ipAddress", NullValueHandling = NullValueHandling.Ignore)]
        public string IpAddress { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AccountDeviceList : ({string.Join(", ", toStringOutput)})";
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
            return obj is AccountDeviceList other &&                ((this.DeviceIds == null && other.DeviceIds == null) || (this.DeviceIds?.Equals(other.DeviceIds) == true)) &&
                ((this.IpAddress == null && other.IpAddress == null) || (this.IpAddress?.Equals(other.IpAddress) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DeviceIds = {(this.DeviceIds == null ? "null" : $"[{string.Join(", ", this.DeviceIds)} ]")}");
            toStringOutput.Add($"this.IpAddress = {(this.IpAddress == null ? "null" : this.IpAddress)}");
        }
    }
}