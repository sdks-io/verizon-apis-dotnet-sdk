// <copyright file="ClusterVersionInfo.cs" company="APIMatic">
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
    /// ClusterVersionInfo.
    /// </summary>
    public class ClusterVersionInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterVersionInfo"/> class.
        /// </summary>
        public ClusterVersionInfo()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterVersionInfo"/> class.
        /// </summary>
        /// <param name="clusterId">cluster_id.</param>
        /// <param name="kubeVersion">kube_version.</param>
        /// <param name="organizationId">organization_id.</param>
        /// <param name="partnerId">partner_id.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="modifiedAt">modified_at.</param>
        /// <param name="id">id.</param>
        /// <param name="behindLatestBy">behind_latest_by.</param>
        public ClusterVersionInfo(
            string clusterId = null,
            string kubeVersion = null,
            string organizationId = null,
            string partnerId = null,
            string createdAt = null,
            string modifiedAt = null,
            string id = null,
            int? behindLatestBy = null)
        {
            this.ClusterId = clusterId;
            this.KubeVersion = kubeVersion;
            this.OrganizationId = organizationId;
            this.PartnerId = partnerId;
            this.CreatedAt = createdAt;
            this.ModifiedAt = modifiedAt;
            this.Id = id;
            this.BehindLatestBy = behindLatestBy;
        }

        /// <summary>
        /// Gets or sets ClusterId.
        /// </summary>
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }

        /// <summary>
        /// Gets or sets KubeVersion.
        /// </summary>
        [JsonProperty("kube_version", NullValueHandling = NullValueHandling.Ignore)]
        public string KubeVersion { get; set; }

        /// <summary>
        /// Gets or sets OrganizationId.
        /// </summary>
        [JsonProperty("organization_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Gets or sets PartnerId.
        /// </summary>
        [JsonProperty("partner_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PartnerId { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets ModifiedAt.
        /// </summary>
        [JsonProperty("modified_at", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedAt { get; set; }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets BehindLatestBy.
        /// </summary>
        [JsonProperty("behind_latest_by", NullValueHandling = NullValueHandling.Ignore)]
        public int? BehindLatestBy { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ClusterVersionInfo : ({string.Join(", ", toStringOutput)})";
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
            return obj is ClusterVersionInfo other &&                ((this.ClusterId == null && other.ClusterId == null) || (this.ClusterId?.Equals(other.ClusterId) == true)) &&
                ((this.KubeVersion == null && other.KubeVersion == null) || (this.KubeVersion?.Equals(other.KubeVersion) == true)) &&
                ((this.OrganizationId == null && other.OrganizationId == null) || (this.OrganizationId?.Equals(other.OrganizationId) == true)) &&
                ((this.PartnerId == null && other.PartnerId == null) || (this.PartnerId?.Equals(other.PartnerId) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.ModifiedAt == null && other.ModifiedAt == null) || (this.ModifiedAt?.Equals(other.ModifiedAt) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.BehindLatestBy == null && other.BehindLatestBy == null) || (this.BehindLatestBy?.Equals(other.BehindLatestBy) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ClusterId = {(this.ClusterId == null ? "null" : this.ClusterId == string.Empty ? "" : this.ClusterId)}");
            toStringOutput.Add($"this.KubeVersion = {(this.KubeVersion == null ? "null" : this.KubeVersion == string.Empty ? "" : this.KubeVersion)}");
            toStringOutput.Add($"this.OrganizationId = {(this.OrganizationId == null ? "null" : this.OrganizationId == string.Empty ? "" : this.OrganizationId)}");
            toStringOutput.Add($"this.PartnerId = {(this.PartnerId == null ? "null" : this.PartnerId == string.Empty ? "" : this.PartnerId)}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt == string.Empty ? "" : this.CreatedAt)}");
            toStringOutput.Add($"this.ModifiedAt = {(this.ModifiedAt == null ? "null" : this.ModifiedAt == string.Empty ? "" : this.ModifiedAt)}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.BehindLatestBy = {(this.BehindLatestBy == null ? "null" : this.BehindLatestBy.ToString())}");
        }
    }
}