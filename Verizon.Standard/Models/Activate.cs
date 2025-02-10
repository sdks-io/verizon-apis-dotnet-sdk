// <copyright file="Activate.cs" company="APIMatic">
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
    /// Activate.
    /// </summary>
    public class Activate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Activate"/> class.
        /// </summary>
        public Activate()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Activate"/> class.
        /// </summary>
        /// <param name="profile">profile.</param>
        public Activate(
            string profile)
        {
            this.Profile = profile;
        }

        /// <summary>
        /// Gets or sets Profile.
        /// </summary>
        [JsonProperty("profile")]
        public string Profile { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Activate : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Activate other &&
                (this.Profile == null && other.Profile == null ||
                 this.Profile?.Equals(other.Profile) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Profile = {this.Profile ?? "null"}");
        }
    }
}