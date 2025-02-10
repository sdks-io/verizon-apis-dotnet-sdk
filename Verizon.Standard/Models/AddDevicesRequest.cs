// <copyright file="AddDevicesRequest.cs" company="APIMatic">
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
    /// AddDevicesRequest.
    /// </summary>
    public class AddDevicesRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddDevicesRequest"/> class.
        /// </summary>
        public AddDevicesRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddDevicesRequest"/> class.
        /// </summary>
        /// <param name="state">state.</param>
        /// <param name="devicesToAdd">devicesToAdd.</param>
        /// <param name="accountName">accountName.</param>
        /// <param name="customFields">customFields.</param>
        /// <param name="groupName">groupName.</param>
        /// <param name="skuNumber">skuNumber.</param>
        /// <param name="smsrOid">smsrOid.</param>
        public AddDevicesRequest(
            string state,
            List<Models.AccountDeviceList> devicesToAdd,
            string accountName = null,
            List<Models.CustomFields> customFields = null,
            string groupName = null,
            string skuNumber = null,
            string smsrOid = null)
        {
            this.State = state;
            this.DevicesToAdd = devicesToAdd;
            this.AccountName = accountName;
            this.CustomFields = customFields;
            this.GroupName = groupName;
            this.SkuNumber = skuNumber;
            this.SmsrOid = smsrOid;
        }

        /// <summary>
        /// The initial service state for the devices. The only valid state is “Preactive.”
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// The devices that you want to add.
        /// </summary>
        [JsonProperty("devicesToAdd")]
        public List<Models.AccountDeviceList> DevicesToAdd { get; set; }

        /// <summary>
        /// The billing account to which the devices are added.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// The names and values for any custom fields that you want set for the devices as they are added to the account.
        /// </summary>
        [JsonProperty("customFields", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CustomFields> CustomFields { get; set; }

        /// <summary>
        /// The name of a device group to add the devices to. They are added to the default device group if you don't include this parameter.
        /// </summary>
        [JsonProperty("groupName", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// The Stock Keeping Unit (SKU) number of a 4G device type with an embedded SIM.
        /// </summary>
        [JsonProperty("skuNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string SkuNumber { get; set; }

        /// <summary>
        /// Gets or sets SmsrOid.
        /// </summary>
        [JsonProperty("smsrOid", NullValueHandling = NullValueHandling.Ignore)]
        public string SmsrOid { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"AddDevicesRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AddDevicesRequest other &&
                (this.State == null && other.State == null ||
                 this.State?.Equals(other.State) == true) &&
                (this.DevicesToAdd == null && other.DevicesToAdd == null ||
                 this.DevicesToAdd?.Equals(other.DevicesToAdd) == true) &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.CustomFields == null && other.CustomFields == null ||
                 this.CustomFields?.Equals(other.CustomFields) == true) &&
                (this.GroupName == null && other.GroupName == null ||
                 this.GroupName?.Equals(other.GroupName) == true) &&
                (this.SkuNumber == null && other.SkuNumber == null ||
                 this.SkuNumber?.Equals(other.SkuNumber) == true) &&
                (this.SmsrOid == null && other.SmsrOid == null ||
                 this.SmsrOid?.Equals(other.SmsrOid) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"State = {this.State ?? "null"}");
            toStringOutput.Add($"DevicesToAdd = {(this.DevicesToAdd == null ? "null" : $"[{string.Join(", ", this.DevicesToAdd)} ]")}");
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
            toStringOutput.Add($"CustomFields = {(this.CustomFields == null ? "null" : $"[{string.Join(", ", this.CustomFields)} ]")}");
            toStringOutput.Add($"GroupName = {this.GroupName ?? "null"}");
            toStringOutput.Add($"SkuNumber = {this.SkuNumber ?? "null"}");
            toStringOutput.Add($"SmsrOid = {this.SmsrOid ?? "null"}");
        }
    }
}