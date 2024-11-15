// <copyright file="Keyschunk2.cs" company="APIMatic">
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
    /// Keyschunk2.
    /// </summary>
    public class Keyschunk2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Keyschunk2"/> class.
        /// </summary>
        public Keyschunk2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Keyschunk2"/> class.
        /// </summary>
        /// <param name="dataPercentage50">dataPercentage50.</param>
        /// <param name="dataPercentage75">dataPercentage75.</param>
        /// <param name="dataPercentage90">dataPercentage90.</param>
        /// <param name="dataPercentage100">dataPercentage100.</param>
        /// <param name="smsPercentage50">smsPercentage50.</param>
        /// <param name="smsPercentage75">smsPercentage75.</param>
        /// <param name="smsPercentage90">smsPercentage90.</param>
        /// <param name="smsPercentage100">smsPercentage100.</param>
        /// <param name="noOfDaysB4PromoExp">NoOfDaysB4PromoExp.</param>
        public Keyschunk2(
            bool? dataPercentage50 = null,
            bool? dataPercentage75 = null,
            bool? dataPercentage90 = null,
            bool? dataPercentage100 = null,
            bool? smsPercentage50 = null,
            bool? smsPercentage75 = null,
            bool? smsPercentage90 = null,
            bool? smsPercentage100 = null,
            int? noOfDaysB4PromoExp = null)
        {
            this.DataPercentage50 = dataPercentage50;
            this.DataPercentage75 = dataPercentage75;
            this.DataPercentage90 = dataPercentage90;
            this.DataPercentage100 = dataPercentage100;
            this.SmsPercentage50 = smsPercentage50;
            this.SmsPercentage75 = smsPercentage75;
            this.SmsPercentage90 = smsPercentage90;
            this.SmsPercentage100 = smsPercentage100;
            this.NoOfDaysB4PromoExp = noOfDaysB4PromoExp;
        }

        /// <summary>
        /// Gets or sets DataPercentage50.
        /// </summary>
        [JsonProperty("dataPercentage50", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DataPercentage50 { get; set; }

        /// <summary>
        /// Gets or sets DataPercentage75.
        /// </summary>
        [JsonProperty("dataPercentage75", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DataPercentage75 { get; set; }

        /// <summary>
        /// Gets or sets DataPercentage90.
        /// </summary>
        [JsonProperty("dataPercentage90", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DataPercentage90 { get; set; }

        /// <summary>
        /// Gets or sets DataPercentage100.
        /// </summary>
        [JsonProperty("dataPercentage100", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DataPercentage100 { get; set; }

        /// <summary>
        /// Gets or sets SmsPercentage50.
        /// </summary>
        [JsonProperty("smsPercentage50", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SmsPercentage50 { get; set; }

        /// <summary>
        /// Gets or sets SmsPercentage75.
        /// </summary>
        [JsonProperty("smsPercentage75", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SmsPercentage75 { get; set; }

        /// <summary>
        /// Gets or sets SmsPercentage90.
        /// </summary>
        [JsonProperty("smsPercentage90", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SmsPercentage90 { get; set; }

        /// <summary>
        /// Gets or sets SmsPercentage100.
        /// </summary>
        [JsonProperty("smsPercentage100", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SmsPercentage100 { get; set; }

        /// <summary>
        /// Gets or sets NoOfDaysB4PromoExp.
        /// </summary>
        [JsonProperty("NoOfDaysB4PromoExp", NullValueHandling = NullValueHandling.Ignore)]
        public int? NoOfDaysB4PromoExp { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Keyschunk2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Keyschunk2 other &&                ((this.DataPercentage50 == null && other.DataPercentage50 == null) || (this.DataPercentage50?.Equals(other.DataPercentage50) == true)) &&
                ((this.DataPercentage75 == null && other.DataPercentage75 == null) || (this.DataPercentage75?.Equals(other.DataPercentage75) == true)) &&
                ((this.DataPercentage90 == null && other.DataPercentage90 == null) || (this.DataPercentage90?.Equals(other.DataPercentage90) == true)) &&
                ((this.DataPercentage100 == null && other.DataPercentage100 == null) || (this.DataPercentage100?.Equals(other.DataPercentage100) == true)) &&
                ((this.SmsPercentage50 == null && other.SmsPercentage50 == null) || (this.SmsPercentage50?.Equals(other.SmsPercentage50) == true)) &&
                ((this.SmsPercentage75 == null && other.SmsPercentage75 == null) || (this.SmsPercentage75?.Equals(other.SmsPercentage75) == true)) &&
                ((this.SmsPercentage90 == null && other.SmsPercentage90 == null) || (this.SmsPercentage90?.Equals(other.SmsPercentage90) == true)) &&
                ((this.SmsPercentage100 == null && other.SmsPercentage100 == null) || (this.SmsPercentage100?.Equals(other.SmsPercentage100) == true)) &&
                ((this.NoOfDaysB4PromoExp == null && other.NoOfDaysB4PromoExp == null) || (this.NoOfDaysB4PromoExp?.Equals(other.NoOfDaysB4PromoExp) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DataPercentage50 = {(this.DataPercentage50 == null ? "null" : this.DataPercentage50.ToString())}");
            toStringOutput.Add($"this.DataPercentage75 = {(this.DataPercentage75 == null ? "null" : this.DataPercentage75.ToString())}");
            toStringOutput.Add($"this.DataPercentage90 = {(this.DataPercentage90 == null ? "null" : this.DataPercentage90.ToString())}");
            toStringOutput.Add($"this.DataPercentage100 = {(this.DataPercentage100 == null ? "null" : this.DataPercentage100.ToString())}");
            toStringOutput.Add($"this.SmsPercentage50 = {(this.SmsPercentage50 == null ? "null" : this.SmsPercentage50.ToString())}");
            toStringOutput.Add($"this.SmsPercentage75 = {(this.SmsPercentage75 == null ? "null" : this.SmsPercentage75.ToString())}");
            toStringOutput.Add($"this.SmsPercentage90 = {(this.SmsPercentage90 == null ? "null" : this.SmsPercentage90.ToString())}");
            toStringOutput.Add($"this.SmsPercentage100 = {(this.SmsPercentage100 == null ? "null" : this.SmsPercentage100.ToString())}");
            toStringOutput.Add($"this.NoOfDaysB4PromoExp = {(this.NoOfDaysB4PromoExp == null ? "null" : this.NoOfDaysB4PromoExp.ToString())}");
        }
    }
}