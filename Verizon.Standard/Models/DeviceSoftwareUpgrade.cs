// <copyright file="DeviceSoftwareUpgrade.cs" company="APIMatic">
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
    /// DeviceSoftwareUpgrade.
    /// </summary>
    public class DeviceSoftwareUpgrade
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceSoftwareUpgrade"/> class.
        /// </summary>
        public DeviceSoftwareUpgrade()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceSoftwareUpgrade"/> class.
        /// </summary>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="id">id.</param>
        /// <param name="accountName">accountName.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="status">status.</param>
        /// <param name="reason">reason.</param>
        /// <param name="softwareName">softwareName.</param>
        public DeviceSoftwareUpgrade(
            string deviceId,
            string id,
            string accountName,
            DateTime startDate,
            string status,
            string reason,
            string softwareName = null)
        {
            this.DeviceId = deviceId;
            this.Id = id;
            this.AccountName = accountName;
            this.SoftwareName = softwareName;
            this.StartDate = startDate;
            this.Status = status;
            this.Reason = reason;
        }

        /// <summary>
        /// Device identifier.
        /// </summary>
        [JsonProperty("deviceId")]
        public string DeviceId { get; set; }

        /// <summary>
        /// Upgrade identifier.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Account identifier.
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Software name.
        /// </summary>
        [JsonProperty("softwareName", NullValueHandling = NullValueHandling.Ignore)]
        public string SoftwareName { get; set; }

        /// <summary>
        /// Software upgrade start date.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("startDate")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Software upgrade status.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Software upgrade result reason.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DeviceSoftwareUpgrade : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DeviceSoftwareUpgrade other &&
                (this.DeviceId == null && other.DeviceId == null ||
                 this.DeviceId?.Equals(other.DeviceId) == true) &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.SoftwareName == null && other.SoftwareName == null ||
                 this.SoftwareName?.Equals(other.SoftwareName) == true) &&
                (this.StartDate.Equals(other.StartDate)) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.Reason == null && other.Reason == null ||
                 this.Reason?.Equals(other.Reason) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"DeviceId = {this.DeviceId ?? "null"}");
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
            toStringOutput.Add($"SoftwareName = {this.SoftwareName ?? "null"}");
            toStringOutput.Add($"StartDate = {this.StartDate}");
            toStringOutput.Add($"Status = {this.Status ?? "null"}");
            toStringOutput.Add($"Reason = {this.Reason ?? "null"}");
        }
    }
}