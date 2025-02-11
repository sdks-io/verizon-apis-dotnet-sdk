// <copyright file="DeleteServiceProfileResult.cs" company="APIMatic">
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
    /// DeleteServiceProfileResult.
    /// </summary>
    public class DeleteServiceProfileResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteServiceProfileResult"/> class.
        /// </summary>
        public DeleteServiceProfileResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteServiceProfileResult"/> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="message">message.</param>
        public DeleteServiceProfileResult(
            string status = null,
            string message = null)
        {
            this.Status = status;
            this.Message = message;
        }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets Message.
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DeleteServiceProfileResult : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DeleteServiceProfileResult other &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.Message == null && other.Message == null ||
                 this.Message?.Equals(other.Message) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Status = {this.Status ?? "null"}");
            toStringOutput.Add($"Message = {this.Message ?? "null"}");
        }
    }
}