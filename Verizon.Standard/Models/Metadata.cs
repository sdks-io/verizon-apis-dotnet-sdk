// <copyright file="Metadata.cs" company="APIMatic">
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
    /// Metadata.
    /// </summary>
    public class Metadata
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Metadata"/> class.
        /// </summary>
        public Metadata()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Metadata"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="modifiedAt">modifiedAt.</param>
        /// <param name="labels">labels.</param>
        /// <param name="annotations">annotations.</param>
        /// <param name="organizationID">organizationID.</param>
        /// <param name="partnerID">partnerID.</param>
        /// <param name="projectID">projectID.</param>
        /// <param name="id">id.</param>
        public Metadata(
            string name = null,
            string displayName = null,
            string createdAt = null,
            string modifiedAt = null,
            Models.MetadataLabel labels = null,
            Models.MetadataAnnotation annotations = null,
            int? organizationID = null,
            int? partnerID = null,
            int? projectID = null,
            string id = null)
        {
            this.Name = name;
            this.DisplayName = displayName;
            this.CreatedAt = createdAt;
            this.ModifiedAt = modifiedAt;
            this.Labels = labels;
            this.Annotations = annotations;
            this.OrganizationID = organizationID;
            this.PartnerID = partnerID;
            this.ProjectID = projectID;
            this.Id = id;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets DisplayName.
        /// </summary>
        [JsonProperty("displayName", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonProperty("createdAt", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets ModifiedAt.
        /// </summary>
        [JsonProperty("modifiedAt", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedAt { get; set; }

        /// <summary>
        /// Gets or sets Labels.
        /// </summary>
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MetadataLabel Labels { get; set; }

        /// <summary>
        /// Gets or sets Annotations.
        /// </summary>
        [JsonProperty("annotations", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MetadataAnnotation Annotations { get; set; }

        /// <summary>
        /// Gets or sets OrganizationID.
        /// </summary>
        [JsonProperty("organizationID", NullValueHandling = NullValueHandling.Ignore)]
        public int? OrganizationID { get; set; }

        /// <summary>
        /// Gets or sets PartnerID.
        /// </summary>
        [JsonProperty("partnerID", NullValueHandling = NullValueHandling.Ignore)]
        public int? PartnerID { get; set; }

        /// <summary>
        /// Gets or sets ProjectID.
        /// </summary>
        [JsonProperty("projectID", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProjectID { get; set; }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Metadata : ({string.Join(", ", toStringOutput)})";
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
            return obj is Metadata other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.DisplayName == null && other.DisplayName == null) || (this.DisplayName?.Equals(other.DisplayName) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.ModifiedAt == null && other.ModifiedAt == null) || (this.ModifiedAt?.Equals(other.ModifiedAt) == true)) &&
                ((this.Labels == null && other.Labels == null) || (this.Labels?.Equals(other.Labels) == true)) &&
                ((this.Annotations == null && other.Annotations == null) || (this.Annotations?.Equals(other.Annotations) == true)) &&
                ((this.OrganizationID == null && other.OrganizationID == null) || (this.OrganizationID?.Equals(other.OrganizationID) == true)) &&
                ((this.PartnerID == null && other.PartnerID == null) || (this.PartnerID?.Equals(other.PartnerID) == true)) &&
                ((this.ProjectID == null && other.ProjectID == null) || (this.ProjectID?.Equals(other.ProjectID) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.DisplayName = {(this.DisplayName == null ? "null" : this.DisplayName == string.Empty ? "" : this.DisplayName)}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt == string.Empty ? "" : this.CreatedAt)}");
            toStringOutput.Add($"this.ModifiedAt = {(this.ModifiedAt == null ? "null" : this.ModifiedAt == string.Empty ? "" : this.ModifiedAt)}");
            toStringOutput.Add($"this.Labels = {(this.Labels == null ? "null" : this.Labels.ToString())}");
            toStringOutput.Add($"this.Annotations = {(this.Annotations == null ? "null" : this.Annotations.ToString())}");
            toStringOutput.Add($"this.OrganizationID = {(this.OrganizationID == null ? "null" : this.OrganizationID.ToString())}");
            toStringOutput.Add($"this.PartnerID = {(this.PartnerID == null ? "null" : this.PartnerID.ToString())}");
            toStringOutput.Add($"this.ProjectID = {(this.ProjectID == null ? "null" : this.ProjectID.ToString())}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
        }
    }
}