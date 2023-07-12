// <copyright file="DeviceLoggingStatus.cs" company="APIMatic">
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
    /// DeviceLoggingStatus.
    /// </summary>
    public class DeviceLoggingStatus
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceLoggingStatus"/> class.
        /// </summary>
        public DeviceLoggingStatus()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceLoggingStatus"/> class.
        /// </summary>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="expiryDate">expiryDate.</param>
        public DeviceLoggingStatus(
            string deviceId,
            DateTime expiryDate)
        {
            this.DeviceId = deviceId;
            this.ExpiryDate = expiryDate;
        }

        /// <summary>
        /// Device IMEI.
        /// </summary>
        [JsonProperty("deviceId")]
        public string DeviceId { get; set; }

        /// <summary>
        /// The date when device logging expires.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("expiryDate")]
        public DateTime ExpiryDate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeviceLoggingStatus : ({string.Join(", ", toStringOutput)})";
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
            return obj is DeviceLoggingStatus other &&                ((this.DeviceId == null && other.DeviceId == null) || (this.DeviceId?.Equals(other.DeviceId) == true)) &&
                this.ExpiryDate.Equals(other.ExpiryDate);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DeviceId = {(this.DeviceId == null ? "null" : this.DeviceId == string.Empty ? "" : this.DeviceId)}");
            toStringOutput.Add($"this.ExpiryDate = {this.ExpiryDate}");
        }
    }
}