// <copyright file="M5gBichangeRequest.cs" company="APIMatic">
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
    /// M5gBichangeRequest.
    /// </summary>
    public class M5gBichangeRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="M5gBichangeRequest"/> class.
        /// </summary>
        public M5gBichangeRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="M5gBichangeRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="servicePlan">servicePlan.</param>
        /// <param name="deviceListWithServiceAddress">deviceListWithServiceAddress.</param>
        /// <param name="currentServicePlan">currentServicePlan.</param>
        public M5gBichangeRequest(
            string accountName = null,
            string servicePlan = null,
            List<Models.DeviceListWithServiceAddress> deviceListWithServiceAddress = null,
            string currentServicePlan = null)
        {
            this.AccountName = accountName;
            this.ServicePlan = servicePlan;
            this.DeviceListWithServiceAddress = deviceListWithServiceAddress;
            this.CurrentServicePlan = currentServicePlan;
        }

        /// <summary>
        /// Gets or sets AccountName.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets ServicePlan.
        /// </summary>
        [JsonProperty("servicePlan", NullValueHandling = NullValueHandling.Ignore)]
        public string ServicePlan { get; set; }

        /// <summary>
        /// Gets or sets DeviceListWithServiceAddress.
        /// </summary>
        [JsonProperty("deviceListWithServiceAddress", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DeviceListWithServiceAddress> DeviceListWithServiceAddress { get; set; }

        /// <summary>
        /// Gets or sets CurrentServicePlan.
        /// </summary>
        [JsonProperty("currentServicePlan", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentServicePlan { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"M5gBichangeRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is M5gBichangeRequest other &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.ServicePlan == null && other.ServicePlan == null ||
                 this.ServicePlan?.Equals(other.ServicePlan) == true) &&
                (this.DeviceListWithServiceAddress == null && other.DeviceListWithServiceAddress == null ||
                 this.DeviceListWithServiceAddress?.Equals(other.DeviceListWithServiceAddress) == true) &&
                (this.CurrentServicePlan == null && other.CurrentServicePlan == null ||
                 this.CurrentServicePlan?.Equals(other.CurrentServicePlan) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
            toStringOutput.Add($"ServicePlan = {this.ServicePlan ?? "null"}");
            toStringOutput.Add($"DeviceListWithServiceAddress = {(this.DeviceListWithServiceAddress == null ? "null" : $"[{string.Join(", ", this.DeviceListWithServiceAddress)} ]")}");
            toStringOutput.Add($"CurrentServicePlan = {this.CurrentServicePlan ?? "null"}");
        }
    }
}