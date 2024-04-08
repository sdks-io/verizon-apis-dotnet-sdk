// <copyright file="SoftwareManagementCallbacksV3Controller.cs" company="APIMatic">
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
    /// SoftwareManagementCallbacksV3Controller.
    /// </summary>
    public class SoftwareManagementCallbacksV3Controller : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoftwareManagementCallbacksV3Controller"/> class.
        /// </summary>
        internal SoftwareManagementCallbacksV3Controller(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// This endpoint allows user to get the registered callback information.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <returns>Returns the ApiResponse of Models.FotaV3CallbackSummary response from the API call.</returns>
        public ApiResponse<Models.FotaV3CallbackSummary> ListRegisteredCallbacks(
                string acc)
            => CoreHelper.RunTask(ListRegisteredCallbacksAsync(acc));

        /// <summary>
        /// This endpoint allows user to get the registered callback information.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.FotaV3CallbackSummary response from the API call.</returns>
        public async Task<ApiResponse<Models.FotaV3CallbackSummary>> ListRegisteredCallbacksAsync(
                string acc,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.FotaV3CallbackSummary>()
              .Server(Server.SoftwareManagementV3)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/callbacks/{acc}")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("acc", acc))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV3ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint allows the user to update the HTTPS callback address.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <param name="body">Required parameter: Callback URL registration..</param>
        /// <returns>Returns the ApiResponse of Models.FotaV3CallbackRegistrationResult response from the API call.</returns>
        public ApiResponse<Models.FotaV3CallbackRegistrationResult> UpdateCallback(
                string acc,
                Models.FotaV3CallbackRegistrationRequest body)
            => CoreHelper.RunTask(UpdateCallbackAsync(acc, body));

        /// <summary>
        /// This endpoint allows the user to update the HTTPS callback address.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <param name="body">Required parameter: Callback URL registration..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.FotaV3CallbackRegistrationResult response from the API call.</returns>
        public async Task<ApiResponse<Models.FotaV3CallbackRegistrationResult>> UpdateCallbackAsync(
                string acc,
                Models.FotaV3CallbackRegistrationRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.FotaV3CallbackRegistrationResult>()
              .Server(Server.SoftwareManagementV3)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/callbacks/{acc}")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("acc", acc))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV3ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint allows the user to create the HTTPS callback address.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <param name="body">Required parameter: Callback URL registration..</param>
        /// <returns>Returns the ApiResponse of Models.FotaV3CallbackRegistrationResult response from the API call.</returns>
        public ApiResponse<Models.FotaV3CallbackRegistrationResult> RegisterCallback(
                string acc,
                Models.FotaV3CallbackRegistrationRequest body)
            => CoreHelper.RunTask(RegisterCallbackAsync(acc, body));

        /// <summary>
        /// This endpoint allows the user to create the HTTPS callback address.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <param name="body">Required parameter: Callback URL registration..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.FotaV3CallbackRegistrationResult response from the API call.</returns>
        public async Task<ApiResponse<Models.FotaV3CallbackRegistrationResult>> RegisterCallbackAsync(
                string acc,
                Models.FotaV3CallbackRegistrationRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.FotaV3CallbackRegistrationResult>()
              .Server(Server.SoftwareManagementV3)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/callbacks/{acc}")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("acc", acc))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV3ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint allows user to delete a previously registered callback URL.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <returns>Returns the ApiResponse of Models.FotaV3SuccessResult response from the API call.</returns>
        public ApiResponse<Models.FotaV3SuccessResult> DeregisterCallback(
                string acc)
            => CoreHelper.RunTask(DeregisterCallbackAsync(acc));

        /// <summary>
        /// This endpoint allows user to delete a previously registered callback URL.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.FotaV3SuccessResult response from the API call.</returns>
        public async Task<ApiResponse<Models.FotaV3SuccessResult>> DeregisterCallbackAsync(
                string acc,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.FotaV3SuccessResult>()
              .Server(Server.SoftwareManagementV3)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/callbacks/{acc}")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("acc", acc))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV3ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}