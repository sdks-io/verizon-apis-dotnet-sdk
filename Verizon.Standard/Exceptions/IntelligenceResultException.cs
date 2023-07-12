// <copyright file="IntelligenceResultException.cs" company="APIMatic">
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
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Verizon.Standard;
    using Verizon.Standard.Http.Client;
    using Verizon.Standard.Models;
    using Verizon.Standard.Utilities;

    /// <summary>
    /// IntelligenceResultException.
    /// </summary>
    public class IntelligenceResultException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntelligenceResultException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public IntelligenceResultException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// The 3-digit HTML error code.
        /// </summary>
        [JsonProperty("errorCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Error Message.
        /// </summary>
        [JsonProperty("errorMessage", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMessage { get; set; }
    }
}