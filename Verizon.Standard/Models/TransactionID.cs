// <copyright file="TransactionID.cs" company="APIMatic">
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
    /// TransactionID.
    /// </summary>
    public class TransactionID
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionID"/> class.
        /// </summary>
        public TransactionID()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionID"/> class.
        /// </summary>
        /// <param name="txid">txid.</param>
        public TransactionID(
            string txid = null)
        {
            this.Txid = txid;
        }

        /// <summary>
        /// Gets or sets Txid.
        /// </summary>
        [JsonProperty("txid", NullValueHandling = NullValueHandling.Ignore)]
        public string Txid { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TransactionID : ({string.Join(", ", toStringOutput)})";
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
            return obj is TransactionID other &&                ((this.Txid == null && other.Txid == null) || (this.Txid?.Equals(other.Txid) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Txid = {(this.Txid == null ? "null" : this.Txid)}");
        }
    }
}