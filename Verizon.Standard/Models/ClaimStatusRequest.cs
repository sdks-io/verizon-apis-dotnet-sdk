// <copyright file="ClaimStatusRequest.cs" company="APIMatic">
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
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Verizon.Standard;
    using Verizon.Standard.Utilities;

    /// <summary>
    /// ClaimStatusRequest.
    /// </summary>
    public class ClaimStatusRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClaimStatusRequest"/> class.
        /// </summary>
        public ClaimStatusRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClaimStatusRequest"/> class.
        /// </summary>
        /// <param name="claimStatus">claimStatus.</param>
        public ClaimStatusRequest(
            Models.ClaimStatusEnum? claimStatus = null)
        {
            this.ClaimStatus = claimStatus;
        }

        /// <summary>
        /// Current status of the claim can have only two values eg: VERIFIED/UNVERIFIED.
        /// </summary>
        [JsonProperty("claimStatus", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.ClaimStatusEnum? ClaimStatus { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ClaimStatusRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is ClaimStatusRequest other &&                ((this.ClaimStatus == null && other.ClaimStatus == null) || (this.ClaimStatus?.Equals(other.ClaimStatus) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ClaimStatus = {(this.ClaimStatus == null ? "null" : this.ClaimStatus.ToString())}");
        }
    }
}