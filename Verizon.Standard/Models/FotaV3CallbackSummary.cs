// <copyright file="FotaV3CallbackSummary.cs" company="APIMatic">
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
    /// FotaV3CallbackSummary.
    /// </summary>
    public class FotaV3CallbackSummary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FotaV3CallbackSummary"/> class.
        /// </summary>
        public FotaV3CallbackSummary()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FotaV3CallbackSummary"/> class.
        /// </summary>
        /// <param name="url">url.</param>
        public FotaV3CallbackSummary(
            string url = null)
        {
            this.Url = url;
        }

        /// <summary>
        /// Callback URL for an subscribed service.
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"FotaV3CallbackSummary : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is FotaV3CallbackSummary other &&
                (this.Url == null && other.Url == null ||
                 this.Url?.Equals(other.Url) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Url = {this.Url ?? "null"}");
        }
    }
}