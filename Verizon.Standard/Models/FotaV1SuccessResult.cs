// <copyright file="FotaV1SuccessResult.cs" company="APIMatic">
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
    /// FotaV1SuccessResult.
    /// </summary>
    public class FotaV1SuccessResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FotaV1SuccessResult"/> class.
        /// </summary>
        public FotaV1SuccessResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FotaV1SuccessResult"/> class.
        /// </summary>
        /// <param name="success">success.</param>
        public FotaV1SuccessResult(
            bool? success = null)
        {
            this.Success = success;
        }

        /// <summary>
        /// True is returned in case of success.
        /// </summary>
        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Success { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"FotaV1SuccessResult : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is FotaV1SuccessResult other &&
                (this.Success == null && other.Success == null ||
                 this.Success?.Equals(other.Success) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Success = {(this.Success == null ? "null" : this.Success.ToString())}");
        }
    }
}