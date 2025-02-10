// <copyright file="DeviceManagementResult.cs" company="APIMatic">
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
    /// DeviceManagementResult.
    /// </summary>
    public class DeviceManagementResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceManagementResult"/> class.
        /// </summary>
        public DeviceManagementResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceManagementResult"/> class.
        /// </summary>
        /// <param name="requestId">requestId.</param>
        public DeviceManagementResult(
            string requestId = null)
        {
            this.RequestId = requestId;
        }

        /// <summary>
        /// A unique string that associates the request with the results that are sent via a callback service.
        /// </summary>
        [JsonProperty("requestId", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DeviceManagementResult : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DeviceManagementResult other &&
                (this.RequestId == null && other.RequestId == null ||
                 this.RequestId?.Equals(other.RequestId) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"RequestId = {this.RequestId ?? "null"}");
        }
    }
}