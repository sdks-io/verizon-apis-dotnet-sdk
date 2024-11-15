// <copyright file="SessionResetPasswordResult.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Verizon.Standard;
using Verizon.Standard.Utilities;

namespace Verizon.Standard.Models
{
    /// <summary>
    /// SessionResetPasswordResult.
    /// </summary>
    public class SessionResetPasswordResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionResetPasswordResult"/> class.
        /// </summary>
        public SessionResetPasswordResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionResetPasswordResult"/> class.
        /// </summary>
        /// <param name="newPassword">newPassword.</param>
        public SessionResetPasswordResult(
            string newPassword = null)
        {
            this.NewPassword = newPassword;
        }

        /// <summary>
        /// The new password for the username.
        /// </summary>
        [JsonProperty("newPassword", NullValueHandling = NullValueHandling.Ignore)]
        public string NewPassword { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SessionResetPasswordResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is SessionResetPasswordResult other &&                ((this.NewPassword == null && other.NewPassword == null) || (this.NewPassword?.Equals(other.NewPassword) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.NewPassword = {(this.NewPassword == null ? "null" : this.NewPassword)}");
        }
    }
}