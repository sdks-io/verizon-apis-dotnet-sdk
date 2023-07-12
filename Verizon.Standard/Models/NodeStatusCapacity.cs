// <copyright file="NodeStatusCapacity.cs" company="APIMatic">
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
    /// NodeStatusCapacity.
    /// </summary>
    public class NodeStatusCapacity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeStatusCapacity"/> class.
        /// </summary>
        public NodeStatusCapacity()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeStatusCapacity"/> class.
        /// </summary>
        /// <param name="cpuCount">cpuCount.</param>
        /// <param name="ephemeralStorageKB">ephemeralStorageKB.</param>
        /// <param name="memoryKB">memoryKB.</param>
        public NodeStatusCapacity(
            int? cpuCount = null,
            long? ephemeralStorageKB = null,
            long? memoryKB = null)
        {
            this.CpuCount = cpuCount;
            this.EphemeralStorageKB = ephemeralStorageKB;
            this.MemoryKB = memoryKB;
        }

        /// <summary>
        /// Gets or sets CpuCount.
        /// </summary>
        [JsonProperty("cpuCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? CpuCount { get; set; }

        /// <summary>
        /// Gets or sets EphemeralStorageKB.
        /// </summary>
        [JsonProperty("ephemeralStorageKB", NullValueHandling = NullValueHandling.Ignore)]
        public long? EphemeralStorageKB { get; set; }

        /// <summary>
        /// Gets or sets MemoryKB.
        /// </summary>
        [JsonProperty("memoryKB", NullValueHandling = NullValueHandling.Ignore)]
        public long? MemoryKB { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"NodeStatusCapacity : ({string.Join(", ", toStringOutput)})";
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
            return obj is NodeStatusCapacity other &&                ((this.CpuCount == null && other.CpuCount == null) || (this.CpuCount?.Equals(other.CpuCount) == true)) &&
                ((this.EphemeralStorageKB == null && other.EphemeralStorageKB == null) || (this.EphemeralStorageKB?.Equals(other.EphemeralStorageKB) == true)) &&
                ((this.MemoryKB == null && other.MemoryKB == null) || (this.MemoryKB?.Equals(other.MemoryKB) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CpuCount = {(this.CpuCount == null ? "null" : this.CpuCount.ToString())}");
            toStringOutput.Add($"this.EphemeralStorageKB = {(this.EphemeralStorageKB == null ? "null" : this.EphemeralStorageKB.ToString())}");
            toStringOutput.Add($"this.MemoryKB = {(this.MemoryKB == null ? "null" : this.MemoryKB.ToString())}");
        }
    }
}