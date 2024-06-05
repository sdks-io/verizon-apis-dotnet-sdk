// <copyright file="DiagnosticsFactoryResetController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Verizon.Standard.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using APIMatic.Core;
    using APIMatic.Core.Types;
    using APIMatic.Core.Utilities;
    using APIMatic.Core.Utilities.Date.Xml;
    using Newtonsoft.Json.Converters;
    using System.Net.Http;
    using Verizon.Standard;
    using Verizon.Standard.Exceptions;
    using Verizon.Standard.Http.Client;
    using Verizon.Standard.Http.Response;
    using Verizon.Standard.Utilities;

    /// <summary>
    /// DiagnosticsFactoryResetController.
    /// </summary>
    public class DiagnosticsFactoryResetController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticsFactoryResetController"/> class.
        /// </summary>
        internal DiagnosticsFactoryResetController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Performs a device reboot or a factory reset on the modem portion of the device.
        /// </summary>
        /// <param name="body">Required parameter: A request to perform a device reboot..</param>
        /// <returns>Returns the ApiResponse of Models.DiagnosticsObservationResult response from the API call.</returns>
        public ApiResponse<Models.DiagnosticsObservationResult> DecivesRestart(
                Models.DeviceResetRequest body)
            => CoreHelper.RunTask(DecivesRestartAsync(body));

        /// <summary>
        /// Performs a device reboot or a factory reset on the modem portion of the device.
        /// </summary>
        /// <param name="body">Required parameter: A request to perform a device reboot..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DiagnosticsObservationResult response from the API call.</returns>
        public async Task<ApiResponse<Models.DiagnosticsObservationResult>> DecivesRestartAsync(
                Models.DeviceResetRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DiagnosticsObservationResult>()
              .Server(Server.DeviceDiagnostics)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/devices/actions/restart")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response.", (_reason, _context) => new DeviceDiagnosticsResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}