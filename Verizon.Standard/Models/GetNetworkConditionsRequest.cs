// <copyright file="GetNetworkConditionsRequest.cs" company="APIMatic">
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
    /// GetNetworkConditionsRequest.
    /// </summary>
    public class GetNetworkConditionsRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetNetworkConditionsRequest"/> class.
        /// </summary>
        public GetNetworkConditionsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetNetworkConditionsRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="locationType">locationType.</param>
        /// <param name="coordinates">coordinates.</param>
        public GetNetworkConditionsRequest(
            string accountName,
            string locationType,
            Models.Coordinates coordinates)
        {
            this.AccountName = accountName;
            this.LocationType = locationType;
            this.Coordinates = coordinates;
        }

        /// <summary>
        /// Account name.
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Type of location detail.
        /// </summary>
        [JsonProperty("locationType")]
        public string LocationType { get; set; }

        /// <summary>
        /// Coordinates information.
        /// </summary>
        [JsonProperty("coordinates")]
        public Models.Coordinates Coordinates { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetNetworkConditionsRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is GetNetworkConditionsRequest other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.LocationType == null && other.LocationType == null) || (this.LocationType?.Equals(other.LocationType) == true)) &&
                ((this.Coordinates == null && other.Coordinates == null) || (this.Coordinates?.Equals(other.Coordinates) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.LocationType = {(this.LocationType == null ? "null" : this.LocationType)}");
            toStringOutput.Add($"this.Coordinates = {(this.Coordinates == null ? "null" : this.Coordinates.ToString())}");
        }
    }
}