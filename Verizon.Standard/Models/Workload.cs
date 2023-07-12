// <copyright file="Workload.cs" company="APIMatic">
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
    /// Workload.
    /// </summary>
    public class Workload
    {
        private string description;
        private Models.ServiceDependencyPackageTypeEnum? packageType;
        private Models.WorkloadRepositoryTypeEnum? repositoryType;
        private string repositoryId;
        private List<string> files;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "description", false },
            { "packageType", false },
            { "repositoryType", false },
            { "repositoryId", false },
            { "files", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Workload"/> class.
        /// </summary>
        public Workload()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Workload"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="id">id.</param>
        /// <param name="description">description.</param>
        /// <param name="packageType">packageType.</param>
        /// <param name="uploadType">uploadType.</param>
        /// <param name="repositoryType">repositoryType.</param>
        /// <param name="repositoryId">repositoryId.</param>
        /// <param name="repository">repository.</param>
        /// <param name="files">files.</param>
        /// <param name="revisionType">revisionType.</param>
        /// <param name="helmGitBranch">helmGitBranch.</param>
        /// <param name="helmGitTag">helmGitTag.</param>
        /// <param name="helmYamlGitTag">helmYamlGitTag.</param>
        /// <param name="helmHelmrepo">helmHelmrepo.</param>
        /// <param name="yamlGitBranch">yamlGitBranch.</param>
        /// <param name="terraformGitBranch">terraformGitBranch.</param>
        /// <param name="terraformGitTag">terraformGitTag.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="lastModifiedDte">lastModifiedDte.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="updatedBy">updatedBy.</param>
        public Workload(
            string name,
            string id = null,
            string description = null,
            Models.ServiceDependencyPackageTypeEnum? packageType = null,
            Models.UploadTypeEnum? uploadType = null,
            Models.WorkloadRepositoryTypeEnum? repositoryType = null,
            string repositoryId = null,
            Models.Repository repository = null,
            List<string> files = null,
            Models.WorkloadRevisionTypeEnum? revisionType = null,
            Models.ServiceOnboardingHelmGitBranch helmGitBranch = null,
            Models.ServiceOnboardingHelmGitTag helmGitTag = null,
            Models.ServiceOnboardingHelmYamlGitTag helmYamlGitTag = null,
            Models.ServiceOnboardingHelmHelmrepo helmHelmrepo = null,
            Models.ServiceOnboardingYamlGitBranch yamlGitBranch = null,
            Models.ServiceOnboardingTerraformGitBranch terraformGitBranch = null,
            Models.ServiceOnboardingTerraformGitTag terraformGitTag = null,
            DateTime? createdDate = null,
            DateTime? lastModifiedDte = null,
            string createdBy = null,
            string updatedBy = null)
        {
            this.Id = id;
            this.Name = name;
            if (description != null)
            {
                this.Description = description;
            }

            if (packageType != null)
            {
                this.PackageType = packageType;
            }

            this.UploadType = uploadType;
            if (repositoryType != null)
            {
                this.RepositoryType = repositoryType;
            }

            if (repositoryId != null)
            {
                this.RepositoryId = repositoryId;
            }

            this.Repository = repository;
            if (files != null)
            {
                this.Files = files;
            }

            this.RevisionType = revisionType;
            this.HelmGitBranch = helmGitBranch;
            this.HelmGitTag = helmGitTag;
            this.HelmYamlGitTag = helmYamlGitTag;
            this.HelmHelmrepo = helmHelmrepo;
            this.YamlGitBranch = yamlGitBranch;
            this.TerraformGitBranch = terraformGitBranch;
            this.TerraformGitTag = terraformGitTag;
            this.CreatedDate = createdDate;
            this.LastModifiedDte = lastModifiedDte;
            this.CreatedBy = createdBy;
            this.UpdatedBy = updatedBy;
        }

        /// <summary>
        /// The auto-generated Id of the workload.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Name of the workload needs to be deployed.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// A brief workload description.
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
        /// Deployment package type.
        /// </summary>
        [JsonProperty("packageType", ItemConverterType = typeof(StringEnumConverter))]
        public Models.ServiceDependencyPackageTypeEnum? PackageType
        {
            get
            {
                return this.packageType;
            }

            set
            {
                this.shouldSerialize["packageType"] = true;
                this.packageType = value;
            }
        }

        /// <summary>
        /// Allowed values are: GIT files (PULL_FROM_REPO), MANUAL_UPLOAD.
        /// </summary>
        [JsonProperty("uploadType", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.UploadTypeEnum? UploadType { get; set; }

        /// <summary>
        /// Repository types allowed: GIT/HELM.
        /// </summary>
        [JsonProperty("repositoryType", ItemConverterType = typeof(StringEnumConverter))]
        public Models.WorkloadRepositoryTypeEnum? RepositoryType
        {
            get
            {
                return this.repositoryType;
            }

            set
            {
                this.shouldSerialize["repositoryType"] = true;
                this.repositoryType = value;
            }
        }

        /// <summary>
        /// In case of 'Pull files from my repository', The user can provide the existing repositoryID.
        /// </summary>
        [JsonProperty("repositoryId")]
        public string RepositoryId
        {
            get
            {
                return this.repositoryId;
            }

            set
            {
                this.shouldSerialize["repositoryId"] = true;
                this.repositoryId = value;
            }
        }

        /// <summary>
        /// Users can create a repository to maintain service artifacts. Repository would be either a Git or HELM repository.
        /// </summary>
        [JsonProperty("repository", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Repository Repository { get; set; }

        /// <summary>
        /// Files which are being generated.
        /// </summary>
        [JsonProperty("files")]
        public List<string> Files
        {
            get
            {
                return this.files;
            }

            set
            {
                this.shouldSerialize["files"] = true;
                this.files = value;
            }
        }

        /// <summary>
        /// Revision type can be a BRANCH or TAG.
        /// </summary>
        [JsonProperty("revisionType", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.WorkloadRevisionTypeEnum? RevisionType { get; set; }

        /// <summary>
        /// Gets or sets HelmGitBranch.
        /// </summary>
        [JsonProperty("helmGitBranch", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ServiceOnboardingHelmGitBranch HelmGitBranch { get; set; }

        /// <summary>
        /// Gets or sets HelmGitTag.
        /// </summary>
        [JsonProperty("helmGitTag", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ServiceOnboardingHelmGitTag HelmGitTag { get; set; }

        /// <summary>
        /// Gets or sets HelmYamlGitTag.
        /// </summary>
        [JsonProperty("helmYamlGitTag", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ServiceOnboardingHelmYamlGitTag HelmYamlGitTag { get; set; }

        /// <summary>
        /// Gets or sets HelmHelmrepo.
        /// </summary>
        [JsonProperty("helmHelmrepo", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ServiceOnboardingHelmHelmrepo HelmHelmrepo { get; set; }

        /// <summary>
        /// Gets or sets YamlGitBranch.
        /// </summary>
        [JsonProperty("yamlGitBranch", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ServiceOnboardingYamlGitBranch YamlGitBranch { get; set; }

        /// <summary>
        /// Gets or sets TerraformGitBranch.
        /// </summary>
        [JsonProperty("terraformGitBranch", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ServiceOnboardingTerraformGitBranch TerraformGitBranch { get; set; }

        /// <summary>
        /// Gets or sets TerraformGitTag.
        /// </summary>
        [JsonProperty("terraformGitTag", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ServiceOnboardingTerraformGitTag TerraformGitTag { get; set; }

        /// <summary>
        /// The date on which the workload is created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// The date when the created workload was last modified.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("lastModifiedDte", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastModifiedDte { get; set; }

        /// <summary>
        /// Identity of the user who created the workload.
        /// </summary>
        [JsonProperty("createdBy", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Identity of the user who updated the workload.
        /// </summary>
        [JsonProperty("updatedBy", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedBy { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Workload : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetPackageType()
        {
            this.shouldSerialize["packageType"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRepositoryType()
        {
            this.shouldSerialize["repositoryType"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRepositoryId()
        {
            this.shouldSerialize["repositoryId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFiles()
        {
            this.shouldSerialize["files"] = false;
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
        public bool ShouldSerializePackageType()
        {
            return this.shouldSerialize["packageType"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRepositoryType()
        {
            return this.shouldSerialize["repositoryType"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRepositoryId()
        {
            return this.shouldSerialize["repositoryId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFiles()
        {
            return this.shouldSerialize["files"];
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
            return obj is Workload other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.PackageType == null && other.PackageType == null) || (this.PackageType?.Equals(other.PackageType) == true)) &&
                ((this.UploadType == null && other.UploadType == null) || (this.UploadType?.Equals(other.UploadType) == true)) &&
                ((this.RepositoryType == null && other.RepositoryType == null) || (this.RepositoryType?.Equals(other.RepositoryType) == true)) &&
                ((this.RepositoryId == null && other.RepositoryId == null) || (this.RepositoryId?.Equals(other.RepositoryId) == true)) &&
                ((this.Repository == null && other.Repository == null) || (this.Repository?.Equals(other.Repository) == true)) &&
                ((this.Files == null && other.Files == null) || (this.Files?.Equals(other.Files) == true)) &&
                ((this.RevisionType == null && other.RevisionType == null) || (this.RevisionType?.Equals(other.RevisionType) == true)) &&
                ((this.HelmGitBranch == null && other.HelmGitBranch == null) || (this.HelmGitBranch?.Equals(other.HelmGitBranch) == true)) &&
                ((this.HelmGitTag == null && other.HelmGitTag == null) || (this.HelmGitTag?.Equals(other.HelmGitTag) == true)) &&
                ((this.HelmYamlGitTag == null && other.HelmYamlGitTag == null) || (this.HelmYamlGitTag?.Equals(other.HelmYamlGitTag) == true)) &&
                ((this.HelmHelmrepo == null && other.HelmHelmrepo == null) || (this.HelmHelmrepo?.Equals(other.HelmHelmrepo) == true)) &&
                ((this.YamlGitBranch == null && other.YamlGitBranch == null) || (this.YamlGitBranch?.Equals(other.YamlGitBranch) == true)) &&
                ((this.TerraformGitBranch == null && other.TerraformGitBranch == null) || (this.TerraformGitBranch?.Equals(other.TerraformGitBranch) == true)) &&
                ((this.TerraformGitTag == null && other.TerraformGitTag == null) || (this.TerraformGitTag?.Equals(other.TerraformGitTag) == true)) &&
                ((this.CreatedDate == null && other.CreatedDate == null) || (this.CreatedDate?.Equals(other.CreatedDate) == true)) &&
                ((this.LastModifiedDte == null && other.LastModifiedDte == null) || (this.LastModifiedDte?.Equals(other.LastModifiedDte) == true)) &&
                ((this.CreatedBy == null && other.CreatedBy == null) || (this.CreatedBy?.Equals(other.CreatedBy) == true)) &&
                ((this.UpdatedBy == null && other.UpdatedBy == null) || (this.UpdatedBy?.Equals(other.UpdatedBy) == true));
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
            toStringOutput.Add($"this.PackageType = {(this.PackageType == null ? "null" : this.PackageType.ToString())}");
            toStringOutput.Add($"this.UploadType = {(this.UploadType == null ? "null" : this.UploadType.ToString())}");
            toStringOutput.Add($"this.RepositoryType = {(this.RepositoryType == null ? "null" : this.RepositoryType.ToString())}");
            toStringOutput.Add($"this.RepositoryId = {(this.RepositoryId == null ? "null" : this.RepositoryId == string.Empty ? "" : this.RepositoryId)}");
            toStringOutput.Add($"this.Repository = {(this.Repository == null ? "null" : this.Repository.ToString())}");
            toStringOutput.Add($"this.Files = {(this.Files == null ? "null" : $"[{string.Join(", ", this.Files)} ]")}");
            toStringOutput.Add($"this.RevisionType = {(this.RevisionType == null ? "null" : this.RevisionType.ToString())}");
            toStringOutput.Add($"this.HelmGitBranch = {(this.HelmGitBranch == null ? "null" : this.HelmGitBranch.ToString())}");
            toStringOutput.Add($"this.HelmGitTag = {(this.HelmGitTag == null ? "null" : this.HelmGitTag.ToString())}");
            toStringOutput.Add($"this.HelmYamlGitTag = {(this.HelmYamlGitTag == null ? "null" : this.HelmYamlGitTag.ToString())}");
            toStringOutput.Add($"this.HelmHelmrepo = {(this.HelmHelmrepo == null ? "null" : this.HelmHelmrepo.ToString())}");
            toStringOutput.Add($"this.YamlGitBranch = {(this.YamlGitBranch == null ? "null" : this.YamlGitBranch.ToString())}");
            toStringOutput.Add($"this.TerraformGitBranch = {(this.TerraformGitBranch == null ? "null" : this.TerraformGitBranch.ToString())}");
            toStringOutput.Add($"this.TerraformGitTag = {(this.TerraformGitTag == null ? "null" : this.TerraformGitTag.ToString())}");
            toStringOutput.Add($"this.CreatedDate = {(this.CreatedDate == null ? "null" : this.CreatedDate.ToString())}");
            toStringOutput.Add($"this.LastModifiedDte = {(this.LastModifiedDte == null ? "null" : this.LastModifiedDte.ToString())}");
            toStringOutput.Add($"this.CreatedBy = {(this.CreatedBy == null ? "null" : this.CreatedBy == string.Empty ? "" : this.CreatedBy)}");
            toStringOutput.Add($"this.UpdatedBy = {(this.UpdatedBy == null ? "null" : this.UpdatedBy == string.Empty ? "" : this.UpdatedBy)}");
        }
    }
}