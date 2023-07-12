// <copyright file="BullseyeServiceRequest.cs" company="APIMatic">
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
    /// BullseyeServiceRequest.
    /// </summary>
    public class BullseyeServiceRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BullseyeServiceRequest"/> class.
        /// </summary>
        public BullseyeServiceRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BullseyeServiceRequest"/> class.
        /// </summary>
        /// <param name="deviceList">deviceList.</param>
        /// <param name="accountNumber">accountNumber.</param>
        public BullseyeServiceRequest(
            List<Models.DeviceServiceRequest> deviceList,
            string accountNumber)
        {
            this.DeviceList = deviceList;
            this.AccountNumber = accountNumber;
        }

        /// <summary>
        /// A list of devices.
        /// </summary>
        [JsonProperty("deviceList")]
        public List<Models.DeviceServiceRequest> DeviceList { get; set; }

        /// <summary>
        /// A unique identifier for an account.
        /// </summary>
        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BullseyeServiceRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is BullseyeServiceRequest other &&                ((this.DeviceList == null && other.DeviceList == null) || (this.DeviceList?.Equals(other.DeviceList) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DeviceList = {(this.DeviceList == null ? "null" : $"[{string.Join(", ", this.DeviceList)} ]")}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber == string.Empty ? "" : this.AccountNumber)}");
        }
    }
}