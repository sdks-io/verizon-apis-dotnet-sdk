// <copyright file="AwsCspProfile.cs" company="APIMatic">
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
    /// AwsCspProfile.
    /// </summary>
    public class AwsCspProfile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AwsCspProfile"/> class.
        /// </summary>
        public AwsCspProfile()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AwsCspProfile"/> class.
        /// </summary>
        /// <param name="credType">credType.</param>
        /// <param name="accessKey">accessKey.</param>
        /// <param name="secretKey">secretKey.</param>
        /// <param name="roleARN">roleARN.</param>
        /// <param name="accountId">accountId.</param>
        /// <param name="externalId">externalId.</param>
        public AwsCspProfile(
            Models.AwsCspProfileCredTypeEnum? credType = null,
            string accessKey = null,
            string secretKey = null,
            string roleARN = null,
            string accountId = null,
            string externalId = null)
        {
            this.CredType = credType;
            this.AccessKey = accessKey;
            this.SecretKey = secretKey;
            this.RoleARN = roleARN;
            this.AccountId = accountId;
            this.ExternalId = externalId;
        }

        /// <summary>
        /// Credential type of AWS CSP profile.
        /// </summary>
        [JsonProperty("credType", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.AwsCspProfileCredTypeEnum? CredType { get; set; }

        /// <summary>
        /// AWS Access Key.
        /// </summary>
        [JsonProperty("accessKey", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessKey { get; set; }

        /// <summary>
        /// AWS Secret Key.
        /// </summary>
        [JsonProperty("secretKey", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretKey { get; set; }

        /// <summary>
        /// CSP AWS Role ARN.
        /// </summary>
        [JsonProperty("roleARN", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleARN { get; set; }

        /// <summary>
        /// AWS account ID.
        /// </summary>
        [JsonProperty("accountId", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountId { get; set; }

        /// <summary>
        /// AWS external ID.
        /// </summary>
        [JsonProperty("externalId", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AwsCspProfile : ({string.Join(", ", toStringOutput)})";
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
            return obj is AwsCspProfile other &&                ((this.CredType == null && other.CredType == null) || (this.CredType?.Equals(other.CredType) == true)) &&
                ((this.AccessKey == null && other.AccessKey == null) || (this.AccessKey?.Equals(other.AccessKey) == true)) &&
                ((this.SecretKey == null && other.SecretKey == null) || (this.SecretKey?.Equals(other.SecretKey) == true)) &&
                ((this.RoleARN == null && other.RoleARN == null) || (this.RoleARN?.Equals(other.RoleARN) == true)) &&
                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.ExternalId == null && other.ExternalId == null) || (this.ExternalId?.Equals(other.ExternalId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CredType = {(this.CredType == null ? "null" : this.CredType.ToString())}");
            toStringOutput.Add($"this.AccessKey = {(this.AccessKey == null ? "null" : this.AccessKey == string.Empty ? "" : this.AccessKey)}");
            toStringOutput.Add($"this.SecretKey = {(this.SecretKey == null ? "null" : this.SecretKey == string.Empty ? "" : this.SecretKey)}");
            toStringOutput.Add($"this.RoleARN = {(this.RoleARN == null ? "null" : this.RoleARN == string.Empty ? "" : this.RoleARN)}");
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId == string.Empty ? "" : this.AccountId)}");
            toStringOutput.Add($"this.ExternalId = {(this.ExternalId == null ? "null" : this.ExternalId == string.Empty ? "" : this.ExternalId)}");
        }
    }
}