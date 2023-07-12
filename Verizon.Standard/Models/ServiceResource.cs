// <copyright file="ServiceResource.cs" company="APIMatic">
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
    /// ServiceResource.
    /// </summary>
    public class ServiceResource
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceResource"/> class.
        /// </summary>
        public ServiceResource()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceResource"/> class.
        /// </summary>
        /// <param name="computeResources">computeResources.</param>
        /// <param name="gpuRequired">gpuRequired.</param>
        /// <param name="gpu">gpu.</param>
        /// <param name="storage">storage.</param>
        /// <param name="memory">memory.</param>
        /// <param name="latency">latency.</param>
        /// <param name="requestRate">requestRate.</param>
        /// <param name="bandwidth">bandwidth.</param>
        public ServiceResource(
            Models.ResourceBase computeResources = null,
            bool? gpuRequired = false,
            Models.ResourceBase gpu = null,
            Models.ResourceBase storage = null,
            Models.ResourceBase memory = null,
            Models.ResourceBase latency = null,
            Models.ResourceBase requestRate = null,
            Models.ResourceBase bandwidth = null)
        {
            this.ComputeResources = computeResources;
            this.GpuRequired = gpuRequired;
            this.Gpu = gpu;
            this.Storage = storage;
            this.Memory = memory;
            this.Latency = latency;
            this.RequestRate = requestRate;
            this.Bandwidth = bandwidth;
        }

        /// <summary>
        /// Resource Base of the service.
        /// </summary>
        [JsonProperty("computeResources", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ResourceBase ComputeResources { get; set; }

        /// <summary>
        /// GPU required or not for onboarding service.
        /// </summary>
        [JsonProperty("gpuRequired", NullValueHandling = NullValueHandling.Ignore)]
        public bool? GpuRequired { get; set; }

        /// <summary>
        /// Resource Base of the service.
        /// </summary>
        [JsonProperty("gpu", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ResourceBase Gpu { get; set; }

        /// <summary>
        /// Resource Base of the service.
        /// </summary>
        [JsonProperty("storage", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ResourceBase Storage { get; set; }

        /// <summary>
        /// Resource Base of the service.
        /// </summary>
        [JsonProperty("memory", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ResourceBase Memory { get; set; }

        /// <summary>
        /// Resource Base of the service.
        /// </summary>
        [JsonProperty("latency", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ResourceBase Latency { get; set; }

        /// <summary>
        /// Resource Base of the service.
        /// </summary>
        [JsonProperty("requestRate", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ResourceBase RequestRate { get; set; }

        /// <summary>
        /// Resource Base of the service.
        /// </summary>
        [JsonProperty("bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ResourceBase Bandwidth { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServiceResource : ({string.Join(", ", toStringOutput)})";
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
            return obj is ServiceResource other &&                ((this.ComputeResources == null && other.ComputeResources == null) || (this.ComputeResources?.Equals(other.ComputeResources) == true)) &&
                ((this.GpuRequired == null && other.GpuRequired == null) || (this.GpuRequired?.Equals(other.GpuRequired) == true)) &&
                ((this.Gpu == null && other.Gpu == null) || (this.Gpu?.Equals(other.Gpu) == true)) &&
                ((this.Storage == null && other.Storage == null) || (this.Storage?.Equals(other.Storage) == true)) &&
                ((this.Memory == null && other.Memory == null) || (this.Memory?.Equals(other.Memory) == true)) &&
                ((this.Latency == null && other.Latency == null) || (this.Latency?.Equals(other.Latency) == true)) &&
                ((this.RequestRate == null && other.RequestRate == null) || (this.RequestRate?.Equals(other.RequestRate) == true)) &&
                ((this.Bandwidth == null && other.Bandwidth == null) || (this.Bandwidth?.Equals(other.Bandwidth) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ComputeResources = {(this.ComputeResources == null ? "null" : this.ComputeResources.ToString())}");
            toStringOutput.Add($"this.GpuRequired = {(this.GpuRequired == null ? "null" : this.GpuRequired.ToString())}");
            toStringOutput.Add($"this.Gpu = {(this.Gpu == null ? "null" : this.Gpu.ToString())}");
            toStringOutput.Add($"this.Storage = {(this.Storage == null ? "null" : this.Storage.ToString())}");
            toStringOutput.Add($"this.Memory = {(this.Memory == null ? "null" : this.Memory.ToString())}");
            toStringOutput.Add($"this.Latency = {(this.Latency == null ? "null" : this.Latency.ToString())}");
            toStringOutput.Add($"this.RequestRate = {(this.RequestRate == null ? "null" : this.RequestRate.ToString())}");
            toStringOutput.Add($"this.Bandwidth = {(this.Bandwidth == null ? "null" : this.Bandwidth.ToString())}");
        }
    }
}