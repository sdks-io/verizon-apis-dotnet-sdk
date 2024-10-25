// <copyright file="RetrieveMonitorsRequest.cs" company="APIMatic">
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
    /// RetrieveMonitorsRequest.
    /// </summary>
    public class RetrieveMonitorsRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveMonitorsRequest"/> class.
        /// </summary>
        public RetrieveMonitorsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveMonitorsRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="devices">devices.</param>
        /// <param name="monitorType">monitorType.</param>
        public RetrieveMonitorsRequest(
            string accountName,
            List<Models.AccountDeviceList> devices,
            string monitorType = null)
        {
            this.AccountName = accountName;
            this.Devices = devices;
            this.MonitorType = monitorType;
        }

        /// <summary>
        /// The name of a billing account.
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// The devices for which you want to restore service, specified by device identifier.
        /// </summary>
        [JsonProperty("devices")]
        public List<Models.AccountDeviceList> Devices { get; set; }

        /// <summary>
        /// The name of a billing account.
        /// </summary>
        [JsonProperty("monitorType", NullValueHandling = NullValueHandling.Ignore)]
        public string MonitorType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RetrieveMonitorsRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is RetrieveMonitorsRequest other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.Devices == null && other.Devices == null) || (this.Devices?.Equals(other.Devices) == true)) &&
                ((this.MonitorType == null && other.MonitorType == null) || (this.MonitorType?.Equals(other.MonitorType) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.Devices = {(this.Devices == null ? "null" : $"[{string.Join(", ", this.Devices)} ]")}");
            toStringOutput.Add($"this.MonitorType = {(this.MonitorType == null ? "null" : this.MonitorType)}");
        }
    }
}