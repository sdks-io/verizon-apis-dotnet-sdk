// <copyright file="GenerateExternalIDResult.cs" company="APIMatic">
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
    /// GenerateExternalIDResult.
    /// </summary>
    public class GenerateExternalIDResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateExternalIDResult"/> class.
        /// </summary>
        public GenerateExternalIDResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateExternalIDResult"/> class.
        /// </summary>
        /// <param name="externalid">externalid.</param>
        public GenerateExternalIDResult(
            string externalid = null)
        {
            this.Externalid = externalid;
        }

        /// <summary>
        /// Newly created security string.
        /// </summary>
        [JsonProperty("externalid", NullValueHandling = NullValueHandling.Ignore)]
        public string Externalid { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GenerateExternalIDResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is GenerateExternalIDResult other &&                ((this.Externalid == null && other.Externalid == null) || (this.Externalid?.Equals(other.Externalid) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Externalid = {(this.Externalid == null ? "null" : this.Externalid)}");
        }
    }
}