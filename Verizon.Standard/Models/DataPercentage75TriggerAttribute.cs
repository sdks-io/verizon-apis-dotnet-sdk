// <copyright file="DataPercentage75TriggerAttribute.cs" company="APIMatic">
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
    /// DataPercentage75TriggerAttribute.
    /// </summary>
    public class DataPercentage75TriggerAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataPercentage75TriggerAttribute"/> class.
        /// </summary>
        public DataPercentage75TriggerAttribute()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPercentage75TriggerAttribute"/> class.
        /// </summary>
        /// <param name="key">key.</param>
        /// <param name="mValue">value.</param>
        public DataPercentage75TriggerAttribute(
            string key = null,
            bool? mValue = null)
        {
            this.Key = key;
            this.MValue = mValue;
        }

        /// <summary>
        /// Key data percentage 75.
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// DataPercentage75<br />True - Trigger on Data percentage is over 75% used<br />False - Do not trigger when over 75% used.
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MValue { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DataPercentage75TriggerAttribute : ({string.Join(", ", toStringOutput)})";
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
            return obj is DataPercentage75TriggerAttribute other &&                ((this.Key == null && other.Key == null) || (this.Key?.Equals(other.Key) == true)) &&
                ((this.MValue == null && other.MValue == null) || (this.MValue?.Equals(other.MValue) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Key = {(this.Key == null ? "null" : this.Key == string.Empty ? "" : this.Key)}");
            toStringOutput.Add($"this.MValue = {(this.MValue == null ? "null" : this.MValue.ToString())}");
        }
    }
}