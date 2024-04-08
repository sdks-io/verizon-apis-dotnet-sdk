// <copyright file="DateFilter.cs" company="APIMatic">
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
    /// DateFilter.
    /// </summary>
    public class DateFilter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DateFilter"/> class.
        /// </summary>
        public DateFilter()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateFilter"/> class.
        /// </summary>
        /// <param name="earliest">earliest.</param>
        /// <param name="latest">latest.</param>
        public DateFilter(
            string earliest,
            string latest)
        {
            this.Earliest = earliest;
            this.Latest = latest;
        }

        /// <summary>
        /// Only include devices that were added after this date and time.
        /// </summary>
        [JsonProperty("earliest")]
        public string Earliest { get; set; }

        /// <summary>
        /// Only include devices that were added before this date and time.
        /// </summary>
        [JsonProperty("latest")]
        public string Latest { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DateFilter : ({string.Join(", ", toStringOutput)})";
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
            return obj is DateFilter other &&                ((this.Earliest == null && other.Earliest == null) || (this.Earliest?.Equals(other.Earliest) == true)) &&
                ((this.Latest == null && other.Latest == null) || (this.Latest?.Equals(other.Latest) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Earliest = {(this.Earliest == null ? "null" : this.Earliest)}");
            toStringOutput.Add($"this.Latest = {(this.Latest == null ? "null" : this.Latest)}");
        }
    }
}