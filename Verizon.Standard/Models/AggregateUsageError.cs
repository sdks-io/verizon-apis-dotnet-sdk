// <copyright file="AggregateUsageError.cs" company="APIMatic">
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
    /// AggregateUsageError.
    /// </summary>
    public class AggregateUsageError
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateUsageError"/> class.
        /// </summary>
        public AggregateUsageError()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateUsageError"/> class.
        /// </summary>
        /// <param name="imei">imei.</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="errorResponse">errorResponse.</param>
        public AggregateUsageError(
            string imei = null,
            string errorMessage = null,
            Models.IErrorMessage errorResponse = null)
        {
            this.Imei = imei;
            this.ErrorMessage = errorMessage;
            this.ErrorResponse = errorResponse;
        }

        /// <summary>
        /// International Mobile Equipment Identifier. This is the ID of the device reporting errors.
        /// </summary>
        [JsonProperty("imei", NullValueHandling = NullValueHandling.Ignore)]
        public string Imei { get; set; }

        /// <summary>
        /// A general error message.
        /// </summary>
        [JsonProperty("errorMessage", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Error message.
        /// </summary>
        [JsonProperty("errorResponse", NullValueHandling = NullValueHandling.Ignore)]
        public Models.IErrorMessage ErrorResponse { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"AggregateUsageError : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AggregateUsageError other &&
                (this.Imei == null && other.Imei == null ||
                 this.Imei?.Equals(other.Imei) == true) &&
                (this.ErrorMessage == null && other.ErrorMessage == null ||
                 this.ErrorMessage?.Equals(other.ErrorMessage) == true) &&
                (this.ErrorResponse == null && other.ErrorResponse == null ||
                 this.ErrorResponse?.Equals(other.ErrorResponse) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Imei = {this.Imei ?? "null"}");
            toStringOutput.Add($"ErrorMessage = {this.ErrorMessage ?? "null"}");
            toStringOutput.Add($"ErrorResponse = {(this.ErrorResponse == null ? "null" : this.ErrorResponse.ToString())}");
        }
    }
}