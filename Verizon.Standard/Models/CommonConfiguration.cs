// <copyright file="CommonConfiguration.cs" company="APIMatic">
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
    /// CommonConfiguration.
    /// </summary>
    public class CommonConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonConfiguration"/> class.
        /// </summary>
        public CommonConfiguration()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommonConfiguration"/> class.
        /// </summary>
        /// <param name="cloudCredentials">cloudCredentials.</param>
        /// <param name="k8sVersion">k8sVersion.</param>
        /// <param name="blueprint">blueprint.</param>
        public CommonConfiguration(
            Models.CloudCredential cloudCredentials = null,
            Models.K8sVersionEnum? k8sVersion = Models.K8sVersionEnum.Enum118,
            Models.Blueprint blueprint = null)
        {
            this.CloudCredentials = cloudCredentials;
            this.K8sVersion = k8sVersion;
            this.Blueprint = blueprint;
        }

        /// <summary>
        /// Gets or sets CloudCredentials.
        /// </summary>
        [JsonProperty("cloudCredentials", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CloudCredential CloudCredentials { get; set; }

        /// <summary>
        /// Version of K8s platform.
        /// </summary>
        [JsonProperty("k8sVersion", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.K8sVersionEnum? K8sVersion { get; set; }

        /// <summary>
        /// Gets or sets Blueprint.
        /// </summary>
        [JsonProperty("blueprint", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Blueprint Blueprint { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CommonConfiguration : ({string.Join(", ", toStringOutput)})";
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
            return obj is CommonConfiguration other &&                ((this.CloudCredentials == null && other.CloudCredentials == null) || (this.CloudCredentials?.Equals(other.CloudCredentials) == true)) &&
                ((this.K8sVersion == null && other.K8sVersion == null) || (this.K8sVersion?.Equals(other.K8sVersion) == true)) &&
                ((this.Blueprint == null && other.Blueprint == null) || (this.Blueprint?.Equals(other.Blueprint) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CloudCredentials = {(this.CloudCredentials == null ? "null" : this.CloudCredentials.ToString())}");
            toStringOutput.Add($"this.K8sVersion = {(this.K8sVersion == null ? "null" : this.K8sVersion.ToString())}");
            toStringOutput.Add($"this.Blueprint = {(this.Blueprint == null ? "null" : this.Blueprint.ToString())}");
        }
    }
}