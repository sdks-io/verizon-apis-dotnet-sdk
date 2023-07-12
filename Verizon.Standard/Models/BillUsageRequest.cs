// <copyright file="BillUsageRequest.cs" company="APIMatic">
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
    /// BillUsageRequest.
    /// </summary>
    public class BillUsageRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillUsageRequest"/> class.
        /// </summary>
        public BillUsageRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillUsageRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="usageForAllAccounts">usageForAllAccounts.</param>
        public BillUsageRequest(
            string accountName = null,
            string startDate = null,
            string endDate = null,
            bool? usageForAllAccounts = null)
        {
            this.AccountName = accountName;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.UsageForAllAccounts = usageForAllAccounts;
        }

        /// <summary>
        /// Account identifier.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// Start date to search for billable usage, mm-dd-yyyy.
        /// </summary>
        [JsonProperty("startDate", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDate { get; set; }

        /// <summary>
        /// End date to search for billable usage, mm-dd-yyyy.
        /// </summary>
        [JsonProperty("endDate", NullValueHandling = NullValueHandling.Ignore)]
        public string EndDate { get; set; }

        /// <summary>
        /// Request usage for single or multiple accounts.
        /// </summary>
        [JsonProperty("usageForAllAccounts", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UsageForAllAccounts { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BillUsageRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is BillUsageRequest other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.StartDate == null && other.StartDate == null) || (this.StartDate?.Equals(other.StartDate) == true)) &&
                ((this.EndDate == null && other.EndDate == null) || (this.EndDate?.Equals(other.EndDate) == true)) &&
                ((this.UsageForAllAccounts == null && other.UsageForAllAccounts == null) || (this.UsageForAllAccounts?.Equals(other.UsageForAllAccounts) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName == string.Empty ? "" : this.AccountName)}");
            toStringOutput.Add($"this.StartDate = {(this.StartDate == null ? "null" : this.StartDate == string.Empty ? "" : this.StartDate)}");
            toStringOutput.Add($"this.EndDate = {(this.EndDate == null ? "null" : this.EndDate == string.Empty ? "" : this.EndDate)}");
            toStringOutput.Add($"this.UsageForAllAccounts = {(this.UsageForAllAccounts == null ? "null" : this.UsageForAllAccounts.ToString())}");
        }
    }
}