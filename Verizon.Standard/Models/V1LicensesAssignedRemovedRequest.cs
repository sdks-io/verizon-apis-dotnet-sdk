// <copyright file="V1LicensesAssignedRemovedRequest.cs" company="APIMatic">
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
    /// V1LicensesAssignedRemovedRequest.
    /// </summary>
    public class V1LicensesAssignedRemovedRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1LicensesAssignedRemovedRequest"/> class.
        /// </summary>
        public V1LicensesAssignedRemovedRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1LicensesAssignedRemovedRequest"/> class.
        /// </summary>
        /// <param name="deviceList">deviceList.</param>
        public V1LicensesAssignedRemovedRequest(
            List<string> deviceList)
        {
            this.DeviceList = deviceList;
        }

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

            return $"V1LicensesAssignedRemovedRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1LicensesAssignedRemovedRequest other &&                ((this.DeviceList == null && other.DeviceList == null) || (this.DeviceList?.Equals(other.DeviceList) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DeviceList = {(this.DeviceList == null ? "null" : $"[{string.Join(", ", this.DeviceList)} ]")}");
        }
    }
}