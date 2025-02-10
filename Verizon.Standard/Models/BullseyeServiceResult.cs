// <copyright file="BullseyeServiceResult.cs" company="APIMatic">
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
    /// BullseyeServiceResult.
    /// </summary>
    public class BullseyeServiceResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BullseyeServiceResult"/> class.
        /// </summary>
        public BullseyeServiceResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BullseyeServiceResult"/> class.
        /// </summary>
        /// <param name="accountNumber">accountNumber.</param>
        /// <param name="deviceList">deviceList.</param>
        /// <param name="responseType">responseType.</param>
        public BullseyeServiceResult(
            string accountNumber = null,
            List<Models.DeviceServiceInformation> deviceList = null,
            Models.ApiResponseCode responseType = null)
        {
            this.AccountNumber = accountNumber;
            this.DeviceList = deviceList;
            this.ResponseType = responseType;
        }

        /// <summary>
        /// The account the device belongs to.
        /// </summary>
        [JsonProperty("accountNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// List of devices.
        /// </summary>
        [JsonProperty("deviceList", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DeviceServiceInformation> DeviceList { get; set; }

        /// <summary>
        /// ResponseCode and/or a message indicating success or failure of the request.
        /// </summary>
        [JsonProperty("responseType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ApiResponseCode ResponseType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"BullseyeServiceResult : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is BullseyeServiceResult other &&
                (this.AccountNumber == null && other.AccountNumber == null ||
                 this.AccountNumber?.Equals(other.AccountNumber) == true) &&
                (this.DeviceList == null && other.DeviceList == null ||
                 this.DeviceList?.Equals(other.DeviceList) == true) &&
                (this.ResponseType == null && other.ResponseType == null ||
                 this.ResponseType?.Equals(other.ResponseType) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AccountNumber = {this.AccountNumber ?? "null"}");
            toStringOutput.Add($"DeviceList = {(this.DeviceList == null ? "null" : $"[{string.Join(", ", this.DeviceList)} ]")}");
            toStringOutput.Add($"ResponseType = {(this.ResponseType == null ? "null" : this.ResponseType.ToString())}");
        }
    }
}