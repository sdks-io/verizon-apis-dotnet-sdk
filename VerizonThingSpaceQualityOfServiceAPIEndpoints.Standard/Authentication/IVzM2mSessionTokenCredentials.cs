// <copyright file="IVzM2mSessionTokenCredentials.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;

namespace VerizonThingSpaceQualityOfServiceAPIEndpoints.Standard.Authentication
{
    /// <summary>
    /// Authentication configuration interface for VzM2mSessionToken.
    /// </summary>
    public interface IVzM2mSessionTokenCredentials
    {
        /// <summary>
        /// Gets string value for vZM2MToken.
        /// </summary>
        string VZM2MToken { get; }

        /// <summary>
        ///  Returns true if credentials matched.
        /// </summary>
        /// <param name="vZM2MToken"> The string value for credentials.</param>
        /// <returns>True if credentials matched.</returns>
        bool Equals(string vZM2MToken);
    }
}