// <copyright file="ManagedAccountsProvisionRequest.cs" company="APIMatic">
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
    /// ManagedAccountsProvisionRequest.
    /// </summary>
    public class ManagedAccountsProvisionRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAccountsProvisionRequest"/> class.
        /// </summary>
        public ManagedAccountsProvisionRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAccountsProvisionRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="paccountName">paccountName.</param>
        /// <param name="serviceName">serviceName.</param>
        /// <param name="type">type.</param>
        /// <param name="txid">txid.</param>
        public ManagedAccountsProvisionRequest(
            string accountName,
            string paccountName,
            Models.ServiceNameEnum serviceName,
            string type,
            string txid)
        {
            this.AccountName = accountName;
            this.PaccountName = paccountName;
            this.ServiceName = serviceName;
            this.Type = type;
            this.Txid = txid;
        }

        /// <summary>
        /// Managed account identifier
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Primary Account identifier
        /// </summary>
        [JsonProperty("paccountName")]
        public string PaccountName { get; set; }

        /// <summary>
        /// Service name
        /// </summary>
        [JsonProperty("serviceName")]
        public Models.ServiceNameEnum ServiceName { get; set; }

        /// <summary>
        /// SKU name
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Transaction identifier returned by add request
        /// </summary>
        [JsonProperty("txid")]
        public string Txid { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ManagedAccountsProvisionRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is ManagedAccountsProvisionRequest other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.PaccountName == null && other.PaccountName == null) || (this.PaccountName?.Equals(other.PaccountName) == true)) &&
                this.ServiceName.Equals(other.ServiceName) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Txid == null && other.Txid == null) || (this.Txid?.Equals(other.Txid) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.PaccountName = {(this.PaccountName == null ? "null" : this.PaccountName)}");
            toStringOutput.Add($"this.ServiceName = {this.ServiceName}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.Txid = {(this.Txid == null ? "null" : this.Txid)}");
        }
    }
}