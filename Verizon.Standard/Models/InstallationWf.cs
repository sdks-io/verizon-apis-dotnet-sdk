// <copyright file="InstallationWf.cs" company="APIMatic">
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
    /// InstallationWf.
    /// </summary>
    public class InstallationWf
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstallationWf"/> class.
        /// </summary>
        public InstallationWf()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstallationWf"/> class.
        /// </summary>
        /// <param name="hookType">hookType.</param>
        /// <param name="uploadType">uploadType.</param>
        /// <param name="repositoryId">repositoryId.</param>
        /// <param name="repository">repository.</param>
        /// <param name="sourceCodeType">sourceCodeType.</param>
        /// <param name="revisionType">revisionType.</param>
        /// <param name="name">name.</param>
        /// <param name="path">path.</param>
        public InstallationWf(
            Models.HookTypeEnum? hookType = null,
            Models.UploadTypeEnum? uploadType = null,
            string repositoryId = null,
            Models.Repository repository = null,
            Models.SourceCodeTypeEnum? sourceCodeType = null,
            Models.WorkloadRevisionTypeEnum? revisionType = null,
            string name = null,
            string path = null)
        {
            this.HookType = hookType;
            this.UploadType = uploadType;
            this.RepositoryId = repositoryId;
            this.Repository = repository;
            this.SourceCodeType = sourceCodeType;
            this.RevisionType = revisionType;
            this.Name = name;
            this.Path = path;
        }

        /// <summary>
        /// Gets or sets HookType.
        /// </summary>
        [JsonProperty("hookType", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.HookTypeEnum? HookType { get; set; }

        /// <summary>
        /// Allowed values are: GIT files (PULL_FROM_REPO), MANUAL_UPLOAD.
        /// </summary>
        [JsonProperty("uploadType", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.UploadTypeEnum? UploadType { get; set; }

        /// <summary>
        /// Repository ID of an existing repository.
        /// </summary>
        [JsonProperty("repositoryId", NullValueHandling = NullValueHandling.Ignore)]
        public string RepositoryId { get; set; }

        /// <summary>
        /// Users can create a repository to maintain service artifacts. Repository would be either a Git or HELM repository.
        /// </summary>
        [JsonProperty("repository", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Repository Repository { get; set; }

        /// <summary>
        /// Source code type can be JAVA or GO.
        /// </summary>
        [JsonProperty("sourceCodeType", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.SourceCodeTypeEnum? SourceCodeType { get; set; }

        /// <summary>
        /// Revision type can be a BRANCH or TAG.
        /// </summary>
        [JsonProperty("revisionType", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.WorkloadRevisionTypeEnum? RevisionType { get; set; }

        /// <summary>
        /// Branch or tag name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// The workflow path.
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InstallationWf : ({string.Join(", ", toStringOutput)})";
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
            return obj is InstallationWf other &&                ((this.HookType == null && other.HookType == null) || (this.HookType?.Equals(other.HookType) == true)) &&
                ((this.UploadType == null && other.UploadType == null) || (this.UploadType?.Equals(other.UploadType) == true)) &&
                ((this.RepositoryId == null && other.RepositoryId == null) || (this.RepositoryId?.Equals(other.RepositoryId) == true)) &&
                ((this.Repository == null && other.Repository == null) || (this.Repository?.Equals(other.Repository) == true)) &&
                ((this.SourceCodeType == null && other.SourceCodeType == null) || (this.SourceCodeType?.Equals(other.SourceCodeType) == true)) &&
                ((this.RevisionType == null && other.RevisionType == null) || (this.RevisionType?.Equals(other.RevisionType) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Path == null && other.Path == null) || (this.Path?.Equals(other.Path) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.HookType = {(this.HookType == null ? "null" : this.HookType.ToString())}");
            toStringOutput.Add($"this.UploadType = {(this.UploadType == null ? "null" : this.UploadType.ToString())}");
            toStringOutput.Add($"this.RepositoryId = {(this.RepositoryId == null ? "null" : this.RepositoryId == string.Empty ? "" : this.RepositoryId)}");
            toStringOutput.Add($"this.Repository = {(this.Repository == null ? "null" : this.Repository.ToString())}");
            toStringOutput.Add($"this.SourceCodeType = {(this.SourceCodeType == null ? "null" : this.SourceCodeType.ToString())}");
            toStringOutput.Add($"this.RevisionType = {(this.RevisionType == null ? "null" : this.RevisionType.ToString())}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.Path = {(this.Path == null ? "null" : this.Path == string.Empty ? "" : this.Path)}");
        }
    }
}