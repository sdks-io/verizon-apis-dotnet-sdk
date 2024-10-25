// <copyright file="DeviceUploadRequest.cs" company="APIMatic">
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
    /// DeviceUploadRequest.
    /// </summary>
    public class DeviceUploadRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceUploadRequest"/> class.
        /// </summary>
        public DeviceUploadRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceUploadRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="devices">devices.</param>
        /// <param name="emailAddress">emailAddress.</param>
        /// <param name="deviceSku">deviceSku.</param>
        /// <param name="uploadType">uploadType.</param>
        public DeviceUploadRequest(
            string accountName,
            List<Models.DeviceList> devices,
            string emailAddress,
            string deviceSku,
            string uploadType)
        {
            this.AccountName = accountName;
            this.Devices = devices;
            this.EmailAddress = emailAddress;
            this.DeviceSku = deviceSku;
            this.UploadType = uploadType;
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
        /// Gets or sets EmailAddress.
        /// </summary>
        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets DeviceSku.
        /// </summary>
        [JsonProperty("deviceSku")]
        public string DeviceSku { get; set; }

        /// <summary>
        /// Gets or sets UploadType.
        /// </summary>
        [JsonProperty("uploadType")]
        public string UploadType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeviceUploadRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is DeviceUploadRequest other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.Devices == null && other.Devices == null) || (this.Devices?.Equals(other.Devices) == true)) &&
                ((this.EmailAddress == null && other.EmailAddress == null) || (this.EmailAddress?.Equals(other.EmailAddress) == true)) &&
                ((this.DeviceSku == null && other.DeviceSku == null) || (this.DeviceSku?.Equals(other.DeviceSku) == true)) &&
                ((this.UploadType == null && other.UploadType == null) || (this.UploadType?.Equals(other.UploadType) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.Devices = {(this.Devices == null ? "null" : $"[{string.Join(", ", this.Devices)} ]")}");
            toStringOutput.Add($"this.EmailAddress = {(this.EmailAddress == null ? "null" : this.EmailAddress)}");
            toStringOutput.Add($"this.DeviceSku = {(this.DeviceSku == null ? "null" : this.DeviceSku)}");
            toStringOutput.Add($"this.UploadType = {(this.UploadType == null ? "null" : this.UploadType)}");
        }
    }
}