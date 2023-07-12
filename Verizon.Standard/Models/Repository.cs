// <copyright file="Repository.cs" company="APIMatic">
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
    /// Repository.
    /// </summary>
    public class Repository
    {
        private List<string> agents;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "Agents", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Repository"/> class.
        /// </summary>
        public Repository()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Repository"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="id">id.</param>
        /// <param name="description">description.</param>
        /// <param name="type">type.</param>
        /// <param name="tag">tag.</param>
        /// <param name="endpoint">endpoint.</param>
        /// <param name="reacheability">reacheability.</param>
        /// <param name="cACertificate">CACertificate.</param>
        /// <param name="agents">Agents.</param>
        /// <param name="sslDisabled">sslDisabled.</param>
        /// <param name="isValidated">isValidated.</param>
        /// <param name="validationStatus">validationStatus.</param>
        /// <param name="credentialsType">credentialsType.</param>
        /// <param name="credentials">credentials.</param>
        /// <param name="sshKey">sshKey.</param>
        /// <param name="lastValidatedDate">lastValidatedDate.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="lastModifiedDate">lastModifiedDate.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="updatedBy">updatedBy.</param>
        /// <param name="isDeleted">isDeleted.</param>
        public Repository(
            string name,
            string id = null,
            string description = null,
            Models.EdgeServiceRepositoryTypeEnum? type = null,
            string tag = null,
            string endpoint = null,
            Models.RepositoryReacheabilityEnum? reacheability = null,
            string cACertificate = null,
            List<string> agents = null,
            bool? sslDisabled = null,
            bool? isValidated = null,
            string validationStatus = null,
            Models.RepositoryCredentialTypeEnum? credentialsType = null,
            Models.RepositoryCredential credentials = null,
            string sshKey = null,
            DateTime? lastValidatedDate = null,
            DateTime? createdDate = null,
            DateTime? lastModifiedDate = null,
            string createdBy = null,
            string updatedBy = null,
            bool? isDeleted = null)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Type = type;
            this.Tag = tag;
            this.Endpoint = endpoint;
            this.Reacheability = reacheability;
            this.CACertificate = cACertificate;
            if (agents != null)
            {
                this.Agents = agents;
            }

            this.SslDisabled = sslDisabled;
            this.IsValidated = isValidated;
            this.ValidationStatus = validationStatus;
            this.CredentialsType = credentialsType;
            this.Credentials = credentials;
            this.SshKey = sshKey;
            this.LastValidatedDate = lastValidatedDate;
            this.CreatedDate = createdDate;
            this.LastModifiedDate = lastModifiedDate;
            this.CreatedBy = createdBy;
            this.UpdatedBy = updatedBy;
            this.IsDeleted = isDeleted;
        }

        /// <summary>
        /// System generated unique identifier to identify repository uniquely.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Name of the repository to be created.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Description of the repository being created.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Type for the repository which can be Git or Helm.
        /// </summary>
        [JsonProperty("type", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.EdgeServiceRepositoryTypeEnum? Type { get; set; }

        /// <summary>
        /// Attribute which can be used to tag a repository.
        /// </summary>
        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        /// <summary>
        /// Endpoint URL for the repository from where resources needs to be fetched.
        /// </summary>
        [JsonProperty("endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string Endpoint { get; set; }

        /// <summary>
        /// Reachability can be of two types, Internet and Private Network.
        /// </summary>
        [JsonProperty("reacheability", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.RepositoryReacheabilityEnum? Reacheability { get; set; }

        /// <summary>
        /// Required if your repository uses a private certificate authencation.Please provide ur CA certificat in PEM format.
        /// </summary>
        [JsonProperty("CACertificate", NullValueHandling = NullValueHandling.Ignore)]
        public string CACertificate { get; set; }

        /// <summary>
        /// This attribute can be used to specify GITOps Agent to fetch details from private repository.
        /// </summary>
        [JsonProperty("Agents")]
        public List<string> Agents
        {
            get
            {
                return this.agents;
            }

            set
            {
                this.shouldSerialize["Agents"] = true;
                this.agents = value;
            }
        }

        /// <summary>
        /// Boolean value to check the SSL certification.
        /// </summary>
        [JsonProperty("sslDisabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SslDisabled { get; set; }

        /// <summary>
        /// True if CSP is validated using provided credential, false otherwise.
        /// </summary>
        [JsonProperty("isValidated", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsValidated { get; set; }

        /// <summary>
        /// Status when the repository is validated eg: CREDENTIAL_VALIDATION_SUCCESS.
        /// </summary>
        [JsonProperty("validationStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string ValidationStatus { get; set; }

        /// <summary>
        /// Credentials can be of two types, UserPassCredentials and SSHCredentials.
        /// </summary>
        [JsonProperty("credentialsType", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.RepositoryCredentialTypeEnum? CredentialsType { get; set; }

        /// <summary>
        /// Credentials of a repository.
        /// </summary>
        [JsonProperty("credentials", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RepositoryCredential Credentials { get; set; }

        /// <summary>
        /// SSH Private Key in PEM format.
        /// </summary>
        [JsonProperty("sshKey", NullValueHandling = NullValueHandling.Ignore)]
        public string SshKey { get; set; }

        /// <summary>
        /// Time when the repository was validated.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("lastValidatedDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastValidatedDate { get; set; }

        /// <summary>
        /// Date when the repository was created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Date when the repository was updated.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("lastModifiedDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// User information by whom the repository was created.
        /// </summary>
        [JsonProperty("createdBy", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// User information by whom the repository was updated.
        /// </summary>
        [JsonProperty("updatedBy", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedBy { get; set; }

        /// <summary>
        /// When it will be soft deleted, status will be changed.
        /// </summary>
        [JsonProperty("isDeleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDeleted { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Repository : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAgents()
        {
            this.shouldSerialize["Agents"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAgents()
        {
            return this.shouldSerialize["Agents"];
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
            return obj is Repository other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Tag == null && other.Tag == null) || (this.Tag?.Equals(other.Tag) == true)) &&
                ((this.Endpoint == null && other.Endpoint == null) || (this.Endpoint?.Equals(other.Endpoint) == true)) &&
                ((this.Reacheability == null && other.Reacheability == null) || (this.Reacheability?.Equals(other.Reacheability) == true)) &&
                ((this.CACertificate == null && other.CACertificate == null) || (this.CACertificate?.Equals(other.CACertificate) == true)) &&
                ((this.Agents == null && other.Agents == null) || (this.Agents?.Equals(other.Agents) == true)) &&
                ((this.SslDisabled == null && other.SslDisabled == null) || (this.SslDisabled?.Equals(other.SslDisabled) == true)) &&
                ((this.IsValidated == null && other.IsValidated == null) || (this.IsValidated?.Equals(other.IsValidated) == true)) &&
                ((this.ValidationStatus == null && other.ValidationStatus == null) || (this.ValidationStatus?.Equals(other.ValidationStatus) == true)) &&
                ((this.CredentialsType == null && other.CredentialsType == null) || (this.CredentialsType?.Equals(other.CredentialsType) == true)) &&
                ((this.Credentials == null && other.Credentials == null) || (this.Credentials?.Equals(other.Credentials) == true)) &&
                ((this.SshKey == null && other.SshKey == null) || (this.SshKey?.Equals(other.SshKey) == true)) &&
                ((this.LastValidatedDate == null && other.LastValidatedDate == null) || (this.LastValidatedDate?.Equals(other.LastValidatedDate) == true)) &&
                ((this.CreatedDate == null && other.CreatedDate == null) || (this.CreatedDate?.Equals(other.CreatedDate) == true)) &&
                ((this.LastModifiedDate == null && other.LastModifiedDate == null) || (this.LastModifiedDate?.Equals(other.LastModifiedDate) == true)) &&
                ((this.CreatedBy == null && other.CreatedBy == null) || (this.CreatedBy?.Equals(other.CreatedBy) == true)) &&
                ((this.UpdatedBy == null && other.UpdatedBy == null) || (this.UpdatedBy?.Equals(other.UpdatedBy) == true)) &&
                ((this.IsDeleted == null && other.IsDeleted == null) || (this.IsDeleted?.Equals(other.IsDeleted) == true));
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
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"this.Tag = {(this.Tag == null ? "null" : this.Tag == string.Empty ? "" : this.Tag)}");
            toStringOutput.Add($"this.Endpoint = {(this.Endpoint == null ? "null" : this.Endpoint == string.Empty ? "" : this.Endpoint)}");
            toStringOutput.Add($"this.Reacheability = {(this.Reacheability == null ? "null" : this.Reacheability.ToString())}");
            toStringOutput.Add($"this.CACertificate = {(this.CACertificate == null ? "null" : this.CACertificate == string.Empty ? "" : this.CACertificate)}");
            toStringOutput.Add($"this.Agents = {(this.Agents == null ? "null" : $"[{string.Join(", ", this.Agents)} ]")}");
            toStringOutput.Add($"this.SslDisabled = {(this.SslDisabled == null ? "null" : this.SslDisabled.ToString())}");
            toStringOutput.Add($"this.IsValidated = {(this.IsValidated == null ? "null" : this.IsValidated.ToString())}");
            toStringOutput.Add($"this.ValidationStatus = {(this.ValidationStatus == null ? "null" : this.ValidationStatus == string.Empty ? "" : this.ValidationStatus)}");
            toStringOutput.Add($"this.CredentialsType = {(this.CredentialsType == null ? "null" : this.CredentialsType.ToString())}");
            toStringOutput.Add($"this.Credentials = {(this.Credentials == null ? "null" : this.Credentials.ToString())}");
            toStringOutput.Add($"this.SshKey = {(this.SshKey == null ? "null" : this.SshKey == string.Empty ? "" : this.SshKey)}");
            toStringOutput.Add($"this.LastValidatedDate = {(this.LastValidatedDate == null ? "null" : this.LastValidatedDate.ToString())}");
            toStringOutput.Add($"this.CreatedDate = {(this.CreatedDate == null ? "null" : this.CreatedDate.ToString())}");
            toStringOutput.Add($"this.LastModifiedDate = {(this.LastModifiedDate == null ? "null" : this.LastModifiedDate.ToString())}");
            toStringOutput.Add($"this.CreatedBy = {(this.CreatedBy == null ? "null" : this.CreatedBy == string.Empty ? "" : this.CreatedBy)}");
            toStringOutput.Add($"this.UpdatedBy = {(this.UpdatedBy == null ? "null" : this.UpdatedBy == string.Empty ? "" : this.UpdatedBy)}");
            toStringOutput.Add($"this.IsDeleted = {(this.IsDeleted == null ? "null" : this.IsDeleted.ToString())}");
        }
    }
}