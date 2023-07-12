// <copyright file="FindDeviceByPropertyResponseList.cs" company="APIMatic">
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
    /// FindDeviceByPropertyResponseList.
    /// </summary>
    public class FindDeviceByPropertyResponseList
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FindDeviceByPropertyResponseList"/> class.
        /// </summary>
        public FindDeviceByPropertyResponseList()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FindDeviceByPropertyResponseList"/> class.
        /// </summary>
        /// <param name="deviceProperty">DeviceProperty.</param>
        public FindDeviceByPropertyResponseList(
            List<Models.FindDeviceByPropertyResponse> deviceProperty = null)
        {
            this.DeviceProperty = deviceProperty;
        }

        /// <summary>
        /// Gets or sets DeviceProperty.
        /// </summary>
        [JsonProperty("DeviceProperty", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.FindDeviceByPropertyResponse> DeviceProperty { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"FindDeviceByPropertyResponseList : ({string.Join(", ", toStringOutput)})";
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
            return obj is FindDeviceByPropertyResponseList other &&                ((this.DeviceProperty == null && other.DeviceProperty == null) || (this.DeviceProperty?.Equals(other.DeviceProperty) == true));
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