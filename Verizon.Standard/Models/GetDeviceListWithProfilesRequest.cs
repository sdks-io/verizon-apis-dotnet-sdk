// <copyright file="GetDeviceListWithProfilesRequest.cs" company="APIMatic">
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
    /// GetDeviceListWithProfilesRequest.
    /// </summary>
    public class GetDeviceListWithProfilesRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeviceListWithProfilesRequest"/> class.
        /// </summary>
        public GetDeviceListWithProfilesRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeviceListWithProfilesRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="provisioningStatusFilter">provisioningStatusFilter.</param>
        /// <param name="profileStatusFilter">profileStatusFilter.</param>
        /// <param name="carrierNameFilter">carrierNameFilter.</param>
        /// <param name="deviceFilter">deviceFilter.</param>
        public GetDeviceListWithProfilesRequest(
            string accountName,
            string provisioningStatusFilter = null,
            string profileStatusFilter = null,
            string carrierNameFilter = null,
            List<Models.GIODeviceId> deviceFilter = null)
        {
            this.AccountName = accountName;
            this.ProvisioningStatusFilter = provisioningStatusFilter;
            this.ProfileStatusFilter = profileStatusFilter;
            this.CarrierNameFilter = carrierNameFilter;
            this.DeviceFilter = deviceFilter;
        }

        /// <summary>
        /// Gets or sets AccountName.
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets ProvisioningStatusFilter.
        /// </summary>
        [JsonProperty("provisioningStatusFilter", NullValueHandling = NullValueHandling.Ignore)]
        public string ProvisioningStatusFilter { get; set; }

        /// <summary>
        /// Gets or sets ProfileStatusFilter.
        /// </summary>
        [JsonProperty("profileStatusFilter", NullValueHandling = NullValueHandling.Ignore)]
        public string ProfileStatusFilter { get; set; }

        /// <summary>
        /// Gets or sets CarrierNameFilter.
        /// </summary>
        [JsonProperty("carrierNameFilter", NullValueHandling = NullValueHandling.Ignore)]
        public string CarrierNameFilter { get; set; }

        /// <summary>
        /// Gets or sets DeviceFilter.
        /// </summary>
        [JsonProperty("deviceFilter", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.GIODeviceId> DeviceFilter { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetDeviceListWithProfilesRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is GetDeviceListWithProfilesRequest other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
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
            toStringOutput.Add($"this.ProvisioningStatusFilter = {(this.ProvisioningStatusFilter == null ? "null" : this.ProvisioningStatusFilter)}");
            toStringOutput.Add($"this.ProfileStatusFilter = {(this.ProfileStatusFilter == null ? "null" : this.ProfileStatusFilter)}");
            toStringOutput.Add($"this.CarrierNameFilter = {(this.CarrierNameFilter == null ? "null" : this.CarrierNameFilter)}");
            toStringOutput.Add($"this.DeviceFilter = {(this.DeviceFilter == null ? "null" : $"[{string.Join(", ", this.DeviceFilter)} ]")}");
        }
    }
}