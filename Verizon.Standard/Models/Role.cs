// <copyright file="Role.cs" company="APIMatic">
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
    /// Role.
    /// </summary>
    public class Role
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Role"/> class.
        /// </summary>
        public Role()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Role"/> class.
        /// </summary>
        /// <param name="accountId">accountId.</param>
        /// <param name="externalId">externalId.</param>
        /// <param name="roleARN">roleARN.</param>
        public Role(
            string accountId = null,
            string externalId = null,
            string roleARN = null)
        {
            this.AccountId = accountId;
            this.ExternalId = externalId;
            this.RoleARN = roleARN;
        }

        /// <summary>
        /// Account ID of the role.
        /// </summary>
        [JsonProperty("accountId", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountId { get; set; }

        /// <summary>
        /// External ID of the role.
        /// </summary>
        [JsonProperty("externalId", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Role ARN of the role.
        /// </summary>
        [JsonProperty("roleARN", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleARN { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Role : ({string.Join(", ", toStringOutput)})";
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
            return obj is Role other &&                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.ExternalId == null && other.ExternalId == null) || (this.ExternalId?.Equals(other.ExternalId) == true)) &&
                ((this.RoleARN == null && other.RoleARN == null) || (this.RoleARN?.Equals(other.RoleARN) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId == string.Empty ? "" : this.AccountId)}");
            toStringOutput.Add($"this.ExternalId = {(this.ExternalId == null ? "null" : this.ExternalId == string.Empty ? "" : this.ExternalId)}");
            toStringOutput.Add($"this.RoleARN = {(this.RoleARN == null ? "null" : this.RoleARN == string.Empty ? "" : this.RoleARN)}");
        }
    }
}