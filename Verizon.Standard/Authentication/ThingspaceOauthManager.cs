// <copyright file="ThingspaceOauthManager.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Verizon.Standard.Authentication
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using Verizon.Standard.Controllers;
        using Verizon.Standard.Http.Response;using Verizon.Standard.Models;
    using Verizon.Standard.Utilities;
    using Verizon.Standard.Exceptions;
    using APIMatic.Core.Authentication;
    using APIMatic.Core;

    /// <summary>
    /// ThingspaceOauthManager Class.
    /// </summary>
    public class ThingspaceOauthManager : AuthManager, IThingspaceOauthCredentials
    {
        private Func<OauthAuthorizationController> oAuthApi;

        /// <summary>
        /// Initializes a new instance of the <see cref="ThingspaceOauthManager"/> class.
        /// </summary>
        /// <param name="thingspaceOauth"> OAuth 2 Client Cridentials Model.</param>
        internal ThingspaceOauthManager(ThingspaceOauthModel thingspaceOauth)
        {
            OauthClientId = thingspaceOauth?.OauthClientId;
            OauthClientSecret = thingspaceOauth?.OauthClientSecret;
            OauthToken = thingspaceOauth?.OauthToken;
            OauthScopes = thingspaceOauth?.OauthScopes;
            Parameters(authParameter => authParameter
                .Header(headerParameter => headerParameter
                    .Setup("Authorization",
                        OauthToken?.AccessToken == null ? null : $"Bearer {OauthToken?.AccessToken}"
                    ).Required()));
        }

        /// <summary>
        /// Gets string value for oauthClientId.
        /// </summary>
        public string OauthClientId { get; }

        /// <summary>
        /// Gets string value for oauthClientSecret.
        /// </summary>
        public string OauthClientSecret { get; }

        /// <summary>
        /// Gets Models.OauthToken value for oauthToken.
        /// </summary>
        public Models.OauthToken OauthToken { get; }

        /// <summary>
        /// Gets List of Models.OauthScopeThingspaceOauthEnum value for oauthScopes.
        /// </summary>
        public List<Models.OauthScopeThingspaceOauthEnum> OauthScopes { get; }

        /// <summary>
        /// Check if credentials match.
        /// </summary>
        /// <param name="oauthClientId"> The string value for credentials.</param>
        /// <param name="oauthClientSecret"> The string value for credentials.</param>
        /// <param name="oauthToken"> The Models.OauthToken value for credentials.</param>
        /// <param name="oauthScopes"> The List of Models.OauthScopeThingspaceOauthEnum value for credentials.</param>
        /// <returns> True if credentials matched.</returns>
        public bool Equals(string oauthClientId, string oauthClientSecret, Models.OauthToken oauthToken, List<Models.OauthScopeThingspaceOauthEnum> oauthScopes)
        {
            return oauthClientId.Equals(this.OauthClientId)
                    && oauthClientSecret.Equals(this.OauthClientSecret)
                    && ((oauthToken == null && this.OauthToken == null) || (oauthToken != null && this.OauthToken != null && oauthToken.Equals(this.OauthToken)))
                    && ((oauthScopes == null && this.OauthScopes == null) || (oauthScopes != null && this.OauthScopes != null && oauthScopes.Equals(this.OauthScopes)));
        }

        /// <summary>
        /// Fetch the OAuth token.
        /// </summary>
        /// <param name="additionalParameters">Dictionary of additional parameters.</param>
        /// <returns>Models.OauthToken.</returns>
        public Models.OauthToken FetchToken(Dictionary<string, object> additionalParameters = null)
            => ApiHelper.RunTask(FetchTokenAsync(additionalParameters));
       

        /// <summary>
        /// Fetch the OAuth token asynchronously.
        /// </summary>
        /// <param name="additionalParameters">Dictionary of additional parameters.</param>
        /// <returns>Models.OauthToken.</returns>
        public async Task<Models.OauthToken> FetchTokenAsync(Dictionary<string, object> additionalParameters = null)
        {
            var token = await oAuthApi?.Invoke().RequestTokenThingspaceOauthAsync(BuildBasicAuthHeader(), this.OauthScopes.GetValues(), additionalParameters);

            if (token.Data.ExpiresIn != null && token.Data.ExpiresIn != 0)
            {
                token.Data.Expiry = (long)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds + token.Data.ExpiresIn;
            }

            return token.Data;
        }
 
        /// <summary>
        /// Checks if token is expired.
        /// </summary>
        /// <returns> Returns true if token is expired.</returns>
        public bool IsTokenExpired()
        {
           if (this.OauthToken == null)
           {
               throw new InvalidOperationException("OAuth token is missing.");
           }
        
           return this.OauthToken.Expiry != null
               && this.OauthToken.Expiry < (long)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
        }

        public void ApplyGlobalConfiguration(Func<OauthAuthorizationController> controllerGetter)
        {
            oAuthApi = controllerGetter;
        }

        /// <summary>
        /// Validates the authentication parameters for the HTTP Request.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
            if (OauthToken == null)
            {
                throw new ApiException(
                        "Client is not authorized.An OAuth token is needed to make API calls.");
            }

            if (IsTokenExpired())
            {
                throw new ApiException(
                        "OAuth token is expired. A valid token is needed to make API calls.");
            }
        }


        /// <summary>
        /// Build basic auth header.
        /// </summary>
        /// <returns> string. </returns>
        private string BuildBasicAuthHeader()
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(this.OauthClientId + ':' + this.OauthClientSecret);
            return "Basic " + Convert.ToBase64String(plainTextBytes);
        }
    }

    public sealed class ThingspaceOauthModel
    {
        internal ThingspaceOauthModel()
        {
        }

        internal string OauthClientId { get; set; }

        internal string OauthClientSecret { get; set; }

        internal Models.OauthToken OauthToken { get; set; }

        internal List<Models.OauthScopeThingspaceOauthEnum> OauthScopes { get; set; }

        /// <summary>
        /// Creates an object of the ThingspaceOauthModel using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            return new Builder(OauthClientId, OauthClientSecret)
                .OauthToken(OauthToken)
                .OauthScopes(OauthScopes);
        }

        /// <summary>
        /// Builder class for ThingspaceOauthModel.
        /// </summary>
        public class Builder
        {
            private string oauthClientId;
            private string oauthClientSecret;
            private Models.OauthToken oauthToken;
            private List<Models.OauthScopeThingspaceOauthEnum> oauthScopes;

            public Builder(string oauthClientId, string oauthClientSecret)
            {
                this.oauthClientId = oauthClientId ?? throw new ArgumentNullException(nameof(oauthClientId));
                this.oauthClientSecret = oauthClientSecret ?? throw new ArgumentNullException(nameof(oauthClientSecret));
            }

            /// <summary>
            /// Sets OauthClientId.
            /// </summary>
            /// <param name="oauthClientId">OauthClientId.</param>
            /// <returns>Builder.</returns>
            public Builder OauthClientId(string oauthClientId)
            {
                this.oauthClientId = oauthClientId ?? throw new ArgumentNullException(nameof(oauthClientId));
                return this;
            }


            /// <summary>
            /// Sets OauthClientSecret.
            /// </summary>
            /// <param name="oauthClientSecret">OauthClientSecret.</param>
            /// <returns>Builder.</returns>
            public Builder OauthClientSecret(string oauthClientSecret)
            {
                this.oauthClientSecret = oauthClientSecret ?? throw new ArgumentNullException(nameof(oauthClientSecret));
                return this;
            }


            /// <summary>
            /// Sets OauthToken.
            /// </summary>
            /// <param name="oauthToken">OauthToken.</param>
            /// <returns>Builder.</returns>
            public Builder OauthToken(Models.OauthToken oauthToken)
            {
                this.oauthToken = oauthToken;
                return this;
            }


            /// <summary>
            /// Sets OauthScopes.
            /// </summary>
            /// <param name="oauthScopes">OauthScopes.</param>
            /// <returns>Builder.</returns>
            public Builder OauthScopes(List<Models.OauthScopeThingspaceOauthEnum> oauthScopes)
            {
                this.oauthScopes = oauthScopes;
                return this;
            }


            /// <summary>
            /// Creates an object of the ThingspaceOauthModel using the values provided for the builder.
            /// </summary>
            /// <returns>ThingspaceOauthModel.</returns>
            public ThingspaceOauthModel Build()
            {
                return new ThingspaceOauthModel()
                {
                    OauthClientId = this.oauthClientId,
                    OauthClientSecret = this.oauthClientSecret,
                    OauthToken = this.oauthToken,
                    OauthScopes = this.oauthScopes
                };
            }
        }
    }
}