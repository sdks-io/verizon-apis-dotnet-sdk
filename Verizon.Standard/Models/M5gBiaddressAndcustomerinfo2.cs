// <copyright file="M5gBiaddressAndcustomerinfo2.cs" company="APIMatic">
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
    /// M5gBiaddressAndcustomerinfo2.
    /// </summary>
    public class M5gBiaddressAndcustomerinfo2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="M5gBiaddressAndcustomerinfo2"/> class.
        /// </summary>
        public M5gBiaddressAndcustomerinfo2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="M5gBiaddressAndcustomerinfo2"/> class.
        /// </summary>
        /// <param name="primaryPlaceofuse">primaryPlaceofuse.</param>
        public M5gBiaddressAndcustomerinfo2(
            Models.M5gBiaddressAndcustomerinfo primaryPlaceofuse = null)
        {
            this.PrimaryPlaceofuse = primaryPlaceofuse;
        }

        /// <summary>
        /// Gets or sets PrimaryPlaceofuse.
        /// </summary>
        [JsonProperty("primaryPlaceofuse", NullValueHandling = NullValueHandling.Ignore)]
        public Models.M5gBiaddressAndcustomerinfo PrimaryPlaceofuse { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"M5gBiaddressAndcustomerinfo2 : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is M5gBiaddressAndcustomerinfo2 other &&
                (this.PrimaryPlaceofuse == null && other.PrimaryPlaceofuse == null ||
                 this.PrimaryPlaceofuse?.Equals(other.PrimaryPlaceofuse) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"PrimaryPlaceofuse = {(this.PrimaryPlaceofuse == null ? "null" : this.PrimaryPlaceofuse.ToString())}");
        }
    }
}