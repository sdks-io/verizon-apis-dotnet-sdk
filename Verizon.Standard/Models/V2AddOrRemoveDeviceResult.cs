// <copyright file="V2AddOrRemoveDeviceResult.cs" company="APIMatic">
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
    /// V2AddOrRemoveDeviceResult.
    /// </summary>
    public class V2AddOrRemoveDeviceResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V2AddOrRemoveDeviceResult"/> class.
        /// </summary>
        public V2AddOrRemoveDeviceResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V2AddOrRemoveDeviceResult"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="campaignId">campaignId.</param>
        /// <param name="requestId">requestId.</param>
        public V2AddOrRemoveDeviceResult(
            string accountName,
            string campaignId,
            string requestId)
        {
            this.AccountName = accountName;
            this.CampaignId = campaignId;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Account identifier.
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Campaign identifier.
        /// </summary>
        [JsonProperty("campaignId")]
        public string CampaignId { get; set; }

        /// <summary>
        /// Request identifier.
        /// </summary>
        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"V2AddOrRemoveDeviceResult : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is V2AddOrRemoveDeviceResult other &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.CampaignId == null && other.CampaignId == null ||
                 this.CampaignId?.Equals(other.CampaignId) == true) &&
                (this.RequestId == null && other.RequestId == null ||
                 this.RequestId?.Equals(other.RequestId) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
            toStringOutput.Add($"CampaignId = {this.CampaignId ?? "null"}");
            toStringOutput.Add($"RequestId = {this.RequestId ?? "null"}");
        }
    }
}