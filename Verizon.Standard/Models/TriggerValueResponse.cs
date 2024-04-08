// <copyright file="TriggerValueResponse.cs" company="APIMatic">
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
    /// TriggerValueResponse.
    /// </summary>
    public class TriggerValueResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerValueResponse"/> class.
        /// </summary>
        public TriggerValueResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerValueResponse"/> class.
        /// </summary>
        /// <param name="triggers">triggers.</param>
        public TriggerValueResponse(
            List<Models.Triggervalues> triggers = null)
        {
            this.Triggers = triggers;
        }

        /// <summary>
        /// Gets or sets Triggers.
        /// </summary>
        [JsonProperty("triggers", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Triggervalues> Triggers { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TriggerValueResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is TriggerValueResponse other &&                ((this.Triggers == null && other.Triggers == null) || (this.Triggers?.Equals(other.Triggers) == true));
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