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
using Verizon.Standard;
using Verizon.Standard.Utilities;

namespace Verizon.Standard.Models
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
        /// Gets or sets FlowServer.
        /// </summary>
        [JsonProperty("flowServer", NullValueHandling = NullValueHandling.Ignore)]
        public string FlowServer { get; set; }

        /// <summary>
        /// Gets or sets FlowDevice.
        /// </summary>
        [JsonProperty("flowDevice", NullValueHandling = NullValueHandling.Ignore)]
        public string FlowDevice { get; set; }

        /// <summary>
        /// Gets or sets FlowDirection.
        /// </summary>
        [JsonProperty("flowDirection", NullValueHandling = NullValueHandling.Ignore)]
        public string FlowDirection { get; set; }

        /// <summary>
        /// Gets or sets FlowProtocol.
        /// </summary>
        [JsonProperty("flowProtocol", NullValueHandling = NullValueHandling.Ignore)]
        public string FlowProtocol { get; set; }

        /// <summary>
        /// Gets or sets QciOption.
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
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is FlowInfo other &&
                (this.FlowServer == null && other.FlowServer == null ||
                 this.FlowServer?.Equals(other.FlowServer) == true) &&
                (this.FlowDevice == null && other.FlowDevice == null ||
                 this.FlowDevice?.Equals(other.FlowDevice) == true) &&
                (this.FlowDirection == null && other.FlowDirection == null ||
                 this.FlowDirection?.Equals(other.FlowDirection) == true) &&
                (this.FlowProtocol == null && other.FlowProtocol == null ||
                 this.FlowProtocol?.Equals(other.FlowProtocol) == true) &&
                (this.QciOption == null && other.QciOption == null ||
                 this.QciOption?.Equals(other.QciOption) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"FlowServer = {this.FlowServer ?? "null"}");
            toStringOutput.Add($"FlowDevice = {this.FlowDevice ?? "null"}");
            toStringOutput.Add($"FlowDirection = {this.FlowDirection ?? "null"}");
            toStringOutput.Add($"FlowProtocol = {this.FlowProtocol ?? "null"}");
            toStringOutput.Add($"QciOption = {this.QciOption ?? "null"}");
        }
    }
}