// <copyright file="ProfileRequest.cs" company="APIMatic">
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
    using APIMatic.Core.Utilities.Converters;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Verizon.Standard;
    using Verizon.Standard.Utilities;

    /// <summary>
    /// ProfileRequest.
    /// </summary>
    public class ProfileRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileRequest"/> class.
        /// </summary>
        public ProfileRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="devices">devices.</param>
        /// <param name="carrierName">carrierName.</param>
        /// <param name="servicePlan">servicePlan.</param>
        /// <param name="mdnZipCode">mdnZipCode.</param>
        /// <param name="primaryPlaceOfUse">primaryPlaceOfUse.</param>
        /// <param name="smsrOid">smsrOid.</param>
        /// <param name="carrierIpPoolName">carrierIpPoolName.</param>
        public ProfileRequest(
            string accountName,
            List<Models.DeviceList> devices,
            string carrierName = null,
            string servicePlan = null,
            string mdnZipCode = null,
            List<Models.PrimaryPlaceOfUse> primaryPlaceOfUse = null,
            string smsrOid = null,
            string carrierIpPoolName = null)
        {
            this.AccountName = accountName;
            this.Devices = devices;
            this.CarrierName = carrierName;
            this.ServicePlan = servicePlan;
            this.MdnZipCode = mdnZipCode;
            this.PrimaryPlaceOfUse = primaryPlaceOfUse;
            this.SmsrOid = smsrOid;
            this.CarrierIpPoolName = carrierIpPoolName;
        }

        /// <summary>
        /// Gets or sets AccountName.
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets Devices.
        /// </summary>
        [JsonProperty("devices")]
        public List<Models.DeviceList> Devices { get; set; }

        /// <summary>
        /// Gets or sets CarrierName.
        /// </summary>
        [JsonProperty("carrierName", NullValueHandling = NullValueHandling.Ignore)]
        public string CarrierName { get; set; }

        /// <summary>
        /// Gets or sets ServicePlan.
        /// </summary>
        [JsonProperty("servicePlan", NullValueHandling = NullValueHandling.Ignore)]
        public string ServicePlan { get; set; }

        /// <summary>
        /// Gets or sets MdnZipCode.
        /// </summary>
        [JsonProperty("mdnZipCode", NullValueHandling = NullValueHandling.Ignore)]
        public string MdnZipCode { get; set; }

        /// <summary>
        /// Gets or sets PrimaryPlaceOfUse.
        /// </summary>
        [JsonProperty("primaryPlaceOfUse", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.PrimaryPlaceOfUse> PrimaryPlaceOfUse { get; set; }

        /// <summary>
        /// Gets or sets SmsrOid.
        /// </summary>
        [JsonProperty("smsrOid", NullValueHandling = NullValueHandling.Ignore)]
        public string SmsrOid { get; set; }

        /// <summary>
        /// The name of the pool of IP addresses assigned to the profile.
        /// </summary>
        [JsonProperty("carrierIpPoolName", NullValueHandling = NullValueHandling.Ignore)]
        public string CarrierIpPoolName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ProfileRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is ProfileRequest other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.Devices == null && other.Devices == null) || (this.Devices?.Equals(other.Devices) == true)) &&
                ((this.CarrierName == null && other.CarrierName == null) || (this.CarrierName?.Equals(other.CarrierName) == true)) &&
                ((this.ServicePlan == null && other.ServicePlan == null) || (this.ServicePlan?.Equals(other.ServicePlan) == true)) &&
                ((this.MdnZipCode == null && other.MdnZipCode == null) || (this.MdnZipCode?.Equals(other.MdnZipCode) == true)) &&
                ((this.PrimaryPlaceOfUse == null && other.PrimaryPlaceOfUse == null) || (this.PrimaryPlaceOfUse?.Equals(other.PrimaryPlaceOfUse) == true)) &&
                ((this.SmsrOid == null && other.SmsrOid == null) || (this.SmsrOid?.Equals(other.SmsrOid) == true)) &&
                ((this.CarrierIpPoolName == null && other.CarrierIpPoolName == null) || (this.CarrierIpPoolName?.Equals(other.CarrierIpPoolName) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.Devices = {(this.Devices == null ? "null" : $"[{string.Join(", ", this.Devices)} ]")}");
            toStringOutput.Add($"this.CarrierName = {(this.CarrierName == null ? "null" : this.CarrierName)}");
            toStringOutput.Add($"this.ServicePlan = {(this.ServicePlan == null ? "null" : this.ServicePlan)}");
            toStringOutput.Add($"this.MdnZipCode = {(this.MdnZipCode == null ? "null" : this.MdnZipCode)}");
            toStringOutput.Add($"this.PrimaryPlaceOfUse = {(this.PrimaryPlaceOfUse == null ? "null" : $"[{string.Join(", ", this.PrimaryPlaceOfUse)} ]")}");
            toStringOutput.Add($"this.SmsrOid = {(this.SmsrOid == null ? "null" : this.SmsrOid)}");
            toStringOutput.Add($"this.CarrierIpPoolName = {(this.CarrierIpPoolName == null ? "null" : this.CarrierIpPoolName)}");
        }
    }
}