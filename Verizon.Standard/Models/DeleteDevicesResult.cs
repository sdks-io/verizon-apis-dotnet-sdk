// <copyright file="DeleteDevicesResult.cs" company="APIMatic">
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
    /// DeleteDevicesResult.
    /// </summary>
    public class DeleteDevicesResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDevicesResult"/> class.
        /// </summary>
        public DeleteDevicesResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDevicesResult"/> class.
        /// </summary>
        /// <param name="deviceIds">deviceIds.</param>
        /// <param name="status">status.</param>
        /// <param name="message">message.</param>
        public DeleteDevicesResult(
            object deviceIds = null,
            string status = null,
            string message = null)
        {
            this.DeviceIds = deviceIds;
            this.Status = status;
            this.Message = message;
        }

        /// <summary>
        /// One object per device to be deleted. Each object must contain a kind and id element identifying the device.
        /// </summary>
        [JsonProperty("deviceIds", NullValueHandling = NullValueHandling.Ignore)]
        public object DeviceIds { get; set; }

        /// <summary>
        /// “Success” if the device was deleted, or “Failed” if there was a problem.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Not present if status=Success. One of these messages if status=Failed:The device is not in deactivate state.The user does not have access to delete the device.
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeleteDevicesResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is DeleteDevicesResult other &&                ((this.DeviceIds == null && other.DeviceIds == null) || (this.DeviceIds?.Equals(other.DeviceIds) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Message == null && other.Message == null) || (this.Message?.Equals(other.Message) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"DeviceIds = {(this.DeviceIds == null ? "null" : this.DeviceIds.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status)}");
            toStringOutput.Add($"this.Message = {(this.Message == null ? "null" : this.Message)}");
        }
    }
}