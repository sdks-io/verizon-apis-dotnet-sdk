// <copyright file="CSPProfileIdRequest.cs" company="APIMatic">
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
    /// CSPProfileIdRequest.
    /// </summary>
    public class CSPProfileIdRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CSPProfileIdRequest"/> class.
        /// </summary>
        public CSPProfileIdRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CSPProfileIdRequest"/> class.
        /// </summary>
        /// <param name="cspProfileId">cspProfileId.</param>
        public CSPProfileIdRequest(
            string cspProfileId = null)
        {
            this.CspProfileId = cspProfileId;
        }

        /// <summary>
        /// CSP Profile ID in which service will be deployed.
        /// </summary>
        [JsonProperty("cspProfileId", NullValueHandling = NullValueHandling.Ignore)]
        public string CspProfileId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CSPProfileIdRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is CSPProfileIdRequest other &&                ((this.CspProfileId == null && other.CspProfileId == null) || (this.CspProfileId?.Equals(other.CspProfileId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CspProfileId = {(this.CspProfileId == null ? "null" : this.CspProfileId == string.Empty ? "" : this.CspProfileId)}");
        }
    }
}