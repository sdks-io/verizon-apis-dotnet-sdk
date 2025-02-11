// <copyright file="LogOutRequest.cs" company="APIMatic">
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
    /// LogOutRequest.
    /// </summary>
    public class LogOutRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogOutRequest"/> class.
        /// </summary>
        public LogOutRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogOutRequest"/> class.
        /// </summary>
        /// <param name="sessionToken">sessionToken.</param>
        public LogOutRequest(
            string sessionToken = null)
        {
            this.SessionToken = sessionToken;
        }

        /// <summary>
        /// The session token is returned to confirm that it was invalidated.
        /// </summary>
        [JsonProperty("sessionToken", NullValueHandling = NullValueHandling.Ignore)]
        public string SessionToken { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"LogOutRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is LogOutRequest other &&
                (this.SessionToken == null && other.SessionToken == null ||
                 this.SessionToken?.Equals(other.SessionToken) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"SessionToken = {this.SessionToken ?? "null"}");
        }
    }
}