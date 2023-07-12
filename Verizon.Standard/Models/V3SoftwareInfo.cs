// <copyright file="V3SoftwareInfo.cs" company="APIMatic">
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
    /// V3SoftwareInfo.
    /// </summary>
    public class V3SoftwareInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V3SoftwareInfo"/> class.
        /// </summary>
        public V3SoftwareInfo()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V3SoftwareInfo"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="version">version.</param>
        /// <param name="upgradeTime">upgradeTime.</param>
        public V3SoftwareInfo(
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

            return $"V3SoftwareInfo : ({string.Join(", ", toStringOutput)})";
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
            return obj is V3SoftwareInfo other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Version == null && other.Version == null) || (this.Version?.Equals(other.Version) == true)) &&
                ((this.UpgradeTime == null && other.UpgradeTime == null) || (this.UpgradeTime?.Equals(other.UpgradeTime) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.Version = {(this.Version == null ? "null" : this.Version == string.Empty ? "" : this.Version)}");
            toStringOutput.Add($"this.UpgradeTime = {(this.UpgradeTime == null ? "null" : this.UpgradeTime == string.Empty ? "" : this.UpgradeTime)}");
        }
    }
}