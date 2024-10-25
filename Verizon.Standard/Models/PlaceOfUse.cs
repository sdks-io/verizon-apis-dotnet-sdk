// <copyright file="PlaceOfUse.cs" company="APIMatic">
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
    /// PlaceOfUse.
    /// </summary>
    public class PlaceOfUse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlaceOfUse"/> class.
        /// </summary>
        public PlaceOfUse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaceOfUse"/> class.
        /// </summary>
        /// <param name="address">address.</param>
        /// <param name="customerName">customerName.</param>
        public PlaceOfUse(
            Models.Address address,
            Models.CustomerName customerName)
        {
            this.Address = address;
            this.CustomerName = customerName;
        }

        /// <summary>
        /// The customer address for the line's primary place of use, for line usage taxation.
        /// </summary>
        [JsonProperty("address")]
        public Models.Address Address { get; set; }

        /// <summary>
        /// The customer name to be used for line usage taxation.
        /// </summary>
        [JsonProperty("customerName")]
        public Models.CustomerName CustomerName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PlaceOfUse : ({string.Join(", ", toStringOutput)})";
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
            return obj is PlaceOfUse other &&                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                ((this.CustomerName == null && other.CustomerName == null) || (this.CustomerName?.Equals(other.CustomerName) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address.ToString())}");
            toStringOutput.Add($"this.CustomerName = {(this.CustomerName == null ? "null" : this.CustomerName.ToString())}");
        }
    }
}