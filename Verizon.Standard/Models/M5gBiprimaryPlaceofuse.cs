// <copyright file="M5gBiprimaryPlaceofuse.cs" company="APIMatic">
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
    /// M5gBiprimaryPlaceofuse.
    /// </summary>
    public class M5gBiprimaryPlaceofuse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="M5gBiprimaryPlaceofuse"/> class.
        /// </summary>
        public M5gBiprimaryPlaceofuse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="M5gBiprimaryPlaceofuse"/> class.
        /// </summary>
        /// <param name="address">address.</param>
        /// <param name="customerName">customerName.</param>
        public M5gBiprimaryPlaceofuse(
            Models.M5gBiAddress address = null,
            Models.M5gBiCustomerName customerName = null)
        {
            this.Address = address;
            this.CustomerName = customerName;
        }

        /// <summary>
        /// Gets or sets Address.
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.M5gBiAddress Address { get; set; }

        /// <summary>
        /// Gets or sets CustomerName.
        /// </summary>
        [JsonProperty("customerName", NullValueHandling = NullValueHandling.Ignore)]
        public Models.M5gBiCustomerName CustomerName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"M5gBiprimaryPlaceofuse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is M5gBiprimaryPlaceofuse other &&
                (this.Address == null && other.Address == null ||
                 this.Address?.Equals(other.Address) == true) &&
                (this.CustomerName == null && other.CustomerName == null ||
                 this.CustomerName?.Equals(other.CustomerName) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Address = {(this.Address == null ? "null" : this.Address.ToString())}");
            toStringOutput.Add($"CustomerName = {(this.CustomerName == null ? "null" : this.CustomerName.ToString())}");
        }
    }
}