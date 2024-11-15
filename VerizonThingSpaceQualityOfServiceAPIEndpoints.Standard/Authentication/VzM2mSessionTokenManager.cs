// <copyright file="VzM2mSessionTokenManager.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VerizonThingSpaceQualityOfServiceAPIEndpoints.Standard.Http.Request;
using APIMatic.Core.Authentication;

namespace VerizonThingSpaceQualityOfServiceAPIEndpoints.Standard.Authentication
{
    /// <summary>
    /// VzM2mSessionTokenManager Class.
    /// </summary>
    internal class VzM2mSessionTokenManager : AuthManager, IVzM2mSessionTokenCredentials
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VzM2mSessionTokenManager"/> class.
        /// </summary>
        /// <param name="vzM2mSessionToken">VzM2mSessionToken.</param>
        public VzM2mSessionTokenManager(VzM2mSessionTokenModel vzM2mSessionTokenModel)
        {
            VZM2MToken = vzM2mSessionTokenModel?.VZM2MToken;
            Parameters(paramBuilder => paramBuilder
                .Header(header => header.Setup("VZ-M2M-Token", VZM2MToken).Required())
            );
        }

        /// <summary>
        /// Gets string value for vZM2MToken.
        /// </summary>
        public string VZM2MToken { get; }

        /// <summary>
        /// Check if credentials match.
        /// </summary>
        /// <param name="vZM2MToken"> The string value for credentials.</param>
        /// <returns> True if credentials matched.</returns>
        public bool Equals(string vZM2MToken)
        {
            return vZM2MToken.Equals(this.VZM2MToken);
        }
    }

    public sealed class VzM2mSessionTokenModel
    {
        internal VzM2mSessionTokenModel()
        {
        }

        internal string VZM2MToken { get; set; }

        /// <summary>
        /// Creates an object of the VzM2mSessionTokenModel using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            return new Builder(VZM2MToken);
        }

        /// <summary>
        /// Builder class for VzM2mSessionTokenModel.
        /// </summary>
        public class Builder
        {
            private string vZM2MToken;

            public Builder(string vZM2MToken)
            {
                this.vZM2MToken = vZM2MToken ?? throw new ArgumentNullException(nameof(vZM2MToken));
            }

            /// <summary>
            /// Sets VZM2MToken.
            /// </summary>
            /// <param name="vZM2MToken">VZM2MToken.</param>
            /// <returns>Builder.</returns>
            public Builder VZM2MToken(string vZM2MToken)
            {
                this.vZM2MToken = vZM2MToken ?? throw new ArgumentNullException(nameof(vZM2MToken));
                return this;
            }


            /// <summary>
            /// Creates an object of the VzM2mSessionTokenModel using the values provided for the builder.
            /// </summary>
            /// <returns>VzM2mSessionTokenModel.</returns>
            public VzM2mSessionTokenModel Build()
            {
                return new VzM2mSessionTokenModel()
                {
                    VZM2MToken = this.vZM2MToken
                };
            }
        }
    }
    
}