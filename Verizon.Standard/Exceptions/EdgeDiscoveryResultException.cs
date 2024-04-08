// <copyright file="EdgeDiscoveryResultException.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Verizon.Standard.Exceptions
{
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

    /// <summary>
    /// EdgeDiscoveryResultException.
    /// </summary>
    public class EdgeDiscoveryResultException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeDiscoveryResultException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public EdgeDiscoveryResultException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// HTTP status code or status of response.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Error details.
        /// </summary>
        [JsonProperty("message")]
        public new string Message { get; set; }

        /// <summary>
        /// For cases where user input exceeds the boundary values an additional 'data' key will be returned with a relevant description.
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public new Models.EdgeDiscoveryResultData Data { get; set; }
    }
}