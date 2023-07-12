// <copyright file="AzureCspProfile.cs" company="APIMatic">
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
    /// AzureCspProfile.
    /// </summary>
    public class AzureCspProfile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AzureCspProfile"/> class.
        /// </summary>
        public AzureCspProfile()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureCspProfile"/> class.
        /// </summary>
        /// <param name="tenantID">tenantID.</param>
        /// <param name="subscriptionID">subscriptionID.</param>
        /// <param name="clientId">clientId.</param>
        /// <param name="clientSecret">clientSecret.</param>
        public AzureCspProfile(
            string tenantID = null,
            string subscriptionID = null,
            string clientId = null,
            string clientSecret = null)
        {
            this.TenantID = tenantID;
            this.SubscriptionID = subscriptionID;
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
        }

        /// <summary>
        /// Azure tenant ID.
        /// </summary>
        [JsonProperty("tenantID", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantID { get; set; }

        /// <summary>
        /// Azure subscription ID.
        /// </summary>
        [JsonProperty("subscriptionID", NullValueHandling = NullValueHandling.Ignore)]
        public string SubscriptionID { get; set; }

        /// <summary>
        /// Azure client ID.
        /// </summary>
        [JsonProperty("clientId", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientId { get; set; }

        /// <summary>
        /// Azure client secret.
        /// </summary>
        [JsonProperty("clientSecret", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientSecret { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AzureCspProfile : ({string.Join(", ", toStringOutput)})";
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
            return obj is AzureCspProfile other &&                ((this.TenantID == null && other.TenantID == null) || (this.TenantID?.Equals(other.TenantID) == true)) &&
                ((this.SubscriptionID == null && other.SubscriptionID == null) || (this.SubscriptionID?.Equals(other.SubscriptionID) == true)) &&
                ((this.ClientId == null && other.ClientId == null) || (this.ClientId?.Equals(other.ClientId) == true)) &&
                ((this.ClientSecret == null && other.ClientSecret == null) || (this.ClientSecret?.Equals(other.ClientSecret) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TenantID = {(this.TenantID == null ? "null" : this.TenantID == string.Empty ? "" : this.TenantID)}");
            toStringOutput.Add($"this.SubscriptionID = {(this.SubscriptionID == null ? "null" : this.SubscriptionID == string.Empty ? "" : this.SubscriptionID)}");
            toStringOutput.Add($"this.ClientId = {(this.ClientId == null ? "null" : this.ClientId == string.Empty ? "" : this.ClientId)}");
            toStringOutput.Add($"this.ClientSecret = {(this.ClientSecret == null ? "null" : this.ClientSecret == string.Empty ? "" : this.ClientSecret)}");
        }
    }
}