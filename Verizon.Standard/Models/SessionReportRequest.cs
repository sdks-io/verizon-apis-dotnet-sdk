// <copyright file="SessionReportRequest.cs" company="APIMatic">
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
    /// SessionReportRequest.
    /// </summary>
    public class SessionReportRequest
    {
        private int? durationLow;
        private int? durationHigh;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "durationLow", false },
            { "durationHigh", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionReportRequest"/> class.
        /// </summary>
        public SessionReportRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionReportRequest"/> class.
        /// </summary>
        /// <param name="accountNumber">accountNumber.</param>
        /// <param name="imei">imei.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="durationLow">durationLow.</param>
        /// <param name="durationHigh">durationHigh.</param>
        public SessionReportRequest(
            string accountNumber,
            string imei,
            string startDate = null,
            string endDate = null,
            int? durationLow = null,
            int? durationHigh = null)
        {
            this.AccountNumber = accountNumber;
            this.Imei = imei;
            this.StartDate = startDate;
            this.EndDate = endDate;
            if (durationLow != null)
            {
                this.DurationLow = durationLow;
            }

            if (durationHigh != null)
            {
                this.DurationHigh = durationHigh;
            }

        }

        /// <summary>
        /// Account Number.
        /// </summary>
        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Device ids.
        /// </summary>
        [JsonProperty("imei")]
        public string Imei { get; set; }

        /// <summary>
        /// Start date of session to include. If not specified  information will be shown from the earliest available (180 days). Can be either date in ISO 8601 format or predefined constants.
        /// </summary>
        [JsonProperty("startDate", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDate { get; set; }

        /// <summary>
        /// End date of session to include. If not specified  information will be shown to the latest available. Can be either date in ISO 8601 format or predefined constants.
        /// </summary>
        [JsonProperty("endDate", NullValueHandling = NullValueHandling.Ignore)]
        public string EndDate { get; set; }

        /// <summary>
        /// The Low value of session duration.
        /// </summary>
        [JsonProperty("durationLow")]
        public int? DurationLow
        {
            get
            {
                return this.durationLow;
            }

            set
            {
                this.shouldSerialize["durationLow"] = true;
                this.durationLow = value;
            }
        }

        /// <summary>
        /// The High value of session duration.
        /// </summary>
        [JsonProperty("durationHigh")]
        public int? DurationHigh
        {
            get
            {
                return this.durationHigh;
            }

            set
            {
                this.shouldSerialize["durationHigh"] = true;
                this.durationHigh = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SessionReportRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDurationLow()
        {
            this.shouldSerialize["durationLow"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDurationHigh()
        {
            this.shouldSerialize["durationHigh"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDurationLow()
        {
            return this.shouldSerialize["durationLow"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDurationHigh()
        {
            return this.shouldSerialize["durationHigh"];
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
            return obj is SessionReportRequest other &&                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.Imei == null && other.Imei == null) || (this.Imei?.Equals(other.Imei) == true)) &&
                ((this.StartDate == null && other.StartDate == null) || (this.StartDate?.Equals(other.StartDate) == true)) &&
                ((this.EndDate == null && other.EndDate == null) || (this.EndDate?.Equals(other.EndDate) == true)) &&
                ((this.DurationLow == null && other.DurationLow == null) || (this.DurationLow?.Equals(other.DurationLow) == true)) &&
                ((this.DurationHigh == null && other.DurationHigh == null) || (this.DurationHigh?.Equals(other.DurationHigh) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber == string.Empty ? "" : this.AccountNumber)}");
            toStringOutput.Add($"this.Imei = {(this.Imei == null ? "null" : this.Imei == string.Empty ? "" : this.Imei)}");
            toStringOutput.Add($"this.StartDate = {(this.StartDate == null ? "null" : this.StartDate == string.Empty ? "" : this.StartDate)}");
            toStringOutput.Add($"this.EndDate = {(this.EndDate == null ? "null" : this.EndDate == string.Empty ? "" : this.EndDate)}");
            toStringOutput.Add($"this.DurationLow = {(this.DurationLow == null ? "null" : this.DurationLow.ToString())}");
            toStringOutput.Add($"this.DurationHigh = {(this.DurationHigh == null ? "null" : this.DurationHigh.ToString())}");
        }
    }
}