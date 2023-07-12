// <copyright file="ConnectionHistoryResult.cs" company="APIMatic">
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
    /// ConnectionHistoryResult.
    /// </summary>
    public class ConnectionHistoryResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionHistoryResult"/> class.
        /// </summary>
        public ConnectionHistoryResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionHistoryResult"/> class.
        /// </summary>
        /// <param name="connectionHistory">connectionHistory.</param>
        /// <param name="hasMoreData">hasMoreData.</param>
        public ConnectionHistoryResult(
            List<Models.ConnectionEvent> connectionHistory = null,
            bool? hasMoreData = null)
        {
            this.ConnectionHistory = connectionHistory;
            this.HasMoreData = hasMoreData;
        }

        /// <summary>
        /// Device connection events, sorted by the occurredAt timestamp, oldest first.
        /// </summary>
        [JsonProperty("connectionHistory", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ConnectionEvent> ConnectionHistory { get; set; }

        /// <summary>
        /// False for a status 200 response.True for a status 202 response, indicating that there is more data to be retrieved. Send another request, adjusting the earliest value in the request based on the occuredAt value for the last device in the current response.
        /// </summary>
        [JsonProperty("hasMoreData", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasMoreData { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ConnectionHistoryResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is ConnectionHistoryResult other &&                ((this.ConnectionHistory == null && other.ConnectionHistory == null) || (this.ConnectionHistory?.Equals(other.ConnectionHistory) == true)) &&
                ((this.HasMoreData == null && other.HasMoreData == null) || (this.HasMoreData?.Equals(other.HasMoreData) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ConnectionHistory = {(this.ConnectionHistory == null ? "null" : $"[{string.Join(", ", this.ConnectionHistory)} ]")}");
            toStringOutput.Add($"this.HasMoreData = {(this.HasMoreData == null ? "null" : this.HasMoreData.ToString())}");
        }
    }
}