// <copyright file="DeviceFilter.cs" company="APIMatic">
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
    /// DeviceFilter.
    /// </summary>
    public class DeviceFilter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceFilter"/> class.
        /// </summary>
        public DeviceFilter()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceFilter"/> class.
        /// </summary>
        /// <param name="account">account.</param>
        /// <param name="groupName">groupName.</param>
        /// <param name="servicePlan">servicePlan.</param>
        /// <param name="customFields">customFields.</param>
        public DeviceFilter(
            string account = null,
            string groupName = null,
            string servicePlan = null,
            List<Models.CustomFields> customFields = null)
        {
            this.Account = account;
            this.GroupName = groupName;
            this.ServicePlan = servicePlan;
            this.CustomFields = customFields;
        }

        /// <summary>
        /// The the billing account that the devices belong to.
        /// </summary>
        [JsonProperty("account", NullValueHandling = NullValueHandling.Ignore)]
        public string Account { get; set; }

        /// <summary>
        /// Only include devices that are in this device group.
        /// </summary>
        [JsonProperty("groupName", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// Only include devices that have this service plan.
        /// </summary>
        [JsonProperty("servicePlan", NullValueHandling = NullValueHandling.Ignore)]
        public string ServicePlan { get; set; }

        /// <summary>
        /// Custom field names and values, if you want to only include devices that have matching values.
        /// </summary>
        [JsonProperty("customFields", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CustomFields> CustomFields { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DeviceFilter : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DeviceFilter other &&
                (this.Account == null && other.Account == null ||
                 this.Account?.Equals(other.Account) == true) &&
                (this.GroupName == null && other.GroupName == null ||
                 this.GroupName?.Equals(other.GroupName) == true) &&
                (this.ServicePlan == null && other.ServicePlan == null ||
                 this.ServicePlan?.Equals(other.ServicePlan) == true) &&
                (this.CustomFields == null && other.CustomFields == null ||
                 this.CustomFields?.Equals(other.CustomFields) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Account = {this.Account ?? "null"}");
            toStringOutput.Add($"GroupName = {this.GroupName ?? "null"}");
            toStringOutput.Add($"ServicePlan = {this.ServicePlan ?? "null"}");
            toStringOutput.Add($"CustomFields = {(this.CustomFields == null ? "null" : $"[{string.Join(", ", this.CustomFields)} ]")}");
        }
    }
}