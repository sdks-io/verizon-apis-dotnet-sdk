// <copyright file="DevicePropertylocation.cs" company="APIMatic">
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
    /// DevicePropertylocation.
    /// </summary>
    public class DevicePropertylocation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DevicePropertylocation"/> class.
        /// </summary>
        public DevicePropertylocation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DevicePropertylocation"/> class.
        /// </summary>
        /// <param name="latitude">latitude.</param>
        /// <param name="longitude">longitude.</param>
        public DevicePropertylocation(
            string latitude = null,
            string longitude = null)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
        }

        /// <summary>
        /// Gets or sets Latitude.
        /// </summary>
        [JsonProperty("latitude", NullValueHandling = NullValueHandling.Ignore)]
        public string Latitude { get; set; }

        /// <summary>
        /// Gets or sets Longitude.
        /// </summary>
        [JsonProperty("longitude", NullValueHandling = NullValueHandling.Ignore)]
        public string Longitude { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DevicePropertylocation : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DevicePropertylocation other &&
                (this.Latitude == null && other.Latitude == null ||
                 this.Latitude?.Equals(other.Latitude) == true) &&
                (this.Longitude == null && other.Longitude == null ||
                 this.Longitude?.Equals(other.Longitude) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Latitude = {this.Latitude ?? "null"}");
            toStringOutput.Add($"Longitude = {this.Longitude ?? "null"}");
        }
    }
}