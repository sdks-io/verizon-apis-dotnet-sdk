// <copyright file="Addressquery.cs" company="APIMatic">
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
    /// Addressquery.
    /// </summary>
    public class Addressquery
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Addressquery"/> class.
        /// </summary>
        public Addressquery()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Addressquery"/> class.
        /// </summary>
        /// <param name="address">address.</param>
        public Addressquery(
            List<Models.Address> address = null)
        {
            this.Address = address;
        }

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

            return $"Addressquery : ({string.Join(", ", toStringOutput)})";
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
            return obj is Addressquery other &&                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : $"[{string.Join(", ", this.Address)} ]")}");
        }
    }
}