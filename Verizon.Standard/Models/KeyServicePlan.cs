// <copyright file="KeyServicePlan.cs" company="APIMatic">
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
    /// KeyServicePlan.
    /// </summary>
    public class KeyServicePlan
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KeyServicePlan"/> class.
        /// </summary>
        public KeyServicePlan()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyServicePlan"/> class.
        /// </summary>
        /// <param name="key">key.</param>
        public KeyServicePlan(
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
            return $"KeyServicePlan : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is KeyServicePlan other &&
                (this.Key == null && other.Key == null ||
                 this.Key?.Equals(other.Key) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Key = {this.Key ?? "null"}");
        }
    }
}