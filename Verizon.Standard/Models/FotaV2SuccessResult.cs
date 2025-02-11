// <copyright file="FotaV2SuccessResult.cs" company="APIMatic">
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
    /// FotaV2SuccessResult.
    /// </summary>
    public class FotaV2SuccessResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FotaV2SuccessResult"/> class.
        /// </summary>
        public FotaV2SuccessResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FotaV2SuccessResult"/> class.
        /// </summary>
        /// <param name="success">success.</param>
        public FotaV2SuccessResult(
            bool success)
        {
            this.Success = success;
        }

        /// <summary>
        /// Gets or sets Success.
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"FotaV2SuccessResult : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is FotaV2SuccessResult other &&
                (this.Success.Equals(other.Success));
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Success = {this.Success}");
        }
    }
}