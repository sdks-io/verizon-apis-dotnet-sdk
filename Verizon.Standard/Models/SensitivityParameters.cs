// <copyright file="SensitivityParameters.cs" company="APIMatic">
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
    /// SensitivityParameters.
    /// </summary>
    public class SensitivityParameters
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SensitivityParameters"/> class.
        /// </summary>
        public SensitivityParameters()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SensitivityParameters"/> class.
        /// </summary>
        /// <param name="abnormalMaxValue">abnormalMaxValue.</param>
        /// <param name="enableAbnormal">enableAbnormal.</param>
        /// <param name="enableVeryAbnormal">enableVeryAbnormal.</param>
        /// <param name="veryAbnormalMaxValue">veryAbnormalMaxValue.</param>
        public SensitivityParameters(
            double? abnormalMaxValue = null,
            bool? enableAbnormal = null,
            bool? enableVeryAbnormal = null,
            double? veryAbnormalMaxValue = null)
        {
            this.AbnormalMaxValue = abnormalMaxValue;
            this.EnableAbnormal = enableAbnormal;
            this.EnableVeryAbnormal = enableVeryAbnormal;
            this.VeryAbnormalMaxValue = veryAbnormalMaxValue;
        }

        /// <summary>
        /// The maximum value of the threshold in the units being measured.
        /// </summary>
        [JsonProperty("abnormalMaxValue", NullValueHandling = NullValueHandling.Ignore)]
        public double? AbnormalMaxValue { get; set; }

        /// <summary>
        /// If abnormal values are being monitored.<br />true - Monitor for abnormal values<br />false - Do not monitor for abnormal values.
        /// </summary>
        [JsonProperty("enableAbnormal", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAbnormal { get; set; }

        /// <summary>
        /// If very abnormal values are being monitored.<br />true - Monitor for very abnormal values<br />false - Do not monitor for very abnormal values.
        /// </summary>
        [JsonProperty("enableVeryAbnormal", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableVeryAbnormal { get; set; }

        /// <summary>
        /// The maximum value of the threshold in the units being measured.
        /// </summary>
        [JsonProperty("veryAbnormalMaxValue", NullValueHandling = NullValueHandling.Ignore)]
        public double? VeryAbnormalMaxValue { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SensitivityParameters : ({string.Join(", ", toStringOutput)})";
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
            return obj is SensitivityParameters other &&                ((this.AbnormalMaxValue == null && other.AbnormalMaxValue == null) || (this.AbnormalMaxValue?.Equals(other.AbnormalMaxValue) == true)) &&
                ((this.EnableAbnormal == null && other.EnableAbnormal == null) || (this.EnableAbnormal?.Equals(other.EnableAbnormal) == true)) &&
                ((this.EnableVeryAbnormal == null && other.EnableVeryAbnormal == null) || (this.EnableVeryAbnormal?.Equals(other.EnableVeryAbnormal) == true)) &&
                ((this.VeryAbnormalMaxValue == null && other.VeryAbnormalMaxValue == null) || (this.VeryAbnormalMaxValue?.Equals(other.VeryAbnormalMaxValue) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AbnormalMaxValue = {(this.AbnormalMaxValue == null ? "null" : this.AbnormalMaxValue.ToString())}");
            toStringOutput.Add($"this.EnableAbnormal = {(this.EnableAbnormal == null ? "null" : this.EnableAbnormal.ToString())}");
            toStringOutput.Add($"this.EnableVeryAbnormal = {(this.EnableVeryAbnormal == null ? "null" : this.EnableVeryAbnormal.ToString())}");
            toStringOutput.Add($"this.VeryAbnormalMaxValue = {(this.VeryAbnormalMaxValue == null ? "null" : this.VeryAbnormalMaxValue.ToString())}");
        }
    }
}