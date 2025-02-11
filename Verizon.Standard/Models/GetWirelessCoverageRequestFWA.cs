// <copyright file="GetWirelessCoverageRequestFWA.cs" company="APIMatic">
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
    /// GetWirelessCoverageRequestFWA.
    /// </summary>
    public class GetWirelessCoverageRequestFWA
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetWirelessCoverageRequestFWA"/> class.
        /// </summary>
        public GetWirelessCoverageRequestFWA()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWirelessCoverageRequestFWA"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="requestType">requestType.</param>
        /// <param name="locationType">locationType.</param>
        /// <param name="locations">locations.</param>
        /// <param name="networkTypesList">networkTypesList.</param>
        public GetWirelessCoverageRequestFWA(
            string accountName,
            string requestType,
            string locationType,
            Models.Locations locations,
            List<Models.NetworkType> networkTypesList)
        {
            this.AccountName = accountName;
            this.RequestType = requestType;
            this.LocationType = locationType;
            this.Locations = locations;
            this.NetworkTypesList = networkTypesList;
        }

        /// <summary>
        /// Account name.
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Type of request.
        /// </summary>
        [JsonProperty("requestType")]
        public string RequestType { get; set; }

        /// <summary>
        /// Type of location detail.
        /// </summary>
        [JsonProperty("locationType")]
        public string LocationType { get; set; }

        /// <summary>
        /// Location details.
        /// </summary>
        [JsonProperty("locations")]
        public Models.Locations Locations { get; set; }

        /// <summary>
        /// Gets or sets NetworkTypesList.
        /// </summary>
        [JsonProperty("networkTypesList")]
        public List<Models.NetworkType> NetworkTypesList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GetWirelessCoverageRequestFWA : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GetWirelessCoverageRequestFWA other &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.RequestType == null && other.RequestType == null ||
                 this.RequestType?.Equals(other.RequestType) == true) &&
                (this.LocationType == null && other.LocationType == null ||
                 this.LocationType?.Equals(other.LocationType) == true) &&
                (this.Locations == null && other.Locations == null ||
                 this.Locations?.Equals(other.Locations) == true) &&
                (this.NetworkTypesList == null && other.NetworkTypesList == null ||
                 this.NetworkTypesList?.Equals(other.NetworkTypesList) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
            toStringOutput.Add($"RequestType = {this.RequestType ?? "null"}");
            toStringOutput.Add($"LocationType = {this.LocationType ?? "null"}");
            toStringOutput.Add($"Locations = {(this.Locations == null ? "null" : this.Locations.ToString())}");
            toStringOutput.Add($"NetworkTypesList = {(this.NetworkTypesList == null ? "null" : $"[{string.Join(", ", this.NetworkTypesList)} ]")}");
        }
    }
}