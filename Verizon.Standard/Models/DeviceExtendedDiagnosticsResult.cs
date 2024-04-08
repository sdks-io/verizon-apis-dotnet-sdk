// <copyright file="DeviceExtendedDiagnosticsResult.cs" company="APIMatic">
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
    /// DeviceExtendedDiagnosticsResult.
    /// </summary>
    public class DeviceExtendedDiagnosticsResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceExtendedDiagnosticsResult"/> class.
        /// </summary>
        public DeviceExtendedDiagnosticsResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceExtendedDiagnosticsResult"/> class.
        /// </summary>
        /// <param name="categories">categories.</param>
        public DeviceExtendedDiagnosticsResult(
            List<Models.DiagnosticsCategory> categories = null)
        {
            this.Categories = categories;
        }

        /// <summary>
        /// The response includes various types of information about the device, grouped into categories. Each category object contains the category name and a list of Extended Attribute objects as key-value pairs.
        /// </summary>
        [JsonProperty("categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DiagnosticsCategory> Categories { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeviceExtendedDiagnosticsResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is DeviceExtendedDiagnosticsResult other &&                ((this.Categories == null && other.Categories == null) || (this.Categories?.Equals(other.Categories) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Categories = {(this.Categories == null ? "null" : $"[{string.Join(", ", this.Categories)} ]")}");
        }
    }
}