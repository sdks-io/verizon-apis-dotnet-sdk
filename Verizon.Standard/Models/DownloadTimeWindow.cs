// <copyright file="DownloadTimeWindow.cs" company="APIMatic">
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
    /// DownloadTimeWindow.
    /// </summary>
    public class DownloadTimeWindow
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadTimeWindow"/> class.
        /// </summary>
        public DownloadTimeWindow()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadTimeWindow"/> class.
        /// </summary>
        /// <param name="startTime">startTime.</param>
        /// <param name="endTime">endTime.</param>
        public DownloadTimeWindow(
            string startTime = null,
            string endTime = null)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        /// <summary>
        /// Device IMEI list.
        /// </summary>
        [JsonProperty("startTime", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// Device IMEI list.
        /// </summary>
        [JsonProperty("endTime", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DownloadTimeWindow : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DownloadTimeWindow other &&
                (this.StartTime == null && other.StartTime == null ||
                 this.StartTime?.Equals(other.StartTime) == true) &&
                (this.EndTime == null && other.EndTime == null ||
                 this.EndTime?.Equals(other.EndTime) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"StartTime = {this.StartTime ?? "null"}");
            toStringOutput.Add($"EndTime = {this.EndTime ?? "null"}");
        }
    }
}