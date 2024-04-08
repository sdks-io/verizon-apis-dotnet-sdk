// <copyright file="V3DeviceStatus.cs" company="APIMatic">
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
    using APIMatic.Core.Utilities.Converters;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Verizon.Standard;
    using Verizon.Standard.Utilities;

    /// <summary>
    /// V3DeviceStatus.
    /// </summary>
    public class V3DeviceStatus
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V3DeviceStatus"/> class.
        /// </summary>
        public V3DeviceStatus()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V3DeviceStatus"/> class.
        /// </summary>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="status">status.</param>
        /// <param name="resultReason">resultReason.</param>
        /// <param name="updatedTime">updatedTime.</param>
        /// <param name="recentAttemptTime">recentAttemptTime.</param>
        /// <param name="nextAttemptTime">nextAttemptTime.</param>
        public V3DeviceStatus(
            string deviceId,
            string status,
            string resultReason = null,
            DateTime? updatedTime = null,
            DateTime? recentAttemptTime = null,
            DateTime? nextAttemptTime = null)
        {
            this.DeviceId = deviceId;
            this.Status = status;
            this.ResultReason = resultReason;
            this.UpdatedTime = updatedTime;
            this.RecentAttemptTime = recentAttemptTime;
            this.NextAttemptTime = nextAttemptTime;
        }

        /// <summary>
        /// Device IMEI.
        /// </summary>
        [JsonProperty("deviceId")]
        public string DeviceId { get; set; }

        /// <summary>
        /// Success or failure.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Result reason.
        /// </summary>
        [JsonProperty("resultReason", NullValueHandling = NullValueHandling.Ignore)]
        public string ResultReason { get; set; }

        /// <summary>
        /// Updated Time.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updatedTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedTime { get; set; }

        /// <summary>
        /// The most recent attempt time.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("recentAttemptTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? RecentAttemptTime { get; set; }

        /// <summary>
        /// Next attempt time.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("nextAttemptTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? NextAttemptTime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V3DeviceStatus : ({string.Join(", ", toStringOutput)})";
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
            return obj is V3DeviceStatus other &&                ((this.DeviceId == null && other.DeviceId == null) || (this.DeviceId?.Equals(other.DeviceId) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.ResultReason == null && other.ResultReason == null) || (this.ResultReason?.Equals(other.ResultReason) == true)) &&
                ((this.UpdatedTime == null && other.UpdatedTime == null) || (this.UpdatedTime?.Equals(other.UpdatedTime) == true)) &&
                ((this.RecentAttemptTime == null && other.RecentAttemptTime == null) || (this.RecentAttemptTime?.Equals(other.RecentAttemptTime) == true)) &&
                ((this.NextAttemptTime == null && other.NextAttemptTime == null) || (this.NextAttemptTime?.Equals(other.NextAttemptTime) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DeviceId = {(this.DeviceId == null ? "null" : this.DeviceId)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status)}");
            toStringOutput.Add($"this.ResultReason = {(this.ResultReason == null ? "null" : this.ResultReason)}");
            toStringOutput.Add($"this.UpdatedTime = {(this.UpdatedTime == null ? "null" : this.UpdatedTime.ToString())}");
            toStringOutput.Add($"this.RecentAttemptTime = {(this.RecentAttemptTime == null ? "null" : this.RecentAttemptTime.ToString())}");
            toStringOutput.Add($"this.NextAttemptTime = {(this.NextAttemptTime == null ? "null" : this.NextAttemptTime.ToString())}");
        }
    }
}