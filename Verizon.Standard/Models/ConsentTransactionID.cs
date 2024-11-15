// <copyright file="ConsentTransactionID.cs" company="APIMatic">
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
    /// ConsentTransactionID.
    /// </summary>
    public class ConsentTransactionID
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsentTransactionID"/> class.
        /// </summary>
        public ConsentTransactionID()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsentTransactionID"/> class.
        /// </summary>
        /// <param name="transactionId">transactionId.</param>
        /// <param name="status">status.</param>
        public ConsentTransactionID(
            string transactionId = null,
            string status = null)
        {
            this.TransactionId = transactionId;
            this.Status = status;
        }

        /// <summary>
        /// Gets or sets TransactionId.
        /// </summary>
        [JsonProperty("transactionId", NullValueHandling = NullValueHandling.Ignore)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ConsentTransactionID : ({string.Join(", ", toStringOutput)})";
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
            return obj is ConsentTransactionID other &&                ((this.TransactionId == null && other.TransactionId == null) || (this.TransactionId?.Equals(other.TransactionId) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TransactionId = {(this.TransactionId == null ? "null" : this.TransactionId)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status)}");
        }
    }
}