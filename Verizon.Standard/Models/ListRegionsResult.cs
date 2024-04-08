// <copyright file="ListRegionsResult.cs" company="APIMatic">
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
    /// ListRegionsResult.
    /// </summary>
    public class ListRegionsResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListRegionsResult"/> class.
        /// </summary>
        public ListRegionsResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListRegionsResult"/> class.
        /// </summary>
        /// <param name="regions">regions.</param>
        public ListRegionsResult(
            List<Models.Region> regions = null)
        {
            this.Regions = regions;
        }

        /// <summary>
        /// An array of all regions in the Verizon 5G Edge service.
        /// </summary>
        [JsonProperty("regions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Region> Regions { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListRegionsResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is ListRegionsResult other &&                ((this.Regions == null && other.Regions == null) || (this.Regions?.Equals(other.Regions) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Regions = {(this.Regions == null ? "null" : $"[{string.Join(", ", this.Regions)} ]")}");
        }
    }
}