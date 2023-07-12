// <copyright file="NodeStatusAllocated.cs" company="APIMatic">
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
    /// NodeStatusAllocated.
    /// </summary>
    public class NodeStatusAllocated
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeStatusAllocated"/> class.
        /// </summary>
        public NodeStatusAllocated()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeStatusAllocated"/> class.
        /// </summary>
        /// <param name="cpuCount">cpuCount.</param>
        /// <param name="memoryKB">memoryKB.</param>
        public NodeStatusAllocated(
            int? cpuCount = null,
            int? memoryKB = null)
        {
            this.CpuCount = cpuCount;
            this.MemoryKB = memoryKB;
        }

        /// <summary>
        /// Gets or sets CpuCount.
        /// </summary>
        [JsonProperty("cpuCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? CpuCount { get; set; }

        /// <summary>
        /// Gets or sets MemoryKB.
        /// </summary>
        [JsonProperty("memoryKB", NullValueHandling = NullValueHandling.Ignore)]
        public int? MemoryKB { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"NodeStatusAllocated : ({string.Join(", ", toStringOutput)})";
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
            return obj is NodeStatusAllocated other &&                ((this.CpuCount == null && other.CpuCount == null) || (this.CpuCount?.Equals(other.CpuCount) == true)) &&
                ((this.MemoryKB == null && other.MemoryKB == null) || (this.MemoryKB?.Equals(other.MemoryKB) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CpuCount = {(this.CpuCount == null ? "null" : this.CpuCount.ToString())}");
            toStringOutput.Add($"this.MemoryKB = {(this.MemoryKB == null ? "null" : this.MemoryKB.ToString())}");
        }
    }
}