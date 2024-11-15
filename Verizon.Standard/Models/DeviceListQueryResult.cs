// <copyright file="DeviceListQueryResult.cs" company="APIMatic">
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
    /// DeviceListQueryResult.
    /// </summary>
    public class DeviceListQueryResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceListQueryResult"/> class.
        /// </summary>
        public DeviceListQueryResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceListQueryResult"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="hasMoreData">hasMoreData.</param>
        /// <param name="lastSeenDeviceId">lastSeenDeviceId.</param>
        /// <param name="deviceList">deviceList.</param>
        public DeviceListQueryResult(
            string accountName = null,
            bool? hasMoreData = null,
            long? lastSeenDeviceId = null,
            List<Models.DeviceListQueryItem> deviceList = null)
        {
            this.AccountName = accountName;
            this.HasMoreData = hasMoreData;
            this.LastSeenDeviceId = lastSeenDeviceId;
            this.DeviceList = deviceList;
        }

        /// <summary>
        /// Account identifier in "##########-#####".
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// True if there are more devices to retrieve.
        /// </summary>
        [JsonProperty("hasMoreData", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasMoreData { get; set; }

        /// <summary>
        /// If hasMoreData=true, the startIndex to use for the next request. 0 if hasMoreData=false.
        /// </summary>
        [JsonProperty("lastSeenDeviceId", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastSeenDeviceId { get; set; }

        /// <summary>
        /// The list of devices in the account.
        /// </summary>
        [JsonProperty("deviceList", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DeviceListQueryItem> DeviceList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeviceListQueryResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is DeviceListQueryResult other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.HasMoreData == null && other.HasMoreData == null) || (this.HasMoreData?.Equals(other.HasMoreData) == true)) &&
                ((this.LastSeenDeviceId == null && other.LastSeenDeviceId == null) || (this.LastSeenDeviceId?.Equals(other.LastSeenDeviceId) == true)) &&
                ((this.DeviceList == null && other.DeviceList == null) || (this.DeviceList?.Equals(other.DeviceList) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.HasMoreData = {(this.HasMoreData == null ? "null" : this.HasMoreData.ToString())}");
            toStringOutput.Add($"this.LastSeenDeviceId = {(this.LastSeenDeviceId == null ? "null" : this.LastSeenDeviceId.ToString())}");
            toStringOutput.Add($"this.DeviceList = {(this.DeviceList == null ? "null" : $"[{string.Join(", ", this.DeviceList)} ]")}");
        }
    }
}