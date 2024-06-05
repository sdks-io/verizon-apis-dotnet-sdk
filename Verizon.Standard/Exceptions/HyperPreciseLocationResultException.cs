// <copyright file="HyperPreciseLocationResultException.cs" company="APIMatic">
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
    /// HyperPreciseLocationResultException.
    /// </summary>
    public class HyperPreciseLocationResultException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HyperPreciseLocationResultException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public HyperPreciseLocationResultException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// Error Code.
        /// </summary>
        [JsonProperty("responseCode", NullValueHandling = NullValueHandling.Ignore)]
        public new Models.ErrorResponseCodeEnum? ResponseCode { get; set; }

        /// <summary>
        /// Error message.
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public new string Message { get; set; }

        /// <summary>
        /// Fault occurred while responding.
        /// </summary>
        [JsonProperty("fault", NullValueHandling = NullValueHandling.Ignore)]
        public Models.HyperPreciseLocationFault Fault { get; set; }

        /// <summary>
        /// Gets or sets Example.
        /// </summary>
        [JsonProperty("example", NullValueHandling = NullValueHandling.Ignore)]
        public object Example { get; set; }
    }
}