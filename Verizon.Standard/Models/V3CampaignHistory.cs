// <copyright file="V3CampaignHistory.cs" company="APIMatic">
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
    /// V3CampaignHistory.
    /// </summary>
    public class V3CampaignHistory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V3CampaignHistory"/> class.
        /// </summary>
        public V3CampaignHistory()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V3CampaignHistory"/> class.
        /// </summary>
        /// <param name="hasMoreData">hasMoreData.</param>
        /// <param name="lastSeenCampaignId">lastSeenCampaignId.</param>
        /// <param name="campaignList">campaignList.</param>
        public V3CampaignHistory(
            bool hasMoreData,
            string lastSeenCampaignId = null,
            List<Models.V3CampaignMetaInfo> campaignList = null)
        {
            this.HasMoreData = hasMoreData;
            this.LastSeenCampaignId = lastSeenCampaignId;
            this.CampaignList = campaignList;
        }

        /// <summary>
        /// Has more report flag?
        /// </summary>
        [JsonProperty("hasMoreData")]
        public bool HasMoreData { get; set; }

        /// <summary>
        /// Campaign identifier.
        /// </summary>
        [JsonProperty("lastSeenCampaignId", NullValueHandling = NullValueHandling.Ignore)]
        public string LastSeenCampaignId { get; set; }

        /// <summary>
        /// Firmware upgrade list.
        /// </summary>
        [JsonProperty("campaignList", NullValueHandling = NullValueHandling.Include)]
        public List<Models.V3CampaignMetaInfo> CampaignList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V3CampaignHistory : ({string.Join(", ", toStringOutput)})";
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
            return obj is V3CampaignHistory other &&                this.HasMoreData.Equals(other.HasMoreData) &&
                ((this.LastSeenCampaignId == null && other.LastSeenCampaignId == null) || (this.LastSeenCampaignId?.Equals(other.LastSeenCampaignId) == true)) &&
                ((this.CampaignList == null && other.CampaignList == null) || (this.CampaignList?.Equals(other.CampaignList) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.HasMoreData = {this.HasMoreData}");
            toStringOutput.Add($"this.LastSeenCampaignId = {(this.LastSeenCampaignId == null ? "null" : this.LastSeenCampaignId)}");
            toStringOutput.Add($"this.CampaignList = {(this.CampaignList == null ? "null" : $"[{string.Join(", ", this.CampaignList)} ]")}");
        }
    }
}