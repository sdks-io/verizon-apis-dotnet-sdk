// <copyright file="DeviceDiagnosticsCallback.cs" company="APIMatic">
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
    /// DeviceDiagnosticsCallback.
    /// </summary>
    public class DeviceDiagnosticsCallback
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceDiagnosticsCallback"/> class.
        /// </summary>
        public DeviceDiagnosticsCallback()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceDiagnosticsCallback"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="serviceName">serviceName.</param>
        /// <param name="endpoint">endpoint.</param>
        /// <param name="createdOn">createdOn.</param>
        /// <param name="httpHeaders">httpHeaders.</param>
        public DeviceDiagnosticsCallback(
            string accountName,
            string serviceName,
            string endpoint,
            DateTime createdOn,
            object httpHeaders = null)
        {
            this.AccountName = accountName;
            this.ServiceName = serviceName;
            this.Endpoint = endpoint;
            this.CreatedOn = createdOn;
            this.HttpHeaders = httpHeaders;
        }

        /// <summary>
        /// The name of the billing account for which callback messages will be sent. Format: "##########-#####".
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// The name of the callback service, which identifies the type and format of messages that will be sent to the registered URL.
        /// </summary>
        [JsonProperty("serviceName")]
        public string ServiceName { get; set; }

        /// <summary>
        /// The URL for your web server.
        /// </summary>
        [JsonProperty("endpoint")]
        public string Endpoint { get; set; }

        /// <summary>
        /// The date and time of when this request was created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdOn")]
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Your HTTP headers.
        /// </summary>
        [JsonProperty("httpHeaders", NullValueHandling = NullValueHandling.Ignore)]
        public object HttpHeaders { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeviceDiagnosticsCallback : ({string.Join(", ", toStringOutput)})";
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
            return obj is DeviceDiagnosticsCallback other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.ServiceName == null && other.ServiceName == null) || (this.ServiceName?.Equals(other.ServiceName) == true)) &&
                ((this.Endpoint == null && other.Endpoint == null) || (this.Endpoint?.Equals(other.Endpoint) == true)) &&
                this.CreatedOn.Equals(other.CreatedOn) &&
                ((this.HttpHeaders == null && other.HttpHeaders == null) || (this.HttpHeaders?.Equals(other.HttpHeaders) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.ServiceName = {(this.ServiceName == null ? "null" : this.ServiceName)}");
            toStringOutput.Add($"this.Endpoint = {(this.Endpoint == null ? "null" : this.Endpoint)}");
            toStringOutput.Add($"this.CreatedOn = {this.CreatedOn}");
            toStringOutput.Add($"HttpHeaders = {(this.HttpHeaders == null ? "null" : this.HttpHeaders.ToString())}");
        }
    }
}