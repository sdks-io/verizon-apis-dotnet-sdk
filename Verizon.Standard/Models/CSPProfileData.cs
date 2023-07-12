// <copyright file="CSPProfileData.cs" company="APIMatic">
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
    /// CSPProfileData.
    /// </summary>
    public class CSPProfileData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CSPProfileData"/> class.
        /// </summary>
        public CSPProfileData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CSPProfileData"/> class.
        /// </summary>
        /// <param name="count">count.</param>
        /// <param name="cspProfileList">cspProfileList.</param>
        public CSPProfileData(
            int? count = null,
            List<Models.CSPProfile> cspProfileList = null)
        {
            this.Count = count;
            this.CspProfileList = cspProfileList;
        }

        /// <summary>
        /// Total number of records available.
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// List of all available CSP profile available within the user's organization.
        /// </summary>
        [JsonProperty("cspProfileList", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CSPProfile> CspProfileList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CSPProfileData : ({string.Join(", ", toStringOutput)})";
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
            return obj is CSPProfileData other &&                ((this.Count == null && other.Count == null) || (this.Count?.Equals(other.Count) == true)) &&
                ((this.CspProfileList == null && other.CspProfileList == null) || (this.CspProfileList?.Equals(other.CspProfileList) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Count = {(this.Count == null ? "null" : this.Count.ToString())}");
            toStringOutput.Add($"this.CspProfileList = {(this.CspProfileList == null ? "null" : $"[{string.Join(", ", this.CspProfileList)} ]")}");
        }
    }
}