// <copyright file="StatusConditionItem.cs" company="APIMatic">
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
    /// StatusConditionItem.
    /// </summary>
    public class StatusConditionItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusConditionItem"/> class.
        /// </summary>
        public StatusConditionItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatusConditionItem"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="status">status.</param>
        /// <param name="lastHeartbeatTime">lastHeartbeatTime.</param>
        /// <param name="lastTransitionTime">lastTransitionTime.</param>
        /// <param name="reason">reason.</param>
        /// <param name="message">message.</param>
        public StatusConditionItem(
            string type = null,
            string status = null,
            DateTime? lastHeartbeatTime = null,
            DateTime? lastTransitionTime = null,
            string reason = null,
            string message = null)
        {
            this.Type = type;
            this.Status = status;
            this.LastHeartbeatTime = lastHeartbeatTime;
            this.LastTransitionTime = lastTransitionTime;
            this.Reason = reason;
            this.Message = message;
        }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets LastHeartbeatTime.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("lastHeartbeatTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastHeartbeatTime { get; set; }

        /// <summary>
        /// Gets or sets LastTransitionTime.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("lastTransitionTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastTransitionTime { get; set; }

        /// <summary>
        /// Gets or sets Reason.
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or sets Message.
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"StatusConditionItem : ({string.Join(", ", toStringOutput)})";
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
            return obj is StatusConditionItem other &&                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.LastHeartbeatTime == null && other.LastHeartbeatTime == null) || (this.LastHeartbeatTime?.Equals(other.LastHeartbeatTime) == true)) &&
                ((this.LastTransitionTime == null && other.LastTransitionTime == null) || (this.LastTransitionTime?.Equals(other.LastTransitionTime) == true)) &&
                ((this.Reason == null && other.Reason == null) || (this.Reason?.Equals(other.Reason) == true)) &&
                ((this.Message == null && other.Message == null) || (this.Message?.Equals(other.Message) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.LastHeartbeatTime = {(this.LastHeartbeatTime == null ? "null" : this.LastHeartbeatTime.ToString())}");
            toStringOutput.Add($"this.LastTransitionTime = {(this.LastTransitionTime == null ? "null" : this.LastTransitionTime.ToString())}");
            toStringOutput.Add($"this.Reason = {(this.Reason == null ? "null" : this.Reason == string.Empty ? "" : this.Reason)}");
            toStringOutput.Add($"this.Message = {(this.Message == null ? "null" : this.Message == string.Empty ? "" : this.Message)}");
        }
    }
}