// <copyright file="V2ListOfLicensesToRemoveRequest.cs" company="APIMatic">
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
    /// V2ListOfLicensesToRemoveRequest.
    /// </summary>
    public class V2ListOfLicensesToRemoveRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V2ListOfLicensesToRemoveRequest"/> class.
        /// </summary>
        public V2ListOfLicensesToRemoveRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V2ListOfLicensesToRemoveRequest"/> class.
        /// </summary>
        /// <param name="deviceList">deviceList.</param>
        /// <param name="type">type.</param>
        /// <param name="count">count.</param>
        public V2ListOfLicensesToRemoveRequest(
            List<string> deviceList,
            string type = null,
            int? count = null)
        {
            this.Type = type;
            this.Count = count;
            this.DeviceList = deviceList;
        }

        /// <summary>
        /// List creation option.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// The number of devices.
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

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

            return $"V2ListOfLicensesToRemoveRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is V2ListOfLicensesToRemoveRequest other &&                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Count == null && other.Count == null) || (this.Count?.Equals(other.Count) == true)) &&
                ((this.DeviceList == null && other.DeviceList == null) || (this.DeviceList?.Equals(other.DeviceList) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.Count = {(this.Count == null ? "null" : this.Count.ToString())}");
            toStringOutput.Add($"this.DeviceList = {(this.DeviceList == null ? "null" : $"[{string.Join(", ", this.DeviceList)} ]")}");
        }
    }
}