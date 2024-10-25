// <copyright file="GIOSmsMessage.cs" company="APIMatic">
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
    /// GIOSmsMessage.
    /// </summary>
    public class GIOSmsMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GIOSmsMessage"/> class.
        /// </summary>
        public GIOSmsMessage()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GIOSmsMessage"/> class.
        /// </summary>
        /// <param name="deviceIds">deviceIds.</param>
        /// <param name="message">message.</param>
        /// <param name="timestamp">timestamp.</param>
        public GIOSmsMessage(
            List<Models.GIODeviceId> deviceIds = null,
            string message = null,
            DateTime? timestamp = null)
        {
            this.DeviceIds = deviceIds;
            this.Message = message;
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// Gets or sets DeviceIds.
        /// </summary>
        [JsonProperty("deviceIds", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.GIODeviceId> DeviceIds { get; set; }

        /// <summary>
        /// Gets or sets Message.
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets Timestamp.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Timestamp { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GIOSmsMessage : ({string.Join(", ", toStringOutput)})";
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
            return obj is GIOSmsMessage other &&                ((this.DeviceIds == null && other.DeviceIds == null) || (this.DeviceIds?.Equals(other.DeviceIds) == true)) &&
                ((this.Message == null && other.Message == null) || (this.Message?.Equals(other.Message) == true)) &&
                ((this.Timestamp == null && other.Timestamp == null) || (this.Timestamp?.Equals(other.Timestamp) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DeviceIds = {(this.DeviceIds == null ? "null" : $"[{string.Join(", ", this.DeviceIds)} ]")}");
            toStringOutput.Add($"this.Message = {(this.Message == null ? "null" : this.Message)}");
            toStringOutput.Add($"this.Timestamp = {(this.Timestamp == null ? "null" : this.Timestamp.ToString())}");
        }
    }
}