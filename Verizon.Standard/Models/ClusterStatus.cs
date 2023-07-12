// <copyright file="ClusterStatus.cs" company="APIMatic">
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
    /// ClusterStatus.
    /// </summary>
    public class ClusterStatus
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterStatus"/> class.
        /// </summary>
        public ClusterStatus()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterStatus"/> class.
        /// </summary>
        /// <param name="conditions">conditions.</param>
        /// <param name="token">token.</param>
        /// <param name="publishedBlueprint">publishedBlueprint.</param>
        /// <param name="nodes">nodes.</param>
        /// <param name="systemTaskCount">systemTaskCount.</param>
        /// <param name="customTaskCount">customTaskCount.</param>
        /// <param name="auxiliaryTaskCount">auxiliaryTaskCount.</param>
        /// <param name="projects">projects.</param>
        /// <param name="extra">extra.</param>
        public ClusterStatus(
            List<Models.ConditionItem> conditions = null,
            string token = null,
            string publishedBlueprint = null,
            List<Models.NodeStatusItem> nodes = null,
            int? systemTaskCount = null,
            int? customTaskCount = null,
            int? auxiliaryTaskCount = null,
            List<Models.StatusProjectItem> projects = null,
            Models.ClusterStatusExtra extra = null)
        {
            this.Conditions = conditions;
            this.Token = token;
            this.PublishedBlueprint = publishedBlueprint;
            this.Nodes = nodes;
            this.SystemTaskCount = systemTaskCount;
            this.CustomTaskCount = customTaskCount;
            this.AuxiliaryTaskCount = auxiliaryTaskCount;
            this.Projects = projects;
            this.Extra = extra;
        }

        /// <summary>
        /// Gets or sets Conditions.
        /// </summary>
        [JsonProperty("conditions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ConditionItem> Conditions { get; set; }

        /// <summary>
        /// Gets or sets Token.
        /// </summary>
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        /// <summary>
        /// Gets or sets PublishedBlueprint.
        /// </summary>
        [JsonProperty("publishedBlueprint", NullValueHandling = NullValueHandling.Ignore)]
        public string PublishedBlueprint { get; set; }

        /// <summary>
        /// Gets or sets Nodes.
        /// </summary>
        [JsonProperty("nodes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.NodeStatusItem> Nodes { get; set; }

        /// <summary>
        /// Gets or sets SystemTaskCount.
        /// </summary>
        [JsonProperty("systemTaskCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? SystemTaskCount { get; set; }

        /// <summary>
        /// Gets or sets CustomTaskCount.
        /// </summary>
        [JsonProperty("customTaskCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? CustomTaskCount { get; set; }

        /// <summary>
        /// Gets or sets AuxiliaryTaskCount.
        /// </summary>
        [JsonProperty("auxiliaryTaskCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? AuxiliaryTaskCount { get; set; }

        /// <summary>
        /// Gets or sets Projects.
        /// </summary>
        [JsonProperty("projects", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.StatusProjectItem> Projects { get; set; }

        /// <summary>
        /// Gets or sets Extra.
        /// </summary>
        [JsonProperty("extra", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ClusterStatusExtra Extra { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ClusterStatus : ({string.Join(", ", toStringOutput)})";
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
            return obj is ClusterStatus other &&                ((this.Conditions == null && other.Conditions == null) || (this.Conditions?.Equals(other.Conditions) == true)) &&
                ((this.Token == null && other.Token == null) || (this.Token?.Equals(other.Token) == true)) &&
                ((this.PublishedBlueprint == null && other.PublishedBlueprint == null) || (this.PublishedBlueprint?.Equals(other.PublishedBlueprint) == true)) &&
                ((this.Nodes == null && other.Nodes == null) || (this.Nodes?.Equals(other.Nodes) == true)) &&
                ((this.SystemTaskCount == null && other.SystemTaskCount == null) || (this.SystemTaskCount?.Equals(other.SystemTaskCount) == true)) &&
                ((this.CustomTaskCount == null && other.CustomTaskCount == null) || (this.CustomTaskCount?.Equals(other.CustomTaskCount) == true)) &&
                ((this.AuxiliaryTaskCount == null && other.AuxiliaryTaskCount == null) || (this.AuxiliaryTaskCount?.Equals(other.AuxiliaryTaskCount) == true)) &&
                ((this.Projects == null && other.Projects == null) || (this.Projects?.Equals(other.Projects) == true)) &&
                ((this.Extra == null && other.Extra == null) || (this.Extra?.Equals(other.Extra) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Conditions = {(this.Conditions == null ? "null" : $"[{string.Join(", ", this.Conditions)} ]")}");
            toStringOutput.Add($"this.Token = {(this.Token == null ? "null" : this.Token == string.Empty ? "" : this.Token)}");
            toStringOutput.Add($"this.PublishedBlueprint = {(this.PublishedBlueprint == null ? "null" : this.PublishedBlueprint == string.Empty ? "" : this.PublishedBlueprint)}");
            toStringOutput.Add($"this.Nodes = {(this.Nodes == null ? "null" : $"[{string.Join(", ", this.Nodes)} ]")}");
            toStringOutput.Add($"this.SystemTaskCount = {(this.SystemTaskCount == null ? "null" : this.SystemTaskCount.ToString())}");
            toStringOutput.Add($"this.CustomTaskCount = {(this.CustomTaskCount == null ? "null" : this.CustomTaskCount.ToString())}");
            toStringOutput.Add($"this.AuxiliaryTaskCount = {(this.AuxiliaryTaskCount == null ? "null" : this.AuxiliaryTaskCount.ToString())}");
            toStringOutput.Add($"this.Projects = {(this.Projects == null ? "null" : $"[{string.Join(", ", this.Projects)} ]")}");
            toStringOutput.Add($"this.Extra = {(this.Extra == null ? "null" : this.Extra.ToString())}");
        }
    }
}