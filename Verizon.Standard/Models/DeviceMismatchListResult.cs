// <copyright file="DeviceMismatchListResult.cs" company="APIMatic">
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
    /// DeviceMismatchListResult.
    /// </summary>
    public class DeviceMismatchListResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceMismatchListResult"/> class.
        /// </summary>
        public DeviceMismatchListResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceMismatchListResult"/> class.
        /// </summary>
        /// <param name="devices">devices.</param>
        public DeviceMismatchListResult(
            List<Models.MismatchedDevice> devices = null)
        {
            this.Devices = devices;
        }

        /// <summary>
        /// A list of specific devices that you want to check, specified by ICCID or MDN.
        /// </summary>
        [JsonProperty("devices", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.MismatchedDevice> Devices { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeviceMismatchListResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is DeviceMismatchListResult other &&                ((this.Devices == null && other.Devices == null) || (this.Devices?.Equals(other.Devices) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Devices = {(this.Devices == null ? "null" : $"[{string.Join(", ", this.Devices)} ]")}");
        }
    }
}