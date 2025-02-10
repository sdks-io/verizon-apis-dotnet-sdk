// <copyright file="AggregateSessionReport.cs" company="APIMatic">
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
    /// AggregateSessionReport.
    /// </summary>
    public class AggregateSessionReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateSessionReport"/> class.
        /// </summary>
        public AggregateSessionReport()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateSessionReport"/> class.
        /// </summary>
        /// <param name="txid">txid.</param>
        /// <param name="usage">usage.</param>
        /// <param name="errors">errors.</param>
        public AggregateSessionReport(
            string txid = null,
            List<Models.AggregateUsageItem> usage = null,
            List<Models.AggregateUsageError> errors = null)
        {
            this.Txid = txid;
            this.Usage = usage;
            this.Errors = errors;
        }

        /// <summary>
        /// A unique string that associates the request with the location report information that is sent in asynchronous callback message.ThingSpace will send a separate callback message for each device that was in the request. All of the callback messages will have the same txid.
        /// </summary>
        [JsonProperty("txid", NullValueHandling = NullValueHandling.Include)]
        public string Txid { get; set; }

        /// <summary>
        /// Contains usage per device.
        /// </summary>
        [JsonProperty("usage", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.AggregateUsageItem> Usage { get; set; }

        /// <summary>
        /// An object containing any errors reported by the device.
        /// </summary>
        [JsonProperty("errors", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.AggregateUsageError> Errors { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"AggregateSessionReport : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AggregateSessionReport other &&
                (this.Txid == null && other.Txid == null ||
                 this.Txid?.Equals(other.Txid) == true) &&
                (this.Usage == null && other.Usage == null ||
                 this.Usage?.Equals(other.Usage) == true) &&
                (this.Errors == null && other.Errors == null ||
                 this.Errors?.Equals(other.Errors) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Txid = {this.Txid ?? "null"}");
            toStringOutput.Add($"Usage = {(this.Usage == null ? "null" : $"[{string.Join(", ", this.Usage)} ]")}");
            toStringOutput.Add($"Errors = {(this.Errors == null ? "null" : $"[{string.Join(", ", this.Errors)} ]")}");
        }
    }
}