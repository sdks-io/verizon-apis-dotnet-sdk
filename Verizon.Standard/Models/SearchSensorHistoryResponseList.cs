// <copyright file="SearchSensorHistoryResponseList.cs" company="APIMatic">
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
    /// SearchSensorHistoryResponseList.
    /// </summary>
    public class SearchSensorHistoryResponseList
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchSensorHistoryResponseList"/> class.
        /// </summary>
        public SearchSensorHistoryResponseList()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchSensorHistoryResponseList"/> class.
        /// </summary>
        /// <param name="searchSensorHistory">SearchSensorHistory.</param>
        public SearchSensorHistoryResponseList(
            List<Models.SearchDeviceResponse> searchSensorHistory = null)
        {
            this.SearchSensorHistory = searchSensorHistory;
        }

        /// <summary>
        /// Gets or sets SearchSensorHistory.
        /// </summary>
        [JsonProperty("SearchSensorHistory", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.SearchDeviceResponse> SearchSensorHistory { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SearchSensorHistoryResponseList : ({string.Join(", ", toStringOutput)})";
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
            return obj is SearchSensorHistoryResponseList other &&                ((this.SearchSensorHistory == null && other.SearchSensorHistory == null) || (this.SearchSensorHistory?.Equals(other.SearchSensorHistory) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SearchSensorHistory = {(this.SearchSensorHistory == null ? "null" : $"[{string.Join(", ", this.SearchSensorHistory)} ]")}");
        }
    }
}