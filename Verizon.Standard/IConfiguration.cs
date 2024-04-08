// <copyright file="IConfiguration.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Verizon.Standard
{
    using System;
    using System.Net;
    using Verizon.Standard.Authentication;
    using Verizon.Standard.Models;

    /// <summary>
    /// IConfiguration.
    /// </summary>
    public interface IConfiguration
    {
        /// <summary>
        /// Gets M2M Session Token ([How to generate an M2M session token?](page:getting-started/5g-edge-developer-creds-token#obtaining-a-vz-m2m-session-token-programmatically))
        /// </summary>
        string VZM2mToken { get; }

        /// <summary>
        /// Gets Current API environment.
        /// </summary>
        Environment Environment { get; }

        /// <summary>
        /// Gets the credentials to use with ClientCredentialsAuth.
        /// </summary>
        IClientCredentialsAuth ClientCredentialsAuth { get; }

        /// <summary>
        /// Gets the credentials model to use with ClientCredentialsAuth.
        /// </summary>
        ClientCredentialsAuthModel ClientCredentialsAuthModel { get; }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:EDGE DISCOVERY.</param>
        /// <returns>Returns the baseurl.</returns>
        string GetBaseUri(Server alias = Server.EdgeDiscovery);
    }
}