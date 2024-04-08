// <copyright file="TriggersListOptions.cs" company="APIMatic">
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
    /// TriggersListOptions.
    /// </summary>
    public class TriggersListOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TriggersListOptions"/> class.
        /// </summary>
        public TriggersListOptions()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggersListOptions"/> class.
        /// </summary>
        /// <param name="triggerId">triggerId.</param>
        /// <param name="triggerName">triggerName.</param>
        /// <param name="organizationName">organizationName.</param>
        /// <param name="triggerCategory">triggerCategory.</param>
        /// <param name="triggerAttributes">triggerAttributes.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="modifiedAt">modifiedAt.</param>
        /// <param name="anomalyattributes">anomalyattributes.</param>
        /// <param name="notification">notification.</param>
        public TriggersListOptions(
            string triggerId = null,
            string triggerName = null,
            string organizationName = null,
            string triggerCategory = null,
            List<Models.TriggerAttributesOptions> triggerAttributes = null,
            string createdAt = null,
            string modifiedAt = null,
            Models.UsageAnomalyAttributes anomalyattributes = null,
            Models.Notification notification = null)
        {
            this.TriggerId = triggerId;
            this.TriggerName = triggerName;
            this.OrganizationName = organizationName;
            this.TriggerCategory = triggerCategory;
            this.TriggerAttributes = triggerAttributes;
            this.CreatedAt = createdAt;
            this.ModifiedAt = modifiedAt;
            this.Anomalyattributes = anomalyattributes;
            this.Notification = notification;
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

        /// <summary>
        /// The details of the UsageAnomaly trigger.
        /// </summary>
        [JsonProperty("anomalyattributes", NullValueHandling = NullValueHandling.Ignore)]
        public Models.UsageAnomalyAttributes Anomalyattributes { get; set; }

        /// <summary>
        /// The notification details of the trigger.
        /// </summary>
        [JsonProperty("notification", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Notification Notification { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TriggersListOptions : ({string.Join(", ", toStringOutput)})";
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
            return obj is TriggersListOptions other &&                ((this.TriggerId == null && other.TriggerId == null) || (this.TriggerId?.Equals(other.TriggerId) == true)) &&
                ((this.TriggerName == null && other.TriggerName == null) || (this.TriggerName?.Equals(other.TriggerName) == true)) &&
                ((this.OrganizationName == null && other.OrganizationName == null) || (this.OrganizationName?.Equals(other.OrganizationName) == true)) &&
                ((this.TriggerCategory == null && other.TriggerCategory == null) || (this.TriggerCategory?.Equals(other.TriggerCategory) == true)) &&
                ((this.TriggerAttributes == null && other.TriggerAttributes == null) || (this.TriggerAttributes?.Equals(other.TriggerAttributes) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.ModifiedAt == null && other.ModifiedAt == null) || (this.ModifiedAt?.Equals(other.ModifiedAt) == true)) &&
                ((this.Anomalyattributes == null && other.Anomalyattributes == null) || (this.Anomalyattributes?.Equals(other.Anomalyattributes) == true)) &&
                ((this.Notification == null && other.Notification == null) || (this.Notification?.Equals(other.Notification) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TriggerId = {(this.TriggerId == null ? "null" : this.TriggerId)}");
            toStringOutput.Add($"this.TriggerName = {(this.TriggerName == null ? "null" : this.TriggerName)}");
            toStringOutput.Add($"this.OrganizationName = {(this.OrganizationName == null ? "null" : this.OrganizationName)}");
            toStringOutput.Add($"this.TriggerCategory = {(this.TriggerCategory == null ? "null" : this.TriggerCategory)}");
            toStringOutput.Add($"this.TriggerAttributes = {(this.TriggerAttributes == null ? "null" : $"[{string.Join(", ", this.TriggerAttributes)} ]")}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt)}");
            toStringOutput.Add($"this.ModifiedAt = {(this.ModifiedAt == null ? "null" : this.ModifiedAt)}");
            toStringOutput.Add($"this.Anomalyattributes = {(this.Anomalyattributes == null ? "null" : this.Anomalyattributes.ToString())}");
            toStringOutput.Add($"this.Notification = {(this.Notification == null ? "null" : this.Notification.ToString())}");
        }
    }
}