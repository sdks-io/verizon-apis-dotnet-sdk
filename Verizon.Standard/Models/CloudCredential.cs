// <copyright file="CloudCredential.cs" company="APIMatic">
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
    /// CloudCredential.
    /// </summary>
    public class CloudCredential
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudCredential"/> class.
        /// </summary>
        public CloudCredential()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudCredential"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="clusterProvisioning">clusterProvisioning.</param>
        /// <param name="dataBackup">dataBackup.</param>
        public CloudCredential(
            string name = null,
            Models.ClusterProvisioning clusterProvisioning = null,
            Models.DataBackup dataBackup = null)
        {
            this.Name = name;
            this.ClusterProvisioning = clusterProvisioning;
            this.DataBackup = dataBackup;
        }

        /// <summary>
        /// Name of the credentials.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets ClusterProvisioning.
        /// </summary>
        [JsonProperty("clusterProvisioning", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ClusterProvisioning ClusterProvisioning { get; set; }

        /// <summary>
        /// Gets or sets DataBackup.
        /// </summary>
        [JsonProperty("dataBackup", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DataBackup DataBackup { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CloudCredential : ({string.Join(", ", toStringOutput)})";
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
            return obj is CloudCredential other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.ClusterProvisioning == null && other.ClusterProvisioning == null) || (this.ClusterProvisioning?.Equals(other.ClusterProvisioning) == true)) &&
                ((this.DataBackup == null && other.DataBackup == null) || (this.DataBackup?.Equals(other.DataBackup) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.ClusterProvisioning = {(this.ClusterProvisioning == null ? "null" : this.ClusterProvisioning.ToString())}");
            toStringOutput.Add($"this.DataBackup = {(this.DataBackup == null ? "null" : this.DataBackup.ToString())}");
        }
    }
}