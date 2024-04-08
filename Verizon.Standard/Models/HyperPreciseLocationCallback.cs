// <copyright file="HyperPreciseLocationCallback.cs" company="APIMatic">
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
    /// HyperPreciseLocationCallback.
    /// </summary>
    public class HyperPreciseLocationCallback
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HyperPreciseLocationCallback"/> class.
        /// </summary>
        public HyperPreciseLocationCallback()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HyperPreciseLocationCallback"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="url">url.</param>
        public HyperPreciseLocationCallback(
            string name,
            string url)
        {
            this.Name = name;
            this.Url = url;
        }

        /// <summary>
        /// The name of the callback service that you want to subscribe to.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The address on your server where you have enabled a listening service for the specific type of callback messages. Specify a URL that is reachable from the Verizon data centers. If your service is running on HTTPS, you should use a one-way authentication certificate with a white-listed IP address.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"HyperPreciseLocationCallback : ({string.Join(", ", toStringOutput)})";
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
            return obj is HyperPreciseLocationCallback other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url)}");
        }
    }
}