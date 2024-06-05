// <copyright file="RequestBodyForUsage1.cs" company="APIMatic">
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
    /// RequestBodyForUsage1.
    /// </summary>
    public class RequestBodyForUsage1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestBodyForUsage1"/> class.
        /// </summary>
        public RequestBodyForUsage1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestBodyForUsage1"/> class.
        /// </summary>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="startTime">startTime.</param>
        /// <param name="endTime">endTime.</param>
        public RequestBodyForUsage1(
            List<Models.ReadySimDeviceId> deviceId = null,
            DateTime? startTime = null,
            DateTime? endTime = null)
        {
            this.DeviceId = deviceId;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        /// <summary>
        /// Gets or sets DeviceId.
        /// </summary>
        [JsonProperty("deviceId", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ReadySimDeviceId> DeviceId { get; set; }

        /// <summary>
        /// Gets or sets StartTime.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("startTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets EndTime.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("endTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EndTime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RequestBodyForUsage1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is RequestBodyForUsage1 other &&                ((this.DeviceId == null && other.DeviceId == null) || (this.DeviceId?.Equals(other.DeviceId) == true)) &&
                ((this.StartTime == null && other.StartTime == null) || (this.StartTime?.Equals(other.StartTime) == true)) &&
                ((this.EndTime == null && other.EndTime == null) || (this.EndTime?.Equals(other.EndTime) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DeviceId = {(this.DeviceId == null ? "null" : $"[{string.Join(", ", this.DeviceId)} ]")}");
            toStringOutput.Add($"this.StartTime = {(this.StartTime == null ? "null" : this.StartTime.ToString())}");
            toStringOutput.Add($"this.EndTime = {(this.EndTime == null ? "null" : this.EndTime.ToString())}");
        }
    }
}