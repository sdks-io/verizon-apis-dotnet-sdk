// <copyright file="MECPlatformResource.cs" company="APIMatic">
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
    /// MECPlatformResource.
    /// </summary>
    public class MECPlatformResource
    {
        private string zone;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "zone", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="MECPlatformResource"/> class.
        /// </summary>
        public MECPlatformResource()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MECPlatformResource"/> class.
        /// </summary>
        /// <param name="ern">ern.</param>
        /// <param name="zone">zone.</param>
        /// <param name="region">region.</param>
        /// <param name="status">status.</param>
        /// <param name="properties">properties.</param>
        public MECPlatformResource(
            string ern = null,
            string zone = null,
            string region = null,
            Models.MECPlatformStatusEnum? status = Models.MECPlatformStatusEnum.Unknown,
            object properties = null)
        {
            this.Ern = ern;

            if (zone != null)
            {
                this.Zone = zone;
            }
            this.Region = region;
            this.Status = status;
            this.Properties = properties;
        }

        /// <summary>
        /// Edge Resource Name. A string identifier for a set of edge resources.
        /// </summary>
        [JsonProperty("ern", NullValueHandling = NullValueHandling.Ignore)]
        public string Ern { get; set; }

        /// <summary>
        /// Unique identifier representing a zone. *Note:* This will have a null value as a placeholder.
        /// </summary>
        [JsonProperty("zone")]
        public string Zone
        {
            get
            {
                return this.zone;
            }

            set
            {
                this.shouldSerialize["zone"] = true;
                this.zone = value;
            }
        }

        /// <summary>
        /// MEC region name. Current valid values are US_WEST_2 and US_EAST_1.
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// Status of the MEC Platform (default is 'unknown')
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MECPlatformStatusEnum? Status { get; set; }

        /// <summary>
        /// Gets or sets Properties.
        /// </summary>
        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public object Properties { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"MECPlatformResource : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetZone()
        {
            this.shouldSerialize["zone"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeZone()
        {
            return this.shouldSerialize["zone"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is MECPlatformResource other &&
                (this.Ern == null && other.Ern == null ||
                 this.Ern?.Equals(other.Ern) == true) &&
                (this.Zone == null && other.Zone == null ||
                 this.Zone?.Equals(other.Zone) == true) &&
                (this.Region == null && other.Region == null ||
                 this.Region?.Equals(other.Region) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.Properties == null && other.Properties == null ||
                 this.Properties?.Equals(other.Properties) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Ern = {this.Ern ?? "null"}");
            toStringOutput.Add($"Zone = {this.Zone ?? "null"}");
            toStringOutput.Add($"Region = {this.Region ?? "null"}");
            toStringOutput.Add($"Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"Properties = {(this.Properties == null ? "null" : this.Properties.ToString())}");
        }
    }
}