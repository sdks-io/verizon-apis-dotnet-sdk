// <copyright file="ConditionItem.cs" company="APIMatic">
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
    /// ConditionItem.
    /// </summary>
    public class ConditionItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionItem"/> class.
        /// </summary>
        public ConditionItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionItem"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="status">status.</param>
        /// <param name="lastUpdated">lastUpdated.</param>
        /// <param name="reason">reason.</param>
        public ConditionItem(
            string type = null,
            string status = null,
            string lastUpdated = null,
            string reason = null)
        {
            this.Type = type;
            this.Status = status;
            this.LastUpdated = lastUpdated;
            this.Reason = reason;
        }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets LastUpdated.
        /// </summary>
        [JsonProperty("lastUpdated", NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdated { get; set; }

        /// <summary>
        /// Gets or sets Reason.
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ConditionItem : ({string.Join(", ", toStringOutput)})";
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
            return obj is ConditionItem other &&                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.LastUpdated == null && other.LastUpdated == null) || (this.LastUpdated?.Equals(other.LastUpdated) == true)) &&
                ((this.Reason == null && other.Reason == null) || (this.Reason?.Equals(other.Reason) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.LastUpdated = {(this.LastUpdated == null ? "null" : this.LastUpdated == string.Empty ? "" : this.LastUpdated)}");
            toStringOutput.Add($"this.Reason = {(this.Reason == null ? "null" : this.Reason == string.Empty ? "" : this.Reason)}");
        }
    }
}