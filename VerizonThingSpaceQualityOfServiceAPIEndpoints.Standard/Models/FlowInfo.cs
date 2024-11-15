// <copyright file="FlowInfo.cs" company="APIMatic">
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
    /// FlowInfo.
    /// </summary>
    public class FlowInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowInfo"/> class.
        /// </summary>
        public FlowInfo()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FlowInfo"/> class.
        /// </summary>
        /// <param name="flowServer">flowServer.</param>
        /// <param name="flowDevice">flowDevice.</param>
        /// <param name="flowDirection">flowDirection.</param>
        /// <param name="flowProtocol">flowProtocol.</param>
        /// <param name="qciOption">qciOption.</param>
        public FlowInfo(
            string flowServer = null,
            string flowDevice = null,
            string flowDirection = null,
            string flowProtocol = null,
            string qciOption = null)
        {
            this.FlowServer = flowServer;
            this.FlowDevice = flowDevice;
            this.FlowDirection = flowDirection;
            this.FlowProtocol = flowProtocol;
            this.QciOption = qciOption;
        }

        /// <summary>
        /// The IPv6 IP address and port used to connect to the server
        /// </summary>
        [JsonProperty("flowServer", NullValueHandling = NullValueHandling.Ignore)]
        public string FlowServer { get; set; }

        /// <summary>
        /// The IPv6 IP address and port used by the device
        /// </summary>
        [JsonProperty("flowDevice", NullValueHandling = NullValueHandling.Ignore)]
        public string FlowDevice { get; set; }

        /// <summary>
        /// The direction the data is flowing. UPLINK if from the device, DOWNLINK is to the device
        /// </summary>
        [JsonProperty("flowDirection", NullValueHandling = NullValueHandling.Ignore)]
        public string FlowDirection { get; set; }

        /// <summary>
        /// The data protocol used for the connection
        /// </summary>
        [JsonProperty("flowProtocol", NullValueHandling = NullValueHandling.Ignore)]
        public string FlowProtocol { get; set; }

        /// <summary>
        /// The QoS level of the connection. This will be Standard or Premium
        /// </summary>
        [JsonProperty("qciOption", NullValueHandling = NullValueHandling.Ignore)]
        public string QciOption { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"FlowInfo : ({string.Join(", ", toStringOutput)})";
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
            return obj is FlowInfo other &&                ((this.FlowServer == null && other.FlowServer == null) || (this.FlowServer?.Equals(other.FlowServer) == true)) &&
                ((this.FlowDevice == null && other.FlowDevice == null) || (this.FlowDevice?.Equals(other.FlowDevice) == true)) &&
                ((this.FlowDirection == null && other.FlowDirection == null) || (this.FlowDirection?.Equals(other.FlowDirection) == true)) &&
                ((this.FlowProtocol == null && other.FlowProtocol == null) || (this.FlowProtocol?.Equals(other.FlowProtocol) == true)) &&
                ((this.QciOption == null && other.QciOption == null) || (this.QciOption?.Equals(other.QciOption) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.FlowServer = {(this.FlowServer == null ? "null" : this.FlowServer)}");
            toStringOutput.Add($"this.FlowDevice = {(this.FlowDevice == null ? "null" : this.FlowDevice)}");
            toStringOutput.Add($"this.FlowDirection = {(this.FlowDirection == null ? "null" : this.FlowDirection)}");
            toStringOutput.Add($"this.FlowProtocol = {(this.FlowProtocol == null ? "null" : this.FlowProtocol)}");
            toStringOutput.Add($"this.QciOption = {(this.QciOption == null ? "null" : this.QciOption)}");
        }
    }
}