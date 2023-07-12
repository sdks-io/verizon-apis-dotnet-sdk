// <copyright file="ServiceClaims.cs" company="APIMatic">
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
    /// ServiceClaims.
    /// </summary>
    public class ServiceClaims
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceClaims"/> class.
        /// </summary>
        public ServiceClaims()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceClaims"/> class.
        /// </summary>
        /// <param name="count">count.</param>
        /// <param name="claimsResList">claimsResList.</param>
        public ServiceClaims(
            int? count = null,
            List<Models.Claim> claimsResList = null)
        {
            this.Count = count;
            this.ClaimsResList = claimsResList;
        }

        /// <summary>
        /// Count for all the claims returned after hitting the API.
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// List of all claims.
        /// </summary>
        [JsonProperty("claimsResList", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Claim> ClaimsResList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServiceClaims : ({string.Join(", ", toStringOutput)})";
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
            return obj is ServiceClaims other &&                ((this.Count == null && other.Count == null) || (this.Count?.Equals(other.Count) == true)) &&
                ((this.ClaimsResList == null && other.ClaimsResList == null) || (this.ClaimsResList?.Equals(other.ClaimsResList) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Count = {(this.Count == null ? "null" : this.Count.ToString())}");
            toStringOutput.Add($"this.ClaimsResList = {(this.ClaimsResList == null ? "null" : $"[{string.Join(", ", this.ClaimsResList)} ]")}");
        }
    }
}