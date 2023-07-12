// <copyright file="BilledusageListRequest.cs" company="APIMatic">
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
        /// <param name="devices">devices.</param>
        /// <param name="billingCycle">BillingCycle.</param>
        public BilledusageListRequest(
            string accountName = null,
            Models.LabelsList labels = null,
            List<Models.DeviceList> devices = null,
            Models.BillingCycle billingCycle = null)
        {
            this.AccountName = accountName;
            this.Labels = labels;
            this.Devices = devices;
            this.BillingCycle = billingCycle;
        }

        /// <summary>
        /// Gets or sets AccountName.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets Labels.
        /// </summary>
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public Models.LabelsList Labels { get; set; }

        /// <summary>
        /// Gets or sets Devices.
        /// </summary>
        [JsonProperty("devices", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DeviceList> Devices { get; set; }

        /// <summary>
        /// Gets or sets BillingCycle.
        /// </summary>
        [JsonProperty("BillingCycle", NullValueHandling = NullValueHandling.Ignore)]
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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is BilledusageListRequest other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.Labels == null && other.Labels == null) || (this.Labels?.Equals(other.Labels) == true)) &&
                ((this.Devices == null && other.Devices == null) || (this.Devices?.Equals(other.Devices) == true)) &&
                ((this.BillingCycle == null && other.BillingCycle == null) || (this.BillingCycle?.Equals(other.BillingCycle) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName == string.Empty ? "" : this.AccountName)}");
            toStringOutput.Add($"this.Labels = {(this.Labels == null ? "null" : this.Labels.ToString())}");
            toStringOutput.Add($"this.Devices = {(this.Devices == null ? "null" : $"[{string.Join(", ", this.Devices)} ]")}");
            toStringOutput.Add($"this.BillingCycle = {(this.BillingCycle == null ? "null" : this.BillingCycle.ToString())}");
        }
    }
}