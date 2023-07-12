// <copyright file="FotaV3ResultException.cs" company="APIMatic">
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
    /// FotaV3ResultException.
    /// </summary>
    public class FotaV3ResultException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FotaV3ResultException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public FotaV3ResultException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// Error code string.
        /// </summary>
        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Error message string.
        /// </summary>
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }
    }
}