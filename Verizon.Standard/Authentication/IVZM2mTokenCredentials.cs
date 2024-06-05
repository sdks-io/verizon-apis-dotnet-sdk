// <copyright file="IVZM2mTokenCredentials.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Verizon.Standard.Authentication
{
    using System;

    /// <summary>
    /// Authentication configuration interface for VZM2MToken.
    /// </summary>
    public interface IVZM2mTokenCredentials
    {
        /// <summary>
        /// Gets string value for vZM2mToken.
        /// </summary>
        string VZM2mToken { get; }

        /// <summary>
        ///  Returns true if credentials matched.
        /// </summary>
        /// <param name="vZM2mToken"> The string value for credentials.</param>
        /// <returns>True if credentials matched.</returns>
        bool Equals(string vZM2mToken);
    }
}