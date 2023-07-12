// <copyright file="NodeConfigurationLabel.cs" company="APIMatic">
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
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Verizon.Standard;
    using Verizon.Standard.Utilities;

    /// <summary>
    /// NodeConfigurationLabel.
    /// </summary>
    public class NodeConfigurationLabel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeConfigurationLabel"/> class.
        /// </summary>
        public NodeConfigurationLabel()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeConfigurationLabel"/> class.
        /// </summary>
        /// <param name="placement">placement.</param>
        public NodeConfigurationLabel(
            string placement = null)
        {
            this.Placement = placement;
        }

        /// <summary>
        /// Gets or sets Placement.
        /// </summary>
        [JsonProperty("placement", NullValueHandling = NullValueHandling.Ignore)]
        public string Placement { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"NodeConfigurationLabel : ({string.Join(", ", toStringOutput)})";
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
            return obj is NodeConfigurationLabel other &&                ((this.Placement == null && other.Placement == null) || (this.Placement?.Equals(other.Placement) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Placement = {(this.Placement == null ? "null" : this.Placement == string.Empty ? "" : this.Placement)}");
        }
    }
}