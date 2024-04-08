// <copyright file="QueryTargetRequest.cs" company="APIMatic">
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
    /// QueryTargetRequest.
    /// </summary>
    public class QueryTargetRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryTargetRequest"/> class.
        /// </summary>
        public QueryTargetRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryTargetRequest"/> class.
        /// </summary>
        /// <param name="accountidentifier">accountidentifier.</param>
        /// <param name="selection">$selection.</param>
        /// <param name="resourceidentifier">resourceidentifier.</param>
        public QueryTargetRequest(
            Models.AccountIdentifier accountidentifier = null,
            Dictionary<string, string> selection = null,
            Models.ResourceIdentifier resourceidentifier = null)
        {
            this.Accountidentifier = accountidentifier;
            this.Selection = selection;
            this.Resourceidentifier = resourceidentifier;
        }

        /// <summary>
        /// The ID of the authenticating billing account, in the format `{"billingaccountid":"1234567890-12345"}`.
        /// </summary>
        [JsonProperty("accountidentifier", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AccountIdentifier Accountidentifier { get; set; }

        /// <summary>
        /// A comma-separated list of properties and comparator values to match against subscriptions in the ThingSpace account. See Working with Query Filters for more information. If the request does not include `$selection`, the response will include all subscriptions to which the requesting user has access.
        /// </summary>
        [JsonProperty("$selection", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Selection { get; set; }

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

            return $"QueryTargetRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is QueryTargetRequest other &&                ((this.Accountidentifier == null && other.Accountidentifier == null) || (this.Accountidentifier?.Equals(other.Accountidentifier) == true)) &&
                ((this.Selection == null && other.Selection == null) || (this.Selection?.Equals(other.Selection) == true)) &&
                ((this.Resourceidentifier == null && other.Resourceidentifier == null) || (this.Resourceidentifier?.Equals(other.Resourceidentifier) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Accountidentifier = {(this.Accountidentifier == null ? "null" : this.Accountidentifier.ToString())}");
            toStringOutput.Add($"Selection = {(this.Selection == null ? "null" : this.Selection.ToString())}");
            toStringOutput.Add($"this.Resourceidentifier = {(this.Resourceidentifier == null ? "null" : this.Resourceidentifier.ToString())}");
        }
    }
}