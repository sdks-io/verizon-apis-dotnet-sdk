// <copyright file="ProfileChangeStateRequest.cs" company="APIMatic">
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
    /// ProfileChangeStateRequest.
    /// </summary>
    public class ProfileChangeStateRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileChangeStateRequest"/> class.
        /// </summary>
        public ProfileChangeStateRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileChangeStateRequest"/> class.
        /// </summary>
        /// <param name="devices">devices.</param>
        /// <param name="accountName">accountName.</param>
        /// <param name="smsrOid">smsrOid.</param>
        public ProfileChangeStateRequest(
            List<Models.DeviceList> devices,
            string accountName,
            string smsrOid)
        {
            this.Devices = devices;
            this.AccountName = accountName;
            this.SmsrOid = smsrOid;
        }

        /// <summary>
        /// Gets or sets Devices.
        /// </summary>
        [JsonProperty("devices")]
        public List<Models.DeviceList> Devices { get; set; }

        /// <summary>
        /// Gets or sets AccountName.
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets SmsrOid.
        /// </summary>
        [JsonProperty("smsrOid")]
        public string SmsrOid { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ProfileChangeStateRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is ProfileChangeStateRequest other &&                ((this.Devices == null && other.Devices == null) || (this.Devices?.Equals(other.Devices) == true)) &&
                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.SmsrOid == null && other.SmsrOid == null) || (this.SmsrOid?.Equals(other.SmsrOid) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Devices = {(this.Devices == null ? "null" : $"[{string.Join(", ", this.Devices)} ]")}");
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.SmsrOid = {(this.SmsrOid == null ? "null" : this.SmsrOid)}");
        }
    }
}