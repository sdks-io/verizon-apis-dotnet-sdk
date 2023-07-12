// <copyright file="CreateServiceProfileRequest.cs" company="APIMatic">
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
    /// CreateServiceProfileRequest.
    /// </summary>
    public class CreateServiceProfileRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateServiceProfileRequest"/> class.
        /// </summary>
        public CreateServiceProfileRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateServiceProfileRequest"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="serviceName">serviceName.</param>
        /// <param name="serviceVersion">serviceVersion.</param>
        /// <param name="customerID">customerID.</param>
        /// <param name="linkedServiceInstances">linkedServiceInstances.</param>
        /// <param name="accessIntents">accessIntents.</param>
        /// <param name="placementIntents">placementIntents.</param>
        /// <param name="deploymentLocations">deploymentLocations.</param>
        public CreateServiceProfileRequest(
            string name = null,
            string serviceName = null,
            string serviceVersion = null,
            string customerID = null,
            List<Models.LinkedServiceInstance> linkedServiceInstances = null,
            Models.AccessIntents accessIntents = null,
            Models.PlacementIntents placementIntents = null,
            List<Models.DeploymentLocation> deploymentLocations = null)
        {
            this.Name = name;
            this.ServiceName = serviceName;
            this.ServiceVersion = serviceVersion;
            this.CustomerID = customerID;
            this.LinkedServiceInstances = linkedServiceInstances;
            this.AccessIntents = accessIntents;
            this.PlacementIntents = placementIntents;
            this.DeploymentLocations = deploymentLocations;
        }

        /// <summary>
        /// Name for a service profile.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Service being deployed.
        /// </summary>
        [JsonProperty("serviceName", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceName { get; set; }

        /// <summary>
        /// Service version being deployed.
        /// </summary>
        [JsonProperty("serviceVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceVersion { get; set; }

        /// <summary>
        /// Id of particular customer.
        /// </summary>
        [JsonProperty("customerID", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerID { get; set; }

        /// <summary>
        /// Gets or sets LinkedServiceInstances.
        /// </summary>
        [JsonProperty("linkedServiceInstances", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.LinkedServiceInstance> LinkedServiceInstances { get; set; }

        /// <summary>
        /// Gets or sets AccessIntents.
        /// </summary>
        [JsonProperty("accessIntents", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AccessIntents AccessIntents { get; set; }

        /// <summary>
        /// Gets or sets PlacementIntents.
        /// </summary>
        [JsonProperty("placementIntents", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PlacementIntents PlacementIntents { get; set; }

        /// <summary>
        /// Gets or sets DeploymentLocations.
        /// </summary>
        [JsonProperty("deploymentLocations", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DeploymentLocation> DeploymentLocations { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateServiceProfileRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreateServiceProfileRequest other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.ServiceName == null && other.ServiceName == null) || (this.ServiceName?.Equals(other.ServiceName) == true)) &&
                ((this.ServiceVersion == null && other.ServiceVersion == null) || (this.ServiceVersion?.Equals(other.ServiceVersion) == true)) &&
                ((this.CustomerID == null && other.CustomerID == null) || (this.CustomerID?.Equals(other.CustomerID) == true)) &&
                ((this.LinkedServiceInstances == null && other.LinkedServiceInstances == null) || (this.LinkedServiceInstances?.Equals(other.LinkedServiceInstances) == true)) &&
                ((this.AccessIntents == null && other.AccessIntents == null) || (this.AccessIntents?.Equals(other.AccessIntents) == true)) &&
                ((this.PlacementIntents == null && other.PlacementIntents == null) || (this.PlacementIntents?.Equals(other.PlacementIntents) == true)) &&
                ((this.DeploymentLocations == null && other.DeploymentLocations == null) || (this.DeploymentLocations?.Equals(other.DeploymentLocations) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.ServiceName = {(this.ServiceName == null ? "null" : this.ServiceName == string.Empty ? "" : this.ServiceName)}");
            toStringOutput.Add($"this.ServiceVersion = {(this.ServiceVersion == null ? "null" : this.ServiceVersion == string.Empty ? "" : this.ServiceVersion)}");
            toStringOutput.Add($"this.CustomerID = {(this.CustomerID == null ? "null" : this.CustomerID == string.Empty ? "" : this.CustomerID)}");
            toStringOutput.Add($"this.LinkedServiceInstances = {(this.LinkedServiceInstances == null ? "null" : $"[{string.Join(", ", this.LinkedServiceInstances)} ]")}");
            toStringOutput.Add($"this.AccessIntents = {(this.AccessIntents == null ? "null" : this.AccessIntents.ToString())}");
            toStringOutput.Add($"this.PlacementIntents = {(this.PlacementIntents == null ? "null" : this.PlacementIntents.ToString())}");
            toStringOutput.Add($"this.DeploymentLocations = {(this.DeploymentLocations == null ? "null" : $"[{string.Join(", ", this.DeploymentLocations)} ]")}");
        }
    }
}