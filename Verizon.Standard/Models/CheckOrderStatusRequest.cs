// <copyright file="CheckOrderStatusRequest.cs" company="APIMatic">
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
    /// CheckOrderStatusRequest.
    /// </summary>
    public class CheckOrderStatusRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckOrderStatusRequest"/> class.
        /// </summary>
        public CheckOrderStatusRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckOrderStatusRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="devices">devices.</param>
        /// <param name="orderRequestId">orderRequestId.</param>
        public CheckOrderStatusRequest(
            string accountName,
            List<Models.DeviceList> devices,
            string orderRequestId = null)
        {
            this.AccountName = accountName;
            this.OrderRequestId = orderRequestId;
            this.Devices = devices;
        }

        /// <summary>
        /// The name of a billing account. An account name is usually numeric, and must include any leading zeros.
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// The request id from the activation order.
        /// </summary>
        [JsonProperty("orderRequestId", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderRequestId { get; set; }

        /// <summary>
        /// The devices to upload, specified by device IDs in a format matching uploadType.
        /// </summary>
        [JsonProperty("devices")]
        public List<Models.DeviceList> Devices { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CheckOrderStatusRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is CheckOrderStatusRequest other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.OrderRequestId == null && other.OrderRequestId == null) || (this.OrderRequestId?.Equals(other.OrderRequestId) == true)) &&
                ((this.Devices == null && other.Devices == null) || (this.Devices?.Equals(other.Devices) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName == string.Empty ? "" : this.AccountName)}");
            toStringOutput.Add($"this.OrderRequestId = {(this.OrderRequestId == null ? "null" : this.OrderRequestId == string.Empty ? "" : this.OrderRequestId)}");
            toStringOutput.Add($"this.Devices = {(this.Devices == null ? "null" : $"[{string.Join(", ", this.Devices)} ]")}");
        }
    }
}