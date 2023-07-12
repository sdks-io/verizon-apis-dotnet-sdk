// <copyright file="Customernamequery.cs" company="APIMatic">
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
    /// Customernamequery.
    /// </summary>
    public class Customernamequery
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Customernamequery"/> class.
        /// </summary>
        public Customernamequery()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customernamequery"/> class.
        /// </summary>
        /// <param name="customerName">customerName.</param>
        public Customernamequery(
            List<Models.CustomerName> customerName = null)
        {
            this.CustomerName = customerName;
        }

        /// <summary>
        /// Gets or sets CustomerName.
        /// </summary>
        [JsonProperty("customerName", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CustomerName> CustomerName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Customernamequery : ({string.Join(", ", toStringOutput)})";
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
            return obj is Customernamequery other &&                ((this.CustomerName == null && other.CustomerName == null) || (this.CustomerName?.Equals(other.CustomerName) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CustomerName = {(this.CustomerName == null ? "null" : $"[{string.Join(", ", this.CustomerName)} ]")}");
        }
    }
}