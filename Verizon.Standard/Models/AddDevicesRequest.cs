// <copyright file="AddDevicesRequest.cs" company="APIMatic">
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
        /// <param name="accountName">accountName.</param>
        /// <param name="customFields">customFields.</param>
        /// <param name="devicesToAdd">devicesToAdd.</param>
        /// <param name="groupName">groupName.</param>
        /// <param name="skuNumber">skuNumber.</param>
        /// <param name="state">state.</param>
        public AddDevicesRequest(
            string accountName = null,
            List<Models.CustomFields> customFields = null,
            List<Models.AccountDeviceList> devicesToAdd = null,
            string groupName = null,
            string skuNumber = null,
            string state = null)
        {
            this.AccountName = accountName;
            this.CustomFields = customFields;
            this.DevicesToAdd = devicesToAdd;
            this.GroupName = groupName;
            this.SkuNumber = skuNumber;
            this.State = state;
        }

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
        /// The devices that you want to add.
        /// </summary>
        [JsonProperty("devicesToAdd", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.AccountDeviceList> DevicesToAdd { get; set; }

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
        /// The initial service state for the devices. The only valid state is “Preactive.”
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is AddDevicesRequest other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.CustomFields == null && other.CustomFields == null) || (this.CustomFields?.Equals(other.CustomFields) == true)) &&
                ((this.DevicesToAdd == null && other.DevicesToAdd == null) || (this.DevicesToAdd?.Equals(other.DevicesToAdd) == true)) &&
                ((this.GroupName == null && other.GroupName == null) || (this.GroupName?.Equals(other.GroupName) == true)) &&
                ((this.SkuNumber == null && other.SkuNumber == null) || (this.SkuNumber?.Equals(other.SkuNumber) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName == string.Empty ? "" : this.AccountName)}");
            toStringOutput.Add($"this.CustomFields = {(this.CustomFields == null ? "null" : $"[{string.Join(", ", this.CustomFields)} ]")}");
            toStringOutput.Add($"this.DevicesToAdd = {(this.DevicesToAdd == null ? "null" : $"[{string.Join(", ", this.DevicesToAdd)} ]")}");
            toStringOutput.Add($"this.GroupName = {(this.GroupName == null ? "null" : this.GroupName == string.Empty ? "" : this.GroupName)}");
            toStringOutput.Add($"this.SkuNumber = {(this.SkuNumber == null ? "null" : this.SkuNumber == string.Empty ? "" : this.SkuNumber)}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State == string.Empty ? "" : this.State)}");
        }
    }
}