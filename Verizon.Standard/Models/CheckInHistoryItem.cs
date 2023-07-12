// <copyright file="CheckInHistoryItem.cs" company="APIMatic">
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
    /// CheckInHistoryItem.
    /// </summary>
    public class CheckInHistoryItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckInHistoryItem"/> class.
        /// </summary>
        public CheckInHistoryItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckInHistoryItem"/> class.
        /// </summary>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="clientType">clientType.</param>
        /// <param name="result">result.</param>
        /// <param name="failureType">failureType.</param>
        /// <param name="timeCompleted">timeCompleted.</param>
        public CheckInHistoryItem(
            string deviceId,
            string clientType,
            string result,
            string failureType,
            DateTime timeCompleted)
        {
            this.DeviceId = deviceId;
            this.ClientType = clientType;
            this.Result = result;
            this.FailureType = failureType;
            this.TimeCompleted = timeCompleted;
        }

        /// <summary>
        /// Device IMEI.
        /// </summary>
        [JsonProperty("deviceId")]
        public string DeviceId { get; set; }

        /// <summary>
        /// Type of client.
        /// </summary>
        [JsonProperty("clientType")]
        public string ClientType { get; set; }

        /// <summary>
        /// Gets or sets Result.
        /// </summary>
        [JsonProperty("result")]
        public string Result { get; set; }

        /// <summary>
        /// Gets or sets FailureType.
        /// </summary>
        [JsonProperty("failureType")]
        public string FailureType { get; set; }

        /// <summary>
        /// Gets or sets TimeCompleted.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("timeCompleted")]
        public DateTime TimeCompleted { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CheckInHistoryItem : ({string.Join(", ", toStringOutput)})";
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
            return obj is CheckInHistoryItem other &&                ((this.DeviceId == null && other.DeviceId == null) || (this.DeviceId?.Equals(other.DeviceId) == true)) &&
                ((this.ClientType == null && other.ClientType == null) || (this.ClientType?.Equals(other.ClientType) == true)) &&
                ((this.Result == null && other.Result == null) || (this.Result?.Equals(other.Result) == true)) &&
                ((this.FailureType == null && other.FailureType == null) || (this.FailureType?.Equals(other.FailureType) == true)) &&
                this.TimeCompleted.Equals(other.TimeCompleted);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DeviceId = {(this.DeviceId == null ? "null" : this.DeviceId == string.Empty ? "" : this.DeviceId)}");
            toStringOutput.Add($"this.ClientType = {(this.ClientType == null ? "null" : this.ClientType == string.Empty ? "" : this.ClientType)}");
            toStringOutput.Add($"this.Result = {(this.Result == null ? "null" : this.Result == string.Empty ? "" : this.Result)}");
            toStringOutput.Add($"this.FailureType = {(this.FailureType == null ? "null" : this.FailureType == string.Empty ? "" : this.FailureType)}");
            toStringOutput.Add($"this.TimeCompleted = {this.TimeCompleted}");
        }
    }
}