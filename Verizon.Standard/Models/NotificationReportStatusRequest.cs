// <copyright file="NotificationReportStatusRequest.cs" company="APIMatic">
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
    using APIMatic.Core.Utilities.Converters;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Verizon.Standard;
    using Verizon.Standard.Utilities;

    /// <summary>
    /// NotificationReportStatusRequest.
    /// </summary>
    public class NotificationReportStatusRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationReportStatusRequest"/> class.
        /// </summary>
        public NotificationReportStatusRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationReportStatusRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="device">device.</param>
        /// <param name="requestType">requestType.</param>
        /// <param name="requestExpirationTime">requestExpirationTime.</param>
        public NotificationReportStatusRequest(
            string accountName,
            Models.DeviceId device,
            string requestType,
            string requestExpirationTime = null)
        {
            this.AccountName = accountName;
            this.Device = device;
            this.RequestType = requestType;
            this.RequestExpirationTime = requestExpirationTime;
        }

        /// <summary>
        /// The name of a billing account.
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// An identifier for a single device.
        /// </summary>
        [JsonProperty("device")]
        public Models.DeviceId Device { get; set; }

        /// <summary>
        /// The type of request.
        /// </summary>
        [JsonProperty("requestType")]
        public string RequestType { get; set; }

        /// <summary>
        /// The time at which the request expires.
        /// </summary>
        [JsonProperty("requestExpirationTime", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestExpirationTime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"NotificationReportStatusRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is NotificationReportStatusRequest other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.Device == null && other.Device == null) || (this.Device?.Equals(other.Device) == true)) &&
                ((this.RequestType == null && other.RequestType == null) || (this.RequestType?.Equals(other.RequestType) == true)) &&
                ((this.RequestExpirationTime == null && other.RequestExpirationTime == null) || (this.RequestExpirationTime?.Equals(other.RequestExpirationTime) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.Device = {(this.Device == null ? "null" : this.Device.ToString())}");
            toStringOutput.Add($"this.RequestType = {(this.RequestType == null ? "null" : this.RequestType)}");
            toStringOutput.Add($"this.RequestExpirationTime = {(this.RequestExpirationTime == null ? "null" : this.RequestExpirationTime)}");
        }
    }
}