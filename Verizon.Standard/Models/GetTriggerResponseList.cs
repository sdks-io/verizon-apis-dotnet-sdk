// <copyright file="GetTriggerResponseList.cs" company="APIMatic">
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
    /// GetTriggerResponseList.
    /// </summary>
    public class GetTriggerResponseList
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTriggerResponseList"/> class.
        /// </summary>
        public GetTriggerResponseList()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTriggerResponseList"/> class.
        /// </summary>
        /// <param name="triggers">triggers.</param>
        public GetTriggerResponseList(
            List<Models.GetTriggerResponse> triggers = null)
        {
            this.Triggers = triggers;
        }

        /// <summary>
        /// Gets or sets Triggers.
        /// </summary>
        [JsonProperty("triggers", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.GetTriggerResponse> Triggers { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetTriggerResponseList : ({string.Join(", ", toStringOutput)})";
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
            return obj is GetTriggerResponseList other &&                ((this.Triggers == null && other.Triggers == null) || (this.Triggers?.Equals(other.Triggers) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Triggers = {(this.Triggers == null ? "null" : $"[{string.Join(", ", this.Triggers)} ]")}");
        }
    }
}