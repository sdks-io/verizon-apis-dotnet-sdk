// <copyright file="GoToStateRequest.cs" company="APIMatic">
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
    /// GoToStateRequest.
    /// </summary>
    public class GoToStateRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoToStateRequest"/> class.
        /// </summary>
        public GoToStateRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoToStateRequest"/> class.
        /// </summary>
        /// <param name="serviceName">serviceName.</param>
        /// <param name="stateName">stateName.</param>
        /// <param name="servicePlan">servicePlan.</param>
        /// <param name="mdnZipCode">mdnZipCode.</param>
        /// <param name="devices">devices.</param>
        /// <param name="filter">filter.</param>
        /// <param name="carrierIpPoolName">carrierIpPoolName.</param>
        /// <param name="publicIpRestriction">publicIpRestriction.</param>
        /// <param name="skuNumber">skuNumber.</param>
        /// <param name="customFields">customFields.</param>
        /// <param name="devicesWithServiceAddress">devicesWithServiceAddress.</param>
        /// <param name="ipaddress">ipAddress.</param>
        /// <param name="groupName">groupName.</param>
        /// <param name="primaryPlaceOfUse">primaryPlaceOfUse.</param>
        public GoToStateRequest(
            string serviceName,
            string stateName,
            string servicePlan,
            string mdnZipCode,
            List<Models.AccountDeviceList> devices = null,
            Models.DeviceFilter filter = null,
            string carrierIpPoolName = null,
            string publicIpRestriction = null,
            string skuNumber = null,
            List<Models.CustomFields> customFields = null,
            object devicesWithServiceAddress = null,
            string ipaddress = null,
            string groupName = null,
            Models.PlaceOfUse primaryPlaceOfUse = null)
        {
            this.ServiceName = serviceName;
            this.StateName = stateName;
            this.ServicePlan = servicePlan;
            this.MdnZipCode = mdnZipCode;
            this.Devices = devices;
            this.Filter = filter;
            this.CarrierIpPoolName = carrierIpPoolName;
            this.PublicIpRestriction = publicIpRestriction;
            this.SkuNumber = skuNumber;
            this.CustomFields = customFields;
            this.DevicesWithServiceAddress = devicesWithServiceAddress;
            this.Ipaddress = ipaddress;
            this.GroupName = groupName;
            this.PrimaryPlaceOfUse = primaryPlaceOfUse;
        }

        /// <summary>
        /// The name of a customer-defined service to push the devices to.
        /// </summary>
        [JsonProperty("serviceName")]
        public string ServiceName { get; set; }

        /// <summary>
        /// The name of a customer-defined stage state to push the devices to.
        /// </summary>
        [JsonProperty("stateName")]
        public string StateName { get; set; }

        /// <summary>
        /// The service plan code that you want to assign to all specified devices in the new state.
        /// </summary>
        [JsonProperty("servicePlan")]
        public string ServicePlan { get; set; }

        /// <summary>
        /// The Zip code of the location where the line of service will primarily be used, or a Zip code that you have been told to use with these devices. For accounts that are configured for geographic numbering, this is the ZIP code from which the MDN will be derived.
        /// </summary>
        [JsonProperty("mdnZipCode")]
        public string MdnZipCode { get; set; }

        /// <summary>
        /// Up to 10,000 devices that you want to push to a different state, specified by device identifier.
        /// </summary>
        [JsonProperty("devices", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.AccountDeviceList> Devices { get; set; }

        /// <summary>
        /// Specify the kind of the device identifier, the type of match, and the string that you want to match.
        /// </summary>
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DeviceFilter Filter { get; set; }

        /// <summary>
        /// The pool from which your device IP addresses will be derived if the service or state change requires new IP addresses.If you do not include this element, the default pool will be used.
        /// </summary>
        [JsonProperty("carrierIpPoolName", NullValueHandling = NullValueHandling.Ignore)]
        public string CarrierIpPoolName { get; set; }

        /// <summary>
        /// For devices with static IP addresses on the public network, this specifies whether the devices have general access to the Internet. Valid values are “restricted” or “unrestricted”.
        /// </summary>
        [JsonProperty("publicIpRestriction", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIpRestriction { get; set; }

        /// <summary>
        /// The Stock Keeping Unit (SKU) number of a 4G device type with an embedded SIM. Can be used with ICCID or EID device identifiers in lieu of an IMEI when activating 4G devices. The SkuNumber will be used with all devices in the request, so all devices must be of the same type.
        /// </summary>
        [JsonProperty("skuNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string SkuNumber { get; set; }

        /// <summary>
        /// The names and values of any custom fields that you want to set for the devices.
        /// </summary>
        [JsonProperty("customFields", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CustomFields> CustomFields { get; set; }

        /// <summary>
        /// This is an array that associates an IP address with a device identifier. This variable is only relevant for Business Internet/Fixed Wireless Access
        /// </summary>
        [JsonProperty("devicesWithServiceAddress", NullValueHandling = NullValueHandling.Ignore)]
        public object DevicesWithServiceAddress { get; set; }

        /// <summary>
        /// The IP address of the device.
        /// </summary>
        [JsonProperty("ipAddress", NullValueHandling = NullValueHandling.Ignore)]
        public string Ipaddress { get; set; }

        /// <summary>
        /// The name of a device group that the devices should be added to.
        /// </summary>
        [JsonProperty("groupName", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// The customer name and the address of the device's primary place of use. Leave these fields empty to use the account profile address as the primary place of use. These values will be applied to all devices in the request.If the account is enabled for non-geographic MDNs and the device supports it, the primaryPlaceOfUse address will also be used to derive the MDN for the device.
        /// </summary>
        [JsonProperty("primaryPlaceOfUse", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PlaceOfUse PrimaryPlaceOfUse { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GoToStateRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GoToStateRequest other &&
                (this.ServiceName == null && other.ServiceName == null ||
                 this.ServiceName?.Equals(other.ServiceName) == true) &&
                (this.StateName == null && other.StateName == null ||
                 this.StateName?.Equals(other.StateName) == true) &&
                (this.ServicePlan == null && other.ServicePlan == null ||
                 this.ServicePlan?.Equals(other.ServicePlan) == true) &&
                (this.MdnZipCode == null && other.MdnZipCode == null ||
                 this.MdnZipCode?.Equals(other.MdnZipCode) == true) &&
                (this.Devices == null && other.Devices == null ||
                 this.Devices?.Equals(other.Devices) == true) &&
                (this.Filter == null && other.Filter == null ||
                 this.Filter?.Equals(other.Filter) == true) &&
                (this.CarrierIpPoolName == null && other.CarrierIpPoolName == null ||
                 this.CarrierIpPoolName?.Equals(other.CarrierIpPoolName) == true) &&
                (this.PublicIpRestriction == null && other.PublicIpRestriction == null ||
                 this.PublicIpRestriction?.Equals(other.PublicIpRestriction) == true) &&
                (this.SkuNumber == null && other.SkuNumber == null ||
                 this.SkuNumber?.Equals(other.SkuNumber) == true) &&
                (this.CustomFields == null && other.CustomFields == null ||
                 this.CustomFields?.Equals(other.CustomFields) == true) &&
                (this.DevicesWithServiceAddress == null && other.DevicesWithServiceAddress == null ||
                 this.DevicesWithServiceAddress?.Equals(other.DevicesWithServiceAddress) == true) &&
                (this.Ipaddress == null && other.Ipaddress == null ||
                 this.Ipaddress?.Equals(other.Ipaddress) == true) &&
                (this.GroupName == null && other.GroupName == null ||
                 this.GroupName?.Equals(other.GroupName) == true) &&
                (this.PrimaryPlaceOfUse == null && other.PrimaryPlaceOfUse == null ||
                 this.PrimaryPlaceOfUse?.Equals(other.PrimaryPlaceOfUse) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ServiceName = {this.ServiceName ?? "null"}");
            toStringOutput.Add($"StateName = {this.StateName ?? "null"}");
            toStringOutput.Add($"ServicePlan = {this.ServicePlan ?? "null"}");
            toStringOutput.Add($"MdnZipCode = {this.MdnZipCode ?? "null"}");
            toStringOutput.Add($"Devices = {(this.Devices == null ? "null" : $"[{string.Join(", ", this.Devices)} ]")}");
            toStringOutput.Add($"Filter = {(this.Filter == null ? "null" : this.Filter.ToString())}");
            toStringOutput.Add($"CarrierIpPoolName = {this.CarrierIpPoolName ?? "null"}");
            toStringOutput.Add($"PublicIpRestriction = {this.PublicIpRestriction ?? "null"}");
            toStringOutput.Add($"SkuNumber = {this.SkuNumber ?? "null"}");
            toStringOutput.Add($"CustomFields = {(this.CustomFields == null ? "null" : $"[{string.Join(", ", this.CustomFields)} ]")}");
            toStringOutput.Add($"DevicesWithServiceAddress = {(this.DevicesWithServiceAddress == null ? "null" : this.DevicesWithServiceAddress.ToString())}");
            toStringOutput.Add($"Ipaddress = {this.Ipaddress ?? "null"}");
            toStringOutput.Add($"GroupName = {this.GroupName ?? "null"}");
            toStringOutput.Add($"PrimaryPlaceOfUse = {(this.PrimaryPlaceOfUse == null ? "null" : this.PrimaryPlaceOfUse.ToString())}");
        }
    }
}