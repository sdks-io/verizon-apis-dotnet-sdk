// <copyright file="DeactivateDeviceProfileRequest.cs" company="APIMatic">
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
    /// DeactivateDeviceProfileRequest.
    /// </summary>
    public class DeactivateDeviceProfileRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeactivateDeviceProfileRequest"/> class.
        /// </summary>
        public DeactivateDeviceProfileRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeactivateDeviceProfileRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="reasonCode">reasonCode.</param>
        /// <param name="devices">devices.</param>
        /// <param name="carrierName">carrierName.</param>
        /// <param name="etfWaiver">etfWaiver.</param>
        /// <param name="checkFallbackProfile">checkFallbackProfile.</param>
        public DeactivateDeviceProfileRequest(
            string accountName,
            string reasonCode,
            List<Models.DeactivateDeviceList> devices = null,
            string carrierName = null,
            bool? etfWaiver = true,
            bool? checkFallbackProfile = false)
        {
            this.AccountName = accountName;
            this.ReasonCode = reasonCode;
            this.Devices = devices;
            this.CarrierName = carrierName;
            this.EtfWaiver = etfWaiver;
            this.CheckFallbackProfile = checkFallbackProfile;
        }

        /// <summary>
        /// Gets or sets AccountName.
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets ReasonCode.
        /// </summary>
        [JsonProperty("reasonCode")]
        public string ReasonCode { get; set; }

        /// <summary>
        /// Gets or sets Devices.
        /// </summary>
        [JsonProperty("devices", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DeactivateDeviceList> Devices { get; set; }

        /// <summary>
        /// Gets or sets CarrierName.
        /// </summary>
        [JsonProperty("carrierName", NullValueHandling = NullValueHandling.Ignore)]
        public string CarrierName { get; set; }

        /// <summary>
        /// Gets or sets EtfWaiver.
        /// </summary>
        [JsonProperty("etfWaiver", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EtfWaiver { get; set; }

        /// <summary>
        /// Gets or sets CheckFallbackProfile.
        /// </summary>
        [JsonProperty("checkFallbackProfile", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CheckFallbackProfile { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DeactivateDeviceProfileRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DeactivateDeviceProfileRequest other &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.ReasonCode == null && other.ReasonCode == null ||
                 this.ReasonCode?.Equals(other.ReasonCode) == true) &&
                (this.Devices == null && other.Devices == null ||
                 this.Devices?.Equals(other.Devices) == true) &&
                (this.CarrierName == null && other.CarrierName == null ||
                 this.CarrierName?.Equals(other.CarrierName) == true) &&
                (this.EtfWaiver == null && other.EtfWaiver == null ||
                 this.EtfWaiver?.Equals(other.EtfWaiver) == true) &&
                (this.CheckFallbackProfile == null && other.CheckFallbackProfile == null ||
                 this.CheckFallbackProfile?.Equals(other.CheckFallbackProfile) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
            toStringOutput.Add($"ReasonCode = {this.ReasonCode ?? "null"}");
            toStringOutput.Add($"Devices = {(this.Devices == null ? "null" : $"[{string.Join(", ", this.Devices)} ]")}");
            toStringOutput.Add($"CarrierName = {this.CarrierName ?? "null"}");
            toStringOutput.Add($"EtfWaiver = {(this.EtfWaiver == null ? "null" : this.EtfWaiver.ToString())}");
            toStringOutput.Add($"CheckFallbackProfile = {(this.CheckFallbackProfile == null ? "null" : this.CheckFallbackProfile.ToString())}");
        }
    }
}