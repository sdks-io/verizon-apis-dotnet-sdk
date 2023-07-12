// <copyright file="Compatibility.cs" company="APIMatic">
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
    /// Compatibility.
    /// </summary>
    public class Compatibility
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Compatibility"/> class.
        /// </summary>
        public Compatibility()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Compatibility"/> class.
        /// </summary>
        /// <param name="csp">csp.</param>
        public Compatibility(
            Models.CSPCompatibilityEnum? csp = Models.CSPCompatibilityEnum.AWSWL)
        {
            this.Csp = csp;
        }

        /// <summary>
        /// Cloud service provider e.g. AWS_PUBLIC_CLOUD, AWS_WL, AWS_OUTPOST, AZURE_EDGE, AZURE_PUBLIC_CLOUD.
        /// </summary>
        [JsonProperty("csp", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.CSPCompatibilityEnum? Csp { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Compatibility : ({string.Join(", ", toStringOutput)})";
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
            return obj is Compatibility other &&                ((this.Csp == null && other.Csp == null) || (this.Csp?.Equals(other.Csp) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Csp = {(this.Csp == null ? "null" : this.Csp.ToString())}");
        }
    }
}