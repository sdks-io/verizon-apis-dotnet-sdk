// <copyright file="MECSiteLocation.cs" company="APIMatic">
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
    /// MECSiteLocation.
    /// </summary>
    public class MECSiteLocation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MECSiteLocation"/> class.
        /// </summary>
        public MECSiteLocation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MECSiteLocation"/> class.
        /// </summary>
        /// <param name="ern">ern.</param>
        /// <param name="city">city.</param>
        /// <param name="latitude">latitude.</param>
        /// <param name="longitude">longitude.</param>
        /// <param name="csp">csp.</param>
        public MECSiteLocation(
            string ern = null,
            string city = null,
            string latitude = null,
            string longitude = null,
            string csp = null)
        {
            this.Ern = ern;
            this.City = city;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Csp = csp;
        }

        /// <summary>
        /// Edge Resource Number.
        /// </summary>
        [JsonProperty("ern", NullValueHandling = NullValueHandling.Ignore)]
        public string Ern { get; set; }

        /// <summary>
        /// Gets or sets City.
        /// </summary>
        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

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

        /// <summary>
        /// Cloud Service Provider.
        /// </summary>
        [JsonProperty("csp", NullValueHandling = NullValueHandling.Ignore)]
        public string Csp { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MECSiteLocation : ({string.Join(", ", toStringOutput)})";
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
            return obj is MECSiteLocation other &&                ((this.Ern == null && other.Ern == null) || (this.Ern?.Equals(other.Ern) == true)) &&
                ((this.City == null && other.City == null) || (this.City?.Equals(other.City) == true)) &&
                ((this.Latitude == null && other.Latitude == null) || (this.Latitude?.Equals(other.Latitude) == true)) &&
                ((this.Longitude == null && other.Longitude == null) || (this.Longitude?.Equals(other.Longitude) == true)) &&
                ((this.Csp == null && other.Csp == null) || (this.Csp?.Equals(other.Csp) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Ern = {(this.Ern == null ? "null" : this.Ern == string.Empty ? "" : this.Ern)}");
            toStringOutput.Add($"this.City = {(this.City == null ? "null" : this.City == string.Empty ? "" : this.City)}");
            toStringOutput.Add($"this.Latitude = {(this.Latitude == null ? "null" : this.Latitude == string.Empty ? "" : this.Latitude)}");
            toStringOutput.Add($"this.Longitude = {(this.Longitude == null ? "null" : this.Longitude == string.Empty ? "" : this.Longitude)}");
            toStringOutput.Add($"this.Csp = {(this.Csp == null ? "null" : this.Csp == string.Empty ? "" : this.Csp)}");
        }
    }
}