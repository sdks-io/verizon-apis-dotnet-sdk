// <copyright file="DeviceIdentifier.cs" company="APIMatic">
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
    /// DeviceIdentifier.
    /// </summary>
    public class DeviceIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceIdentifier"/> class.
        /// </summary>
        public DeviceIdentifier()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceIdentifier"/> class.
        /// </summary>
        /// <param name="kind">kind.</param>
        /// <param name="id">id.</param>
        /// <param name="mdn">mdn.</param>
        public DeviceIdentifier(
            string kind,
            string id,
            string mdn = null)
        {
            this.Kind = kind;
            this.Id = id;
            this.Mdn = mdn;
        }

        /// <summary>
        /// Kind of device.
        /// </summary>
        [JsonProperty("kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Device Identity number.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Device MDN number.
        /// </summary>
        [JsonProperty("mdn", NullValueHandling = NullValueHandling.Ignore)]
        public string Mdn { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeviceIdentifier : ({string.Join(", ", toStringOutput)})";
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
            return obj is DeviceIdentifier other &&                ((this.Kind == null && other.Kind == null) || (this.Kind?.Equals(other.Kind) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Mdn == null && other.Mdn == null) || (this.Mdn?.Equals(other.Mdn) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Kind = {(this.Kind == null ? "null" : this.Kind)}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Mdn = {(this.Mdn == null ? "null" : this.Mdn)}");
        }
    }
}