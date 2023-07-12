// <copyright file="ObservabilityTemplate.cs" company="APIMatic">
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
    /// ObservabilityTemplate.
    /// </summary>
    public class ObservabilityTemplate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObservabilityTemplate"/> class.
        /// </summary>
        public ObservabilityTemplate()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObservabilityTemplate"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        public ObservabilityTemplate(
            string id = null)
        {
            this.Id = id;
        }

        /// <summary>
        /// Auto generated id of the observabilityTemplate spec file uploaded.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ObservabilityTemplate : ({string.Join(", ", toStringOutput)})";
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
            return obj is ObservabilityTemplate other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
        }
    }
}