// <copyright file="AccessIntents.cs" company="APIMatic">
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
    /// AccessIntents.
    /// </summary>
    public class AccessIntents
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessIntents"/> class.
        /// </summary>
        public AccessIntents()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessIntents"/> class.
        /// </summary>
        /// <param name="enableCarrierNetworkAccess">enableCarrierNetworkAccess.</param>
        public AccessIntents(
            bool? enableCarrierNetworkAccess = false)
        {
            this.EnableCarrierNetworkAccess = enableCarrierNetworkAccess;
        }

        /// <summary>
        /// Gets or sets EnableCarrierNetworkAccess.
        /// </summary>
        [JsonProperty("enableCarrierNetworkAccess", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableCarrierNetworkAccess { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AccessIntents : ({string.Join(", ", toStringOutput)})";
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
            return obj is AccessIntents other &&                ((this.EnableCarrierNetworkAccess == null && other.EnableCarrierNetworkAccess == null) || (this.EnableCarrierNetworkAccess?.Equals(other.EnableCarrierNetworkAccess) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.EnableCarrierNetworkAccess = {(this.EnableCarrierNetworkAccess == null ? "null" : this.EnableCarrierNetworkAccess.ToString())}");
        }
    }
}