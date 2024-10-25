// <copyright file="FotaV3SuccessResult.cs" company="APIMatic">
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
    /// FotaV3SuccessResult.
    /// </summary>
    public class FotaV3SuccessResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FotaV3SuccessResult"/> class.
        /// </summary>
        public FotaV3SuccessResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FotaV3SuccessResult"/> class.
        /// </summary>
        /// <param name="success">success.</param>
        public FotaV3SuccessResult(
            bool success)
        {
            this.Success = success;
        }

        /// <summary>
        /// True or false.
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"FotaV3SuccessResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is FotaV3SuccessResult other &&                this.Success.Equals(other.Success);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Success = {this.Success}");
        }
    }
}