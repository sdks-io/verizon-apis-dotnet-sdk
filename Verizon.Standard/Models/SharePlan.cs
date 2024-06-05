// <copyright file="SharePlan.cs" company="APIMatic">
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
    /// SharePlan.
    /// </summary>
    public class SharePlan
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SharePlan"/> class.
        /// </summary>
        public SharePlan()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharePlan"/> class.
        /// </summary>
        /// <param name="fromCarrierCode">fromCarrierCode.</param>
        /// <param name="toCarrierCode">toCarrierCode.</param>
        /// <param name="criteriaPercentage">criteriaPercentage.</param>
        public SharePlan(
            string fromCarrierCode = null,
            string toCarrierCode = null,
            int? criteriaPercentage = null)
        {
            this.FromCarrierCode = fromCarrierCode;
            this.ToCarrierCode = toCarrierCode;
            this.CriteriaPercentage = criteriaPercentage;
        }

        /// <summary>
        /// Gets or sets FromCarrierCode.
        /// </summary>
        [JsonProperty("fromCarrierCode", NullValueHandling = NullValueHandling.Ignore)]
        public string FromCarrierCode { get; set; }

        /// <summary>
        /// Gets or sets ToCarrierCode.
        /// </summary>
        [JsonProperty("toCarrierCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ToCarrierCode { get; set; }

        /// <summary>
        /// Gets or sets CriteriaPercentage.
        /// </summary>
        [JsonProperty("criteriaPercentage", NullValueHandling = NullValueHandling.Ignore)]
        public int? CriteriaPercentage { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SharePlan : ({string.Join(", ", toStringOutput)})";
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
            return obj is SharePlan other &&                ((this.FromCarrierCode == null && other.FromCarrierCode == null) || (this.FromCarrierCode?.Equals(other.FromCarrierCode) == true)) &&
                ((this.ToCarrierCode == null && other.ToCarrierCode == null) || (this.ToCarrierCode?.Equals(other.ToCarrierCode) == true)) &&
                ((this.CriteriaPercentage == null && other.CriteriaPercentage == null) || (this.CriteriaPercentage?.Equals(other.CriteriaPercentage) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.FromCarrierCode = {(this.FromCarrierCode == null ? "null" : this.FromCarrierCode)}");
            toStringOutput.Add($"this.ToCarrierCode = {(this.ToCarrierCode == null ? "null" : this.ToCarrierCode)}");
            toStringOutput.Add($"this.CriteriaPercentage = {(this.CriteriaPercentage == null ? "null" : this.CriteriaPercentage.ToString())}");
        }
    }
}