// <copyright file="ApiResponseCode.cs" company="APIMatic">
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
    /// ApiResponseCode.
    /// </summary>
    public class ApiResponseCode
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseCode"/> class.
        /// </summary>
        public ApiResponseCode()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseCode"/> class.
        /// </summary>
        /// <param name="responseCode">responseCode.</param>
        /// <param name="message">message.</param>
        public ApiResponseCode(
            Models.ResponseCodeEnum responseCode,
            string message)
        {
            this.ResponseCode = responseCode;
            this.Message = message;
        }

        /// <summary>
        /// Possible response codes.
        /// </summary>
        [JsonProperty("responseCode")]
        public Models.ResponseCodeEnum ResponseCode { get; set; }

        /// <summary>
        /// More details about the responseCode received.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ApiResponseCode : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ApiResponseCode other &&
                (this.ResponseCode.Equals(other.ResponseCode)) &&
                (this.Message == null && other.Message == null ||
                 this.Message?.Equals(other.Message) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ResponseCode = {this.ResponseCode}");
            toStringOutput.Add($"Message = {this.Message ?? "null"}");
        }
    }
}