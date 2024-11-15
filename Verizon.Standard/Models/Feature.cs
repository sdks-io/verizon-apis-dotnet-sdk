// <copyright file="Feature.cs" company="APIMatic">
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
    /// Feature.
    /// </summary>
    public class Feature
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Feature"/> class.
        /// </summary>
        public Feature()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Feature"/> class.
        /// </summary>
        /// <param name="features">features.</param>
        public Feature(
            string features = null)
        {
            this.Features = features;
        }

        /// <summary>
        /// The calling and data features available for the account. **Note:** for Global IoT Orchestrator, the features `eUICC Verizon as Lead` and `Global eSim Billing` will always be present.
        /// </summary>
        [JsonProperty("features", NullValueHandling = NullValueHandling.Ignore)]
        public string Features { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Feature : ({string.Join(", ", toStringOutput)})";
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
            return obj is Feature other &&                ((this.Features == null && other.Features == null) || (this.Features?.Equals(other.Features) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Features = {(this.Features == null ? "null" : this.Features)}");
        }
    }
}