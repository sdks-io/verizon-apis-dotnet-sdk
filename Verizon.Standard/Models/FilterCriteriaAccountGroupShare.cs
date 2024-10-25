// <copyright file="FilterCriteriaAccountGroupShare.cs" company="APIMatic">
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
    /// FilterCriteriaAccountGroupShare.
    /// </summary>
    public class FilterCriteriaAccountGroupShare
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilterCriteriaAccountGroupShare"/> class.
        /// </summary>
        public FilterCriteriaAccountGroupShare()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterCriteriaAccountGroupShare"/> class.
        /// </summary>
        /// <param name="ratePlanGroupId">ratePlanGroupId.</param>
        public FilterCriteriaAccountGroupShare(
            int? ratePlanGroupId = null)
        {
            this.RatePlanGroupId = ratePlanGroupId;
        }

        /// <summary>
        /// Gets or sets RatePlanGroupId.
        /// </summary>
        [JsonProperty("ratePlanGroupId", NullValueHandling = NullValueHandling.Ignore)]
        public int? RatePlanGroupId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"FilterCriteriaAccountGroupShare : ({string.Join(", ", toStringOutput)})";
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
            return obj is FilterCriteriaAccountGroupShare other &&                ((this.RatePlanGroupId == null && other.RatePlanGroupId == null) || (this.RatePlanGroupId?.Equals(other.RatePlanGroupId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RatePlanGroupId = {(this.RatePlanGroupId == null ? "null" : this.RatePlanGroupId.ToString())}");
        }
    }
}