// <copyright file="AnomalyTriggerValue.cs" company="APIMatic">
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
    /// AnomalyTriggerValue.
    /// </summary>
    public class AnomalyTriggerValue
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnomalyTriggerValue"/> class.
        /// </summary>
        public AnomalyTriggerValue()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnomalyTriggerValue"/> class.
        /// </summary>
        /// <param name="triggerId">triggerId.</param>
        /// <param name="triggerName">triggerName.</param>
        /// <param name="organizationName">organizationName.</param>
        /// <param name="triggerCategory">triggerCategory.</param>
        /// <param name="triggerAttributes">triggerAttributes.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="modifiedAt">modifiedAt.</param>
        public AnomalyTriggerValue(
            string triggerId = null,
            string triggerName = null,
            string organizationName = null,
            string triggerCategory = null,
            List<Models.TriggerAttributesOptions> triggerAttributes = null,
            string createdAt = null,
            string modifiedAt = null)
        {
            this.TriggerId = triggerId;
            this.TriggerName = triggerName;
            this.OrganizationName = organizationName;
            this.TriggerCategory = triggerCategory;
            this.TriggerAttributes = triggerAttributes;
            this.CreatedAt = createdAt;
            this.ModifiedAt = modifiedAt;
        }

        /// <summary>
        /// The system assigned name of the trigger being updated.
        /// </summary>
        [JsonProperty("triggerId", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerId { get; set; }

        /// <summary>
        /// The user defined name of the trigger.
        /// </summary>
        [JsonProperty("triggerName", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerName { get; set; }

        /// <summary>
        /// The user assigned name of the organization associated with the trigger.
        /// </summary>
        [JsonProperty("organizationName", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationName { get; set; }

        /// <summary>
        /// This is the value to use in the request body to detect anomalous behaivior. The values in this table will only be relevant when this parameter is set to this value.
        /// </summary>
        [JsonProperty("triggerCategory", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerCategory { get; set; }

        /// <summary>
        /// Additional details and keys for the trigger.
        /// </summary>
        [JsonProperty("triggerAttributes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.TriggerAttributesOptions> TriggerAttributes { get; set; }

        /// <summary>
        /// Timestamp for whe the trigger was created.
        /// </summary>
        [JsonProperty("createdAt", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Timestamp for the most recent time the trigger was modified.
        /// </summary>
        [JsonProperty("modifiedAt", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedAt { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"AnomalyTriggerValue : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AnomalyTriggerValue other &&
                (this.TriggerId == null && other.TriggerId == null ||
                 this.TriggerId?.Equals(other.TriggerId) == true) &&
                (this.TriggerName == null && other.TriggerName == null ||
                 this.TriggerName?.Equals(other.TriggerName) == true) &&
                (this.OrganizationName == null && other.OrganizationName == null ||
                 this.OrganizationName?.Equals(other.OrganizationName) == true) &&
                (this.TriggerCategory == null && other.TriggerCategory == null ||
                 this.TriggerCategory?.Equals(other.TriggerCategory) == true) &&
                (this.TriggerAttributes == null && other.TriggerAttributes == null ||
                 this.TriggerAttributes?.Equals(other.TriggerAttributes) == true) &&
                (this.CreatedAt == null && other.CreatedAt == null ||
                 this.CreatedAt?.Equals(other.CreatedAt) == true) &&
                (this.ModifiedAt == null && other.ModifiedAt == null ||
                 this.ModifiedAt?.Equals(other.ModifiedAt) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"TriggerId = {this.TriggerId ?? "null"}");
            toStringOutput.Add($"TriggerName = {this.TriggerName ?? "null"}");
            toStringOutput.Add($"OrganizationName = {this.OrganizationName ?? "null"}");
            toStringOutput.Add($"TriggerCategory = {this.TriggerCategory ?? "null"}");
            toStringOutput.Add($"TriggerAttributes = {(this.TriggerAttributes == null ? "null" : $"[{string.Join(", ", this.TriggerAttributes)} ]")}");
            toStringOutput.Add($"CreatedAt = {this.CreatedAt ?? "null"}");
            toStringOutput.Add($"ModifiedAt = {this.ModifiedAt ?? "null"}");
        }
    }
}