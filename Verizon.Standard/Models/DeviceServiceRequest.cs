// <copyright file="DeviceServiceRequest.cs" company="APIMatic">
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
    /// DeviceServiceRequest.
    /// </summary>
    public class DeviceServiceRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceServiceRequest"/> class.
        /// </summary>
        public DeviceServiceRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceServiceRequest"/> class.
        /// </summary>
        /// <param name="imei">imei.</param>
        /// <param name="bullseyeEnable">BullseyeEnable.</param>
        public DeviceServiceRequest(
            string imei,
            bool bullseyeEnable)
        {
            this.Imei = imei;
            this.BullseyeEnable = bullseyeEnable;
        }

        /// <summary>
        /// International Mobile Equipment Identifier. The unique ID of a device.
        /// </summary>
        [JsonProperty("imei")]
        public string Imei { get; set; }

        /// <summary>
        /// Set to Enable (true) or Disable (false).
        /// </summary>
        [JsonProperty("BullseyeEnable")]
        public bool BullseyeEnable { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeviceServiceRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is DeviceServiceRequest other &&                ((this.Imei == null && other.Imei == null) || (this.Imei?.Equals(other.Imei) == true)) &&
                this.BullseyeEnable.Equals(other.BullseyeEnable);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Imei = {(this.Imei == null ? "null" : this.Imei)}");
            toStringOutput.Add($"this.BullseyeEnable = {this.BullseyeEnable}");
        }
    }
}