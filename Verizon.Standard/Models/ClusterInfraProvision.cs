// <copyright file="ClusterInfraProvision.cs" company="APIMatic">
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
    /// ClusterInfraProvision.
    /// </summary>
    public class ClusterInfraProvision
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterInfraProvision"/> class.
        /// </summary>
        public ClusterInfraProvision()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterInfraProvision"/> class.
        /// </summary>
        /// <param name="clusterId">cluster_id.</param>
        /// <param name="provisionId">provision_id.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="modifiedAt">modified_at.</param>
        /// <param name="organizationId">organization_id.</param>
        /// <param name="partnerId">partner_id.</param>
        /// <param name="type">type.</param>
        /// <param name="runningState">running_state.</param>
        /// <param name="runningStatus">running_status.</param>
        /// <param name="id">id.</param>
        /// <param name="status">status.</param>
        /// <param name="totalSteps">total_steps.</param>
        public ClusterInfraProvision(
            string clusterId = null,
            string provisionId = null,
            string createdAt = null,
            string modifiedAt = null,
            string organizationId = null,
            string partnerId = null,
            string type = null,
            string runningState = null,
            string runningStatus = null,
            string id = null,
            string status = null,
            int? totalSteps = null)
        {
            this.ClusterId = clusterId;
            this.ProvisionId = provisionId;
            this.CreatedAt = createdAt;
            this.ModifiedAt = modifiedAt;
            this.OrganizationId = organizationId;
            this.PartnerId = partnerId;
            this.Type = type;
            this.RunningState = runningState;
            this.RunningStatus = runningStatus;
            this.Id = id;
            this.Status = status;
            this.TotalSteps = totalSteps;
        }

        /// <summary>
        /// Gets or sets ClusterId.
        /// </summary>
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }

        /// <summary>
        /// Gets or sets ProvisionId.
        /// </summary>
        [JsonProperty("provision_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProvisionId { get; set; }

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
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets RunningState.
        /// </summary>
        [JsonProperty("running_state", NullValueHandling = NullValueHandling.Ignore)]
        public string RunningState { get; set; }

        /// <summary>
        /// Gets or sets RunningStatus.
        /// </summary>
        [JsonProperty("running_status", NullValueHandling = NullValueHandling.Ignore)]
        public string RunningStatus { get; set; }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets TotalSteps.
        /// </summary>
        [JsonProperty("total_steps", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalSteps { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ClusterInfraProvision : ({string.Join(", ", toStringOutput)})";
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
            return obj is ClusterInfraProvision other &&                ((this.ClusterId == null && other.ClusterId == null) || (this.ClusterId?.Equals(other.ClusterId) == true)) &&
                ((this.ProvisionId == null && other.ProvisionId == null) || (this.ProvisionId?.Equals(other.ProvisionId) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.ModifiedAt == null && other.ModifiedAt == null) || (this.ModifiedAt?.Equals(other.ModifiedAt) == true)) &&
                ((this.OrganizationId == null && other.OrganizationId == null) || (this.OrganizationId?.Equals(other.OrganizationId) == true)) &&
                ((this.PartnerId == null && other.PartnerId == null) || (this.PartnerId?.Equals(other.PartnerId) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.RunningState == null && other.RunningState == null) || (this.RunningState?.Equals(other.RunningState) == true)) &&
                ((this.RunningStatus == null && other.RunningStatus == null) || (this.RunningStatus?.Equals(other.RunningStatus) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.TotalSteps == null && other.TotalSteps == null) || (this.TotalSteps?.Equals(other.TotalSteps) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ClusterId = {(this.ClusterId == null ? "null" : this.ClusterId == string.Empty ? "" : this.ClusterId)}");
            toStringOutput.Add($"this.ProvisionId = {(this.ProvisionId == null ? "null" : this.ProvisionId == string.Empty ? "" : this.ProvisionId)}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt == string.Empty ? "" : this.CreatedAt)}");
            toStringOutput.Add($"this.ModifiedAt = {(this.ModifiedAt == null ? "null" : this.ModifiedAt == string.Empty ? "" : this.ModifiedAt)}");
            toStringOutput.Add($"this.OrganizationId = {(this.OrganizationId == null ? "null" : this.OrganizationId == string.Empty ? "" : this.OrganizationId)}");
            toStringOutput.Add($"this.PartnerId = {(this.PartnerId == null ? "null" : this.PartnerId == string.Empty ? "" : this.PartnerId)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
            toStringOutput.Add($"this.RunningState = {(this.RunningState == null ? "null" : this.RunningState == string.Empty ? "" : this.RunningState)}");
            toStringOutput.Add($"this.RunningStatus = {(this.RunningStatus == null ? "null" : this.RunningStatus == string.Empty ? "" : this.RunningStatus)}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.TotalSteps = {(this.TotalSteps == null ? "null" : this.TotalSteps.ToString())}");
        }
    }
}