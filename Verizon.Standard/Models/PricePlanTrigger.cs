// <copyright file="PricePlanTrigger.cs" company="APIMatic">
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
    /// PricePlanTrigger.
    /// </summary>
    public class PricePlanTrigger
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PricePlanTrigger"/> class.
        /// </summary>
        public PricePlanTrigger()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricePlanTrigger"/> class.
        /// </summary>
        /// <param name="accountGroupShare">accountGroupShare.</param>
        public PricePlanTrigger(
            Models.AccountGroupShare accountGroupShare = null)
        {
            this.AccountGroupShare = accountGroupShare;
        }

        /// <summary>
        /// Gets or sets AccountGroupShare.
        /// </summary>
        [JsonProperty("accountGroupShare", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AccountGroupShare AccountGroupShare { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PricePlanTrigger : ({string.Join(", ", toStringOutput)})";
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
            return obj is PricePlanTrigger other &&                ((this.AccountGroupShare == null && other.AccountGroupShare == null) || (this.AccountGroupShare?.Equals(other.AccountGroupShare) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountGroupShare = {(this.AccountGroupShare == null ? "null" : this.AccountGroupShare.ToString())}");
        }
    }
}