// <copyright file="AnomalyDetectionRequest.cs" company="APIMatic">
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
    /// AnomalyDetectionRequest.
    /// </summary>
    public class AnomalyDetectionRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnomalyDetectionRequest"/> class.
        /// </summary>
        public AnomalyDetectionRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnomalyDetectionRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="requestType">requestType.</param>
        /// <param name="sensitivityParameter">sensitivityParameter.</param>
        public AnomalyDetectionRequest(
            string accountName = null,
            string requestType = null,
            Models.SensitivityParameters sensitivityParameter = null)
        {
            this.AccountName = accountName;
            this.RequestType = requestType;
            this.SensitivityParameter = sensitivityParameter;
        }

        /// <summary>
        /// The name of a billing account. An account name is usually numeric, and must include any leading zeros.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// The type of request being made. anomaly is the request to activate anomaly detection.
        /// </summary>
        [JsonProperty("requestType", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestType { get; set; }

        /// <summary>
        /// Details for sensitivity parameters.
        /// </summary>
        [JsonProperty("sensitivityParameter", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SensitivityParameters SensitivityParameter { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AnomalyDetectionRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is AnomalyDetectionRequest other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.RequestType == null && other.RequestType == null) || (this.RequestType?.Equals(other.RequestType) == true)) &&
                ((this.SensitivityParameter == null && other.SensitivityParameter == null) || (this.SensitivityParameter?.Equals(other.SensitivityParameter) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.RequestType = {(this.RequestType == null ? "null" : this.RequestType)}");
            toStringOutput.Add($"this.SensitivityParameter = {(this.SensitivityParameter == null ? "null" : this.SensitivityParameter.ToString())}");
        }
    }
}