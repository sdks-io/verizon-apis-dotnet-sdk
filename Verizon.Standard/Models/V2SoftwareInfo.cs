// <copyright file="V2SoftwareInfo.cs" company="APIMatic">
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
    /// V2SoftwareInfo.
    /// </summary>
    public class V2SoftwareInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V2SoftwareInfo"/> class.
        /// </summary>
        public V2SoftwareInfo()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V2SoftwareInfo"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="version">version.</param>
        /// <param name="upgradeTime">upgradeTime.</param>
        public V2SoftwareInfo(
            string name,
            string version,
            string upgradeTime)
        {
            this.Name = name;
            this.Version = version;
            this.UpgradeTime = upgradeTime;
        }

        /// <summary>
        /// Software name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Software version.
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }

        /// <summary>
        /// Upgrade time.
        /// </summary>
        [JsonProperty("upgradeTime")]
        public string UpgradeTime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"V2SoftwareInfo : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is V2SoftwareInfo other &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Version == null && other.Version == null ||
                 this.Version?.Equals(other.Version) == true) &&
                (this.UpgradeTime == null && other.UpgradeTime == null ||
                 this.UpgradeTime?.Equals(other.UpgradeTime) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Version = {this.Version ?? "null"}");
            toStringOutput.Add($"UpgradeTime = {this.UpgradeTime ?? "null"}");
        }
    }
}