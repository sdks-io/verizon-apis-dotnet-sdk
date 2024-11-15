// <copyright file="HyperPreciseLocationFault.cs" company="APIMatic">
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
    /// HyperPreciseLocationFault.
    /// </summary>
    public class HyperPreciseLocationFault
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HyperPreciseLocationFault"/> class.
        /// </summary>
        public HyperPreciseLocationFault()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HyperPreciseLocationFault"/> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="message">message.</param>
        /// <param name="description">description.</param>
        public HyperPreciseLocationFault(
            string code = null,
            string message = null,
            string description = null)
        {
            this.Code = code;
            this.Message = message;
            this.Description = description;
        }

        /// <summary>
        /// Hyper precise location fault code.
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// Hyper precise location fault message.
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// Hyper precise location fault description.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"HyperPreciseLocationFault : ({string.Join(", ", toStringOutput)})";
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
            return obj is HyperPreciseLocationFault other &&                ((this.Code == null && other.Code == null) || (this.Code?.Equals(other.Code) == true)) &&
                ((this.Message == null && other.Message == null) || (this.Message?.Equals(other.Message) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code)}");
            toStringOutput.Add($"this.Message = {(this.Message == null ? "null" : this.Message)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
        }
    }
}