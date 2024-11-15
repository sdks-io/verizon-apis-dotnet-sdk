// <copyright file="UpgradeListQueryResult.cs" company="APIMatic">
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
    /// UpgradeListQueryResult.
    /// </summary>
    public class UpgradeListQueryResult
    {
        private List<Models.FirmwareUpgrade> reportList;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "reportList", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="UpgradeListQueryResult"/> class.
        /// </summary>
        public UpgradeListQueryResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpgradeListQueryResult"/> class.
        /// </summary>
        /// <param name="hasMoreFlag">hasMoreFlag.</param>
        /// <param name="lastSeenUpgradeId">lastSeenUpgradeId.</param>
        /// <param name="reportList">reportList.</param>
        public UpgradeListQueryResult(
            bool? hasMoreFlag = null,
            int? lastSeenUpgradeId = null,
            List<Models.FirmwareUpgrade> reportList = null)
        {
            this.HasMoreFlag = hasMoreFlag;
            this.LastSeenUpgradeId = lastSeenUpgradeId;
            if (reportList != null)
            {
                this.ReportList = reportList;
            }

        }

        /// <summary>
        /// True if there are more devices to retrieve.
        /// </summary>
        [JsonProperty("hasMoreFlag", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasMoreFlag { get; set; }

        /// <summary>
        /// If hasMoreData=true, the startIndex to use for the next request. 0 if hasMoreData=false.
        /// </summary>
        [JsonProperty("lastSeenUpgradeId", NullValueHandling = NullValueHandling.Ignore)]
        public int? LastSeenUpgradeId { get; set; }

        /// <summary>
        /// Array of upgrade objects with the specified status.
        /// </summary>
        [JsonProperty("reportList")]
        public List<Models.FirmwareUpgrade> ReportList
        {
            get
            {
                return this.reportList;
            }

            set
            {
                this.shouldSerialize["reportList"] = true;
                this.reportList = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UpgradeListQueryResult : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetReportList()
        {
            this.shouldSerialize["reportList"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeReportList()
        {
            return this.shouldSerialize["reportList"];
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
            return obj is UpgradeListQueryResult other &&                ((this.HasMoreFlag == null && other.HasMoreFlag == null) || (this.HasMoreFlag?.Equals(other.HasMoreFlag) == true)) &&
                ((this.LastSeenUpgradeId == null && other.LastSeenUpgradeId == null) || (this.LastSeenUpgradeId?.Equals(other.LastSeenUpgradeId) == true)) &&
                ((this.ReportList == null && other.ReportList == null) || (this.ReportList?.Equals(other.ReportList) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.HasMoreFlag = {(this.HasMoreFlag == null ? "null" : this.HasMoreFlag.ToString())}");
            toStringOutput.Add($"this.LastSeenUpgradeId = {(this.LastSeenUpgradeId == null ? "null" : this.LastSeenUpgradeId.ToString())}");
            toStringOutput.Add($"this.ReportList = {(this.ReportList == null ? "null" : $"[{string.Join(", ", this.ReportList)} ]")}");
        }
    }
}