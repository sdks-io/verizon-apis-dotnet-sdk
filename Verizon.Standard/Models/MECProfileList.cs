// <copyright file="MECProfileList.cs" company="APIMatic">
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
    /// MECProfileList.
    /// </summary>
    public class MECProfileList
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MECProfileList"/> class.
        /// </summary>
        public MECProfileList()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MECProfileList"/> class.
        /// </summary>
        /// <param name="profiles">profiles.</param>
        public MECProfileList(
            List<Models.MECProfile> profiles = null)
        {
            this.Profiles = profiles;
        }

        /// <summary>
        /// Gets or sets Profiles.
        /// </summary>
        [JsonProperty("profiles", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.MECProfile> Profiles { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MECProfileList : ({string.Join(", ", toStringOutput)})";
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
            return obj is MECProfileList other &&                ((this.Profiles == null && other.Profiles == null) || (this.Profiles?.Equals(other.Profiles) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Profiles = {(this.Profiles == null ? "null" : $"[{string.Join(", ", this.Profiles)} ]")}");
        }
    }
}