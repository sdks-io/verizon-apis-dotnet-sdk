// <copyright file="SearchSensorHistoryRequest.cs" company="APIMatic">
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
    /// SearchSensorHistoryRequest.
    /// </summary>
    public class SearchSensorHistoryRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchSensorHistoryRequest"/> class.
        /// </summary>
        public SearchSensorHistoryRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchSensorHistoryRequest"/> class.
        /// </summary>
        /// <param name="accountidentifier">accountidentifier.</param>
        /// <param name="resourceidentifier">resourceidentifier.</param>
        /// <param name="limitnumber">$limitnumber.</param>
        /// <param name="page">$page.</param>
        public SearchSensorHistoryRequest(
            Models.AccountIdentifier accountidentifier,
            Models.ResourceIdentifier resourceidentifier,
            int? limitnumber = null,
            string page = null)
        {
            this.Accountidentifier = accountidentifier;
            this.Resourceidentifier = resourceidentifier;
            this.Limitnumber = limitnumber;
            this.Page = page;
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

        /// <summary>
        /// The maximum number of events to include in the response.
        /// </summary>
        [JsonProperty("$limitnumber", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limitnumber { get; set; }

        /// <summary>
        /// The maximum number of events to include in the response.
        /// </summary>
        [JsonProperty("$page", NullValueHandling = NullValueHandling.Ignore)]
        public string Page { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SearchSensorHistoryRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is SearchSensorHistoryRequest other &&                ((this.Accountidentifier == null && other.Accountidentifier == null) || (this.Accountidentifier?.Equals(other.Accountidentifier) == true)) &&
                ((this.Resourceidentifier == null && other.Resourceidentifier == null) || (this.Resourceidentifier?.Equals(other.Resourceidentifier) == true)) &&
                ((this.Limitnumber == null && other.Limitnumber == null) || (this.Limitnumber?.Equals(other.Limitnumber) == true)) &&
                ((this.Page == null && other.Page == null) || (this.Page?.Equals(other.Page) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Accountidentifier = {(this.Accountidentifier == null ? "null" : this.Accountidentifier.ToString())}");
            toStringOutput.Add($"this.Resourceidentifier = {(this.Resourceidentifier == null ? "null" : this.Resourceidentifier.ToString())}");
            toStringOutput.Add($"this.Limitnumber = {(this.Limitnumber == null ? "null" : this.Limitnumber.ToString())}");
            toStringOutput.Add($"this.Page = {(this.Page == null ? "null" : this.Page)}");
        }
    }
}