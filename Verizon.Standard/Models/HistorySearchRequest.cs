// <copyright file="HistorySearchRequest.cs" company="APIMatic">
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
    /// HistorySearchRequest.
    /// </summary>
    public class HistorySearchRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HistorySearchRequest"/> class.
        /// </summary>
        public HistorySearchRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HistorySearchRequest"/> class.
        /// </summary>
        /// <param name="filter">$filter.</param>
        /// <param name="limitNumber">$limitNumber.</param>
        /// <param name="limitTime">$limitTime.</param>
        /// <param name="page">$page.</param>
        public HistorySearchRequest(
            Models.HistorySearchFilter filter,
            int? limitNumber = null,
            Models.HistorySearchLimitTime limitTime = null,
            string page = null)
        {
            this.Filter = filter;
            this.LimitNumber = limitNumber;
            this.LimitTime = limitTime;
            this.Page = page;
        }

        /// <summary>
        /// The selected device and attributes for which a request should retrieve data.
        /// </summary>
        [JsonProperty("$filter")]
        public Models.HistorySearchFilter Filter { get; set; }

        /// <summary>
        /// The maximum number of historical attributes to include in the response. If the request matches more than this number of attributes, the response will contain an X-Next value in the header that can be used as the page value in the next request to retrieve the next page of events.
        /// </summary>
        [JsonProperty("$limitNumber", NullValueHandling = NullValueHandling.Ignore)]
        public int? LimitNumber { get; set; }

        /// <summary>
        /// The time period for which a request should retrieve data, beginning with the limitTime.startOn and proceeding with the limitTime.duration.
        /// </summary>
        [JsonProperty("$limitTime", NullValueHandling = NullValueHandling.Ignore)]
        public Models.HistorySearchLimitTime LimitTime { get; set; }

        /// <summary>
        /// Page number for pagination purposes.
        /// </summary>
        [JsonProperty("$page", NullValueHandling = NullValueHandling.Ignore)]
        public string Page { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"HistorySearchRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is HistorySearchRequest other &&                ((this.Filter == null && other.Filter == null) || (this.Filter?.Equals(other.Filter) == true)) &&
                ((this.LimitNumber == null && other.LimitNumber == null) || (this.LimitNumber?.Equals(other.LimitNumber) == true)) &&
                ((this.LimitTime == null && other.LimitTime == null) || (this.LimitTime?.Equals(other.LimitTime) == true)) &&
                ((this.Page == null && other.Page == null) || (this.Page?.Equals(other.Page) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Filter = {(this.Filter == null ? "null" : this.Filter.ToString())}");
            toStringOutput.Add($"this.LimitNumber = {(this.LimitNumber == null ? "null" : this.LimitNumber.ToString())}");
            toStringOutput.Add($"this.LimitTime = {(this.LimitTime == null ? "null" : this.LimitTime.ToString())}");
            toStringOutput.Add($"this.Page = {(this.Page == null ? "null" : this.Page)}");
        }
    }
}