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
        /// Gets Current API environment.
        /// </summary>
        Environment Environment { get; }

        /// <summary>
        /// Gets the credentials to use with ThingspaceOauth.
        /// </summary>
        IThingspaceOauthCredentials ThingspaceOauthCredentials { get; }

        /// <summary>
        /// Gets the credentials model to use with ThingspaceOauth.
        /// </summary>
        ThingspaceOauthModel ThingspaceOauthModel { get; }

        /// <summary>
        /// Gets the credentials to use with VZM2MToken.
        /// </summary>
        IVZM2mTokenCredentials VZM2mTokenCredentials { get; }

        /// <summary>
        /// Gets the credentials model to use with VZM2MToken.
        /// </summary>
        VZM2mTokenModel VZM2mTokenModel { get; }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:EDGE DISCOVERY.</param>
        /// <returns>Returns the baseurl.</returns>
        string GetBaseUri(Server alias = Server.EdgeDiscovery);
    }
}