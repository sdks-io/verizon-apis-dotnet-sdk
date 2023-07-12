// <copyright file="DefaultLocation.cs" company="APIMatic">
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
    /// DefaultLocation.
    /// </summary>
    public class DefaultLocation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultLocation"/> class.
        /// </summary>
        public DefaultLocation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultLocation"/> class.
        /// </summary>
        /// <param name="region">region.</param>
        /// <param name="zone">zone.</param>
        public DefaultLocation(
            string region = null,
            string zone = null)
        {
            this.Region = region;
            this.Zone = zone;
        }

        /// <summary>
        /// CSP region where service needs to be deployed.
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// Zone within a region where service needs to be deployed.
        /// </summary>
        [JsonProperty("zone", NullValueHandling = NullValueHandling.Ignore)]
        public string Zone { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DefaultLocation : ({string.Join(", ", toStringOutput)})";
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
            return obj is DefaultLocation other &&                ((this.Region == null && other.Region == null) || (this.Region?.Equals(other.Region) == true)) &&
                ((this.Zone == null && other.Zone == null) || (this.Zone?.Equals(other.Zone) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Region = {(this.Region == null ? "null" : this.Region == string.Empty ? "" : this.Region)}");
            toStringOutput.Add($"this.Zone = {(this.Zone == null ? "null" : this.Zone == string.Empty ? "" : this.Zone)}");
        }
    }
}