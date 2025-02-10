// <copyright file="ActionAccountGroupShare.cs" company="APIMatic">
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
    /// ActionAccountGroupShare.
    /// </summary>
    public class ActionAccountGroupShare
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionAccountGroupShare"/> class.
        /// </summary>
        public ActionAccountGroupShare()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionAccountGroupShare"/> class.
        /// </summary>
        /// <param name="changePlan">changePlan.</param>
        public ActionAccountGroupShare(
            Models.ChangePlan changePlan = null)
        {
            this.ChangePlan = changePlan;
        }

        /// <summary>
        /// Gets or sets ChangePlan.
        /// </summary>
        [JsonProperty("changePlan", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ChangePlan ChangePlan { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ActionAccountGroupShare : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ActionAccountGroupShare other &&
                (this.ChangePlan == null && other.ChangePlan == null ||
                 this.ChangePlan?.Equals(other.ChangePlan) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ChangePlan = {(this.ChangePlan == null ? "null" : this.ChangePlan.ToString())}");
        }
    }
}