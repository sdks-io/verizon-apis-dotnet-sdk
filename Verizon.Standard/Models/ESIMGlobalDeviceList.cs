// <copyright file="ESIMGlobalDeviceList.cs" company="APIMatic">
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
    /// ESIMGlobalDeviceList.
    /// </summary>
    public class ESIMGlobalDeviceList
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ESIMGlobalDeviceList"/> class.
        /// </summary>
        public ESIMGlobalDeviceList()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ESIMGlobalDeviceList"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="provisioningStatusFilter">provisioningStatusFilter.</param>
        /// <param name="profileStatusFilter">profileStatusFilter.</param>
        /// <param name="carrierNameFilter">carrierNameFilter.</param>
        /// <param name="deviceFilter">deviceFilter.</param>
        public ESIMGlobalDeviceList(
            string accountName = null,
            Models.ProvisioningStatusFilterEnum? provisioningStatusFilter = null,
            Models.ProfileStatusFilterEnum? profileStatusFilter = null,
            string carrierNameFilter = null,
            List<Models.DeviceId2> deviceFilter = null)
        {
            this.AccountName = accountName;
            this.ProvisioningStatusFilter = provisioningStatusFilter;
            this.ProfileStatusFilter = profileStatusFilter;
            this.CarrierNameFilter = carrierNameFilter;
            this.DeviceFilter = deviceFilter;
        }

        /// <summary>
        /// The numeric name of the account.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// The last status of the device as a list filter.
        /// </summary>
        [JsonProperty("provisioningStatusFilter", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ProvisioningStatusFilterEnum? ProvisioningStatusFilter { get; set; }

        /// <summary>
        /// The last status of the device's profile as a filter.
        /// </summary>
        [JsonProperty("profileStatusFilter", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ProfileStatusFilterEnum? ProfileStatusFilter { get; set; }

        /// <summary>
        /// The cellular service provider.
        /// </summary>
        [JsonProperty("carrierNameFilter", NullValueHandling = NullValueHandling.Ignore)]
        public string CarrierNameFilter { get; set; }

        /// <summary>
        /// An array of device identifiers to filter the list.
        /// </summary>
        [JsonProperty("deviceFilter", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DeviceId2> DeviceFilter { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ESIMGlobalDeviceList : ({string.Join(", ", toStringOutput)})";
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
            return obj is ESIMGlobalDeviceList other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.ProvisioningStatusFilter == null && other.ProvisioningStatusFilter == null) || (this.ProvisioningStatusFilter?.Equals(other.ProvisioningStatusFilter) == true)) &&
                ((this.ProfileStatusFilter == null && other.ProfileStatusFilter == null) || (this.ProfileStatusFilter?.Equals(other.ProfileStatusFilter) == true)) &&
                ((this.CarrierNameFilter == null && other.CarrierNameFilter == null) || (this.CarrierNameFilter?.Equals(other.CarrierNameFilter) == true)) &&
                ((this.DeviceFilter == null && other.DeviceFilter == null) || (this.DeviceFilter?.Equals(other.DeviceFilter) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.ProvisioningStatusFilter = {(this.ProvisioningStatusFilter == null ? "null" : this.ProvisioningStatusFilter.ToString())}");
            toStringOutput.Add($"this.ProfileStatusFilter = {(this.ProfileStatusFilter == null ? "null" : this.ProfileStatusFilter.ToString())}");
            toStringOutput.Add($"this.CarrierNameFilter = {(this.CarrierNameFilter == null ? "null" : this.CarrierNameFilter)}");
            toStringOutput.Add($"this.DeviceFilter = {(this.DeviceFilter == null ? "null" : $"[{string.Join(", ", this.DeviceFilter)} ]")}");
        }
    }
}