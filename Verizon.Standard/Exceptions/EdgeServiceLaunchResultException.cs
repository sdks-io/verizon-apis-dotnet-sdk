// <copyright file="EdgeServiceLaunchResultException.cs" company="APIMatic">
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
    /// EdgeServiceLaunchResultException.
    /// </summary>
    public class EdgeServiceLaunchResultException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeServiceLaunchResultException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public EdgeServiceLaunchResultException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// Gets or sets Code.
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets Message.
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public new string Message { get; set; }

        /// <summary>
        /// Gets or sets RemedyMessage.
        /// </summary>
        [JsonProperty("remedyMessage", NullValueHandling = NullValueHandling.Ignore)]
        public string RemedyMessage { get; set; }
    }
}