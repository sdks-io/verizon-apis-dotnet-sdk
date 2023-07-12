// <copyright file="CarrierActivateRequest.cs" company="APIMatic">
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
    /// CarrierActivateRequest.
    /// </summary>
    public class CarrierActivateRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CarrierActivateRequest"/> class.
        /// </summary>
        public CarrierActivateRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CarrierActivateRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="carrierIpPoolName">carrierIpPoolName.</param>
        /// <param name="carrierName">carrierName.</param>
        /// <param name="costCenterCode">costCenterCode.</param>
        /// <param name="customFields">customFields.</param>
        /// <param name="devices">devices.</param>
        /// <param name="groupName">groupName.</param>
        /// <param name="leadId">leadId.</param>
        /// <param name="mdnZipCode">mdnZipCode.</param>
        /// <param name="primaryPlaceOfUse">primaryPlaceOfUse.</param>
        /// <param name="publicIpRestriction">publicIpRestriction.</param>
        /// <param name="servicePlan">servicePlan.</param>
        /// <param name="skuNumber">skuNumber.</param>
        public CarrierActivateRequest(
            string accountName = null,
            string carrierIpPoolName = null,
            string carrierName = null,
            string costCenterCode = null,
            List<Models.CustomFields> customFields = null,
            List<Models.AccountDeviceList> devices = null,
            string groupName = null,
            string leadId = null,
            string mdnZipCode = null,
            Models.PlaceOfUse primaryPlaceOfUse = null,
            string publicIpRestriction = null,
            string servicePlan = null,
            string skuNumber = null)
        {
            this.AccountName = accountName;
            this.CarrierIpPoolName = carrierIpPoolName;
            this.CarrierName = carrierName;
            this.CostCenterCode = costCenterCode;
            this.CustomFields = customFields;
            this.Devices = devices;
            this.GroupName = groupName;
            this.LeadId = leadId;
            this.MdnZipCode = mdnZipCode;
            this.PrimaryPlaceOfUse = primaryPlaceOfUse;
            this.PublicIpRestriction = publicIpRestriction;
            this.ServicePlan = servicePlan;
            this.SkuNumber = skuNumber;
        }

        /// <summary>
        /// The name of a billing account.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// The private IP pool (Carrier Group Name) from which your device IP addresses will be derived.
        /// </summary>
        [JsonProperty("carrierIpPoolName", NullValueHandling = NullValueHandling.Ignore)]
        public string CarrierIpPoolName { get; set; }

        /// <summary>
        /// The carrier that will perform the activation.
        /// </summary>
        [JsonProperty("carrierName", NullValueHandling = NullValueHandling.Ignore)]
        public string CarrierName { get; set; }

        /// <summary>
        /// A string to identify the cost center that the device is associated with.
        /// </summary>
        [JsonProperty("costCenterCode", NullValueHandling = NullValueHandling.Ignore)]
        public string CostCenterCode { get; set; }

        /// <summary>
        /// A user-defined descriptive field, limited to 50 characters.
        /// </summary>
        [JsonProperty("customFields", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CustomFields> CustomFields { get; set; }

        /// <summary>
        /// Up to 10,000 devices for which you want to activate service, specified by device identifier.
        /// </summary>
        [JsonProperty("devices", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.AccountDeviceList> Devices { get; set; }

        /// <summary>
        /// If you specify devices by ID in the devices parameters, this is the name of a device group that the devices should be added to.If you don't specify individual devices with the devices parameter, you can provide the name of a device group to activate all devices in that group.
        /// </summary>
        [JsonProperty("groupName", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// The ID of a “Qualified” or “Closed - Won” VPP customer lead, which is used with other values to determine MDN assignment, taxation, and compensation.
        /// </summary>
        [JsonProperty("leadId", NullValueHandling = NullValueHandling.Ignore)]
        public string LeadId { get; set; }

        /// <summary>
        /// The Zip code of the location where the line of service will primarily be used, or a Zip code that you have been told to use with these devices. For accounts that are configured for geographic numbering, this is the ZIP code from which the MDN will be derived.
        /// </summary>
        [JsonProperty("mdnZipCode", NullValueHandling = NullValueHandling.Ignore)]
        public string MdnZipCode { get; set; }

        /// <summary>
        /// The customer name and the address of the device's primary place of use. Leave these fields empty to use the account profile address as the primary place of use. These values will be applied to all devices in the request.If the account is enabled for non-geographic MDNs and the device supports it, the primaryPlaceOfUse address will also be used to derive the MDN for the device.
        /// </summary>
        [JsonProperty("primaryPlaceOfUse", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PlaceOfUse PrimaryPlaceOfUse { get; set; }

        /// <summary>
        /// For devices with static IP addresses on the public network, this specifies whether the devices have general access to the Internet.
        /// </summary>
        [JsonProperty("publicIpRestriction", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIpRestriction { get; set; }

        /// <summary>
        /// The service plan code that you want to assign to all specified devices.
        /// </summary>
        [JsonProperty("servicePlan", NullValueHandling = NullValueHandling.Ignore)]
        public string ServicePlan { get; set; }

        /// <summary>
        /// The Stock Keeping Unit (SKU) of a 4G device type can be used with ICCID device identifiers in lieu of an IMEI when activating 4G devices. The SkuNumber will be used with all devices in the request, so all devices must be of the same type.
        /// </summary>
        [JsonProperty("skuNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string SkuNumber { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CarrierActivateRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is CarrierActivateRequest other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.CarrierIpPoolName == null && other.CarrierIpPoolName == null) || (this.CarrierIpPoolName?.Equals(other.CarrierIpPoolName) == true)) &&
                ((this.CarrierName == null && other.CarrierName == null) || (this.CarrierName?.Equals(other.CarrierName) == true)) &&
                ((this.CostCenterCode == null && other.CostCenterCode == null) || (this.CostCenterCode?.Equals(other.CostCenterCode) == true)) &&
                ((this.CustomFields == null && other.CustomFields == null) || (this.CustomFields?.Equals(other.CustomFields) == true)) &&
                ((this.Devices == null && other.Devices == null) || (this.Devices?.Equals(other.Devices) == true)) &&
                ((this.GroupName == null && other.GroupName == null) || (this.GroupName?.Equals(other.GroupName) == true)) &&
                ((this.LeadId == null && other.LeadId == null) || (this.LeadId?.Equals(other.LeadId) == true)) &&
                ((this.MdnZipCode == null && other.MdnZipCode == null) || (this.MdnZipCode?.Equals(other.MdnZipCode) == true)) &&
                ((this.PrimaryPlaceOfUse == null && other.PrimaryPlaceOfUse == null) || (this.PrimaryPlaceOfUse?.Equals(other.PrimaryPlaceOfUse) == true)) &&
                ((this.PublicIpRestriction == null && other.PublicIpRestriction == null) || (this.PublicIpRestriction?.Equals(other.PublicIpRestriction) == true)) &&
                ((this.ServicePlan == null && other.ServicePlan == null) || (this.ServicePlan?.Equals(other.ServicePlan) == true)) &&
                ((this.SkuNumber == null && other.SkuNumber == null) || (this.SkuNumber?.Equals(other.SkuNumber) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName == string.Empty ? "" : this.AccountName)}");
            toStringOutput.Add($"this.CarrierIpPoolName = {(this.CarrierIpPoolName == null ? "null" : this.CarrierIpPoolName == string.Empty ? "" : this.CarrierIpPoolName)}");
            toStringOutput.Add($"this.CarrierName = {(this.CarrierName == null ? "null" : this.CarrierName == string.Empty ? "" : this.CarrierName)}");
            toStringOutput.Add($"this.CostCenterCode = {(this.CostCenterCode == null ? "null" : this.CostCenterCode == string.Empty ? "" : this.CostCenterCode)}");
            toStringOutput.Add($"this.CustomFields = {(this.CustomFields == null ? "null" : $"[{string.Join(", ", this.CustomFields)} ]")}");
            toStringOutput.Add($"this.Devices = {(this.Devices == null ? "null" : $"[{string.Join(", ", this.Devices)} ]")}");
            toStringOutput.Add($"this.GroupName = {(this.GroupName == null ? "null" : this.GroupName == string.Empty ? "" : this.GroupName)}");
            toStringOutput.Add($"this.LeadId = {(this.LeadId == null ? "null" : this.LeadId == string.Empty ? "" : this.LeadId)}");
            toStringOutput.Add($"this.MdnZipCode = {(this.MdnZipCode == null ? "null" : this.MdnZipCode == string.Empty ? "" : this.MdnZipCode)}");
            toStringOutput.Add($"this.PrimaryPlaceOfUse = {(this.PrimaryPlaceOfUse == null ? "null" : this.PrimaryPlaceOfUse.ToString())}");
            toStringOutput.Add($"this.PublicIpRestriction = {(this.PublicIpRestriction == null ? "null" : this.PublicIpRestriction == string.Empty ? "" : this.PublicIpRestriction)}");
            toStringOutput.Add($"this.ServicePlan = {(this.ServicePlan == null ? "null" : this.ServicePlan == string.Empty ? "" : this.ServicePlan)}");
            toStringOutput.Add($"this.SkuNumber = {(this.SkuNumber == null ? "null" : this.SkuNumber == string.Empty ? "" : this.SkuNumber)}");
        }
    }
}