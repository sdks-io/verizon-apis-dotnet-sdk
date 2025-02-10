// <copyright file="DeleteDevicesRequest.cs" company="APIMatic">
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
    /// DeleteDevicesRequest.
    /// </summary>
    public class DeleteDevicesRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDevicesRequest"/> class.
        /// </summary>
        public DeleteDevicesRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDevicesRequest"/> class.
        /// </summary>
        /// <param name="devicesToDelete">devicesToDelete.</param>
        /// <param name="accountName">accountName.</param>
        public DeleteDevicesRequest(
            List<Models.AccountDeviceList> devicesToDelete,
            string accountName = null)
        {
            this.DevicesToDelete = devicesToDelete;
            this.AccountName = accountName;
        }

        /// <summary>
        /// A list of up to 100 devices that you want to delete, specified by device identifier. You only need to provide one identifier per device.
        /// </summary>
        [JsonProperty("devicesToDelete")]
        public List<Models.AccountDeviceList> DevicesToDelete { get; set; }

        /// <summary>
        /// The Verizon billing account that the device group belongs to. An account name is usually numeric, and must include any leading zeros.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DeleteDevicesRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DeleteDevicesRequest other &&
                (this.DevicesToDelete == null && other.DevicesToDelete == null ||
                 this.DevicesToDelete?.Equals(other.DevicesToDelete) == true) &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"DevicesToDelete = {(this.DevicesToDelete == null ? "null" : $"[{string.Join(", ", this.DevicesToDelete)} ]")}");
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
        }
    }
}