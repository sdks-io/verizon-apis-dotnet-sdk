// <copyright file="GenerateExternalIDRequest.cs" company="APIMatic">
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
    /// GenerateExternalIDRequest.
    /// </summary>
    public class GenerateExternalIDRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateExternalIDRequest"/> class.
        /// </summary>
        public GenerateExternalIDRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateExternalIDRequest"/> class.
        /// </summary>
        /// <param name="accountidentifier">accountidentifier.</param>
        public GenerateExternalIDRequest(
            Models.AccountIdentifier accountidentifier = null)
        {
            this.Accountidentifier = accountidentifier;
        }

        /// <summary>
        /// The ID of the authenticating billing account, in the format `{"billingaccountid":"1234567890-12345"}`.
        /// </summary>
        [JsonProperty("accountidentifier", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AccountIdentifier Accountidentifier { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GenerateExternalIDRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GenerateExternalIDRequest other &&
                (this.Accountidentifier == null && other.Accountidentifier == null ||
                 this.Accountidentifier?.Equals(other.Accountidentifier) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Accountidentifier = {(this.Accountidentifier == null ? "null" : this.Accountidentifier.ToString())}");
        }
    }
}