// <copyright file="OauthProviderException.cs" company="APIMatic">
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
using Verizon.Standard.Http.Client;
using Verizon.Standard.Models;
using Verizon.Standard.Utilities;

namespace Verizon.Standard.Exceptions
{
    /// <summary>
    /// OauthProviderException.
    /// </summary>
    public class OauthProviderException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OauthProviderException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public OauthProviderException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// Gets or sets error code.
        /// </summary>
        [JsonProperty("error")]
        public Models.OauthProviderErrorEnum Error { get; set; }

        /// <summary>
        /// Gets or sets human-readable text providing additional information on error.
        /// Used to assist the client developer in understanding the error that occurred.
        /// </summary>
        [JsonProperty("error_description", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorDescription { get; set; }

        /// <summary>
        /// Gets or sets a URI identifying a human-readable web page with information about the error, used to provide the client developer with additional information about the error.
        /// </summary>
        [JsonProperty("error_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorUri { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"OauthProviderException : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            base.ToString(toStringOutput);
            toStringOutput.Add($"Error = {this.Error}");
            toStringOutput.Add($"ErrorDescription = {this.ErrorDescription ?? "null"}");
            toStringOutput.Add($"ErrorUri = {this.ErrorUri ?? "null"}");
        }
    }
}