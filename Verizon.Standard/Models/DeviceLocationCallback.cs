// <copyright file="DeviceLocationCallback.cs" company="APIMatic">
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
    /// DeviceLocationCallback.
    /// </summary>
    public class DeviceLocationCallback
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceLocationCallback"/> class.
        /// </summary>
        public DeviceLocationCallback()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceLocationCallback"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="url">url.</param>
        public DeviceLocationCallback(
            Models.CallbackServiceNameEnum name,
            string url)
        {
            this.Name = name;
            this.Url = url;
        }

        /// <summary>
        /// The name of the callback service.
        /// </summary>
        [JsonProperty("name")]
        public Models.CallbackServiceNameEnum Name { get; set; }

        /// <summary>
        /// The location of your callback listener.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeviceLocationCallback : ({string.Join(", ", toStringOutput)})";
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
            return obj is DeviceLocationCallback other &&                this.Name.Equals(other.Name) &&
                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {this.Name}");
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url)}");
        }
    }
}