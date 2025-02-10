// <copyright file="NetworkType.cs" company="APIMatic">
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
    /// NetworkType.
    /// </summary>
    public class NetworkType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkType"/> class.
        /// </summary>
        public NetworkType()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkType"/> class.
        /// </summary>
        /// <param name="networkTypeProp">networkType.</param>
        public NetworkType(
            string networkTypeProp = null)
        {
            this.NetworkTypeProp = networkTypeProp;
        }

        /// <summary>
        /// Gets or sets NetworkTypeProp.
        /// </summary>
        [JsonProperty("networkType", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkTypeProp { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"NetworkType : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is NetworkType other &&
                (this.NetworkTypeProp == null && other.NetworkTypeProp == null ||
                 this.NetworkTypeProp?.Equals(other.NetworkTypeProp) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"NetworkTypeProp = {this.NetworkTypeProp ?? "null"}");
        }
    }
}