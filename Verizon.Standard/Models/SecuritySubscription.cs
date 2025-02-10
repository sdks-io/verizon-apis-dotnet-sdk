// <copyright file="SecuritySubscription.cs" company="APIMatic">
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
    /// SecuritySubscription.
    /// </summary>
    public class SecuritySubscription
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecuritySubscription"/> class.
        /// </summary>
        public SecuritySubscription()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecuritySubscription"/> class.
        /// </summary>
        /// <param name="extendedAttributes">extendedAttributes.</param>
        /// <param name="licenseAssigned">licenseAssigned.</param>
        /// <param name="licenseAvailable">licenseAvailable.</param>
        /// <param name="licensePurchased">licensePurchased.</param>
        /// <param name="licenseType">licenseType.</param>
        /// <param name="skuNumber">skuNumber.</param>
        public SecuritySubscription(
            List<Models.ExtendedAttributes> extendedAttributes = null,
            int? licenseAssigned = null,
            int? licenseAvailable = null,
            int? licensePurchased = null,
            string licenseType = null,
            string skuNumber = null)
        {
            this.ExtendedAttributes = extendedAttributes;
            this.LicenseAssigned = licenseAssigned;
            this.LicenseAvailable = licenseAvailable;
            this.LicensePurchased = licensePurchased;
            this.LicenseType = licenseType;
            this.SkuNumber = skuNumber;
        }

        /// <summary>
        /// Attributes of the subscription.
        /// </summary>
        [JsonProperty("extendedAttributes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ExtendedAttributes> ExtendedAttributes { get; set; }

        /// <summary>
        /// The total number of licenses for this license type that are assigned to device SIMs.
        /// </summary>
        [JsonProperty("licenseAssigned", NullValueHandling = NullValueHandling.Ignore)]
        public int? LicenseAssigned { get; set; }

        /// <summary>
        /// The total number of licenses for this license type that are available to assign to device SIMs.
        /// </summary>
        [JsonProperty("licenseAvailable", NullValueHandling = NullValueHandling.Ignore)]
        public int? LicenseAvailable { get; set; }

        /// <summary>
        /// The total number of licenses purchased for the license type.
        /// </summary>
        [JsonProperty("licensePurchased", NullValueHandling = NullValueHandling.Ignore)]
        public int? LicensePurchased { get; set; }

        /// <summary>
        /// The license type associated with the skuNumber.
        /// </summary>
        [JsonProperty("licenseType", NullValueHandling = NullValueHandling.Ignore)]
        public string LicenseType { get; set; }

        /// <summary>
        /// The skuNumber that identifies the license type.
        /// </summary>
        [JsonProperty("skuNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string SkuNumber { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SecuritySubscription : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SecuritySubscription other &&
                (this.ExtendedAttributes == null && other.ExtendedAttributes == null ||
                 this.ExtendedAttributes?.Equals(other.ExtendedAttributes) == true) &&
                (this.LicenseAssigned == null && other.LicenseAssigned == null ||
                 this.LicenseAssigned?.Equals(other.LicenseAssigned) == true) &&
                (this.LicenseAvailable == null && other.LicenseAvailable == null ||
                 this.LicenseAvailable?.Equals(other.LicenseAvailable) == true) &&
                (this.LicensePurchased == null && other.LicensePurchased == null ||
                 this.LicensePurchased?.Equals(other.LicensePurchased) == true) &&
                (this.LicenseType == null && other.LicenseType == null ||
                 this.LicenseType?.Equals(other.LicenseType) == true) &&
                (this.SkuNumber == null && other.SkuNumber == null ||
                 this.SkuNumber?.Equals(other.SkuNumber) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ExtendedAttributes = {(this.ExtendedAttributes == null ? "null" : $"[{string.Join(", ", this.ExtendedAttributes)} ]")}");
            toStringOutput.Add($"LicenseAssigned = {(this.LicenseAssigned == null ? "null" : this.LicenseAssigned.ToString())}");
            toStringOutput.Add($"LicenseAvailable = {(this.LicenseAvailable == null ? "null" : this.LicenseAvailable.ToString())}");
            toStringOutput.Add($"LicensePurchased = {(this.LicensePurchased == null ? "null" : this.LicensePurchased.ToString())}");
            toStringOutput.Add($"LicenseType = {this.LicenseType ?? "null"}");
            toStringOutput.Add($"SkuNumber = {this.SkuNumber ?? "null"}");
        }
    }
}