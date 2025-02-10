// <copyright file="V1ListOfLicensesToRemoveRequest.cs" company="APIMatic">
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
    /// V1ListOfLicensesToRemoveRequest.
    /// </summary>
    public class V1ListOfLicensesToRemoveRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1ListOfLicensesToRemoveRequest"/> class.
        /// </summary>
        public V1ListOfLicensesToRemoveRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ListOfLicensesToRemoveRequest"/> class.
        /// </summary>
        /// <param name="deviceList">deviceList.</param>
        /// <param name="type">type.</param>
        public V1ListOfLicensesToRemoveRequest(
            List<string> deviceList,
            string type = null)
        {
            this.Type = type;
            this.DeviceList = deviceList;
        }

        /// <summary>
        /// Set to 'append' to append the devices in the current request to the existing list. If there is no existing list then it will be created with only these devices. Leave this parameter out when you want to replace the existing list with the devices in the current request.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// The IMEIs of the devices.
        /// </summary>
        [JsonProperty("deviceList")]
        public List<string> DeviceList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"V1ListOfLicensesToRemoveRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is V1ListOfLicensesToRemoveRequest other &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true) &&
                (this.DeviceList == null && other.DeviceList == null ||
                 this.DeviceList?.Equals(other.DeviceList) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Type = {this.Type ?? "null"}");
            toStringOutput.Add($"DeviceList = {(this.DeviceList == null ? "null" : $"[{string.Join(", ", this.DeviceList)} ]")}");
        }
    }
}