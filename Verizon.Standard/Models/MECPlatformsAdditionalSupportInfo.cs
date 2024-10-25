// <copyright file="MECPlatformsAdditionalSupportInfo.cs" company="APIMatic">
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
    /// MECPlatformsAdditionalSupportInfo.
    /// </summary>
    public class MECPlatformsAdditionalSupportInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MECPlatformsAdditionalSupportInfo"/> class.
        /// </summary>
        public MECPlatformsAdditionalSupportInfo()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MECPlatformsAdditionalSupportInfo"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="data">data.</param>
        public MECPlatformsAdditionalSupportInfo(
            string type = null,
            Models.MECPlatformsAdditionalSupportInfoData data = null)
        {
            this.Type = type;
            this.Data = data;
        }

        /// <summary>
        /// Type of additional service support information for the MEC platform.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// Data about additional service support information for the MEC platform.
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MECPlatformsAdditionalSupportInfoData Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MECPlatformsAdditionalSupportInfo : ({string.Join(", ", toStringOutput)})";
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
            return obj is MECPlatformsAdditionalSupportInfo other &&                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : this.Data.ToString())}");
        }
    }
}