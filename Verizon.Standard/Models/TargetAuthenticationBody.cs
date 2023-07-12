// <copyright file="TargetAuthenticationBody.cs" company="APIMatic">
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
    /// TargetAuthenticationBody.
    /// </summary>
    public class TargetAuthenticationBody
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TargetAuthenticationBody"/> class.
        /// </summary>
        public TargetAuthenticationBody()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TargetAuthenticationBody"/> class.
        /// </summary>
        /// <param name="grantType">grant_type.</param>
        /// <param name="refreshToken">refresh_token.</param>
        /// <param name="scope">scope.</param>
        /// <param name="headers">headers.</param>
        /// <param name="host">host.</param>
        public TargetAuthenticationBody(
            string grantType = null,
            string refreshToken = null,
            string scope = null,
            Models.TargetAuthenticationBodyHeaders headers = null,
            Models.TargetAuthenticationBodyHost host = null)
        {
            this.GrantType = grantType;
            this.RefreshToken = refreshToken;
            this.Scope = scope;
            this.Headers = headers;
            this.Host = host;
        }

        /// <summary>
        /// Authentication grant type.
        /// </summary>
        [JsonProperty("grant_type", NullValueHandling = NullValueHandling.Ignore)]
        public string GrantType { get; set; }

        /// <summary>
        /// Refresh token.
        /// </summary>
        [JsonProperty("refresh_token", NullValueHandling = NullValueHandling.Ignore)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Authentication scopes.
        /// </summary>
        [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
        public string Scope { get; set; }

        /// <summary>
        /// Authentication headers.
        /// </summary>
        [JsonProperty("headers", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TargetAuthenticationBodyHeaders Headers { get; set; }

        /// <summary>
        /// Host information.
        /// </summary>
        [JsonProperty("host", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TargetAuthenticationBodyHost Host { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TargetAuthenticationBody : ({string.Join(", ", toStringOutput)})";
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
            return obj is TargetAuthenticationBody other &&                ((this.GrantType == null && other.GrantType == null) || (this.GrantType?.Equals(other.GrantType) == true)) &&
                ((this.RefreshToken == null && other.RefreshToken == null) || (this.RefreshToken?.Equals(other.RefreshToken) == true)) &&
                ((this.Scope == null && other.Scope == null) || (this.Scope?.Equals(other.Scope) == true)) &&
                ((this.Headers == null && other.Headers == null) || (this.Headers?.Equals(other.Headers) == true)) &&
                ((this.Host == null && other.Host == null) || (this.Host?.Equals(other.Host) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.GrantType = {(this.GrantType == null ? "null" : this.GrantType == string.Empty ? "" : this.GrantType)}");
            toStringOutput.Add($"this.RefreshToken = {(this.RefreshToken == null ? "null" : this.RefreshToken == string.Empty ? "" : this.RefreshToken)}");
            toStringOutput.Add($"this.Scope = {(this.Scope == null ? "null" : this.Scope == string.Empty ? "" : this.Scope)}");
            toStringOutput.Add($"this.Headers = {(this.Headers == null ? "null" : this.Headers.ToString())}");
            toStringOutput.Add($"this.Host = {(this.Host == null ? "null" : this.Host.ToString())}");
        }
    }
}