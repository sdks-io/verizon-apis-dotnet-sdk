// <copyright file="ThingspaceOauthManager.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Verizon.Standard.Controllers;
using Verizon.Standard.Http.Response;using Verizon.Standard.Models;
using Verizon.Standard.Utilities;
using Verizon.Standard.Exceptions;
using APIMatic.Core.Authentication;
using APIMatic.Core.Request;
using APIMatic.Core;

namespace Verizon.Standard.Authentication
{
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
            OAuthClockSkew = thingspaceOauth?.OAuthClockSkew;
            OAuthTokenProvider = thingspaceOauth?.OAuthTokenProvider;
            OAuthOnTokenUpdate = thingspaceOauth?.OAuthOnTokenUpdate;
            OAuthTokenAutoRefresh = thingspaceOauth?.OauthToken;
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
        /// Gets TimeSpan? value for oauthClockSkew.
        /// </summary>
        public TimeSpan? OAuthClockSkew { get; }

        /// <summary>
        /// Gets Func of OauthToken value for oauthTokenProvider.
        /// </summary>
        public Func<ThingspaceOauthManager, OauthToken, Task<OauthToken>> OAuthTokenProvider { get; }

        /// <summary>
        /// Gets Action of OauthToken value for oauthOnTokenUpdate.
        /// </summary>
        public Action<OauthToken> OAuthOnTokenUpdate { get; }

        /// <summary>
        /// Gets OauthToken value for oauthTokenAutoRefresh.
        /// </summary>
        private OauthToken OAuthTokenAutoRefresh { get; set; }

        private readonly SemaphoreSlim semaphoreSlim = new SemaphoreSlim(1);


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

        /// <inheritdoc />
        public override async Task Apply(RequestBuilder requestBuilder)
        {
            var token = await FetchOrReturnToken(); 
            Parameters(authParameter => authParameter
                .Header(headerParameter => headerParameter
                    .Setup("Authorization",
                        token?.AccessToken == null ? null : $"Bearer {token.AccessToken}"
                    ).Required()));
            await base.Apply(requestBuilder);
        }

        private async Task<OauthToken> FetchOrReturnToken()
        {
            if (OAuthTokenAutoRefresh != null && !OAuthTokenAutoRefresh.IsTokenExpired(OAuthClockSkew))
                return OAuthTokenAutoRefresh;

            await semaphoreSlim.WaitAsync();
            try
            {
                if (OAuthTokenAutoRefresh != null && !OAuthTokenAutoRefresh.IsTokenExpired(OAuthClockSkew))
                    return OAuthTokenAutoRefresh;
                OAuthTokenAutoRefresh = OAuthTokenProvider != null
                    ? await OAuthTokenProvider(this, OAuthTokenAutoRefresh)
                    : await FetchTokenAsync();
            }
            finally
            {
                semaphoreSlim.Release();
            }

            OAuthOnTokenUpdate?.Invoke(OAuthTokenAutoRefresh);

            if (OAuthTokenAutoRefresh == null)
                throw new ApiException(
                    "Client is not authorized.An OAuth token is needed to make API calls.");

            if (OAuthTokenAutoRefresh.IsTokenExpired(TimeSpan.Zero))
                throw new ApiException("OAuth token is expired. A valid token is needed to make API calls.");

            return OAuthTokenAutoRefresh;
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

        internal TimeSpan? OAuthClockSkew { get; set; }

        internal Func<ThingspaceOauthManager, OauthToken, Task<OauthToken>> OAuthTokenProvider { get; set; }

        internal Action<OauthToken> OAuthOnTokenUpdate { get; set; }

        /// <summary>
        /// Creates an object of the ThingspaceOauthModel using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            return new Builder(OauthClientId, OauthClientSecret)
                .OauthToken(OauthToken)
                .OauthScopes(OauthScopes)
                .OAuthClockSkew(OAuthClockSkew)
                .OAuthTokenProvider(OAuthTokenProvider)
                .OAuthOnTokenUpdate(OAuthOnTokenUpdate);
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
            private TimeSpan? oauthClockSkew;
            private Func<ThingspaceOauthManager, OauthToken, Task<OauthToken>> oauthTokenProvider;
            private Action<OauthToken> oauthOnTokenUpdate;

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
            /// Sets OAuthClockSkew.
            /// </summary>
            /// <param name="oauthClockSkew">oauthClockSkew.</param>
            /// <returns>Builder.</returns>
            public Builder OAuthClockSkew(TimeSpan? oauthClockSkew)
            {
                this.oauthClockSkew = oauthClockSkew;
                return this;
            }


            /// <summary>
            /// Sets OAuthTokenProvider.
            /// </summary>
            /// <param name="oauthTokenProvider">oauthTokenProvider.</param>
            /// <returns>Builder.</returns>
            public Builder OAuthTokenProvider(Func<ThingspaceOauthManager, OauthToken, Task<OauthToken>> oauthTokenProvider)
            {
                this.oauthTokenProvider = oauthTokenProvider;
                return this;
            }


            /// <summary>
            /// Sets OAuthOnTokenUpdate.
            /// </summary>
            /// <param name="oauthOnTokenUpdate">oauthOnTokenUpdate.</param>
            /// <returns>Builder.</returns>
            public Builder OAuthOnTokenUpdate(Action<OauthToken> oauthOnTokenUpdate)
            {
                this.oauthOnTokenUpdate = oauthOnTokenUpdate;
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
                    OauthScopes = this.oauthScopes,
                    OAuthClockSkew = this.oauthClockSkew,
                    OAuthTokenProvider = this.oauthTokenProvider,
                    OAuthOnTokenUpdate = this.oauthOnTokenUpdate
                };
            }
        }
    }
}