// <copyright file="ResourceBase.cs" company="APIMatic">
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
    /// ResourceBase.
    /// </summary>
    public class ResourceBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceBase"/> class.
        /// </summary>
        public ResourceBase()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceBase"/> class.
        /// </summary>
        /// <param name="unit">unit.</param>
        /// <param name="mValue">value.</param>
        /// <param name="max">max.</param>
        /// <param name="min">min.</param>
        public ResourceBase(
            string unit = null,
            long? mValue = null,
            long? max = null,
            long? min = null)
        {
            this.Unit = unit;
            this.MValue = mValue;
            this.Max = max;
            this.Min = min;
        }

        /// <summary>
        /// Resource unit ex :MB.
        /// </summary>
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }

        /// <summary>
        /// Resource value e.g. 200MB.
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public long? MValue { get; set; }

        /// <summary>
        /// Resource max value e.g. 400MB.
        /// </summary>
        [JsonProperty("max", NullValueHandling = NullValueHandling.Ignore)]
        public long? Max { get; set; }

        /// <summary>
        /// Resource min value e.g. 10MB.
        /// </summary>
        [JsonProperty("min", NullValueHandling = NullValueHandling.Ignore)]
        public long? Min { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ResourceBase : ({string.Join(", ", toStringOutput)})";
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
            return obj is ResourceBase other &&                ((this.Unit == null && other.Unit == null) || (this.Unit?.Equals(other.Unit) == true)) &&
                ((this.MValue == null && other.MValue == null) || (this.MValue?.Equals(other.MValue) == true)) &&
                ((this.Max == null && other.Max == null) || (this.Max?.Equals(other.Max) == true)) &&
                ((this.Min == null && other.Min == null) || (this.Min?.Equals(other.Min) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Unit = {(this.Unit == null ? "null" : this.Unit == string.Empty ? "" : this.Unit)}");
            toStringOutput.Add($"this.MValue = {(this.MValue == null ? "null" : this.MValue.ToString())}");
            toStringOutput.Add($"this.Max = {(this.Max == null ? "null" : this.Max.ToString())}");
            toStringOutput.Add($"this.Min = {(this.Min == null ? "null" : this.Min.ToString())}");
        }
    }
}