// <copyright file="ServiceLaunchHelmGitTag.cs" company="APIMatic">
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
    /// ServiceLaunchHelmGitTag.
    /// </summary>
    public class ServiceLaunchHelmGitTag
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceLaunchHelmGitTag"/> class.
        /// </summary>
        public ServiceLaunchHelmGitTag()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceLaunchHelmGitTag"/> class.
        /// </summary>
        /// <param name="tagName">tagName.</param>
        /// <param name="helmChartPath">helmChartPath.</param>
        /// <param name="valuesYamlPaths">valuesYamlPaths.</param>
        public ServiceLaunchHelmGitTag(
            string tagName,
            string helmChartPath,
            List<string> valuesYamlPaths)
        {
            this.TagName = tagName;
            this.HelmChartPath = helmChartPath;
            this.ValuesYamlPaths = valuesYamlPaths;
        }

        /// <summary>
        /// Gets or sets TagName.
        /// </summary>
        [JsonProperty("tagName")]
        public string TagName { get; set; }

        /// <summary>
        /// Gets or sets HelmChartPath.
        /// </summary>
        [JsonProperty("helmChartPath")]
        public string HelmChartPath { get; set; }

        /// <summary>
        /// Gets or sets ValuesYamlPaths.
        /// </summary>
        [JsonProperty("valuesYamlPaths")]
        public List<string> ValuesYamlPaths { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServiceLaunchHelmGitTag : ({string.Join(", ", toStringOutput)})";
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
            return obj is ServiceLaunchHelmGitTag other &&                ((this.TagName == null && other.TagName == null) || (this.TagName?.Equals(other.TagName) == true)) &&
                ((this.HelmChartPath == null && other.HelmChartPath == null) || (this.HelmChartPath?.Equals(other.HelmChartPath) == true)) &&
                ((this.ValuesYamlPaths == null && other.ValuesYamlPaths == null) || (this.ValuesYamlPaths?.Equals(other.ValuesYamlPaths) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TagName = {(this.TagName == null ? "null" : this.TagName == string.Empty ? "" : this.TagName)}");
            toStringOutput.Add($"this.HelmChartPath = {(this.HelmChartPath == null ? "null" : this.HelmChartPath == string.Empty ? "" : this.HelmChartPath)}");
            toStringOutput.Add($"this.ValuesYamlPaths = {(this.ValuesYamlPaths == null ? "null" : $"[{string.Join(", ", this.ValuesYamlPaths)} ]")}");
        }
    }
}