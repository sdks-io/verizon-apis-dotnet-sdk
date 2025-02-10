// <copyright file="TargetAuthenticationBodyHeaders.cs" company="APIMatic">
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
    /// TargetAuthenticationBodyHeaders.
    /// </summary>
    public class TargetAuthenticationBodyHeaders
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TargetAuthenticationBodyHeaders"/> class.
        /// </summary>
        public TargetAuthenticationBodyHeaders()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TargetAuthenticationBodyHeaders"/> class.
        /// </summary>
        /// <param name="authorization">Authorization.</param>
        /// <param name="contentType">Content-Type.</param>
        public TargetAuthenticationBodyHeaders(
            string authorization = null,
            string contentType = null)
        {
            this.Authorization = authorization;
            this.ContentType = contentType;
        }

        /// <summary>
        /// Authorization header.
        /// </summary>
        [JsonProperty("Authorization", NullValueHandling = NullValueHandling.Ignore)]
        public string Authorization { get; set; }

        /// <summary>
        /// Content-Type header.
        /// </summary>
        [JsonProperty("Content-Type", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"TargetAuthenticationBodyHeaders : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is TargetAuthenticationBodyHeaders other &&
                (this.Authorization == null && other.Authorization == null ||
                 this.Authorization?.Equals(other.Authorization) == true) &&
                (this.ContentType == null && other.ContentType == null ||
                 this.ContentType?.Equals(other.ContentType) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Authorization = {this.Authorization ?? "null"}");
            toStringOutput.Add($"ContentType = {this.ContentType ?? "null"}");
        }
    }
}