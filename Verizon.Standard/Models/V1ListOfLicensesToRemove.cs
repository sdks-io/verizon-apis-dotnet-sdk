// <copyright file="V1ListOfLicensesToRemove.cs" company="APIMatic">
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
    /// V1ListOfLicensesToRemove.
    /// </summary>
    public class V1ListOfLicensesToRemove
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1ListOfLicensesToRemove"/> class.
        /// </summary>
        public V1ListOfLicensesToRemove()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ListOfLicensesToRemove"/> class.
        /// </summary>
        /// <param name="count">count.</param>
        /// <param name="hasMoreData">hasMoreData.</param>
        /// <param name="updateTime">updateTime.</param>
        /// <param name="deviceList">deviceList.</param>
        public V1ListOfLicensesToRemove(
            int? count = null,
            bool? hasMoreData = null,
            DateTime? updateTime = null,
            List<string> deviceList = null)
        {
            this.Count = count;
            this.HasMoreData = hasMoreData;
            this.UpdateTime = updateTime;
            this.DeviceList = deviceList;
        }

        /// <summary>
        /// The total number of devices on the list.
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// True if there are more devices to retrieve.
        /// </summary>
        [JsonProperty("hasMoreData", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasMoreData { get; set; }

        /// <summary>
        /// The date and time that the list was last updated.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updateTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// The IMEIs of the devices.
        /// </summary>
        [JsonProperty("deviceList", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DeviceList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"V1ListOfLicensesToRemove : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is V1ListOfLicensesToRemove other &&
                (this.Count == null && other.Count == null ||
                 this.Count?.Equals(other.Count) == true) &&
                (this.HasMoreData == null && other.HasMoreData == null ||
                 this.HasMoreData?.Equals(other.HasMoreData) == true) &&
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
            toStringOutput.Add($"Count = {(this.Count == null ? "null" : this.Count.ToString())}");
            toStringOutput.Add($"HasMoreData = {(this.HasMoreData == null ? "null" : this.HasMoreData.ToString())}");
            toStringOutput.Add($"UpdateTime = {(this.UpdateTime == null ? "null" : this.UpdateTime.ToString())}");
            toStringOutput.Add($"DeviceList = {(this.DeviceList == null ? "null" : $"[{string.Join(", ", this.DeviceList)} ]")}");
        }
    }
}