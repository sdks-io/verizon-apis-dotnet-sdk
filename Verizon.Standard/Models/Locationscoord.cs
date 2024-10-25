// <copyright file="Locationscoord.cs" company="APIMatic">
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
    /// Locationscoord.
    /// </summary>
    public class Locationscoord
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Locationscoord"/> class.
        /// </summary>
        public Locationscoord()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Locationscoord"/> class.
        /// </summary>
        /// <param name="coordinatesList">coordinatesList.</param>
        public Locationscoord(
            List<Models.Coordinates> coordinatesList)
        {
            this.CoordinatesList = coordinatesList;
        }

        /// <summary>
        /// Gets or sets CoordinatesList.
        /// </summary>
        [JsonProperty("coordinatesList")]
        public List<Models.Coordinates> CoordinatesList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Locationscoord : ({string.Join(", ", toStringOutput)})";
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
            return obj is Locationscoord other &&                ((this.CoordinatesList == null && other.CoordinatesList == null) || (this.CoordinatesList?.Equals(other.CoordinatesList) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CoordinatesList = {(this.CoordinatesList == null ? "null" : $"[{string.Join(", ", this.CoordinatesList)} ]")}");
        }
    }
}