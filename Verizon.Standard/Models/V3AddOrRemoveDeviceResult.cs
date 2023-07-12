// <copyright file="V3AddOrRemoveDeviceResult.cs" company="APIMatic">
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
    /// V3AddOrRemoveDeviceResult.
    /// </summary>
    public class V3AddOrRemoveDeviceResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V3AddOrRemoveDeviceResult"/> class.
        /// </summary>
        public V3AddOrRemoveDeviceResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V3AddOrRemoveDeviceResult"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="campaignId">campaignId.</param>
        /// <param name="deviceList">deviceList.</param>
        public V3AddOrRemoveDeviceResult(
            string accountName,
            string campaignId,
            List<Models.V3DeviceListItem> deviceList)
        {
            this.AccountName = accountName;
            this.CampaignId = campaignId;
            this.DeviceList = deviceList;
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
        /// Array of devices changed.
        /// </summary>
        [JsonProperty("deviceList")]
        public List<Models.V3DeviceListItem> DeviceList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V3AddOrRemoveDeviceResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is V3AddOrRemoveDeviceResult other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.CampaignId == null && other.CampaignId == null) || (this.CampaignId?.Equals(other.CampaignId) == true)) &&
                ((this.DeviceList == null && other.DeviceList == null) || (this.DeviceList?.Equals(other.DeviceList) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName == string.Empty ? "" : this.AccountName)}");
            toStringOutput.Add($"this.CampaignId = {(this.CampaignId == null ? "null" : this.CampaignId == string.Empty ? "" : this.CampaignId)}");
            toStringOutput.Add($"this.DeviceList = {(this.DeviceList == null ? "null" : $"[{string.Join(", ", this.DeviceList)} ]")}");
        }
    }
}