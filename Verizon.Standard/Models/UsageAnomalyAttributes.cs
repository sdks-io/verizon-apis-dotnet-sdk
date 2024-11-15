// <copyright file="UsageAnomalyAttributes.cs" company="APIMatic">
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
    /// UsageAnomalyAttributes.
    /// </summary>
    public class UsageAnomalyAttributes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsageAnomalyAttributes"/> class.
        /// </summary>
        public UsageAnomalyAttributes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageAnomalyAttributes"/> class.
        /// </summary>
        /// <param name="accountNames">accountNames.</param>
        /// <param name="deviceGroup">deviceGroup.</param>
        /// <param name="includeAbnormal">includeAbnormal.</param>
        /// <param name="includeVeryAbnormal">includeVeryAbnormal.</param>
        /// <param name="includeUnderExpectedUsage">includeUnderExpectedUsage.</param>
        /// <param name="includeOverExpectedUsage">includeOverExpectedUsage.</param>
        public UsageAnomalyAttributes(
            string accountNames = null,
            string deviceGroup = null,
            bool? includeAbnormal = null,
            bool? includeVeryAbnormal = null,
            bool? includeUnderExpectedUsage = null,
            bool? includeOverExpectedUsage = null)
        {
            this.AccountNames = accountNames;
            this.DeviceGroup = deviceGroup;
            this.IncludeAbnormal = includeAbnormal;
            this.IncludeVeryAbnormal = includeVeryAbnormal;
            this.IncludeUnderExpectedUsage = includeUnderExpectedUsage;
            this.IncludeOverExpectedUsage = includeOverExpectedUsage;
        }

        /// <summary>
        /// The Verizon billing account associated with the anomaly triggers for this trigger to be active for devices in those accounts. An account name is usually numeric, and must include any leading zeros.
        /// </summary>
        [JsonProperty("accountNames", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountNames { get; set; }

        /// <summary>
        /// The names of device groups associated with the anomaly triggers for this trigger to be active for devices in those groups.
        /// </summary>
        [JsonProperty("deviceGroup", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceGroup { get; set; }

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

            return $"UsageAnomalyAttributes : ({string.Join(", ", toStringOutput)})";
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
            return obj is UsageAnomalyAttributes other &&                ((this.AccountNames == null && other.AccountNames == null) || (this.AccountNames?.Equals(other.AccountNames) == true)) &&
                ((this.DeviceGroup == null && other.DeviceGroup == null) || (this.DeviceGroup?.Equals(other.DeviceGroup) == true)) &&
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
            toStringOutput.Add($"this.AccountNames = {(this.AccountNames == null ? "null" : this.AccountNames)}");
            toStringOutput.Add($"this.DeviceGroup = {(this.DeviceGroup == null ? "null" : this.DeviceGroup)}");
            toStringOutput.Add($"this.IncludeAbnormal = {(this.IncludeAbnormal == null ? "null" : this.IncludeAbnormal.ToString())}");
            toStringOutput.Add($"this.IncludeVeryAbnormal = {(this.IncludeVeryAbnormal == null ? "null" : this.IncludeVeryAbnormal.ToString())}");
            toStringOutput.Add($"this.IncludeUnderExpectedUsage = {(this.IncludeUnderExpectedUsage == null ? "null" : this.IncludeUnderExpectedUsage.ToString())}");
            toStringOutput.Add($"this.IncludeOverExpectedUsage = {(this.IncludeOverExpectedUsage == null ? "null" : this.IncludeOverExpectedUsage.ToString())}");
        }
    }
}