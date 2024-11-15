// <copyright file="DeviceInfo.cs" company="APIMatic">
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
    /// DeviceInfo.
    /// </summary>
    public class DeviceInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceInfo"/> class.
        /// </summary>
        public DeviceInfo()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceInfo"/> class.
        /// </summary>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="deviceIPv6Addr">deviceIPv6Addr.</param>
        /// <param name="flowInfo">flowInfo.</param>
        public DeviceInfo(
            Models.DeviceId deviceId = null,
            string deviceIPv6Addr = null,
            List<Models.FlowInfo> flowInfo = null)
        {
            this.DeviceId = deviceId;
            this.DeviceIPv6Addr = deviceIPv6Addr;
            this.FlowInfo = flowInfo;
        }

        /// <summary>
        /// device identifiers consisting of an ID value and what that value represents (kind)
        /// </summary>
        [JsonProperty("deviceId", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DeviceId DeviceId { get; set; }

        /// <summary>
        /// the IPv6 IP address of the device
        /// </summary>
        [JsonProperty("deviceIPv6Addr", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceIPv6Addr { get; set; }

        /// <summary>
        /// The details of the data connection
        /// </summary>
        [JsonProperty("flowInfo", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.FlowInfo> FlowInfo { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeviceInfo : ({string.Join(", ", toStringOutput)})";
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
            return obj is DeviceInfo other &&                ((this.DeviceId == null && other.DeviceId == null) || (this.DeviceId?.Equals(other.DeviceId) == true)) &&
                ((this.DeviceIPv6Addr == null && other.DeviceIPv6Addr == null) || (this.DeviceIPv6Addr?.Equals(other.DeviceIPv6Addr) == true)) &&
                ((this.FlowInfo == null && other.FlowInfo == null) || (this.FlowInfo?.Equals(other.FlowInfo) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DeviceId = {(this.DeviceId == null ? "null" : this.DeviceId.ToString())}");
            toStringOutput.Add($"this.DeviceIPv6Addr = {(this.DeviceIPv6Addr == null ? "null" : this.DeviceIPv6Addr)}");
            toStringOutput.Add($"this.FlowInfo = {(this.FlowInfo == null ? "null" : $"[{string.Join(", ", this.FlowInfo)} ]")}");
        }
    }
}