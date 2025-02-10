// <copyright file="DeviceFirmwareList.cs" company="APIMatic">
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
    /// DeviceFirmwareList.
    /// </summary>
    public class DeviceFirmwareList
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceFirmwareList"/> class.
        /// </summary>
        public DeviceFirmwareList()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceFirmwareList"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="deviceFirmwarVersionList">deviceFirmwarVersionList.</param>
        public DeviceFirmwareList(
            string accountName,
            List<Models.DeviceFirmwareVersion> deviceFirmwarVersionList = null)
        {
            this.AccountName = accountName;
            this.DeviceFirmwarVersionList = deviceFirmwarVersionList;
        }

        /// <summary>
        /// Account name.
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// <![CDATA[
        /// List of device & firmware.
        /// ]]>
        /// </summary>
        [JsonProperty("deviceFirmwarVersionList", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DeviceFirmwareVersion> DeviceFirmwarVersionList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DeviceFirmwareList : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DeviceFirmwareList other &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.DeviceFirmwarVersionList == null && other.DeviceFirmwarVersionList == null ||
                 this.DeviceFirmwarVersionList?.Equals(other.DeviceFirmwarVersionList) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
            toStringOutput.Add($"DeviceFirmwarVersionList = {(this.DeviceFirmwarVersionList == null ? "null" : $"[{string.Join(", ", this.DeviceFirmwarVersionList)} ]")}");
        }
    }
}