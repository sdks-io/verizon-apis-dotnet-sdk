// <copyright file="MECPlatformsAdditionalSupportInfoData.cs" company="APIMatic">
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
    /// MECPlatformsAdditionalSupportInfoData.
    /// </summary>
    public class MECPlatformsAdditionalSupportInfoData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MECPlatformsAdditionalSupportInfoData"/> class.
        /// </summary>
        public MECPlatformsAdditionalSupportInfoData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MECPlatformsAdditionalSupportInfoData"/> class.
        /// </summary>
        /// <param name="additionalInfo">additionalInfo.</param>
        public MECPlatformsAdditionalSupportInfoData(
            string additionalInfo = null)
        {
            this.AdditionalInfo = additionalInfo;
        }

        /// <summary>
        /// Gets or sets AdditionalInfo.
        /// </summary>
        [JsonProperty("additionalInfo", NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionalInfo { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MECPlatformsAdditionalSupportInfoData : ({string.Join(", ", toStringOutput)})";
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
            return obj is MECPlatformsAdditionalSupportInfoData other &&                ((this.AdditionalInfo == null && other.AdditionalInfo == null) || (this.AdditionalInfo?.Equals(other.AdditionalInfo) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AdditionalInfo = {(this.AdditionalInfo == null ? "null" : this.AdditionalInfo == string.Empty ? "" : this.AdditionalInfo)}");
        }
    }
}