// <copyright file="Condition.cs" company="APIMatic">
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
    /// Condition.
    /// </summary>
    public class Condition
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Condition"/> class.
        /// </summary>
        public Condition()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Condition"/> class.
        /// </summary>
        /// <param name="conditionProp">condition.</param>
        public Condition(
            List<Models.Keyschunk2> conditionProp = null)
        {
            this.ConditionProp = conditionProp;
        }

        /// <summary>
        /// Gets or sets ConditionProp.
        /// </summary>
        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Keyschunk2> ConditionProp { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Condition : ({string.Join(", ", toStringOutput)})";
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
            return obj is Condition other &&                ((this.ConditionProp == null && other.ConditionProp == null) || (this.ConditionProp?.Equals(other.ConditionProp) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ConditionProp = {(this.ConditionProp == null ? "null" : $"[{string.Join(", ", this.ConditionProp)} ]")}");
        }
    }
}