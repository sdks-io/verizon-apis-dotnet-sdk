// <copyright file="FotaV2ResultException.cs" company="APIMatic">
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
    /// FotaV2ResultException.
    /// </summary>
    public class FotaV2ResultException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FotaV2ResultException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public FotaV2ResultException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// Code of the error.
        /// </summary>
        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Details of the error.
        /// </summary>
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }
    }
}