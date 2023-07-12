// <copyright file="ManagedAccountsAddRequest.cs" company="APIMatic">
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
    /// ManagedAccountsAddRequest.
    /// </summary>
    public class ManagedAccountsAddRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAccountsAddRequest"/> class.
        /// </summary>
        public ManagedAccountsAddRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAccountsAddRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="serviceName">serviceName.</param>
        /// <param name="type">type.</param>
        /// <param name="managedAccList">managedAccList.</param>
        public ManagedAccountsAddRequest(
            string accountName,
            Models.ServiceNameEnum serviceName,
            string type,
            List<string> managedAccList)
        {
            this.AccountName = accountName;
            this.ServiceName = serviceName;
            this.Type = type;
            this.ManagedAccList = managedAccList;
        }

        /// <summary>
        /// Account identifier
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Service name
        /// </summary>
        [JsonProperty("serviceName", ItemConverterType = typeof(StringEnumConverter))]
        public Models.ServiceNameEnum ServiceName { get; set; }

        /// <summary>
        /// SKU name
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// managed account list
        /// </summary>
        [JsonProperty("managedAccList")]
        public List<string> ManagedAccList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ManagedAccountsAddRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is ManagedAccountsAddRequest other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                this.ServiceName.Equals(other.ServiceName) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.ManagedAccList == null && other.ManagedAccList == null) || (this.ManagedAccList?.Equals(other.ManagedAccList) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName == string.Empty ? "" : this.AccountName)}");
            toStringOutput.Add($"this.ServiceName = {this.ServiceName}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
            toStringOutput.Add($"this.ManagedAccList = {(this.ManagedAccList == null ? "null" : $"[{string.Join(", ", this.ManagedAccList)} ]")}");
        }
    }
}