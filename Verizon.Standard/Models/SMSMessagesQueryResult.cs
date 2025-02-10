// <copyright file="SMSMessagesQueryResult.cs" company="APIMatic">
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
    /// SMSMessagesQueryResult.
    /// </summary>
    public class SMSMessagesQueryResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SMSMessagesQueryResult"/> class.
        /// </summary>
        public SMSMessagesQueryResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SMSMessagesQueryResult"/> class.
        /// </summary>
        /// <param name="hasMoreData">hasMoreData.</param>
        /// <param name="messages">messages.</param>
        public SMSMessagesQueryResult(
            bool? hasMoreData = null,
            List<Models.SMSMessage> messages = null)
        {
            this.HasMoreData = hasMoreData;
            this.Messages = messages;
        }

        /// <summary>
        /// False for a status 200 response.True for a status 202 response, indicating that there is more data to be retrieved.
        /// </summary>
        [JsonProperty("hasMoreData", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasMoreData { get; set; }

        /// <summary>
        /// An array of up to 100 SMS messages that were sent by devices in the account.
        /// </summary>
        [JsonProperty("messages", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.SMSMessage> Messages { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SMSMessagesQueryResult : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SMSMessagesQueryResult other &&
                (this.HasMoreData == null && other.HasMoreData == null ||
                 this.HasMoreData?.Equals(other.HasMoreData) == true) &&
                (this.Messages == null && other.Messages == null ||
                 this.Messages?.Equals(other.Messages) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"HasMoreData = {(this.HasMoreData == null ? "null" : this.HasMoreData.ToString())}");
            toStringOutput.Add($"Messages = {(this.Messages == null ? "null" : $"[{string.Join(", ", this.Messages)} ]")}");
        }
    }
}