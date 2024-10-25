// <copyright file="GetDeviceExperienceScoreHistoryRequest.cs" company="APIMatic">
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
    /// GetDeviceExperienceScoreHistoryRequest.
    /// </summary>
    public class GetDeviceExperienceScoreHistoryRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeviceExperienceScoreHistoryRequest"/> class.
        /// </summary>
        public GetDeviceExperienceScoreHistoryRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeviceExperienceScoreHistoryRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="deviceId">deviceId.</param>
        public GetDeviceExperienceScoreHistoryRequest(
            string accountName,
            Models.DeviceIdentifier deviceId)
        {
            this.AccountName = accountName;
            this.DeviceId = deviceId;
        }

        /// <summary>
        /// Account name.
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Device Id details.
        /// </summary>
        [JsonProperty("deviceId")]
        public Models.DeviceIdentifier DeviceId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetDeviceExperienceScoreHistoryRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is GetDeviceExperienceScoreHistoryRequest other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.DeviceId == null && other.DeviceId == null) || (this.DeviceId?.Equals(other.DeviceId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.DeviceId = {(this.DeviceId == null ? "null" : this.DeviceId.ToString())}");
        }
    }
}