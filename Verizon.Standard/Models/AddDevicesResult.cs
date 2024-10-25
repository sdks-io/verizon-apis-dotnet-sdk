// <copyright file="AddDevicesResult.cs" company="APIMatic">
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
    /// AddDevicesResult.
    /// </summary>
    public class AddDevicesResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddDevicesResult"/> class.
        /// </summary>
        public AddDevicesResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddDevicesResult"/> class.
        /// </summary>
        /// <param name="deviceIds">deviceIds.</param>
        /// <param name="response">response.</param>
        public AddDevicesResult(
            List<Models.DeviceId> deviceIds = null,
            string response = null)
        {
            this.DeviceIds = deviceIds;
            this.Response = response;
        }

        /// <summary>
        /// Identifiers for the device.
        /// </summary>
        [JsonProperty("deviceIds", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DeviceId> DeviceIds { get; set; }

        /// <summary>
        /// The success message or error message for the current device.
        /// </summary>
        [JsonProperty("response", NullValueHandling = NullValueHandling.Ignore)]
        public string Response { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AddDevicesResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is AddDevicesResult other &&                ((this.DeviceIds == null && other.DeviceIds == null) || (this.DeviceIds?.Equals(other.DeviceIds) == true)) &&
                ((this.Response == null && other.Response == null) || (this.Response?.Equals(other.Response) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DeviceIds = {(this.DeviceIds == null ? "null" : $"[{string.Join(", ", this.DeviceIds)} ]")}");
            toStringOutput.Add($"this.Response = {(this.Response == null ? "null" : this.Response)}");
        }
    }
}