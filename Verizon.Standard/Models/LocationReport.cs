// <copyright file="LocationReport.cs" company="APIMatic">
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
    /// LocationReport.
    /// </summary>
    public class LocationReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationReport"/> class.
        /// </summary>
        public LocationReport()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationReport"/> class.
        /// </summary>
        /// <param name="devLocationList">devLocationList.</param>
        /// <param name="hasMoreData">hasMoreData.</param>
        /// <param name="startIndex">startIndex.</param>
        /// <param name="totalCount">totalCount.</param>
        /// <param name="txid">txid.</param>
        public LocationReport(
            List<Models.Location> devLocationList = null,
            bool? hasMoreData = null,
            string startIndex = null,
            int? totalCount = null,
            string txid = null)
        {
            this.DevLocationList = devLocationList;
            this.HasMoreData = hasMoreData;
            this.StartIndex = startIndex;
            this.TotalCount = totalCount;
            this.Txid = txid;
        }

        /// <summary>
        /// Device location information.
        /// </summary>
        [JsonProperty("devLocationList", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Location> DevLocationList { get; set; }

        /// <summary>
        /// True if there are more device locations to retrieve.
        /// </summary>
        [JsonProperty("hasMoreData", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasMoreData { get; set; }

        /// <summary>
        /// The zero-based number of the first record to return. Set startIndex=0 for the first request. If there are more than 1,000 devices to be returned (hasMoreData=true), set startIndex=1000 for the second request, 2000 for the third request, etc.
        /// </summary>
        [JsonProperty("startIndex", NullValueHandling = NullValueHandling.Ignore)]
        public string StartIndex { get; set; }

        /// <summary>
        /// The total number of devices in the original request and in the report.
        /// </summary>
        [JsonProperty("totalCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The transaction ID of the report.
        /// </summary>
        [JsonProperty("txid", NullValueHandling = NullValueHandling.Ignore)]
        public string Txid { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"LocationReport : ({string.Join(", ", toStringOutput)})";
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
            return obj is LocationReport other &&                ((this.DevLocationList == null && other.DevLocationList == null) || (this.DevLocationList?.Equals(other.DevLocationList) == true)) &&
                ((this.HasMoreData == null && other.HasMoreData == null) || (this.HasMoreData?.Equals(other.HasMoreData) == true)) &&
                ((this.StartIndex == null && other.StartIndex == null) || (this.StartIndex?.Equals(other.StartIndex) == true)) &&
                ((this.TotalCount == null && other.TotalCount == null) || (this.TotalCount?.Equals(other.TotalCount) == true)) &&
                ((this.Txid == null && other.Txid == null) || (this.Txid?.Equals(other.Txid) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DevLocationList = {(this.DevLocationList == null ? "null" : $"[{string.Join(", ", this.DevLocationList)} ]")}");
            toStringOutput.Add($"this.HasMoreData = {(this.HasMoreData == null ? "null" : this.HasMoreData.ToString())}");
            toStringOutput.Add($"this.StartIndex = {(this.StartIndex == null ? "null" : this.StartIndex == string.Empty ? "" : this.StartIndex)}");
            toStringOutput.Add($"this.TotalCount = {(this.TotalCount == null ? "null" : this.TotalCount.ToString())}");
            toStringOutput.Add($"this.Txid = {(this.Txid == null ? "null" : this.Txid == string.Empty ? "" : this.Txid)}");
        }
    }
}