// <copyright file="IntelligenceSuccessResult.cs" company="APIMatic">
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
    /// IntelligenceSuccessResult.
    /// </summary>
    public class IntelligenceSuccessResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntelligenceSuccessResult"/> class.
        /// </summary>
        public IntelligenceSuccessResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntelligenceSuccessResult"/> class.
        /// </summary>
        /// <param name="status">status.</param>
        public IntelligenceSuccessResult(
            string status = null)
        {
            this.Status = status;
        }

        /// <summary>
        /// Anomaly detection status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"IntelligenceSuccessResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is IntelligenceSuccessResult other &&                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status)}");
        }
    }
}