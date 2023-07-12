// <copyright file="TargetAuthenticationBodyHost.cs" company="APIMatic">
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
    /// TargetAuthenticationBodyHost.
    /// </summary>
    public class TargetAuthenticationBodyHost
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TargetAuthenticationBodyHost"/> class.
        /// </summary>
        public TargetAuthenticationBodyHost()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TargetAuthenticationBodyHost"/> class.
        /// </summary>
        /// <param name="hostandpath">hostandpath.</param>
        public TargetAuthenticationBodyHost(
            string hostandpath = null)
        {
            this.Hostandpath = hostandpath;
        }

        /// <summary>
        /// Gets or sets Hostandpath.
        /// </summary>
        [JsonProperty("hostandpath", NullValueHandling = NullValueHandling.Ignore)]
        public string Hostandpath { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TargetAuthenticationBodyHost : ({string.Join(", ", toStringOutput)})";
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
            return obj is TargetAuthenticationBodyHost other &&                ((this.Hostandpath == null && other.Hostandpath == null) || (this.Hostandpath?.Equals(other.Hostandpath) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Hostandpath = {(this.Hostandpath == null ? "null" : this.Hostandpath == string.Empty ? "" : this.Hostandpath)}");
        }
    }
}