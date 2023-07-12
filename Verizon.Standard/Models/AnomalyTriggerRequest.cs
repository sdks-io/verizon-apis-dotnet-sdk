// <copyright file="AnomalyTriggerRequest.cs" company="APIMatic">
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
    /// AnomalyTriggerRequest.
    /// </summary>
    public class AnomalyTriggerRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnomalyTriggerRequest"/> class.
        /// </summary>
        public AnomalyTriggerRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnomalyTriggerRequest"/> class.
        /// </summary>
        /// <param name="accountNames">accountNames.</param>
        /// <param name="includeAbnormal">includeAbnormal.</param>
        /// <param name="includeVeryAbnormal">includeVeryAbnormal.</param>
        /// <param name="includeUnderExpectedUsage">includeUnderExpectedUsage.</param>
        /// <param name="includeOverExpectedUsage">includeOverExpectedUsage.</param>
        public AnomalyTriggerRequest(
            string accountNames = null,
            bool? includeAbnormal = null,
            bool? includeVeryAbnormal = null,
            bool? includeUnderExpectedUsage = null,
            bool? includeOverExpectedUsage = null)
        {
            this.AccountNames = accountNames;
            this.IncludeAbnormal = includeAbnormal;
            this.IncludeVeryAbnormal = includeVeryAbnormal;
            this.IncludeUnderExpectedUsage = includeUnderExpectedUsage;
            this.IncludeOverExpectedUsage = includeOverExpectedUsage;
        }

        /// <summary>
        /// The Verizon billing accounts associated with the anomaly triggers for this trigger to be active for devices in those accounts. An account name is usually numeric, and must include any leading zeros.
        /// </summary>
        [JsonProperty("accountNames", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountNames { get; set; }

        /// <summary>
        /// Whether or not to include anomalies classified as 'abnormal'.<br />true<br />false<br />Classification is set as part of ThingSpace Intelligence anomaly detection settings.
        /// </summary>
        [JsonProperty("includeAbnormal", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeAbnormal { get; set; }

        /// <summary>
        /// Whether or not to include anomalies classified as 'very abnormal'.<br />true<br />false<br />Classification is set as part of ThingSpace Intelligence anomaly detection settings.
        /// </summary>
        [JsonProperty("includeVeryAbnormal", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeVeryAbnormal { get; set; }

        /// <summary>
        /// Whether or not to include anomalies that are directionally under the expected usage.<br />true<br />false.
        /// </summary>
        [JsonProperty("includeUnderExpectedUsage", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeUnderExpectedUsage { get; set; }

        /// <summary>
        /// Whether or not to include anomalies that are directionally over the expected usage. <br />true<br />false.
        /// </summary>
        [JsonProperty("includeOverExpectedUsage", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeOverExpectedUsage { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AnomalyTriggerRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is AnomalyTriggerRequest other &&                ((this.AccountNames == null && other.AccountNames == null) || (this.AccountNames?.Equals(other.AccountNames) == true)) &&
                ((this.IncludeAbnormal == null && other.IncludeAbnormal == null) || (this.IncludeAbnormal?.Equals(other.IncludeAbnormal) == true)) &&
                ((this.IncludeVeryAbnormal == null && other.IncludeVeryAbnormal == null) || (this.IncludeVeryAbnormal?.Equals(other.IncludeVeryAbnormal) == true)) &&
                ((this.IncludeUnderExpectedUsage == null && other.IncludeUnderExpectedUsage == null) || (this.IncludeUnderExpectedUsage?.Equals(other.IncludeUnderExpectedUsage) == true)) &&
                ((this.IncludeOverExpectedUsage == null && other.IncludeOverExpectedUsage == null) || (this.IncludeOverExpectedUsage?.Equals(other.IncludeOverExpectedUsage) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountNames = {(this.AccountNames == null ? "null" : this.AccountNames == string.Empty ? "" : this.AccountNames)}");
            toStringOutput.Add($"this.IncludeAbnormal = {(this.IncludeAbnormal == null ? "null" : this.IncludeAbnormal.ToString())}");
            toStringOutput.Add($"this.IncludeVeryAbnormal = {(this.IncludeVeryAbnormal == null ? "null" : this.IncludeVeryAbnormal.ToString())}");
            toStringOutput.Add($"this.IncludeUnderExpectedUsage = {(this.IncludeUnderExpectedUsage == null ? "null" : this.IncludeUnderExpectedUsage.ToString())}");
            toStringOutput.Add($"this.IncludeOverExpectedUsage = {(this.IncludeOverExpectedUsage == null ? "null" : this.IncludeOverExpectedUsage.ToString())}");
        }
    }
}