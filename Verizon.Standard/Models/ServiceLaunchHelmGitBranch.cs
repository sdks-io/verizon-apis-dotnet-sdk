// <copyright file="ServiceLaunchHelmGitBranch.cs" company="APIMatic">
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
    /// ServiceLaunchHelmGitBranch.
    /// </summary>
    public class ServiceLaunchHelmGitBranch
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceLaunchHelmGitBranch"/> class.
        /// </summary>
        public ServiceLaunchHelmGitBranch()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceLaunchHelmGitBranch"/> class.
        /// </summary>
        /// <param name="branchName">branchName.</param>
        /// <param name="helmChartPath">helmChartPath.</param>
        /// <param name="valuesYamlPaths">valuesYamlPaths.</param>
        public ServiceLaunchHelmGitBranch(
            string branchName = null,
            string helmChartPath = null,
            List<string> valuesYamlPaths = null)
        {
            this.BranchName = branchName;
            this.HelmChartPath = helmChartPath;
            this.ValuesYamlPaths = valuesYamlPaths;
        }

        /// <summary>
        /// Gets or sets BranchName.
        /// </summary>
        [JsonProperty("branchName", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchName { get; set; }

        /// <summary>
        /// Gets or sets HelmChartPath.
        /// </summary>
        [JsonProperty("helmChartPath", NullValueHandling = NullValueHandling.Ignore)]
        public string HelmChartPath { get; set; }

        /// <summary>
        /// Gets or sets ValuesYamlPaths.
        /// </summary>
        [JsonProperty("valuesYamlPaths", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ValuesYamlPaths { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServiceLaunchHelmGitBranch : ({string.Join(", ", toStringOutput)})";
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
            return obj is ServiceLaunchHelmGitBranch other &&                ((this.BranchName == null && other.BranchName == null) || (this.BranchName?.Equals(other.BranchName) == true)) &&
                ((this.HelmChartPath == null && other.HelmChartPath == null) || (this.HelmChartPath?.Equals(other.HelmChartPath) == true)) &&
                ((this.ValuesYamlPaths == null && other.ValuesYamlPaths == null) || (this.ValuesYamlPaths?.Equals(other.ValuesYamlPaths) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BranchName = {(this.BranchName == null ? "null" : this.BranchName == string.Empty ? "" : this.BranchName)}");
            toStringOutput.Add($"this.HelmChartPath = {(this.HelmChartPath == null ? "null" : this.HelmChartPath == string.Empty ? "" : this.HelmChartPath)}");
            toStringOutput.Add($"this.ValuesYamlPaths = {(this.ValuesYamlPaths == null ? "null" : $"[{string.Join(", ", this.ValuesYamlPaths)} ]")}");
        }
    }
}