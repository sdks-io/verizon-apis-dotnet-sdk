// <copyright file="AnomalyDetectionSettings.cs" company="APIMatic">
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
    /// AnomalyDetectionSettings.
    /// </summary>
    public class AnomalyDetectionSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnomalyDetectionSettings"/> class.
        /// </summary>
        public AnomalyDetectionSettings()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnomalyDetectionSettings"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="sensitivityParameter">sensitivityParameter.</param>
        /// <param name="status">status.</param>
        public AnomalyDetectionSettings(
            string accountName = null,
            Models.SensitivityParameters sensitivityParameter = null,
            string status = null)
        {
            this.AccountName = accountName;
            this.SensitivityParameter = sensitivityParameter;
            this.Status = status;
        }

        /// <summary>
        /// Indicates if the account name used has anomaly detection.<br />Success - The account has anomaly detection.<br />Failure - The account does not have anomaly detection.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// Details for sensitivity parameters.
        /// </summary>
        [JsonProperty("sensitivityParameter", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SensitivityParameters SensitivityParameter { get; set; }

        /// <summary>
        /// Indicates if anomaly detection is active on the account<br />Active - Anomaly detection is active<br />Disabled- Anomaly detection is not active.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AnomalyDetectionSettings : ({string.Join(", ", toStringOutput)})";
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
            return obj is AnomalyDetectionSettings other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.SensitivityParameter == null && other.SensitivityParameter == null) || (this.SensitivityParameter?.Equals(other.SensitivityParameter) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName == string.Empty ? "" : this.AccountName)}");
            toStringOutput.Add($"this.SensitivityParameter = {(this.SensitivityParameter == null ? "null" : this.SensitivityParameter.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
        }
    }
}