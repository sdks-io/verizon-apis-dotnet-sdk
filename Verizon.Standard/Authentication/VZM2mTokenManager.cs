// <copyright file="VZM2mTokenManager.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Verizon.Standard.Authentication
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Verizon.Standard.Http.Request;
    using APIMatic.Core.Authentication;

    /// <summary>
    /// VZM2mTokenManager Class.
    /// </summary>
    internal class VZM2mTokenManager : AuthManager, IVZM2mTokenCredentials
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VZM2mTokenManager"/> class.
        /// </summary>
        /// <param name="vZM2mToken">VZM2MToken.</param>
        public VZM2mTokenManager(VZM2mTokenModel vZM2mTokenModel)
        {
            VZM2mToken = vZM2mTokenModel?.VZM2mToken;
            Parameters(paramBuilder => paramBuilder
                .Header(header => header.Setup("VZ-M2M-Token", VZM2mToken).Required())
            );
        }

        /// <summary>
        /// Gets string value for vZM2mToken.
        /// </summary>
        public string VZM2mToken { get; }

        /// <summary>
        /// Check if credentials match.
        /// </summary>
        /// <param name="vZM2mToken"> The string value for credentials.</param>
        /// <returns> True if credentials matched.</returns>
        public bool Equals(string vZM2mToken)
        {
            return vZM2mToken.Equals(this.VZM2mToken);
        }
    }

    public sealed class VZM2mTokenModel
    {
        internal VZM2mTokenModel()
        {
        }

        internal string VZM2mToken { get; set; }

        /// <summary>
        /// Creates an object of the VZM2mTokenModel using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            return new Builder(VZM2mToken);
        }

        /// <summary>
        /// Builder class for VZM2mTokenModel.
        /// </summary>
        public class Builder
        {
            private string vZM2mToken;

            public Builder(string vZM2mToken)
            {
                this.vZM2mToken = vZM2mToken ?? throw new ArgumentNullException(nameof(vZM2mToken));
            }

            /// <summary>
            /// Sets VZM2mToken.
            /// </summary>
            /// <param name="vZM2mToken">VZM2mToken.</param>
            /// <returns>Builder.</returns>
            public Builder VZM2mToken(string vZM2mToken)
            {
                this.vZM2mToken = vZM2mToken ?? throw new ArgumentNullException(nameof(vZM2mToken));
                return this;
            }


            /// <summary>
            /// Creates an object of the VZM2mTokenModel using the values provided for the builder.
            /// </summary>
            /// <returns>VZM2mTokenModel.</returns>
            public VZM2mTokenModel Build()
            {
                return new VZM2mTokenModel()
                {
                    VZM2mToken = this.vZM2mToken
                };
            }
        }
    }
    
}