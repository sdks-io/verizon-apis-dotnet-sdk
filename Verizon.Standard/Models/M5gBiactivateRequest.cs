// <copyright file="M5gBiactivateRequest.cs" company="APIMatic">
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
    /// M5gBiactivateRequest.
    /// </summary>
    public class M5gBiactivateRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="M5gBiactivateRequest"/> class.
        /// </summary>
        public M5gBiactivateRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="M5gBiactivateRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="servicePlan">servicePlan.</param>
        /// <param name="deviceListWithServiceAddress">deviceListWithServiceAddress.</param>
        /// <param name="publicIpRestriction">publicIpRestriction.</param>
        /// <param name="carrierName">carrierName.</param>
        /// <param name="mdnZipCode">mdnZipCode.</param>
        public M5gBiactivateRequest(
            string accountName = null,
            string servicePlan = null,
            List<Models.DeviceListWithServiceAddress1> deviceListWithServiceAddress = null,
            string publicIpRestriction = null,
            string carrierName = null,
            string mdnZipCode = null)
        {
            this.AccountName = accountName;
            this.ServicePlan = servicePlan;
            this.DeviceListWithServiceAddress = deviceListWithServiceAddress;
            this.PublicIpRestriction = publicIpRestriction;
            this.CarrierName = carrierName;
            this.MdnZipCode = mdnZipCode;
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
        public List<Models.DeviceListWithServiceAddress1> DeviceListWithServiceAddress { get; set; }

        /// <summary>
        /// Gets or sets PublicIpRestriction.
        /// </summary>
        [JsonProperty("publicIpRestriction", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIpRestriction { get; set; }

        /// <summary>
        /// Gets or sets CarrierName.
        /// </summary>
        [JsonProperty("carrierName", NullValueHandling = NullValueHandling.Ignore)]
        public string CarrierName { get; set; }

        /// <summary>
        /// Gets or sets MdnZipCode.
        /// </summary>
        [JsonProperty("mdnZipCode", NullValueHandling = NullValueHandling.Ignore)]
        public string MdnZipCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"M5gBiactivateRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is M5gBiactivateRequest other &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.ServicePlan == null && other.ServicePlan == null ||
                 this.ServicePlan?.Equals(other.ServicePlan) == true) &&
                (this.DeviceListWithServiceAddress == null && other.DeviceListWithServiceAddress == null ||
                 this.DeviceListWithServiceAddress?.Equals(other.DeviceListWithServiceAddress) == true) &&
                (this.PublicIpRestriction == null && other.PublicIpRestriction == null ||
                 this.PublicIpRestriction?.Equals(other.PublicIpRestriction) == true) &&
                (this.CarrierName == null && other.CarrierName == null ||
                 this.CarrierName?.Equals(other.CarrierName) == true) &&
                (this.MdnZipCode == null && other.MdnZipCode == null ||
                 this.MdnZipCode?.Equals(other.MdnZipCode) == true);
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
            toStringOutput.Add($"PublicIpRestriction = {this.PublicIpRestriction ?? "null"}");
            toStringOutput.Add($"CarrierName = {this.CarrierName ?? "null"}");
            toStringOutput.Add($"MdnZipCode = {this.MdnZipCode ?? "null"}");
        }
    }
}