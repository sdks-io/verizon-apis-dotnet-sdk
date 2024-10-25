// <copyright file="ListOptimalServiceEndpointsResult.cs" company="APIMatic">
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
    /// ListOptimalServiceEndpointsResult.
    /// </summary>
    public class ListOptimalServiceEndpointsResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListOptimalServiceEndpointsResult"/> class.
        /// </summary>
        public ListOptimalServiceEndpointsResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOptimalServiceEndpointsResult"/> class.
        /// </summary>
        /// <param name="serviceEndpoints">serviceEndpoints.</param>
        public ListOptimalServiceEndpointsResult(
            List<Models.ResourcesEdgeHostedService> serviceEndpoints = null)
        {
            this.ServiceEndpoints = serviceEndpoints;
        }

        /// <summary>
        /// An array of optimal Service Endpoint IDs for clients to connect to.
        /// </summary>
        [JsonProperty("serviceEndpoints", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ResourcesEdgeHostedService> ServiceEndpoints { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListOptimalServiceEndpointsResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is ListOptimalServiceEndpointsResult other &&                ((this.ServiceEndpoints == null && other.ServiceEndpoints == null) || (this.ServiceEndpoints?.Equals(other.ServiceEndpoints) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ServiceEndpoints = {(this.ServiceEndpoints == null ? "null" : $"[{string.Join(", ", this.ServiceEndpoints)} ]")}");
        }
    }
}