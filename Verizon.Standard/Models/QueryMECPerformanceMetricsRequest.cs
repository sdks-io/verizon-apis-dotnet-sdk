// <copyright file="QueryMECPerformanceMetricsRequest.cs" company="APIMatic">
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
    /// QueryMECPerformanceMetricsRequest.
    /// </summary>
    public class QueryMECPerformanceMetricsRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryMECPerformanceMetricsRequest"/> class.
        /// </summary>
        public QueryMECPerformanceMetricsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryMECPerformanceMetricsRequest"/> class.
        /// </summary>
        /// <param name="iMEI">IMEI.</param>
        /// <param name="mSISDN">MSISDN.</param>
        public QueryMECPerformanceMetricsRequest(
            string iMEI,
            string mSISDN)
        {
            this.IMEI = iMEI;
            this.MSISDN = mSISDN;
        }

        /// <summary>
        /// The 15-digit International Mobile Equipment Identifier.
        /// </summary>
        [JsonProperty("IMEI")]
        public string IMEI { get; set; }

        /// <summary>
        /// The 12-digit Mobile Station International Subscriber Directory Number.
        /// </summary>
        [JsonProperty("MSISDN")]
        public string MSISDN { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"QueryMECPerformanceMetricsRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is QueryMECPerformanceMetricsRequest other &&                ((this.IMEI == null && other.IMEI == null) || (this.IMEI?.Equals(other.IMEI) == true)) &&
                ((this.MSISDN == null && other.MSISDN == null) || (this.MSISDN?.Equals(other.MSISDN) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.IMEI = {(this.IMEI == null ? "null" : this.IMEI)}");
            toStringOutput.Add($"this.MSISDN = {(this.MSISDN == null ? "null" : this.MSISDN)}");
        }
    }
}