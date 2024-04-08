// <copyright file="DeleteTargetRequest.cs" company="APIMatic">
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
    /// DeleteTargetRequest.
    /// </summary>
    public class DeleteTargetRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTargetRequest"/> class.
        /// </summary>
        public DeleteTargetRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTargetRequest"/> class.
        /// </summary>
        /// <param name="accountidentifier">accountidentifier.</param>
        /// <param name="resourceidentifier">resourceidentifier.</param>
        public DeleteTargetRequest(
            Models.AccountIdentifier accountidentifier = null,
            Models.ResourceIdentifier resourceidentifier = null)
        {
            this.Accountidentifier = accountidentifier;
            this.Resourceidentifier = resourceidentifier;
        }

        /// <summary>
        /// The ID of the authenticating billing account, in the format `{"billingaccountid":"1234567890-12345"}`.
        /// </summary>
        [JsonProperty("accountidentifier", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AccountIdentifier Accountidentifier { get; set; }

        /// <summary>
        /// The ID of the target to delete, in the format {"id": "dd1682d3-2d80-cefc-f3ee-25154800beff"}.
        /// </summary>
        [JsonProperty("resourceidentifier", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ResourceIdentifier Resourceidentifier { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeleteTargetRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is DeleteTargetRequest other &&                ((this.Accountidentifier == null && other.Accountidentifier == null) || (this.Accountidentifier?.Equals(other.Accountidentifier) == true)) &&
                ((this.Resourceidentifier == null && other.Resourceidentifier == null) || (this.Resourceidentifier?.Equals(other.Resourceidentifier) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Accountidentifier = {(this.Accountidentifier == null ? "null" : this.Accountidentifier.ToString())}");
            toStringOutput.Add($"this.Resourceidentifier = {(this.Resourceidentifier == null ? "null" : this.Resourceidentifier.ToString())}");
        }
    }
}