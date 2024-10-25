// <copyright file="M5gBiattribute1.cs" company="APIMatic">
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
    /// M5gBiattribute1.
    /// </summary>
    public class M5gBiattribute1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="M5gBiattribute1"/> class.
        /// </summary>
        public M5gBiattribute1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="M5gBiattribute1"/> class.
        /// </summary>
        /// <param name="key">key.</param>
        public M5gBiattribute1(
            string key = null)
        {
            this.Key = key;
        }

        /// <summary>
        /// Gets or sets Key.
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"M5gBiattribute1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is M5gBiattribute1 other &&                ((this.Key == null && other.Key == null) || (this.Key?.Equals(other.Key) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Key = {(this.Key == null ? "null" : this.Key)}");
        }
    }
}