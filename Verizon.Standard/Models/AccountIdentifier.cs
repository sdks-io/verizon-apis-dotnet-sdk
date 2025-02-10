// <copyright file="AccountIdentifier.cs" company="APIMatic">
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
    /// AccountIdentifier.
    /// </summary>
    public class AccountIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountIdentifier"/> class.
        /// </summary>
        public AccountIdentifier()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountIdentifier"/> class.
        /// </summary>
        /// <param name="billingaccountid">billingaccountid.</param>
        public AccountIdentifier(
            string billingaccountid = null)
        {
            this.Billingaccountid = billingaccountid;
        }

        /// <summary>
        /// Gets or sets Billingaccountid.
        /// </summary>
        [JsonProperty("billingaccountid", NullValueHandling = NullValueHandling.Ignore)]
        public string Billingaccountid { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"AccountIdentifier : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AccountIdentifier other &&
                (this.Billingaccountid == null && other.Billingaccountid == null ||
                 this.Billingaccountid?.Equals(other.Billingaccountid) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Billingaccountid = {this.Billingaccountid ?? "null"}");
        }
    }
}