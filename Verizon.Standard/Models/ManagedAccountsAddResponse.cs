// <copyright file="ManagedAccountsAddResponse.cs" company="APIMatic">
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
    /// ManagedAccountsAddResponse.
    /// </summary>
    public class ManagedAccountsAddResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAccountsAddResponse"/> class.
        /// </summary>
        public ManagedAccountsAddResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAccountsAddResponse"/> class.
        /// </summary>
        /// <param name="txId">TxId.</param>
        /// <param name="statusList">statusList.</param>
        public ManagedAccountsAddResponse(
            string txId = null,
            List<Models.StatusList> statusList = null)
        {
            this.TxId = txId;
            this.StatusList = statusList;
        }

        /// <summary>
        /// Transaction identifier
        /// </summary>
        [JsonProperty("TxId", NullValueHandling = NullValueHandling.Ignore)]
        public string TxId { get; set; }

        /// <summary>
        /// Gets or sets StatusList.
        /// </summary>
        [JsonProperty("statusList", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.StatusList> StatusList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ManagedAccountsAddResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ManagedAccountsAddResponse other &&
                (this.TxId == null && other.TxId == null ||
                 this.TxId?.Equals(other.TxId) == true) &&
                (this.StatusList == null && other.StatusList == null ||
                 this.StatusList?.Equals(other.StatusList) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"TxId = {this.TxId ?? "null"}");
            toStringOutput.Add($"StatusList = {(this.StatusList == null ? "null" : $"[{string.Join(", ", this.StatusList)} ]")}");
        }
    }
}