// <copyright file="DeviceLocationSuccessResult.cs" company="APIMatic">
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
    /// DeviceLocationSuccessResult.
    /// </summary>
    public class DeviceLocationSuccessResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceLocationSuccessResult"/> class.
        /// </summary>
        public DeviceLocationSuccessResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceLocationSuccessResult"/> class.
        /// </summary>
        /// <param name="success">success.</param>
        public DeviceLocationSuccessResult(
            bool? success = null)
        {
            this.Success = success;
        }

        /// <summary>
        /// Gets or sets Success.
        /// </summary>
        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Success { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeviceLocationSuccessResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is DeviceLocationSuccessResult other &&                ((this.Success == null && other.Success == null) || (this.Success?.Equals(other.Success) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Success = {(this.Success == null ? "null" : this.Success.ToString())}");
        }
    }
}