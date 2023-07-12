// <copyright file="ManagedAccountsProvisionResponse.cs" company="APIMatic">
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
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Verizon.Standard;
    using Verizon.Standard.Utilities;

    /// <summary>
    /// ManagedAccountsProvisionResponse.
    /// </summary>
    public class ManagedAccountsProvisionResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAccountsProvisionResponse"/> class.
        /// </summary>
        public ManagedAccountsProvisionResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAccountsProvisionResponse"/> class.
        /// </summary>
        /// <param name="txid">txid.</param>
        /// <param name="accountName">accountName.</param>
        /// <param name="paccountName">paccountName.</param>
        /// <param name="serviceName">serviceName.</param>
        /// <param name="status">status.</param>
        /// <param name="reason">reason.</param>
        public ManagedAccountsProvisionResponse(
            string txid = null,
            string accountName = null,
            string paccountName = null,
            Models.ServiceNameEnum? serviceName = Models.ServiceNameEnum.Location,
            string status = null,
            string reason = null)
        {
            this.Txid = txid;
            this.AccountName = accountName;
            this.PaccountName = paccountName;
            this.ServiceName = serviceName;
            this.Status = status;
            this.Reason = reason;
        }

        /// <summary>
        /// Transaction identifier
        /// </summary>
        [JsonProperty("txid", NullValueHandling = NullValueHandling.Ignore)]
        public string Txid { get; set; }

        /// <summary>
        /// Account identifier
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// Primary Account identifier
        /// </summary>
        [JsonProperty("paccountName", NullValueHandling = NullValueHandling.Ignore)]
        public string PaccountName { get; set; }

        /// <summary>
        /// Service name
        /// </summary>
        [JsonProperty("serviceName", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.ServiceNameEnum? ServiceName { get; set; }

        /// <summary>
        /// Provision status. Success or Fail
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Detailed reason
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ManagedAccountsProvisionResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is ManagedAccountsProvisionResponse other &&                ((this.Txid == null && other.Txid == null) || (this.Txid?.Equals(other.Txid) == true)) &&
                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.PaccountName == null && other.PaccountName == null) || (this.PaccountName?.Equals(other.PaccountName) == true)) &&
                ((this.ServiceName == null && other.ServiceName == null) || (this.ServiceName?.Equals(other.ServiceName) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Reason == null && other.Reason == null) || (this.Reason?.Equals(other.Reason) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Txid = {(this.Txid == null ? "null" : this.Txid == string.Empty ? "" : this.Txid)}");
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName == string.Empty ? "" : this.AccountName)}");
            toStringOutput.Add($"this.PaccountName = {(this.PaccountName == null ? "null" : this.PaccountName == string.Empty ? "" : this.PaccountName)}");
            toStringOutput.Add($"this.ServiceName = {(this.ServiceName == null ? "null" : this.ServiceName.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.Reason = {(this.Reason == null ? "null" : this.Reason == string.Empty ? "" : this.Reason)}");
        }
    }
}