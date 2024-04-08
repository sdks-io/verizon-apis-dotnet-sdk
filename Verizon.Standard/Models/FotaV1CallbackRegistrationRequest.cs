// <copyright file="FotaV1CallbackRegistrationRequest.cs" company="APIMatic">
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
    using APIMatic.Core.Utilities.Converters;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Verizon.Standard;
    using Verizon.Standard.Utilities;

    /// <summary>
    /// FotaV1CallbackRegistrationRequest.
    /// </summary>
    public class FotaV1CallbackRegistrationRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FotaV1CallbackRegistrationRequest"/> class.
        /// </summary>
        public FotaV1CallbackRegistrationRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FotaV1CallbackRegistrationRequest"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="url">url.</param>
        /// <param name="username">username.</param>
        /// <param name="password">password.</param>
        public FotaV1CallbackRegistrationRequest(
            string name,
            string url,
            string username = null,
            string password = null)
        {
            this.Name = name;
            this.Url = url;
            this.Username = username;
            this.Password = password;
        }

        /// <summary>
        /// The name of the callback service that you want to subscribe to, which must be 'Fota' for Software Management Services callbacks.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The address on your server where you have enabled a listening service for Software Management Services callback messages.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// The user name that ThingSpace should return in the callback messages.
        /// </summary>
        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        /// <summary>
        /// The password that ThingSpace should return in the callback messages.
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"FotaV1CallbackRegistrationRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is FotaV1CallbackRegistrationRequest other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true)) &&
                ((this.Username == null && other.Username == null) || (this.Username?.Equals(other.Username) == true)) &&
                ((this.Password == null && other.Password == null) || (this.Password?.Equals(other.Password) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url)}");
            toStringOutput.Add($"this.Username = {(this.Username == null ? "null" : this.Username)}");
            toStringOutput.Add($"this.Password = {(this.Password == null ? "null" : this.Password)}");
        }
    }
}