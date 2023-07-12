// <copyright file="ServiceLaunchRequestsResult.cs" company="APIMatic">
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
    /// ServiceLaunchRequestsResult.
    /// </summary>
    public class ServiceLaunchRequestsResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceLaunchRequestsResult"/> class.
        /// </summary>
        public ServiceLaunchRequestsResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceLaunchRequestsResult"/> class.
        /// </summary>
        /// <param name="count">count.</param>
        /// <param name="next">next.</param>
        /// <param name="previous">previous.</param>
        /// <param name="resultSet">resultSet.</param>
        public ServiceLaunchRequestsResult(
            int? count = null,
            string next = null,
            string previous = null,
            List<Models.ServiceLaunchRequestResult> resultSet = null)
        {
            this.Count = count;
            this.Next = next;
            this.Previous = previous;
            this.ResultSet = resultSet;
        }

        /// <summary>
        /// Gets or sets Count.
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// Gets or sets Next.
        /// </summary>
        [JsonProperty("next", NullValueHandling = NullValueHandling.Ignore)]
        public string Next { get; set; }

        /// <summary>
        /// Gets or sets Previous.
        /// </summary>
        [JsonProperty("previous", NullValueHandling = NullValueHandling.Ignore)]
        public string Previous { get; set; }

        /// <summary>
        /// Gets or sets ResultSet.
        /// </summary>
        [JsonProperty("resultSet", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ServiceLaunchRequestResult> ResultSet { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServiceLaunchRequestsResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is ServiceLaunchRequestsResult other &&                ((this.Count == null && other.Count == null) || (this.Count?.Equals(other.Count) == true)) &&
                ((this.Next == null && other.Next == null) || (this.Next?.Equals(other.Next) == true)) &&
                ((this.Previous == null && other.Previous == null) || (this.Previous?.Equals(other.Previous) == true)) &&
                ((this.ResultSet == null && other.ResultSet == null) || (this.ResultSet?.Equals(other.ResultSet) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Count = {(this.Count == null ? "null" : this.Count.ToString())}");
            toStringOutput.Add($"this.Next = {(this.Next == null ? "null" : this.Next == string.Empty ? "" : this.Next)}");
            toStringOutput.Add($"this.Previous = {(this.Previous == null ? "null" : this.Previous == string.Empty ? "" : this.Previous)}");
            toStringOutput.Add($"this.ResultSet = {(this.ResultSet == null ? "null" : $"[{string.Join(", ", this.ResultSet)} ]")}");
        }
    }
}