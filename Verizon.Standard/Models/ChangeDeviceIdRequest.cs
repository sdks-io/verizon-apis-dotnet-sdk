// <copyright file="ChangeDeviceIdRequest.cs" company="APIMatic">
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
    /// ChangeDeviceIdRequest.
    /// </summary>
    public class ChangeDeviceIdRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeDeviceIdRequest"/> class.
        /// </summary>
        public ChangeDeviceIdRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeDeviceIdRequest"/> class.
        /// </summary>
        /// <param name="deviceIds">deviceIds.</param>
        /// <param name="assignNonGeoMdn">assignNonGeoMdn.</param>
        /// <param name="change4gOption">change4gOption.</param>
        /// <param name="deviceIdsTo">deviceIdsTo.</param>
        /// <param name="npaNxx">npaNxx.</param>
        /// <param name="servicePlan">servicePlan.</param>
        /// <param name="zipCode">zipCode.</param>
        /// <param name="smsrOid">smsrOid.</param>
        public ChangeDeviceIdRequest(
            List<Models.DeviceId> deviceIds,
            bool? assignNonGeoMdn = null,
            string change4gOption = null,
            List<Models.DeviceId> deviceIdsTo = null,
            string npaNxx = null,
            string servicePlan = null,
            string zipCode = null,
            string smsrOid = null)
        {
            this.AssignNonGeoMdn = assignNonGeoMdn;
            this.Change4gOption = change4gOption;
            this.DeviceIds = deviceIds;
            this.DeviceIdsTo = deviceIdsTo;
            this.NpaNxx = npaNxx;
            this.ServicePlan = servicePlan;
            this.ZipCode = zipCode;
            this.SmsrOid = smsrOid;
        }

        /// <summary>
        /// Set to true to assign a non-Geo MDN and MSISDN, or false to assign an MDN and MSISDN from a specific NPA-NXX.
        /// </summary>
        [JsonProperty("assignNonGeoMdn", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AssignNonGeoMdn { get; set; }

        /// <summary>
        /// The type of change that you want to make for a 4G device.
        /// </summary>
        [JsonProperty("change4gOption", NullValueHandling = NullValueHandling.Ignore)]
        public string Change4gOption { get; set; }

        /// <summary>
        /// The device that you want to change, specified by a device identifier.
        /// </summary>
        [JsonProperty("deviceIds")]
        public List<Models.DeviceId> DeviceIds { get; set; }

        /// <summary>
        /// The new identifier for the device. Required for all change4GOptions except ChangeMSISDN.
        /// </summary>
        [JsonProperty("deviceIdsTo", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DeviceId> DeviceIdsTo { get; set; }

        /// <summary>
        /// The NPA NXX (area code and prefix) from which the MDN and MSISDN will be derived when assignNonGeoMDN is false. Specify the 6-digit NPA NXX of the location where the line of service will primarily be used. This API checks to see if a number starting with the NPA NXX is available. If not, this API uses the zipCode parameter, if specified, to assign a number in the area of the line of service. This parameter is required when you change an MDN/MSISDN for a B2B carrier, such as Verizon Wireless.
        /// </summary>
        [JsonProperty("npaNxx", NullValueHandling = NullValueHandling.Ignore)]
        public string NpaNxx { get; set; }

        /// <summary>
        /// The code for a different service plan, if you want to change the service plan while changing the device identifier. Set this parameter to one of the Code values returned by GET /plans.
        /// </summary>
        [JsonProperty("servicePlan", NullValueHandling = NullValueHandling.Ignore)]
        public string ServicePlan { get; set; }

        /// <summary>
        /// The ZIP code from which the MDN and MSISDN will be derived when assignNonGeoMDN is true. Specify the zip code of the location where the line of service will primarily be used.
        /// </summary>
        [JsonProperty("zipCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ZipCode { get; set; }

        /// <summary>
        /// Gets or sets SmsrOid.
        /// </summary>
        [JsonProperty("smsrOid", NullValueHandling = NullValueHandling.Ignore)]
        public string SmsrOid { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ChangeDeviceIdRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is ChangeDeviceIdRequest other &&                ((this.AssignNonGeoMdn == null && other.AssignNonGeoMdn == null) || (this.AssignNonGeoMdn?.Equals(other.AssignNonGeoMdn) == true)) &&
                ((this.Change4gOption == null && other.Change4gOption == null) || (this.Change4gOption?.Equals(other.Change4gOption) == true)) &&
                ((this.DeviceIds == null && other.DeviceIds == null) || (this.DeviceIds?.Equals(other.DeviceIds) == true)) &&
                ((this.DeviceIdsTo == null && other.DeviceIdsTo == null) || (this.DeviceIdsTo?.Equals(other.DeviceIdsTo) == true)) &&
                ((this.NpaNxx == null && other.NpaNxx == null) || (this.NpaNxx?.Equals(other.NpaNxx) == true)) &&
                ((this.ServicePlan == null && other.ServicePlan == null) || (this.ServicePlan?.Equals(other.ServicePlan) == true)) &&
                ((this.ZipCode == null && other.ZipCode == null) || (this.ZipCode?.Equals(other.ZipCode) == true)) &&
                ((this.SmsrOid == null && other.SmsrOid == null) || (this.SmsrOid?.Equals(other.SmsrOid) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AssignNonGeoMdn = {(this.AssignNonGeoMdn == null ? "null" : this.AssignNonGeoMdn.ToString())}");
            toStringOutput.Add($"this.Change4gOption = {(this.Change4gOption == null ? "null" : this.Change4gOption)}");
            toStringOutput.Add($"this.DeviceIds = {(this.DeviceIds == null ? "null" : $"[{string.Join(", ", this.DeviceIds)} ]")}");
            toStringOutput.Add($"this.DeviceIdsTo = {(this.DeviceIdsTo == null ? "null" : $"[{string.Join(", ", this.DeviceIdsTo)} ]")}");
            toStringOutput.Add($"this.NpaNxx = {(this.NpaNxx == null ? "null" : this.NpaNxx)}");
            toStringOutput.Add($"this.ServicePlan = {(this.ServicePlan == null ? "null" : this.ServicePlan)}");
            toStringOutput.Add($"this.ZipCode = {(this.ZipCode == null ? "null" : this.ZipCode)}");
            toStringOutput.Add($"this.SmsrOid = {(this.SmsrOid == null ? "null" : this.SmsrOid)}");
        }
    }
}