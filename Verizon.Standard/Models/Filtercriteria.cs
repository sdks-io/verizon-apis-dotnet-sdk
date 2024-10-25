// <copyright file="Filtercriteria.cs" company="APIMatic">
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
    /// Filtercriteria.
    /// </summary>
    public class Filtercriteria
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Filtercriteria"/> class.
        /// </summary>
        public Filtercriteria()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Filtercriteria"/> class.
        /// </summary>
        /// <param name="filterCriteria">filterCriteria.</param>
        public Filtercriteria(
            List<Models.ReadySimServicePlan> filterCriteria = null)
        {
            this.FilterCriteria = filterCriteria;
        }

        /// <summary>
        /// Gets or sets FilterCriteria.
        /// </summary>
        [JsonProperty("filterCriteria", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ReadySimServicePlan> FilterCriteria { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Filtercriteria : ({string.Join(", ", toStringOutput)})";
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
            return obj is Filtercriteria other &&                ((this.FilterCriteria == null && other.FilterCriteria == null) || (this.FilterCriteria?.Equals(other.FilterCriteria) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.FilterCriteria = {(this.FilterCriteria == null ? "null" : $"[{string.Join(", ", this.FilterCriteria)} ]")}");
        }
    }
}