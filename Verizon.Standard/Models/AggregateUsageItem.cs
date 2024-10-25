// <copyright file="AggregateUsageItem.cs" company="APIMatic">
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
    /// AggregateUsageItem.
    /// </summary>
    public class AggregateUsageItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateUsageItem"/> class.
        /// </summary>
        public AggregateUsageItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateUsageItem"/> class.
        /// </summary>
        /// <param name="imei">imei.</param>
        /// <param name="numberOfSessions">numberOfSessions.</param>
        /// <param name="bytesTransferred">bytesTransferred.</param>
        public AggregateUsageItem(
            string imei = null,
            int? numberOfSessions = null,
            int? bytesTransferred = null)
        {
            this.Imei = imei;
            this.NumberOfSessions = numberOfSessions;
            this.BytesTransferred = bytesTransferred;
        }

        /// <summary>
        /// International Mobile Equipment Identifier. This is the ID of the device reporting usage.
        /// </summary>
        [JsonProperty("imei", NullValueHandling = NullValueHandling.Ignore)]
        public string Imei { get; set; }

        /// <summary>
        /// Number of sessions established by the device reporting usage.
        /// </summary>
        [JsonProperty("numberOfSessions", NullValueHandling = NullValueHandling.Ignore)]
        public int? NumberOfSessions { get; set; }

        /// <summary>
        /// The amount of data transferred by the device reporting usage, measured in Bytes.
        /// </summary>
        [JsonProperty("bytesTransferred", NullValueHandling = NullValueHandling.Ignore)]
        public int? BytesTransferred { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AggregateUsageItem : ({string.Join(", ", toStringOutput)})";
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
            return obj is AggregateUsageItem other &&                ((this.Imei == null && other.Imei == null) || (this.Imei?.Equals(other.Imei) == true)) &&
                ((this.NumberOfSessions == null && other.NumberOfSessions == null) || (this.NumberOfSessions?.Equals(other.NumberOfSessions) == true)) &&
                ((this.BytesTransferred == null && other.BytesTransferred == null) || (this.BytesTransferred?.Equals(other.BytesTransferred) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Imei = {(this.Imei == null ? "null" : this.Imei)}");
            toStringOutput.Add($"this.NumberOfSessions = {(this.NumberOfSessions == null ? "null" : this.NumberOfSessions.ToString())}");
            toStringOutput.Add($"this.BytesTransferred = {(this.BytesTransferred == null ? "null" : this.BytesTransferred.ToString())}");
        }
    }
}