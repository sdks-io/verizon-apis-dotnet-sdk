// <copyright file="DiagnosticsSubscription.cs" company="APIMatic">
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
    /// DiagnosticsSubscription.
    /// </summary>
    public class DiagnosticsSubscription
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticsSubscription"/> class.
        /// </summary>
        public DiagnosticsSubscription()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticsSubscription"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="createdOn">createdOn.</param>
        /// <param name="lastUpdated">lastUpdated.</param>
        /// <param name="totalAllowed">totalAllowed.</param>
        /// <param name="totalUsed">totalUsed.</param>
        /// <param name="skuName">skuName.</param>
        public DiagnosticsSubscription(
            string accountName,
            DateTime createdOn,
            DateTime lastUpdated,
            int totalAllowed,
            int totalUsed,
            string skuName)
        {
            this.AccountName = accountName;
            this.CreatedOn = createdOn;
            this.LastUpdated = lastUpdated;
            this.TotalAllowed = totalAllowed;
            this.TotalUsed = totalUsed;
            this.SkuName = skuName;
        }

        /// <summary>
        /// Account identifier in "##########-#####". An account name is usually numeric, and must include any leading zeros.
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// The date and time of when the subscription was created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdOn")]
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// The date and time of when the subscription was last updated.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("lastUpdated")]
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// Number of licenses currently assigned to devices.
        /// </summary>
        [JsonProperty("totalAllowed")]
        public int TotalAllowed { get; set; }

        /// <summary>
        /// Number of licenses currently used by the devices.
        /// </summary>
        [JsonProperty("totalUsed")]
        public int TotalUsed { get; set; }

        /// <summary>
        /// Name of the SKU for the account.
        /// </summary>
        [JsonProperty("skuName")]
        public string SkuName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DiagnosticsSubscription : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DiagnosticsSubscription other &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.CreatedOn.Equals(other.CreatedOn)) &&
                (this.LastUpdated.Equals(other.LastUpdated)) &&
                (this.TotalAllowed.Equals(other.TotalAllowed)) &&
                (this.TotalUsed.Equals(other.TotalUsed)) &&
                (this.SkuName == null && other.SkuName == null ||
                 this.SkuName?.Equals(other.SkuName) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
            toStringOutput.Add($"CreatedOn = {this.CreatedOn}");
            toStringOutput.Add($"LastUpdated = {this.LastUpdated}");
            toStringOutput.Add($"TotalAllowed = {this.TotalAllowed}");
            toStringOutput.Add($"TotalUsed = {this.TotalUsed}");
            toStringOutput.Add($"SkuName = {this.SkuName ?? "null"}");
        }
    }
}