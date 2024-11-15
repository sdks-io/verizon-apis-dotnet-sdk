// <copyright file="DeviceLocationResultException.cs" company="APIMatic">
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
    /// DeviceLocationResultException.
    /// </summary>
    public class DeviceLocationResultException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceLocationResultException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public DeviceLocationResultException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// Gets or sets ErrorCode.
        /// </summary>
        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Gets or sets ErrorMessage.
        /// </summary>
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }
    }
}