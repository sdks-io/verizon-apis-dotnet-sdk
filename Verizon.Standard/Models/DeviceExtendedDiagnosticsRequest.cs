// <copyright file="DeviceExtendedDiagnosticsRequest.cs" company="APIMatic">
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
    /// DeviceExtendedDiagnosticsRequest.
    /// </summary>
    public class DeviceExtendedDiagnosticsRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceExtendedDiagnosticsRequest"/> class.
        /// </summary>
        public DeviceExtendedDiagnosticsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceExtendedDiagnosticsRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="deviceList">deviceList.</param>
        public DeviceExtendedDiagnosticsRequest(
            string accountName,
            List<Models.DeviceId> deviceList)
        {
            this.AccountName = accountName;
            this.DeviceList = deviceList;
        }

        /// <summary>
        /// The Verizon billing account that the device belongs to. An account name is usually numeric, and must include any leading zeros.
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// The device for which you want diagnostic information, specified by the device's MDN.
        /// </summary>
        [JsonProperty("deviceList")]
        public List<Models.DeviceId> DeviceList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeviceExtendedDiagnosticsRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is DeviceExtendedDiagnosticsRequest other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.DeviceList == null && other.DeviceList == null) || (this.DeviceList?.Equals(other.DeviceList) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName == string.Empty ? "" : this.AccountName)}");
            toStringOutput.Add($"this.DeviceList = {(this.DeviceList == null ? "null" : $"[{string.Join(", ", this.DeviceList)} ]")}");
        }
    }
}