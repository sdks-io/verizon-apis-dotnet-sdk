// <copyright file="CallbackRegistrationResult.cs" company="APIMatic">
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
    /// CallbackRegistrationResult.
    /// </summary>
    public class CallbackRegistrationResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackRegistrationResult"/> class.
        /// </summary>
        public CallbackRegistrationResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackRegistrationResult"/> class.
        /// </summary>
        /// <param name="account">account.</param>
        /// <param name="name">name.</param>
        public CallbackRegistrationResult(
            string account = null,
            Models.CallbackServiceNameEnum? name = null)
        {
            this.Account = account;
            this.Name = name;
        }

        /// <summary>
        /// The name of the account that registered the callback URL.
        /// </summary>
        [JsonProperty("account", NullValueHandling = NullValueHandling.Ignore)]
        public string Account { get; set; }

        /// <summary>
        /// The name of the callback service.
        /// </summary>
        [JsonProperty("name", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.CallbackServiceNameEnum? Name { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CallbackRegistrationResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is CallbackRegistrationResult other &&                ((this.Account == null && other.Account == null) || (this.Account?.Equals(other.Account) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Account = {(this.Account == null ? "null" : this.Account == string.Empty ? "" : this.Account)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name.ToString())}");
        }
    }
}