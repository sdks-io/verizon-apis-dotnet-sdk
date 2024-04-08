// <copyright file="GetMECPerformanceConsentResponse.cs" company="APIMatic">
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
    /// GetMECPerformanceConsentResponse.
    /// </summary>
    public class GetMECPerformanceConsentResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetMECPerformanceConsentResponse"/> class.
        /// </summary>
        public GetMECPerformanceConsentResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMECPerformanceConsentResponse"/> class.
        /// </summary>
        /// <param name="consent">consent.</param>
        public GetMECPerformanceConsentResponse(
            string consent = null)
        {
            this.Consent = consent;
        }

        /// <summary>
        /// MEC Performance Consent Response.
        /// </summary>
        [JsonProperty("consent", NullValueHandling = NullValueHandling.Ignore)]
        public string Consent { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetMECPerformanceConsentResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is GetMECPerformanceConsentResponse other &&                ((this.Consent == null && other.Consent == null) || (this.Consent?.Equals(other.Consent) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Consent = {(this.Consent == null ? "null" : this.Consent)}");
        }
    }
}