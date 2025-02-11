// <copyright file="Acceleration.cs" company="APIMatic">
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
    /// Acceleration.
    /// </summary>
    public class Acceleration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Acceleration"/> class.
        /// </summary>
        public Acceleration()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Acceleration"/> class.
        /// </summary>
        /// <param name="x">x.</param>
        /// <param name="y">y.</param>
        /// <param name="z">z.</param>
        public Acceleration(
            string x = null,
            string y = null,
            string z = null)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        /// <summary>
        /// Gets or sets X.
        /// </summary>
        [JsonProperty("x", NullValueHandling = NullValueHandling.Ignore)]
        public string X { get; set; }

        /// <summary>
        /// Gets or sets Y.
        /// </summary>
        [JsonProperty("y", NullValueHandling = NullValueHandling.Ignore)]
        public string Y { get; set; }

        /// <summary>
        /// Gets or sets Z.
        /// </summary>
        [JsonProperty("z", NullValueHandling = NullValueHandling.Ignore)]
        public string Z { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Acceleration : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Acceleration other &&
                (this.X == null && other.X == null ||
                 this.X?.Equals(other.X) == true) &&
                (this.Y == null && other.Y == null ||
                 this.Y?.Equals(other.Y) == true) &&
                (this.Z == null && other.Z == null ||
                 this.Z?.Equals(other.Z) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"X = {this.X ?? "null"}");
            toStringOutput.Add($"Y = {this.Y ?? "null"}");
            toStringOutput.Add($"Z = {this.Z ?? "null"}");
        }
    }
}