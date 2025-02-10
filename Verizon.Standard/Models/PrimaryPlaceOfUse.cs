// <copyright file="PrimaryPlaceOfUse.cs" company="APIMatic">
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
    /// PrimaryPlaceOfUse.
    /// </summary>
    public class PrimaryPlaceOfUse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrimaryPlaceOfUse"/> class.
        /// </summary>
        public PrimaryPlaceOfUse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrimaryPlaceOfUse"/> class.
        /// </summary>
        /// <param name="customerName">customerName.</param>
        /// <param name="address">address.</param>
        public PrimaryPlaceOfUse(
            List<Models.CustomerName> customerName = null,
            List<Models.Address> address = null)
        {
            this.CustomerName = customerName;
            this.Address = address;
        }

        /// <summary>
        /// Gets or sets CustomerName.
        /// </summary>
        [JsonProperty("customerName", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CustomerName> CustomerName { get; set; }

        /// <summary>
        /// Gets or sets Address.
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Address> Address { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PrimaryPlaceOfUse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PrimaryPlaceOfUse other &&
                (this.CustomerName == null && other.CustomerName == null ||
                 this.CustomerName?.Equals(other.CustomerName) == true) &&
                (this.Address == null && other.Address == null ||
                 this.Address?.Equals(other.Address) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CustomerName = {(this.CustomerName == null ? "null" : $"[{string.Join(", ", this.CustomerName)} ]")}");
            toStringOutput.Add($"Address = {(this.Address == null ? "null" : $"[{string.Join(", ", this.Address)} ]")}");
        }
    }
}