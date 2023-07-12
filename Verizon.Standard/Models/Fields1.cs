// <copyright file="Fields1.cs" company="APIMatic">
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
    /// Fields1.
    /// </summary>
    public class Fields1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Fields1"/> class.
        /// </summary>
        public Fields1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Fields1"/> class.
        /// </summary>
        /// <param name="item">item.</param>
        public Fields1(
            Models.SearchDeviceByPropertyFields item = null)
        {
            this.Item = item;
        }

        /// <summary>
        /// List of device sensors and their most recently reported values.
        /// </summary>
        [JsonProperty("item", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SearchDeviceByPropertyFields Item { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Fields1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Fields1 other &&                ((this.Item == null && other.Item == null) || (this.Item?.Equals(other.Item) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Item = {(this.Item == null ? "null" : this.Item.ToString())}");
        }
    }
}