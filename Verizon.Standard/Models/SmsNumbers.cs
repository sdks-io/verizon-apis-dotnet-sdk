// <copyright file="SmsNumbers.cs" company="APIMatic">
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
    /// SmsNumbers.
    /// </summary>
    public class SmsNumbers
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SmsNumbers"/> class.
        /// </summary>
        public SmsNumbers()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SmsNumbers"/> class.
        /// </summary>
        /// <param name="number">number.</param>
        /// <param name="carrier">carrier.</param>
        public SmsNumbers(
            string number = null,
            string carrier = null)
        {
            this.Number = number;
            this.Carrier = carrier;
        }

        /// <summary>
        /// Gets or sets Number.
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets Carrier.
        /// </summary>
        [JsonProperty("carrier", NullValueHandling = NullValueHandling.Ignore)]
        public string Carrier { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SmsNumbers : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SmsNumbers other &&
                (this.Number == null && other.Number == null ||
                 this.Number?.Equals(other.Number) == true) &&
                (this.Carrier == null && other.Carrier == null ||
                 this.Carrier?.Equals(other.Carrier) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Number = {this.Number ?? "null"}");
            toStringOutput.Add($"Carrier = {this.Carrier ?? "null"}");
        }
    }
}