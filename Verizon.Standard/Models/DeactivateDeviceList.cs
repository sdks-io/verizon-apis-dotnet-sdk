// <copyright file="DeactivateDeviceList.cs" company="APIMatic">
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
    /// DeactivateDeviceList.
    /// </summary>
    public class DeactivateDeviceList
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeactivateDeviceList"/> class.
        /// </summary>
        public DeactivateDeviceList()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeactivateDeviceList"/> class.
        /// </summary>
        /// <param name="ids">ids.</param>
        public DeactivateDeviceList(
            List<Models.Id> ids = null)
        {
            this.Ids = ids;
        }

        /// <summary>
        /// Gets or sets Ids.
        /// </summary>
        [JsonProperty("ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Id> Ids { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DeactivateDeviceList : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DeactivateDeviceList other &&
                (this.Ids == null && other.Ids == null ||
                 this.Ids?.Equals(other.Ids) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Ids = {(this.Ids == null ? "null" : $"[{string.Join(", ", this.Ids)} ]")}");
        }
    }
}