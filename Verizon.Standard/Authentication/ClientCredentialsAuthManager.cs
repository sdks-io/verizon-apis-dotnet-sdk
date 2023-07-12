// <copyright file="ClientCredentialsAuthManager.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Verizon.Standard.Authentication
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using Verizon.Standard.Controllers;
    using Verizon.Standard.Http.Request;
        using Verizon.Standard.Http.Response;using Verizon.Standard.Models;
    using Verizon.Standard.Utilities;
    using Verizon.Standard.Exceptions;
    using APIMatic.Core.Authentication;
    using APIMatic.Core;

    /// <summary>
    /// ClientCredentialsAuthManager Class.
    /// </summary>
    public class ClientCredentialsAuthManager : AuthManager, IClientCredentialsAuth
    {
        private OauthAuthorizationController oAuthApi;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientCredOAuthManager"/> class.
        /// </summary>
        /// <param name="oauthClientId"> OAuth 2 Client ID.</param>
        /// <param name="oauthClientSecret"> OAuth 2 Client Secret.</param>
        /// <param name="oauthToken"> OAuth 2 token.</param>
        /// <param name="oauthScopes"> List of OAuth 2 scopes.</param>
        public ClientCredentialsAuthManager(
            string oauthClientId,
            string oauthClientSecret,
            OauthToken oauthToken,
            List<Models.OauthScopeEnum> oauthScopes)
        {
            this.OauthClientId = oauthClientId;
            this.OauthClientSecret = oauthClientSecret;
            this.OauthToken = oauthToken;
            this.OauthScopes = oauthScopes;
            Parameters(authParameter => authParameter
                .Header(headerParameter => headerParameter
                    .Setup("Authorization", $"Bearer {OauthToken?.AccessToken}")));
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
        /// Gets List of Models.OauthScopeEnum value for oauthScopes.
        /// </summary>
        public List<Models.OauthScopeEnum> OauthScopes { get; }

        /// <summary>
        /// Check if credentials match.
        /// </summary>
        /// <param name="oauthClientId"> The string value for credentials.</param>
        /// <param name="oauthClientSecret"> The string value for credentials.</param>
        /// <param name="oauthToken"> The Models.OauthToken value for credentials.</param>
        /// <param name="oauthScopes"> The List of Models.OauthScopeEnum value for credentials.</param>
        /// <returns> True if credentials matched.</returns>
        public bool Equals(string oauthClientId, string oauthClientSecret, Models.OauthToken oauthToken, List<Models.OauthScopeEnum> oauthScopes)
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
            var token = await oAuthApi.RequestTokenAsync(BuildBasicAuthheader(),
                scope: this.OauthScopes.GetValues(),
                fieldParameters: additionalParameters);

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

        public void ApplyGlobalConfiguration(GlobalConfiguration globalConfiguration)
        {
            oAuthApi = new OauthAuthorizationController(globalConfiguration);
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
        private string BuildBasicAuthheader()
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(this.OauthClientId + ':' + this.OauthClientSecret);
            return "Basic " + Convert.ToBase64String(plainTextBytes);
        }
    }
}