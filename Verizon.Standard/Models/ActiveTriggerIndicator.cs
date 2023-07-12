// <copyright file="ActiveTriggerIndicator.cs" company="APIMatic">
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
    /// ActiveTriggerIndicator.
    /// </summary>
    public class ActiveTriggerIndicator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveTriggerIndicator"/> class.
        /// </summary>
        public ActiveTriggerIndicator()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveTriggerIndicator"/> class.
        /// </summary>
        /// <param name="active">active.</param>
        public ActiveTriggerIndicator(
            bool? active = null)
        {
            this.Active = active;
        }

        /// <summary>
        /// Indicates if the trigger is active<br />True - trigger is active<br />False - trigger is not active.
        /// </summary>
        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ActiveTriggerIndicator : ({string.Join(", ", toStringOutput)})";
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
            return obj is ActiveTriggerIndicator other &&                ((this.Active == null && other.Active == null) || (this.Active?.Equals(other.Active) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Active = {(this.Active == null ? "null" : this.Active.ToString())}");
        }
    }
}