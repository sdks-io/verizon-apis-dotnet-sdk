// <copyright file="Filtercriteria2.cs" company="APIMatic">
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
    /// Filtercriteria2.
    /// </summary>
    public class Filtercriteria2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Filtercriteria2"/> class.
        /// </summary>
        public Filtercriteria2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Filtercriteria2"/> class.
        /// </summary>
        /// <param name="filterCriteria">filterCriteria.</param>
        public Filtercriteria2(
            object filterCriteria = null)
        {
            this.FilterCriteria = filterCriteria;
        }

        /// <summary>
        /// Gets or sets FilterCriteria.
        /// </summary>
        [JsonProperty("filterCriteria", NullValueHandling = NullValueHandling.Ignore)]
        public object FilterCriteria { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Filtercriteria2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Filtercriteria2 other &&                ((this.FilterCriteria == null && other.FilterCriteria == null) || (this.FilterCriteria?.Equals(other.FilterCriteria) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"FilterCriteria = {(this.FilterCriteria == null ? "null" : this.FilterCriteria.ToString())}");
        }
    }
}