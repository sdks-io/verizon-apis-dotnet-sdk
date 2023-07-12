// <copyright file="ContactInfoUpdateRequest.cs" company="APIMatic">
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
    /// ContactInfoUpdateRequest.
    /// </summary>
    public class ContactInfoUpdateRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactInfoUpdateRequest"/> class.
        /// </summary>
        public ContactInfoUpdateRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactInfoUpdateRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="devices">devices.</param>
        /// <param name="primaryPlaceOfUse">primaryPlaceOfUse.</param>
        public ContactInfoUpdateRequest(
            string accountName = null,
            List<Models.AccountDeviceList> devices = null,
            object primaryPlaceOfUse = null)
        {
            this.AccountName = accountName;
            this.Devices = devices;
            this.PrimaryPlaceOfUse = primaryPlaceOfUse;
        }

        /// <summary>
        /// The name of the billing account that the devices belong to. An account name is usually numeric, and must include any leading zeros.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// A list of the devices that you want to change, specified by device identifier. You only need to provide one identifier per device. Do not include accountName, groupName, customFields, or servicePlan if you use this parameter.
        /// </summary>
        [JsonProperty("devices", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.AccountDeviceList> Devices { get; set; }

        /// <summary>
        /// The customer name and the address of the device's primary place of use. These values are applied to all devices in the request.The Primary Place of Use location may affect taxation or have other legal implications. You may want to speak with legal and/or financial advisers before entering values for these fields.
        /// </summary>
        [JsonProperty("primaryPlaceOfUse", NullValueHandling = NullValueHandling.Ignore)]
        public object PrimaryPlaceOfUse { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ContactInfoUpdateRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is ContactInfoUpdateRequest other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.Devices == null && other.Devices == null) || (this.Devices?.Equals(other.Devices) == true)) &&
                ((this.PrimaryPlaceOfUse == null && other.PrimaryPlaceOfUse == null) || (this.PrimaryPlaceOfUse?.Equals(other.PrimaryPlaceOfUse) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName == string.Empty ? "" : this.AccountName)}");
            toStringOutput.Add($"this.Devices = {(this.Devices == null ? "null" : $"[{string.Join(", ", this.Devices)} ]")}");
            toStringOutput.Add($"PrimaryPlaceOfUse = {(this.PrimaryPlaceOfUse == null ? "null" : this.PrimaryPlaceOfUse.ToString())}");
        }
    }
}