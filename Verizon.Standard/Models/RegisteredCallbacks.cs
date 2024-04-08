// <copyright file="RegisteredCallbacks.cs" company="APIMatic">
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
    /// RegisteredCallbacks.
    /// </summary>
    public class RegisteredCallbacks
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisteredCallbacks"/> class.
        /// </summary>
        public RegisteredCallbacks()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisteredCallbacks"/> class.
        /// </summary>
        /// <param name="aname">aname.</param>
        /// <param name="name">name.</param>
        /// <param name="url">url.</param>
        /// <param name="username">username.</param>
        /// <param name="password">password.</param>
        public RegisteredCallbacks(
            string aname = null,
            string name = null,
            string url = null,
            string username = null,
            string password = null)
        {
            this.Aname = aname;
            this.Name = name;
            this.Url = url;
            this.Username = username;
            this.Password = password;
        }

        /// <summary>
        /// The name of the billing account for which callback messages will be sent.
        /// </summary>
        [JsonProperty("aname", NullValueHandling = NullValueHandling.Ignore)]
        public string Aname { get; set; }

        /// <summary>
        /// The name of the callback service, which identifies the type and format of messages that will be sent to the registered URL. This will be 'Fota' for the Software Management Services callback.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// The address to which callback messages will be sent.
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// The user name that ThingSpace will return in the callback messages.
        /// </summary>
        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        /// <summary>
        /// The password that ThingSpace will return in the callback messages.
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RegisteredCallbacks : ({string.Join(", ", toStringOutput)})";
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
            return obj is RegisteredCallbacks other &&                ((this.Aname == null && other.Aname == null) || (this.Aname?.Equals(other.Aname) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
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
            toStringOutput.Add($"this.Aname = {(this.Aname == null ? "null" : this.Aname)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url)}");
            toStringOutput.Add($"this.Username = {(this.Username == null ? "null" : this.Username)}");
            toStringOutput.Add($"this.Password = {(this.Password == null ? "null" : this.Password)}");
        }
    }
}