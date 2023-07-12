// <copyright file="DiagnosticsCategory.cs" company="APIMatic">
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
    /// DiagnosticsCategory.
    /// </summary>
    public class DiagnosticsCategory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticsCategory"/> class.
        /// </summary>
        public DiagnosticsCategory()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticsCategory"/> class.
        /// </summary>
        /// <param name="categoryName">categoryName.</param>
        /// <param name="extendedAttributes">extendedAttributes.</param>
        public DiagnosticsCategory(
            string categoryName = null,
            List<Models.CustomFields> extendedAttributes = null)
        {
            this.CategoryName = categoryName;
            this.ExtendedAttributes = extendedAttributes;
        }

        /// <summary>
        /// The name of the category.
        /// </summary>
        [JsonProperty("categoryName", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryName { get; set; }

        /// <summary>
        /// A list of Extended Attribute objects as key-value pairs.
        /// </summary>
        [JsonProperty("extendedAttributes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CustomFields> ExtendedAttributes { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DiagnosticsCategory : ({string.Join(", ", toStringOutput)})";
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
            return obj is DiagnosticsCategory other &&                ((this.CategoryName == null && other.CategoryName == null) || (this.CategoryName?.Equals(other.CategoryName) == true)) &&
                ((this.ExtendedAttributes == null && other.ExtendedAttributes == null) || (this.ExtendedAttributes?.Equals(other.ExtendedAttributes) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CategoryName = {(this.CategoryName == null ? "null" : this.CategoryName == string.Empty ? "" : this.CategoryName)}");
            toStringOutput.Add($"this.ExtendedAttributes = {(this.ExtendedAttributes == null ? "null" : $"[{string.Join(", ", this.ExtendedAttributes)} ]")}");
        }
    }
}