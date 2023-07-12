// <copyright file="ServiceResumeResult.cs" company="APIMatic">
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
    /// ServiceResumeResult.
    /// </summary>
    public class ServiceResumeResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceResumeResult"/> class.
        /// </summary>
        public ServiceResumeResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceResumeResult"/> class.
        /// </summary>
        /// <param name="requestId">requestId.</param>
        /// <param name="correlationId">correlationId.</param>
        /// <param name="message">message.</param>
        /// <param name="status">status.</param>
        /// <param name="subStatus">subStatus.</param>
        public ServiceResumeResult(
            string requestId = null,
            string correlationId = null,
            string message = null,
            string status = null,
            string subStatus = null)
        {
            this.RequestId = requestId;
            this.CorrelationId = correlationId;
            this.Message = message;
            this.Status = status;
            this.SubStatus = subStatus;
        }

        /// <summary>
        /// Gets or sets RequestId.
        /// </summary>
        [JsonProperty("requestId", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// Gets or sets CorrelationId.
        /// </summary>
        [JsonProperty("correlationId", NullValueHandling = NullValueHandling.Ignore)]
        public string CorrelationId { get; set; }

        /// <summary>
        /// Gets or sets Message.
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets SubStatus.
        /// </summary>
        [JsonProperty("subStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string SubStatus { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServiceResumeResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is ServiceResumeResult other &&                ((this.RequestId == null && other.RequestId == null) || (this.RequestId?.Equals(other.RequestId) == true)) &&
                ((this.CorrelationId == null && other.CorrelationId == null) || (this.CorrelationId?.Equals(other.CorrelationId) == true)) &&
                ((this.Message == null && other.Message == null) || (this.Message?.Equals(other.Message) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.SubStatus == null && other.SubStatus == null) || (this.SubStatus?.Equals(other.SubStatus) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RequestId = {(this.RequestId == null ? "null" : this.RequestId == string.Empty ? "" : this.RequestId)}");
            toStringOutput.Add($"this.CorrelationId = {(this.CorrelationId == null ? "null" : this.CorrelationId == string.Empty ? "" : this.CorrelationId)}");
            toStringOutput.Add($"this.Message = {(this.Message == null ? "null" : this.Message == string.Empty ? "" : this.Message)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.SubStatus = {(this.SubStatus == null ? "null" : this.SubStatus == string.Empty ? "" : this.SubStatus)}");
        }
    }
}