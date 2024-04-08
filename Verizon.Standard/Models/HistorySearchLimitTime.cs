// <copyright file="HistorySearchLimitTime.cs" company="APIMatic">
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
    /// HistorySearchLimitTime.
    /// </summary>
    public class HistorySearchLimitTime
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HistorySearchLimitTime"/> class.
        /// </summary>
        public HistorySearchLimitTime()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HistorySearchLimitTime"/> class.
        /// </summary>
        /// <param name="startOn">startOn.</param>
        /// <param name="duration">duration.</param>
        public HistorySearchLimitTime(
            DateTime? startOn = null,
            Models.NumericalData duration = null)
        {
            this.StartOn = startOn;
            this.Duration = duration;
        }

        /// <summary>
        /// The starting date-time for this request.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("startOn", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StartOn { get; set; }

        /// <summary>
        /// Describes value and unit of time.
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public Models.NumericalData Duration { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"HistorySearchLimitTime : ({string.Join(", ", toStringOutput)})";
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
            return obj is HistorySearchLimitTime other &&                ((this.StartOn == null && other.StartOn == null) || (this.StartOn?.Equals(other.StartOn) == true)) &&
                ((this.Duration == null && other.Duration == null) || (this.Duration?.Equals(other.Duration) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.StartOn = {(this.StartOn == null ? "null" : this.StartOn.ToString())}");
            toStringOutput.Add($"this.Duration = {(this.Duration == null ? "null" : this.Duration.ToString())}");
        }
    }
}