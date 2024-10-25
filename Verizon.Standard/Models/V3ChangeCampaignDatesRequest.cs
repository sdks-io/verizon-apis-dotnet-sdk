// <copyright file="V3ChangeCampaignDatesRequest.cs" company="APIMatic">
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
    /// V3ChangeCampaignDatesRequest.
    /// </summary>
    public class V3ChangeCampaignDatesRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V3ChangeCampaignDatesRequest"/> class.
        /// </summary>
        public V3ChangeCampaignDatesRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V3ChangeCampaignDatesRequest"/> class.
        /// </summary>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="campaignTimeWindowList">campaignTimeWindowList.</param>
        public V3ChangeCampaignDatesRequest(
            DateTime startDate,
            DateTime endDate,
            List<Models.V3TimeWindow> campaignTimeWindowList = null)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.CampaignTimeWindowList = campaignTimeWindowList;
        }

        /// <summary>
        /// Campaign start date.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("startDate")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Campaign end date.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("endDate")]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// List of allowed campaign time windows.
        /// </summary>
        [JsonProperty("campaignTimeWindowList", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.V3TimeWindow> CampaignTimeWindowList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V3ChangeCampaignDatesRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is V3ChangeCampaignDatesRequest other &&                this.StartDate.Equals(other.StartDate) &&
                this.EndDate.Equals(other.EndDate) &&
                ((this.CampaignTimeWindowList == null && other.CampaignTimeWindowList == null) || (this.CampaignTimeWindowList?.Equals(other.CampaignTimeWindowList) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.StartDate = {this.StartDate}");
            toStringOutput.Add($"this.EndDate = {this.EndDate}");
            toStringOutput.Add($"this.CampaignTimeWindowList = {(this.CampaignTimeWindowList == null ? "null" : $"[{string.Join(", ", this.CampaignTimeWindowList)} ]")}");
        }
    }
}