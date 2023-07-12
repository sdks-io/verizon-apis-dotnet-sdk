// <copyright file="SynchronousLocationRequestResult.cs" company="APIMatic">
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
    /// SynchronousLocationRequestResult.
    /// </summary>
    public class SynchronousLocationRequestResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SynchronousLocationRequestResult"/> class.
        /// </summary>
        public SynchronousLocationRequestResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SynchronousLocationRequestResult"/> class.
        /// </summary>
        /// <param name="txid">txid.</param>
        /// <param name="status">status.</param>
        public SynchronousLocationRequestResult(
            string txid,
            Models.ReportStatusEnum status)
        {
            this.Txid = txid;
            this.Status = status;
        }

        /// <summary>
        /// The transaction ID of the report.
        /// </summary>
        [JsonProperty("txid")]
        public string Txid { get; set; }

        /// <summary>
        /// Status of the report.
        /// </summary>
        [JsonProperty("status", ItemConverterType = typeof(StringEnumConverter))]
        public Models.ReportStatusEnum Status { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SynchronousLocationRequestResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is SynchronousLocationRequestResult other &&                ((this.Txid == null && other.Txid == null) || (this.Txid?.Equals(other.Txid) == true)) &&
                this.Status.Equals(other.Status);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Txid = {(this.Txid == null ? "null" : this.Txid == string.Empty ? "" : this.Txid)}");
            toStringOutput.Add($"this.Status = {this.Status}");
        }
    }
}