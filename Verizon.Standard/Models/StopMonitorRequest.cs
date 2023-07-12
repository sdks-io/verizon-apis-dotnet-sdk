// <copyright file="StopMonitorRequest.cs" company="APIMatic">
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
    /// StopMonitorRequest.
    /// </summary>
    public class StopMonitorRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StopMonitorRequest"/> class.
        /// </summary>
        public StopMonitorRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StopMonitorRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="monitorIds">monitorIds.</param>
        public StopMonitorRequest(
            string accountName,
            List<string> monitorIds)
        {
            this.AccountName = accountName;
            this.MonitorIds = monitorIds;
        }

        /// <summary>
        /// Gets or sets AccountName.
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets MonitorIds.
        /// </summary>
        [JsonProperty("monitorIds")]
        public List<string> MonitorIds { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"StopMonitorRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is StopMonitorRequest other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.MonitorIds == null && other.MonitorIds == null) || (this.MonitorIds?.Equals(other.MonitorIds) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName == string.Empty ? "" : this.AccountName)}");
            toStringOutput.Add($"this.MonitorIds = {(this.MonitorIds == null ? "null" : $"[{string.Join(", ", this.MonitorIds)} ]")}");
        }
    }
}