// <copyright file="V3AccountDeviceList.cs" company="APIMatic">
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
    /// V3AccountDeviceList.
    /// </summary>
    public class V3AccountDeviceList
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V3AccountDeviceList"/> class.
        /// </summary>
        public V3AccountDeviceList()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V3AccountDeviceList"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="hasMoreData">hasMoreData.</param>
        /// <param name="maxPageSize">maxPageSize.</param>
        /// <param name="deviceList">deviceList.</param>
        /// <param name="lastSeenDeviceId">lastSeenDeviceId.</param>
        public V3AccountDeviceList(
            string accountName,
            bool hasMoreData,
            int maxPageSize,
            List<Models.V3AccountDevice> deviceList,
            string lastSeenDeviceId = null)
        {
            this.AccountName = accountName;
            this.HasMoreData = hasMoreData;
            this.LastSeenDeviceId = lastSeenDeviceId;
            this.MaxPageSize = maxPageSize;
            this.DeviceList = deviceList;
        }

        /// <summary>
        /// Account name.
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Has more device flag?
        /// </summary>
        [JsonProperty("hasMoreData")]
        public bool HasMoreData { get; set; }

        /// <summary>
        /// Last seen device identifier.
        /// </summary>
        [JsonProperty("lastSeenDeviceId", NullValueHandling = NullValueHandling.Ignore)]
        public string LastSeenDeviceId { get; set; }

        /// <summary>
        /// Maximum page size.
        /// </summary>
        [JsonProperty("maxPageSize")]
        public int MaxPageSize { get; set; }

        /// <summary>
        /// Account device list.
        /// </summary>
        [JsonProperty("deviceList")]
        public List<Models.V3AccountDevice> DeviceList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"V3AccountDeviceList : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is V3AccountDeviceList other &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.HasMoreData.Equals(other.HasMoreData)) &&
                (this.LastSeenDeviceId == null && other.LastSeenDeviceId == null ||
                 this.LastSeenDeviceId?.Equals(other.LastSeenDeviceId) == true) &&
                (this.MaxPageSize.Equals(other.MaxPageSize)) &&
                (this.DeviceList == null && other.DeviceList == null ||
                 this.DeviceList?.Equals(other.DeviceList) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
            toStringOutput.Add($"HasMoreData = {this.HasMoreData}");
            toStringOutput.Add($"LastSeenDeviceId = {this.LastSeenDeviceId ?? "null"}");
            toStringOutput.Add($"MaxPageSize = {this.MaxPageSize}");
            toStringOutput.Add($"DeviceList = {(this.DeviceList == null ? "null" : $"[{string.Join(", ", this.DeviceList)} ]")}");
        }
    }
}