// <copyright file="IConfiguration.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Net;
using VerizonThingSpaceQualityOfServiceAPIEndpoints.Standard.Authentication;
using VerizonThingSpaceQualityOfServiceAPIEndpoints.Standard.Models;

namespace VerizonThingSpaceQualityOfServiceAPIEndpoints.Standard
{
    /// <summary>
    /// IConfiguration.
    /// </summary>
    public interface IConfiguration
    {
        /// <summary>
        /// Gets The VZ-M2M session token from [Getting Started](/content/thingspace-portal/documentation/apis/connectivity-management/get-started.html)
        /// </summary>
        string VZM2MToken2 { get; }

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
        /// Gets the credentials to use with VzM2mSessionToken.
        /// </summary>
        IVzM2mSessionTokenCredentials VzM2mSessionTokenCredentials { get; }

        /// <summary>
        /// Gets the credentials model to use with VzM2mSessionToken.
        /// </summary>
        VzM2mSessionTokenModel VzM2mSessionTokenModel { get; }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:THINGSPACE.</param>
        /// <returns>Returns the baseurl.</returns>
        string GetBaseUri(Server alias = Server.Thingspace);
    }
}