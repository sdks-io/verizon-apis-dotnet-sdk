// <copyright file="PWNProfile.cs" company="APIMatic">
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
    /// PWNProfile.
    /// </summary>
    public class PWNProfile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PWNProfile"/> class.
        /// </summary>
        public PWNProfile()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PWNProfile"/> class.
        /// </summary>
        /// <param name="profileId">profileId.</param>
        /// <param name="profileName">profileName.</param>
        public PWNProfile(
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
            return $"PWNProfile : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PWNProfile other &&
                (this.ProfileId == null && other.ProfileId == null ||
                 this.ProfileId?.Equals(other.ProfileId) == true) &&
                (this.ProfileName == null && other.ProfileName == null ||
                 this.ProfileName?.Equals(other.ProfileName) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ProfileId = {this.ProfileId ?? "null"}");
            toStringOutput.Add($"ProfileName = {this.ProfileName ?? "null"}");
        }
    }
}