// <copyright file="AccountDeviceListRequest.cs" company="APIMatic">
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
    /// AccountDeviceListRequest.
    /// </summary>
    public class AccountDeviceListRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDeviceListRequest"/> class.
        /// </summary>
        public AccountDeviceListRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDeviceListRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="filter">filter.</param>
        /// <param name="currentState">currentState.</param>
        /// <param name="customFields">customFields.</param>
        /// <param name="earliest">earliest.</param>
        /// <param name="groupName">groupName.</param>
        /// <param name="latest">latest.</param>
        /// <param name="servicePlan">servicePlan.</param>
        /// <param name="maxNumberOfDevices">maxNumberOfDevices.</param>
        /// <param name="largestDeviceIdSeen">largestDeviceIdSeen.</param>
        public AccountDeviceListRequest(
            string accountName = null,
            Models.DeviceId deviceId = null,
            Models.AccountDeviceListFilter filter = null,
            string currentState = null,
            List<Models.CustomFields> customFields = null,
            string earliest = null,
            string groupName = null,
            string latest = null,
            string servicePlan = null,
            int? maxNumberOfDevices = null,
            long? largestDeviceIdSeen = null)
        {
            this.AccountName = accountName;
            this.DeviceId = deviceId;
            this.Filter = filter;
            this.CurrentState = currentState;
            this.CustomFields = customFields;
            this.Earliest = earliest;
            this.GroupName = groupName;
            this.Latest = latest;
            this.ServicePlan = servicePlan;
            this.MaxNumberOfDevices = maxNumberOfDevices;
            this.LargestDeviceIdSeen = largestDeviceIdSeen;
        }

        /// <summary>
        /// The billing account for which a list of devices is returned. If you don't specify an accountName, the list includes all devices to which you have access.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// An identifier for a single device.
        /// </summary>
        [JsonProperty("deviceId", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DeviceId DeviceId { get; set; }

        /// <summary>
        /// Filter for a list of devices.
        /// </summary>
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AccountDeviceListFilter Filter { get; set; }

        /// <summary>
        /// The name of a device state, to only include devices in that state.
        /// </summary>
        [JsonProperty("currentState", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentState { get; set; }

        /// <summary>
        /// Custom field names and values, if you want to only include devices that have matching values.
        /// </summary>
        [JsonProperty("customFields", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CustomFields> CustomFields { get; set; }

        /// <summary>
        /// Only include devices that were added after this date and time.
        /// </summary>
        [JsonProperty("earliest", NullValueHandling = NullValueHandling.Ignore)]
        public string Earliest { get; set; }

        /// <summary>
        /// Only include devices that are in this device group.
        /// </summary>
        [JsonProperty("groupName", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// Only include devices that were added before this date and time.
        /// </summary>
        [JsonProperty("latest", NullValueHandling = NullValueHandling.Ignore)]
        public string Latest { get; set; }

        /// <summary>
        /// Only include devices that have this service plan.
        /// </summary>
        [JsonProperty("servicePlan", NullValueHandling = NullValueHandling.Ignore)]
        public string ServicePlan { get; set; }

        /// <summary>
        /// Gets or sets MaxNumberOfDevices.
        /// </summary>
        [JsonProperty("maxNumberOfDevices", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxNumberOfDevices { get; set; }

        /// <summary>
        /// Gets or sets LargestDeviceIdSeen.
        /// </summary>
        [JsonProperty("largestDeviceIdSeen", NullValueHandling = NullValueHandling.Ignore)]
        public long? LargestDeviceIdSeen { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AccountDeviceListRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is AccountDeviceListRequest other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.DeviceId == null && other.DeviceId == null) || (this.DeviceId?.Equals(other.DeviceId) == true)) &&
                ((this.Filter == null && other.Filter == null) || (this.Filter?.Equals(other.Filter) == true)) &&
                ((this.CurrentState == null && other.CurrentState == null) || (this.CurrentState?.Equals(other.CurrentState) == true)) &&
                ((this.CustomFields == null && other.CustomFields == null) || (this.CustomFields?.Equals(other.CustomFields) == true)) &&
                ((this.Earliest == null && other.Earliest == null) || (this.Earliest?.Equals(other.Earliest) == true)) &&
                ((this.GroupName == null && other.GroupName == null) || (this.GroupName?.Equals(other.GroupName) == true)) &&
                ((this.Latest == null && other.Latest == null) || (this.Latest?.Equals(other.Latest) == true)) &&
                ((this.ServicePlan == null && other.ServicePlan == null) || (this.ServicePlan?.Equals(other.ServicePlan) == true)) &&
                ((this.MaxNumberOfDevices == null && other.MaxNumberOfDevices == null) || (this.MaxNumberOfDevices?.Equals(other.MaxNumberOfDevices) == true)) &&
                ((this.LargestDeviceIdSeen == null && other.LargestDeviceIdSeen == null) || (this.LargestDeviceIdSeen?.Equals(other.LargestDeviceIdSeen) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.DeviceId = {(this.DeviceId == null ? "null" : this.DeviceId.ToString())}");
            toStringOutput.Add($"this.Filter = {(this.Filter == null ? "null" : this.Filter.ToString())}");
            toStringOutput.Add($"this.CurrentState = {(this.CurrentState == null ? "null" : this.CurrentState)}");
            toStringOutput.Add($"this.CustomFields = {(this.CustomFields == null ? "null" : $"[{string.Join(", ", this.CustomFields)} ]")}");
            toStringOutput.Add($"this.Earliest = {(this.Earliest == null ? "null" : this.Earliest)}");
            toStringOutput.Add($"this.GroupName = {(this.GroupName == null ? "null" : this.GroupName)}");
            toStringOutput.Add($"this.Latest = {(this.Latest == null ? "null" : this.Latest)}");
            toStringOutput.Add($"this.ServicePlan = {(this.ServicePlan == null ? "null" : this.ServicePlan)}");
            toStringOutput.Add($"this.MaxNumberOfDevices = {(this.MaxNumberOfDevices == null ? "null" : this.MaxNumberOfDevices.ToString())}");
            toStringOutput.Add($"this.LargestDeviceIdSeen = {(this.LargestDeviceIdSeen == null ? "null" : this.LargestDeviceIdSeen.ToString())}");
        }
    }
}