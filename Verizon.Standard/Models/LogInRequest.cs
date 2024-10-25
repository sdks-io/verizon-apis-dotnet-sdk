// <copyright file="LogInRequest.cs" company="APIMatic">
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
    /// LogInRequest.
    /// </summary>
    public class LogInRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogInRequest"/> class.
        /// </summary>
        public LogInRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogInRequest"/> class.
        /// </summary>
        /// <param name="username">username.</param>
        /// <param name="password">password.</param>
        public LogInRequest(
            string username,
            string password)
        {
            this.Username = username;
            this.Password = password;
        }

        /// <summary>
        /// The username for authentication.
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// The password for authentication.
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"LogInRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is LogInRequest other &&                ((this.Username == null && other.Username == null) || (this.Username?.Equals(other.Username) == true)) &&
                ((this.Password == null && other.Password == null) || (this.Password?.Equals(other.Password) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Username = {(this.Username == null ? "null" : this.Username)}");
            toStringOutput.Add($"this.Password = {(this.Password == null ? "null" : this.Password)}");
        }
    }
}