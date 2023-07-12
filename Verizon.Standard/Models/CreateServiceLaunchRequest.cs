// <copyright file="CreateServiceLaunchRequest.cs" company="APIMatic">
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
    /// CreateServiceLaunchRequest.
    /// </summary>
    public class CreateServiceLaunchRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateServiceLaunchRequest"/> class.
        /// </summary>
        public CreateServiceLaunchRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateServiceLaunchRequest"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="cspProfileId">cspProfileId.</param>
        /// <param name="serviceProfileId">serviceProfileId.</param>
        /// <param name="serviceName">serviceName.</param>
        /// <param name="serviceVersion">serviceVersion.</param>
        public CreateServiceLaunchRequest(
            string name,
            string cspProfileId,
            string serviceProfileId,
            string serviceName = null,
            string serviceVersion = null)
        {
            this.Name = name;
            this.ServiceName = serviceName;
            this.CspProfileId = cspProfileId;
            this.ServiceProfileId = serviceProfileId;
            this.ServiceVersion = serviceVersion;
        }

        /// <summary>
        /// Name of the received request.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Service being deployed.
        /// </summary>
        [JsonProperty("serviceName", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceName { get; set; }

        /// <summary>
        /// Gets or sets CspProfileId.
        /// </summary>
        [JsonProperty("cspProfileId")]
        public string CspProfileId { get; set; }

        /// <summary>
        /// The service profile ID that is created during the post-service API.
        /// </summary>
        [JsonProperty("serviceProfileId")]
        public string ServiceProfileId { get; set; }

        /// <summary>
        /// Service version being deployed.
        /// </summary>
        [JsonProperty("serviceVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceVersion { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateServiceLaunchRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreateServiceLaunchRequest other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.ServiceName == null && other.ServiceName == null) || (this.ServiceName?.Equals(other.ServiceName) == true)) &&
                ((this.CspProfileId == null && other.CspProfileId == null) || (this.CspProfileId?.Equals(other.CspProfileId) == true)) &&
                ((this.ServiceProfileId == null && other.ServiceProfileId == null) || (this.ServiceProfileId?.Equals(other.ServiceProfileId) == true)) &&
                ((this.ServiceVersion == null && other.ServiceVersion == null) || (this.ServiceVersion?.Equals(other.ServiceVersion) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.ServiceName = {(this.ServiceName == null ? "null" : this.ServiceName == string.Empty ? "" : this.ServiceName)}");
            toStringOutput.Add($"this.CspProfileId = {(this.CspProfileId == null ? "null" : this.CspProfileId == string.Empty ? "" : this.CspProfileId)}");
            toStringOutput.Add($"this.ServiceProfileId = {(this.ServiceProfileId == null ? "null" : this.ServiceProfileId == string.Empty ? "" : this.ServiceProfileId)}");
            toStringOutput.Add($"this.ServiceVersion = {(this.ServiceVersion == null ? "null" : this.ServiceVersion == string.Empty ? "" : this.ServiceVersion)}");
        }
    }
}