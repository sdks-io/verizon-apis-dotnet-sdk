// <copyright file="AccountConsentUpdate.cs" company="APIMatic">
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
    /// AccountConsentUpdate.
    /// </summary>
    public class AccountConsentUpdate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountConsentUpdate"/> class.
        /// </summary>
        public AccountConsentUpdate()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountConsentUpdate"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="allDeviceConsent">allDeviceConsent.</param>
        public AccountConsentUpdate(
            string accountName = null,
            int? allDeviceConsent = null)
        {
            this.AccountName = accountName;
            this.AllDeviceConsent = allDeviceConsent;
        }

        /// <summary>
        /// The numeric name of the account, including leading zeros.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// The consent setting to use for all the devices in the account.
        /// </summary>
        [JsonProperty("allDeviceConsent", NullValueHandling = NullValueHandling.Ignore)]
        public int? AllDeviceConsent { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"AccountConsentUpdate : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AccountConsentUpdate other &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.AllDeviceConsent == null && other.AllDeviceConsent == null ||
                 this.AllDeviceConsent?.Equals(other.AllDeviceConsent) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
            toStringOutput.Add($"AllDeviceConsent = {(this.AllDeviceConsent == null ? "null" : this.AllDeviceConsent.ToString())}");
        }
    }
}