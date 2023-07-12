// <copyright file="HistorySearchFilterAttributes.cs" company="APIMatic">
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
    /// HistorySearchFilterAttributes.
    /// </summary>
    public class HistorySearchFilterAttributes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HistorySearchFilterAttributes"/> class.
        /// </summary>
        public HistorySearchFilterAttributes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HistorySearchFilterAttributes"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        public HistorySearchFilterAttributes(
            Models.AttributeIdentifierEnum? name = null)
        {
            this.Name = name;
        }

        /// <summary>
        /// Attribute identifier.
        /// </summary>
        [JsonProperty("name", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.AttributeIdentifierEnum? Name { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"HistorySearchFilterAttributes : ({string.Join(", ", toStringOutput)})";
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
            return obj is HistorySearchFilterAttributes other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name.ToString())}");
        }
    }
}