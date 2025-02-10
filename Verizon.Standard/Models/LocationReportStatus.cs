// <copyright file="LocationReportStatus.cs" company="APIMatic">
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
    /// LocationReportStatus.
    /// </summary>
    public class LocationReportStatus
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationReportStatus"/> class.
        /// </summary>
        public LocationReportStatus()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationReportStatus"/> class.
        /// </summary>
        /// <param name="txid">txid.</param>
        /// <param name="status">status.</param>
        public LocationReportStatus(
            string txid = null,
            Models.ReportStatusEnum? status = null)
        {
            this.Txid = txid;
            this.Status = status;
        }

        /// <summary>
        /// The transaction ID of the report.
        /// </summary>
        [JsonProperty("txid", NullValueHandling = NullValueHandling.Ignore)]
        public string Txid { get; set; }

        /// <summary>
        /// Status of the report.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ReportStatusEnum? Status { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"LocationReportStatus : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is LocationReportStatus other &&
                (this.Txid == null && other.Txid == null ||
                 this.Txid?.Equals(other.Txid) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Txid = {this.Txid ?? "null"}");
            toStringOutput.Add($"Status = {(this.Status == null ? "null" : this.Status.ToString())}");
        }
    }
}