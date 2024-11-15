// <copyright file="EdgePerformanceResultException.cs" company="APIMatic">
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
    /// EdgePerformanceResultException.
    /// </summary>
    public class EdgePerformanceResultException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgePerformanceResultException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public EdgePerformanceResultException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// HTTP status code.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Error details.
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public new string Message { get; set; }
    }
}