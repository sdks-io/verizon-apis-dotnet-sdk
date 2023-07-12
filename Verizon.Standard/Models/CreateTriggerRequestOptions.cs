// <copyright file="CreateTriggerRequestOptions.cs" company="APIMatic">
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
    /// CreateTriggerRequestOptions.
    /// </summary>
    public class CreateTriggerRequestOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTriggerRequestOptions"/> class.
        /// </summary>
        public CreateTriggerRequestOptions()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTriggerRequestOptions"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="triggerCategory">triggerCategory.</param>
        /// <param name="accountName">accountName.</param>
        /// <param name="anomalyTriggerRequest">anomalyTriggerRequest.</param>
        /// <param name="notification">notification.</param>
        /// <param name="active">active.</param>
        public CreateTriggerRequestOptions(
            string name = null,
            string triggerCategory = null,
            string accountName = null,
            Models.AnomalyTriggerRequest anomalyTriggerRequest = null,
            Models.Notification notification = null,
            bool? active = null)
        {
            this.Name = name;
            this.TriggerCategory = triggerCategory;
            this.AccountName = accountName;
            this.AnomalyTriggerRequest = anomalyTriggerRequest;
            this.Notification = notification;
            this.Active = active;
        }

        /// <summary>
        /// Trigger name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

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
        public Models.Notification Notification { get; set; }

        /// <summary>
        /// Indicates anomaly detection is active<br />True - Anomaly detection is active.<br />False - Anomaly detection is not active.
        /// </summary>
        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateTriggerRequestOptions : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreateTriggerRequestOptions other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.TriggerCategory == null && other.TriggerCategory == null) || (this.TriggerCategory?.Equals(other.TriggerCategory) == true)) &&
                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.AnomalyTriggerRequest == null && other.AnomalyTriggerRequest == null) || (this.AnomalyTriggerRequest?.Equals(other.AnomalyTriggerRequest) == true)) &&
                ((this.Notification == null && other.Notification == null) || (this.Notification?.Equals(other.Notification) == true)) &&
                ((this.Active == null && other.Active == null) || (this.Active?.Equals(other.Active) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.TriggerCategory = {(this.TriggerCategory == null ? "null" : this.TriggerCategory == string.Empty ? "" : this.TriggerCategory)}");
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName == string.Empty ? "" : this.AccountName)}");
            toStringOutput.Add($"this.AnomalyTriggerRequest = {(this.AnomalyTriggerRequest == null ? "null" : this.AnomalyTriggerRequest.ToString())}");
            toStringOutput.Add($"this.Notification = {(this.Notification == null ? "null" : this.Notification.ToString())}");
            toStringOutput.Add($"this.Active = {(this.Active == null ? "null" : this.Active.ToString())}");
        }
    }
}