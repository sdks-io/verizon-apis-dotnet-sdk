// <copyright file="DailyUsageItem.cs" company="APIMatic">
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
    /// DailyUsageItem.
    /// </summary>
    public class DailyUsageItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DailyUsageItem"/> class.
        /// </summary>
        public DailyUsageItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DailyUsageItem"/> class.
        /// </summary>
        /// <param name="startTime">startTime.</param>
        /// <param name="endTime">endTime.</param>
        /// <param name="numBytes">numBytes.</param>
        public DailyUsageItem(
            string startTime = null,
            string endTime = null,
            int? numBytes = null)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.NumBytes = numBytes;
        }

        /// <summary>
        /// Start date of session. ISO 8601 format.
        /// </summary>
        [JsonProperty("startTime", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// End date of session. ISO 8601 format.
        /// </summary>
        [JsonProperty("endTime", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// Amount of data transferred, measured in Bytes.
        /// </summary>
        [JsonProperty("numBytes", NullValueHandling = NullValueHandling.Ignore)]
        public int? NumBytes { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DailyUsageItem : ({string.Join(", ", toStringOutput)})";
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
            return obj is DailyUsageItem other &&                ((this.StartTime == null && other.StartTime == null) || (this.StartTime?.Equals(other.StartTime) == true)) &&
                ((this.EndTime == null && other.EndTime == null) || (this.EndTime?.Equals(other.EndTime) == true)) &&
                ((this.NumBytes == null && other.NumBytes == null) || (this.NumBytes?.Equals(other.NumBytes) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.StartTime = {(this.StartTime == null ? "null" : this.StartTime == string.Empty ? "" : this.StartTime)}");
            toStringOutput.Add($"this.EndTime = {(this.EndTime == null ? "null" : this.EndTime == string.Empty ? "" : this.EndTime)}");
            toStringOutput.Add($"this.NumBytes = {(this.NumBytes == null ? "null" : this.NumBytes.ToString())}");
        }
    }
}