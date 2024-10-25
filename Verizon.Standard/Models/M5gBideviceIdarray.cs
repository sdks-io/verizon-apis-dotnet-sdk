// <copyright file="M5gBideviceIdarray.cs" company="APIMatic">
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
    /// M5gBideviceIdarray.
    /// </summary>
    public class M5gBideviceIdarray
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="M5gBideviceIdarray"/> class.
        /// </summary>
        public M5gBideviceIdarray()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="M5gBideviceIdarray"/> class.
        /// </summary>
        /// <param name="deviceId">deviceId.</param>
        public M5gBideviceIdarray(
            List<Models.M5gBideviceId1> deviceId = null)
        {
            this.DeviceId = deviceId;
        }

        /// <summary>
        /// Gets or sets DeviceId.
        /// </summary>
        [JsonProperty("deviceId", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.M5gBideviceId1> DeviceId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"M5gBideviceIdarray : ({string.Join(", ", toStringOutput)})";
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
            return obj is M5gBideviceIdarray other &&                ((this.DeviceId == null && other.DeviceId == null) || (this.DeviceId?.Equals(other.DeviceId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DeviceId = {(this.DeviceId == null ? "null" : $"[{string.Join(", ", this.DeviceId)} ]")}");
        }
    }
}