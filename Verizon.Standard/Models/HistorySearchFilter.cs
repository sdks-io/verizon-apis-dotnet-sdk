// <copyright file="HistorySearchFilter.cs" company="APIMatic">
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
    /// HistorySearchFilter.
    /// </summary>
    public class HistorySearchFilter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HistorySearchFilter"/> class.
        /// </summary>
        public HistorySearchFilter()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HistorySearchFilter"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="device">device.</param>
        /// <param name="attributes">attributes.</param>
        public HistorySearchFilter(
            string accountName,
            Models.Device device,
            Models.HistorySearchFilterAttributes attributes = null)
        {
            this.AccountName = accountName;
            this.Device = device;
            this.Attributes = attributes;
        }

        /// <summary>
        /// Account name identifier.
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Identifies a particular IoT device.
        /// </summary>
        [JsonProperty("device")]
        public Models.Device Device { get; set; }

        /// <summary>
        /// Streaming RF parameters for which you want to retrieve history data.
        /// </summary>
        [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore)]
        public Models.HistorySearchFilterAttributes Attributes { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"HistorySearchFilter : ({string.Join(", ", toStringOutput)})";
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
            return obj is HistorySearchFilter other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.Device == null && other.Device == null) || (this.Device?.Equals(other.Device) == true)) &&
                ((this.Attributes == null && other.Attributes == null) || (this.Attributes?.Equals(other.Attributes) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName == string.Empty ? "" : this.AccountName)}");
            toStringOutput.Add($"this.Device = {(this.Device == null ? "null" : this.Device.ToString())}");
            toStringOutput.Add($"this.Attributes = {(this.Attributes == null ? "null" : this.Attributes.ToString())}");
        }
    }
}