// <copyright file="Workflow.cs" company="APIMatic">
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
    /// Workflow.
    /// </summary>
    public class Workflow
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Workflow"/> class.
        /// </summary>
        public Workflow()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Workflow"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="version">version.</param>
        /// <param name="id">id.</param>
        /// <param name="type">type.</param>
        /// <param name="installationWf">installationWf.</param>
        /// <param name="operationsWf">operationsWf.</param>
        /// <param name="customWf">customWf.</param>
        /// <param name="files">files.</param>
        /// <param name="status">status.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="lastModifiedDate">lastModifiedDate.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="updatedBy">updatedBy.</param>
        public Workflow(
            string name,
            string version,
            string id = null,
            Models.WorkflowTypeEnum? type = null,
            Models.InstallationWf installationWf = null,
            Models.OperationsWf operationsWf = null,
            Models.CustomWf customWf = null,
            List<string> files = null,
            string status = null,
            DateTime? createdDate = null,
            DateTime? lastModifiedDate = null,
            string createdBy = null,
            string updatedBy = null)
        {
            this.Name = name;
            this.Version = version;
            this.Id = id;
            this.Type = type;
            this.InstallationWf = installationWf;
            this.OperationsWf = operationsWf;
            this.CustomWf = customWf;
            this.Files = files;
            this.Status = status;
            this.CreatedDate = createdDate;
            this.LastModifiedDate = lastModifiedDate;
            this.CreatedBy = createdBy;
            this.UpdatedBy = updatedBy;
        }

        /// <summary>
        /// The service version workflow name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The service version workflow value.
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }

        /// <summary>
        /// Auto-generated UUID for each workdflow triggered.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Service type e.g. Installation, Operations, Custom.
        /// </summary>
        [JsonProperty("type", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.WorkflowTypeEnum? Type { get; set; }

        /// <summary>
        /// `installationWf` attribute of a service.
        /// </summary>
        [JsonProperty("installationWf", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InstallationWf InstallationWf { get; set; }

        /// <summary>
        /// `operationsWf` attribute of a service.
        /// </summary>
        [JsonProperty("operationsWf", NullValueHandling = NullValueHandling.Ignore)]
        public Models.OperationsWf OperationsWf { get; set; }

        /// <summary>
        /// `customWf` attribute of a service.
        /// </summary>
        [JsonProperty("customWf", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CustomWf CustomWf { get; set; }

        /// <summary>
        /// Files which are being generated.
        /// </summary>
        [JsonProperty("files", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Files { get; set; }

        /// <summary>
        /// Status of the workflow.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// The date on which the workflow is created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// The date when the created workflow was last modified.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("lastModifiedDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Identity of the user who created the workflow.
        /// </summary>
        [JsonProperty("createdBy", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Identity of the user who updated the workflow.
        /// </summary>
        [JsonProperty("updatedBy", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedBy { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Workflow : ({string.Join(", ", toStringOutput)})";
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
            return obj is Workflow other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Version == null && other.Version == null) || (this.Version?.Equals(other.Version) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.InstallationWf == null && other.InstallationWf == null) || (this.InstallationWf?.Equals(other.InstallationWf) == true)) &&
                ((this.OperationsWf == null && other.OperationsWf == null) || (this.OperationsWf?.Equals(other.OperationsWf) == true)) &&
                ((this.CustomWf == null && other.CustomWf == null) || (this.CustomWf?.Equals(other.CustomWf) == true)) &&
                ((this.Files == null && other.Files == null) || (this.Files?.Equals(other.Files) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.CreatedDate == null && other.CreatedDate == null) || (this.CreatedDate?.Equals(other.CreatedDate) == true)) &&
                ((this.LastModifiedDate == null && other.LastModifiedDate == null) || (this.LastModifiedDate?.Equals(other.LastModifiedDate) == true)) &&
                ((this.CreatedBy == null && other.CreatedBy == null) || (this.CreatedBy?.Equals(other.CreatedBy) == true)) &&
                ((this.UpdatedBy == null && other.UpdatedBy == null) || (this.UpdatedBy?.Equals(other.UpdatedBy) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.Version = {(this.Version == null ? "null" : this.Version == string.Empty ? "" : this.Version)}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"this.InstallationWf = {(this.InstallationWf == null ? "null" : this.InstallationWf.ToString())}");
            toStringOutput.Add($"this.OperationsWf = {(this.OperationsWf == null ? "null" : this.OperationsWf.ToString())}");
            toStringOutput.Add($"this.CustomWf = {(this.CustomWf == null ? "null" : this.CustomWf.ToString())}");
            toStringOutput.Add($"this.Files = {(this.Files == null ? "null" : $"[{string.Join(", ", this.Files)} ]")}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.CreatedDate = {(this.CreatedDate == null ? "null" : this.CreatedDate.ToString())}");
            toStringOutput.Add($"this.LastModifiedDate = {(this.LastModifiedDate == null ? "null" : this.LastModifiedDate.ToString())}");
            toStringOutput.Add($"this.CreatedBy = {(this.CreatedBy == null ? "null" : this.CreatedBy == string.Empty ? "" : this.CreatedBy)}");
            toStringOutput.Add($"this.UpdatedBy = {(this.UpdatedBy == null ? "null" : this.UpdatedBy == string.Empty ? "" : this.UpdatedBy)}");
        }
    }
}