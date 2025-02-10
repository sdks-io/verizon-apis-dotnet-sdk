// <copyright file="AccountGroupShareIndividual.cs" company="APIMatic">
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
    /// AccountGroupShareIndividual.
    /// </summary>
    public class AccountGroupShareIndividual
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountGroupShareIndividual"/> class.
        /// </summary>
        public AccountGroupShareIndividual()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountGroupShareIndividual"/> class.
        /// </summary>
        /// <param name="filterCriteria">filterCriteria.</param>
        /// <param name="condition">condition.</param>
        /// <param name="action">action.</param>
        public AccountGroupShareIndividual(
            Models.FilterCriteriaAccountGroupShare filterCriteria = null,
            Models.ConditionAccountGroupShare condition = null,
            Models.ActionAccountGroupShare action = null)
        {
            this.FilterCriteria = filterCriteria;
            this.Condition = condition;
            this.Action = action;
        }

        /// <summary>
        /// Gets or sets FilterCriteria.
        /// </summary>
        [JsonProperty("filterCriteria", NullValueHandling = NullValueHandling.Ignore)]
        public Models.FilterCriteriaAccountGroupShare FilterCriteria { get; set; }

        /// <summary>
        /// Gets or sets Condition.
        /// </summary>
        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ConditionAccountGroupShare Condition { get; set; }

        /// <summary>
        /// Gets or sets Action.
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ActionAccountGroupShare Action { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"AccountGroupShareIndividual : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AccountGroupShareIndividual other &&
                (this.FilterCriteria == null && other.FilterCriteria == null ||
                 this.FilterCriteria?.Equals(other.FilterCriteria) == true) &&
                (this.Condition == null && other.Condition == null ||
                 this.Condition?.Equals(other.Condition) == true) &&
                (this.Action == null && other.Action == null ||
                 this.Action?.Equals(other.Action) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"FilterCriteria = {(this.FilterCriteria == null ? "null" : this.FilterCriteria.ToString())}");
            toStringOutput.Add($"Condition = {(this.Condition == null ? "null" : this.Condition.ToString())}");
            toStringOutput.Add($"Action = {(this.Action == null ? "null" : this.Action.ToString())}");
        }
    }
}