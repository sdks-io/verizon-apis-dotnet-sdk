// <copyright file="V2ListOfLicensesToRemove.cs" company="APIMatic">
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
    /// V2ListOfLicensesToRemove.
    /// </summary>
    public class V2ListOfLicensesToRemove
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V2ListOfLicensesToRemove"/> class.
        /// </summary>
        public V2ListOfLicensesToRemove()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V2ListOfLicensesToRemove"/> class.
        /// </summary>
        /// <param name="count">count.</param>
        /// <param name="hasMoreData">hasMoreData.</param>
        /// <param name="updateTime">updateTime.</param>
        /// <param name="deviceList">deviceList.</param>
        public V2ListOfLicensesToRemove(
            int count,
            bool hasMoreData,
            string updateTime,
            List<string> deviceList)
        {
            this.Count = count;
            this.HasMoreData = hasMoreData;
            this.UpdateTime = updateTime;
            this.DeviceList = deviceList;
        }

        /// <summary>
        /// Cancellation candidate devices count.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Flag to indicat more devices.
        /// </summary>
        [JsonProperty("hasMoreData")]
        public bool HasMoreData { get; set; }

        /// <summary>
        /// Last update time.
        /// </summary>
        [JsonProperty("updateTime")]
        public string UpdateTime { get; set; }

        /// <summary>
        /// Device IMEI list.
        /// </summary>
        [JsonProperty("deviceList")]
        public List<string> DeviceList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"V2ListOfLicensesToRemove : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is V2ListOfLicensesToRemove other &&
                (this.Count.Equals(other.Count)) &&
                (this.HasMoreData.Equals(other.HasMoreData)) &&
                (this.UpdateTime == null && other.UpdateTime == null ||
                 this.UpdateTime?.Equals(other.UpdateTime) == true) &&
                (this.DeviceList == null && other.DeviceList == null ||
                 this.DeviceList?.Equals(other.DeviceList) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Count = {this.Count}");
            toStringOutput.Add($"HasMoreData = {this.HasMoreData}");
            toStringOutput.Add($"UpdateTime = {this.UpdateTime ?? "null"}");
            toStringOutput.Add($"DeviceList = {(this.DeviceList == null ? "null" : $"[{string.Join(", ", this.DeviceList)} ]")}");
        }
    }
}