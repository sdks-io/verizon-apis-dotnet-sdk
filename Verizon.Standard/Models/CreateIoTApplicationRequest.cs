// <copyright file="CreateIoTApplicationRequest.cs" company="APIMatic">
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
    /// CreateIoTApplicationRequest.
    /// </summary>
    public class CreateIoTApplicationRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIoTApplicationRequest"/> class.
        /// </summary>
        public CreateIoTApplicationRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIoTApplicationRequest"/> class.
        /// </summary>
        /// <param name="appName">appName.</param>
        /// <param name="billingAccountID">billingAccountID.</param>
        /// <param name="clientID">clientID.</param>
        /// <param name="clientSecret">clientSecret.</param>
        /// <param name="emailIDs">emailIDs.</param>
        /// <param name="resourcegroup">resourcegroup.</param>
        /// <param name="sampleIOTcApp">sampleIOTcApp.</param>
        /// <param name="subscriptionID">subscriptionID.</param>
        /// <param name="tenantID">tenantID.</param>
        public CreateIoTApplicationRequest(
            string appName = null,
            string billingAccountID = null,
            string clientID = null,
            string clientSecret = null,
            string emailIDs = null,
            string resourcegroup = null,
            string sampleIOTcApp = null,
            string subscriptionID = null,
            string tenantID = null)
        {
            this.AppName = appName;
            this.BillingAccountID = billingAccountID;
            this.ClientID = clientID;
            this.ClientSecret = clientSecret;
            this.EmailIDs = emailIDs;
            this.Resourcegroup = resourcegroup;
            this.SampleIOTcApp = sampleIOTcApp;
            this.SubscriptionID = subscriptionID;
            this.TenantID = tenantID;
        }

        /// <summary>
        /// A user defined name for the application being deployed in Azure IoT Central.
        /// </summary>
        [JsonProperty("appName", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// The ThingSpace ID of the authenticating billing account
        /// </summary>
        [JsonProperty("billingAccountID", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingAccountID { get; set; }

        /// <summary>
        /// The Azure ClientID of the associated Azure target account
        /// </summary>
        [JsonProperty("clientID", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientID { get; set; }

        /// <summary>
        /// The Azure Client Secret of the associated Azure target account
        /// </summary>
        [JsonProperty("clientSecret", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// The “email IDs” to be added to/sent to with this API.
        /// </summary>
        [JsonProperty("emailIDs", NullValueHandling = NullValueHandling.Ignore)]
        public string EmailIDs { get; set; }

        /// <summary>
        /// The Azure Resource group of the associated Azure target account
        /// </summary>
        [JsonProperty("resourcegroup", NullValueHandling = NullValueHandling.Ignore)]
        public string Resourcegroup { get; set; }

        /// <summary>
        /// This is the reference Azure IoT Central application developed by Verizon.
        /// </summary>
        [JsonProperty("sampleIOTcApp", NullValueHandling = NullValueHandling.Ignore)]
        public string SampleIOTcApp { get; set; }

        /// <summary>
        /// The Azure Subscription ID of the associated Azure target account
        /// </summary>
        [JsonProperty("subscriptionID", NullValueHandling = NullValueHandling.Ignore)]
        public string SubscriptionID { get; set; }

        /// <summary>
        /// The Azure Tenant ID of the associated Azure target account
        /// </summary>
        [JsonProperty("tenantID", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantID { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateIoTApplicationRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreateIoTApplicationRequest other &&                ((this.AppName == null && other.AppName == null) || (this.AppName?.Equals(other.AppName) == true)) &&
                ((this.BillingAccountID == null && other.BillingAccountID == null) || (this.BillingAccountID?.Equals(other.BillingAccountID) == true)) &&
                ((this.ClientID == null && other.ClientID == null) || (this.ClientID?.Equals(other.ClientID) == true)) &&
                ((this.ClientSecret == null && other.ClientSecret == null) || (this.ClientSecret?.Equals(other.ClientSecret) == true)) &&
                ((this.EmailIDs == null && other.EmailIDs == null) || (this.EmailIDs?.Equals(other.EmailIDs) == true)) &&
                ((this.Resourcegroup == null && other.Resourcegroup == null) || (this.Resourcegroup?.Equals(other.Resourcegroup) == true)) &&
                ((this.SampleIOTcApp == null && other.SampleIOTcApp == null) || (this.SampleIOTcApp?.Equals(other.SampleIOTcApp) == true)) &&
                ((this.SubscriptionID == null && other.SubscriptionID == null) || (this.SubscriptionID?.Equals(other.SubscriptionID) == true)) &&
                ((this.TenantID == null && other.TenantID == null) || (this.TenantID?.Equals(other.TenantID) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AppName = {(this.AppName == null ? "null" : this.AppName == string.Empty ? "" : this.AppName)}");
            toStringOutput.Add($"this.BillingAccountID = {(this.BillingAccountID == null ? "null" : this.BillingAccountID == string.Empty ? "" : this.BillingAccountID)}");
            toStringOutput.Add($"this.ClientID = {(this.ClientID == null ? "null" : this.ClientID == string.Empty ? "" : this.ClientID)}");
            toStringOutput.Add($"this.ClientSecret = {(this.ClientSecret == null ? "null" : this.ClientSecret == string.Empty ? "" : this.ClientSecret)}");
            toStringOutput.Add($"this.EmailIDs = {(this.EmailIDs == null ? "null" : this.EmailIDs == string.Empty ? "" : this.EmailIDs)}");
            toStringOutput.Add($"this.Resourcegroup = {(this.Resourcegroup == null ? "null" : this.Resourcegroup == string.Empty ? "" : this.Resourcegroup)}");
            toStringOutput.Add($"this.SampleIOTcApp = {(this.SampleIOTcApp == null ? "null" : this.SampleIOTcApp == string.Empty ? "" : this.SampleIOTcApp)}");
            toStringOutput.Add($"this.SubscriptionID = {(this.SubscriptionID == null ? "null" : this.SubscriptionID == string.Empty ? "" : this.SubscriptionID)}");
            toStringOutput.Add($"this.TenantID = {(this.TenantID == null ? "null" : this.TenantID == string.Empty ? "" : this.TenantID)}");
        }
    }
}