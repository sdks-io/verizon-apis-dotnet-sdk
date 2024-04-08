// <copyright file="DiagnosticsCallbacksController.cs" company="APIMatic">
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
    /// DiagnosticsCallbacksController.
    /// </summary>
    public class DiagnosticsCallbacksController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticsCallbacksController"/> class.
        /// </summary>
        internal DiagnosticsCallbacksController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// This endpoint allows user to get the registered callback information of an existing diagnostics subscription.
        /// </summary>
        /// <param name="accountName">Required parameter: Account identifier..</param>
        /// <returns>Returns the ApiResponse of List<Models.DeviceDiagnosticsCallback> response from the API call.</returns>
        public ApiResponse<List<Models.DeviceDiagnosticsCallback>> GetDiagnosticsSubscriptionCallbackInfo(
                string accountName)
            => CoreHelper.RunTask(GetDiagnosticsSubscriptionCallbackInfoAsync(accountName));

        /// <summary>
        /// This endpoint allows user to get the registered callback information of an existing diagnostics subscription.
        /// </summary>
        /// <param name="accountName">Required parameter: Account identifier..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List<Models.DeviceDiagnosticsCallback> response from the API call.</returns>
        public async Task<ApiResponse<List<Models.DeviceDiagnosticsCallback>>> GetDiagnosticsSubscriptionCallbackInfoAsync(
                string accountName,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.DeviceDiagnosticsCallback>>()
              .Server(Server.DeviceDiagnostics)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/callbacks")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("accountName", accountName))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new DeviceDiagnosticsResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint allows user update the callback HTTPS address of an existing diagnostics subscription.
        /// </summary>
        /// <param name="body">Required parameter: Callback URL registration request..</param>
        /// <returns>Returns the ApiResponse of Models.DeviceDiagnosticsCallback response from the API call.</returns>
        public ApiResponse<Models.DeviceDiagnosticsCallback> RegisterDiagnosticsCallbackURL(
                Models.CallbackRegistrationRequest body)
            => CoreHelper.RunTask(RegisterDiagnosticsCallbackURLAsync(body));

        /// <summary>
        /// This endpoint allows user update the callback HTTPS address of an existing diagnostics subscription.
        /// </summary>
        /// <param name="body">Required parameter: Callback URL registration request..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeviceDiagnosticsCallback response from the API call.</returns>
        public async Task<ApiResponse<Models.DeviceDiagnosticsCallback>> RegisterDiagnosticsCallbackURLAsync(
                Models.CallbackRegistrationRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeviceDiagnosticsCallback>()
              .Server(Server.DeviceDiagnostics)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/callbacks")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "*/*"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new DeviceDiagnosticsResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint allows user to delete a registered callback URL and credential.
        /// </summary>
        /// <param name="accountName">Required parameter: Account identifier..</param>
        /// <param name="serviceName">Required parameter: Service name for callback notification..</param>
        /// <returns>Returns the ApiResponse of Models.DeviceDiagnosticsCallback response from the API call.</returns>
        public ApiResponse<Models.DeviceDiagnosticsCallback> UnregisterDiagnosticsCallback(
                string accountName,
                string serviceName)
            => CoreHelper.RunTask(UnregisterDiagnosticsCallbackAsync(accountName, serviceName));

        /// <summary>
        /// This endpoint allows user to delete a registered callback URL and credential.
        /// </summary>
        /// <param name="accountName">Required parameter: Account identifier..</param>
        /// <param name="serviceName">Required parameter: Service name for callback notification..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeviceDiagnosticsCallback response from the API call.</returns>
        public async Task<ApiResponse<Models.DeviceDiagnosticsCallback>> UnregisterDiagnosticsCallbackAsync(
                string accountName,
                string serviceName,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeviceDiagnosticsCallback>()
              .Server(Server.DeviceDiagnostics)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/callbacks")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("accountName", accountName))
                      .Query(_query => _query.Setup("serviceName", serviceName))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new DeviceDiagnosticsResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}