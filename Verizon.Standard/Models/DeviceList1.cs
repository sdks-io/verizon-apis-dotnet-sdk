// <copyright file="DeviceList1.cs" company="APIMatic">
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
    /// DeviceList1.
    /// </summary>
    public class DeviceList1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceList1"/> class.
        /// </summary>
        public DeviceList1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceList1"/> class.
        /// </summary>
        /// <param name="deviceIds">deviceIds.</param>
        /// <param name="ipAddress">ipAddress.</param>
        /// <param name="apn">apn.</param>
        public DeviceList1(
            List<Models.MECDeviceId> deviceIds,
            string ipAddress,
            string apn)
        {
            this.DeviceIds = deviceIds;
            this.IpAddress = ipAddress;
            this.Apn = apn;
        }

        /// <summary>
        /// Gets or sets DeviceIds.
        /// </summary>
        [JsonProperty("deviceIds")]
        public List<Models.MECDeviceId> DeviceIds { get; set; }

        /// <summary>
        /// Gets or sets IpAddress.
        /// </summary>
        [JsonProperty("ipAddress")]
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or sets Apn.
        /// </summary>
        [JsonProperty("apn")]
        public string Apn { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeviceList1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is DeviceList1 other &&                ((this.DeviceIds == null && other.DeviceIds == null) || (this.DeviceIds?.Equals(other.DeviceIds) == true)) &&
                ((this.IpAddress == null && other.IpAddress == null) || (this.IpAddress?.Equals(other.IpAddress) == true)) &&
                ((this.Apn == null && other.Apn == null) || (this.Apn?.Equals(other.Apn) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DeviceIds = {(this.DeviceIds == null ? "null" : $"[{string.Join(", ", this.DeviceIds)} ]")}");
            toStringOutput.Add($"this.IpAddress = {(this.IpAddress == null ? "null" : this.IpAddress)}");
            toStringOutput.Add($"this.Apn = {(this.Apn == null ? "null" : this.Apn)}");
        }
    }
}