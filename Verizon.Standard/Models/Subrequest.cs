// <copyright file="Subrequest.cs" company="APIMatic">
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
    /// Subrequest.
    /// </summary>
    public class Subrequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Subrequest"/> class.
        /// </summary>
        public Subrequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Subrequest"/> class.
        /// </summary>
        /// <param name="ids">ids.</param>
        /// <param name="status">status.</param>
        public Subrequest(
            Models.GIODeviceId ids = null,
            string status = null)
        {
            this.Ids = ids;
            this.Status = status;
        }

        /// <summary>
        /// Gets or sets Ids.
        /// </summary>
        [JsonProperty("ids", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GIODeviceId Ids { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Subrequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Subrequest other &&
                (this.Ids == null && other.Ids == null ||
                 this.Ids?.Equals(other.Ids) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Ids = {(this.Ids == null ? "null" : this.Ids.ToString())}");
            toStringOutput.Add($"Status = {this.Status ?? "null"}");
        }
    }
}