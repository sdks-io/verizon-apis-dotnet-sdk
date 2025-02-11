// <copyright file="RegisterServiceEndpointResult.cs" company="APIMatic">
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
    /// RegisterServiceEndpointResult.
    /// </summary>
    public class RegisterServiceEndpointResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterServiceEndpointResult"/> class.
        /// </summary>
        public RegisterServiceEndpointResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterServiceEndpointResult"/> class.
        /// </summary>
        /// <param name="serviceEndpointsId">serviceEndpointsId.</param>
        public RegisterServiceEndpointResult(
            string serviceEndpointsId = null)
        {
            this.ServiceEndpointsId = serviceEndpointsId;
        }

        /// <summary>
        /// A system-defined string identifier representing one or more registered Service Endpoints.
        /// </summary>
        [JsonProperty("serviceEndpointsId", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceEndpointsId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"RegisterServiceEndpointResult : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is RegisterServiceEndpointResult other &&
                (this.ServiceEndpointsId == null && other.ServiceEndpointsId == null ||
                 this.ServiceEndpointsId?.Equals(other.ServiceEndpointsId) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ServiceEndpointsId = {this.ServiceEndpointsId ?? "null"}");
        }
    }
}