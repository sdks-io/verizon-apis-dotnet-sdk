// <copyright file="CreateTargetRequest.cs" company="APIMatic">
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
    /// CreateTargetRequest.
    /// </summary>
    public class CreateTargetRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTargetRequest"/> class.
        /// </summary>
        public CreateTargetRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTargetRequest"/> class.
        /// </summary>
        /// <param name="accountidentifier">accountidentifier.</param>
        /// <param name="billingaccountid">billingaccountid.</param>
        /// <param name="kind">kind.</param>
        /// <param name="address">address.</param>
        /// <param name="addressscheme">addressscheme.</param>
        /// <param name="fields">fields.</param>
        /// <param name="description">description.</param>
        /// <param name="externalid">externalid.</param>
        /// <param name="name">name.</param>
        /// <param name="region">region.</param>
        /// <param name="key1">key1.</param>
        /// <param name="oauth">oauth.</param>
        public CreateTargetRequest(
            Models.AccountIdentifier accountidentifier = null,
            string billingaccountid = null,
            string kind = null,
            string address = null,
            string addressscheme = null,
            Models.CreateTargetRequestFields fields = null,
            string description = null,
            string externalid = null,
            string name = null,
            string region = null,
            string key1 = null,
            Models.TargetAuthentication oauth = null)
        {
            this.Accountidentifier = accountidentifier;
            this.Billingaccountid = billingaccountid;
            this.Kind = kind;
            this.Address = address;
            this.Addressscheme = addressscheme;
            this.Fields = fields;
            this.Description = description;
            this.Externalid = externalid;
            this.Name = name;
            this.Region = region;
            this.Key1 = key1;
            this.Oauth = oauth;
        }

        /// <summary>
        /// The ID of the authenticating billing account, in the format `{"billingaccountid":"1234567890-12345"}`.
        /// </summary>
        [JsonProperty("accountidentifier", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AccountIdentifier Accountidentifier { get; set; }

        /// <summary>
        /// The ID of the authenticating billing account.
        /// </summary>
        [JsonProperty("billingaccountid", NullValueHandling = NullValueHandling.Ignore)]
        public string Billingaccountid { get; set; }

        /// <summary>
        /// Identifies the resource kind. Targets are ts.target.
        /// </summary>
        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        public string Kind { get; set; }

        /// <summary>
        /// The endpoint for notifications or data streams. The format depends on the selected `addressscheme`.<br />`streamrest` requires a `host:port` value <br />`streamawsiot` requres a valid ARN.
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// The transport format. Valid values are: <br />streamawsiot - streamed data to an AWS account <br />streamrest - streamed REST data to a defined endpoint.
        /// </summary>
        [JsonProperty("addressscheme", NullValueHandling = NullValueHandling.Ignore)]
        public string Addressscheme { get; set; }

        /// <summary>
        /// Gets or sets Fields.
        /// </summary>
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateTargetRequestFields Fields { get; set; }

        /// <summary>
        /// Descriptive information about the target.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Security identification string created by a POST /targets/actions/newextid request.
        /// </summary>
        [JsonProperty("externalid", NullValueHandling = NullValueHandling.Ignore)]
        public string Externalid { get; set; }

        /// <summary>
        /// Name of the target.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// AWS region value.
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// OAuth 2.0 bearer token.
        /// </summary>
        [JsonProperty("key1", NullValueHandling = NullValueHandling.Ignore)]
        public string Key1 { get; set; }

        /// <summary>
        /// OAuth 2 token and refresh token for TS to stream events to Target.
        /// </summary>
        [JsonProperty("oauth", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TargetAuthentication Oauth { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateTargetRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateTargetRequest other &&
                (this.Accountidentifier == null && other.Accountidentifier == null ||
                 this.Accountidentifier?.Equals(other.Accountidentifier) == true) &&
                (this.Billingaccountid == null && other.Billingaccountid == null ||
                 this.Billingaccountid?.Equals(other.Billingaccountid) == true) &&
                (this.Kind == null && other.Kind == null ||
                 this.Kind?.Equals(other.Kind) == true) &&
                (this.Address == null && other.Address == null ||
                 this.Address?.Equals(other.Address) == true) &&
                (this.Addressscheme == null && other.Addressscheme == null ||
                 this.Addressscheme?.Equals(other.Addressscheme) == true) &&
                (this.Fields == null && other.Fields == null ||
                 this.Fields?.Equals(other.Fields) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.Externalid == null && other.Externalid == null ||
                 this.Externalid?.Equals(other.Externalid) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Region == null && other.Region == null ||
                 this.Region?.Equals(other.Region) == true) &&
                (this.Key1 == null && other.Key1 == null ||
                 this.Key1?.Equals(other.Key1) == true) &&
                (this.Oauth == null && other.Oauth == null ||
                 this.Oauth?.Equals(other.Oauth) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Accountidentifier = {(this.Accountidentifier == null ? "null" : this.Accountidentifier.ToString())}");
            toStringOutput.Add($"Billingaccountid = {this.Billingaccountid ?? "null"}");
            toStringOutput.Add($"Kind = {this.Kind ?? "null"}");
            toStringOutput.Add($"Address = {this.Address ?? "null"}");
            toStringOutput.Add($"Addressscheme = {this.Addressscheme ?? "null"}");
            toStringOutput.Add($"Fields = {(this.Fields == null ? "null" : this.Fields.ToString())}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"Externalid = {this.Externalid ?? "null"}");
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Region = {this.Region ?? "null"}");
            toStringOutput.Add($"Key1 = {this.Key1 ?? "null"}");
            toStringOutput.Add($"Oauth = {(this.Oauth == null ? "null" : this.Oauth.ToString())}");
        }
    }
}