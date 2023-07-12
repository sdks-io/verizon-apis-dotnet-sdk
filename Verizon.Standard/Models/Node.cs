// <copyright file="Node.cs" company="APIMatic">
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
    /// Node.
    /// </summary>
    public class Node
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// </summary>
        public Node()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="modifiedAt">modified_at.</param>
        /// <param name="nodeId">node_id.</param>
        /// <param name="privateIp">private_ip.</param>
        /// <param name="numCores">num_cores.</param>
        /// <param name="totalMemory">total_memory.</param>
        /// <param name="clusterId">cluster_id.</param>
        /// <param name="roles">roles.</param>
        /// <param name="id">id.</param>
        /// <param name="approved">approved.</param>
        /// <param name="status">status.</param>
        public Node(
            string name = null,
            string createdAt = null,
            string modifiedAt = null,
            string nodeId = null,
            string privateIp = null,
            int? numCores = null,
            int? totalMemory = null,
            string clusterId = null,
            List<string> roles = null,
            string id = null,
            bool? approved = null,
            string status = null)
        {
            this.Name = name;
            this.CreatedAt = createdAt;
            this.ModifiedAt = modifiedAt;
            this.NodeId = nodeId;
            this.PrivateIp = privateIp;
            this.NumCores = numCores;
            this.TotalMemory = totalMemory;
            this.ClusterId = clusterId;
            this.Roles = roles;
            this.Id = id;
            this.Approved = approved;
            this.Status = status;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

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
        /// Gets or sets NodeId.
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// Gets or sets PrivateIp.
        /// </summary>
        [JsonProperty("private_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateIp { get; set; }

        /// <summary>
        /// Gets or sets NumCores.
        /// </summary>
        [JsonProperty("num_cores", NullValueHandling = NullValueHandling.Ignore)]
        public int? NumCores { get; set; }

        /// <summary>
        /// Gets or sets TotalMemory.
        /// </summary>
        [JsonProperty("total_memory", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalMemory { get; set; }

        /// <summary>
        /// Gets or sets ClusterId.
        /// </summary>
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }

        /// <summary>
        /// Gets or sets Roles.
        /// </summary>
        [JsonProperty("roles", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Roles { get; set; }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets Approved.
        /// </summary>
        [JsonProperty("approved", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Approved { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Node : ({string.Join(", ", toStringOutput)})";
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
            return obj is Node other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.ModifiedAt == null && other.ModifiedAt == null) || (this.ModifiedAt?.Equals(other.ModifiedAt) == true)) &&
                ((this.NodeId == null && other.NodeId == null) || (this.NodeId?.Equals(other.NodeId) == true)) &&
                ((this.PrivateIp == null && other.PrivateIp == null) || (this.PrivateIp?.Equals(other.PrivateIp) == true)) &&
                ((this.NumCores == null && other.NumCores == null) || (this.NumCores?.Equals(other.NumCores) == true)) &&
                ((this.TotalMemory == null && other.TotalMemory == null) || (this.TotalMemory?.Equals(other.TotalMemory) == true)) &&
                ((this.ClusterId == null && other.ClusterId == null) || (this.ClusterId?.Equals(other.ClusterId) == true)) &&
                ((this.Roles == null && other.Roles == null) || (this.Roles?.Equals(other.Roles) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Approved == null && other.Approved == null) || (this.Approved?.Equals(other.Approved) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt == string.Empty ? "" : this.CreatedAt)}");
            toStringOutput.Add($"this.ModifiedAt = {(this.ModifiedAt == null ? "null" : this.ModifiedAt == string.Empty ? "" : this.ModifiedAt)}");
            toStringOutput.Add($"this.NodeId = {(this.NodeId == null ? "null" : this.NodeId == string.Empty ? "" : this.NodeId)}");
            toStringOutput.Add($"this.PrivateIp = {(this.PrivateIp == null ? "null" : this.PrivateIp == string.Empty ? "" : this.PrivateIp)}");
            toStringOutput.Add($"this.NumCores = {(this.NumCores == null ? "null" : this.NumCores.ToString())}");
            toStringOutput.Add($"this.TotalMemory = {(this.TotalMemory == null ? "null" : this.TotalMemory.ToString())}");
            toStringOutput.Add($"this.ClusterId = {(this.ClusterId == null ? "null" : this.ClusterId == string.Empty ? "" : this.ClusterId)}");
            toStringOutput.Add($"this.Roles = {(this.Roles == null ? "null" : $"[{string.Join(", ", this.Roles)} ]")}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.Approved = {(this.Approved == null ? "null" : this.Approved.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
        }
    }
}