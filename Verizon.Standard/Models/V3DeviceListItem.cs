// <copyright file="V3DeviceListItem.cs" company="APIMatic">
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
    /// V3DeviceListItem.
    /// </summary>
    public class V3DeviceListItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V3DeviceListItem"/> class.
        /// </summary>
        public V3DeviceListItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V3DeviceListItem"/> class.
        /// </summary>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="status">status.</param>
        /// <param name="reason">Reason.</param>
        public V3DeviceListItem(
            string deviceId = null,
            string status = null,
            string reason = null)
        {
            this.DeviceId = deviceId;
            this.Status = status;
            this.Reason = reason;
        }

        /// <summary>
        /// Device IMEI.
        /// </summary>
        [JsonProperty("deviceId", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceId { get; set; }

        /// <summary>
        /// Success or failure.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Result reason.
        /// </summary>
        [JsonProperty("Reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"V3DeviceListItem : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is V3DeviceListItem other &&
                (this.DeviceId == null && other.DeviceId == null ||
                 this.DeviceId?.Equals(other.DeviceId) == true) &&
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
            toStringOutput.Add($"Status = {this.Status ?? "null"}");
            toStringOutput.Add($"Reason = {this.Reason ?? "null"}");
        }
    }
}