// <copyright file="PWNDeviceList.cs" company="APIMatic">
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
    /// PWNDeviceList.
    /// </summary>
    public class PWNDeviceList
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PWNDeviceList"/> class.
        /// </summary>
        public PWNDeviceList()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PWNDeviceList"/> class.
        /// </summary>
        /// <param name="deviceIds">deviceIds.</param>
        public PWNDeviceList(
            List<Models.PWNDeviceId> deviceIds)
        {
            this.DeviceIds = deviceIds;
        }

        /// <summary>
        /// Gets or sets DeviceIds.
        /// </summary>
        [JsonProperty("deviceIds")]
        public List<Models.PWNDeviceId> DeviceIds { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PWNDeviceList : ({string.Join(", ", toStringOutput)})";
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
            return obj is PWNDeviceList other &&                ((this.DeviceIds == null && other.DeviceIds == null) || (this.DeviceIds?.Equals(other.DeviceIds) == true));
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