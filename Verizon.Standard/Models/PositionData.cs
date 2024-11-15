// <copyright file="PositionData.cs" company="APIMatic">
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
    /// PositionData.
    /// </summary>
    public class PositionData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PositionData"/> class.
        /// </summary>
        public PositionData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PositionData"/> class.
        /// </summary>
        /// <param name="time">time.</param>
        /// <param name="utcoffset">utcoffset.</param>
        /// <param name="x">x.</param>
        /// <param name="y">y.</param>
        /// <param name="radius">radius.</param>
        /// <param name="qos">qos.</param>
        public PositionData(
            string time = null,
            string utcoffset = null,
            string x = null,
            string y = null,
            string radius = null,
            bool? qos = null)
        {
            this.Time = time;
            this.Utcoffset = utcoffset;
            this.X = x;
            this.Y = y;
            this.Radius = radius;
            this.Qos = qos;
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
        /// X coordinate of location.
        /// </summary>
        [JsonProperty("x", NullValueHandling = NullValueHandling.Ignore)]
        public string X { get; set; }

        /// <summary>
        /// Y coordinate of location.
        /// </summary>
        [JsonProperty("y", NullValueHandling = NullValueHandling.Ignore)]
        public string Y { get; set; }

        /// <summary>
        /// Radius of the location in meters.
        /// </summary>
        [JsonProperty("radius", NullValueHandling = NullValueHandling.Ignore)]
        public string Radius { get; set; }

        /// <summary>
        /// Whether requested accurary is met or not.
        /// </summary>
        [JsonProperty("qos", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Qos { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PositionData : ({string.Join(", ", toStringOutput)})";
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
            return obj is PositionData other &&                ((this.Time == null && other.Time == null) || (this.Time?.Equals(other.Time) == true)) &&
                ((this.Utcoffset == null && other.Utcoffset == null) || (this.Utcoffset?.Equals(other.Utcoffset) == true)) &&
                ((this.X == null && other.X == null) || (this.X?.Equals(other.X) == true)) &&
                ((this.Y == null && other.Y == null) || (this.Y?.Equals(other.Y) == true)) &&
                ((this.Radius == null && other.Radius == null) || (this.Radius?.Equals(other.Radius) == true)) &&
                ((this.Qos == null && other.Qos == null) || (this.Qos?.Equals(other.Qos) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Time = {(this.Time == null ? "null" : this.Time)}");
            toStringOutput.Add($"this.Utcoffset = {(this.Utcoffset == null ? "null" : this.Utcoffset)}");
            toStringOutput.Add($"this.X = {(this.X == null ? "null" : this.X)}");
            toStringOutput.Add($"this.Y = {(this.Y == null ? "null" : this.Y)}");
            toStringOutput.Add($"this.Radius = {(this.Radius == null ? "null" : this.Radius)}");
            toStringOutput.Add($"this.Qos = {(this.Qos == null ? "null" : this.Qos.ToString())}");
        }
    }
}