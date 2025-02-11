// <copyright file="CallbackActionResult.cs" company="APIMatic">
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
    /// CallbackActionResult.
    /// </summary>
    public class CallbackActionResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackActionResult"/> class.
        /// </summary>
        public CallbackActionResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackActionResult"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="serviceName">serviceName.</param>
        public CallbackActionResult(
            string accountName = null,
            string serviceName = null)
        {
            this.AccountName = accountName;
            this.ServiceName = serviceName;
        }

        /// <summary>
        /// The name of the billing account.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// The name of the callback service that was registered/deregistered.
        /// </summary>
        [JsonProperty("serviceName", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CallbackActionResult : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CallbackActionResult other &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.ServiceName == null && other.ServiceName == null ||
                 this.ServiceName?.Equals(other.ServiceName) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
            toStringOutput.Add($"ServiceName = {this.ServiceName ?? "null"}");
        }
    }
}