// <copyright file="SearchDeviceByPropertyResponseList.cs" company="APIMatic">
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
    /// SearchDeviceByPropertyResponseList.
    /// </summary>
    public class SearchDeviceByPropertyResponseList
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchDeviceByPropertyResponseList"/> class.
        /// </summary>
        public SearchDeviceByPropertyResponseList()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchDeviceByPropertyResponseList"/> class.
        /// </summary>
        /// <param name="deviceProperty">DeviceProperty.</param>
        public SearchDeviceByPropertyResponseList(
            List<Models.SearchDeviceByPropertyResponse> deviceProperty = null)
        {
            this.DeviceProperty = deviceProperty;
        }

        /// <summary>
        /// Gets or sets DeviceProperty.
        /// </summary>
        [JsonProperty("DeviceProperty", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.SearchDeviceByPropertyResponse> DeviceProperty { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SearchDeviceByPropertyResponseList : ({string.Join(", ", toStringOutput)})";
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
            return obj is SearchDeviceByPropertyResponseList other &&                ((this.DeviceProperty == null && other.DeviceProperty == null) || (this.DeviceProperty?.Equals(other.DeviceProperty) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DeviceProperty = {(this.DeviceProperty == null ? "null" : $"[{string.Join(", ", this.DeviceProperty)} ]")}");
        }
    }
}