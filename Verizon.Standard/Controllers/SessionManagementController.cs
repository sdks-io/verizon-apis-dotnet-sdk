// <copyright file="SessionManagementController.cs" company="APIMatic">
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
    using Verizon.Standard.Authentication;
    using Verizon.Standard.Exceptions;
    using Verizon.Standard.Http.Client;
    using Verizon.Standard.Http.Response;
    using Verizon.Standard.Utilities;

    /// <summary>
    /// SessionManagementController.
    /// </summary>
    public class SessionManagementController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionManagementController"/> class.
        /// </summary>
        internal SessionManagementController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// The new password is effective immediately. Passwords do not expire, but Verizon recommends changing your password every 90 days.
        /// </summary>
        /// <param name="body">Required parameter: Request with current password that needs to be reset..</param>
        /// <returns>Returns the ApiResponse of Models.SessionResetPasswordResult response from the API call.</returns>
        public ApiResponse<Models.SessionResetPasswordResult> ResetConnectivityManagementPassword(
                Models.SessionResetPasswordRequest body)
            => CoreHelper.RunTask(ResetConnectivityManagementPasswordAsync(body));

        /// <summary>
        /// The new password is effective immediately. Passwords do not expire, but Verizon recommends changing your password every 90 days.
        /// </summary>
        /// <param name="body">Required parameter: Request with current password that needs to be reset..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.SessionResetPasswordResult response from the API call.</returns>
        public async Task<ApiResponse<Models.SessionResetPasswordResult>> ResetConnectivityManagementPasswordAsync(
                Models.SessionResetPasswordRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SessionResetPasswordResult>()
              .Server(Server.M2m)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/v1/session/password/actions/reset")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.SessionResetPasswordResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Initiates a Connectivity Management session and returns a VZ-M2M session token that is required in subsequent API requests.
        /// </summary>
        /// <param name="body">Optional parameter: Request to initiate a session..</param>
        /// <returns>Returns the ApiResponse of Models.LogInResult response from the API call.</returns>
        public ApiResponse<Models.LogInResult> StartConnectivityManagementSession(
                Models.LogInRequest body = null)
            => CoreHelper.RunTask(StartConnectivityManagementSessionAsync(body));

        /// <summary>
        /// Initiates a Connectivity Management session and returns a VZ-M2M session token that is required in subsequent API requests.
        /// </summary>
        /// <param name="body">Optional parameter: Request to initiate a session..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.LogInResult response from the API call.</returns>
        public async Task<ApiResponse<Models.LogInResult>> StartConnectivityManagementSessionAsync(
                Models.LogInRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.LogInResult>()
              .Server(Server.M2m)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/session/login")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.LogInResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Ends a Connectivity Management session.
        /// </summary>
        /// <returns>Returns the ApiResponse of Models.LogOutRequest response from the API call.</returns>
        public ApiResponse<Models.LogOutRequest> EndConnectivityManagementSession()
            => CoreHelper.RunTask(EndConnectivityManagementSessionAsync());

        /// <summary>
        /// Ends a Connectivity Management session.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.LogOutRequest response from the API call.</returns>
        public async Task<ApiResponse<Models.LogOutRequest>> EndConnectivityManagementSessionAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.LogOutRequest>()
              .Server(Server.M2m)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/session/logout")
                  .WithAuth("global"))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.LogOutRequest>(_response)))
              .ExecuteAsync(cancellationToken);
    }
}