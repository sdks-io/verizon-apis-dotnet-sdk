// <copyright file="CreateSubscriptionRequest.cs" company="APIMatic">
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
    /// CreateSubscriptionRequest.
    /// </summary>
    public class CreateSubscriptionRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriptionRequest"/> class.
        /// </summary>
        public CreateSubscriptionRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriptionRequest"/> class.
        /// </summary>
        /// <param name="accountidentifier">accountidentifier.</param>
        /// <param name="description">description.</param>
        /// <param name="disabled">disabled.</param>
        /// <param name="email">email.</param>
        /// <param name="filter">filter.</param>
        /// <param name="billingaccountid">billingaccountid.</param>
        /// <param name="streamkind">streamkind.</param>
        /// <param name="targetid">targetid.</param>
        /// <param name="name">name.</param>
        /// <param name="allowaggregation">allowaggregation.</param>
        public CreateSubscriptionRequest(
            Models.AccountIdentifier accountidentifier = null,
            string description = null,
            bool? disabled = null,
            string email = null,
            string filter = null,
            string billingaccountid = null,
            string streamkind = null,
            string targetid = null,
            string name = null,
            bool? allowaggregation = null)
        {
            this.Accountidentifier = accountidentifier;
            this.Description = description;
            this.Disabled = disabled;
            this.Email = email;
            this.Filter = filter;
            this.Billingaccountid = billingaccountid;
            this.Streamkind = streamkind;
            this.Targetid = targetid;
            this.Name = name;
            this.Allowaggregation = allowaggregation;
        }

        /// <summary>
        /// The ID of the authenticating billing account, in the format `{"billingaccountid":"1234567890-12345"}`.
        /// </summary>
        [JsonProperty("accountidentifier", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AccountIdentifier Accountidentifier { get; set; }

        /// <summary>
        /// Descriptive information about the subscription.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Enable or disable the subscription. A disabled subscription will not send any data.
        /// </summary>
        [JsonProperty("disabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disabled { get; set; }

        /// <summary>
        /// The address to which any error reports should be delivered.
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// String containing a $filter object with a property and value to filter out non-matching events.
        /// </summary>
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public string Filter { get; set; }

        /// <summary>
        /// Gets or sets Billingaccountid.
        /// </summary>
        [JsonProperty("billingaccountid", NullValueHandling = NullValueHandling.Ignore)]
        public string Billingaccountid { get; set; }

        /// <summary>
        /// The type of event data to send via this subscription. This will be `ts.event` in most cases. Other event types are `ts.event.diagnostics` for device diagnostic data, `ts.event.configuration` for device configuration events, or `ts.event.security`. Note that the device ThingSpace client must support sending specific event types for anything other than `ts.event`.
        /// </summary>
        [JsonProperty("streamkind", NullValueHandling = NullValueHandling.Ignore)]
        public string Streamkind { get; set; }

        /// <summary>
        /// The ID of the target resource to be used when dispatching events. The corresponding target should have a “stream” addressscheme.
        /// </summary>
        [JsonProperty("targetid", NullValueHandling = NullValueHandling.Ignore)]
        public string Targetid { get; set; }

        /// <summary>
        /// Name of the subscription.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Setting this value to `false` prevents the data returned from being aggregated and makes the data easier to parse.
        /// </summary>
        [JsonProperty("allowaggregation", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowaggregation { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateSubscriptionRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreateSubscriptionRequest other &&                ((this.Accountidentifier == null && other.Accountidentifier == null) || (this.Accountidentifier?.Equals(other.Accountidentifier) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Disabled == null && other.Disabled == null) || (this.Disabled?.Equals(other.Disabled) == true)) &&
                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true)) &&
                ((this.Filter == null && other.Filter == null) || (this.Filter?.Equals(other.Filter) == true)) &&
                ((this.Billingaccountid == null && other.Billingaccountid == null) || (this.Billingaccountid?.Equals(other.Billingaccountid) == true)) &&
                ((this.Streamkind == null && other.Streamkind == null) || (this.Streamkind?.Equals(other.Streamkind) == true)) &&
                ((this.Targetid == null && other.Targetid == null) || (this.Targetid?.Equals(other.Targetid) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Allowaggregation == null && other.Allowaggregation == null) || (this.Allowaggregation?.Equals(other.Allowaggregation) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Accountidentifier = {(this.Accountidentifier == null ? "null" : this.Accountidentifier.ToString())}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.Disabled = {(this.Disabled == null ? "null" : this.Disabled.ToString())}");
            toStringOutput.Add($"this.Email = {(this.Email == null ? "null" : this.Email == string.Empty ? "" : this.Email)}");
            toStringOutput.Add($"this.Filter = {(this.Filter == null ? "null" : this.Filter == string.Empty ? "" : this.Filter)}");
            toStringOutput.Add($"this.Billingaccountid = {(this.Billingaccountid == null ? "null" : this.Billingaccountid == string.Empty ? "" : this.Billingaccountid)}");
            toStringOutput.Add($"this.Streamkind = {(this.Streamkind == null ? "null" : this.Streamkind == string.Empty ? "" : this.Streamkind)}");
            toStringOutput.Add($"this.Targetid = {(this.Targetid == null ? "null" : this.Targetid == string.Empty ? "" : this.Targetid)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.Allowaggregation = {(this.Allowaggregation == null ? "null" : this.Allowaggregation.ToString())}");
        }
    }
}