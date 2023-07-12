// <copyright file="IClientCredentialsAuthCredentials.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Verizon.Standard.Authentication
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public interface IClientCredentialsAuth
    {
        /// <summary>
        /// Gets string value for oauthClientId.
        /// </summary>
        string OauthClientId { get; }

        /// <summary>
        /// Gets string value for oauthClientSecret.
        /// </summary>
        string OauthClientSecret { get; }

        /// <summary>
        /// Gets Models.OauthToken value for oauthToken.
        /// </summary>
        Models.OauthToken OauthToken { get; }

        /// <summary>
        /// Gets List of Models.OauthScopeEnum value for oauthScopes.
        /// </summary>
        List<Models.OauthScopeEnum> OauthScopes { get; }

        /// <summary>
        ///  Returns true if credentials matched.
        /// </summary>
        /// <param name="oauthClientId"> The string value for credentials.</param>
        /// <param name="oauthClientSecret"> The string value for credentials.</param>
        /// <param name="oauthToken"> The Models.OauthToken value for credentials.</param>
        /// <param name="oauthScopes"> The List of Models.OauthScopeEnum value for credentials.</param>
        /// <returns>True if credentials matched.</returns>
        bool Equals(string oauthClientId, string oauthClientSecret, Models.OauthToken oauthToken, List<Models.OauthScopeEnum> oauthScopes);

        /// <summary>
        /// Fetch the OAuth token asynchronously.
        /// </summary>
        /// <param name="additionalParameters">Dictionary of additional parameters.</param>
        /// <returns>OAuthToken.</returns>
        Task<Models.OauthToken> FetchTokenAsync(Dictionary<string, object> additionalParameters = null);

        /// <summary>
        /// Fetch the OAuth token.
        /// </summary>
        /// <param name="additionalParameters">Dictionary of additional parameters.</param>
        /// <returns>OAuthToken.</returns>
        Models.OauthToken FetchToken(Dictionary<string, object> additionalParameters = null);

        /// <summary>
        /// Checks if token is expired.
        /// </summary>
        /// <returns> Returns true if token is expired.</returns>
        bool IsTokenExpired();
    }
}