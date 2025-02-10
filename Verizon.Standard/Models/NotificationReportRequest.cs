// <copyright file="NotificationReportRequest.cs" company="APIMatic">
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
    /// NotificationReportRequest.
    /// </summary>
    public class NotificationReportRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationReportRequest"/> class.
        /// </summary>
        public NotificationReportRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationReportRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="requestType">requestType.</param>
        /// <param name="devices">devices.</param>
        /// <param name="monitorExpirationTime">monitorExpirationTime.</param>
        public NotificationReportRequest(
            string accountName,
            string requestType,
            List<Models.DeviceList> devices,
            string monitorExpirationTime)
        {
            this.AccountName = accountName;
            this.RequestType = requestType;
            this.Devices = devices;
            this.MonitorExpirationTime = monitorExpirationTime;
        }

        /// <summary>
        /// Gets or sets AccountName.
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets RequestType.
        /// </summary>
        [JsonProperty("requestType")]
        public string RequestType { get; set; }

        /// <summary>
        /// Gets or sets Devices.
        /// </summary>
        [JsonProperty("devices")]
        public List<Models.DeviceList> Devices { get; set; }

        /// <summary>
        /// Gets or sets MonitorExpirationTime.
        /// </summary>
        [JsonProperty("monitorExpirationTime")]
        public string MonitorExpirationTime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"NotificationReportRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is NotificationReportRequest other &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.RequestType == null && other.RequestType == null ||
                 this.RequestType?.Equals(other.RequestType) == true) &&
                (this.Devices == null && other.Devices == null ||
                 this.Devices?.Equals(other.Devices) == true) &&
                (this.MonitorExpirationTime == null && other.MonitorExpirationTime == null ||
                 this.MonitorExpirationTime?.Equals(other.MonitorExpirationTime) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
            toStringOutput.Add($"RequestType = {this.RequestType ?? "null"}");
            toStringOutput.Add($"Devices = {(this.Devices == null ? "null" : $"[{string.Join(", ", this.Devices)} ]")}");
            toStringOutput.Add($"MonitorExpirationTime = {this.MonitorExpirationTime ?? "null"}");
        }
    }
}