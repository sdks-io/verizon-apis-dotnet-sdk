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
        /// <param name="devices">devices.</param>
        /// <param name="carrierName">carrierName.</param>
        /// <param name="accountName">accountName.</param>
        /// <param name="servicePlan">servicePlan.</param>
        /// <param name="mdnZipCode">mdnZipCode.</param>
        /// <param name="primaryPlaceOfUse">primaryPlaceOfUse.</param>
        public ProfileRequest(
            List<Models.DeviceList> devices = null,
            string carrierName = null,
            string accountName = null,
            string servicePlan = null,
            string mdnZipCode = null,
            List<Models.PrimaryPlaceOfUse> primaryPlaceOfUse = null)
        {
            this.Devices = devices;
            this.CarrierName = carrierName;
            this.AccountName = accountName;
            this.ServicePlan = servicePlan;
            this.MdnZipCode = mdnZipCode;
            this.PrimaryPlaceOfUse = primaryPlaceOfUse;
        }

        /// <summary>
        /// Gets or sets Devices.
        /// </summary>
        [JsonProperty("devices", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DeviceList> Devices { get; set; }

        /// <summary>
        /// Gets or sets CarrierName.
        /// </summary>
        [JsonProperty("carrierName", NullValueHandling = NullValueHandling.Ignore)]
        public string CarrierName { get; set; }

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
        /// Gets or sets MdnZipCode.
        /// </summary>
        [JsonProperty("mdnZipCode", NullValueHandling = NullValueHandling.Ignore)]
        public string MdnZipCode { get; set; }

        /// <summary>
        /// Gets or sets PrimaryPlaceOfUse.
        /// </summary>
        [JsonProperty("primaryPlaceOfUse", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.PrimaryPlaceOfUse> PrimaryPlaceOfUse { get; set; }

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
            return obj is ProfileRequest other &&                ((this.Devices == null && other.Devices == null) || (this.Devices?.Equals(other.Devices) == true)) &&
                ((this.CarrierName == null && other.CarrierName == null) || (this.CarrierName?.Equals(other.CarrierName) == true)) &&
                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.ServicePlan == null && other.ServicePlan == null) || (this.ServicePlan?.Equals(other.ServicePlan) == true)) &&
                ((this.MdnZipCode == null && other.MdnZipCode == null) || (this.MdnZipCode?.Equals(other.MdnZipCode) == true)) &&
                ((this.PrimaryPlaceOfUse == null && other.PrimaryPlaceOfUse == null) || (this.PrimaryPlaceOfUse?.Equals(other.PrimaryPlaceOfUse) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Devices = {(this.Devices == null ? "null" : $"[{string.Join(", ", this.Devices)} ]")}");
            toStringOutput.Add($"this.CarrierName = {(this.CarrierName == null ? "null" : this.CarrierName == string.Empty ? "" : this.CarrierName)}");
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName == string.Empty ? "" : this.AccountName)}");
            toStringOutput.Add($"this.ServicePlan = {(this.ServicePlan == null ? "null" : this.ServicePlan == string.Empty ? "" : this.ServicePlan)}");
            toStringOutput.Add($"this.MdnZipCode = {(this.MdnZipCode == null ? "null" : this.MdnZipCode == string.Empty ? "" : this.MdnZipCode)}");
            toStringOutput.Add($"this.PrimaryPlaceOfUse = {(this.PrimaryPlaceOfUse == null ? "null" : $"[{string.Join(", ", this.PrimaryPlaceOfUse)} ]")}");
        }
    }
}