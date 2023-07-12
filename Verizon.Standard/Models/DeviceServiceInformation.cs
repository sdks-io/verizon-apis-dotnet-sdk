// <copyright file="DeviceServiceInformation.cs" company="APIMatic">
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
    /// DeviceServiceInformation.
    /// </summary>
    public class DeviceServiceInformation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceServiceInformation"/> class.
        /// </summary>
        public DeviceServiceInformation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceServiceInformation"/> class.
        /// </summary>
        /// <param name="imei">imei.</param>
        /// <param name="bullseyeEnable">BullseyeEnable.</param>
        /// <param name="responseType">responseType.</param>
        public DeviceServiceInformation(
            string imei,
            bool bullseyeEnable,
            Models.ApiResponseCode responseType = null)
        {
            this.ResponseType = responseType;
            this.Imei = imei;
            this.BullseyeEnable = bullseyeEnable;
        }

        /// <summary>
        /// ResponseCode and/or a message indicating success or failure of the request.
        /// </summary>
        [JsonProperty("responseType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ApiResponseCode ResponseType { get; set; }

        /// <summary>
        /// The International Mobile Equipment Identifier of the device.
        /// </summary>
        [JsonProperty("imei")]
        public string Imei { get; set; }

        /// <summary>
        /// Shows if Hyper Precise is enabled (true) or disabled (false).
        /// </summary>
        [JsonProperty("BullseyeEnable")]
        public bool BullseyeEnable { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeviceServiceInformation : ({string.Join(", ", toStringOutput)})";
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
            return obj is DeviceServiceInformation other &&                ((this.ResponseType == null && other.ResponseType == null) || (this.ResponseType?.Equals(other.ResponseType) == true)) &&
                ((this.Imei == null && other.Imei == null) || (this.Imei?.Equals(other.Imei) == true)) &&
                this.BullseyeEnable.Equals(other.BullseyeEnable);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ResponseType = {(this.ResponseType == null ? "null" : this.ResponseType.ToString())}");
            toStringOutput.Add($"this.Imei = {(this.Imei == null ? "null" : this.Imei == string.Empty ? "" : this.Imei)}");
            toStringOutput.Add($"this.BullseyeEnable = {this.BullseyeEnable}");
        }
    }
}