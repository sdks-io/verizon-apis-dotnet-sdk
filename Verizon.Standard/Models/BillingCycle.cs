// <copyright file="BillingCycle.cs" company="APIMatic">
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
    /// BillingCycle.
    /// </summary>
    public class BillingCycle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingCycle"/> class.
        /// </summary>
        public BillingCycle()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingCycle"/> class.
        /// </summary>
        /// <param name="year">year.</param>
        /// <param name="month">month.</param>
        public BillingCycle(
            string year = null,
            string month = null)
        {
            this.Year = year;
            this.Month = month;
        }

        /// <summary>
        /// Gets or sets Year.
        /// </summary>
        [JsonProperty("year", NullValueHandling = NullValueHandling.Ignore)]
        public string Year { get; set; }

        /// <summary>
        /// Gets or sets Month.
        /// </summary>
        [JsonProperty("month", NullValueHandling = NullValueHandling.Ignore)]
        public string Month { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BillingCycle : ({string.Join(", ", toStringOutput)})";
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
            return obj is BillingCycle other &&                ((this.Year == null && other.Year == null) || (this.Year?.Equals(other.Year) == true)) &&
                ((this.Month == null && other.Month == null) || (this.Month?.Equals(other.Month) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Year = {(this.Year == null ? "null" : this.Year == string.Empty ? "" : this.Year)}");
            toStringOutput.Add($"this.Month = {(this.Month == null ? "null" : this.Month == string.Empty ? "" : this.Month)}");
        }
    }
}