// <copyright file="ClusterInfoDetails.cs" company="APIMatic">
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
    /// ClusterInfoDetails.
    /// </summary>
    public class ClusterInfoDetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterInfoDetails"/> class.
        /// </summary>
        public ClusterInfoDetails()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterInfoDetails"/> class.
        /// </summary>
        /// <param name="clusterName">clusterName.</param>
        /// <param name="mNamespace">namespace.</param>
        public ClusterInfoDetails(
            string clusterName,
            string mNamespace)
        {
            this.ClusterName = clusterName;
            this.MNamespace = mNamespace;
        }

        /// <summary>
        /// Name of the cluster to be used.
        /// </summary>
        [JsonProperty("clusterName")]
        public string ClusterName { get; set; }

        /// <summary>
        /// Namespace name inside cluster.
        /// </summary>
        [JsonProperty("namespace")]
        public string MNamespace { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ClusterInfoDetails : ({string.Join(", ", toStringOutput)})";
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
            return obj is ClusterInfoDetails other &&                ((this.ClusterName == null && other.ClusterName == null) || (this.ClusterName?.Equals(other.ClusterName) == true)) &&
                ((this.MNamespace == null && other.MNamespace == null) || (this.MNamespace?.Equals(other.MNamespace) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ClusterName = {(this.ClusterName == null ? "null" : this.ClusterName == string.Empty ? "" : this.ClusterName)}");
            toStringOutput.Add($"this.MNamespace = {(this.MNamespace == null ? "null" : this.MNamespace == string.Empty ? "" : this.MNamespace)}");
        }
    }
}