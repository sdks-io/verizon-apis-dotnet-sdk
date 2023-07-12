// <copyright file="MECSiteLocationsResult.cs" company="APIMatic">
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
    /// MECSiteLocationsResult.
    /// </summary>
    public class MECSiteLocationsResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MECSiteLocationsResult"/> class.
        /// </summary>
        public MECSiteLocationsResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MECSiteLocationsResult"/> class.
        /// </summary>
        /// <param name="mecsites">mecsites.</param>
        public MECSiteLocationsResult(
            List<Models.MECSiteLocation> mecsites = null)
        {
            this.Mecsites = mecsites;
        }

        /// <summary>
        /// Gets or sets Mecsites.
        /// </summary>
        [JsonProperty("mecsites", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.MECSiteLocation> Mecsites { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MECSiteLocationsResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is MECSiteLocationsResult other &&                ((this.Mecsites == null && other.Mecsites == null) || (this.Mecsites?.Equals(other.Mecsites) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Mecsites = {(this.Mecsites == null ? "null" : $"[{string.Join(", ", this.Mecsites)} ]")}");
        }
    }
}