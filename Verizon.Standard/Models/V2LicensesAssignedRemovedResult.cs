// <copyright file="V2LicensesAssignedRemovedResult.cs" company="APIMatic">
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
    /// V2LicensesAssignedRemovedResult.
    /// </summary>
    public class V2LicensesAssignedRemovedResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V2LicensesAssignedRemovedResult"/> class.
        /// </summary>
        public V2LicensesAssignedRemovedResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V2LicensesAssignedRemovedResult"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="licTotalCount">licTotalCount.</param>
        /// <param name="licUsedCount">licUsedCount.</param>
        /// <param name="deviceList">deviceList.</param>
        public V2LicensesAssignedRemovedResult(
            string accountName,
            int licTotalCount,
            int licUsedCount,
            List<Models.V2DeviceStatus> deviceList)
        {
            this.AccountName = accountName;
            this.LicTotalCount = licTotalCount;
            this.LicUsedCount = licUsedCount;
            this.DeviceList = deviceList;
        }

        /// <summary>
        /// Account name.
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Total license count.
        /// </summary>
        [JsonProperty("licTotalCount")]
        public int LicTotalCount { get; set; }

        /// <summary>
        /// Assigned license count.
        /// </summary>
        [JsonProperty("licUsedCount")]
        public int LicUsedCount { get; set; }

        /// <summary>
        /// List of devices with id in IMEI.
        /// </summary>
        [JsonProperty("deviceList")]
        public List<Models.V2DeviceStatus> DeviceList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V2LicensesAssignedRemovedResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is V2LicensesAssignedRemovedResult other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                this.LicTotalCount.Equals(other.LicTotalCount) &&
                this.LicUsedCount.Equals(other.LicUsedCount) &&
                ((this.DeviceList == null && other.DeviceList == null) || (this.DeviceList?.Equals(other.DeviceList) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.LicTotalCount = {this.LicTotalCount}");
            toStringOutput.Add($"this.LicUsedCount = {this.LicUsedCount}");
            toStringOutput.Add($"this.DeviceList = {(this.DeviceList == null ? "null" : $"[{string.Join(", ", this.DeviceList)} ]")}");
        }
    }
}