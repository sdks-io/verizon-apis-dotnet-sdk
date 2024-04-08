// <copyright file="MECProfile.cs" company="APIMatic">
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
    using APIMatic.Core.Utilities.Converters;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Verizon.Standard;
    using Verizon.Standard.Utilities;

    /// <summary>
    /// MECProfile.
    /// </summary>
    public class MECProfile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MECProfile"/> class.
        /// </summary>
        public MECProfile()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MECProfile"/> class.
        /// </summary>
        /// <param name="profileId">profileId.</param>
        /// <param name="profileName">profileName.</param>
        public MECProfile(
            string profileId = null,
            string profileName = null)
        {
            this.ProfileId = profileId;
            this.ProfileName = profileName;
        }

        /// <summary>
        /// Gets or sets ProfileId.
        /// </summary>
        [JsonProperty("profileId", NullValueHandling = NullValueHandling.Ignore)]
        public string ProfileId { get; set; }

        /// <summary>
        /// Gets or sets ProfileName.
        /// </summary>
        [JsonProperty("profileName", NullValueHandling = NullValueHandling.Ignore)]
        public string ProfileName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MECProfile : ({string.Join(", ", toStringOutput)})";
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
            return obj is MECProfile other &&                ((this.ProfileId == null && other.ProfileId == null) || (this.ProfileId?.Equals(other.ProfileId) == true)) &&
                ((this.ProfileName == null && other.ProfileName == null) || (this.ProfileName?.Equals(other.ProfileName) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ProfileId = {(this.ProfileId == null ? "null" : this.ProfileId)}");
            toStringOutput.Add($"this.ProfileName = {(this.ProfileName == null ? "null" : this.ProfileName)}");
        }
    }
}