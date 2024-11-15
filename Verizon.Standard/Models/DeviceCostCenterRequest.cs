// <copyright file="DeviceCostCenterRequest.cs" company="APIMatic">
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
    /// DeviceCostCenterRequest.
    /// </summary>
    public class DeviceCostCenterRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceCostCenterRequest"/> class.
        /// </summary>
        public DeviceCostCenterRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceCostCenterRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="costCenter">costCenter.</param>
        /// <param name="customFields">customFields.</param>
        /// <param name="devices">devices.</param>
        /// <param name="groupName">groupName.</param>
        /// <param name="primaryPlaceOfUse">primaryPlaceOfUse.</param>
        /// <param name="removeCostCenter">removeCostCenter.</param>
        /// <param name="servicePlan">servicePlan.</param>
        public DeviceCostCenterRequest(
            string accountName = null,
            string costCenter = null,
            List<Models.CustomFields> customFields = null,
            List<Models.AccountDeviceList> devices = null,
            string groupName = null,
            object primaryPlaceOfUse = null,
            bool? removeCostCenter = null,
            string servicePlan = null)
        {
            this.AccountName = accountName;
            this.CostCenter = costCenter;
            this.CustomFields = customFields;
            this.Devices = devices;
            this.GroupName = groupName;
            this.PrimaryPlaceOfUse = primaryPlaceOfUse;
            this.RemoveCostCenter = removeCostCenter;
            this.ServicePlan = servicePlan;
        }

        /// <summary>
        /// The name of a billing account.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// The new cost center code. Valid values are any string of up to 36 alphanumeric characters, space, dash, exclamation point, and pound sign.
        /// </summary>
        [JsonProperty("costCenter", NullValueHandling = NullValueHandling.Ignore)]
        public string CostCenter { get; set; }

        /// <summary>
        /// Custom field names and values, if you want to only include devices that have matching values.
        /// </summary>
        [JsonProperty("customFields", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CustomFields> CustomFields { get; set; }

        /// <summary>
        /// A list of the devices that you want to change, specified by device identifier. Do not include accountName, groupName, customFields, or servicePlan if you use this parameter.
        /// </summary>
        [JsonProperty("devices", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.AccountDeviceList> Devices { get; set; }

        /// <summary>
        /// The name of a device group, if you want to only include devices in that group.
        /// </summary>
        [JsonProperty("groupName", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// The customer name and the address of the device's primary place of use. These values are applied to all devices in the request.The Primary Place of Use location may affect taxation or have other legal implications. You may want to speak with legal and/or financial advisers before entering values for these fields.
        /// </summary>
        [JsonProperty("primaryPlaceOfUse", NullValueHandling = NullValueHandling.Ignore)]
        public object PrimaryPlaceOfUse { get; set; }

        /// <summary>
        /// Set to true to remove the cost center code value. This flag takes precedence over a new costCenter value. If this flag is true and costCenter has a value, the cost center code is removed. Do not include this parameter, or set it to false to change the costCenter value.
        /// </summary>
        [JsonProperty("removeCostCenter", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RemoveCostCenter { get; set; }

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

            return $"DeviceCostCenterRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is DeviceCostCenterRequest other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.CostCenter == null && other.CostCenter == null) || (this.CostCenter?.Equals(other.CostCenter) == true)) &&
                ((this.CustomFields == null && other.CustomFields == null) || (this.CustomFields?.Equals(other.CustomFields) == true)) &&
                ((this.Devices == null && other.Devices == null) || (this.Devices?.Equals(other.Devices) == true)) &&
                ((this.GroupName == null && other.GroupName == null) || (this.GroupName?.Equals(other.GroupName) == true)) &&
                ((this.PrimaryPlaceOfUse == null && other.PrimaryPlaceOfUse == null) || (this.PrimaryPlaceOfUse?.Equals(other.PrimaryPlaceOfUse) == true)) &&
                ((this.RemoveCostCenter == null && other.RemoveCostCenter == null) || (this.RemoveCostCenter?.Equals(other.RemoveCostCenter) == true)) &&
                ((this.ServicePlan == null && other.ServicePlan == null) || (this.ServicePlan?.Equals(other.ServicePlan) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.CostCenter = {(this.CostCenter == null ? "null" : this.CostCenter)}");
            toStringOutput.Add($"this.CustomFields = {(this.CustomFields == null ? "null" : $"[{string.Join(", ", this.CustomFields)} ]")}");
            toStringOutput.Add($"this.Devices = {(this.Devices == null ? "null" : $"[{string.Join(", ", this.Devices)} ]")}");
            toStringOutput.Add($"this.GroupName = {(this.GroupName == null ? "null" : this.GroupName)}");
            toStringOutput.Add($"PrimaryPlaceOfUse = {(this.PrimaryPlaceOfUse == null ? "null" : this.PrimaryPlaceOfUse.ToString())}");
            toStringOutput.Add($"this.RemoveCostCenter = {(this.RemoveCostCenter == null ? "null" : this.RemoveCostCenter.ToString())}");
            toStringOutput.Add($"this.ServicePlan = {(this.ServicePlan == null ? "null" : this.ServicePlan)}");
        }
    }
}