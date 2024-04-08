// <copyright file="DeviceProvisioningHistoryListRequest.cs" company="APIMatic">
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
    /// DeviceProvisioningHistoryListRequest.
    /// </summary>
    public class DeviceProvisioningHistoryListRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceProvisioningHistoryListRequest"/> class.
        /// </summary>
        public DeviceProvisioningHistoryListRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceProvisioningHistoryListRequest"/> class.
        /// </summary>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="earliest">earliest.</param>
        /// <param name="latest">latest.</param>
        public DeviceProvisioningHistoryListRequest(
            Models.DeviceId deviceId,
            string earliest,
            string latest)
        {
            this.DeviceId = deviceId;
            this.Earliest = earliest;
            this.Latest = latest;
        }

        /// <summary>
        /// An identifier for a single device.
        /// </summary>
        [JsonProperty("deviceId")]
        public Models.DeviceId DeviceId { get; set; }

        /// <summary>
        /// The earliest date and time for which you want provisioning data.
        /// </summary>
        [JsonProperty("earliest")]
        public string Earliest { get; set; }

        /// <summary>
        /// The last date and time for which you want provisioning data.
        /// </summary>
        [JsonProperty("latest")]
        public string Latest { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeviceProvisioningHistoryListRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is DeviceProvisioningHistoryListRequest other &&                ((this.DeviceId == null && other.DeviceId == null) || (this.DeviceId?.Equals(other.DeviceId) == true)) &&
                ((this.Earliest == null && other.Earliest == null) || (this.Earliest?.Equals(other.Earliest) == true)) &&
                ((this.Latest == null && other.Latest == null) || (this.Latest?.Equals(other.Latest) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DeviceId = {(this.DeviceId == null ? "null" : this.DeviceId.ToString())}");
            toStringOutput.Add($"this.Earliest = {(this.Earliest == null ? "null" : this.Earliest)}");
            toStringOutput.Add($"this.Latest = {(this.Latest == null ? "null" : this.Latest)}");
        }
    }
}