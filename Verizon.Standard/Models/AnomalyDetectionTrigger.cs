// <copyright file="AnomalyDetectionTrigger.cs" company="APIMatic">
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
    /// AnomalyDetectionTrigger.
    /// </summary>
    public class AnomalyDetectionTrigger
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnomalyDetectionTrigger"/> class.
        /// </summary>
        public AnomalyDetectionTrigger()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnomalyDetectionTrigger"/> class.
        /// </summary>
        /// <param name="triggerId">triggerId.</param>
        public AnomalyDetectionTrigger(
            string triggerId = null)
        {
            this.TriggerId = triggerId;
        }

        /// <summary>
        /// Trigger ID to identify the request in a callback.
        /// </summary>
        [JsonProperty("triggerId", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AnomalyDetectionTrigger : ({string.Join(", ", toStringOutput)})";
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
            return obj is AnomalyDetectionTrigger other &&                ((this.TriggerId == null && other.TriggerId == null) || (this.TriggerId?.Equals(other.TriggerId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TriggerId = {(this.TriggerId == null ? "null" : this.TriggerId)}");
        }
    }
}