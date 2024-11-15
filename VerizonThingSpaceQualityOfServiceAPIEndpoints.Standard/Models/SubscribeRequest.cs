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
using VerizonThingSpaceQualityOfServiceAPIEndpoints.Standard;
using VerizonThingSpaceQualityOfServiceAPIEndpoints.Standard.Utilities;

namespace VerizonThingSpaceQualityOfServiceAPIEndpoints.Standard.Models
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
            string accountName = null,
            List<Models.DeviceInfo> deviceInfo = null)
        {
            this.AccountName = accountName;
            this.DeviceInfo = deviceInfo;
        }

        /// <summary>
        /// The numeric name of an account
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// An array of device identifiers (deviceId values)
        /// </summary>
        [JsonProperty("deviceInfo", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DeviceInfo> DeviceInfo { get; set; }

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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is SubscribeRequest other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.DeviceInfo == null && other.DeviceInfo == null) || (this.DeviceInfo?.Equals(other.DeviceInfo) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.DeviceInfo = {(this.DeviceInfo == null ? "null" : $"[{string.Join(", ", this.DeviceInfo)} ]")}");
        }
    }
}