// <copyright file="Fields.cs" company="APIMatic">
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
    /// Fields.
    /// </summary>
    public class Fields
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Fields"/> class.
        /// </summary>
        public Fields()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Fields"/> class.
        /// </summary>
        /// <param name="configuration">configuration.</param>
        public Fields(
            Models.Configuration configuration = null)
        {
            this.Configuration = configuration;
        }

        /// <summary>
        /// List of the field names and values to set.
        /// </summary>
        [JsonProperty("configuration", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Configuration Configuration { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Fields : ({string.Join(", ", toStringOutput)})";
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
            return obj is Fields other &&                ((this.Configuration == null && other.Configuration == null) || (this.Configuration?.Equals(other.Configuration) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Configuration = {(this.Configuration == null ? "null" : this.Configuration.ToString())}");
        }
    }
}