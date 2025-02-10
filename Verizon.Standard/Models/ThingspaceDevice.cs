// <copyright file="ThingspaceDevice.cs" company="APIMatic">
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
    /// ThingspaceDevice.
    /// </summary>
    public class ThingspaceDevice
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThingspaceDevice"/> class.
        /// </summary>
        public ThingspaceDevice()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThingspaceDevice"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="billingCycleEndDate">billingCycleEndDate.</param>
        /// <param name="carrierInformations">carrierInformations.</param>
        /// <param name="connected">connected.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="customFields">customFields.</param>
        /// <param name="deviceIds">deviceIds.</param>
        /// <param name="extendedAttributes">extendedAttributes.</param>
        /// <param name="groupNames">groupNames.</param>
        /// <param name="ipaddress">ipAddress.</param>
        /// <param name="lastActivationBy">lastActivationBy.</param>
        /// <param name="lastActivationDate">lastActivationDate.</param>
        /// <param name="lastConnectionDate">lastConnectionDate.</param>
        public ThingspaceDevice(
            string accountName = null,
            string billingCycleEndDate = null,
            List<Models.CarrierInformation> carrierInformations = null,
            bool? connected = null,
            string createdAt = null,
            List<Models.CustomFields> customFields = null,
            List<Models.DeviceId> deviceIds = null,
            List<Models.CustomFields> extendedAttributes = null,
            List<string> groupNames = null,
            string ipaddress = null,
            string lastActivationBy = null,
            string lastActivationDate = null,
            string lastConnectionDate = null)
        {
            this.AccountName = accountName;
            this.BillingCycleEndDate = billingCycleEndDate;
            this.CarrierInformations = carrierInformations;
            this.Connected = connected;
            this.CreatedAt = createdAt;
            this.CustomFields = customFields;
            this.DeviceIds = deviceIds;
            this.ExtendedAttributes = extendedAttributes;
            this.GroupNames = groupNames;
            this.Ipaddress = ipaddress;
            this.LastActivationBy = lastActivationBy;
            this.LastActivationDate = lastActivationDate;
            this.LastConnectionDate = lastConnectionDate;
        }

        /// <summary>
        /// The billing account that the device is associated with.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// The date that the device's current billing cycle ends.
        /// </summary>
        [JsonProperty("billingCycleEndDate", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingCycleEndDate { get; set; }

        /// <summary>
        /// The carrier information associated with the device.
        /// </summary>
        [JsonProperty("carrierInformations", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CarrierInformation> CarrierInformations { get; set; }

        /// <summary>
        /// True if the device is connected; false if it is not.
        /// </summary>
        [JsonProperty("connected", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Connected { get; set; }

        /// <summary>
        /// The date and time that the device was added to the system.
        /// </summary>
        [JsonProperty("createdAt", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// The custom fields and values that have been set for the device.
        /// </summary>
        [JsonProperty("customFields", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CustomFields> CustomFields { get; set; }

        /// <summary>
        /// All identifiers for the device.
        /// </summary>
        [JsonProperty("deviceIds", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DeviceId> DeviceIds { get; set; }

        /// <summary>
        /// Any extended attributes for the device, as Key and Value pairs. The pairs listed below are returned as part of the response for a single device, but are not included if the request was for information about multiple devices.
        /// </summary>
        [JsonProperty("extendedAttributes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CustomFields> ExtendedAttributes { get; set; }

        /// <summary>
        /// The device groups that the device belongs to.
        /// </summary>
        [JsonProperty("groupNames", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> GroupNames { get; set; }

        /// <summary>
        /// The IP address of the device.
        /// </summary>
        [JsonProperty("ipAddress", NullValueHandling = NullValueHandling.Ignore)]
        public string Ipaddress { get; set; }

        /// <summary>
        /// The user who last activated the device.
        /// </summary>
        [JsonProperty("lastActivationBy", NullValueHandling = NullValueHandling.Ignore)]
        public string LastActivationBy { get; set; }

        /// <summary>
        /// The date and time that the device was last activated.
        /// </summary>
        [JsonProperty("lastActivationDate", NullValueHandling = NullValueHandling.Ignore)]
        public string LastActivationDate { get; set; }

        /// <summary>
        /// The most recent connection date and time.
        /// </summary>
        [JsonProperty("lastConnectionDate", NullValueHandling = NullValueHandling.Ignore)]
        public string LastConnectionDate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ThingspaceDevice : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ThingspaceDevice other &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.BillingCycleEndDate == null && other.BillingCycleEndDate == null ||
                 this.BillingCycleEndDate?.Equals(other.BillingCycleEndDate) == true) &&
                (this.CarrierInformations == null && other.CarrierInformations == null ||
                 this.CarrierInformations?.Equals(other.CarrierInformations) == true) &&
                (this.Connected == null && other.Connected == null ||
                 this.Connected?.Equals(other.Connected) == true) &&
                (this.CreatedAt == null && other.CreatedAt == null ||
                 this.CreatedAt?.Equals(other.CreatedAt) == true) &&
                (this.CustomFields == null && other.CustomFields == null ||
                 this.CustomFields?.Equals(other.CustomFields) == true) &&
                (this.DeviceIds == null && other.DeviceIds == null ||
                 this.DeviceIds?.Equals(other.DeviceIds) == true) &&
                (this.ExtendedAttributes == null && other.ExtendedAttributes == null ||
                 this.ExtendedAttributes?.Equals(other.ExtendedAttributes) == true) &&
                (this.GroupNames == null && other.GroupNames == null ||
                 this.GroupNames?.Equals(other.GroupNames) == true) &&
                (this.Ipaddress == null && other.Ipaddress == null ||
                 this.Ipaddress?.Equals(other.Ipaddress) == true) &&
                (this.LastActivationBy == null && other.LastActivationBy == null ||
                 this.LastActivationBy?.Equals(other.LastActivationBy) == true) &&
                (this.LastActivationDate == null && other.LastActivationDate == null ||
                 this.LastActivationDate?.Equals(other.LastActivationDate) == true) &&
                (this.LastConnectionDate == null && other.LastConnectionDate == null ||
                 this.LastConnectionDate?.Equals(other.LastConnectionDate) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
            toStringOutput.Add($"BillingCycleEndDate = {this.BillingCycleEndDate ?? "null"}");
            toStringOutput.Add($"CarrierInformations = {(this.CarrierInformations == null ? "null" : $"[{string.Join(", ", this.CarrierInformations)} ]")}");
            toStringOutput.Add($"Connected = {(this.Connected == null ? "null" : this.Connected.ToString())}");
            toStringOutput.Add($"CreatedAt = {this.CreatedAt ?? "null"}");
            toStringOutput.Add($"CustomFields = {(this.CustomFields == null ? "null" : $"[{string.Join(", ", this.CustomFields)} ]")}");
            toStringOutput.Add($"DeviceIds = {(this.DeviceIds == null ? "null" : $"[{string.Join(", ", this.DeviceIds)} ]")}");
            toStringOutput.Add($"ExtendedAttributes = {(this.ExtendedAttributes == null ? "null" : $"[{string.Join(", ", this.ExtendedAttributes)} ]")}");
            toStringOutput.Add($"GroupNames = {(this.GroupNames == null ? "null" : $"[{string.Join(", ", this.GroupNames)} ]")}");
            toStringOutput.Add($"Ipaddress = {this.Ipaddress ?? "null"}");
            toStringOutput.Add($"LastActivationBy = {this.LastActivationBy ?? "null"}");
            toStringOutput.Add($"LastActivationDate = {this.LastActivationDate ?? "null"}");
            toStringOutput.Add($"LastConnectionDate = {this.LastConnectionDate ?? "null"}");
        }
    }
}