// <copyright file="UpdateTriggerRequest.cs" company="APIMatic">
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
    /// UpdateTriggerRequest.
    /// </summary>
    public class UpdateTriggerRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTriggerRequest"/> class.
        /// </summary>
        public UpdateTriggerRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTriggerRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="active">active.</param>
        /// <param name="anomalyTriggerRequest">anomalyTriggerRequest.</param>
        /// <param name="cycleType">cycleType.</param>
        /// <param name="dataTriggerRequest">dataTriggerRequest.</param>
        /// <param name="groupName">groupName.</param>
        /// <param name="promoAlertTriggerRequest">promoAlertTriggerRequest.</param>
        /// <param name="sessionTriggerRequest">sessionTriggerRequest.</param>
        /// <param name="smsTriggerRequest">smsTriggerRequest.</param>
        /// <param name="triggerCategory">triggerCategory.</param>
        /// <param name="triggerId">triggerId.</param>
        /// <param name="triggerName">triggerName.</param>
        public UpdateTriggerRequest(
            string accountName = null,
            bool? active = null,
            Models.AnomalyTriggerRequest anomalyTriggerRequest = null,
            Models.CycleTypeEnum? cycleType = null,
            Models.DataTriggerRequest dataTriggerRequest = null,
            string groupName = null,
            Models.PromoAlertTriggerRequest promoAlertTriggerRequest = null,
            Models.SessionTriggerRequest sessionTriggerRequest = null,
            Models.SMSTriggerRequest smsTriggerRequest = null,
            string triggerCategory = null,
            string triggerId = null,
            string triggerName = null)
        {
            this.AccountName = accountName;
            this.Active = active;
            this.AnomalyTriggerRequest = anomalyTriggerRequest;
            this.CycleType = cycleType;
            this.DataTriggerRequest = dataTriggerRequest;
            this.GroupName = groupName;
            this.PromoAlertTriggerRequest = promoAlertTriggerRequest;
            this.SessionTriggerRequest = sessionTriggerRequest;
            this.SmsTriggerRequest = smsTriggerRequest;
            this.TriggerCategory = triggerCategory;
            this.TriggerId = triggerId;
            this.TriggerName = triggerName;
        }

        /// <summary>
        /// Gets or sets AccountName.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets Active.
        /// </summary>
        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; }

        /// <summary>
        /// The details of the UsageAnomaly trigger.
        /// </summary>
        [JsonProperty("anomalyTriggerRequest", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AnomalyTriggerRequest AnomalyTriggerRequest { get; set; }

        /// <summary>
        /// Gets or sets CycleType.
        /// </summary>
        [JsonProperty("cycleType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CycleTypeEnum? CycleType { get; set; }

        /// <summary>
        /// Gets or sets DataTriggerRequest.
        /// </summary>
        [JsonProperty("dataTriggerRequest", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DataTriggerRequest DataTriggerRequest { get; set; }

        /// <summary>
        /// Gets or sets GroupName.
        /// </summary>
        [JsonProperty("groupName", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// Gets or sets PromoAlertTriggerRequest.
        /// </summary>
        [JsonProperty("promoAlertTriggerRequest", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PromoAlertTriggerRequest PromoAlertTriggerRequest { get; set; }

        /// <summary>
        /// Gets or sets SessionTriggerRequest.
        /// </summary>
        [JsonProperty("sessionTriggerRequest", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SessionTriggerRequest SessionTriggerRequest { get; set; }

        /// <summary>
        /// Gets or sets SmsTriggerRequest.
        /// </summary>
        [JsonProperty("smsTriggerRequest", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SMSTriggerRequest SmsTriggerRequest { get; set; }

        /// <summary>
        /// Gets or sets TriggerCategory.
        /// </summary>
        [JsonProperty("triggerCategory", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerCategory { get; set; }

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

            return $"UpdateTriggerRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is UpdateTriggerRequest other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.Active == null && other.Active == null) || (this.Active?.Equals(other.Active) == true)) &&
                ((this.AnomalyTriggerRequest == null && other.AnomalyTriggerRequest == null) || (this.AnomalyTriggerRequest?.Equals(other.AnomalyTriggerRequest) == true)) &&
                ((this.CycleType == null && other.CycleType == null) || (this.CycleType?.Equals(other.CycleType) == true)) &&
                ((this.DataTriggerRequest == null && other.DataTriggerRequest == null) || (this.DataTriggerRequest?.Equals(other.DataTriggerRequest) == true)) &&
                ((this.GroupName == null && other.GroupName == null) || (this.GroupName?.Equals(other.GroupName) == true)) &&
                ((this.PromoAlertTriggerRequest == null && other.PromoAlertTriggerRequest == null) || (this.PromoAlertTriggerRequest?.Equals(other.PromoAlertTriggerRequest) == true)) &&
                ((this.SessionTriggerRequest == null && other.SessionTriggerRequest == null) || (this.SessionTriggerRequest?.Equals(other.SessionTriggerRequest) == true)) &&
                ((this.SmsTriggerRequest == null && other.SmsTriggerRequest == null) || (this.SmsTriggerRequest?.Equals(other.SmsTriggerRequest) == true)) &&
                ((this.TriggerCategory == null && other.TriggerCategory == null) || (this.TriggerCategory?.Equals(other.TriggerCategory) == true)) &&
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
            toStringOutput.Add($"this.Active = {(this.Active == null ? "null" : this.Active.ToString())}");
            toStringOutput.Add($"this.AnomalyTriggerRequest = {(this.AnomalyTriggerRequest == null ? "null" : this.AnomalyTriggerRequest.ToString())}");
            toStringOutput.Add($"this.CycleType = {(this.CycleType == null ? "null" : this.CycleType.ToString())}");
            toStringOutput.Add($"this.DataTriggerRequest = {(this.DataTriggerRequest == null ? "null" : this.DataTriggerRequest.ToString())}");
            toStringOutput.Add($"this.GroupName = {(this.GroupName == null ? "null" : this.GroupName)}");
            toStringOutput.Add($"this.PromoAlertTriggerRequest = {(this.PromoAlertTriggerRequest == null ? "null" : this.PromoAlertTriggerRequest.ToString())}");
            toStringOutput.Add($"this.SessionTriggerRequest = {(this.SessionTriggerRequest == null ? "null" : this.SessionTriggerRequest.ToString())}");
            toStringOutput.Add($"this.SmsTriggerRequest = {(this.SmsTriggerRequest == null ? "null" : this.SmsTriggerRequest.ToString())}");
            toStringOutput.Add($"this.TriggerCategory = {(this.TriggerCategory == null ? "null" : this.TriggerCategory)}");
            toStringOutput.Add($"this.TriggerId = {(this.TriggerId == null ? "null" : this.TriggerId)}");
            toStringOutput.Add($"this.TriggerName = {(this.TriggerName == null ? "null" : this.TriggerName)}");
        }
    }
}