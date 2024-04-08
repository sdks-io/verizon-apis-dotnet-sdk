// <copyright file="ListMECPlatformsResult.cs" company="APIMatic">
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
    /// ListMECPlatformsResult.
    /// </summary>
    public class ListMECPlatformsResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListMECPlatformsResult"/> class.
        /// </summary>
        public ListMECPlatformsResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMECPlatformsResult"/> class.
        /// </summary>
        /// <param name="mECPlatforms">MECPlatforms.</param>
        public ListMECPlatformsResult(
            List<Models.MECPlatformResource> mECPlatforms = null)
        {
            this.MECPlatforms = mECPlatforms;
        }

        /// <summary>
        /// A list of optimal MEC Platforms where you can register your deployed application.
        /// </summary>
        [JsonProperty("MECPlatforms", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.MECPlatformResource> MECPlatforms { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListMECPlatformsResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is ListMECPlatformsResult other &&                ((this.MECPlatforms == null && other.MECPlatforms == null) || (this.MECPlatforms?.Equals(other.MECPlatforms) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MECPlatforms = {(this.MECPlatforms == null ? "null" : $"[{string.Join(", ", this.MECPlatforms)} ]")}");
        }
    }
}