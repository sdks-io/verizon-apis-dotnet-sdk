// <copyright file="StatusResponse.cs" company="APIMatic">
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
    /// StatusResponse.
    /// </summary>
    public class StatusResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusResponse"/> class.
        /// </summary>
        public StatusResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatusResponse"/> class.
        /// </summary>
        /// <param name="requestId">requestId.</param>
        /// <param name="status">status.</param>
        /// <param name="subrequests">subrequests.</param>
        public StatusResponse(
            string requestId = null,
            string status = null,
            List<Models.Subrequest> subrequests = null)
        {
            this.RequestId = requestId;
            this.Status = status;
            this.Subrequests = subrequests;
        }

        /// <summary>
        /// Gets or sets RequestId.
        /// </summary>
        [JsonProperty("requestId", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets Subrequests.
        /// </summary>
        [JsonProperty("subrequests", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Subrequest> Subrequests { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"StatusResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is StatusResponse other &&                ((this.RequestId == null && other.RequestId == null) || (this.RequestId?.Equals(other.RequestId) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Subrequests == null && other.Subrequests == null) || (this.Subrequests?.Equals(other.Subrequests) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RequestId = {(this.RequestId == null ? "null" : this.RequestId)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status)}");
            toStringOutput.Add($"this.Subrequests = {(this.Subrequests == null ? "null" : $"[{string.Join(", ", this.Subrequests)} ]")}");
        }
    }
}