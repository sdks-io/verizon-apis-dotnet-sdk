// <copyright file="ResourcesEdgeHostedService.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Verizon.Standard;
using Verizon.Standard.Utilities;

namespace Verizon.Standard.Models
{
    /// <summary>
    /// ResourcesEdgeHostedService.
    /// </summary>
    public class ResourcesEdgeHostedService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourcesEdgeHostedService"/> class.
        /// </summary>
        public ResourcesEdgeHostedService()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourcesEdgeHostedService"/> class.
        /// </summary>
        /// <param name="ern">ern.</param>
        /// <param name="serviceEndpoint">serviceEndpoint.</param>
        /// <param name="applicationServerProviderId">applicationServerProviderId.</param>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="serviceDescription">serviceDescription.</param>
        public ResourcesEdgeHostedService(
            string ern = null,
            Models.ResourcesServiceEndpoint serviceEndpoint = null,
            string applicationServerProviderId = null,
            string applicationId = null,
            string serviceDescription = null)
        {
            this.Ern = ern;
            this.ServiceEndpoint = serviceEndpoint;
            this.ApplicationServerProviderId = applicationServerProviderId;
            this.ApplicationId = applicationId;
            this.ServiceDescription = serviceDescription;
        }

        /// <summary>
        /// Edge Resource Name. A string identifier for a set of edge resources.
        /// </summary>
        [JsonProperty("ern", NullValueHandling = NullValueHandling.Ignore)]
        public string Ern { get; set; }

        /// <summary>
        /// Service Endpoint path, address, and port.
        /// </summary>
        [JsonProperty("serviceEndpoint", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ResourcesServiceEndpoint ServiceEndpoint { get; set; }

        /// <summary>
        /// Unique ID representing the Edge Application Provider.
        /// </summary>
        [JsonProperty("applicationServerProviderId", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplicationServerProviderId { get; set; }

        /// <summary>
        /// Unique ID representing the Edge Application.
        /// </summary>
        [JsonProperty("applicationId", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets or sets ServiceDescription.
        /// </summary>
        [JsonProperty("serviceDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceDescription { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ResourcesEdgeHostedService : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ResourcesEdgeHostedService other &&
                (this.Ern == null && other.Ern == null ||
                 this.Ern?.Equals(other.Ern) == true) &&
                (this.ServiceEndpoint == null && other.ServiceEndpoint == null ||
                 this.ServiceEndpoint?.Equals(other.ServiceEndpoint) == true) &&
                (this.ApplicationServerProviderId == null && other.ApplicationServerProviderId == null ||
                 this.ApplicationServerProviderId?.Equals(other.ApplicationServerProviderId) == true) &&
                (this.ApplicationId == null && other.ApplicationId == null ||
                 this.ApplicationId?.Equals(other.ApplicationId) == true) &&
                (this.ServiceDescription == null && other.ServiceDescription == null ||
                 this.ServiceDescription?.Equals(other.ServiceDescription) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Ern = {this.Ern ?? "null"}");
            toStringOutput.Add($"ServiceEndpoint = {(this.ServiceEndpoint == null ? "null" : this.ServiceEndpoint.ToString())}");
            toStringOutput.Add($"ApplicationServerProviderId = {this.ApplicationServerProviderId ?? "null"}");
            toStringOutput.Add($"ApplicationId = {this.ApplicationId ?? "null"}");
            toStringOutput.Add($"ServiceDescription = {this.ServiceDescription ?? "null"}");
        }
    }
}