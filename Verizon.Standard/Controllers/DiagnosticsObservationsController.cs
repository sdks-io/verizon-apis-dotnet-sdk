// <copyright file="DiagnosticsObservationsController.cs" company="APIMatic">
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
    /// DiagnosticsObservationsController.
    /// </summary>
    public class DiagnosticsObservationsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticsObservationsController"/> class.
        /// </summary>
        internal DiagnosticsObservationsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// This endpoint allows the user to start or change observe diagnostics.
        /// </summary>
        /// <param name="body">Required parameter: Request for device observation information..</param>
        /// <returns>Returns the ApiResponse of Models.DiagnosticsObservationResult response from the API call.</returns>
        public ApiResponse<Models.DiagnosticsObservationResult> StartDiagnosticsObservation(
                Models.ObservationRequest body)
            => CoreHelper.RunTask(StartDiagnosticsObservationAsync(body));

        /// <summary>
        /// This endpoint allows the user to start or change observe diagnostics.
        /// </summary>
        /// <param name="body">Required parameter: Request for device observation information..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DiagnosticsObservationResult response from the API call.</returns>
        public async Task<ApiResponse<Models.DiagnosticsObservationResult>> StartDiagnosticsObservationAsync(
                Models.ObservationRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DiagnosticsObservationResult>()
              .Server(Server.DeviceDiagnostics)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/devices/attributes/actions/observe")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "*/*"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response.", (_reason, _context) => new DeviceDiagnosticsResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint allows the user to stop or reset observe diagnostics.
        /// </summary>
        /// <param name="transactionId">Required parameter: The ID value associated with the transaction..</param>
        /// <param name="accountName">Required parameter: The numeric account name..</param>
        /// <returns>Returns the ApiResponse of Models.DiagnosticsObservationResult response from the API call.</returns>
        public ApiResponse<Models.DiagnosticsObservationResult> StopDiagnosticsObservation(
                string transactionId,
                string accountName)
            => CoreHelper.RunTask(StopDiagnosticsObservationAsync(transactionId, accountName));

        /// <summary>
        /// This endpoint allows the user to stop or reset observe diagnostics.
        /// </summary>
        /// <param name="transactionId">Required parameter: The ID value associated with the transaction..</param>
        /// <param name="accountName">Required parameter: The numeric account name..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DiagnosticsObservationResult response from the API call.</returns>
        public async Task<ApiResponse<Models.DiagnosticsObservationResult>> StopDiagnosticsObservationAsync(
                string transactionId,
                string accountName,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DiagnosticsObservationResult>()
              .Server(Server.DeviceDiagnostics)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/devices/attributes/actions/observe")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("transactionId", transactionId))
                      .Query(_query => _query.Setup("accountName", accountName))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response.", (_reason, _context) => new DeviceDiagnosticsResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}