// <copyright file="EnablePromoExp.cs" company="APIMatic">
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
    /// EnablePromoExp.
    /// </summary>
    public class EnablePromoExp
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnablePromoExp"/> class.
        /// </summary>
        public EnablePromoExp()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnablePromoExp"/> class.
        /// </summary>
        /// <param name="enablePromoExpProp">enablePromoExp.</param>
        public EnablePromoExp(
            bool? enablePromoExpProp = null)
        {
            this.EnablePromoExpProp = enablePromoExpProp;
        }

        /// <summary>
        /// Gets or sets EnablePromoExpProp.
        /// </summary>
        [JsonProperty("enablePromoExp", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnablePromoExpProp { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"EnablePromoExp : ({string.Join(", ", toStringOutput)})";
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
            return obj is EnablePromoExp other &&                ((this.EnablePromoExpProp == null && other.EnablePromoExpProp == null) || (this.EnablePromoExpProp?.Equals(other.EnablePromoExpProp) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.EnablePromoExpProp = {(this.EnablePromoExpProp == null ? "null" : this.EnablePromoExpProp.ToString())}");
        }
    }
}