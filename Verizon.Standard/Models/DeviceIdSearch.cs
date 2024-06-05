// <copyright file="DeviceIdSearch.cs" company="APIMatic">
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
    /// DeviceIdSearch.
    /// </summary>
    public class DeviceIdSearch
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceIdSearch"/> class.
        /// </summary>
        public DeviceIdSearch()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceIdSearch"/> class.
        /// </summary>
        /// <param name="contains">contains.</param>
        /// <param name="kind">kind.</param>
        /// <param name="startswith">startswith.</param>
        /// <param name="endswith">endswith.</param>
        public DeviceIdSearch(
            string contains,
            string kind,
            string startswith = null,
            string endswith = null)
        {
            this.Contains = contains;
            this.Startswith = startswith;
            this.Endswith = endswith;
            this.Kind = kind;
        }

        /// <summary>
        /// The string appears anywhere in the identifer.
        /// </summary>
        [JsonProperty("contains")]
        public string Contains { get; set; }

        /// <summary>
        /// The identifer must start with the specified string.
        /// </summary>
        [JsonProperty("startswith", NullValueHandling = NullValueHandling.Ignore)]
        public string Startswith { get; set; }

        /// <summary>
        /// The identifier must end with the specified string.
        /// </summary>
        [JsonProperty("endswith", NullValueHandling = NullValueHandling.Ignore)]
        public string Endswith { get; set; }

        /// <summary>
        /// The type of the device identifier. Valid types of identifiers are:ESN (decimal),EID,ICCID (up to 20 digits),IMEI (up to 16 digits),MDN,MEID (hexadecimal),MSISDN.
        /// </summary>
        [JsonProperty("kind")]
        public string Kind { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeviceIdSearch : ({string.Join(", ", toStringOutput)})";
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
            return obj is DeviceIdSearch other &&                ((this.Contains == null && other.Contains == null) || (this.Contains?.Equals(other.Contains) == true)) &&
                ((this.Startswith == null && other.Startswith == null) || (this.Startswith?.Equals(other.Startswith) == true)) &&
                ((this.Endswith == null && other.Endswith == null) || (this.Endswith?.Equals(other.Endswith) == true)) &&
                ((this.Kind == null && other.Kind == null) || (this.Kind?.Equals(other.Kind) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Contains = {(this.Contains == null ? "null" : this.Contains)}");
            toStringOutput.Add($"this.Startswith = {(this.Startswith == null ? "null" : this.Startswith)}");
            toStringOutput.Add($"this.Endswith = {(this.Endswith == null ? "null" : this.Endswith)}");
            toStringOutput.Add($"this.Kind = {(this.Kind == null ? "null" : this.Kind)}");
        }
    }
}