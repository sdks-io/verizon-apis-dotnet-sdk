// <copyright file="RemoveDeviceRequest.cs" company="APIMatic">
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
    /// RemoveDeviceRequest.
    /// </summary>
    public class RemoveDeviceRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveDeviceRequest"/> class.
        /// </summary>
        public RemoveDeviceRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveDeviceRequest"/> class.
        /// </summary>
        /// <param name="accountidentifier">accountidentifier.</param>
        /// <param name="resourceidentifier">resourceidentifier.</param>
        public RemoveDeviceRequest(
            Models.AccountIdentifier accountidentifier,
            Models.ResourceIdentifier resourceidentifier)
        {
            this.Accountidentifier = accountidentifier;
            this.Resourceidentifier = resourceidentifier;
        }

        /// <summary>
        /// The ID of the authenticating billing account, in the format `{"billingaccountid":"1234567890-12345"}`.
        /// </summary>
        [JsonProperty("accountidentifier")]
        public Models.AccountIdentifier Accountidentifier { get; set; }

        /// <summary>
        /// The ID of the target to delete, in the format {"id": "dd1682d3-2d80-cefc-f3ee-25154800beff"}.
        /// </summary>
        [JsonProperty("resourceidentifier")]
        public Models.ResourceIdentifier Resourceidentifier { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"RemoveDeviceRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is RemoveDeviceRequest other &&
                (this.Accountidentifier == null && other.Accountidentifier == null ||
                 this.Accountidentifier?.Equals(other.Accountidentifier) == true) &&
                (this.Resourceidentifier == null && other.Resourceidentifier == null ||
                 this.Resourceidentifier?.Equals(other.Resourceidentifier) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Accountidentifier = {(this.Accountidentifier == null ? "null" : this.Accountidentifier.ToString())}");
            toStringOutput.Add($"Resourceidentifier = {(this.Resourceidentifier == null ? "null" : this.Resourceidentifier.ToString())}");
        }
    }
}