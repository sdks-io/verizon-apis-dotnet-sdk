// <copyright file="QosDeviceInfo.cs" company="APIMatic">
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
    /// QosDeviceInfo.
    /// </summary>
    public class QosDeviceInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QosDeviceInfo"/> class.
        /// </summary>
        public QosDeviceInfo()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QosDeviceInfo"/> class.
        /// </summary>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="flowInfo">flowInfo.</param>
        /// <param name="deviceIPv6Addr">deviceIPv6Addr.</param>
        public QosDeviceInfo(
            Models.QosDeviceId deviceId,
            List<Models.FlowInfo> flowInfo,
            string deviceIPv6Addr = null)
        {
            this.DeviceId = deviceId;
            this.DeviceIPv6Addr = deviceIPv6Addr;
            this.FlowInfo = flowInfo;
        }

        /// <summary>
        /// Gets or sets DeviceId.
        /// </summary>
        [JsonProperty("deviceId")]
        public Models.QosDeviceId DeviceId { get; set; }

        /// <summary>
        /// Gets or sets DeviceIPv6Addr.
        /// </summary>
        [JsonProperty("deviceIPv6Addr", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceIPv6Addr { get; set; }

        /// <summary>
        /// Gets or sets FlowInfo.
        /// </summary>
        [JsonProperty("flowInfo")]
        public List<Models.FlowInfo> FlowInfo { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"QosDeviceInfo : ({string.Join(", ", toStringOutput)})";
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
            return obj is QosDeviceInfo other &&                ((this.DeviceId == null && other.DeviceId == null) || (this.DeviceId?.Equals(other.DeviceId) == true)) &&
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