// <copyright file="PWNProfileList.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
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

namespace Verizon.Standard.Models
{
    /// <summary>
    /// PWNProfileList.
    /// </summary>
    public class PWNProfileList
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PWNProfileList"/> class.
        /// </summary>
        public PWNProfileList()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PWNProfileList"/> class.
        /// </summary>
        /// <param name="profiles">profiles.</param>
        public PWNProfileList(
            List<Models.PWNProfile> profiles = null)
        {
            this.Profiles = profiles;
        }

        /// <summary>
        /// Gets or sets Profiles.
        /// </summary>
        [JsonProperty("profiles", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.PWNProfile> Profiles { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PWNProfileList : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PWNProfileList other &&
                (this.Profiles == null && other.Profiles == null ||
                 this.Profiles?.Equals(other.Profiles) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Profiles = {(this.Profiles == null ? "null" : $"[{string.Join(", ", this.Profiles)} ]")}");
        }
    }
}