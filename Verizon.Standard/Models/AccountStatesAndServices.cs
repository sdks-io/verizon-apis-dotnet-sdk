// <copyright file="AccountStatesAndServices.cs" company="APIMatic">
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
    /// AccountStatesAndServices.
    /// </summary>
    public class AccountStatesAndServices
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountStatesAndServices"/> class.
        /// </summary>
        public AccountStatesAndServices()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountStatesAndServices"/> class.
        /// </summary>
        /// <param name="engagement">engagement.</param>
        public AccountStatesAndServices(
            List<Models.Engagement> engagement)
        {
            this.Engagement = engagement;
        }

        /// <summary>
        /// The engagements associated with the account.
        /// </summary>
        [JsonProperty("engagement")]
        public List<Models.Engagement> Engagement { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AccountStatesAndServices : ({string.Join(", ", toStringOutput)})";
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
            return obj is AccountStatesAndServices other &&                ((this.Engagement == null && other.Engagement == null) || (this.Engagement?.Equals(other.Engagement) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Engagement = {(this.Engagement == null ? "null" : $"[{string.Join(", ", this.Engagement)} ]")}");
        }
    }
}