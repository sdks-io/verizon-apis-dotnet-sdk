// <copyright file="V3LicenseAssignedRemovedResult.cs" company="APIMatic">
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
    /// V3LicenseAssignedRemovedResult.
    /// </summary>
    public class V3LicenseAssignedRemovedResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V3LicenseAssignedRemovedResult"/> class.
        /// </summary>
        public V3LicenseAssignedRemovedResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V3LicenseAssignedRemovedResult"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="licCount">licCount.</param>
        /// <param name="licUsedCount">licUsedCount.</param>
        /// <param name="deviceList">deviceList.</param>
        public V3LicenseAssignedRemovedResult(
            string accountName,
            int licCount,
            int licUsedCount,
            List<Models.V3DeviceStatus> deviceList)
        {
            this.AccountName = accountName;
            this.LicCount = licCount;
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
        [JsonProperty("licCount")]
        public int LicCount { get; set; }

        /// <summary>
        /// Assigned license count.
        /// </summary>
        [JsonProperty("licUsedCount")]
        public int LicUsedCount { get; set; }

        /// <summary>
        /// List of devices with id in IMEI.
        /// </summary>
        [JsonProperty("deviceList")]
        public List<Models.V3DeviceStatus> DeviceList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V3LicenseAssignedRemovedResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is V3LicenseAssignedRemovedResult other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                this.LicCount.Equals(other.LicCount) &&
                this.LicUsedCount.Equals(other.LicUsedCount) &&
                ((this.DeviceList == null && other.DeviceList == null) || (this.DeviceList?.Equals(other.DeviceList) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName == string.Empty ? "" : this.AccountName)}");
            toStringOutput.Add($"this.LicCount = {this.LicCount}");
            toStringOutput.Add($"this.LicUsedCount = {this.LicUsedCount}");
            toStringOutput.Add($"this.DeviceList = {(this.DeviceList == null ? "null" : $"[{string.Join(", ", this.DeviceList)} ]")}");
        }
    }
}