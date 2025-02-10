// <copyright file="ServiceUsage.cs" company="APIMatic">
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
    /// ServiceUsage.
    /// </summary>
    public class ServiceUsage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceUsage"/> class.
        /// </summary>
        public ServiceUsage()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceUsage"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="transactionsCount">transactionsCount.</param>
        public ServiceUsage(
            string accountName = null,
            string transactionsCount = null)
        {
            this.AccountName = accountName;
            this.TransactionsCount = transactionsCount;
        }

        /// <summary>
        /// Account identifier.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// Total requests for the account during the reporting period.
        /// </summary>
        [JsonProperty("transactionsCount", NullValueHandling = NullValueHandling.Ignore)]
        public string TransactionsCount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ServiceUsage : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ServiceUsage other &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.TransactionsCount == null && other.TransactionsCount == null ||
                 this.TransactionsCount?.Equals(other.TransactionsCount) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
            toStringOutput.Add($"TransactionsCount = {this.TransactionsCount ?? "null"}");
        }
    }
}