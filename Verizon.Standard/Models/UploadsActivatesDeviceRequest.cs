// <copyright file="UploadsActivatesDeviceRequest.cs" company="APIMatic">
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
    /// UploadsActivatesDeviceRequest.
    /// </summary>
    public class UploadsActivatesDeviceRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadsActivatesDeviceRequest"/> class.
        /// </summary>
        public UploadsActivatesDeviceRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadsActivatesDeviceRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="emailAddress">emailAddress.</param>
        /// <param name="deviceSku">deviceSku.</param>
        /// <param name="uploadType">uploadType.</param>
        /// <param name="servicePlan">servicePlan.</param>
        /// <param name="mdnZipCode">mdnZipCode.</param>
        /// <param name="devices">devices.</param>
        /// <param name="carrierIpPoolName">carrierIpPoolName.</param>
        public UploadsActivatesDeviceRequest(
            string accountName,
            string emailAddress,
            string deviceSku,
            string uploadType,
            string servicePlan,
            string mdnZipCode,
            List<Models.DeviceList> devices,
            string carrierIpPoolName = null)
        {
            this.AccountName = accountName;
            this.EmailAddress = emailAddress;
            this.DeviceSku = deviceSku;
            this.UploadType = uploadType;
            this.ServicePlan = servicePlan;
            this.CarrierIpPoolName = carrierIpPoolName;
            this.MdnZipCode = mdnZipCode;
            this.Devices = devices;
        }

        /// <summary>
        /// The name of a billing account. An account name is usually numeric, and must include any leading zeros.
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// The email address that the report should be sent to when the upload is complete.
        /// </summary>
        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// The stock keeping unit that identifies the type of devices in the upload and activation.
        /// </summary>
        [JsonProperty("deviceSku")]
        public string DeviceSku { get; set; }

        /// <summary>
        /// The format of the device identifiers in the upload and activation.
        /// </summary>
        [JsonProperty("uploadType")]
        public string UploadType { get; set; }

        /// <summary>
        /// The service plan code that you want to assign to all specified devices.
        /// </summary>
        [JsonProperty("servicePlan")]
        public string ServicePlan { get; set; }

        /// <summary>
        /// The pool from which your device IP addresses is derived.
        /// </summary>
        [JsonProperty("carrierIpPoolName", NullValueHandling = NullValueHandling.Ignore)]
        public string CarrierIpPoolName { get; set; }

        /// <summary>
        /// The Zip code of the location where the line of service is primarily used, or a Zip code that you have been told to use with these devices.
        /// </summary>
        [JsonProperty("mdnZipCode")]
        public string MdnZipCode { get; set; }

        /// <summary>
        /// The devices to upload, specified by device IDs in a format matching uploadType.
        /// </summary>
        [JsonProperty("devices")]
        public List<Models.DeviceList> Devices { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UploadsActivatesDeviceRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is UploadsActivatesDeviceRequest other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.EmailAddress == null && other.EmailAddress == null) || (this.EmailAddress?.Equals(other.EmailAddress) == true)) &&
                ((this.DeviceSku == null && other.DeviceSku == null) || (this.DeviceSku?.Equals(other.DeviceSku) == true)) &&
                ((this.UploadType == null && other.UploadType == null) || (this.UploadType?.Equals(other.UploadType) == true)) &&
                ((this.ServicePlan == null && other.ServicePlan == null) || (this.ServicePlan?.Equals(other.ServicePlan) == true)) &&
                ((this.CarrierIpPoolName == null && other.CarrierIpPoolName == null) || (this.CarrierIpPoolName?.Equals(other.CarrierIpPoolName) == true)) &&
                ((this.MdnZipCode == null && other.MdnZipCode == null) || (this.MdnZipCode?.Equals(other.MdnZipCode) == true)) &&
                ((this.Devices == null && other.Devices == null) || (this.Devices?.Equals(other.Devices) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName == string.Empty ? "" : this.AccountName)}");
            toStringOutput.Add($"this.EmailAddress = {(this.EmailAddress == null ? "null" : this.EmailAddress == string.Empty ? "" : this.EmailAddress)}");
            toStringOutput.Add($"this.DeviceSku = {(this.DeviceSku == null ? "null" : this.DeviceSku == string.Empty ? "" : this.DeviceSku)}");
            toStringOutput.Add($"this.UploadType = {(this.UploadType == null ? "null" : this.UploadType == string.Empty ? "" : this.UploadType)}");
            toStringOutput.Add($"this.ServicePlan = {(this.ServicePlan == null ? "null" : this.ServicePlan == string.Empty ? "" : this.ServicePlan)}");
            toStringOutput.Add($"this.CarrierIpPoolName = {(this.CarrierIpPoolName == null ? "null" : this.CarrierIpPoolName == string.Empty ? "" : this.CarrierIpPoolName)}");
            toStringOutput.Add($"this.MdnZipCode = {(this.MdnZipCode == null ? "null" : this.MdnZipCode == string.Empty ? "" : this.MdnZipCode)}");
            toStringOutput.Add($"this.Devices = {(this.Devices == null ? "null" : $"[{string.Join(", ", this.Devices)} ]")}");
        }
    }
}