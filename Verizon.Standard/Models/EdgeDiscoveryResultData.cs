// <copyright file="EdgeDiscoveryResultData.cs" company="APIMatic">
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
    /// EdgeDiscoveryResultData.
    /// </summary>
    public class EdgeDiscoveryResultData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeDiscoveryResultData"/> class.
        /// </summary>
        public EdgeDiscoveryResultData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeDiscoveryResultData"/> class.
        /// </summary>
        /// <param name="additionalMessage">additionalMessage.</param>
        public EdgeDiscoveryResultData(
            string additionalMessage = null)
        {
            this.AdditionalMessage = additionalMessage;
        }

        /// <summary>
        /// Gets or sets AdditionalMessage.
        /// </summary>
        [JsonProperty("additionalMessage", NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionalMessage { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"EdgeDiscoveryResultData : ({string.Join(", ", toStringOutput)})";
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
            return obj is EdgeDiscoveryResultData other &&                ((this.AdditionalMessage == null && other.AdditionalMessage == null) || (this.AdditionalMessage?.Equals(other.AdditionalMessage) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AdditionalMessage = {(this.AdditionalMessage == null ? "null" : this.AdditionalMessage)}");
        }
    }
}