// <copyright file="M5gBiCarrierInformation.cs" company="APIMatic">
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
    /// M5gBiCarrierInformation.
    /// </summary>
    public class M5gBiCarrierInformation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="M5gBiCarrierInformation"/> class.
        /// </summary>
        public M5gBiCarrierInformation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="M5gBiCarrierInformation"/> class.
        /// </summary>
        /// <param name="carrierName">carrierName.</param>
        public M5gBiCarrierInformation(
            string carrierName = null)
        {
            this.CarrierName = carrierName;
        }

        /// <summary>
        /// Gets or sets CarrierName.
        /// </summary>
        [JsonProperty("carrierName", NullValueHandling = NullValueHandling.Ignore)]
        public string CarrierName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"M5gBiCarrierInformation : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is M5gBiCarrierInformation other &&
                (this.CarrierName == null && other.CarrierName == null ||
                 this.CarrierName?.Equals(other.CarrierName) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CarrierName = {this.CarrierName ?? "null"}");
        }
    }
}