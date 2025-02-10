// <copyright file="BilledusageListRequest.cs" company="APIMatic">
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
    /// BilledusageListRequest.
    /// </summary>
    public class BilledusageListRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BilledusageListRequest"/> class.
        /// </summary>
        public BilledusageListRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BilledusageListRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="labels">labels.</param>
        /// <param name="deviceIds">deviceIds.</param>
        /// <param name="billingCycle">billingCycle.</param>
        public BilledusageListRequest(
            string accountName,
            Models.LabelsList labels = null,
            List<Models.DeviceList> deviceIds = null,
            Models.BillingCycle billingCycle = null)
        {
            this.AccountName = accountName;
            this.Labels = labels;
            this.DeviceIds = deviceIds;
            this.BillingCycle = billingCycle;
        }

        /// <summary>
        /// Gets or sets AccountName.
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets Labels.
        /// </summary>
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public Models.LabelsList Labels { get; set; }

        /// <summary>
        /// Gets or sets DeviceIds.
        /// </summary>
        [JsonProperty("deviceIds", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DeviceList> DeviceIds { get; set; }

        /// <summary>
        /// Gets or sets BillingCycle.
        /// </summary>
        [JsonProperty("billingCycle", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BillingCycle BillingCycle { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"BilledusageListRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is BilledusageListRequest other &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.Labels == null && other.Labels == null ||
                 this.Labels?.Equals(other.Labels) == true) &&
                (this.DeviceIds == null && other.DeviceIds == null ||
                 this.DeviceIds?.Equals(other.DeviceIds) == true) &&
                (this.BillingCycle == null && other.BillingCycle == null ||
                 this.BillingCycle?.Equals(other.BillingCycle) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
            toStringOutput.Add($"Labels = {(this.Labels == null ? "null" : this.Labels.ToString())}");
            toStringOutput.Add($"DeviceIds = {(this.DeviceIds == null ? "null" : $"[{string.Join(", ", this.DeviceIds)} ]")}");
            toStringOutput.Add($"BillingCycle = {(this.BillingCycle == null ? "null" : this.BillingCycle.ToString())}");
        }
    }
}