// <copyright file="CreateTargetRequestFields.cs" company="APIMatic">
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
    /// CreateTargetRequestFields.
    /// </summary>
    public class CreateTargetRequestFields
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTargetRequestFields"/> class.
        /// </summary>
        public CreateTargetRequestFields()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTargetRequestFields"/> class.
        /// </summary>
        /// <param name="httpheaders">httpheaders.</param>
        /// <param name="devicetypes">devicetypes.</param>
        public CreateTargetRequestFields(
            Models.FieldsHttpHeaders httpheaders = null,
            List<string> devicetypes = null)
        {
            this.Httpheaders = httpheaders;
            this.Devicetypes = devicetypes;
        }

        /// <summary>
        /// Gets or sets Httpheaders.
        /// </summary>
        [JsonProperty("httpheaders", NullValueHandling = NullValueHandling.Ignore)]
        public Models.FieldsHttpHeaders Httpheaders { get; set; }

        /// <summary>
        /// List of device types.
        /// </summary>
        [JsonProperty("devicetypes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Devicetypes { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateTargetRequestFields : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateTargetRequestFields other &&
                (this.Httpheaders == null && other.Httpheaders == null ||
                 this.Httpheaders?.Equals(other.Httpheaders) == true) &&
                (this.Devicetypes == null && other.Devicetypes == null ||
                 this.Devicetypes?.Equals(other.Devicetypes) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Httpheaders = {(this.Httpheaders == null ? "null" : this.Httpheaders.ToString())}");
            toStringOutput.Add($"Devicetypes = {(this.Devicetypes == null ? "null" : $"[{string.Join(", ", this.Devicetypes)} ]")}");
        }
    }
}