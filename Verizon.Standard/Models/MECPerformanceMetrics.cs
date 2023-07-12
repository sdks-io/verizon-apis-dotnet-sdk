// <copyright file="MECPerformanceMetrics.cs" company="APIMatic">
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
    /// MECPerformanceMetrics.
    /// </summary>
    public class MECPerformanceMetrics
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MECPerformanceMetrics"/> class.
        /// </summary>
        public MECPerformanceMetrics()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MECPerformanceMetrics"/> class.
        /// </summary>
        /// <param name="queryStatus">QueryStatus.</param>
        /// <param name="start">Start.</param>
        /// <param name="end">End.</param>
        /// <param name="queryResult">QueryResult.</param>
        public MECPerformanceMetrics(
            string queryStatus = null,
            string start = null,
            string end = null,
            List<Models.MECPerformanceQueryResult> queryResult = null)
        {
            this.QueryStatus = queryStatus;
            this.Start = start;
            this.End = end;
            this.QueryResult = queryResult;
        }

        /// <summary>
        /// Success or Failed.
        /// </summary>
        [JsonProperty("QueryStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string QueryStatus { get; set; }

        /// <summary>
        /// Timestamp of the query's start, format:mm/dd/yyyy,hr:min:sec.
        /// </summary>
        [JsonProperty("Start", NullValueHandling = NullValueHandling.Ignore)]
        public string Start { get; set; }

        /// <summary>
        /// Timestamp of the query's end , format:mm/dd/yyyy, hr:min:sec.
        /// </summary>
        [JsonProperty("End", NullValueHandling = NullValueHandling.Ignore)]
        public string End { get; set; }

        /// <summary>
        /// MEC performance query result.
        /// </summary>
        [JsonProperty("QueryResult", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.MECPerformanceQueryResult> QueryResult { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MECPerformanceMetrics : ({string.Join(", ", toStringOutput)})";
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
            return obj is MECPerformanceMetrics other &&                ((this.QueryStatus == null && other.QueryStatus == null) || (this.QueryStatus?.Equals(other.QueryStatus) == true)) &&
                ((this.Start == null && other.Start == null) || (this.Start?.Equals(other.Start) == true)) &&
                ((this.End == null && other.End == null) || (this.End?.Equals(other.End) == true)) &&
                ((this.QueryResult == null && other.QueryResult == null) || (this.QueryResult?.Equals(other.QueryResult) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.QueryStatus = {(this.QueryStatus == null ? "null" : this.QueryStatus == string.Empty ? "" : this.QueryStatus)}");
            toStringOutput.Add($"this.Start = {(this.Start == null ? "null" : this.Start == string.Empty ? "" : this.Start)}");
            toStringOutput.Add($"this.End = {(this.End == null ? "null" : this.End == string.Empty ? "" : this.End)}");
            toStringOutput.Add($"this.QueryResult = {(this.QueryResult == null ? "null" : $"[{string.Join(", ", this.QueryResult)} ]")}");
        }
    }
}