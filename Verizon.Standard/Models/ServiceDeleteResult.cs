// <copyright file="ServiceDeleteResult.cs" company="APIMatic">
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
    /// ServiceDeleteResult.
    /// </summary>
    public class ServiceDeleteResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceDeleteResult"/> class.
        /// </summary>
        public ServiceDeleteResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceDeleteResult"/> class.
        /// </summary>
        /// <param name="selectedService">selectedService.</param>
        /// <param name="dependentService">dependentService.</param>
        /// <param name="runningInstances">runningInstances.</param>
        /// <param name="errorDetails">errorDetails.</param>
        public ServiceDeleteResult(
            Models.SelectedService selectedService = null,
            List<Models.DependentService> dependentService = null,
            List<Models.RunningInstance> runningInstances = null,
            Models.EdgeServiceOnboardingResult errorDetails = null)
        {
            this.SelectedService = selectedService;
            this.DependentService = dependentService;
            this.RunningInstances = runningInstances;
            this.ErrorDetails = errorDetails;
        }

        /// <summary>
        /// Service which is selected.
        /// </summary>
        [JsonProperty("selectedService", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SelectedService SelectedService { get; set; }

        /// <summary>
        /// List of dependent services.
        /// </summary>
        [JsonProperty("dependentService", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DependentService> DependentService { get; set; }

        /// <summary>
        /// List of running Instance.
        /// </summary>
        [JsonProperty("runningInstances", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.RunningInstance> RunningInstances { get; set; }

        /// <summary>
        /// Error response attribute of a service.
        /// </summary>
        [JsonProperty("errorDetails", NullValueHandling = NullValueHandling.Ignore)]
        public Models.EdgeServiceOnboardingResult ErrorDetails { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServiceDeleteResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is ServiceDeleteResult other &&                ((this.SelectedService == null && other.SelectedService == null) || (this.SelectedService?.Equals(other.SelectedService) == true)) &&
                ((this.DependentService == null && other.DependentService == null) || (this.DependentService?.Equals(other.DependentService) == true)) &&
                ((this.RunningInstances == null && other.RunningInstances == null) || (this.RunningInstances?.Equals(other.RunningInstances) == true)) &&
                ((this.ErrorDetails == null && other.ErrorDetails == null) || (this.ErrorDetails?.Equals(other.ErrorDetails) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SelectedService = {(this.SelectedService == null ? "null" : this.SelectedService.ToString())}");
            toStringOutput.Add($"this.DependentService = {(this.DependentService == null ? "null" : $"[{string.Join(", ", this.DependentService)} ]")}");
            toStringOutput.Add($"this.RunningInstances = {(this.RunningInstances == null ? "null" : $"[{string.Join(", ", this.RunningInstances)} ]")}");
            toStringOutput.Add($"this.ErrorDetails = {(this.ErrorDetails == null ? "null" : this.ErrorDetails.ToString())}");
        }
    }
}