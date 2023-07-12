// <copyright file="DeviceFirmwareVersionUpdateResult.cs" company="APIMatic">
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
    /// DeviceFirmwareVersionUpdateResult.
    /// </summary>
    public class DeviceFirmwareVersionUpdateResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceFirmwareVersionUpdateResult"/> class.
        /// </summary>
        public DeviceFirmwareVersionUpdateResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceFirmwareVersionUpdateResult"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="requestId">requestId.</param>
        public DeviceFirmwareVersionUpdateResult(
            string accountName,
            string requestId)
        {
            this.AccountName = accountName;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Account identifier.
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Request identifier.
        /// </summary>
        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeviceFirmwareVersionUpdateResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is DeviceFirmwareVersionUpdateResult other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.RequestId == null && other.RequestId == null) || (this.RequestId?.Equals(other.RequestId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName == string.Empty ? "" : this.AccountName)}");
            toStringOutput.Add($"this.RequestId = {(this.RequestId == null ? "null" : this.RequestId == string.Empty ? "" : this.RequestId)}");
        }
    }
}