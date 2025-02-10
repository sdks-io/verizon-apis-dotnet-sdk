// <copyright file="GroupName.cs" company="APIMatic">
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
    /// GroupName.
    /// </summary>
    public class GroupName
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupName"/> class.
        /// </summary>
        public GroupName()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupName"/> class.
        /// </summary>
        /// <param name="mDefault">Default.</param>
        public GroupName(
            string mDefault = null)
        {
            this.MDefault = mDefault;
        }

        /// <summary>
        /// Gets or sets MDefault.
        /// </summary>
        [JsonProperty("Default", NullValueHandling = NullValueHandling.Ignore)]
        public string MDefault { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GroupName : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GroupName other &&
                (this.MDefault == null && other.MDefault == null ||
                 this.MDefault?.Equals(other.MDefault) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"MDefault = {this.MDefault ?? "null"}");
        }
    }
}