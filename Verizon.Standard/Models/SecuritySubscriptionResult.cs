// <copyright file="SecuritySubscriptionResult.cs" company="APIMatic">
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
    /// SecuritySubscriptionResult.
    /// </summary>
    public class SecuritySubscriptionResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecuritySubscriptionResult"/> class.
        /// </summary>
        public SecuritySubscriptionResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecuritySubscriptionResult"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="subscriptionList">subscriptionList.</param>
        public SecuritySubscriptionResult(
            string accountName = null,
            List<Models.SecuritySubscription> subscriptionList = null)
        {
            this.AccountName = accountName;
            this.SubscriptionList = subscriptionList;
        }

        /// <summary>
        /// The name of a billing account.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// The list of SKU numbers and counts for each license type specified in the request.
        /// </summary>
        [JsonProperty("subscriptionList", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.SecuritySubscription> SubscriptionList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SecuritySubscriptionResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is SecuritySubscriptionResult other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.SubscriptionList == null && other.SubscriptionList == null) || (this.SubscriptionList?.Equals(other.SubscriptionList) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName == string.Empty ? "" : this.AccountName)}");
            toStringOutput.Add($"this.SubscriptionList = {(this.SubscriptionList == null ? "null" : $"[{string.Join(", ", this.SubscriptionList)} ]")}");
        }
    }
}