// <copyright file="GPU.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Verizon.Standard;
using Verizon.Standard.Utilities;

namespace Verizon.Standard.Models
{
    /// <summary>
    /// GPU.
    /// </summary>
    public class GPU
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GPU"/> class.
        /// </summary>
        public GPU()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GPU"/> class.
        /// </summary>
        /// <param name="minCoreClockMHz">minCoreClockMHz.</param>
        /// <param name="minMemoryClockMHz">minMemoryClockMHz.</param>
        /// <param name="minBandwidthGBs">minBandwidthGBs.</param>
        /// <param name="minTFLOPS">minTFLOPS.</param>
        public GPU(
            int? minCoreClockMHz = null,
            int? minMemoryClockMHz = null,
            int? minBandwidthGBs = null,
            int? minTFLOPS = null)
        {
            this.MinCoreClockMHz = minCoreClockMHz;
            this.MinMemoryClockMHz = minMemoryClockMHz;
            this.MinBandwidthGBs = minBandwidthGBs;
            this.MinTFLOPS = minTFLOPS;
        }

        /// <summary>
        /// Minimum Core Clock value in megahertz.
        /// </summary>
        [JsonProperty("minCoreClockMHz", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinCoreClockMHz { get; set; }

        /// <summary>
        /// Minimum Memory Clock value in megahertz.
        /// </summary>
        [JsonProperty("minMemoryClockMHz", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinMemoryClockMHz { get; set; }

        /// <summary>
        /// Minimum GPU bandwidth in GB/s.
        /// </summary>
        [JsonProperty("minBandwidthGBs", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinBandwidthGBs { get; set; }

        /// <summary>
        /// Minimum Floating Point Operations Per Second in Teraflops.
        /// </summary>
        [JsonProperty("minTFLOPS", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinTFLOPS { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GPU : ({string.Join(", ", toStringOutput)})";
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
            return obj is GPU other &&                ((this.MinCoreClockMHz == null && other.MinCoreClockMHz == null) || (this.MinCoreClockMHz?.Equals(other.MinCoreClockMHz) == true)) &&
                ((this.MinMemoryClockMHz == null && other.MinMemoryClockMHz == null) || (this.MinMemoryClockMHz?.Equals(other.MinMemoryClockMHz) == true)) &&
                ((this.MinBandwidthGBs == null && other.MinBandwidthGBs == null) || (this.MinBandwidthGBs?.Equals(other.MinBandwidthGBs) == true)) &&
                ((this.MinTFLOPS == null && other.MinTFLOPS == null) || (this.MinTFLOPS?.Equals(other.MinTFLOPS) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MinCoreClockMHz = {(this.MinCoreClockMHz == null ? "null" : this.MinCoreClockMHz.ToString())}");
            toStringOutput.Add($"this.MinMemoryClockMHz = {(this.MinMemoryClockMHz == null ? "null" : this.MinMemoryClockMHz.ToString())}");
            toStringOutput.Add($"this.MinBandwidthGBs = {(this.MinBandwidthGBs == null ? "null" : this.MinBandwidthGBs.ToString())}");
            toStringOutput.Add($"this.MinTFLOPS = {(this.MinTFLOPS == null ? "null" : this.MinTFLOPS.ToString())}");
        }
    }
}