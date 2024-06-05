// <copyright file="SoftwareManagementCallbacksV2Controller.cs" company="APIMatic">
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
    /// SoftwareManagementCallbacksV2Controller.
    /// </summary>
    public class SoftwareManagementCallbacksV2Controller : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoftwareManagementCallbacksV2Controller"/> class.
        /// </summary>
        internal SoftwareManagementCallbacksV2Controller(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// This endpoint allows user to get the registered callback information.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <returns>Returns the ApiResponse of Models.CallbackSummary response from the API call.</returns>
        public ApiResponse<Models.CallbackSummary> ListRegisteredCallbacks(
                string account)
            => CoreHelper.RunTask(ListRegisteredCallbacksAsync(account));

        /// <summary>
        /// This endpoint allows user to get the registered callback information.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.CallbackSummary response from the API call.</returns>
        public async Task<ApiResponse<Models.CallbackSummary>> ListRegisteredCallbacksAsync(
                string account,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CallbackSummary>()
              .Server(Server.SoftwareManagementV2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/callbacks/{account}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("account", account))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV2ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint allows user to update the HTTPS callback address.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="body">Required parameter: Callback URL registration..</param>
        /// <returns>Returns the ApiResponse of Models.FotaV2CallbackRegistrationResult response from the API call.</returns>
        public ApiResponse<Models.FotaV2CallbackRegistrationResult> UpdateCallback(
                string account,
                Models.FotaV2CallbackRegistrationRequest body)
            => CoreHelper.RunTask(UpdateCallbackAsync(account, body));

        /// <summary>
        /// This endpoint allows user to update the HTTPS callback address.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="body">Required parameter: Callback URL registration..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.FotaV2CallbackRegistrationResult response from the API call.</returns>
        public async Task<ApiResponse<Models.FotaV2CallbackRegistrationResult>> UpdateCallbackAsync(
                string account,
                Models.FotaV2CallbackRegistrationRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.FotaV2CallbackRegistrationResult>()
              .Server(Server.SoftwareManagementV2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/callbacks/{account}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("account", account))
                      .Header(_header => _header.Setup("Content-Type", "*/*"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV2ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint allows user to create the HTTPS callback address.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="body">Required parameter: Callback URL registration..</param>
        /// <returns>Returns the ApiResponse of Models.FotaV2CallbackRegistrationResult response from the API call.</returns>
        public ApiResponse<Models.FotaV2CallbackRegistrationResult> RegisterCallback(
                string account,
                Models.FotaV2CallbackRegistrationRequest body)
            => CoreHelper.RunTask(RegisterCallbackAsync(account, body));

        /// <summary>
        /// This endpoint allows user to create the HTTPS callback address.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="body">Required parameter: Callback URL registration..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.FotaV2CallbackRegistrationResult response from the API call.</returns>
        public async Task<ApiResponse<Models.FotaV2CallbackRegistrationResult>> RegisterCallbackAsync(
                string account,
                Models.FotaV2CallbackRegistrationRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.FotaV2CallbackRegistrationResult>()
              .Server(Server.SoftwareManagementV2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/callbacks/{account}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("account", account))
                      .Header(_header => _header.Setup("Content-Type", "*/*"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV2ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint allows user to delete a previously registered callback URL.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <returns>Returns the ApiResponse of Models.FotaV2SuccessResult response from the API call.</returns>
        public ApiResponse<Models.FotaV2SuccessResult> DeregisterCallback(
                string account)
            => CoreHelper.RunTask(DeregisterCallbackAsync(account));

        /// <summary>
        /// This endpoint allows user to delete a previously registered callback URL.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.FotaV2SuccessResult response from the API call.</returns>
        public async Task<ApiResponse<Models.FotaV2SuccessResult>> DeregisterCallbackAsync(
                string account,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.FotaV2SuccessResult>()
              .Server(Server.SoftwareManagementV2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/callbacks/{account}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("account", account))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV2ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}