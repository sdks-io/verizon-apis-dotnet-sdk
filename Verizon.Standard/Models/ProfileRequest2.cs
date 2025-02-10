// <copyright file="ProfileRequest2.cs" company="APIMatic">
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
    /// ProfileRequest2.
    /// </summary>
    public class ProfileRequest2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileRequest2"/> class.
        /// </summary>
        public ProfileRequest2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileRequest2"/> class.
        /// </summary>
        /// <param name="devices">devices.</param>
        /// <param name="accountName">accountName.</param>
        /// <param name="carrierName">carrierName.</param>
        /// <param name="reasonCode">reasonCode.</param>
        /// <param name="etfWaiver">etfWaiver.</param>
        /// <param name="checkFallbackProfile">checkFallbackProfile.</param>
        public ProfileRequest2(
            List<Models.DeviceList2> devices = null,
            string accountName = null,
            string carrierName = null,
            string reasonCode = null,
            bool? etfWaiver = true,
            bool? checkFallbackProfile = false)
        {
            this.Devices = devices;
            this.AccountName = accountName;
            this.CarrierName = carrierName;
            this.ReasonCode = reasonCode;
            this.EtfWaiver = etfWaiver;
            this.CheckFallbackProfile = checkFallbackProfile;
        }

        /// <summary>
        /// Gets or sets Devices.
        /// </summary>
        [JsonProperty("devices", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DeviceList2> Devices { get; set; }

        /// <summary>
        /// Gets or sets AccountName.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets CarrierName.
        /// </summary>
        [JsonProperty("carrierName", NullValueHandling = NullValueHandling.Ignore)]
        public string CarrierName { get; set; }

        /// <summary>
        /// Gets or sets ReasonCode.
        /// </summary>
        [JsonProperty("reasonCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ReasonCode { get; set; }

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
            return $"ProfileRequest2 : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ProfileRequest2 other &&
                (this.Devices == null && other.Devices == null ||
                 this.Devices?.Equals(other.Devices) == true) &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.CarrierName == null && other.CarrierName == null ||
                 this.CarrierName?.Equals(other.CarrierName) == true) &&
                (this.ReasonCode == null && other.ReasonCode == null ||
                 this.ReasonCode?.Equals(other.ReasonCode) == true) &&
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
            toStringOutput.Add($"Devices = {(this.Devices == null ? "null" : $"[{string.Join(", ", this.Devices)} ]")}");
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
            toStringOutput.Add($"CarrierName = {this.CarrierName ?? "null"}");
            toStringOutput.Add($"ReasonCode = {this.ReasonCode ?? "null"}");
            toStringOutput.Add($"EtfWaiver = {(this.EtfWaiver == null ? "null" : this.EtfWaiver.ToString())}");
            toStringOutput.Add($"CheckFallbackProfile = {(this.CheckFallbackProfile == null ? "null" : this.CheckFallbackProfile.ToString())}");
        }
    }
}