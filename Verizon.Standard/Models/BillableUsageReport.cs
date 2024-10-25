// <copyright file="BillableUsageReport.cs" company="APIMatic">
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
    /// BillableUsageReport.
    /// </summary>
    public class BillableUsageReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillableUsageReport"/> class.
        /// </summary>
        public BillableUsageReport()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillableUsageReport"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="usageForAllAccounts">usageForAllAccounts.</param>
        /// <param name="skuName">skuName.</param>
        /// <param name="transactionsAllowed">transactionsAllowed.</param>
        /// <param name="totalTransactionCount">totalTransactionCount.</param>
        /// <param name="primaryAccount">PrimaryAccount.</param>
        /// <param name="managedAccounts">ManagedAccounts.</param>
        public BillableUsageReport(
            string accountName = null,
            bool? usageForAllAccounts = null,
            string skuName = null,
            string transactionsAllowed = null,
            string totalTransactionCount = null,
            Models.ServiceUsage primaryAccount = null,
            List<Models.ServiceUsage> managedAccounts = null)
        {
            this.AccountName = accountName;
            this.UsageForAllAccounts = usageForAllAccounts;
            this.SkuName = skuName;
            this.TransactionsAllowed = transactionsAllowed;
            this.TotalTransactionCount = totalTransactionCount;
            this.PrimaryAccount = primaryAccount;
            this.ManagedAccounts = managedAccounts;
        }

        /// <summary>
        /// Account identifier.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// The usage is for a single or multiple accounts.
        /// </summary>
        [JsonProperty("usageForAllAccounts", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UsageForAllAccounts { get; set; }

        /// <summary>
        /// SKU Name of the service subscription.
        /// </summary>
        [JsonProperty("skuName", NullValueHandling = NullValueHandling.Ignore)]
        public string SkuName { get; set; }

        /// <summary>
        /// The number of location requests included with the subscription type.
        /// </summary>
        [JsonProperty("transactionsAllowed", NullValueHandling = NullValueHandling.Ignore)]
        public string TransactionsAllowed { get; set; }

        /// <summary>
        /// The total number of billable device location requests during the reporting period from all included accounts.
        /// </summary>
        [JsonProperty("totalTransactionCount", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalTransactionCount { get; set; }

        /// <summary>
        /// Gets or sets PrimaryAccount.
        /// </summary>
        [JsonProperty("PrimaryAccount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ServiceUsage PrimaryAccount { get; set; }

        /// <summary>
        /// Zero or more managed accounts.
        /// </summary>
        [JsonProperty("ManagedAccounts", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ServiceUsage> ManagedAccounts { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BillableUsageReport : ({string.Join(", ", toStringOutput)})";
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
            return obj is BillableUsageReport other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.UsageForAllAccounts == null && other.UsageForAllAccounts == null) || (this.UsageForAllAccounts?.Equals(other.UsageForAllAccounts) == true)) &&
                ((this.SkuName == null && other.SkuName == null) || (this.SkuName?.Equals(other.SkuName) == true)) &&
                ((this.TransactionsAllowed == null && other.TransactionsAllowed == null) || (this.TransactionsAllowed?.Equals(other.TransactionsAllowed) == true)) &&
                ((this.TotalTransactionCount == null && other.TotalTransactionCount == null) || (this.TotalTransactionCount?.Equals(other.TotalTransactionCount) == true)) &&
                ((this.PrimaryAccount == null && other.PrimaryAccount == null) || (this.PrimaryAccount?.Equals(other.PrimaryAccount) == true)) &&
                ((this.ManagedAccounts == null && other.ManagedAccounts == null) || (this.ManagedAccounts?.Equals(other.ManagedAccounts) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.UsageForAllAccounts = {(this.UsageForAllAccounts == null ? "null" : this.UsageForAllAccounts.ToString())}");
            toStringOutput.Add($"this.SkuName = {(this.SkuName == null ? "null" : this.SkuName)}");
            toStringOutput.Add($"this.TransactionsAllowed = {(this.TransactionsAllowed == null ? "null" : this.TransactionsAllowed)}");
            toStringOutput.Add($"this.TotalTransactionCount = {(this.TotalTransactionCount == null ? "null" : this.TotalTransactionCount)}");
            toStringOutput.Add($"this.PrimaryAccount = {(this.PrimaryAccount == null ? "null" : this.PrimaryAccount.ToString())}");
            toStringOutput.Add($"this.ManagedAccounts = {(this.ManagedAccounts == null ? "null" : $"[{string.Join(", ", this.ManagedAccounts)} ]")}");
        }
    }
}