// <copyright file="ServiceLaunchTerraformGitBranch.cs" company="APIMatic">
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
    /// ServiceLaunchTerraformGitBranch.
    /// </summary>
    public class ServiceLaunchTerraformGitBranch
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceLaunchTerraformGitBranch"/> class.
        /// </summary>
        public ServiceLaunchTerraformGitBranch()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceLaunchTerraformGitBranch"/> class.
        /// </summary>
        /// <param name="branchName">branchName.</param>
        /// <param name="terraformPath">terraformPath.</param>
        public ServiceLaunchTerraformGitBranch(
            string branchName = null,
            string terraformPath = null)
        {
            this.BranchName = branchName;
            this.TerraformPath = terraformPath;
        }

        /// <summary>
        /// Gets or sets BranchName.
        /// </summary>
        [JsonProperty("branchName", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchName { get; set; }

        /// <summary>
        /// Gets or sets TerraformPath.
        /// </summary>
        [JsonProperty("terraformPath", NullValueHandling = NullValueHandling.Ignore)]
        public string TerraformPath { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServiceLaunchTerraformGitBranch : ({string.Join(", ", toStringOutput)})";
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
            return obj is ServiceLaunchTerraformGitBranch other &&                ((this.BranchName == null && other.BranchName == null) || (this.BranchName?.Equals(other.BranchName) == true)) &&
                ((this.TerraformPath == null && other.TerraformPath == null) || (this.TerraformPath?.Equals(other.TerraformPath) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BranchName = {(this.BranchName == null ? "null" : this.BranchName == string.Empty ? "" : this.BranchName)}");
            toStringOutput.Add($"this.TerraformPath = {(this.TerraformPath == null ? "null" : this.TerraformPath == string.Empty ? "" : this.TerraformPath)}");
        }
    }
}