// <copyright file="GetAccountDeviceConsent.cs" company="APIMatic">
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
    /// GetAccountDeviceConsent.
    /// </summary>
    public class GetAccountDeviceConsent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAccountDeviceConsent"/> class.
        /// </summary>
        public GetAccountDeviceConsent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAccountDeviceConsent"/> class.
        /// </summary>
        /// <param name="deviceList">deviceList.</param>
        /// <param name="accountName">accountName.</param>
        /// <param name="allDeviceConsent">allDeviceConsent.</param>
        public GetAccountDeviceConsent(
            object deviceList = null,
            string accountName = null,
            int? allDeviceConsent = null)
        {
            this.DeviceList = deviceList;
            this.AccountName = accountName;
            this.AllDeviceConsent = allDeviceConsent;
        }

        /// <summary>
        /// An array of device identifiers
        /// </summary>
        [JsonProperty("deviceList", NullValueHandling = NullValueHandling.Ignore)]
        public object DeviceList { get; set; }

        /// <summary>
        /// The numeric name of the account, including leading zeros.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// If consent is set at the account level, this value will show the consent level.
        /// </summary>
        [JsonProperty("allDeviceConsent", NullValueHandling = NullValueHandling.Ignore)]
        public int? AllDeviceConsent { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetAccountDeviceConsent : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetAccountDeviceConsent other &&
                (this.DeviceList == null && other.DeviceList == null ||
                 this.DeviceList?.Equals(other.DeviceList) == true) &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.AllDeviceConsent == null && other.AllDeviceConsent == null ||
                 this.AllDeviceConsent?.Equals(other.AllDeviceConsent) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"DeviceList = {(this.DeviceList == null ? "null" : this.DeviceList.ToString())}");
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
            toStringOutput.Add($"AllDeviceConsent = {(this.AllDeviceConsent == null ? "null" : this.AllDeviceConsent.ToString())}");
        }
    }
}