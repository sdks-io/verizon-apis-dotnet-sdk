// <copyright file="ResourcesEdgeHostedServiceWithProfileId.cs" company="APIMatic">
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
    using APIMatic.Core.Utilities.Converters;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Verizon.Standard;
    using Verizon.Standard.Utilities;

    /// <summary>
    /// ResourcesEdgeHostedServiceWithProfileId.
    /// </summary>
    public class ResourcesEdgeHostedServiceWithProfileId
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourcesEdgeHostedServiceWithProfileId"/> class.
        /// </summary>
        public ResourcesEdgeHostedServiceWithProfileId()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourcesEdgeHostedServiceWithProfileId"/> class.
        /// </summary>
        /// <param name="ern">ern.</param>
        /// <param name="serviceEndpoint">serviceEndpoint.</param>
        /// <param name="applicationServerProviderId">applicationServerProviderId.</param>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="serviceDescription">serviceDescription.</param>
        /// <param name="serviceProfileID">serviceProfileID.</param>
        public ResourcesEdgeHostedServiceWithProfileId(
            string ern = null,
            Models.ResourcesServiceEndpoint serviceEndpoint = null,
            string applicationServerProviderId = null,
            string applicationId = null,
            string serviceDescription = null,
            string serviceProfileID = null)
        {
            this.Ern = ern;
            this.ServiceEndpoint = serviceEndpoint;
            this.ApplicationServerProviderId = applicationServerProviderId;
            this.ApplicationId = applicationId;
            this.ServiceDescription = serviceDescription;
            this.ServiceProfileID = serviceProfileID;
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

        /// <summary>
        /// The system assigned ID of the service profile.
        /// </summary>
        [JsonProperty("serviceProfileID", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceProfileID { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ResourcesEdgeHostedServiceWithProfileId : ({string.Join(", ", toStringOutput)})";
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
            return obj is ResourcesEdgeHostedServiceWithProfileId other &&                ((this.Ern == null && other.Ern == null) || (this.Ern?.Equals(other.Ern) == true)) &&
                ((this.ServiceEndpoint == null && other.ServiceEndpoint == null) || (this.ServiceEndpoint?.Equals(other.ServiceEndpoint) == true)) &&
                ((this.ApplicationServerProviderId == null && other.ApplicationServerProviderId == null) || (this.ApplicationServerProviderId?.Equals(other.ApplicationServerProviderId) == true)) &&
                ((this.ApplicationId == null && other.ApplicationId == null) || (this.ApplicationId?.Equals(other.ApplicationId) == true)) &&
                ((this.ServiceDescription == null && other.ServiceDescription == null) || (this.ServiceDescription?.Equals(other.ServiceDescription) == true)) &&
                ((this.ServiceProfileID == null && other.ServiceProfileID == null) || (this.ServiceProfileID?.Equals(other.ServiceProfileID) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Ern = {(this.Ern == null ? "null" : this.Ern)}");
            toStringOutput.Add($"this.ServiceEndpoint = {(this.ServiceEndpoint == null ? "null" : this.ServiceEndpoint.ToString())}");
            toStringOutput.Add($"this.ApplicationServerProviderId = {(this.ApplicationServerProviderId == null ? "null" : this.ApplicationServerProviderId)}");
            toStringOutput.Add($"this.ApplicationId = {(this.ApplicationId == null ? "null" : this.ApplicationId)}");
            toStringOutput.Add($"this.ServiceDescription = {(this.ServiceDescription == null ? "null" : this.ServiceDescription)}");
            toStringOutput.Add($"this.ServiceProfileID = {(this.ServiceProfileID == null ? "null" : this.ServiceProfileID)}");
        }
    }
}