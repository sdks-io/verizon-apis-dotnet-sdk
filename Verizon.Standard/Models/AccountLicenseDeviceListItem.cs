// <copyright file="AccountLicenseDeviceListItem.cs" company="APIMatic">
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
    /// AccountLicenseDeviceListItem.
    /// </summary>
    public class AccountLicenseDeviceListItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountLicenseDeviceListItem"/> class.
        /// </summary>
        public AccountLicenseDeviceListItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountLicenseDeviceListItem"/> class.
        /// </summary>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="assignmentTime">assignmentTime.</param>
        public AccountLicenseDeviceListItem(
            string deviceId = null,
            DateTime? assignmentTime = null)
        {
            this.DeviceId = deviceId;
            this.AssignmentTime = assignmentTime;
        }

        /// <summary>
        /// Device IMEI.
        /// </summary>
        [JsonProperty("deviceId", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceId { get; set; }

        /// <summary>
        /// Timestamp of when a license was assigned to the device.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("assignmentTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? AssignmentTime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AccountLicenseDeviceListItem : ({string.Join(", ", toStringOutput)})";
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
            return obj is AccountLicenseDeviceListItem other &&                ((this.DeviceId == null && other.DeviceId == null) || (this.DeviceId?.Equals(other.DeviceId) == true)) &&
                ((this.AssignmentTime == null && other.AssignmentTime == null) || (this.AssignmentTime?.Equals(other.AssignmentTime) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DeviceId = {(this.DeviceId == null ? "null" : this.DeviceId)}");
            toStringOutput.Add($"this.AssignmentTime = {(this.AssignmentTime == null ? "null" : this.AssignmentTime.ToString())}");
        }
    }
}