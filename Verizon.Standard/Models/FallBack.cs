// <copyright file="FallBack.cs" company="APIMatic">
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
    /// FallBack.
    /// </summary>
    public class FallBack
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FallBack"/> class.
        /// </summary>
        public FallBack()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FallBack"/> class.
        /// </summary>
        /// <param name="devices">devices.</param>
        /// <param name="accountName">accountName.</param>
        public FallBack(
            List<List<Models.DeviceIdarray>> devices = null,
            string accountName = null)
        {
            this.Devices = devices;
            this.AccountName = accountName;
        }

        /// <summary>
        /// An array containing the `deviceId` array.
        /// </summary>
        [JsonProperty("devices", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<Models.DeviceIdarray>> Devices { get; set; }

        /// <summary>
        /// The numeric name of the account, in the format "0000123456-00001". Leading zeros must be included.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"FallBack : ({string.Join(", ", toStringOutput)})";
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
            return obj is FallBack other &&                ((this.Devices == null && other.Devices == null) || (this.Devices?.Equals(other.Devices) == true)) &&
                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Devices = {(this.Devices == null ? "null" : $"[{string.Join(", ", this.Devices)} ]")}");
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
        }
    }
}