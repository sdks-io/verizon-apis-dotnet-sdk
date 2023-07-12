// <copyright file="EdgeServiceOnboardingResultErrorException.cs" company="APIMatic">
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
    /// EdgeServiceOnboardingResultErrorException.
    /// </summary>
    public class EdgeServiceOnboardingResultErrorException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeServiceOnboardingResultErrorException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public EdgeServiceOnboardingResultErrorException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// Code of the error. eg: SDMS_000_000.
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// Brief description of the error in the form of a message.
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public new string Message { get; set; }

        /// <summary>
        /// Suggestion on how to fix the issue.
        /// </summary>
        [JsonProperty("remedyMessage", NullValueHandling = NullValueHandling.Ignore)]
        public string RemedyMessage { get; set; }
    }
}