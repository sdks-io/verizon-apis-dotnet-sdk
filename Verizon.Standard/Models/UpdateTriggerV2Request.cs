// <copyright file="UpdateTriggerV2Request.cs" company="APIMatic">
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
    /// UpdateTriggerV2Request.
    /// </summary>
    public class UpdateTriggerV2Request
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTriggerV2Request"/> class.
        /// </summary>
        public UpdateTriggerV2Request()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTriggerV2Request"/> class.
        /// </summary>
        /// <param name="triggerId">triggerId.</param>
        /// <param name="triggerName">triggerName.</param>
        /// <param name="ecpdId">ecpdId.</param>
        /// <param name="deviceGroupName">deviceGroupName.</param>
        /// <param name="triggerCategory">triggerCategory.</param>
        /// <param name="pricePlanTrigger">pricePlanTrigger.</param>
        /// <param name="notification">notification.</param>
        /// <param name="active">active.</param>
        public UpdateTriggerV2Request(
            string triggerId = null,
            string triggerName = null,
            string ecpdId = null,
            string deviceGroupName = null,
            string triggerCategory = null,
            Models.PricePlanTrigger pricePlanTrigger = null,
            Models.Notification notification = null,
            bool? active = null)
        {
            this.TriggerId = triggerId;
            this.TriggerName = triggerName;
            this.EcpdId = ecpdId;
            this.DeviceGroupName = deviceGroupName;
            this.TriggerCategory = triggerCategory;
            this.PricePlanTrigger = pricePlanTrigger;
            this.Notification = notification;
            this.Active = active;
        }

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

        /// <summary>
        /// Gets or sets EcpdId.
        /// </summary>
        [JsonProperty("ecpdId", NullValueHandling = NullValueHandling.Ignore)]
        public string EcpdId { get; set; }

        /// <summary>
        /// Gets or sets DeviceGroupName.
        /// </summary>
        [JsonProperty("deviceGroupName", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceGroupName { get; set; }

        /// <summary>
        /// Gets or sets TriggerCategory.
        /// </summary>
        [JsonProperty("triggerCategory", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerCategory { get; set; }

        /// <summary>
        /// Gets or sets PricePlanTrigger.
        /// </summary>
        [JsonProperty("pricePlanTrigger", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PricePlanTrigger PricePlanTrigger { get; set; }

        /// <summary>
        /// Gets or sets Notification.
        /// </summary>
        [JsonProperty("notification", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Notification Notification { get; set; }

        /// <summary>
        /// Gets or sets Active.
        /// </summary>
        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpdateTriggerV2Request : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdateTriggerV2Request other &&
                (this.TriggerId == null && other.TriggerId == null ||
                 this.TriggerId?.Equals(other.TriggerId) == true) &&
                (this.TriggerName == null && other.TriggerName == null ||
                 this.TriggerName?.Equals(other.TriggerName) == true) &&
                (this.EcpdId == null && other.EcpdId == null ||
                 this.EcpdId?.Equals(other.EcpdId) == true) &&
                (this.DeviceGroupName == null && other.DeviceGroupName == null ||
                 this.DeviceGroupName?.Equals(other.DeviceGroupName) == true) &&
                (this.TriggerCategory == null && other.TriggerCategory == null ||
                 this.TriggerCategory?.Equals(other.TriggerCategory) == true) &&
                (this.PricePlanTrigger == null && other.PricePlanTrigger == null ||
                 this.PricePlanTrigger?.Equals(other.PricePlanTrigger) == true) &&
                (this.Notification == null && other.Notification == null ||
                 this.Notification?.Equals(other.Notification) == true) &&
                (this.Active == null && other.Active == null ||
                 this.Active?.Equals(other.Active) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"TriggerId = {this.TriggerId ?? "null"}");
            toStringOutput.Add($"TriggerName = {this.TriggerName ?? "null"}");
            toStringOutput.Add($"EcpdId = {this.EcpdId ?? "null"}");
            toStringOutput.Add($"DeviceGroupName = {this.DeviceGroupName ?? "null"}");
            toStringOutput.Add($"TriggerCategory = {this.TriggerCategory ?? "null"}");
            toStringOutput.Add($"PricePlanTrigger = {(this.PricePlanTrigger == null ? "null" : this.PricePlanTrigger.ToString())}");
            toStringOutput.Add($"Notification = {(this.Notification == null ? "null" : this.Notification.ToString())}");
            toStringOutput.Add($"Active = {(this.Active == null ? "null" : this.Active.ToString())}");
        }
    }
}