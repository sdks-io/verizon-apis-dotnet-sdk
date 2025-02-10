// <copyright file="CallbackCreated.cs" company="APIMatic">
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
    /// CallbackCreated.
    /// </summary>
    public class CallbackCreated
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackCreated"/> class.
        /// </summary>
        public CallbackCreated()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackCreated"/> class.
        /// </summary>
        /// <param name="aname">aname.</param>
        /// <param name="name">name.</param>
        /// <param name="url">url.</param>
        public CallbackCreated(
            string aname,
            string name,
            string url = null)
        {
            this.Aname = aname;
            this.Name = name;
            this.Url = url;
        }

        /// <summary>
        /// The billing account number for which callback messages will be sent.
        /// </summary>
        [JsonProperty("aname")]
        public string Aname { get; set; }

        /// <summary>
        /// The name of the callback service, which identifies the type and format of messages that will be sent to the registered URL.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The address of the callback listening service where the ThingSpace Platform will send callback messages for the service type.
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CallbackCreated : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CallbackCreated other &&
                (this.Aname == null && other.Aname == null ||
                 this.Aname?.Equals(other.Aname) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Url == null && other.Url == null ||
                 this.Url?.Equals(other.Url) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Aname = {this.Aname ?? "null"}");
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Url = {this.Url ?? "null"}");
        }
    }
}