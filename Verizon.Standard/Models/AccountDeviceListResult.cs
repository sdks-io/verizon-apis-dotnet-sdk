// <copyright file="AccountDeviceListResult.cs" company="APIMatic">
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
    /// AccountDeviceListResult.
    /// </summary>
    public class AccountDeviceListResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDeviceListResult"/> class.
        /// </summary>
        public AccountDeviceListResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDeviceListResult"/> class.
        /// </summary>
        /// <param name="devices">devices.</param>
        /// <param name="hasMoreData">hasMoreData.</param>
        public AccountDeviceListResult(
            List<Models.ThingspaceDevice> devices = null,
            bool? hasMoreData = null)
        {
            this.Devices = devices;
            this.HasMoreData = hasMoreData;
        }

        /// <summary>
        /// Up to 10,000 devices that you want to move to a different account, specified by device identifier.
        /// </summary>
        [JsonProperty("devices", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ThingspaceDevice> Devices { get; set; }

        /// <summary>
        /// False for a status 200 response.True for a status 202 response, indicating that there is more data to be retrieved.
        /// </summary>
        [JsonProperty("hasMoreData", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasMoreData { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AccountDeviceListResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is AccountDeviceListResult other &&                ((this.Devices == null && other.Devices == null) || (this.Devices?.Equals(other.Devices) == true)) &&
                ((this.HasMoreData == null && other.HasMoreData == null) || (this.HasMoreData?.Equals(other.HasMoreData) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Devices = {(this.Devices == null ? "null" : $"[{string.Join(", ", this.Devices)} ]")}");
            toStringOutput.Add($"this.HasMoreData = {(this.HasMoreData == null ? "null" : this.HasMoreData.ToString())}");
        }
    }
}