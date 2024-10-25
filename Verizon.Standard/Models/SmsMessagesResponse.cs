// <copyright file="SmsMessagesResponse.cs" company="APIMatic">
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
    /// SmsMessagesResponse.
    /// </summary>
    public class SmsMessagesResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SmsMessagesResponse"/> class.
        /// </summary>
        public SmsMessagesResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SmsMessagesResponse"/> class.
        /// </summary>
        /// <param name="messages">messages.</param>
        /// <param name="hasMoreData">hasMoreData.</param>
        public SmsMessagesResponse(
            List<Models.GIOSmsMessage> messages = null,
            bool? hasMoreData = null)
        {
            this.Messages = messages;
            this.HasMoreData = hasMoreData;
        }

        /// <summary>
        /// Gets or sets Messages.
        /// </summary>
        [JsonProperty("messages", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.GIOSmsMessage> Messages { get; set; }

        /// <summary>
        /// Gets or sets HasMoreData.
        /// </summary>
        [JsonProperty("hasMoreData", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasMoreData { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SmsMessagesResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is SmsMessagesResponse other &&                ((this.Messages == null && other.Messages == null) || (this.Messages?.Equals(other.Messages) == true)) &&
                ((this.HasMoreData == null && other.HasMoreData == null) || (this.HasMoreData?.Equals(other.HasMoreData) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Messages = {(this.Messages == null ? "null" : $"[{string.Join(", ", this.Messages)} ]")}");
            toStringOutput.Add($"this.HasMoreData = {(this.HasMoreData == null ? "null" : this.HasMoreData.ToString())}");
        }
    }
}