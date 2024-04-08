// <copyright file="ListAllServiceEndpointsResult.cs" company="APIMatic">
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
    /// ListAllServiceEndpointsResult.
    /// </summary>
    public class ListAllServiceEndpointsResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListAllServiceEndpointsResult"/> class.
        /// </summary>
        public ListAllServiceEndpointsResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAllServiceEndpointsResult"/> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="data">data.</param>
        public ListAllServiceEndpointsResult(
            string status = "success",
            List<string> data = null)
        {
            this.Status = status;
            this.Data = data;
        }

        /// <summary>
        /// HTTP status code.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// A comma delimited list of all registered service endpoints.
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListAllServiceEndpointsResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is ListAllServiceEndpointsResult other &&                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status)}");
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : $"[{string.Join(", ", this.Data)} ]")}");
        }
    }
}