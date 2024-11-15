// <copyright file="CarrierDeactivateRequest.cs" company="APIMatic">
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
    /// CarrierDeactivateRequest.
    /// </summary>
    public class CarrierDeactivateRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CarrierDeactivateRequest"/> class.
        /// </summary>
        public CarrierDeactivateRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CarrierDeactivateRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="devices">devices.</param>
        /// <param name="reasonCode">reasonCode.</param>
        /// <param name="customFields">customFields.</param>
        /// <param name="etfWaiver">etfWaiver.</param>
        /// <param name="groupName">groupName.</param>
        /// <param name="servicePlan">servicePlan.</param>
        /// <param name="deleteAfterDeactivation">deleteAfterDeactivation.</param>
        public CarrierDeactivateRequest(
            string accountName,
            List<Models.AccountDeviceList> devices,
            string reasonCode,
            List<Models.CustomFields> customFields = null,
            bool? etfWaiver = null,
            string groupName = null,
            string servicePlan = null,
            bool? deleteAfterDeactivation = null)
        {
            this.AccountName = accountName;
            this.Devices = devices;
            this.ReasonCode = reasonCode;
            this.CustomFields = customFields;
            this.EtfWaiver = etfWaiver;
            this.GroupName = groupName;
            this.ServicePlan = servicePlan;
            this.DeleteAfterDeactivation = deleteAfterDeactivation;
        }

        /// <summary>
        /// The name of a billing account.
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// The devices for which you want to deactivate service, specified by device identifier.
        /// </summary>
        [JsonProperty("devices")]
        public List<Models.AccountDeviceList> Devices { get; set; }

        /// <summary>
        /// Code identifying the reason for the deactivation. Currently the only valid reason code is “FF”, which corresponds to General Admin/Maintenance.
        /// </summary>
        [JsonProperty("reasonCode")]
        public string ReasonCode { get; set; }

        /// <summary>
        /// Custom field names and values, if you want to only include devices that have matching values.
        /// </summary>
        [JsonProperty("customFields", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CustomFields> CustomFields { get; set; }

        /// <summary>
        /// Fees may be assessed for deactivating Verizon Wireless devices, depending on the account contract. The etfWaiver parameter waives the Early Termination Fee (ETF), if applicable.
        /// </summary>
        [JsonProperty("etfWaiver", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EtfWaiver { get; set; }

        /// <summary>
        /// The name of a device group, if you want to deactivate all devices in that group.
        /// </summary>
        [JsonProperty("groupName", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// The name of a service plan, if you want to only include devices that have that service plan.
        /// </summary>
        [JsonProperty("servicePlan", NullValueHandling = NullValueHandling.Ignore)]
        public string ServicePlan { get; set; }

        /// <summary>
        /// Gets or sets DeleteAfterDeactivation.
        /// </summary>
        [JsonProperty("deleteAfterDeactivation", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeleteAfterDeactivation { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CarrierDeactivateRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is CarrierDeactivateRequest other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.Devices == null && other.Devices == null) || (this.Devices?.Equals(other.Devices) == true)) &&
                ((this.ReasonCode == null && other.ReasonCode == null) || (this.ReasonCode?.Equals(other.ReasonCode) == true)) &&
                ((this.CustomFields == null && other.CustomFields == null) || (this.CustomFields?.Equals(other.CustomFields) == true)) &&
                ((this.EtfWaiver == null && other.EtfWaiver == null) || (this.EtfWaiver?.Equals(other.EtfWaiver) == true)) &&
                ((this.GroupName == null && other.GroupName == null) || (this.GroupName?.Equals(other.GroupName) == true)) &&
                ((this.ServicePlan == null && other.ServicePlan == null) || (this.ServicePlan?.Equals(other.ServicePlan) == true)) &&
                ((this.DeleteAfterDeactivation == null && other.DeleteAfterDeactivation == null) || (this.DeleteAfterDeactivation?.Equals(other.DeleteAfterDeactivation) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.Devices = {(this.Devices == null ? "null" : $"[{string.Join(", ", this.Devices)} ]")}");
            toStringOutput.Add($"this.ReasonCode = {(this.ReasonCode == null ? "null" : this.ReasonCode)}");
            toStringOutput.Add($"this.CustomFields = {(this.CustomFields == null ? "null" : $"[{string.Join(", ", this.CustomFields)} ]")}");
            toStringOutput.Add($"this.EtfWaiver = {(this.EtfWaiver == null ? "null" : this.EtfWaiver.ToString())}");
            toStringOutput.Add($"this.GroupName = {(this.GroupName == null ? "null" : this.GroupName)}");
            toStringOutput.Add($"this.ServicePlan = {(this.ServicePlan == null ? "null" : this.ServicePlan)}");
            toStringOutput.Add($"this.DeleteAfterDeactivation = {(this.DeleteAfterDeactivation == null ? "null" : this.DeleteAfterDeactivation.ToString())}");
        }
    }
}