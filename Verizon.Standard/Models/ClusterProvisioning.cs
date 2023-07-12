// <copyright file="ClusterProvisioning.cs" company="APIMatic">
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
    /// ClusterProvisioning.
    /// </summary>
    public class ClusterProvisioning
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterProvisioning"/> class.
        /// </summary>
        public ClusterProvisioning()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterProvisioning"/> class.
        /// </summary>
        /// <param name="provider">provider.</param>
        /// <param name="accessKey">accessKey.</param>
        /// <param name="role">role.</param>
        public ClusterProvisioning(
            Models.ClusterProviderEnum? provider = null,
            Models.AccessKey accessKey = null,
            Models.Role role = null)
        {
            this.Provider = provider;
            this.AccessKey = accessKey;
            this.Role = role;
        }

        /// <summary>
        /// Cloud provider.
        /// </summary>
        [JsonProperty("provider", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.ClusterProviderEnum? Provider { get; set; }

        /// <summary>
        /// Gets or sets AccessKey.
        /// </summary>
        [JsonProperty("accessKey", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AccessKey AccessKey { get; set; }

        /// <summary>
        /// Role of the user calling API.
        /// </summary>
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Role Role { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ClusterProvisioning : ({string.Join(", ", toStringOutput)})";
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
            return obj is ClusterProvisioning other &&                ((this.Provider == null && other.Provider == null) || (this.Provider?.Equals(other.Provider) == true)) &&
                ((this.AccessKey == null && other.AccessKey == null) || (this.AccessKey?.Equals(other.AccessKey) == true)) &&
                ((this.Role == null && other.Role == null) || (this.Role?.Equals(other.Role) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Provider = {(this.Provider == null ? "null" : this.Provider.ToString())}");
            toStringOutput.Add($"this.AccessKey = {(this.AccessKey == null ? "null" : this.AccessKey.ToString())}");
            toStringOutput.Add($"this.Role = {(this.Role == null ? "null" : this.Role.ToString())}");
        }
    }
}