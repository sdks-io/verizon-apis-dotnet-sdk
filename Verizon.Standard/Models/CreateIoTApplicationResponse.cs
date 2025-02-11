// <copyright file="CreateIoTApplicationResponse.cs" company="APIMatic">
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
    /// CreateIoTApplicationResponse.
    /// </summary>
    public class CreateIoTApplicationResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIoTApplicationResponse"/> class.
        /// </summary>
        public CreateIoTApplicationResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIoTApplicationResponse"/> class.
        /// </summary>
        /// <param name="appName">appName.</param>
        /// <param name="sharedSecret">sharedSecret.</param>
        /// <param name="url">url.</param>
        public CreateIoTApplicationResponse(
            string appName = null,
            string sharedSecret = null,
            string url = null)
        {
            this.AppName = appName;
            this.SharedSecret = sharedSecret;
            this.Url = url;
        }

        /// <summary>
        /// An application will be created under the user's Azure subscription with this name and of type IOT central.
        /// </summary>
        [JsonProperty("appName", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// Part of the user credentials (from Azure) the user needs to use for calling further TS Core APIs for setting up Azure cloud connector.
        /// </summary>
        [JsonProperty("sharedSecret", NullValueHandling = NullValueHandling.Ignore)]
        public string SharedSecret { get; set; }

        /// <summary>
        /// An IOT central endpoint the user can use to see the data that is being streamed.
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateIoTApplicationResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateIoTApplicationResponse other &&
                (this.AppName == null && other.AppName == null ||
                 this.AppName?.Equals(other.AppName) == true) &&
                (this.SharedSecret == null && other.SharedSecret == null ||
                 this.SharedSecret?.Equals(other.SharedSecret) == true) &&
                (this.Url == null && other.Url == null ||
                 this.Url?.Equals(other.Url) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AppName = {this.AppName ?? "null"}");
            toStringOutput.Add($"SharedSecret = {this.SharedSecret ?? "null"}");
            toStringOutput.Add($"Url = {this.Url ?? "null"}");
        }
    }
}