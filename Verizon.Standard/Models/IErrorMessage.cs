// <copyright file="IErrorMessage.cs" company="APIMatic">
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
    /// IErrorMessage.
    /// </summary>
    public class IErrorMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IErrorMessage"/> class.
        /// </summary>
        public IErrorMessage()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IErrorMessage"/> class.
        /// </summary>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="httpStatusCode">httpStatusCode.</param>
        /// <param name="detailErrorMessage">detailErrorMessage.</param>
        public IErrorMessage(
            Models.ErrorResponseCodeEnum? errorCode = null,
            string errorMessage = null,
            Models.HttpStatusCodeEnum? httpStatusCode = null,
            string detailErrorMessage = null)
        {
            this.ErrorCode = errorCode;
            this.ErrorMessage = errorMessage;
            this.HttpStatusCode = httpStatusCode;
            this.DetailErrorMessage = detailErrorMessage;
        }

        /// <summary>
        /// Error Code.
        /// </summary>
        [JsonProperty("errorCode", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ErrorResponseCodeEnum? ErrorCode { get; set; }

        /// <summary>
        /// Details and additional information about the error code.
        /// </summary>
        [JsonProperty("errorMessage", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// HTML error code and description.
        /// </summary>
        [JsonProperty("httpStatusCode", NullValueHandling = NullValueHandling.Ignore)]
        public Models.HttpStatusCodeEnum? HttpStatusCode { get; set; }

        /// <summary>
        /// More detail and information about the HTML error code.
        /// </summary>
        [JsonProperty("detailErrorMessage", NullValueHandling = NullValueHandling.Ignore)]
        public string DetailErrorMessage { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"IErrorMessage : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is IErrorMessage other &&
                (this.ErrorCode == null && other.ErrorCode == null ||
                 this.ErrorCode?.Equals(other.ErrorCode) == true) &&
                (this.ErrorMessage == null && other.ErrorMessage == null ||
                 this.ErrorMessage?.Equals(other.ErrorMessage) == true) &&
                (this.HttpStatusCode == null && other.HttpStatusCode == null ||
                 this.HttpStatusCode?.Equals(other.HttpStatusCode) == true) &&
                (this.DetailErrorMessage == null && other.DetailErrorMessage == null ||
                 this.DetailErrorMessage?.Equals(other.DetailErrorMessage) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ErrorCode = {(this.ErrorCode == null ? "null" : this.ErrorCode.ToString())}");
            toStringOutput.Add($"ErrorMessage = {this.ErrorMessage ?? "null"}");
            toStringOutput.Add($"HttpStatusCode = {(this.HttpStatusCode == null ? "null" : this.HttpStatusCode.ToString())}");
            toStringOutput.Add($"DetailErrorMessage = {this.DetailErrorMessage ?? "null"}");
        }
    }
}