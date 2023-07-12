// <copyright file="DeploymentLocation.cs" company="APIMatic">
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
    /// DeploymentLocation.
    /// </summary>
    public class DeploymentLocation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentLocation"/> class.
        /// </summary>
        public DeploymentLocation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentLocation"/> class.
        /// </summary>
        /// <param name="ern">ern.</param>
        /// <param name="cluster">cluster.</param>
        /// <param name="mNamespace">namespace.</param>
        public DeploymentLocation(
            string ern = null,
            Models.DeploymentLocationCluster cluster = null,
            Models.DeploymentLocationNamespace mNamespace = null)
        {
            this.Ern = ern;
            this.Cluster = cluster;
            this.MNamespace = mNamespace;
        }

        /// <summary>
        /// Edge Resource Number.
        /// </summary>
        [JsonProperty("ern", NullValueHandling = NullValueHandling.Ignore)]
        public string Ern { get; set; }

        /// <summary>
        /// Gets or sets Cluster.
        /// </summary>
        [JsonProperty("cluster", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DeploymentLocationCluster Cluster { get; set; }

        /// <summary>
        /// Gets or sets MNamespace.
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DeploymentLocationNamespace MNamespace { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeploymentLocation : ({string.Join(", ", toStringOutput)})";
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
            return obj is DeploymentLocation other &&                ((this.Ern == null && other.Ern == null) || (this.Ern?.Equals(other.Ern) == true)) &&
                ((this.Cluster == null && other.Cluster == null) || (this.Cluster?.Equals(other.Cluster) == true)) &&
                ((this.MNamespace == null && other.MNamespace == null) || (this.MNamespace?.Equals(other.MNamespace) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Ern = {(this.Ern == null ? "null" : this.Ern == string.Empty ? "" : this.Ern)}");
            toStringOutput.Add($"this.Cluster = {(this.Cluster == null ? "null" : this.Cluster.ToString())}");
            toStringOutput.Add($"this.MNamespace = {(this.MNamespace == null ? "null" : this.MNamespace.ToString())}");
        }
    }
}