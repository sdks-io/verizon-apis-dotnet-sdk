// <copyright file="SecuritySuccessResult.cs" company="APIMatic">
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
    /// SecuritySuccessResult.
    /// </summary>
    public class SecuritySuccessResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecuritySuccessResult"/> class.
        /// </summary>
        public SecuritySuccessResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecuritySuccessResult"/> class.
        /// </summary>
        /// <param name="requestId">requestId.</param>
        public SecuritySuccessResult(
            string requestId = null)
        {
            this.RequestId = requestId;
        }

        /// <summary>
        /// A unique string that associates the request with the results that are sent via a callback message.The ThingSpace Platform sends a separate callback message for each device that matches the request criteria, indicating whether the operation succeeded for that device and containing any requested information. All callback messages will have the same requestId.
        /// </summary>
        [JsonProperty("requestId", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SecuritySuccessResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is SecuritySuccessResult other &&                ((this.RequestId == null && other.RequestId == null) || (this.RequestId?.Equals(other.RequestId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RequestId = {(this.RequestId == null ? "null" : this.RequestId == string.Empty ? "" : this.RequestId)}");
        }
    }
}