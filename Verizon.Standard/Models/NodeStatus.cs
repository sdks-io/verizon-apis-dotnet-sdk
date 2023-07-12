// <copyright file="NodeStatus.cs" company="APIMatic">
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
    /// NodeStatus.
    /// </summary>
    public class NodeStatus
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeStatus"/> class.
        /// </summary>
        public NodeStatus()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeStatus"/> class.
        /// </summary>
        /// <param name="state">state.</param>
        /// <param name="conditions">conditions.</param>
        /// <param name="nodeInfo">nodeInfo.</param>
        /// <param name="capacity">capacity.</param>
        /// <param name="allocatable">allocatable.</param>
        /// <param name="allocated">allocated.</param>
        /// <param name="ips">ips.</param>
        public NodeStatus(
            string state = null,
            List<Models.StatusConditionItem> conditions = null,
            Models.NodeStatusInfo nodeInfo = null,
            Models.NodeStatusCapacity capacity = null,
            Models.NodeStatusAllocatable allocatable = null,
            Models.NodeStatusAllocated allocated = null,
            List<Models.IP> ips = null)
        {
            this.State = state;
            this.Conditions = conditions;
            this.NodeInfo = nodeInfo;
            this.Capacity = capacity;
            this.Allocatable = allocatable;
            this.Allocated = allocated;
            this.Ips = ips;
        }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets Conditions.
        /// </summary>
        [JsonProperty("conditions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.StatusConditionItem> Conditions { get; set; }

        /// <summary>
        /// Gets or sets NodeInfo.
        /// </summary>
        [JsonProperty("nodeInfo", NullValueHandling = NullValueHandling.Ignore)]
        public Models.NodeStatusInfo NodeInfo { get; set; }

        /// <summary>
        /// Gets or sets Capacity.
        /// </summary>
        [JsonProperty("capacity", NullValueHandling = NullValueHandling.Ignore)]
        public Models.NodeStatusCapacity Capacity { get; set; }

        /// <summary>
        /// Gets or sets Allocatable.
        /// </summary>
        [JsonProperty("allocatable", NullValueHandling = NullValueHandling.Ignore)]
        public Models.NodeStatusAllocatable Allocatable { get; set; }

        /// <summary>
        /// Gets or sets Allocated.
        /// </summary>
        [JsonProperty("allocated", NullValueHandling = NullValueHandling.Ignore)]
        public Models.NodeStatusAllocated Allocated { get; set; }

        /// <summary>
        /// Gets or sets Ips.
        /// </summary>
        [JsonProperty("ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.IP> Ips { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"NodeStatus : ({string.Join(", ", toStringOutput)})";
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
            return obj is NodeStatus other &&                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.Conditions == null && other.Conditions == null) || (this.Conditions?.Equals(other.Conditions) == true)) &&
                ((this.NodeInfo == null && other.NodeInfo == null) || (this.NodeInfo?.Equals(other.NodeInfo) == true)) &&
                ((this.Capacity == null && other.Capacity == null) || (this.Capacity?.Equals(other.Capacity) == true)) &&
                ((this.Allocatable == null && other.Allocatable == null) || (this.Allocatable?.Equals(other.Allocatable) == true)) &&
                ((this.Allocated == null && other.Allocated == null) || (this.Allocated?.Equals(other.Allocated) == true)) &&
                ((this.Ips == null && other.Ips == null) || (this.Ips?.Equals(other.Ips) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State == string.Empty ? "" : this.State)}");
            toStringOutput.Add($"this.Conditions = {(this.Conditions == null ? "null" : $"[{string.Join(", ", this.Conditions)} ]")}");
            toStringOutput.Add($"this.NodeInfo = {(this.NodeInfo == null ? "null" : this.NodeInfo.ToString())}");
            toStringOutput.Add($"this.Capacity = {(this.Capacity == null ? "null" : this.Capacity.ToString())}");
            toStringOutput.Add($"this.Allocatable = {(this.Allocatable == null ? "null" : this.Allocatable.ToString())}");
            toStringOutput.Add($"this.Allocated = {(this.Allocated == null ? "null" : this.Allocated.ToString())}");
            toStringOutput.Add($"this.Ips = {(this.Ips == null ? "null" : $"[{string.Join(", ", this.Ips)} ]")}");
        }
    }
}