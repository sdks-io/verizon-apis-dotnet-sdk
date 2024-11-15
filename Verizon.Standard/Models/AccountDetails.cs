// <copyright file="AccountDetails.cs" company="APIMatic">
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
    /// AccountDetails.
    /// </summary>
    public class AccountDetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDetails"/> class.
        /// </summary>
        public AccountDetails()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDetails"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="accountNumber">accountNumber.</param>
        /// <param name="organizationName">organizationName.</param>
        /// <param name="isProvisioningAllowed">isProvisioningAllowed.</param>
        /// <param name="carriers">carriers.</param>
        /// <param name="features">features.</param>
        /// <param name="servicePlans">servicePlans.</param>
        public AccountDetails(
            string accountName = null,
            string accountNumber = null,
            string organizationName = null,
            bool? isProvisioningAllowed = null,
            List<Models.Carrier> carriers = null,
            List<Models.Feature> features = null,
            List<Models.CarrierServicePlan> servicePlans = null)
        {
            this.AccountName = accountName;
            this.AccountNumber = accountNumber;
            this.OrganizationName = organizationName;
            this.IsProvisioningAllowed = isProvisioningAllowed;
            this.Carriers = carriers;
            this.Features = features;
            this.ServicePlans = servicePlans;
        }

        /// <summary>
        /// The numeric name of the account, in the format "0000123456-00001". Leading zeros must be included.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// The numeric name of the account, in the format "0000123456-00001". Leading zeros must be included.
        /// </summary>
        [JsonProperty("accountNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// user defined name of organization
        /// </summary>
        [JsonProperty("organizationName", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationName { get; set; }

        /// <summary>
        /// Flag set to indicate if account details can be edited or not. Default is "true".
        /// </summary>
        [JsonProperty("isProvisioningAllowed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsProvisioningAllowed { get; set; }

        /// <summary>
        /// Gets or sets Carriers.
        /// </summary>
        [JsonProperty("carriers", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Carrier> Carriers { get; set; }

        /// <summary>
        /// Gets or sets Features.
        /// </summary>
        [JsonProperty("features", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Feature> Features { get; set; }

        /// <summary>
        /// Gets or sets ServicePlans.
        /// </summary>
        [JsonProperty("servicePlans", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CarrierServicePlan> ServicePlans { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AccountDetails : ({string.Join(", ", toStringOutput)})";
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
            return obj is AccountDetails other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.OrganizationName == null && other.OrganizationName == null) || (this.OrganizationName?.Equals(other.OrganizationName) == true)) &&
                ((this.IsProvisioningAllowed == null && other.IsProvisioningAllowed == null) || (this.IsProvisioningAllowed?.Equals(other.IsProvisioningAllowed) == true)) &&
                ((this.Carriers == null && other.Carriers == null) || (this.Carriers?.Equals(other.Carriers) == true)) &&
                ((this.Features == null && other.Features == null) || (this.Features?.Equals(other.Features) == true)) &&
                ((this.ServicePlans == null && other.ServicePlans == null) || (this.ServicePlans?.Equals(other.ServicePlans) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.OrganizationName = {(this.OrganizationName == null ? "null" : this.OrganizationName)}");
            toStringOutput.Add($"this.IsProvisioningAllowed = {(this.IsProvisioningAllowed == null ? "null" : this.IsProvisioningAllowed.ToString())}");
            toStringOutput.Add($"this.Carriers = {(this.Carriers == null ? "null" : $"[{string.Join(", ", this.Carriers)} ]")}");
            toStringOutput.Add($"this.Features = {(this.Features == null ? "null" : $"[{string.Join(", ", this.Features)} ]")}");
            toStringOutput.Add($"this.ServicePlans = {(this.ServicePlans == null ? "null" : $"[{string.Join(", ", this.ServicePlans)} ]")}");
        }
    }
}