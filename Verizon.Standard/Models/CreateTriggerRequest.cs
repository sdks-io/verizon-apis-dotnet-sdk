// <copyright file="CreateTriggerRequest.cs" company="APIMatic">
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
    /// CreateTriggerRequest.
    /// </summary>
    public class CreateTriggerRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTriggerRequest"/> class.
        /// </summary>
        public CreateTriggerRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTriggerRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="anomalyTriggerRequest">anomalyTriggerRequest.</param>
        /// <param name="dataTriggerRequest">dataTriggerRequest.</param>
        /// <param name="groupName">groupName.</param>
        /// <param name="name">name.</param>
        /// <param name="sessionTriggerRequest">sessionTriggerRequest.</param>
        /// <param name="smsTriggerRequest">smsTriggerRequest.</param>
        /// <param name="triggerCategory">triggerCategory.</param>
        /// <param name="triggerCycle">triggerCycle.</param>
        public CreateTriggerRequest(
            string accountName = null,
            Models.AnomalyTriggerRequest anomalyTriggerRequest = null,
            Models.DataTriggerRequest dataTriggerRequest = null,
            string groupName = null,
            string name = null,
            Models.SessionTriggerRequest sessionTriggerRequest = null,
            Models.SMSTriggerRequest smsTriggerRequest = null,
            string triggerCategory = null,
            string triggerCycle = null)
        {
            this.AccountName = accountName;
            this.AnomalyTriggerRequest = anomalyTriggerRequest;
            this.DataTriggerRequest = dataTriggerRequest;
            this.GroupName = groupName;
            this.Name = name;
            this.SessionTriggerRequest = sessionTriggerRequest;
            this.SmsTriggerRequest = smsTriggerRequest;
            this.TriggerCategory = triggerCategory;
            this.TriggerCycle = triggerCycle;
        }

        /// <summary>
        /// Gets or sets AccountName.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// The details of the UsageAnomaly trigger.
        /// </summary>
        [JsonProperty("anomalyTriggerRequest", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AnomalyTriggerRequest AnomalyTriggerRequest { get; set; }

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
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

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
        /// Gets or sets TriggerCycle.
        /// </summary>
        [JsonProperty("triggerCycle", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerCycle { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateTriggerRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreateTriggerRequest other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.AnomalyTriggerRequest == null && other.AnomalyTriggerRequest == null) || (this.AnomalyTriggerRequest?.Equals(other.AnomalyTriggerRequest) == true)) &&
                ((this.DataTriggerRequest == null && other.DataTriggerRequest == null) || (this.DataTriggerRequest?.Equals(other.DataTriggerRequest) == true)) &&
                ((this.GroupName == null && other.GroupName == null) || (this.GroupName?.Equals(other.GroupName) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.SessionTriggerRequest == null && other.SessionTriggerRequest == null) || (this.SessionTriggerRequest?.Equals(other.SessionTriggerRequest) == true)) &&
                ((this.SmsTriggerRequest == null && other.SmsTriggerRequest == null) || (this.SmsTriggerRequest?.Equals(other.SmsTriggerRequest) == true)) &&
                ((this.TriggerCategory == null && other.TriggerCategory == null) || (this.TriggerCategory?.Equals(other.TriggerCategory) == true)) &&
                ((this.TriggerCycle == null && other.TriggerCycle == null) || (this.TriggerCycle?.Equals(other.TriggerCycle) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.AnomalyTriggerRequest = {(this.AnomalyTriggerRequest == null ? "null" : this.AnomalyTriggerRequest.ToString())}");
            toStringOutput.Add($"this.DataTriggerRequest = {(this.DataTriggerRequest == null ? "null" : this.DataTriggerRequest.ToString())}");
            toStringOutput.Add($"this.GroupName = {(this.GroupName == null ? "null" : this.GroupName)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.SessionTriggerRequest = {(this.SessionTriggerRequest == null ? "null" : this.SessionTriggerRequest.ToString())}");
            toStringOutput.Add($"this.SmsTriggerRequest = {(this.SmsTriggerRequest == null ? "null" : this.SmsTriggerRequest.ToString())}");
            toStringOutput.Add($"this.TriggerCategory = {(this.TriggerCategory == null ? "null" : this.TriggerCategory)}");
            toStringOutput.Add($"this.TriggerCycle = {(this.TriggerCycle == null ? "null" : this.TriggerCycle)}");
        }
    }
}