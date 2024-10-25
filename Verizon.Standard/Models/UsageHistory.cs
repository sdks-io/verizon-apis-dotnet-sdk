// <copyright file="UsageHistory.cs" company="APIMatic">
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
    /// UsageHistory.
    /// </summary>
    public class UsageHistory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsageHistory"/> class.
        /// </summary>
        public UsageHistory()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageHistory"/> class.
        /// </summary>
        /// <param name="bytesUsed">bytesUsed.</param>
        /// <param name="serviceplan">serviceplan.</param>
        /// <param name="smsUsed">smsUsed.</param>
        /// <param name="moSMS">moSMS.</param>
        /// <param name="mtSMS">mtSMS.</param>
        /// <param name="source">source.</param>
        /// <param name="eventDateTime">eventDateTime.</param>
        public UsageHistory(
            int? bytesUsed = null,
            string serviceplan = null,
            int? smsUsed = null,
            int? moSMS = null,
            int? mtSMS = null,
            string source = null,
            DateTime? eventDateTime = null)
        {
            this.BytesUsed = bytesUsed;
            this.Serviceplan = serviceplan;
            this.SmsUsed = smsUsed;
            this.MoSMS = moSMS;
            this.MtSMS = mtSMS;
            this.Source = source;
            this.EventDateTime = eventDateTime;
        }

        /// <summary>
        /// Gets or sets BytesUsed.
        /// </summary>
        [JsonProperty("bytesUsed", NullValueHandling = NullValueHandling.Ignore)]
        public int? BytesUsed { get; set; }

        /// <summary>
        /// Gets or sets Serviceplan.
        /// </summary>
        [JsonProperty("serviceplan", NullValueHandling = NullValueHandling.Ignore)]
        public string Serviceplan { get; set; }

        /// <summary>
        /// Gets or sets SmsUsed.
        /// </summary>
        [JsonProperty("smsUsed", NullValueHandling = NullValueHandling.Ignore)]
        public int? SmsUsed { get; set; }

        /// <summary>
        /// Gets or sets MoSMS.
        /// </summary>
        [JsonProperty("moSMS", NullValueHandling = NullValueHandling.Ignore)]
        public int? MoSMS { get; set; }

        /// <summary>
        /// Gets or sets MtSMS.
        /// </summary>
        [JsonProperty("mtSMS", NullValueHandling = NullValueHandling.Ignore)]
        public int? MtSMS { get; set; }

        /// <summary>
        /// Gets or sets Source.
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets EventDateTime.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("eventDateTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EventDateTime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UsageHistory : ({string.Join(", ", toStringOutput)})";
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
            return obj is UsageHistory other &&                ((this.BytesUsed == null && other.BytesUsed == null) || (this.BytesUsed?.Equals(other.BytesUsed) == true)) &&
                ((this.Serviceplan == null && other.Serviceplan == null) || (this.Serviceplan?.Equals(other.Serviceplan) == true)) &&
                ((this.SmsUsed == null && other.SmsUsed == null) || (this.SmsUsed?.Equals(other.SmsUsed) == true)) &&
                ((this.MoSMS == null && other.MoSMS == null) || (this.MoSMS?.Equals(other.MoSMS) == true)) &&
                ((this.MtSMS == null && other.MtSMS == null) || (this.MtSMS?.Equals(other.MtSMS) == true)) &&
                ((this.Source == null && other.Source == null) || (this.Source?.Equals(other.Source) == true)) &&
                ((this.EventDateTime == null && other.EventDateTime == null) || (this.EventDateTime?.Equals(other.EventDateTime) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BytesUsed = {(this.BytesUsed == null ? "null" : this.BytesUsed.ToString())}");
            toStringOutput.Add($"this.Serviceplan = {(this.Serviceplan == null ? "null" : this.Serviceplan)}");
            toStringOutput.Add($"this.SmsUsed = {(this.SmsUsed == null ? "null" : this.SmsUsed.ToString())}");
            toStringOutput.Add($"this.MoSMS = {(this.MoSMS == null ? "null" : this.MoSMS.ToString())}");
            toStringOutput.Add($"this.MtSMS = {(this.MtSMS == null ? "null" : this.MtSMS.ToString())}");
            toStringOutput.Add($"this.Source = {(this.Source == null ? "null" : this.Source)}");
            toStringOutput.Add($"this.EventDateTime = {(this.EventDateTime == null ? "null" : this.EventDateTime.ToString())}");
        }
    }
}