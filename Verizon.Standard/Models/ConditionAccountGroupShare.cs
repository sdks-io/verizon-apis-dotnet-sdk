// <copyright file="ConditionAccountGroupShare.cs" company="APIMatic">
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
    /// ConditionAccountGroupShare.
    /// </summary>
    public class ConditionAccountGroupShare
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionAccountGroupShare"/> class.
        /// </summary>
        public ConditionAccountGroupShare()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionAccountGroupShare"/> class.
        /// </summary>
        /// <param name="action">action.</param>
        public ConditionAccountGroupShare(
            string action = null)
        {
            this.Action = action;
        }

        /// <summary>
        /// Gets or sets Action.
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ConditionAccountGroupShare : ({string.Join(", ", toStringOutput)})";
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
            return obj is ConditionAccountGroupShare other &&                ((this.Action == null && other.Action == null) || (this.Action?.Equals(other.Action) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Action = {(this.Action == null ? "null" : this.Action)}");
        }
    }
}