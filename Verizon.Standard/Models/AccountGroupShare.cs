// <copyright file="AccountGroupShare.cs" company="APIMatic">
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
    /// AccountGroupShare.
    /// </summary>
    public class AccountGroupShare
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountGroupShare"/> class.
        /// </summary>
        public AccountGroupShare()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountGroupShare"/> class.
        /// </summary>
        /// <param name="accountGroupShareIndividual">accountGroupShareIndividual.</param>
        public AccountGroupShare(
            Models.AccountGroupShareIndividual accountGroupShareIndividual = null)
        {
            this.AccountGroupShareIndividual = accountGroupShareIndividual;
        }

        /// <summary>
        /// Gets or sets AccountGroupShareIndividual.
        /// </summary>
        [JsonProperty("accountGroupShareIndividual", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AccountGroupShareIndividual AccountGroupShareIndividual { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AccountGroupShare : ({string.Join(", ", toStringOutput)})";
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
            return obj is AccountGroupShare other &&                ((this.AccountGroupShareIndividual == null && other.AccountGroupShareIndividual == null) || (this.AccountGroupShareIndividual?.Equals(other.AccountGroupShareIndividual) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountGroupShareIndividual = {(this.AccountGroupShareIndividual == null ? "null" : this.AccountGroupShareIndividual.ToString())}");
        }
    }
}