// <copyright file="DeviceListWithServiceAddress1.cs" company="APIMatic">
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
    /// DeviceListWithServiceAddress1.
    /// </summary>
    public class DeviceListWithServiceAddress1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceListWithServiceAddress1"/> class.
        /// </summary>
        public DeviceListWithServiceAddress1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceListWithServiceAddress1"/> class.
        /// </summary>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="primaryPlaceofuse">primaryPlaceofuse.</param>
        public DeviceListWithServiceAddress1(
            List<Models.M5gBideviceId1> deviceId = null,
            Models.M5gBiprimaryPlaceofuse primaryPlaceofuse = null)
        {
            this.DeviceId = deviceId;
            this.PrimaryPlaceofuse = primaryPlaceofuse;
        }

        /// <summary>
        /// Gets or sets DeviceId.
        /// </summary>
        [JsonProperty("deviceId", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.M5gBideviceId1> DeviceId { get; set; }

        /// <summary>
        /// Gets or sets PrimaryPlaceofuse.
        /// </summary>
        [JsonProperty("primaryPlaceofuse", NullValueHandling = NullValueHandling.Ignore)]
        public Models.M5gBiprimaryPlaceofuse PrimaryPlaceofuse { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DeviceListWithServiceAddress1 : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DeviceListWithServiceAddress1 other &&
                (this.DeviceId == null && other.DeviceId == null ||
                 this.DeviceId?.Equals(other.DeviceId) == true) &&
                (this.PrimaryPlaceofuse == null && other.PrimaryPlaceofuse == null ||
                 this.PrimaryPlaceofuse?.Equals(other.PrimaryPlaceofuse) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"DeviceId = {(this.DeviceId == null ? "null" : $"[{string.Join(", ", this.DeviceId)} ]")}");
            toStringOutput.Add($"PrimaryPlaceofuse = {(this.PrimaryPlaceofuse == null ? "null" : this.PrimaryPlaceofuse.ToString())}");
        }
    }
}