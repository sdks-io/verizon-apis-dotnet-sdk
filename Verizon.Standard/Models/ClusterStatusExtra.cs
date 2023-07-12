// <copyright file="ClusterStatusExtra.cs" company="APIMatic">
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
    /// ClusterStatusExtra.
    /// </summary>
    public class ClusterStatusExtra
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterStatusExtra"/> class.
        /// </summary>
        public ClusterStatusExtra()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterStatusExtra"/> class.
        /// </summary>
        /// <param name="vaultIntegration">vaultIntegration.</param>
        public ClusterStatusExtra(
            Models.ServiceLaunchClusterAdditionalParams vaultIntegration = null)
        {
            this.VaultIntegration = vaultIntegration;
        }

        /// <summary>
        /// Gets or sets VaultIntegration.
        /// </summary>
        [JsonProperty("vaultIntegration", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ServiceLaunchClusterAdditionalParams VaultIntegration { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ClusterStatusExtra : ({string.Join(", ", toStringOutput)})";
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
            return obj is ClusterStatusExtra other &&                ((this.VaultIntegration == null && other.VaultIntegration == null) || (this.VaultIntegration?.Equals(other.VaultIntegration) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.VaultIntegration = {(this.VaultIntegration == null ? "null" : this.VaultIntegration.ToString())}");
        }
    }
}