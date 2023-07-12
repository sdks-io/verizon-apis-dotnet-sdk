// <copyright file="CategoryList.cs" company="APIMatic">
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
    /// CategoryList.
    /// </summary>
    public class CategoryList
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryList"/> class.
        /// </summary>
        public CategoryList()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryList"/> class.
        /// </summary>
        /// <param name="categories">categories.</param>
        public CategoryList(
            List<string> categories = null)
        {
            this.Categories = categories;
        }

        /// <summary>
        /// Can be any name just to define it under a category.
        /// </summary>
        [JsonProperty("categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Categories { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CategoryList : ({string.Join(", ", toStringOutput)})";
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
            return obj is CategoryList other &&                ((this.Categories == null && other.Categories == null) || (this.Categories?.Equals(other.Categories) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Categories = {(this.Categories == null ? "null" : $"[{string.Join(", ", this.Categories)} ]")}");
        }
    }
}