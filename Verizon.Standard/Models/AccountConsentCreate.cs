// <copyright file="AccountConsentCreate.cs" company="APIMatic">
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
    /// AccountConsentCreate.
    /// </summary>
    public class AccountConsentCreate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountConsentCreate"/> class.
        /// </summary>
        public AccountConsentCreate()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountConsentCreate"/> class.
        /// </summary>
        /// <param name="deviceList">deviceList.</param>
        /// <param name="accountName">accountName.</param>
        public AccountConsentCreate(
            object deviceList = null,
            string accountName = null)
        {
            this.DeviceList = deviceList;
            this.AccountName = accountName;
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"AccountConsentCreate : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AccountConsentCreate other &&
                (this.DeviceList == null && other.DeviceList == null ||
                 this.DeviceList?.Equals(other.DeviceList) == true) &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"DeviceList = {(this.DeviceList == null ? "null" : this.DeviceList.ToString())}");
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
        }
    }
}