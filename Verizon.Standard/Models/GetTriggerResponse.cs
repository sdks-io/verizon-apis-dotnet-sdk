// <copyright file="GetTriggerResponse.cs" company="APIMatic">
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
    /// GetTriggerResponse.
    /// </summary>
    public class GetTriggerResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTriggerResponse"/> class.
        /// </summary>
        public GetTriggerResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTriggerResponse"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="comparator">comparator.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="groupName">groupName.</param>
        /// <param name="modifiedAt">modifiedAt.</param>
        /// <param name="notificationGroupName">notificationGroupName.</param>
        /// <param name="organizationName">organizationName.</param>
        /// <param name="smsType">smsType.</param>
        /// <param name="threshold">threshold.</param>
        /// <param name="thresholdUnit">thresholdUnit.</param>
        /// <param name="triggerCategory">triggerCategory.</param>
        /// <param name="triggerCycle">triggerCycle.</param>
        /// <param name="triggerId">triggerId.</param>
        /// <param name="triggerName">triggerName.</param>
        public GetTriggerResponse(
            string accountName = null,
            string comparator = null,
            DateTime? createdAt = null,
            string groupName = null,
            DateTime? modifiedAt = null,
            string notificationGroupName = null,
            string organizationName = null,
            string smsType = null,
            string threshold = null,
            string thresholdUnit = null,
            string triggerCategory = null,
            string triggerCycle = null,
            string triggerId = null,
            string triggerName = null)
        {
            this.AccountName = accountName;
            this.Comparator = comparator;
            this.CreatedAt = createdAt;
            this.GroupName = groupName;
            this.ModifiedAt = modifiedAt;
            this.NotificationGroupName = notificationGroupName;
            this.OrganizationName = organizationName;
            this.SmsType = smsType;
            this.Threshold = threshold;
            this.ThresholdUnit = thresholdUnit;
            this.TriggerCategory = triggerCategory;
            this.TriggerCycle = triggerCycle;
            this.TriggerId = triggerId;
            this.TriggerName = triggerName;
        }

        /// <summary>
        /// Gets or sets AccountName.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets Comparator.
        /// </summary>
        [JsonProperty("comparator", NullValueHandling = NullValueHandling.Ignore)]
        public string Comparator { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets GroupName.
        /// </summary>
        [JsonProperty("groupName", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// Gets or sets ModifiedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("modifiedAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// Gets or sets NotificationGroupName.
        /// </summary>
        [JsonProperty("notificationGroupName", NullValueHandling = NullValueHandling.Ignore)]
        public string NotificationGroupName { get; set; }

        /// <summary>
        /// Gets or sets OrganizationName.
        /// </summary>
        [JsonProperty("organizationName", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationName { get; set; }

        /// <summary>
        /// Gets or sets SmsType.
        /// </summary>
        [JsonProperty("smsType", NullValueHandling = NullValueHandling.Ignore)]
        public string SmsType { get; set; }

        /// <summary>
        /// Gets or sets Threshold.
        /// </summary>
        [JsonProperty("threshold", NullValueHandling = NullValueHandling.Ignore)]
        public string Threshold { get; set; }

        /// <summary>
        /// Gets or sets ThresholdUnit.
        /// </summary>
        [JsonProperty("thresholdUnit", NullValueHandling = NullValueHandling.Ignore)]
        public string ThresholdUnit { get; set; }

        /// <summary>
        /// Gets or sets TriggerCategory.
        /// </summary>
        [JsonProperty("triggerCategory", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerCategory { get; set; }

        /// <summary>
        /// Gets or sets TriggerCycle.
        /// </summary>
        [JsonProperty("triggerCycle", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerCycle { get; set; }

        /// <summary>
        /// Gets or sets TriggerId.
        /// </summary>
        [JsonProperty("triggerId", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerId { get; set; }

        /// <summary>
        /// Gets or sets TriggerName.
        /// </summary>
        [JsonProperty("triggerName", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetTriggerResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is GetTriggerResponse other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.Comparator == null && other.Comparator == null) || (this.Comparator?.Equals(other.Comparator) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.GroupName == null && other.GroupName == null) || (this.GroupName?.Equals(other.GroupName) == true)) &&
                ((this.ModifiedAt == null && other.ModifiedAt == null) || (this.ModifiedAt?.Equals(other.ModifiedAt) == true)) &&
                ((this.NotificationGroupName == null && other.NotificationGroupName == null) || (this.NotificationGroupName?.Equals(other.NotificationGroupName) == true)) &&
                ((this.OrganizationName == null && other.OrganizationName == null) || (this.OrganizationName?.Equals(other.OrganizationName) == true)) &&
                ((this.SmsType == null && other.SmsType == null) || (this.SmsType?.Equals(other.SmsType) == true)) &&
                ((this.Threshold == null && other.Threshold == null) || (this.Threshold?.Equals(other.Threshold) == true)) &&
                ((this.ThresholdUnit == null && other.ThresholdUnit == null) || (this.ThresholdUnit?.Equals(other.ThresholdUnit) == true)) &&
                ((this.TriggerCategory == null && other.TriggerCategory == null) || (this.TriggerCategory?.Equals(other.TriggerCategory) == true)) &&
                ((this.TriggerCycle == null && other.TriggerCycle == null) || (this.TriggerCycle?.Equals(other.TriggerCycle) == true)) &&
                ((this.TriggerId == null && other.TriggerId == null) || (this.TriggerId?.Equals(other.TriggerId) == true)) &&
                ((this.TriggerName == null && other.TriggerName == null) || (this.TriggerName?.Equals(other.TriggerName) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.Comparator = {(this.Comparator == null ? "null" : this.Comparator)}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"this.GroupName = {(this.GroupName == null ? "null" : this.GroupName)}");
            toStringOutput.Add($"this.ModifiedAt = {(this.ModifiedAt == null ? "null" : this.ModifiedAt.ToString())}");
            toStringOutput.Add($"this.NotificationGroupName = {(this.NotificationGroupName == null ? "null" : this.NotificationGroupName)}");
            toStringOutput.Add($"this.OrganizationName = {(this.OrganizationName == null ? "null" : this.OrganizationName)}");
            toStringOutput.Add($"this.SmsType = {(this.SmsType == null ? "null" : this.SmsType)}");
            toStringOutput.Add($"this.Threshold = {(this.Threshold == null ? "null" : this.Threshold)}");
            toStringOutput.Add($"this.ThresholdUnit = {(this.ThresholdUnit == null ? "null" : this.ThresholdUnit)}");
            toStringOutput.Add($"this.TriggerCategory = {(this.TriggerCategory == null ? "null" : this.TriggerCategory)}");
            toStringOutput.Add($"this.TriggerCycle = {(this.TriggerCycle == null ? "null" : this.TriggerCycle)}");
            toStringOutput.Add($"this.TriggerId = {(this.TriggerId == null ? "null" : this.TriggerId)}");
            toStringOutput.Add($"this.TriggerName = {(this.TriggerName == null ? "null" : this.TriggerName)}");
        }
    }
}