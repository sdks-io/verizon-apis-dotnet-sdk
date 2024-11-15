// <copyright file="PropertyDeviceId.cs" company="APIMatic">
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
    /// PropertyDeviceId.
    /// </summary>
    public class PropertyDeviceId
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyDeviceId"/> class.
        /// </summary>
        public PropertyDeviceId()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyDeviceId"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="kind">kind.</param>
        public PropertyDeviceId(
            string id = null,
            string kind = null)
        {
            this.Id = id;
            this.Kind = kind;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// The type of the device identifier. Valid types of identifiers are:ESN (decimal),EID,ICCID (up to 20 digits),IMEI (up to 16 digits),MDN,MEID (hexadecimal),MSISDN.
        /// </summary>
        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        public string Kind { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PropertyDeviceId : ({string.Join(", ", toStringOutput)})";
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
            return obj is PropertyDeviceId other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Kind == null && other.Kind == null) || (this.Kind?.Equals(other.Kind) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Kind = {(this.Kind == null ? "null" : this.Kind)}");
        }
    }
}