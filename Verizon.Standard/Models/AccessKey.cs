// <copyright file="AccessKey.cs" company="APIMatic">
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
    /// AccessKey.
    /// </summary>
    public class AccessKey
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessKey"/> class.
        /// </summary>
        public AccessKey()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessKey"/> class.
        /// </summary>
        /// <param name="accessId">accessId.</param>
        /// <param name="secretKey">secretKey.</param>
        /// <param name="sessionToken">sessionToken.</param>
        public AccessKey(
            string accessId = null,
            string secretKey = null,
            string sessionToken = null)
        {
            this.AccessId = accessId;
            this.SecretKey = secretKey;
            this.SessionToken = sessionToken;
        }

        /// <summary>
        /// Access ID of the access key.
        /// </summary>
        [JsonProperty("accessId", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessId { get; set; }

        /// <summary>
        /// Secret key of the access key.
        /// </summary>
        [JsonProperty("secretKey", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretKey { get; set; }

        /// <summary>
        /// Session token of the access key.
        /// </summary>
        [JsonProperty("sessionToken", NullValueHandling = NullValueHandling.Ignore)]
        public string SessionToken { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AccessKey : ({string.Join(", ", toStringOutput)})";
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
            return obj is AccessKey other &&                ((this.AccessId == null && other.AccessId == null) || (this.AccessId?.Equals(other.AccessId) == true)) &&
                ((this.SecretKey == null && other.SecretKey == null) || (this.SecretKey?.Equals(other.SecretKey) == true)) &&
                ((this.SessionToken == null && other.SessionToken == null) || (this.SessionToken?.Equals(other.SessionToken) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccessId = {(this.AccessId == null ? "null" : this.AccessId == string.Empty ? "" : this.AccessId)}");
            toStringOutput.Add($"this.SecretKey = {(this.SecretKey == null ? "null" : this.SecretKey == string.Empty ? "" : this.SecretKey)}");
            toStringOutput.Add($"this.SessionToken = {(this.SessionToken == null ? "null" : this.SessionToken == string.Empty ? "" : this.SessionToken)}");
        }
    }
}