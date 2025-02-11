// <copyright file="ReadySimServicePlan.cs" company="APIMatic">
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
    /// ReadySimServicePlan.
    /// </summary>
    public class ReadySimServicePlan
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadySimServicePlan"/> class.
        /// </summary>
        public ReadySimServicePlan()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadySimServicePlan"/> class.
        /// </summary>
        /// <param name="servicePlan">servicePlan.</param>
        public ReadySimServicePlan(
            string servicePlan = null)
        {
            this.ServicePlan = servicePlan;
        }

        /// <summary>
        /// Gets or sets ServicePlan.
        /// </summary>
        [JsonProperty("servicePlan", NullValueHandling = NullValueHandling.Ignore)]
        public string ServicePlan { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ReadySimServicePlan : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ReadySimServicePlan other &&
                (this.ServicePlan == null && other.ServicePlan == null ||
                 this.ServicePlan?.Equals(other.ServicePlan) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ServicePlan = {this.ServicePlan ?? "null"}");
        }
    }
}