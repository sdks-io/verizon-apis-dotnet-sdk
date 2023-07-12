// <copyright file="SecuritySubscriptionRequest.cs" company="APIMatic">
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
    /// SecuritySubscriptionRequest.
    /// </summary>
    public class SecuritySubscriptionRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecuritySubscriptionRequest"/> class.
        /// </summary>
        public SecuritySubscriptionRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecuritySubscriptionRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="skuNumber">skuNumber.</param>
        public SecuritySubscriptionRequest(
            string accountName = null,
            string skuNumber = null)
        {
            this.AccountName = accountName;
            this.SkuNumber = skuNumber;
        }

        /// <summary>
        /// The name of a billing account.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// The Stock Keeping Unit (SKU). Valid skuNumbers for SIM-Secure for IoT are:SIMSec-IoT-Lt”. (Lifetime) Once a license is assigned to a SIM, the SIM-Secure feature is enabled for the life of the SIM.“TS-BUNDLE-KTO-SIMSEC-MRC”. (Bundle) The SIM-Secure Flex license can be assigned to or removed from a SIM at any time. This SKU is bundled with other ThingSpace Services.*“SIMSec-IoT”. (Flex) The SIM-Secure Flex license can be assigned to or removed from a SIM at any time. This SKU is purchased a la carte.
        /// </summary>
        [JsonProperty("skuNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string SkuNumber { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SecuritySubscriptionRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is SecuritySubscriptionRequest other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.SkuNumber == null && other.SkuNumber == null) || (this.SkuNumber?.Equals(other.SkuNumber) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName == string.Empty ? "" : this.AccountName)}");
            toStringOutput.Add($"this.SkuNumber = {(this.SkuNumber == null ? "null" : this.SkuNumber == string.Empty ? "" : this.SkuNumber)}");
        }
    }
}