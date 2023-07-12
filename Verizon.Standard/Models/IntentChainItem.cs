// <copyright file="IntentChainItem.cs" company="APIMatic">
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
    /// IntentChainItem.
    /// </summary>
    public class IntentChainItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntentChainItem"/> class.
        /// </summary>
        public IntentChainItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntentChainItem"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="input">input.</param>
        public IntentChainItem(
            string name = null,
            object input = null)
        {
            this.Name = name;
            this.Input = input;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Input.
        /// </summary>
        [JsonProperty("input", NullValueHandling = NullValueHandling.Ignore)]
        public object Input { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"IntentChainItem : ({string.Join(", ", toStringOutput)})";
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
            return obj is IntentChainItem other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Input == null && other.Input == null) || (this.Input?.Equals(other.Input) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"Input = {(this.Input == null ? "null" : this.Input.ToString())}");
        }
    }
}