// <copyright file="Usage.cs" company="APIMatic">
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
    /// Usage.
    /// </summary>
    public class Usage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Usage"/> class.
        /// </summary>
        public Usage()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Usage"/> class.
        /// </summary>
        /// <param name="bytesUsed">bytesUsed.</param>
        /// <param name="extendedAttributes">extendedAttributes.</param>
        /// <param name="servicePlan">servicePlan.</param>
        /// <param name="smsUsed">smsUsed.</param>
        /// <param name="source">source.</param>
        /// <param name="timestamp">timestamp.</param>
        public Usage(
            long? bytesUsed = null,
            List<Models.CustomFields> extendedAttributes = null,
            string servicePlan = null,
            int? smsUsed = null,
            string source = null,
            string timestamp = null)
        {
            this.BytesUsed = bytesUsed;
            this.ExtendedAttributes = extendedAttributes;
            this.ServicePlan = servicePlan;
            this.SmsUsed = smsUsed;
            this.Source = source;
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// The number of bytes that the device sent or received on the report date.
        /// </summary>
        [JsonProperty("bytesUsed", NullValueHandling = NullValueHandling.Ignore)]
        public long? BytesUsed { get; set; }

        /// <summary>
        /// The number of mobile-originated and mobile-terminated SMS messages on the report date.
        /// </summary>
        [JsonProperty("extendedAttributes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CustomFields> ExtendedAttributes { get; set; }

        /// <summary>
        /// The list of service plans associated with the device/account.
        /// </summary>
        [JsonProperty("servicePlan", NullValueHandling = NullValueHandling.Ignore)]
        public string ServicePlan { get; set; }

        /// <summary>
        /// The number of SMS messages that were sent or received on the report date.
        /// </summary>
        [JsonProperty("smsUsed", NullValueHandling = NullValueHandling.Ignore)]
        public int? SmsUsed { get; set; }

        /// <summary>
        /// The source of the information for the reported usage.
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        /// <summary>
        /// The date of the recorded usage.
        /// </summary>
        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string Timestamp { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Usage : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Usage other &&
                (this.BytesUsed == null && other.BytesUsed == null ||
                 this.BytesUsed?.Equals(other.BytesUsed) == true) &&
                (this.ExtendedAttributes == null && other.ExtendedAttributes == null ||
                 this.ExtendedAttributes?.Equals(other.ExtendedAttributes) == true) &&
                (this.ServicePlan == null && other.ServicePlan == null ||
                 this.ServicePlan?.Equals(other.ServicePlan) == true) &&
                (this.SmsUsed == null && other.SmsUsed == null ||
                 this.SmsUsed?.Equals(other.SmsUsed) == true) &&
                (this.Source == null && other.Source == null ||
                 this.Source?.Equals(other.Source) == true) &&
                (this.Timestamp == null && other.Timestamp == null ||
                 this.Timestamp?.Equals(other.Timestamp) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"BytesUsed = {(this.BytesUsed == null ? "null" : this.BytesUsed.ToString())}");
            toStringOutput.Add($"ExtendedAttributes = {(this.ExtendedAttributes == null ? "null" : $"[{string.Join(", ", this.ExtendedAttributes)} ]")}");
            toStringOutput.Add($"ServicePlan = {this.ServicePlan ?? "null"}");
            toStringOutput.Add($"SmsUsed = {(this.SmsUsed == null ? "null" : this.SmsUsed.ToString())}");
            toStringOutput.Add($"Source = {this.Source ?? "null"}");
            toStringOutput.Add($"Timestamp = {this.Timestamp ?? "null"}");
        }
    }
}