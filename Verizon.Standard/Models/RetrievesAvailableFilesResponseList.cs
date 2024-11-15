// <copyright file="RetrievesAvailableFilesResponseList.cs" company="APIMatic">
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
    /// RetrievesAvailableFilesResponseList.
    /// </summary>
    public class RetrievesAvailableFilesResponseList
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RetrievesAvailableFilesResponseList"/> class.
        /// </summary>
        public RetrievesAvailableFilesResponseList()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrievesAvailableFilesResponseList"/> class.
        /// </summary>
        /// <param name="availableFilesResponse">AvailableFilesResponse.</param>
        public RetrievesAvailableFilesResponseList(
            List<Models.RetrievesAvailableFilesResponse> availableFilesResponse = null)
        {
            this.AvailableFilesResponse = availableFilesResponse;
        }

        /// <summary>
        /// Gets or sets AvailableFilesResponse.
        /// </summary>
        [JsonProperty("AvailableFilesResponse", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.RetrievesAvailableFilesResponse> AvailableFilesResponse { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RetrievesAvailableFilesResponseList : ({string.Join(", ", toStringOutput)})";
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
            return obj is RetrievesAvailableFilesResponseList other &&                ((this.AvailableFilesResponse == null && other.AvailableFilesResponse == null) || (this.AvailableFilesResponse?.Equals(other.AvailableFilesResponse) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AvailableFilesResponse = {(this.AvailableFilesResponse == null ? "null" : $"[{string.Join(", ", this.AvailableFilesResponse)} ]")}");
        }
    }
}