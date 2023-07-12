// <copyright file="NodeStatusItem.cs" company="APIMatic">
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
    /// NodeStatusItem.
    /// </summary>
    public class NodeStatusItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeStatusItem"/> class.
        /// </summary>
        public NodeStatusItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeStatusItem"/> class.
        /// </summary>
        /// <param name="metadata">metadata.</param>
        /// <param name="spec">spec.</param>
        /// <param name="status">status.</param>
        public NodeStatusItem(
            Models.Metadata metadata = null,
            Models.ServiceLaunchClusterAdditionalParams spec = null,
            Models.NodeStatus status = null)
        {
            this.Metadata = metadata;
            this.Spec = spec;
            this.Status = status;
        }

        /// <summary>
        /// Gets or sets Metadata.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Metadata Metadata { get; set; }

        /// <summary>
        /// Gets or sets Spec.
        /// </summary>
        [JsonProperty("spec", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ServiceLaunchClusterAdditionalParams Spec { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.NodeStatus Status { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"NodeStatusItem : ({string.Join(", ", toStringOutput)})";
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
            return obj is NodeStatusItem other &&                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.Spec == null && other.Spec == null) || (this.Spec?.Equals(other.Spec) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.Spec = {(this.Spec == null ? "null" : this.Spec.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
        }
    }
}