// <copyright file="DeviceLoggingRequest.cs" company="APIMatic">
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
    /// DeviceLoggingRequest.
    /// </summary>
    public class DeviceLoggingRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceLoggingRequest"/> class.
        /// </summary>
        public DeviceLoggingRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceLoggingRequest"/> class.
        /// </summary>
        /// <param name="deviceIds">deviceIds.</param>
        public DeviceLoggingRequest(
            List<string> deviceIds)
        {
            this.DeviceIds = deviceIds;
        }

        /// <summary>
        /// List of device IMEI identifiers.
        /// </summary>
        [JsonProperty("deviceIds")]
        public List<string> DeviceIds { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeviceLoggingRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is DeviceLoggingRequest other &&                ((this.DeviceIds == null && other.DeviceIds == null) || (this.DeviceIds?.Equals(other.DeviceIds) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DeviceIds = {(this.DeviceIds == null ? "null" : $"[{string.Join(", ", this.DeviceIds)} ]")}");
        }
    }
}