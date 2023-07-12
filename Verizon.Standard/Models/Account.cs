// <copyright file="Account.cs" company="APIMatic">
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
    /// Account.
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// </summary>
        public Account()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="accountNumber">accountNumber.</param>
        /// <param name="organizationName">organizationName.</param>
        /// <param name="isProvisioningAllowed">isProvisioningAllowed.</param>
        /// <param name="carriers">carriers.</param>
        /// <param name="features">features.</param>
        /// <param name="iPPools">iPPools.</param>
        /// <param name="servicePlans">servicePlans.</param>
        public Account(
            string accountName = null,
            string accountNumber = null,
            string organizationName = null,
            bool? isProvisioningAllowed = null,
            List<string> carriers = null,
            List<string> features = null,
            List<Models.IPPool> iPPools = null,
            List<Models.ServicePlan> servicePlans = null)
        {
            this.AccountName = accountName;
            this.AccountNumber = accountNumber;
            this.OrganizationName = organizationName;
            this.IsProvisioningAllowed = isProvisioningAllowed;
            this.Carriers = carriers;
            this.Features = features;
            this.IPPools = iPPools;
            this.ServicePlans = servicePlans;
        }

        /// <summary>
        /// The name of the account.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// The billing number of the account.
        /// </summary>
        [JsonProperty("accountNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The name of the organization that the account is part of.
        /// </summary>
        [JsonProperty("organizationName", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationName { get; set; }

        /// <summary>
        /// True if devices can be added to the account and activated with a single request. False if devices must be added to the account before they can be activated.
        /// </summary>
        [JsonProperty("isProvisioningAllowed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsProvisioningAllowed { get; set; }

        /// <summary>
        /// The names of all carriers for the account.
        /// </summary>
        [JsonProperty("carriers", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Carriers { get; set; }

        /// <summary>
        /// The names of features that are enabled for the account.
        /// </summary>
        [JsonProperty("features", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Features { get; set; }

        /// <summary>
        /// Array of IP pools that are available to the account.
        /// </summary>
        [JsonProperty("iPPools", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.IPPool> IPPools { get; set; }

        /// <summary>
        /// Array of service plans that are available to the account.
        /// </summary>
        [JsonProperty("servicePlans", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ServicePlan> ServicePlans { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Account : ({string.Join(", ", toStringOutput)})";
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
            return obj is Account other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.OrganizationName == null && other.OrganizationName == null) || (this.OrganizationName?.Equals(other.OrganizationName) == true)) &&
                ((this.IsProvisioningAllowed == null && other.IsProvisioningAllowed == null) || (this.IsProvisioningAllowed?.Equals(other.IsProvisioningAllowed) == true)) &&
                ((this.Carriers == null && other.Carriers == null) || (this.Carriers?.Equals(other.Carriers) == true)) &&
                ((this.Features == null && other.Features == null) || (this.Features?.Equals(other.Features) == true)) &&
                ((this.IPPools == null && other.IPPools == null) || (this.IPPools?.Equals(other.IPPools) == true)) &&
                ((this.ServicePlans == null && other.ServicePlans == null) || (this.ServicePlans?.Equals(other.ServicePlans) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName == string.Empty ? "" : this.AccountName)}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber == string.Empty ? "" : this.AccountNumber)}");
            toStringOutput.Add($"this.OrganizationName = {(this.OrganizationName == null ? "null" : this.OrganizationName == string.Empty ? "" : this.OrganizationName)}");
            toStringOutput.Add($"this.IsProvisioningAllowed = {(this.IsProvisioningAllowed == null ? "null" : this.IsProvisioningAllowed.ToString())}");
            toStringOutput.Add($"this.Carriers = {(this.Carriers == null ? "null" : $"[{string.Join(", ", this.Carriers)} ]")}");
            toStringOutput.Add($"this.Features = {(this.Features == null ? "null" : $"[{string.Join(", ", this.Features)} ]")}");
            toStringOutput.Add($"this.IPPools = {(this.IPPools == null ? "null" : $"[{string.Join(", ", this.IPPools)} ]")}");
            toStringOutput.Add($"this.ServicePlans = {(this.ServicePlans == null ? "null" : $"[{string.Join(", ", this.ServicePlans)} ]")}");
        }
    }
}