// <copyright file="Location.cs" company="APIMatic">
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
    /// Location.
    /// </summary>
    public class Location
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Location"/> class.
        /// </summary>
        public Location()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Location"/> class.
        /// </summary>
        /// <param name="msid">msid.</param>
        /// <param name="pd">pd.</param>
        /// <param name="error">error.</param>
        public Location(
            string msid = null,
            Models.PositionData pd = null,
            Models.PositionError error = null)
        {
            this.Msid = msid;
            this.Pd = pd;
            this.Error = error;
        }

        /// <summary>
        /// MDN.
        /// </summary>
        [JsonProperty("msid", NullValueHandling = NullValueHandling.Ignore)]
        public string Msid { get; set; }

        /// <summary>
        /// Position data.
        /// </summary>
        [JsonProperty("pd", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PositionData Pd { get; set; }

        /// <summary>
        /// Position error.
        /// </summary>
        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PositionError Error { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Location : ({string.Join(", ", toStringOutput)})";
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
            return obj is Location other &&                ((this.Msid == null && other.Msid == null) || (this.Msid?.Equals(other.Msid) == true)) &&
                ((this.Pd == null && other.Pd == null) || (this.Pd?.Equals(other.Pd) == true)) &&
                ((this.Error == null && other.Error == null) || (this.Error?.Equals(other.Error) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Msid = {(this.Msid == null ? "null" : this.Msid)}");
            toStringOutput.Add($"this.Pd = {(this.Pd == null ? "null" : this.Pd.ToString())}");
            toStringOutput.Add($"this.Error = {(this.Error == null ? "null" : this.Error.ToString())}");
        }
    }
}