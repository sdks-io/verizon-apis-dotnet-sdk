// <copyright file="ServicesProfileRegistration.cs" company="APIMatic">
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
    /// ServicesProfileRegistration.
    /// </summary>
    public class ServicesProfileRegistration
    {
        private List<Models.LinkedServiceInstance> linkedServiceInstances;
        private List<Models.DeploymentLocation> deploymentLocations;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "linkedServiceInstances", false },
            { "deploymentLocations", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ServicesProfileRegistration"/> class.
        /// </summary>
        public ServicesProfileRegistration()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServicesProfileRegistration"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="serviceName">serviceName.</param>
        /// <param name="serviceVersion">serviceVersion.</param>
        /// <param name="currentVersion">currentVersion.</param>
        /// <param name="version">version.</param>
        /// <param name="state">state.</param>
        /// <param name="customerID">customerID.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="lastUpdatedBy">lastUpdatedBy.</param>
        /// <param name="lastUpdatedAt">lastUpdatedAt.</param>
        /// <param name="linkedServiceInstances">linkedServiceInstances.</param>
        /// <param name="accessIntents">accessIntents.</param>
        /// <param name="placementIntents">placementIntents.</param>
        /// <param name="deploymentLocations">deploymentLocations.</param>
        public ServicesProfileRegistration(
            Guid? id = null,
            string name = null,
            string serviceName = null,
            string serviceVersion = null,
            string currentVersion = null,
            string version = null,
            Models.ServicesProfileRegistrationStateEnum? state = null,
            string customerID = null,
            string createdBy = null,
            string createdAt = null,
            string lastUpdatedBy = null,
            string lastUpdatedAt = null,
            List<Models.LinkedServiceInstance> linkedServiceInstances = null,
            Models.AccessIntents accessIntents = null,
            Models.PlacementIntents placementIntents = null,
            List<Models.DeploymentLocation> deploymentLocations = null)
        {
            this.Id = id;
            this.Name = name;
            this.ServiceName = serviceName;
            this.ServiceVersion = serviceVersion;
            this.CurrentVersion = currentVersion;
            this.Version = version;
            this.State = state;
            this.CustomerID = customerID;
            this.CreatedBy = createdBy;
            this.CreatedAt = createdAt;
            this.LastUpdatedBy = lastUpdatedBy;
            this.LastUpdatedAt = lastUpdatedAt;
            if (linkedServiceInstances != null)
            {
                this.LinkedServiceInstances = linkedServiceInstances;
            }

            this.AccessIntents = accessIntents;
            this.PlacementIntents = placementIntents;
            if (deploymentLocations != null)
            {
                this.DeploymentLocations = deploymentLocations;
            }

        }

        /// <summary>
        /// Id of the service profile.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Id { get; set; }

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
        /// Gets or sets CurrentVersion.
        /// </summary>
        [JsonProperty("currentVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentVersion { get; set; }

        /// <summary>
        /// Gets or sets Version.
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.ServicesProfileRegistrationStateEnum? State { get; set; }

        /// <summary>
        /// Id of particular customer.
        /// </summary>
        [JsonProperty("customerID", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerID { get; set; }

        /// <summary>
        /// Gets or sets CreatedBy.
        /// </summary>
        [JsonProperty("createdBy", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonProperty("createdAt", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets LastUpdatedBy.
        /// </summary>
        [JsonProperty("lastUpdatedBy", NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdatedBy { get; set; }

        /// <summary>
        /// Gets or sets LastUpdatedAt.
        /// </summary>
        [JsonProperty("lastUpdatedAt", NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets LinkedServiceInstances.
        /// </summary>
        [JsonProperty("linkedServiceInstances")]
        public List<Models.LinkedServiceInstance> LinkedServiceInstances
        {
            get
            {
                return this.linkedServiceInstances;
            }

            set
            {
                this.shouldSerialize["linkedServiceInstances"] = true;
                this.linkedServiceInstances = value;
            }
        }

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
        [JsonProperty("deploymentLocations")]
        public List<Models.DeploymentLocation> DeploymentLocations
        {
            get
            {
                return this.deploymentLocations;
            }

            set
            {
                this.shouldSerialize["deploymentLocations"] = true;
                this.deploymentLocations = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServicesProfileRegistration : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLinkedServiceInstances()
        {
            this.shouldSerialize["linkedServiceInstances"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDeploymentLocations()
        {
            this.shouldSerialize["deploymentLocations"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLinkedServiceInstances()
        {
            return this.shouldSerialize["linkedServiceInstances"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDeploymentLocations()
        {
            return this.shouldSerialize["deploymentLocations"];
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
            return obj is ServicesProfileRegistration other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.ServiceName == null && other.ServiceName == null) || (this.ServiceName?.Equals(other.ServiceName) == true)) &&
                ((this.ServiceVersion == null && other.ServiceVersion == null) || (this.ServiceVersion?.Equals(other.ServiceVersion) == true)) &&
                ((this.CurrentVersion == null && other.CurrentVersion == null) || (this.CurrentVersion?.Equals(other.CurrentVersion) == true)) &&
                ((this.Version == null && other.Version == null) || (this.Version?.Equals(other.Version) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.CustomerID == null && other.CustomerID == null) || (this.CustomerID?.Equals(other.CustomerID) == true)) &&
                ((this.CreatedBy == null && other.CreatedBy == null) || (this.CreatedBy?.Equals(other.CreatedBy) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.LastUpdatedBy == null && other.LastUpdatedBy == null) || (this.LastUpdatedBy?.Equals(other.LastUpdatedBy) == true)) &&
                ((this.LastUpdatedAt == null && other.LastUpdatedAt == null) || (this.LastUpdatedAt?.Equals(other.LastUpdatedAt) == true)) &&
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
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.ServiceName = {(this.ServiceName == null ? "null" : this.ServiceName == string.Empty ? "" : this.ServiceName)}");
            toStringOutput.Add($"this.ServiceVersion = {(this.ServiceVersion == null ? "null" : this.ServiceVersion == string.Empty ? "" : this.ServiceVersion)}");
            toStringOutput.Add($"this.CurrentVersion = {(this.CurrentVersion == null ? "null" : this.CurrentVersion == string.Empty ? "" : this.CurrentVersion)}");
            toStringOutput.Add($"this.Version = {(this.Version == null ? "null" : this.Version == string.Empty ? "" : this.Version)}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"this.CustomerID = {(this.CustomerID == null ? "null" : this.CustomerID == string.Empty ? "" : this.CustomerID)}");
            toStringOutput.Add($"this.CreatedBy = {(this.CreatedBy == null ? "null" : this.CreatedBy == string.Empty ? "" : this.CreatedBy)}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt == string.Empty ? "" : this.CreatedAt)}");
            toStringOutput.Add($"this.LastUpdatedBy = {(this.LastUpdatedBy == null ? "null" : this.LastUpdatedBy == string.Empty ? "" : this.LastUpdatedBy)}");
            toStringOutput.Add($"this.LastUpdatedAt = {(this.LastUpdatedAt == null ? "null" : this.LastUpdatedAt == string.Empty ? "" : this.LastUpdatedAt)}");
            toStringOutput.Add($"this.LinkedServiceInstances = {(this.LinkedServiceInstances == null ? "null" : $"[{string.Join(", ", this.LinkedServiceInstances)} ]")}");
            toStringOutput.Add($"this.AccessIntents = {(this.AccessIntents == null ? "null" : this.AccessIntents.ToString())}");
            toStringOutput.Add($"this.PlacementIntents = {(this.PlacementIntents == null ? "null" : this.PlacementIntents.ToString())}");
            toStringOutput.Add($"this.DeploymentLocations = {(this.DeploymentLocations == null ? "null" : $"[{string.Join(", ", this.DeploymentLocations)} ]")}");
        }
    }
}