// <copyright file="Service.cs" company="APIMatic">
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
    /// Service.
    /// </summary>
    public class Service
    {
        private string description;
        private List<string> categories;
        private List<Models.Boundary> boundaries;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "description", false },
            { "categories", false },
            { "boundaries", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Service"/> class.
        /// </summary>
        public Service()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Service"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="version">version.</param>
        /// <param name="id">id.</param>
        /// <param name="description">description.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="tags">tags.</param>
        /// <param name="categories">categories.</param>
        /// <param name="isFavourite">isFavourite.</param>
        /// <param name="isDeleted">isDeleted.</param>
        /// <param name="compatibility">compatibility.</param>
        /// <param name="resource">resource.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="lastModifiedDate">lastModifiedDate.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="lastModifiedBy">lastModifiedBy.</param>
        /// <param name="error">error.</param>
        /// <param name="errorResponse">errorResponse.</param>
        /// <param name="state">state.</param>
        /// <param name="status">status.</param>
        /// <param name="type">type.</param>
        /// <param name="serviceHandlerId">serviceHandlerId.</param>
        /// <param name="observabilityTemplate">observabilityTemplate.</param>
        /// <param name="serviceSwaggerSpecId">serviceSwaggerSpecId.</param>
        /// <param name="workflows">workflows.</param>
        /// <param name="workloads">workloads.</param>
        /// <param name="dependencies">dependencies.</param>
        /// <param name="boundaries">boundaries.</param>
        public Service(
            string name,
            string version,
            string id = null,
            string description = null,
            List<Models.ServiceOnboardingAdditionalParams> metadata = null,
            List<Models.ServiceTag> tags = null,
            List<string> categories = null,
            bool? isFavourite = null,
            bool? isDeleted = null,
            List<Models.Compatibility> compatibility = null,
            Models.ServiceResource resource = null,
            DateTime? createdDate = null,
            DateTime? lastModifiedDate = null,
            string createdBy = null,
            string lastModifiedBy = null,
            Models.ServiceError error = null,
            Models.EdgeServiceOnboardingResult errorResponse = null,
            Models.ServiceStateEnum? state = null,
            Models.ServiceStatusEnum? status = null,
            Models.ServiceTypeEnum? type = null,
            Models.ServiceHandlerId serviceHandlerId = null,
            Models.ObservabilityTemplate observabilityTemplate = null,
            Models.ServiceSwaggerSpecId serviceSwaggerSpecId = null,
            List<Models.Workflow> workflows = null,
            List<Models.Workload> workloads = null,
            List<Models.ServiceDependency> dependencies = null,
            List<Models.Boundary> boundaries = null)
        {
            this.Id = id;
            this.Name = name;
            if (description != null)
            {
                this.Description = description;
            }

            this.Version = version;
            this.Metadata = metadata;
            this.Tags = tags;
            if (categories != null)
            {
                this.Categories = categories;
            }

            this.IsFavourite = isFavourite;
            this.IsDeleted = isDeleted;
            this.Compatibility = compatibility;
            this.Resource = resource;
            this.CreatedDate = createdDate;
            this.LastModifiedDate = lastModifiedDate;
            this.CreatedBy = createdBy;
            this.LastModifiedBy = lastModifiedBy;
            this.Error = error;
            this.ErrorResponse = errorResponse;
            this.State = state;
            this.Status = status;
            this.Type = type;
            this.ServiceHandlerId = serviceHandlerId;
            this.ObservabilityTemplate = observabilityTemplate;
            this.ServiceSwaggerSpecId = serviceSwaggerSpecId;
            this.Workflows = workflows;
            this.Workloads = workloads;
            this.Dependencies = dependencies;
            if (boundaries != null)
            {
                this.Boundaries = boundaries;
            }

        }

        /// <summary>
        /// System generated unique UUID.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Name of the service needs to be deployed.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Description of the service needs to be deployed.
        /// </summary>
        [JsonProperty("description")]
        public string Description
        {
            get
            {
                return this.description;
            }

            set
            {
                this.shouldSerialize["description"] = true;
                this.description = value;
            }
        }

        /// <summary>
        /// Version of the service needs to be deployed.
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }

        /// <summary>
        /// Properties are metadata attributes.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ServiceOnboardingAdditionalParams> Metadata { get; set; }

        /// <summary>
        /// List of service tags.
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ServiceTag> Tags { get; set; }

        /// <summary>
        /// Can be any name just to define it under a category.
        /// </summary>
        [JsonProperty("categories")]
        public List<string> Categories
        {
            get
            {
                return this.categories;
            }

            set
            {
                this.shouldSerialize["categories"] = true;
                this.categories = value;
            }
        }

        /// <summary>
        /// Boolean value to set/unset the service as favorite.
        /// </summary>
        [JsonProperty("isFavourite", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFavourite { get; set; }

        /// <summary>
        /// Boolean to support soft delete of a version of a service.
        /// </summary>
        [JsonProperty("isDeleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Compatibility would have the attribute CSP which is Cloud service provider e.g. AWS_PUBLIC_CLOUD, AWS_WL, AWS_OUTPOST, AZURE_EDGE, AZURE_PUBLIC_CLOUD.
        /// </summary>
        [JsonProperty("compatibility", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Compatibility> Compatibility { get; set; }

        /// <summary>
        /// Resource of the service.
        /// </summary>
        [JsonProperty("resource", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ServiceResource Resource { get; set; }

        /// <summary>
        /// Auto-derived time of creation. Part of response only.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Last modified time. Part of response only.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("lastModifiedDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// User who created the service. Part of response only.
        /// </summary>
        [JsonProperty("createdBy", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// User who last modified the service. Part of response only.
        /// </summary>
        [JsonProperty("lastModifiedBy", NullValueHandling = NullValueHandling.Ignore)]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// Errors related to service.
        /// </summary>
        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ServiceError Error { get; set; }

        /// <summary>
        /// Error response attribute of a service.
        /// </summary>
        [JsonProperty("errorResponse", NullValueHandling = NullValueHandling.Ignore)]
        public Models.EdgeServiceOnboardingResult ErrorResponse { get; set; }

        /// <summary>
        /// Can have any value as - DRAFT, DESIGN, TESTING, PUBLISH, CERTIFY, READY_TO_USE, DEPRECATE, DELETED.
        /// </summary>
        [JsonProperty("state", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.ServiceStateEnum? State { get; set; }

        /// <summary>
        /// Can have any value as - DRAFT_INPROGRESS, DRAFT_COMPLETE, DESIGN_INPROGRESS, DESIGN_FAILED, DESIGN_COMPLETED, VALIDATION_INPROGRESS,  VALIDATION_FAILED, VALIDATION_COMPLETED, TESTING_INPROGRESS, TESTING_FAILED, TESTING_COMPLETED, READY_TO_USE_INPROGRESS, READY_TO_USE_FAILED, READY_TO_USE_COMPLETED, READY_TO_PRIVATE_USE_INPROGRESS, READY_TO_PRIVATE_USE_FAILED, READY_TO_PRIVATE_USE_COMPLETED,  PUBLISH_INPROGRESS,  PUBLISH_FAILED,  PUBLISH_COMPLETED,  CERTIFY_INPROGRESS,  CERTIFY_FAILED, CERTIFY_COMPLETED, DEPRECATE_INPROGRESS,  DEPRECATE_FAILED, DEPRECATE_COMPLETED, MARKDELETE_INPROGRESS, MARKDELETE_FAILED, MARKDELETE_COMPLETED.
        /// </summary>
        [JsonProperty("status", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.ServiceStatusEnum? Status { get; set; }

        /// <summary>
        /// Service Type e.g. Installation, Operations, Custom.
        /// </summary>
        [JsonProperty("type", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.ServiceTypeEnum? Type { get; set; }

        /// <summary>
        /// Auto-generated Id of serviceHandlerId created.
        /// </summary>
        [JsonProperty("serviceHandlerId", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ServiceHandlerId ServiceHandlerId { get; set; }

        /// <summary>
        /// Attribute of service.
        /// </summary>
        [JsonProperty("observabilityTemplate", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ObservabilityTemplate ObservabilityTemplate { get; set; }

        /// <summary>
        /// Auto-generated Id of service handler Swagger specification file uploaded.
        /// </summary>
        [JsonProperty("serviceSwaggerSpecId", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ServiceSwaggerSpecId ServiceSwaggerSpecId { get; set; }

        /// <summary>
        /// Gets or sets Workflows.
        /// </summary>
        [JsonProperty("workflows", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Workflow> Workflows { get; set; }

        /// <summary>
        /// Gets or sets Workloads.
        /// </summary>
        [JsonProperty("workloads", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Workload> Workloads { get; set; }

        /// <summary>
        /// Dependencies of the service.
        /// </summary>
        [JsonProperty("dependencies", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ServiceDependency> Dependencies { get; set; }

        /// <summary>
        /// Boundaries would have attributes csp, region and zoneId.
        /// </summary>
        [JsonProperty("boundaries")]
        public List<Models.Boundary> Boundaries
        {
            get
            {
                return this.boundaries;
            }

            set
            {
                this.shouldSerialize["boundaries"] = true;
                this.boundaries = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Service : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDescription()
        {
            this.shouldSerialize["description"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCategories()
        {
            this.shouldSerialize["categories"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBoundaries()
        {
            this.shouldSerialize["boundaries"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDescription()
        {
            return this.shouldSerialize["description"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCategories()
        {
            return this.shouldSerialize["categories"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBoundaries()
        {
            return this.shouldSerialize["boundaries"];
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
            return obj is Service other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Version == null && other.Version == null) || (this.Version?.Equals(other.Version) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.Tags == null && other.Tags == null) || (this.Tags?.Equals(other.Tags) == true)) &&
                ((this.Categories == null && other.Categories == null) || (this.Categories?.Equals(other.Categories) == true)) &&
                ((this.IsFavourite == null && other.IsFavourite == null) || (this.IsFavourite?.Equals(other.IsFavourite) == true)) &&
                ((this.IsDeleted == null && other.IsDeleted == null) || (this.IsDeleted?.Equals(other.IsDeleted) == true)) &&
                ((this.Compatibility == null && other.Compatibility == null) || (this.Compatibility?.Equals(other.Compatibility) == true)) &&
                ((this.Resource == null && other.Resource == null) || (this.Resource?.Equals(other.Resource) == true)) &&
                ((this.CreatedDate == null && other.CreatedDate == null) || (this.CreatedDate?.Equals(other.CreatedDate) == true)) &&
                ((this.LastModifiedDate == null && other.LastModifiedDate == null) || (this.LastModifiedDate?.Equals(other.LastModifiedDate) == true)) &&
                ((this.CreatedBy == null && other.CreatedBy == null) || (this.CreatedBy?.Equals(other.CreatedBy) == true)) &&
                ((this.LastModifiedBy == null && other.LastModifiedBy == null) || (this.LastModifiedBy?.Equals(other.LastModifiedBy) == true)) &&
                ((this.Error == null && other.Error == null) || (this.Error?.Equals(other.Error) == true)) &&
                ((this.ErrorResponse == null && other.ErrorResponse == null) || (this.ErrorResponse?.Equals(other.ErrorResponse) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.ServiceHandlerId == null && other.ServiceHandlerId == null) || (this.ServiceHandlerId?.Equals(other.ServiceHandlerId) == true)) &&
                ((this.ObservabilityTemplate == null && other.ObservabilityTemplate == null) || (this.ObservabilityTemplate?.Equals(other.ObservabilityTemplate) == true)) &&
                ((this.ServiceSwaggerSpecId == null && other.ServiceSwaggerSpecId == null) || (this.ServiceSwaggerSpecId?.Equals(other.ServiceSwaggerSpecId) == true)) &&
                ((this.Workflows == null && other.Workflows == null) || (this.Workflows?.Equals(other.Workflows) == true)) &&
                ((this.Workloads == null && other.Workloads == null) || (this.Workloads?.Equals(other.Workloads) == true)) &&
                ((this.Dependencies == null && other.Dependencies == null) || (this.Dependencies?.Equals(other.Dependencies) == true)) &&
                ((this.Boundaries == null && other.Boundaries == null) || (this.Boundaries?.Equals(other.Boundaries) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.Version = {(this.Version == null ? "null" : this.Version == string.Empty ? "" : this.Version)}");
            toStringOutput.Add($"this.Metadata = {(this.Metadata == null ? "null" : $"[{string.Join(", ", this.Metadata)} ]")}");
            toStringOutput.Add($"this.Tags = {(this.Tags == null ? "null" : $"[{string.Join(", ", this.Tags)} ]")}");
            toStringOutput.Add($"this.Categories = {(this.Categories == null ? "null" : $"[{string.Join(", ", this.Categories)} ]")}");
            toStringOutput.Add($"this.IsFavourite = {(this.IsFavourite == null ? "null" : this.IsFavourite.ToString())}");
            toStringOutput.Add($"this.IsDeleted = {(this.IsDeleted == null ? "null" : this.IsDeleted.ToString())}");
            toStringOutput.Add($"this.Compatibility = {(this.Compatibility == null ? "null" : $"[{string.Join(", ", this.Compatibility)} ]")}");
            toStringOutput.Add($"this.Resource = {(this.Resource == null ? "null" : this.Resource.ToString())}");
            toStringOutput.Add($"this.CreatedDate = {(this.CreatedDate == null ? "null" : this.CreatedDate.ToString())}");
            toStringOutput.Add($"this.LastModifiedDate = {(this.LastModifiedDate == null ? "null" : this.LastModifiedDate.ToString())}");
            toStringOutput.Add($"this.CreatedBy = {(this.CreatedBy == null ? "null" : this.CreatedBy == string.Empty ? "" : this.CreatedBy)}");
            toStringOutput.Add($"this.LastModifiedBy = {(this.LastModifiedBy == null ? "null" : this.LastModifiedBy == string.Empty ? "" : this.LastModifiedBy)}");
            toStringOutput.Add($"this.Error = {(this.Error == null ? "null" : this.Error.ToString())}");
            toStringOutput.Add($"this.ErrorResponse = {(this.ErrorResponse == null ? "null" : this.ErrorResponse.ToString())}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"this.ServiceHandlerId = {(this.ServiceHandlerId == null ? "null" : this.ServiceHandlerId.ToString())}");
            toStringOutput.Add($"this.ObservabilityTemplate = {(this.ObservabilityTemplate == null ? "null" : this.ObservabilityTemplate.ToString())}");
            toStringOutput.Add($"this.ServiceSwaggerSpecId = {(this.ServiceSwaggerSpecId == null ? "null" : this.ServiceSwaggerSpecId.ToString())}");
            toStringOutput.Add($"this.Workflows = {(this.Workflows == null ? "null" : $"[{string.Join(", ", this.Workflows)} ]")}");
            toStringOutput.Add($"this.Workloads = {(this.Workloads == null ? "null" : $"[{string.Join(", ", this.Workloads)} ]")}");
            toStringOutput.Add($"this.Dependencies = {(this.Dependencies == null ? "null" : $"[{string.Join(", ", this.Dependencies)} ]")}");
            toStringOutput.Add($"this.Boundaries = {(this.Boundaries == null ? "null" : $"[{string.Join(", ", this.Boundaries)} ]")}");
        }
    }
}