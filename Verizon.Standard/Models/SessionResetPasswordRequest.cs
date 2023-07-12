// <copyright file="SessionResetPasswordRequest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Verizon.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Verizon.Standard;
    using Verizon.Standard.Utilities;

    /// <summary>
    /// SessionResetPasswordRequest.
    /// </summary>
    public class SessionResetPasswordRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionResetPasswordRequest"/> class.
        /// </summary>
        public SessionResetPasswordRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionResetPasswordRequest"/> class.
        /// </summary>
        /// <param name="oldPassword">oldPassword.</param>
        public SessionResetPasswordRequest(
            string oldPassword = null)
        {
            this.OldPassword = oldPassword;
        }

        /// <summary>
        /// The current password for the username.
        /// </summary>
        [JsonProperty("oldPassword", NullValueHandling = NullValueHandling.Ignore)]
        public string OldPassword { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SessionResetPasswordRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is SessionResetPasswordRequest other &&                ((this.OldPassword == null && other.OldPassword == null) || (this.OldPassword?.Equals(other.OldPassword) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.OldPassword = {(this.OldPassword == null ? "null" : this.OldPassword == string.Empty ? "" : this.OldPassword)}");
        }
    }
}