// <copyright file="ClusterSpec.cs" company="APIMatic">
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
    /// ClusterSpec.
    /// </summary>
    public class ClusterSpec
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterSpec"/> class.
        /// </summary>
        public ClusterSpec()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterSpec"/> class.
        /// </summary>
        /// <param name="blueprintRef">blueprintRef.</param>
        /// <param name="overrideSelector">overrideSelector.</param>
        /// <param name="shareMode">shareMode.</param>
        public ClusterSpec(
            string blueprintRef = null,
            string overrideSelector = null,
            string shareMode = null)
        {
            this.BlueprintRef = blueprintRef;
            this.OverrideSelector = overrideSelector;
            this.ShareMode = shareMode;
        }

        /// <summary>
        /// Gets or sets BlueprintRef.
        /// </summary>
        [JsonProperty("blueprintRef", NullValueHandling = NullValueHandling.Ignore)]
        public string BlueprintRef { get; set; }

        /// <summary>
        /// Gets or sets OverrideSelector.
        /// </summary>
        [JsonProperty("overrideSelector", NullValueHandling = NullValueHandling.Ignore)]
        public string OverrideSelector { get; set; }

        /// <summary>
        /// Gets or sets ShareMode.
        /// </summary>
        [JsonProperty("shareMode", NullValueHandling = NullValueHandling.Ignore)]
        public string ShareMode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ClusterSpec : ({string.Join(", ", toStringOutput)})";
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
            return obj is ClusterSpec other &&                ((this.BlueprintRef == null && other.BlueprintRef == null) || (this.BlueprintRef?.Equals(other.BlueprintRef) == true)) &&
                ((this.OverrideSelector == null && other.OverrideSelector == null) || (this.OverrideSelector?.Equals(other.OverrideSelector) == true)) &&
                ((this.ShareMode == null && other.ShareMode == null) || (this.ShareMode?.Equals(other.ShareMode) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BlueprintRef = {(this.BlueprintRef == null ? "null" : this.BlueprintRef == string.Empty ? "" : this.BlueprintRef)}");
            toStringOutput.Add($"this.OverrideSelector = {(this.OverrideSelector == null ? "null" : this.OverrideSelector == string.Empty ? "" : this.OverrideSelector)}");
            toStringOutput.Add($"this.ShareMode = {(this.ShareMode == null ? "null" : this.ShareMode == string.Empty ? "" : this.ShareMode)}");
        }
    }
}