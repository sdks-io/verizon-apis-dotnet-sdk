// <copyright file="ServiceOnboardingHelmHelmrepo.cs" company="APIMatic">
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
    /// ServiceOnboardingHelmHelmrepo.
    /// </summary>
    public class ServiceOnboardingHelmHelmrepo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceOnboardingHelmHelmrepo"/> class.
        /// </summary>
        public ServiceOnboardingHelmHelmrepo()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceOnboardingHelmHelmrepo"/> class.
        /// </summary>
        /// <param name="helmChartName">helmChartName.</param>
        /// <param name="helmChartVersion">helmChartVersion.</param>
        public ServiceOnboardingHelmHelmrepo(
            string helmChartName,
            string helmChartVersion)
        {
            this.HelmChartName = helmChartName;
            this.HelmChartVersion = helmChartVersion;
        }

        /// <summary>
        /// The user can provide the Helm chart name.
        /// </summary>
        [JsonProperty("helmChartName")]
        public string HelmChartName { get; set; }

        /// <summary>
        /// The user can provide the Helm chart version.
        /// </summary>
        [JsonProperty("helmChartVersion")]
        public string HelmChartVersion { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServiceOnboardingHelmHelmrepo : ({string.Join(", ", toStringOutput)})";
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
            return obj is ServiceOnboardingHelmHelmrepo other &&                ((this.HelmChartName == null && other.HelmChartName == null) || (this.HelmChartName?.Equals(other.HelmChartName) == true)) &&
                ((this.HelmChartVersion == null && other.HelmChartVersion == null) || (this.HelmChartVersion?.Equals(other.HelmChartVersion) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.HelmChartName = {(this.HelmChartName == null ? "null" : this.HelmChartName == string.Empty ? "" : this.HelmChartName)}");
            toStringOutput.Add($"this.HelmChartVersion = {(this.HelmChartVersion == null ? "null" : this.HelmChartVersion == string.Empty ? "" : this.HelmChartVersion)}");
        }
    }
}