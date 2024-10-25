// <copyright file="CarrierActionsRequest.cs" company="APIMatic">
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
    /// CarrierActionsRequest.
    /// </summary>
    public class CarrierActionsRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CarrierActionsRequest"/> class.
        /// </summary>
        public CarrierActionsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CarrierActionsRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="customFields">customFields.</param>
        /// <param name="devices">devices.</param>
        /// <param name="withBilling">withBilling.</param>
        /// <param name="groupName">groupName.</param>
        /// <param name="servicePlan">servicePlan.</param>
        public CarrierActionsRequest(
            string accountName = null,
            List<Models.CustomFields> customFields = null,
            List<Models.AccountDeviceList> devices = null,
            bool? withBilling = null,
            string groupName = null,
            string servicePlan = null)
        {
            this.AccountName = accountName;
            this.CustomFields = customFields;
            this.Devices = devices;
            this.WithBilling = withBilling;
            this.GroupName = groupName;
            this.ServicePlan = servicePlan;
        }

        /// <summary>
        /// The name of a billing account.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// Custom field names and values, if you want to only include devices that have matching values.
        /// </summary>
        [JsonProperty("customFields", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CustomFields> CustomFields { get; set; }

        /// <summary>
        /// The devices for which you want to restore service, specified by device identifier.
        /// </summary>
        [JsonProperty("devices", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.AccountDeviceList> Devices { get; set; }

        /// <summary>
        /// set to "true" to suspend with billing, set to "false" to suspend without billing
        /// </summary>
        [JsonProperty("withBilling", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WithBilling { get; set; }

        /// <summary>
        /// The name of a device group, if you want to restore service for all devices in that group.
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

            return $"CarrierActionsRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is CarrierActionsRequest other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.CustomFields == null && other.CustomFields == null) || (this.CustomFields?.Equals(other.CustomFields) == true)) &&
                ((this.Devices == null && other.Devices == null) || (this.Devices?.Equals(other.Devices) == true)) &&
                ((this.WithBilling == null && other.WithBilling == null) || (this.WithBilling?.Equals(other.WithBilling) == true)) &&
                ((this.GroupName == null && other.GroupName == null) || (this.GroupName?.Equals(other.GroupName) == true)) &&
                ((this.ServicePlan == null && other.ServicePlan == null) || (this.ServicePlan?.Equals(other.ServicePlan) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.CustomFields = {(this.CustomFields == null ? "null" : $"[{string.Join(", ", this.CustomFields)} ]")}");
            toStringOutput.Add($"this.Devices = {(this.Devices == null ? "null" : $"[{string.Join(", ", this.Devices)} ]")}");
            toStringOutput.Add($"this.WithBilling = {(this.WithBilling == null ? "null" : this.WithBilling.ToString())}");
            toStringOutput.Add($"this.GroupName = {(this.GroupName == null ? "null" : this.GroupName)}");
            toStringOutput.Add($"this.ServicePlan = {(this.ServicePlan == null ? "null" : this.ServicePlan)}");
        }
    }
}