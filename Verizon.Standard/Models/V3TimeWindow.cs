// <copyright file="V3TimeWindow.cs" company="APIMatic">
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
    /// V3TimeWindow.
    /// </summary>
    public class V3TimeWindow
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V3TimeWindow"/> class.
        /// </summary>
        public V3TimeWindow()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V3TimeWindow"/> class.
        /// </summary>
        /// <param name="startTime">startTime.</param>
        /// <param name="endTime">endTime.</param>
        public V3TimeWindow(
            int startTime,
            int endTime)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        /// <summary>
        /// Start hour in range [0..23], current hour >= startTime.
        /// </summary>
        [JsonProperty("startTime")]
        public int StartTime { get; set; }

        /// <summary>
        /// End hour in range [1..24], current hour < endTime.
        /// </summary>
        [JsonProperty("endTime")]
        public int EndTime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V3TimeWindow : ({string.Join(", ", toStringOutput)})";
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
            return obj is V3TimeWindow other &&                this.StartTime.Equals(other.StartTime) &&
                this.EndTime.Equals(other.EndTime);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.StartTime = {this.StartTime}");
            toStringOutput.Add($"this.EndTime = {this.EndTime}");
        }
    }
}