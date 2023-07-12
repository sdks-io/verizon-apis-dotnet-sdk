// <copyright file="ServiceOnboardingTerraformGitTag.cs" company="APIMatic">
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
    /// ServiceOnboardingTerraformGitTag.
    /// </summary>
    public class ServiceOnboardingTerraformGitTag
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceOnboardingTerraformGitTag"/> class.
        /// </summary>
        public ServiceOnboardingTerraformGitTag()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceOnboardingTerraformGitTag"/> class.
        /// </summary>
        /// <param name="tagName">tagName.</param>
        /// <param name="terraformPath">terraformPath.</param>
        public ServiceOnboardingTerraformGitTag(
            string tagName,
            string terraformPath)
        {
            this.TagName = tagName;
            this.TerraformPath = terraformPath;
        }

        /// <summary>
        /// Gets or sets TagName.
        /// </summary>
        [JsonProperty("tagName")]
        public string TagName { get; set; }

        /// <summary>
        /// Gets or sets TerraformPath.
        /// </summary>
        [JsonProperty("terraformPath")]
        public string TerraformPath { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServiceOnboardingTerraformGitTag : ({string.Join(", ", toStringOutput)})";
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
            return obj is ServiceOnboardingTerraformGitTag other &&                ((this.TagName == null && other.TagName == null) || (this.TagName?.Equals(other.TagName) == true)) &&
                ((this.TerraformPath == null && other.TerraformPath == null) || (this.TerraformPath?.Equals(other.TerraformPath) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TagName = {(this.TagName == null ? "null" : this.TagName == string.Empty ? "" : this.TagName)}");
            toStringOutput.Add($"this.TerraformPath = {(this.TerraformPath == null ? "null" : this.TerraformPath == string.Empty ? "" : this.TerraformPath)}");
        }
    }
}