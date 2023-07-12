// <copyright file="CustomFieldsUpdateRequest.cs" company="APIMatic">
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
    /// CustomFieldsUpdateRequest.
    /// </summary>
    public class CustomFieldsUpdateRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomFieldsUpdateRequest"/> class.
        /// </summary>
        public CustomFieldsUpdateRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomFieldsUpdateRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="customFields">customFields.</param>
        /// <param name="customFieldsToUpdate">customFieldsToUpdate.</param>
        /// <param name="devices">devices.</param>
        /// <param name="groupName">groupName.</param>
        /// <param name="servicePlan">servicePlan.</param>
        public CustomFieldsUpdateRequest(
            string accountName = null,
            List<Models.CustomFields> customFields = null,
            List<Models.CustomFields> customFieldsToUpdate = null,
            List<Models.AccountDeviceList> devices = null,
            string groupName = null,
            string servicePlan = null)
        {
            this.AccountName = accountName;
            this.CustomFields = customFields;
            this.CustomFieldsToUpdate = customFieldsToUpdate;
            this.Devices = devices;
            this.GroupName = groupName;
            this.ServicePlan = servicePlan;
        }

        /// <summary>
        /// The name of a billing account.This parameter is only required if the UWS account used for the current API session has access to multiple billing accounts.An account name is usually numeric, and must include any leading zeros.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// Custom field names and values, if you want to only include devices that have matching values.
        /// </summary>
        [JsonProperty("customFields", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CustomFields> CustomFields { get; set; }

        /// <summary>
        /// The names and new values of any custom fields that you want to change.
        /// </summary>
        [JsonProperty("customFieldsToUpdate", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CustomFields> CustomFieldsToUpdate { get; set; }

        /// <summary>
        /// The devices that you want to change.
        /// </summary>
        [JsonProperty("devices", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.AccountDeviceList> Devices { get; set; }

        /// <summary>
        /// The name of a device group, if you want to only include devices in that group.
        /// </summary>
        [JsonProperty("groupName", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// The name of a service plan, if you want to only include devices that have that service plan.
        /// </summary>
        [JsonProperty("servicePlan", NullValueHandling = NullValueHandling.Ignore)]
        public string ServicePlan { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CustomFieldsUpdateRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is CustomFieldsUpdateRequest other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.CustomFields == null && other.CustomFields == null) || (this.CustomFields?.Equals(other.CustomFields) == true)) &&
                ((this.CustomFieldsToUpdate == null && other.CustomFieldsToUpdate == null) || (this.CustomFieldsToUpdate?.Equals(other.CustomFieldsToUpdate) == true)) &&
                ((this.Devices == null && other.Devices == null) || (this.Devices?.Equals(other.Devices) == true)) &&
                ((this.GroupName == null && other.GroupName == null) || (this.GroupName?.Equals(other.GroupName) == true)) &&
                ((this.ServicePlan == null && other.ServicePlan == null) || (this.ServicePlan?.Equals(other.ServicePlan) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName == string.Empty ? "" : this.AccountName)}");
            toStringOutput.Add($"this.CustomFields = {(this.CustomFields == null ? "null" : $"[{string.Join(", ", this.CustomFields)} ]")}");
            toStringOutput.Add($"this.CustomFieldsToUpdate = {(this.CustomFieldsToUpdate == null ? "null" : $"[{string.Join(", ", this.CustomFieldsToUpdate)} ]")}");
            toStringOutput.Add($"this.Devices = {(this.Devices == null ? "null" : $"[{string.Join(", ", this.Devices)} ]")}");
            toStringOutput.Add($"this.GroupName = {(this.GroupName == null ? "null" : this.GroupName == string.Empty ? "" : this.GroupName)}");
            toStringOutput.Add($"this.ServicePlan = {(this.ServicePlan == null ? "null" : this.ServicePlan == string.Empty ? "" : this.ServicePlan)}");
        }
    }
}