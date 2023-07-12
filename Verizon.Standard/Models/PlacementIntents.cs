// <copyright file="PlacementIntents.cs" company="APIMatic">
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
    /// PlacementIntents.
    /// </summary>
    public class PlacementIntents
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlacementIntents"/> class.
        /// </summary>
        public PlacementIntents()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlacementIntents"/> class.
        /// </summary>
        /// <param name="isPlacementAtLaunchEnabled">isPlacementAtLaunchEnabled.</param>
        /// <param name="groupId">groupId.</param>
        /// <param name="intentChain">intentChain.</param>
        public PlacementIntents(
            bool? isPlacementAtLaunchEnabled = false,
            string groupId = null,
            List<Models.IntentChainItem> intentChain = null)
        {
            this.IsPlacementAtLaunchEnabled = isPlacementAtLaunchEnabled;
            this.GroupId = groupId;
            this.IntentChain = intentChain;
        }

        /// <summary>
        /// Gets or sets IsPlacementAtLaunchEnabled.
        /// </summary>
        [JsonProperty("isPlacementAtLaunchEnabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPlacementAtLaunchEnabled { get; set; }

        /// <summary>
        /// Gets or sets GroupId.
        /// </summary>
        [JsonProperty("groupId", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// Gets or sets IntentChain.
        /// </summary>
        [JsonProperty("intentChain", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.IntentChainItem> IntentChain { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PlacementIntents : ({string.Join(", ", toStringOutput)})";
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
            return obj is PlacementIntents other &&                ((this.IsPlacementAtLaunchEnabled == null && other.IsPlacementAtLaunchEnabled == null) || (this.IsPlacementAtLaunchEnabled?.Equals(other.IsPlacementAtLaunchEnabled) == true)) &&
                ((this.GroupId == null && other.GroupId == null) || (this.GroupId?.Equals(other.GroupId) == true)) &&
                ((this.IntentChain == null && other.IntentChain == null) || (this.IntentChain?.Equals(other.IntentChain) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.IsPlacementAtLaunchEnabled = {(this.IsPlacementAtLaunchEnabled == null ? "null" : this.IsPlacementAtLaunchEnabled.ToString())}");
            toStringOutput.Add($"this.GroupId = {(this.GroupId == null ? "null" : this.GroupId == string.Empty ? "" : this.GroupId)}");
            toStringOutput.Add($"this.IntentChain = {(this.IntentChain == null ? "null" : $"[{string.Join(", ", this.IntentChain)} ]")}");
        }
    }
}