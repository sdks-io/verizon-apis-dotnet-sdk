// <copyright file="ChangePlan.cs" company="APIMatic">
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
    /// ChangePlan.
    /// </summary>
    public class ChangePlan
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangePlan"/> class.
        /// </summary>
        public ChangePlan()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangePlan"/> class.
        /// </summary>
        /// <param name="triggerDate">triggerDate.</param>
        /// <param name="sharePlan">sharePlan.</param>
        public ChangePlan(
            string triggerDate = null,
            List<Models.SharePlan> sharePlan = null)
        {
            this.TriggerDate = triggerDate;
            this.SharePlan = sharePlan;
        }

        /// <summary>
        /// Gets or sets TriggerDate.
        /// </summary>
        [JsonProperty("triggerDate", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerDate { get; set; }

        /// <summary>
        /// Gets or sets SharePlan.
        /// </summary>
        [JsonProperty("sharePlan", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.SharePlan> SharePlan { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ChangePlan : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ChangePlan other &&
                (this.TriggerDate == null && other.TriggerDate == null ||
                 this.TriggerDate?.Equals(other.TriggerDate) == true) &&
                (this.SharePlan == null && other.SharePlan == null ||
                 this.SharePlan?.Equals(other.SharePlan) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"TriggerDate = {this.TriggerDate ?? "null"}");
            toStringOutput.Add($"SharePlan = {(this.SharePlan == null ? "null" : $"[{string.Join(", ", this.SharePlan)} ]")}");
        }
    }
}