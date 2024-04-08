// <copyright file="LicenseDeviceList.cs" company="APIMatic">
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
    /// LicenseDeviceList.
    /// </summary>
    public class LicenseDeviceList
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseDeviceList"/> class.
        /// </summary>
        public LicenseDeviceList()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseDeviceList"/> class.
        /// </summary>
        /// <param name="deviceIds">deviceIds.</param>
        /// <param name="ipAddress">ipAddress.</param>
        public LicenseDeviceList(
            List<Models.LicenseDeviceId> deviceIds = null,
            string ipAddress = null)
        {
            this.DeviceIds = deviceIds;
            this.IpAddress = ipAddress;
        }

        /// <summary>
        /// For 4G devices, IMEI (decimal, up to 15 digits).
        /// </summary>
        [JsonProperty("deviceIds", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.LicenseDeviceId> DeviceIds { get; set; }

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

            return $"LicenseDeviceList : ({string.Join(", ", toStringOutput)})";
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
            return obj is LicenseDeviceList other &&                ((this.DeviceIds == null && other.DeviceIds == null) || (this.DeviceIds?.Equals(other.DeviceIds) == true)) &&
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