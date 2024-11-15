// <copyright file="FieldsHttpHeaders.cs" company="APIMatic">
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
    /// FieldsHttpHeaders.
    /// </summary>
    public class FieldsHttpHeaders
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldsHttpHeaders"/> class.
        /// </summary>
        public FieldsHttpHeaders()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldsHttpHeaders"/> class.
        /// </summary>
        /// <param name="authorization">Authorization.</param>
        public FieldsHttpHeaders(
            string authorization = null)
        {
            this.Authorization = authorization;
        }

        /// <summary>
        /// Gets or sets Authorization.
        /// </summary>
        [JsonProperty("Authorization", NullValueHandling = NullValueHandling.Ignore)]
        public string Authorization { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"FieldsHttpHeaders : ({string.Join(", ", toStringOutput)})";
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
            return obj is FieldsHttpHeaders other &&                ((this.Authorization == null && other.Authorization == null) || (this.Authorization?.Equals(other.Authorization) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Authorization = {(this.Authorization == null ? "null" : this.Authorization)}");
        }
    }
}