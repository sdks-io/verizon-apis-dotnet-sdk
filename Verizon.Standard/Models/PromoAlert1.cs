// <copyright file="PromoAlert1.cs" company="APIMatic">
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
    /// PromoAlert1.
    /// </summary>
    public class PromoAlert1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PromoAlert1"/> class.
        /// </summary>
        public PromoAlert1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromoAlert1"/> class.
        /// </summary>
        /// <param name="filterCriteria">filterCriteria.</param>
        /// <param name="condition">condition.</param>
        /// <param name="enablePromoExp">enablePromoExp.</param>
        public PromoAlert1(
            object filterCriteria = null,
            List<Models.Keyschunk2> condition = null,
            bool? enablePromoExp = null)
        {
            this.FilterCriteria = filterCriteria;
            this.Condition = condition;
            this.EnablePromoExp = enablePromoExp;
        }

        /// <summary>
        /// Gets or sets FilterCriteria.
        /// </summary>
        [JsonProperty("filterCriteria", NullValueHandling = NullValueHandling.Ignore)]
        public object FilterCriteria { get; set; }

        /// <summary>
        /// Gets or sets Condition.
        /// </summary>
        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Keyschunk2> Condition { get; set; }

        /// <summary>
        /// Gets or sets EnablePromoExp.
        /// </summary>
        [JsonProperty("enablePromoExp", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnablePromoExp { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PromoAlert1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is PromoAlert1 other &&                ((this.FilterCriteria == null && other.FilterCriteria == null) || (this.FilterCriteria?.Equals(other.FilterCriteria) == true)) &&
                ((this.Condition == null && other.Condition == null) || (this.Condition?.Equals(other.Condition) == true)) &&
                ((this.EnablePromoExp == null && other.EnablePromoExp == null) || (this.EnablePromoExp?.Equals(other.EnablePromoExp) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"FilterCriteria = {(this.FilterCriteria == null ? "null" : this.FilterCriteria.ToString())}");
            toStringOutput.Add($"this.Condition = {(this.Condition == null ? "null" : $"[{string.Join(", ", this.Condition)} ]")}");
            toStringOutput.Add($"this.EnablePromoExp = {(this.EnablePromoExp == null ? "null" : this.EnablePromoExp.ToString())}");
        }
    }
}