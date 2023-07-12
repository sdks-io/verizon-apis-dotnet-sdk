// <copyright file="DeviceListResult.cs" company="APIMatic">
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
    /// DeviceListResult.
    /// </summary>
    public class DeviceListResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceListResult"/> class.
        /// </summary>
        public DeviceListResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceListResult"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="deviceCount">deviceCount.</param>
        /// <param name="deviceList">deviceList.</param>
        public DeviceListResult(
            string accountName,
            int deviceCount,
            List<Models.V3Device> deviceList)
        {
            this.AccountName = accountName;
            this.DeviceCount = deviceCount;
            this.DeviceList = deviceList;
        }

        /// <summary>
        /// Account name.
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Total device count.
        /// </summary>
        [JsonProperty("deviceCount")]
        public int DeviceCount { get; set; }

        /// <summary>
        /// List of devices with id in IMEI.
        /// </summary>
        [JsonProperty("deviceList")]
        public List<Models.V3Device> DeviceList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeviceListResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is DeviceListResult other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                this.DeviceCount.Equals(other.DeviceCount) &&
                ((this.DeviceList == null && other.DeviceList == null) || (this.DeviceList?.Equals(other.DeviceList) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName == string.Empty ? "" : this.AccountName)}");
            toStringOutput.Add($"this.DeviceCount = {this.DeviceCount}");
            toStringOutput.Add($"this.DeviceList = {(this.DeviceList == null ? "null" : $"[{string.Join(", ", this.DeviceList)} ]")}");
        }
    }
}