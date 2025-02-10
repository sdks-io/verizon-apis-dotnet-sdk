// <copyright file="SubscribeRequest.cs" company="APIMatic">
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
    /// SubscribeRequest.
    /// </summary>
    public class SubscribeRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscribeRequest"/> class.
        /// </summary>
        public SubscribeRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscribeRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="deviceInfo">deviceInfo.</param>
        public SubscribeRequest(
            string accountName,
            List<Models.QosDeviceInfo> deviceInfo)
        {
            this.AccountName = accountName;
            this.DeviceInfo = deviceInfo;
        }

        /// <summary>
        /// Gets or sets AccountName.
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets DeviceInfo.
        /// </summary>
        [JsonProperty("deviceInfo")]
        public List<Models.QosDeviceInfo> DeviceInfo { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SubscribeRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SubscribeRequest other &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.DeviceInfo == null && other.DeviceInfo == null ||
                 this.DeviceInfo?.Equals(other.DeviceInfo) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
            toStringOutput.Add($"DeviceInfo = {(this.DeviceInfo == null ? "null" : $"[{string.Join(", ", this.DeviceInfo)} ]")}");
        }
    }
}