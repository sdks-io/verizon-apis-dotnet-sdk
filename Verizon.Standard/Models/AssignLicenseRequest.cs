// <copyright file="AssignLicenseRequest.cs" company="APIMatic">
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
    /// AssignLicenseRequest.
    /// </summary>
    public class AssignLicenseRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssignLicenseRequest"/> class.
        /// </summary>
        public AssignLicenseRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignLicenseRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="devices">devices.</param>
        /// <param name="skuNumber">skuNumber.</param>
        public AssignLicenseRequest(
            string accountName = null,
            List<Models.LicenseDeviceList> devices = null,
            string skuNumber = null)
        {
            this.AccountName = accountName;
            this.Devices = devices;
            this.SkuNumber = skuNumber;
        }

        /// <summary>
        /// The name of a billing account.This parameter is required only if the UWS account used for the current API session has access to multiple accounts. An account name is usually numeric, and must include any leading zeros.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// A list of 4G devices.
        /// </summary>
        [JsonProperty("devices", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.LicenseDeviceList> Devices { get; set; }

        /// <summary>
        /// The Stock Keeping Unit (SKU). Valid skuNumbers for license types: “SIMSec-IoT-Lt”. (Lifetime) Once a license is assigned to a SIM, the SIM-Secure feature is enabled for the life of the SIM.“TS-BUNDLE-KTO-SIMSEC-MRC”. (Bundle) The SIM-Secure Flex license can be assigned to or removed from a SIM at any time. This SKU is bundled with other ThingSpace Services.“SIMSec-IoT”. (Flex) The SIM-Secure Flex license can be assigned to or removed from a SIM at any time. This SKU is purchased a la carte.
        /// </summary>
        [JsonProperty("skuNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string SkuNumber { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AssignLicenseRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is AssignLicenseRequest other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.Devices == null && other.Devices == null) || (this.Devices?.Equals(other.Devices) == true)) &&
                ((this.SkuNumber == null && other.SkuNumber == null) || (this.SkuNumber?.Equals(other.SkuNumber) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName == string.Empty ? "" : this.AccountName)}");
            toStringOutput.Add($"this.Devices = {(this.Devices == null ? "null" : $"[{string.Join(", ", this.Devices)} ]")}");
            toStringOutput.Add($"this.SkuNumber = {(this.SkuNumber == null ? "null" : this.SkuNumber == string.Empty ? "" : this.SkuNumber)}");
        }
    }
}