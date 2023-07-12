// <copyright file="ServiceInstancesResultSetItem.cs" company="APIMatic">
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
    /// ServiceInstancesResultSetItem.
    /// </summary>
    public class ServiceInstancesResultSetItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceInstancesResultSetItem"/> class.
        /// </summary>
        public ServiceInstancesResultSetItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceInstancesResultSetItem"/> class.
        /// </summary>
        /// <param name="statusUrl">statusUrl.</param>
        /// <param name="requestId">requestId.</param>
        /// <param name="correlationId">correlationId.</param>
        /// <param name="status">status.</param>
        /// <param name="state">state.</param>
        /// <param name="service">service.</param>
        public ServiceInstancesResultSetItem(
            string statusUrl = null,
            string requestId = null,
            string correlationId = null,
            string status = null,
            string state = null,
            Models.ServiceInstance service = null)
        {
            this.StatusUrl = statusUrl;
            this.RequestId = requestId;
            this.CorrelationId = correlationId;
            this.Status = status;
            this.State = state;
            this.Service = service;
        }

        /// <summary>
        /// URL to check the status of the add service.
        /// </summary>
        [JsonProperty("statusUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusUrl { get; set; }

        /// <summary>
        /// A unique Id assigned to the request by system calling API.
        /// </summary>
        [JsonProperty("requestId", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// Gets or sets CorrelationId.
        /// </summary>
        [JsonProperty("correlationId", NullValueHandling = NullValueHandling.Ignore)]
        public string CorrelationId { get; set; }

        /// <summary>
        /// Status of the added service.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// State of the service instance.
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets Service.
        /// </summary>
        [JsonProperty("service", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ServiceInstance Service { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServiceInstancesResultSetItem : ({string.Join(", ", toStringOutput)})";
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
            return obj is ServiceInstancesResultSetItem other &&                ((this.StatusUrl == null && other.StatusUrl == null) || (this.StatusUrl?.Equals(other.StatusUrl) == true)) &&
                ((this.RequestId == null && other.RequestId == null) || (this.RequestId?.Equals(other.RequestId) == true)) &&
                ((this.CorrelationId == null && other.CorrelationId == null) || (this.CorrelationId?.Equals(other.CorrelationId) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.Service == null && other.Service == null) || (this.Service?.Equals(other.Service) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.StatusUrl = {(this.StatusUrl == null ? "null" : this.StatusUrl == string.Empty ? "" : this.StatusUrl)}");
            toStringOutput.Add($"this.RequestId = {(this.RequestId == null ? "null" : this.RequestId == string.Empty ? "" : this.RequestId)}");
            toStringOutput.Add($"this.CorrelationId = {(this.CorrelationId == null ? "null" : this.CorrelationId == string.Empty ? "" : this.CorrelationId)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State == string.Empty ? "" : this.State)}");
            toStringOutput.Add($"this.Service = {(this.Service == null ? "null" : this.Service.ToString())}");
        }
    }
}