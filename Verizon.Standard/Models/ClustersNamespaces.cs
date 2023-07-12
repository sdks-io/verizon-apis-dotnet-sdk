// <copyright file="ClustersNamespaces.cs" company="APIMatic">
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
    /// ClustersNamespaces.
    /// </summary>
    public class ClustersNamespaces
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClustersNamespaces"/> class.
        /// </summary>
        public ClustersNamespaces()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClustersNamespaces"/> class.
        /// </summary>
        /// <param name="location">location.</param>
        /// <param name="cluster">cluster.</param>
        public ClustersNamespaces(
            Models.ClusterNamespacesLocation location = null,
            List<Models.ERNCluster> cluster = null)
        {
            this.Location = location;
            this.Cluster = cluster;
        }

        /// <summary>
        /// Gets or sets Location.
        /// </summary>
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ClusterNamespacesLocation Location { get; set; }

        /// <summary>
        /// Gets or sets Cluster.
        /// </summary>
        [JsonProperty("cluster", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ERNCluster> Cluster { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ClustersNamespaces : ({string.Join(", ", toStringOutput)})";
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
            return obj is ClustersNamespaces other &&                ((this.Location == null && other.Location == null) || (this.Location?.Equals(other.Location) == true)) &&
                ((this.Cluster == null && other.Cluster == null) || (this.Cluster?.Equals(other.Cluster) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Location = {(this.Location == null ? "null" : this.Location.ToString())}");
            toStringOutput.Add($"this.Cluster = {(this.Cluster == null ? "null" : $"[{string.Join(", ", this.Cluster)} ]")}");
        }
    }
}