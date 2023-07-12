// <copyright file="AsynchronousLocationRequestResult.cs" company="APIMatic">
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
    /// AsynchronousLocationRequestResult.
    /// </summary>
    public class AsynchronousLocationRequestResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AsynchronousLocationRequestResult"/> class.
        /// </summary>
        public AsynchronousLocationRequestResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsynchronousLocationRequestResult"/> class.
        /// </summary>
        /// <param name="txid">txid.</param>
        /// <param name="status">status.</param>
        /// <param name="estimatedDuration">estimatedDuration.</param>
        public AsynchronousLocationRequestResult(
            string txid = null,
            Models.ReportStatusEnum? status = null,
            string estimatedDuration = null)
        {
            this.Txid = txid;
            this.Status = status;
            this.EstimatedDuration = estimatedDuration;
        }

        /// <summary>
        /// The transaction ID of the report.
        /// </summary>
        [JsonProperty("txid", NullValueHandling = NullValueHandling.Ignore)]
        public string Txid { get; set; }

        /// <summary>
        /// Status of the report.
        /// </summary>
        [JsonProperty("status", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.ReportStatusEnum? Status { get; set; }

        /// <summary>
        /// Estimated number of minutes required to complete the report.
        /// </summary>
        [JsonProperty("estimatedDuration", NullValueHandling = NullValueHandling.Ignore)]
        public string EstimatedDuration { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AsynchronousLocationRequestResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is AsynchronousLocationRequestResult other &&                ((this.Txid == null && other.Txid == null) || (this.Txid?.Equals(other.Txid) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.EstimatedDuration == null && other.EstimatedDuration == null) || (this.EstimatedDuration?.Equals(other.EstimatedDuration) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Txid = {(this.Txid == null ? "null" : this.Txid == string.Empty ? "" : this.Txid)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.EstimatedDuration = {(this.EstimatedDuration == null ? "null" : this.EstimatedDuration == string.Empty ? "" : this.EstimatedDuration)}");
        }
    }
}