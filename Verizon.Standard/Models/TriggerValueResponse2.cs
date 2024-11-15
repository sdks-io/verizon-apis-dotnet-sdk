// <copyright file="TriggerValueResponse2.cs" company="APIMatic">
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
    /// TriggerValueResponse2.
    /// </summary>
    public class TriggerValueResponse2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerValueResponse2"/> class.
        /// </summary>
        public TriggerValueResponse2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerValueResponse2"/> class.
        /// </summary>
        /// <param name="triggers">triggers.</param>
        public TriggerValueResponse2(
            List<Models.Triggervalues2> triggers = null)
        {
            this.Triggers = triggers;
        }

        /// <summary>
        /// Gets or sets Triggers.
        /// </summary>
        [JsonProperty("triggers", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Triggervalues2> Triggers { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TriggerValueResponse2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is TriggerValueResponse2 other &&                ((this.Triggers == null && other.Triggers == null) || (this.Triggers?.Equals(other.Triggers) == true));
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