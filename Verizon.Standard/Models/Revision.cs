// <copyright file="Revision.cs" company="APIMatic">
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
    /// Revision.
    /// </summary>
    public class Revision
    {
        private List<Models.EdgeServiceLaunchParams> additionalParams;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "additionalParams", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Revision"/> class.
        /// </summary>
        public Revision()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Revision"/> class.
        /// </summary>
        /// <param name="version">version.</param>
        /// <param name="additionalParams">additionalParams.</param>
        public Revision(
            string version,
            List<Models.EdgeServiceLaunchParams> additionalParams = null)
        {
            this.Version = version;
            if (additionalParams != null)
            {
                this.AdditionalParams = additionalParams;
            }

        }

        /// <summary>
        /// Gets or sets Version.
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets AdditionalParams.
        /// </summary>
        [JsonProperty("additionalParams")]
        public List<Models.EdgeServiceLaunchParams> AdditionalParams
        {
            get
            {
                return this.additionalParams;
            }

            set
            {
                this.shouldSerialize["additionalParams"] = true;
                this.additionalParams = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Revision : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAdditionalParams()
        {
            this.shouldSerialize["additionalParams"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAdditionalParams()
        {
            return this.shouldSerialize["additionalParams"];
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
            return obj is Revision other &&                ((this.Version == null && other.Version == null) || (this.Version?.Equals(other.Version) == true)) &&
                ((this.AdditionalParams == null && other.AdditionalParams == null) || (this.AdditionalParams?.Equals(other.AdditionalParams) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Version = {(this.Version == null ? "null" : this.Version == string.Empty ? "" : this.Version)}");
            toStringOutput.Add($"this.AdditionalParams = {(this.AdditionalParams == null ? "null" : $"[{string.Join(", ", this.AdditionalParams)} ]")}");
        }
    }
}