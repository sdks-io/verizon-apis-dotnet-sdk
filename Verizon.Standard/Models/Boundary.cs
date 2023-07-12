// <copyright file="Boundary.cs" company="APIMatic">
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
    /// Boundary.
    /// </summary>
    public class Boundary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Boundary"/> class.
        /// </summary>
        public Boundary()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Boundary"/> class.
        /// </summary>
        /// <param name="csp">csp.</param>
        /// <param name="region">region.</param>
        /// <param name="zoneId">zoneId.</param>
        public Boundary(
            Models.CSPCompatibilityEnum? csp = Models.CSPCompatibilityEnum.AWSWL,
            string region = null,
            List<string> zoneId = null)
        {
            this.Csp = csp;
            this.Region = region;
            this.ZoneId = zoneId;
        }

        /// <summary>
        /// Cloud service provider e.g. AWS_PUBLIC_CLOUD, AWS_WL, AWS_OUTPOST, AZURE_EDGE, AZURE_PUBLIC_CLOUD.
        /// </summary>
        [JsonProperty("csp", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.CSPCompatibilityEnum? Csp { get; set; }

        /// <summary>
        /// Boundary region e.g. US East (Ohio).
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// Zones listed under a specific region.
        /// </summary>
        [JsonProperty("zoneId", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ZoneId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Boundary : ({string.Join(", ", toStringOutput)})";
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
            return obj is Boundary other &&                ((this.Csp == null && other.Csp == null) || (this.Csp?.Equals(other.Csp) == true)) &&
                ((this.Region == null && other.Region == null) || (this.Region?.Equals(other.Region) == true)) &&
                ((this.ZoneId == null && other.ZoneId == null) || (this.ZoneId?.Equals(other.ZoneId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Csp = {(this.Csp == null ? "null" : this.Csp.ToString())}");
            toStringOutput.Add($"this.Region = {(this.Region == null ? "null" : this.Region == string.Empty ? "" : this.Region)}");
            toStringOutput.Add($"this.ZoneId = {(this.ZoneId == null ? "null" : $"[{string.Join(", ", this.ZoneId)} ]")}");
        }
    }
}