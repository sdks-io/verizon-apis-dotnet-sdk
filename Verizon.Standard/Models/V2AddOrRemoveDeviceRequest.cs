// <copyright file="V2AddOrRemoveDeviceRequest.cs" company="APIMatic">
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
    /// V2AddOrRemoveDeviceRequest.
    /// </summary>
    public class V2AddOrRemoveDeviceRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V2AddOrRemoveDeviceRequest"/> class.
        /// </summary>
        public V2AddOrRemoveDeviceRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V2AddOrRemoveDeviceRequest"/> class.
        /// </summary>
        /// <param name="type">Type.</param>
        /// <param name="deviceList">deviceList.</param>
        public V2AddOrRemoveDeviceRequest(
            string type,
            List<string> deviceList)
        {
            this.Type = type;
            this.DeviceList = deviceList;
        }

        /// <summary>
        /// Operation either 'append' or 'remove'.
        /// </summary>
        [JsonProperty("Type")]
        public string Type { get; set; }

        /// <summary>
        /// Device IMEI list.
        /// </summary>
        [JsonProperty("deviceList")]
        public List<string> DeviceList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V2AddOrRemoveDeviceRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is V2AddOrRemoveDeviceRequest other &&                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.DeviceList == null && other.DeviceList == null) || (this.DeviceList?.Equals(other.DeviceList) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
            toStringOutput.Add($"this.DeviceList = {(this.DeviceList == null ? "null" : $"[{string.Join(", ", this.DeviceList)} ]")}");
        }
    }
}