// <copyright file="DeviceAggregateUsageListRequest.cs" company="APIMatic">
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
    /// DeviceAggregateUsageListRequest.
    /// </summary>
    public class DeviceAggregateUsageListRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceAggregateUsageListRequest"/> class.
        /// </summary>
        public DeviceAggregateUsageListRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceAggregateUsageListRequest"/> class.
        /// </summary>
        /// <param name="deviceIds">deviceIds.</param>
        /// <param name="accountName">accountName.</param>
        /// <param name="groupName">groupName.</param>
        /// <param name="startTime">startTime.</param>
        /// <param name="endTime">endTime.</param>
        public DeviceAggregateUsageListRequest(
            List<Models.DeviceId> deviceIds = null,
            string accountName = null,
            string groupName = null,
            string startTime = null,
            string endTime = null)
        {
            this.DeviceIds = deviceIds;
            this.AccountName = accountName;
            this.GroupName = groupName;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        /// <summary>
        /// One or more devices for which you want aggregate data, specified by device ID.
        /// </summary>
        [JsonProperty("deviceIds", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DeviceId> DeviceIds { get; set; }

        /// <summary>
        /// The name of a billing account.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// The name of a device group, if you want to only include devices in that group.
        /// </summary>
        [JsonProperty("groupName", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// The beginning of the reporting period. The startTime cannot be more than 6 months before the current date.
        /// </summary>
        [JsonProperty("startTime", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// The end of the reporting period. The endTime date must be within on month of the startTime date.
        /// </summary>
        [JsonProperty("endTime", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeviceAggregateUsageListRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is DeviceAggregateUsageListRequest other &&                ((this.DeviceIds == null && other.DeviceIds == null) || (this.DeviceIds?.Equals(other.DeviceIds) == true)) &&
                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.GroupName == null && other.GroupName == null) || (this.GroupName?.Equals(other.GroupName) == true)) &&
                ((this.StartTime == null && other.StartTime == null) || (this.StartTime?.Equals(other.StartTime) == true)) &&
                ((this.EndTime == null && other.EndTime == null) || (this.EndTime?.Equals(other.EndTime) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DeviceIds = {(this.DeviceIds == null ? "null" : $"[{string.Join(", ", this.DeviceIds)} ]")}");
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName == string.Empty ? "" : this.AccountName)}");
            toStringOutput.Add($"this.GroupName = {(this.GroupName == null ? "null" : this.GroupName == string.Empty ? "" : this.GroupName)}");
            toStringOutput.Add($"this.StartTime = {(this.StartTime == null ? "null" : this.StartTime == string.Empty ? "" : this.StartTime)}");
            toStringOutput.Add($"this.EndTime = {(this.EndTime == null ? "null" : this.EndTime == string.Empty ? "" : this.EndTime)}");
        }
    }
}