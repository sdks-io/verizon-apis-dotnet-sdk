// <copyright file="SMSNumber.cs" company="APIMatic">
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
    using APIMatic.Core.Utilities.Converters;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Verizon.Standard;
    using Verizon.Standard.Utilities;

    /// <summary>
    /// SMSNumber.
    /// </summary>
    public class SMSNumber
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SMSNumber"/> class.
        /// </summary>
        public SMSNumber()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SMSNumber"/> class.
        /// </summary>
        /// <param name="carrier">carrier.</param>
        /// <param name="number">number.</param>
        public SMSNumber(
            string carrier = null,
            string number = null)
        {
            this.Carrier = carrier;
            this.Number = number;
        }

        /// <summary>
        /// Gets or sets Carrier.
        /// </summary>
        [JsonProperty("carrier", NullValueHandling = NullValueHandling.Ignore)]
        public string Carrier { get; set; }

        /// <summary>
        /// Gets or sets Number.
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SMSNumber : ({string.Join(", ", toStringOutput)})";
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
            return obj is SMSNumber other &&                ((this.Carrier == null && other.Carrier == null) || (this.Carrier?.Equals(other.Carrier) == true)) &&
                ((this.Number == null && other.Number == null) || (this.Number?.Equals(other.Number) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Carrier = {(this.Carrier == null ? "null" : this.Carrier)}");
            toStringOutput.Add($"this.Number = {(this.Number == null ? "null" : this.Number)}");
        }
    }
}