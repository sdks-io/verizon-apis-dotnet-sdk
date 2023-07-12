// <copyright file="ServiceLaunchClusterAdditionalParams.cs" company="APIMatic">
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
    /// ServiceLaunchClusterAdditionalParams.
    /// </summary>
    public class ServiceLaunchClusterAdditionalParams
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceLaunchClusterAdditionalParams"/> class.
        /// </summary>
        public ServiceLaunchClusterAdditionalParams()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceLaunchClusterAdditionalParams"/> class.
        /// </summary>
        /// <param name="additionalProperties">additionalProperties.</param>
        public ServiceLaunchClusterAdditionalParams(
            object additionalProperties = null)
        {
            this.AdditionalProperties = additionalProperties;
        }

        /// <summary>
        /// Gets or sets AdditionalProperties.
        /// </summary>
        [JsonProperty("additionalProperties", NullValueHandling = NullValueHandling.Ignore)]
        public object AdditionalProperties { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServiceLaunchClusterAdditionalParams : ({string.Join(", ", toStringOutput)})";
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
            return obj is ServiceLaunchClusterAdditionalParams other &&                ((this.AdditionalProperties == null && other.AdditionalProperties == null) || (this.AdditionalProperties?.Equals(other.AdditionalProperties) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AdditionalProperties = {(this.AdditionalProperties == null ? "null" : this.AdditionalProperties.ToString())}");
        }
    }
}