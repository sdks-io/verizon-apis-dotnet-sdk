// <copyright file="DeviceSuspensionStatusRequest.cs" company="APIMatic">
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
    /// DeviceSuspensionStatusRequest.
    /// </summary>
    public class DeviceSuspensionStatusRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceSuspensionStatusRequest"/> class.
        /// </summary>
        public DeviceSuspensionStatusRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceSuspensionStatusRequest"/> class.
        /// </summary>
        /// <param name="deviceIds">deviceIds.</param>
        /// <param name="filter">filter.</param>
        /// <param name="accountName">accountName.</param>
        public DeviceSuspensionStatusRequest(
            List<Models.DeviceId> deviceIds = null,
            Models.DeviceFilterWithoutAccount filter = null,
            string accountName = null)
        {
            this.DeviceIds = deviceIds;
            this.Filter = filter;
            this.AccountName = accountName;
        }

        /// <summary>
        /// The devices that you want to include in the request, specified by device identifier. You only need to provide one identifier per device.
        /// </summary>
        [JsonProperty("deviceIds", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DeviceId> DeviceIds { get; set; }

        /// <summary>
        /// Filter for devices without account.
        /// </summary>
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DeviceFilterWithoutAccount Filter { get; set; }

        /// <summary>
        /// The name of a billing account.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeviceSuspensionStatusRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is DeviceSuspensionStatusRequest other &&                ((this.DeviceIds == null && other.DeviceIds == null) || (this.DeviceIds?.Equals(other.DeviceIds) == true)) &&
                ((this.Filter == null && other.Filter == null) || (this.Filter?.Equals(other.Filter) == true)) &&
                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DeviceIds = {(this.DeviceIds == null ? "null" : $"[{string.Join(", ", this.DeviceIds)} ]")}");
            toStringOutput.Add($"this.Filter = {(this.Filter == null ? "null" : this.Filter.ToString())}");
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName == string.Empty ? "" : this.AccountName)}");
        }
    }
}