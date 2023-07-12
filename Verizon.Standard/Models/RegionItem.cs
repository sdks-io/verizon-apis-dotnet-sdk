// <copyright file="RegionItem.cs" company="APIMatic">
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
    /// RegionItem.
    /// </summary>
    public class RegionItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegionItem"/> class.
        /// </summary>
        public RegionItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionItem"/> class.
        /// </summary>
        /// <param name="region">region.</param>
        /// <param name="zones">zones.</param>
        public RegionItem(
            string region = null,
            List<Models.ZoneItem> zones = null)
        {
            this.Region = region;
            this.Zones = zones;
        }

        /// <summary>
        /// Region name.
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// Gets or sets Zones.
        /// </summary>
        [JsonProperty("zones", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ZoneItem> Zones { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RegionItem : ({string.Join(", ", toStringOutput)})";
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
            return obj is RegionItem other &&                ((this.Region == null && other.Region == null) || (this.Region?.Equals(other.Region) == true)) &&
                ((this.Zones == null && other.Zones == null) || (this.Zones?.Equals(other.Zones) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Region = {(this.Region == null ? "null" : this.Region == string.Empty ? "" : this.Region)}");
            toStringOutput.Add($"this.Zones = {(this.Zones == null ? "null" : $"[{string.Join(", ", this.Zones)} ]")}");
        }
    }
}