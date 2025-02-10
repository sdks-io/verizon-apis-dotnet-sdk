// <copyright file="FotaV3Subscription.cs" company="APIMatic">
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
    /// FotaV3Subscription.
    /// </summary>
    public class FotaV3Subscription
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FotaV3Subscription"/> class.
        /// </summary>
        public FotaV3Subscription()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FotaV3Subscription"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="purchaseType">purchaseType.</param>
        /// <param name="licenseCount">licenseCount.</param>
        /// <param name="licenseUsedCount">licenseUsedCount.</param>
        /// <param name="updateTime">updateTime.</param>
        public FotaV3Subscription(
            string accountName = null,
            string purchaseType = null,
            int? licenseCount = null,
            int? licenseUsedCount = null,
            string updateTime = null)
        {
            this.AccountName = accountName;
            this.PurchaseType = purchaseType;
            this.LicenseCount = licenseCount;
            this.LicenseUsedCount = licenseUsedCount;
            this.UpdateTime = updateTime;
        }

        /// <summary>
        /// Account identifier in "##########-#####".
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// Subscription models used by the account.
        /// </summary>
        [JsonProperty("purchaseType", NullValueHandling = NullValueHandling.Ignore)]
        public string PurchaseType { get; set; }

        /// <summary>
        /// Number of monthly licenses in an MRC subscription.
        /// </summary>
        [JsonProperty("licenseCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? LicenseCount { get; set; }

        /// <summary>
        /// Number of licenses currently assigned to devices.
        /// </summary>
        [JsonProperty("licenseUsedCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? LicenseUsedCount { get; set; }

        /// <summary>
        /// The date and time of when the subscription was last updated.
        /// </summary>
        [JsonProperty("updateTime", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"FotaV3Subscription : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is FotaV3Subscription other &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.PurchaseType == null && other.PurchaseType == null ||
                 this.PurchaseType?.Equals(other.PurchaseType) == true) &&
                (this.LicenseCount == null && other.LicenseCount == null ||
                 this.LicenseCount?.Equals(other.LicenseCount) == true) &&
                (this.LicenseUsedCount == null && other.LicenseUsedCount == null ||
                 this.LicenseUsedCount?.Equals(other.LicenseUsedCount) == true) &&
                (this.UpdateTime == null && other.UpdateTime == null ||
                 this.UpdateTime?.Equals(other.UpdateTime) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
            toStringOutput.Add($"PurchaseType = {this.PurchaseType ?? "null"}");
            toStringOutput.Add($"LicenseCount = {(this.LicenseCount == null ? "null" : this.LicenseCount.ToString())}");
            toStringOutput.Add($"LicenseUsedCount = {(this.LicenseUsedCount == null ? "null" : this.LicenseUsedCount.ToString())}");
            toStringOutput.Add($"UpdateTime = {this.UpdateTime ?? "null"}");
        }
    }
}