// <copyright file="StorageClassMap.cs" company="APIMatic">
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
    /// StorageClassMap.
    /// </summary>
    public class StorageClassMap
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageClassMap"/> class.
        /// </summary>
        public StorageClassMap()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageClassMap"/> class.
        /// </summary>
        /// <param name="glusterFs">GlusterFs.</param>
        /// <param name="hostPath">HostPath.</param>
        public StorageClassMap(
            string glusterFs = null,
            string hostPath = null)
        {
            this.GlusterFs = glusterFs;
            this.HostPath = hostPath;
        }

        /// <summary>
        /// Gets or sets GlusterFs.
        /// </summary>
        [JsonProperty("GlusterFs", NullValueHandling = NullValueHandling.Ignore)]
        public string GlusterFs { get; set; }

        /// <summary>
        /// Gets or sets HostPath.
        /// </summary>
        [JsonProperty("HostPath", NullValueHandling = NullValueHandling.Ignore)]
        public string HostPath { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"StorageClassMap : ({string.Join(", ", toStringOutput)})";
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
            return obj is StorageClassMap other &&                ((this.GlusterFs == null && other.GlusterFs == null) || (this.GlusterFs?.Equals(other.GlusterFs) == true)) &&
                ((this.HostPath == null && other.HostPath == null) || (this.HostPath?.Equals(other.HostPath) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.GlusterFs = {(this.GlusterFs == null ? "null" : this.GlusterFs == string.Empty ? "" : this.GlusterFs)}");
            toStringOutput.Add($"this.HostPath = {(this.HostPath == null ? "null" : this.HostPath == string.Empty ? "" : this.HostPath)}");
        }
    }
}