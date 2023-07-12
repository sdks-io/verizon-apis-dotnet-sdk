// <copyright file="EdgeServiceRepository.cs" company="APIMatic">
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
    /// EdgeServiceRepository.
    /// </summary>
    public class EdgeServiceRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeServiceRepository"/> class.
        /// </summary>
        public EdgeServiceRepository()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeServiceRepository"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="type">type.</param>
        /// <param name="endpoint">endpoint.</param>
        /// <param name="reacheability">reacheability.</param>
        /// <param name="description">description.</param>
        /// <param name="revision">revision.</param>
        /// <param name="vendorInformation">vendorInformation.</param>
        /// <param name="tag">tag.</param>
        /// <param name="cACertificate">CACertificate.</param>
        /// <param name="agents">Agents.</param>
        /// <param name="sslDisabled">sslDisabled.</param>
        /// <param name="credentialsType">credentialsType.</param>
        /// <param name="credentials">credentials.</param>
        /// <param name="sshKey">sshKey.</param>
        public EdgeServiceRepository(
            string name,
            Models.RepositoryResTypeEnum type,
            string endpoint,
            Models.ReacheabilityEnum reacheability,
            string description = null,
            Models.Revision revision = null,
            Models.VendorInformation vendorInformation = null,
            string tag = null,
            string cACertificate = null,
            List<string> agents = null,
            bool? sslDisabled = null,
            Models.CredentialsTypeEnum? credentialsType = null,
            Models.Credential credentials = null,
            string sshKey = null)
        {
            this.Name = name;
            this.Description = description;
            this.Revision = revision;
            this.VendorInformation = vendorInformation;
            this.Type = type;
            this.Tag = tag;
            this.Endpoint = endpoint;
            this.Reacheability = reacheability;
            this.CACertificate = cACertificate;
            this.Agents = agents;
            this.SslDisabled = sslDisabled;
            this.CredentialsType = credentialsType;
            this.Credentials = credentials;
            this.SshKey = sshKey;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Revision.
        /// </summary>
        [JsonProperty("revision", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Revision Revision { get; set; }

        /// <summary>
        /// Gets or sets VendorInformation.
        /// </summary>
        [JsonProperty("vendorInformation", NullValueHandling = NullValueHandling.Ignore)]
        public Models.VendorInformation VendorInformation { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type", ItemConverterType = typeof(StringEnumConverter))]
        public Models.RepositoryResTypeEnum Type { get; set; }

        /// <summary>
        /// Gets or sets Tag.
        /// </summary>
        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        /// <summary>
        /// Gets or sets Endpoint.
        /// </summary>
        [JsonProperty("endpoint")]
        public string Endpoint { get; set; }

        /// <summary>
        /// Gets or sets Reacheability.
        /// </summary>
        [JsonProperty("reacheability", ItemConverterType = typeof(StringEnumConverter))]
        public Models.ReacheabilityEnum Reacheability { get; set; }

        /// <summary>
        /// Required if your repository uses a private certificate authencation.Please provide ur CA certificat in PEM format.
        /// </summary>
        [JsonProperty("CACertificate", NullValueHandling = NullValueHandling.Ignore)]
        public string CACertificate { get; set; }

        /// <summary>
        /// Gets or sets Agents.
        /// </summary>
        [JsonProperty("Agents", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Agents { get; set; }

        /// <summary>
        /// Gets or sets SslDisabled.
        /// </summary>
        [JsonProperty("sslDisabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SslDisabled { get; set; }

        /// <summary>
        /// Gets or sets CredentialsType.
        /// </summary>
        [JsonProperty("credentialsType", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.CredentialsTypeEnum? CredentialsType { get; set; }

        /// <summary>
        /// Gets or sets Credentials.
        /// </summary>
        [JsonProperty("credentials", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Credential Credentials { get; set; }

        /// <summary>
        /// SSH Private Key in PEM format.
        /// </summary>
        [JsonProperty("sshKey", NullValueHandling = NullValueHandling.Ignore)]
        public string SshKey { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"EdgeServiceRepository : ({string.Join(", ", toStringOutput)})";
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
            return obj is EdgeServiceRepository other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Revision == null && other.Revision == null) || (this.Revision?.Equals(other.Revision) == true)) &&
                ((this.VendorInformation == null && other.VendorInformation == null) || (this.VendorInformation?.Equals(other.VendorInformation) == true)) &&
                this.Type.Equals(other.Type) &&
                ((this.Tag == null && other.Tag == null) || (this.Tag?.Equals(other.Tag) == true)) &&
                ((this.Endpoint == null && other.Endpoint == null) || (this.Endpoint?.Equals(other.Endpoint) == true)) &&
                this.Reacheability.Equals(other.Reacheability) &&
                ((this.CACertificate == null && other.CACertificate == null) || (this.CACertificate?.Equals(other.CACertificate) == true)) &&
                ((this.Agents == null && other.Agents == null) || (this.Agents?.Equals(other.Agents) == true)) &&
                ((this.SslDisabled == null && other.SslDisabled == null) || (this.SslDisabled?.Equals(other.SslDisabled) == true)) &&
                ((this.CredentialsType == null && other.CredentialsType == null) || (this.CredentialsType?.Equals(other.CredentialsType) == true)) &&
                ((this.Credentials == null && other.Credentials == null) || (this.Credentials?.Equals(other.Credentials) == true)) &&
                ((this.SshKey == null && other.SshKey == null) || (this.SshKey?.Equals(other.SshKey) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.Revision = {(this.Revision == null ? "null" : this.Revision.ToString())}");
            toStringOutput.Add($"this.VendorInformation = {(this.VendorInformation == null ? "null" : this.VendorInformation.ToString())}");
            toStringOutput.Add($"this.Type = {this.Type}");
            toStringOutput.Add($"this.Tag = {(this.Tag == null ? "null" : this.Tag == string.Empty ? "" : this.Tag)}");
            toStringOutput.Add($"this.Endpoint = {(this.Endpoint == null ? "null" : this.Endpoint == string.Empty ? "" : this.Endpoint)}");
            toStringOutput.Add($"this.Reacheability = {this.Reacheability}");
            toStringOutput.Add($"this.CACertificate = {(this.CACertificate == null ? "null" : this.CACertificate == string.Empty ? "" : this.CACertificate)}");
            toStringOutput.Add($"this.Agents = {(this.Agents == null ? "null" : $"[{string.Join(", ", this.Agents)} ]")}");
            toStringOutput.Add($"this.SslDisabled = {(this.SslDisabled == null ? "null" : this.SslDisabled.ToString())}");
            toStringOutput.Add($"this.CredentialsType = {(this.CredentialsType == null ? "null" : this.CredentialsType.ToString())}");
            toStringOutput.Add($"this.Credentials = {(this.Credentials == null ? "null" : this.Credentials.ToString())}");
            toStringOutput.Add($"this.SshKey = {(this.SshKey == null ? "null" : this.SshKey == string.Empty ? "" : this.SshKey)}");
        }
    }
}