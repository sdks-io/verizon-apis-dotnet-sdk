// <copyright file="NumericalData.cs" company="APIMatic">
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
    /// NumericalData.
    /// </summary>
    public class NumericalData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NumericalData"/> class.
        /// </summary>
        public NumericalData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumericalData"/> class.
        /// </summary>
        /// <param name="mValue">value.</param>
        /// <param name="unit">unit.</param>
        public NumericalData(
            int? mValue = null,
            Models.NumericalDataUnitEnum? unit = null)
        {
            this.MValue = mValue;
            this.Unit = unit;
        }

        /// <summary>
        /// Numerical value.
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public int? MValue { get; set; }

        /// <summary>
        /// Unit of time.
        /// </summary>
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public Models.NumericalDataUnitEnum? Unit { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"NumericalData : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is NumericalData other &&
                (this.MValue == null && other.MValue == null ||
                 this.MValue?.Equals(other.MValue) == true) &&
                (this.Unit == null && other.Unit == null ||
                 this.Unit?.Equals(other.Unit) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"MValue = {(this.MValue == null ? "null" : this.MValue.ToString())}");
            toStringOutput.Add($"Unit = {(this.Unit == null ? "null" : this.Unit.ToString())}");
        }
    }
}