// <copyright file="SessionTriggerRequest.cs" company="APIMatic">
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
    /// SessionTriggerRequest.
    /// </summary>
    public class SessionTriggerRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionTriggerRequest"/> class.
        /// </summary>
        public SessionTriggerRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionTriggerRequest"/> class.
        /// </summary>
        /// <param name="comparator">comparator.</param>
        /// <param name="threshold">threshold.</param>
        public SessionTriggerRequest(
            string comparator = null,
            int? threshold = null)
        {
            this.Comparator = comparator;
            this.Threshold = threshold;
        }

        /// <summary>
        /// Gets or sets Comparator.
        /// </summary>
        [JsonProperty("comparator", NullValueHandling = NullValueHandling.Ignore)]
        public string Comparator { get; set; }

        /// <summary>
        /// Gets or sets Threshold.
        /// </summary>
        [JsonProperty("threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? Threshold { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SessionTriggerRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SessionTriggerRequest other &&
                (this.Comparator == null && other.Comparator == null ||
                 this.Comparator?.Equals(other.Comparator) == true) &&
                (this.Threshold == null && other.Threshold == null ||
                 this.Threshold?.Equals(other.Threshold) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Comparator = {this.Comparator ?? "null"}");
            toStringOutput.Add($"Threshold = {(this.Threshold == null ? "null" : this.Threshold.ToString())}");
        }
    }
}