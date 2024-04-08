// <copyright file="ComputeResourcesType.cs" company="APIMatic">
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
    using APIMatic.Core.Utilities.Converters;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Verizon.Standard;
    using Verizon.Standard.Utilities;

    /// <summary>
    /// ComputeResourcesType.
    /// </summary>
    public class ComputeResourcesType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComputeResourcesType"/> class.
        /// </summary>
        public ComputeResourcesType()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputeResourcesType"/> class.
        /// </summary>
        /// <param name="gPU">GPU.</param>
        /// <param name="minRAMGB">minRAMGB.</param>
        /// <param name="minStorageGB">minStorageGB.</param>
        public ComputeResourcesType(
            Models.GPU gPU = null,
            int? minRAMGB = null,
            int? minStorageGB = null)
        {
            this.GPU = gPU;
            this.MinRAMGB = minRAMGB;
            this.MinStorageGB = minStorageGB;
        }

        /// <summary>
        /// GPU resources of a service profile.
        /// </summary>
        [JsonProperty("GPU", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GPU GPU { get; set; }

        /// <summary>
        /// Minimum RAM required in Gigabytes.
        /// </summary>
        [JsonProperty("minRAMGB", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinRAMGB { get; set; }

        /// <summary>
        /// Minimum storage requirement in Gigabytes.
        /// </summary>
        [JsonProperty("minStorageGB", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinStorageGB { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ComputeResourcesType : ({string.Join(", ", toStringOutput)})";
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
            return obj is ComputeResourcesType other &&                ((this.GPU == null && other.GPU == null) || (this.GPU?.Equals(other.GPU) == true)) &&
                ((this.MinRAMGB == null && other.MinRAMGB == null) || (this.MinRAMGB?.Equals(other.MinRAMGB) == true)) &&
                ((this.MinStorageGB == null && other.MinStorageGB == null) || (this.MinStorageGB?.Equals(other.MinStorageGB) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.GPU = {(this.GPU == null ? "null" : this.GPU.ToString())}");
            toStringOutput.Add($"this.MinRAMGB = {(this.MinRAMGB == null ? "null" : this.MinRAMGB.ToString())}");
            toStringOutput.Add($"this.MinStorageGB = {(this.MinStorageGB == null ? "null" : this.MinStorageGB.ToString())}");
        }
    }
}