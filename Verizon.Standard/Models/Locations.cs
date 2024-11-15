// <copyright file="Locations.cs" company="APIMatic">
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
    /// Locations.
    /// </summary>
    public class Locations
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Locations"/> class.
        /// </summary>
        public Locations()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Locations"/> class.
        /// </summary>
        /// <param name="addressList">addressList.</param>
        public Locations(
            List<Models.AddressItem> addressList = null)
        {
            this.AddressList = addressList;
        }

        /// <summary>
        /// Gets or sets AddressList.
        /// </summary>
        [JsonProperty("addressList", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.AddressItem> AddressList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Locations : ({string.Join(", ", toStringOutput)})";
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
            return obj is Locations other &&                ((this.AddressList == null && other.AddressList == null) || (this.AddressList?.Equals(other.AddressList) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AddressList = {(this.AddressList == null ? "null" : $"[{string.Join(", ", this.AddressList)} ]")}");
        }
    }
}