// <copyright file="ServicePlanUpdateRequest.cs" company="APIMatic">
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
    /// ServicePlanUpdateRequest.
    /// </summary>
    public class ServicePlanUpdateRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServicePlanUpdateRequest"/> class.
        /// </summary>
        public ServicePlanUpdateRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServicePlanUpdateRequest"/> class.
        /// </summary>
        /// <param name="servicePlan">servicePlan.</param>
        /// <param name="accountName">accountName.</param>
        /// <param name="currentServicePlan">currentServicePlan.</param>
        /// <param name="customFields">customFields.</param>
        /// <param name="devices">devices.</param>
        /// <param name="groupName">groupName.</param>
        /// <param name="carrierIpPoolName">carrierIpPoolName.</param>
        /// <param name="takeEffect">takeEffect.</param>
        public ServicePlanUpdateRequest(
            string servicePlan,
            string accountName = null,
            string currentServicePlan = null,
            List<Models.CustomFields> customFields = null,
            List<Models.AccountDeviceList> devices = null,
            string groupName = null,
            string carrierIpPoolName = null,
            DateTime? takeEffect = null)
        {
            this.ServicePlan = servicePlan;
            this.AccountName = accountName;
            this.CurrentServicePlan = currentServicePlan;
            this.CustomFields = customFields;
            this.Devices = devices;
            this.GroupName = groupName;
            this.CarrierIpPoolName = carrierIpPoolName;
            this.TakeEffect = takeEffect;
        }

        /// <summary>
        /// The service plan code that you want to assign to all specified devices.
        /// </summary>
        [JsonProperty("servicePlan")]
        public string ServicePlan { get; set; }

        /// <summary>
        /// The name of a billing account.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// The name of a service plan, if you want to only include devices that have that service plan.
        /// </summary>
        [JsonProperty("currentServicePlan", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentServicePlan { get; set; }

        /// <summary>
        /// Custom field names and values, if you want to only include devices that have matching values.
        /// </summary>
        [JsonProperty("customFields", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CustomFields> CustomFields { get; set; }

        /// <summary>
        /// A list of the devices that you want to change, specified by device identifier.
        /// </summary>
        [JsonProperty("devices", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.AccountDeviceList> Devices { get; set; }

        /// <summary>
        /// The name of a device group, if you want to restore service for all devices in that group.
        /// </summary>
        [JsonProperty("groupName", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// Gets or sets CarrierIpPoolName.
        /// </summary>
        [JsonProperty("carrierIpPoolName", NullValueHandling = NullValueHandling.Ignore)]
        public string CarrierIpPoolName { get; set; }

        /// <summary>
        /// Gets or sets TakeEffect.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("takeEffect", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? TakeEffect { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServicePlanUpdateRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is ServicePlanUpdateRequest other &&                ((this.ServicePlan == null && other.ServicePlan == null) || (this.ServicePlan?.Equals(other.ServicePlan) == true)) &&
                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.CurrentServicePlan == null && other.CurrentServicePlan == null) || (this.CurrentServicePlan?.Equals(other.CurrentServicePlan) == true)) &&
                ((this.CustomFields == null && other.CustomFields == null) || (this.CustomFields?.Equals(other.CustomFields) == true)) &&
                ((this.Devices == null && other.Devices == null) || (this.Devices?.Equals(other.Devices) == true)) &&
                ((this.GroupName == null && other.GroupName == null) || (this.GroupName?.Equals(other.GroupName) == true)) &&
                ((this.CarrierIpPoolName == null && other.CarrierIpPoolName == null) || (this.CarrierIpPoolName?.Equals(other.CarrierIpPoolName) == true)) &&
                ((this.TakeEffect == null && other.TakeEffect == null) || (this.TakeEffect?.Equals(other.TakeEffect) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ServicePlan = {(this.ServicePlan == null ? "null" : this.ServicePlan)}");
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.CurrentServicePlan = {(this.CurrentServicePlan == null ? "null" : this.CurrentServicePlan)}");
            toStringOutput.Add($"this.CustomFields = {(this.CustomFields == null ? "null" : $"[{string.Join(", ", this.CustomFields)} ]")}");
            toStringOutput.Add($"this.Devices = {(this.Devices == null ? "null" : $"[{string.Join(", ", this.Devices)} ]")}");
            toStringOutput.Add($"this.GroupName = {(this.GroupName == null ? "null" : this.GroupName)}");
            toStringOutput.Add($"this.CarrierIpPoolName = {(this.CarrierIpPoolName == null ? "null" : this.CarrierIpPoolName)}");
            toStringOutput.Add($"this.TakeEffect = {(this.TakeEffect == null ? "null" : this.TakeEffect.ToString())}");
        }
    }
}