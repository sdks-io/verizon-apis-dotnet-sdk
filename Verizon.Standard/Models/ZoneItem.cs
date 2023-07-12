// <copyright file="ZoneItem.cs" company="APIMatic">
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
    /// ZoneItem.
    /// </summary>
    public class ZoneItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZoneItem"/> class.
        /// </summary>
        public ZoneItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZoneItem"/> class.
        /// </summary>
        /// <param name="zone">zone.</param>
        public ZoneItem(
            string zone = null)
        {
            this.Zone = zone;
        }

        /// <summary>
        /// Zone name.
        /// </summary>
        [JsonProperty("zone", NullValueHandling = NullValueHandling.Ignore)]
        public string Zone { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ZoneItem : ({string.Join(", ", toStringOutput)})";
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
            return obj is ZoneItem other &&                ((this.Zone == null && other.Zone == null) || (this.Zone?.Equals(other.Zone) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Zone = {(this.Zone == null ? "null" : this.Zone == string.Empty ? "" : this.Zone)}");
        }
    }
}