// <copyright file="ChangePmecDeviceStateBulkActivateRequest.cs" company="APIMatic">
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
    using APIMatic.Core.Utilities.Converters;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Verizon.Standard;
    using Verizon.Standard.Utilities;

    /// <summary>
    /// ChangePmecDeviceStateBulkActivateRequest.
    /// </summary>
    public class ChangePmecDeviceStateBulkActivateRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangePmecDeviceStateBulkActivateRequest"/> class.
        /// </summary>
        public ChangePmecDeviceStateBulkActivateRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangePmecDeviceStateBulkActivateRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="deviceList">deviceList.</param>
        /// <param name="activate">activate.</param>
        public ChangePmecDeviceStateBulkActivateRequest(
            string accountName,
            List<Models.DeviceList1> deviceList,
            Models.Activate activate)
        {
            this.AccountName = accountName;
            this.DeviceList = deviceList;
            this.Activate = activate;
        }

        /// <summary>
        /// Gets or sets AccountName.
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets DeviceList.
        /// </summary>
        [JsonProperty("deviceList")]
        public List<Models.DeviceList1> DeviceList { get; set; }

        /// <summary>
        /// Gets or sets Activate.
        /// </summary>
        [JsonProperty("activate")]
        public Models.Activate Activate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ChangePmecDeviceStateBulkActivateRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is ChangePmecDeviceStateBulkActivateRequest other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.DeviceList == null && other.DeviceList == null) || (this.DeviceList?.Equals(other.DeviceList) == true)) &&
                ((this.Activate == null && other.Activate == null) || (this.Activate?.Equals(other.Activate) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.DeviceList = {(this.DeviceList == null ? "null" : $"[{string.Join(", ", this.DeviceList)} ]")}");
            toStringOutput.Add($"this.Activate = {(this.Activate == null ? "null" : this.Activate.ToString())}");
        }
    }
}