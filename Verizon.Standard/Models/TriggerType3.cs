// <copyright file="TriggerType3.cs" company="APIMatic">
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
    /// TriggerType3.
    /// </summary>
    public class TriggerType3
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerType3"/> class.
        /// </summary>
        public TriggerType3()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerType3"/> class.
        /// </summary>
        /// <param name="triggerId">triggerId.</param>
        /// <param name="triggerName">triggerName.</param>
        /// <param name="triggerCategory">triggerCategory.</param>
        /// <param name="accountName">accountName.</param>
        /// <param name="anomalyTriggerRequest">anomalyTriggerRequest.</param>
        /// <param name="notification">notification.</param>
        public TriggerType3(
            string triggerId = null,
            string triggerName = null,
            string triggerCategory = null,
            string accountName = null,
            Models.AnomalyTriggerRequest anomalyTriggerRequest = null,
            Models.TriggerNotification notification = null)
        {
            this.TriggerId = triggerId;
            this.TriggerName = triggerName;
            this.TriggerCategory = triggerCategory;
            this.AccountName = accountName;
            this.AnomalyTriggerRequest = anomalyTriggerRequest;
            this.Notification = notification;
        }

        /// <summary>
        /// Trigger ID.
        /// </summary>
        [JsonProperty("triggerId", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerId { get; set; }

        /// <summary>
        /// Trigger name.
        /// </summary>
        [JsonProperty("triggerName", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerName { get; set; }

        /// <summary>
        /// This is the value to use in the request body to detect anomalous behaivior. The values in this table will only be relevant when this parameter is set to this value.
        /// </summary>
        [JsonProperty("triggerCategory", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerCategory { get; set; }

        /// <summary>
        /// Account name.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// The details of the UsageAnomaly trigger.
        /// </summary>
        [JsonProperty("anomalyTriggerRequest", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AnomalyTriggerRequest AnomalyTriggerRequest { get; set; }

        /// <summary>
        /// The notification details of the trigger.
        /// </summary>
        [JsonProperty("notification", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TriggerNotification Notification { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TriggerType3 : ({string.Join(", ", toStringOutput)})";
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
            return obj is TriggerType3 other &&                ((this.TriggerId == null && other.TriggerId == null) || (this.TriggerId?.Equals(other.TriggerId) == true)) &&
                ((this.TriggerName == null && other.TriggerName == null) || (this.TriggerName?.Equals(other.TriggerName) == true)) &&
                ((this.TriggerCategory == null && other.TriggerCategory == null) || (this.TriggerCategory?.Equals(other.TriggerCategory) == true)) &&
                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.AnomalyTriggerRequest == null && other.AnomalyTriggerRequest == null) || (this.AnomalyTriggerRequest?.Equals(other.AnomalyTriggerRequest) == true)) &&
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
            toStringOutput.Add($"this.TriggerCategory = {(this.TriggerCategory == null ? "null" : this.TriggerCategory)}");
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.AnomalyTriggerRequest = {(this.AnomalyTriggerRequest == null ? "null" : this.AnomalyTriggerRequest.ToString())}");
            toStringOutput.Add($"this.Notification = {(this.Notification == null ? "null" : this.Notification.ToString())}");
        }
    }
}