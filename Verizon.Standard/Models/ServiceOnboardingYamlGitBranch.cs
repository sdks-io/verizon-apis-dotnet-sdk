// <copyright file="ServiceOnboardingYamlGitBranch.cs" company="APIMatic">
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
    /// ServiceOnboardingYamlGitBranch.
    /// </summary>
    public class ServiceOnboardingYamlGitBranch
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceOnboardingYamlGitBranch"/> class.
        /// </summary>
        public ServiceOnboardingYamlGitBranch()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceOnboardingYamlGitBranch"/> class.
        /// </summary>
        /// <param name="branchName">branchName.</param>
        /// <param name="valuesYamlPaths">valuesYamlPaths.</param>
        public ServiceOnboardingYamlGitBranch(
            string branchName,
            List<string> valuesYamlPaths = null)
        {
            this.BranchName = branchName;
            this.ValuesYamlPaths = valuesYamlPaths;
        }

        /// <summary>
        /// The user can provide branchName for the Helm chart.
        /// </summary>
        [JsonProperty("branchName")]
        public string BranchName { get; set; }

        /// <summary>
        /// The user can provide an array of values. YAML files paths.
        /// </summary>
        [JsonProperty("valuesYamlPaths", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ValuesYamlPaths { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServiceOnboardingYamlGitBranch : ({string.Join(", ", toStringOutput)})";
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
            return obj is ServiceOnboardingYamlGitBranch other &&                ((this.BranchName == null && other.BranchName == null) || (this.BranchName?.Equals(other.BranchName) == true)) &&
                ((this.ValuesYamlPaths == null && other.ValuesYamlPaths == null) || (this.ValuesYamlPaths?.Equals(other.ValuesYamlPaths) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BranchName = {(this.BranchName == null ? "null" : this.BranchName == string.Empty ? "" : this.BranchName)}");
            toStringOutput.Add($"this.ValuesYamlPaths = {(this.ValuesYamlPaths == null ? "null" : $"[{string.Join(", ", this.ValuesYamlPaths)} ]")}");
        }
    }
}