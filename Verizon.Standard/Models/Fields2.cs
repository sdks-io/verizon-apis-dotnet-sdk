// <copyright file="Fields2.cs" company="APIMatic">
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
    /// Fields2.
    /// </summary>
    public class Fields2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Fields2"/> class.
        /// </summary>
        public Fields2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Fields2"/> class.
        /// </summary>
        /// <param name="temperature">temperature.</param>
        public Fields2(
            string temperature = null)
        {
            this.Temperature = temperature;
        }

        /// <summary>
        /// Gets or sets Temperature.
        /// </summary>
        [JsonProperty("temperature", NullValueHandling = NullValueHandling.Ignore)]
        public string Temperature { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Fields2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Fields2 other &&                ((this.Temperature == null && other.Temperature == null) || (this.Temperature?.Equals(other.Temperature) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Temperature = {(this.Temperature == null ? "null" : this.Temperature)}");
        }
    }
}