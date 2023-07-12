// <copyright file="TargetAuthenticationBodyHeaders.cs" company="APIMatic">
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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is TargetAuthenticationBodyHeaders other &&                ((this.Authorization == null && other.Authorization == null) || (this.Authorization?.Equals(other.Authorization) == true)) &&
                ((this.ContentType == null && other.ContentType == null) || (this.ContentType?.Equals(other.ContentType) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Authorization = {(this.Authorization == null ? "null" : this.Authorization == string.Empty ? "" : this.Authorization)}");
            toStringOutput.Add($"this.ContentType = {(this.ContentType == null ? "null" : this.ContentType == string.Empty ? "" : this.ContentType)}");
        }
    }
}