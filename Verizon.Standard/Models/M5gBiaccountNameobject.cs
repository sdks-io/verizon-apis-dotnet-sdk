// <copyright file="M5gBiaccountNameobject.cs" company="APIMatic">
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
    /// M5gBiaccountNameobject.
    /// </summary>
    public class M5gBiaccountNameobject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="M5gBiaccountNameobject"/> class.
        /// </summary>
        public M5gBiaccountNameobject()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="M5gBiaccountNameobject"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="billingCycleEndDate">billingCycleEndDate.</param>
        /// <param name="carrierInformation">carrierInformation.</param>
        /// <param name="connected">connected.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="customFields">customFields.</param>
        /// <param name="deviceIds">deviceIds.</param>
        /// <param name="extendedAttributes">extendedAttributes.</param>
        /// <param name="groupNames">groupNames.</param>
        /// <param name="ipaddress">ipAddress.</param>
        /// <param name="lastActivationBy">lastActivationBy.</param>
        /// <param name="lastActivationDate">lastActivationDate.</param>
        public M5gBiaccountNameobject(
            string accountName = null,
            string billingCycleEndDate = null,
            List<Models.M5gBiCarrierInformation> carrierInformation = null,
            bool? connected = null,
            string createdAt = null,
            List<Models.M5gBikeyValue1> customFields = null,
            List<Models.M5gBideviceId1> deviceIds = null,
            List<Models.M5gBikeyValue1> extendedAttributes = null,
            List<Models.GroupName> groupNames = null,
            string ipaddress = null,
            string lastActivationBy = null,
            string lastActivationDate = null)
        {
            this.AccountName = accountName;
            this.BillingCycleEndDate = billingCycleEndDate;
            this.CarrierInformation = carrierInformation;
            this.Connected = connected;
            this.CreatedAt = createdAt;
            this.CustomFields = customFields;
            this.DeviceIds = deviceIds;
            this.ExtendedAttributes = extendedAttributes;
            this.GroupNames = groupNames;
            this.Ipaddress = ipaddress;
            this.LastActivationBy = lastActivationBy;
            this.LastActivationDate = lastActivationDate;
        }

        /// <summary>
        /// Gets or sets AccountName.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets BillingCycleEndDate.
        /// </summary>
        [JsonProperty("billingCycleEndDate", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingCycleEndDate { get; set; }

        /// <summary>
        /// Gets or sets CarrierInformation.
        /// </summary>
        [JsonProperty("carrierInformation", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.M5gBiCarrierInformation> CarrierInformation { get; set; }

        /// <summary>
        /// Gets or sets Connected.
        /// </summary>
        [JsonProperty("connected", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Connected { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonProperty("createdAt", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets CustomFields.
        /// </summary>
        [JsonProperty("customFields", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.M5gBikeyValue1> CustomFields { get; set; }

        /// <summary>
        /// Gets or sets DeviceIds.
        /// </summary>
        [JsonProperty("deviceIds", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.M5gBideviceId1> DeviceIds { get; set; }

        /// <summary>
        /// Gets or sets ExtendedAttributes.
        /// </summary>
        [JsonProperty("extendedAttributes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.M5gBikeyValue1> ExtendedAttributes { get; set; }

        /// <summary>
        /// Gets or sets GroupNames.
        /// </summary>
        [JsonProperty("groupNames", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.GroupName> GroupNames { get; set; }

        /// <summary>
        /// Gets or sets Ipaddress.
        /// </summary>
        [JsonProperty("ipAddress", NullValueHandling = NullValueHandling.Ignore)]
        public string Ipaddress { get; set; }

        /// <summary>
        /// Gets or sets LastActivationBy.
        /// </summary>
        [JsonProperty("lastActivationBy", NullValueHandling = NullValueHandling.Ignore)]
        public string LastActivationBy { get; set; }

        /// <summary>
        /// Gets or sets LastActivationDate.
        /// </summary>
        [JsonProperty("lastActivationDate", NullValueHandling = NullValueHandling.Ignore)]
        public string LastActivationDate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"M5gBiaccountNameobject : ({string.Join(", ", toStringOutput)})";
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
            return obj is M5gBiaccountNameobject other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.BillingCycleEndDate == null && other.BillingCycleEndDate == null) || (this.BillingCycleEndDate?.Equals(other.BillingCycleEndDate) == true)) &&
                ((this.CarrierInformation == null && other.CarrierInformation == null) || (this.CarrierInformation?.Equals(other.CarrierInformation) == true)) &&
                ((this.Connected == null && other.Connected == null) || (this.Connected?.Equals(other.Connected) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.CustomFields == null && other.CustomFields == null) || (this.CustomFields?.Equals(other.CustomFields) == true)) &&
                ((this.DeviceIds == null && other.DeviceIds == null) || (this.DeviceIds?.Equals(other.DeviceIds) == true)) &&
                ((this.ExtendedAttributes == null && other.ExtendedAttributes == null) || (this.ExtendedAttributes?.Equals(other.ExtendedAttributes) == true)) &&
                ((this.GroupNames == null && other.GroupNames == null) || (this.GroupNames?.Equals(other.GroupNames) == true)) &&
                ((this.Ipaddress == null && other.Ipaddress == null) || (this.Ipaddress?.Equals(other.Ipaddress) == true)) &&
                ((this.LastActivationBy == null && other.LastActivationBy == null) || (this.LastActivationBy?.Equals(other.LastActivationBy) == true)) &&
                ((this.LastActivationDate == null && other.LastActivationDate == null) || (this.LastActivationDate?.Equals(other.LastActivationDate) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.BillingCycleEndDate = {(this.BillingCycleEndDate == null ? "null" : this.BillingCycleEndDate)}");
            toStringOutput.Add($"this.CarrierInformation = {(this.CarrierInformation == null ? "null" : $"[{string.Join(", ", this.CarrierInformation)} ]")}");
            toStringOutput.Add($"this.Connected = {(this.Connected == null ? "null" : this.Connected.ToString())}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt)}");
            toStringOutput.Add($"this.CustomFields = {(this.CustomFields == null ? "null" : $"[{string.Join(", ", this.CustomFields)} ]")}");
            toStringOutput.Add($"this.DeviceIds = {(this.DeviceIds == null ? "null" : $"[{string.Join(", ", this.DeviceIds)} ]")}");
            toStringOutput.Add($"this.ExtendedAttributes = {(this.ExtendedAttributes == null ? "null" : $"[{string.Join(", ", this.ExtendedAttributes)} ]")}");
            toStringOutput.Add($"this.GroupNames = {(this.GroupNames == null ? "null" : $"[{string.Join(", ", this.GroupNames)} ]")}");
            toStringOutput.Add($"this.Ipaddress = {(this.Ipaddress == null ? "null" : this.Ipaddress)}");
            toStringOutput.Add($"this.LastActivationBy = {(this.LastActivationBy == null ? "null" : this.LastActivationBy)}");
            toStringOutput.Add($"this.LastActivationDate = {(this.LastActivationDate == null ? "null" : this.LastActivationDate)}");
        }
    }
}