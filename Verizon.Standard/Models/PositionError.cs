// <copyright file="PositionError.cs" company="APIMatic">
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
    /// PositionError.
    /// </summary>
    public class PositionError
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PositionError"/> class.
        /// </summary>
        public PositionError()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PositionError"/> class.
        /// </summary>
        /// <param name="time">time.</param>
        /// <param name="utcoffset">utcoffset.</param>
        /// <param name="type">type.</param>
        /// <param name="info">info.</param>
        public PositionError(
            string time = null,
            string utcoffset = null,
            string type = null,
            string info = null)
        {
            this.Time = time;
            this.Utcoffset = utcoffset;
            this.Type = type;
            this.Info = info;
        }

        /// <summary>
        /// Time location obtained.
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time { get; set; }

        /// <summary>
        /// UTC offset of time.
        /// </summary>
        [JsonProperty("utcoffset", NullValueHandling = NullValueHandling.Ignore)]
        public string Utcoffset { get; set; }

        /// <summary>
        /// Error type returned from location server.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// Additional information about the error.
        /// </summary>
        [JsonProperty("info", NullValueHandling = NullValueHandling.Ignore)]
        public string Info { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PositionError : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PositionError other &&
                (this.Time == null && other.Time == null ||
                 this.Time?.Equals(other.Time) == true) &&
                (this.Utcoffset == null && other.Utcoffset == null ||
                 this.Utcoffset?.Equals(other.Utcoffset) == true) &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true) &&
                (this.Info == null && other.Info == null ||
                 this.Info?.Equals(other.Info) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Time = {this.Time ?? "null"}");
            toStringOutput.Add($"Utcoffset = {this.Utcoffset ?? "null"}");
            toStringOutput.Add($"Type = {this.Type ?? "null"}");
            toStringOutput.Add($"Info = {this.Info ?? "null"}");
        }
    }
}