// <copyright file="DiagnosticsObservationResult.cs" company="APIMatic">
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
    /// DiagnosticsObservationResult.
    /// </summary>
    public class DiagnosticsObservationResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticsObservationResult"/> class.
        /// </summary>
        public DiagnosticsObservationResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticsObservationResult"/> class.
        /// </summary>
        /// <param name="transactionID">transactionID.</param>
        /// <param name="status">status.</param>
        /// <param name="createdOn">createdOn.</param>
        public DiagnosticsObservationResult(
            string transactionID,
            string status,
            DateTime createdOn)
        {
            this.TransactionID = transactionID;
            this.Status = status;
            this.CreatedOn = createdOn;
        }

        /// <summary>
        /// Transaction identifier.
        /// </summary>
        [JsonProperty("transactionID")]
        public string TransactionID { get; set; }

        /// <summary>
        /// Status of the request.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// The date and time of when this request was created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdOn")]
        public DateTime CreatedOn { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DiagnosticsObservationResult : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DiagnosticsObservationResult other &&
                (this.TransactionID == null && other.TransactionID == null ||
                 this.TransactionID?.Equals(other.TransactionID) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.CreatedOn.Equals(other.CreatedOn));
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"TransactionID = {this.TransactionID ?? "null"}");
            toStringOutput.Add($"Status = {this.Status ?? "null"}");
            toStringOutput.Add($"CreatedOn = {this.CreatedOn}");
        }
    }
}