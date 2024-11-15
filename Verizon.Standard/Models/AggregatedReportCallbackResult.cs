// <copyright file="AggregatedReportCallbackResult.cs" company="APIMatic">
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
    /// AggregatedReportCallbackResult.
    /// </summary>
    public class AggregatedReportCallbackResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregatedReportCallbackResult"/> class.
        /// </summary>
        public AggregatedReportCallbackResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregatedReportCallbackResult"/> class.
        /// </summary>
        /// <param name="txid">txid.</param>
        /// <param name="status">status.</param>
        public AggregatedReportCallbackResult(
            string txid,
            Models.AggregatedReportCallbackStatusEnum? status = null)
        {
            this.Txid = txid;
            this.Status = status;
        }

        /// <summary>
        /// A unique string that associates the request with the location report information that is sent in asynchronous callback message.ThingSpace will send a separate callback message for each device that was in the request. All of the callback messages will have the same txid.
        /// </summary>
        [JsonProperty("txid")]
        public string Txid { get; set; }

        /// <summary>
        /// QUEUED or COMPLETED. Requests for IoT devices with cacheMode=0 (cached) have status=COMPLETED; all other requests are QUEUED.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AggregatedReportCallbackStatusEnum? Status { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AggregatedReportCallbackResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is AggregatedReportCallbackResult other &&                ((this.Txid == null && other.Txid == null) || (this.Txid?.Equals(other.Txid) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Txid = {(this.Txid == null ? "null" : this.Txid)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
        }
    }
}