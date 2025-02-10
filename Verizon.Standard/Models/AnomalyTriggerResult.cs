// <copyright file="AnomalyTriggerResult.cs" company="APIMatic">
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
    /// AnomalyTriggerResult.
    /// </summary>
    public class AnomalyTriggerResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnomalyTriggerResult"/> class.
        /// </summary>
        public AnomalyTriggerResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnomalyTriggerResult"/> class.
        /// </summary>
        /// <param name="triggers">triggers.</param>
        public AnomalyTriggerResult(
            List<Models.TriggersListOptions> triggers = null)
        {
            this.Triggers = triggers;
        }

        /// <summary>
        /// Trigger value chunk details.
        /// </summary>
        [JsonProperty("triggers", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.TriggersListOptions> Triggers { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"AnomalyTriggerResult : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AnomalyTriggerResult other &&
                (this.Triggers == null && other.Triggers == null ||
                 this.Triggers?.Equals(other.Triggers) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Triggers = {(this.Triggers == null ? "null" : $"[{string.Join(", ", this.Triggers)} ]")}");
        }
    }
}