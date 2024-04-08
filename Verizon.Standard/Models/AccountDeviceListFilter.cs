// <copyright file="AccountDeviceListFilter.cs" company="APIMatic">
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
    /// AccountDeviceListFilter.
    /// </summary>
    public class AccountDeviceListFilter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDeviceListFilter"/> class.
        /// </summary>
        public AccountDeviceListFilter()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDeviceListFilter"/> class.
        /// </summary>
        /// <param name="deviceIdentifierFilters">deviceIdentifierFilters.</param>
        public AccountDeviceListFilter(
            List<Models.DeviceIdSearch> deviceIdentifierFilters)
        {
            this.DeviceIdentifierFilters = deviceIdentifierFilters;
        }

        /// <summary>
        /// Specify the kind of the device identifier, the type of match, and the string that you want to match.
        /// </summary>
        [JsonProperty("deviceIdentifierFilters")]
        public List<Models.DeviceIdSearch> DeviceIdentifierFilters { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AccountDeviceListFilter : ({string.Join(", ", toStringOutput)})";
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
            return obj is AccountDeviceListFilter other &&                ((this.DeviceIdentifierFilters == null && other.DeviceIdentifierFilters == null) || (this.DeviceIdentifierFilters?.Equals(other.DeviceIdentifierFilters) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DeviceIdentifierFilters = {(this.DeviceIdentifierFilters == null ? "null" : $"[{string.Join(", ", this.DeviceIdentifierFilters)} ]")}");
        }
    }
}