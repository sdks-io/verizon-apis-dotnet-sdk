// <copyright file="DeviceLocationSubscription.cs" company="APIMatic">
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
    /// DeviceLocationSubscription.
    /// </summary>
    public class DeviceLocationSubscription
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceLocationSubscription"/> class.
        /// </summary>
        public DeviceLocationSubscription()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceLocationSubscription"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="locType">locType.</param>
        /// <param name="maxAllowance">maxAllowance.</param>
        /// <param name="purchaseTime">purchaseTime.</param>
        public DeviceLocationSubscription(
            string accountName = null,
            string locType = null,
            string maxAllowance = null,
            string purchaseTime = null)
        {
            this.AccountName = accountName;
            this.LocType = locType;
            this.MaxAllowance = maxAllowance;
            this.PurchaseTime = purchaseTime;
        }

        /// <summary>
        /// Account identifier in "##########-#####".
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// Location service license type.
        /// </summary>
        [JsonProperty("locType", NullValueHandling = NullValueHandling.Ignore)]
        public string LocType { get; set; }

        /// <summary>
        /// The number of billable location requests allowed per billing cycle.
        /// </summary>
        [JsonProperty("maxAllowance", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxAllowance { get; set; }

        /// <summary>
        /// Location service purchase time.
        /// </summary>
        [JsonProperty("purchaseTime", NullValueHandling = NullValueHandling.Ignore)]
        public string PurchaseTime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DeviceLocationSubscription : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DeviceLocationSubscription other &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.LocType == null && other.LocType == null ||
                 this.LocType?.Equals(other.LocType) == true) &&
                (this.MaxAllowance == null && other.MaxAllowance == null ||
                 this.MaxAllowance?.Equals(other.MaxAllowance) == true) &&
                (this.PurchaseTime == null && other.PurchaseTime == null ||
                 this.PurchaseTime?.Equals(other.PurchaseTime) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
            toStringOutput.Add($"LocType = {this.LocType ?? "null"}");
            toStringOutput.Add($"MaxAllowance = {this.MaxAllowance ?? "null"}");
            toStringOutput.Add($"PurchaseTime = {this.PurchaseTime ?? "null"}");
        }
    }
}