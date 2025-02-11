// <copyright file="SearchDeviceEventHistoryResponseList.cs" company="APIMatic">
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
    /// SearchDeviceEventHistoryResponseList.
    /// </summary>
    public class SearchDeviceEventHistoryResponseList
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchDeviceEventHistoryResponseList"/> class.
        /// </summary>
        public SearchDeviceEventHistoryResponseList()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchDeviceEventHistoryResponseList"/> class.
        /// </summary>
        /// <param name="searchDeviceEventHistory">SearchDeviceEventHistory.</param>
        public SearchDeviceEventHistoryResponseList(
            List<Models.SearchDeviceResponse> searchDeviceEventHistory = null)
        {
            this.SearchDeviceEventHistory = searchDeviceEventHistory;
        }

        /// <summary>
        /// Gets or sets SearchDeviceEventHistory.
        /// </summary>
        [JsonProperty("SearchDeviceEventHistory", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.SearchDeviceResponse> SearchDeviceEventHistory { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SearchDeviceEventHistoryResponseList : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SearchDeviceEventHistoryResponseList other &&
                (this.SearchDeviceEventHistory == null && other.SearchDeviceEventHistory == null ||
                 this.SearchDeviceEventHistory?.Equals(other.SearchDeviceEventHistory) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"SearchDeviceEventHistory = {(this.SearchDeviceEventHistory == null ? "null" : $"[{string.Join(", ", this.SearchDeviceEventHistory)} ]")}");
        }
    }
}