// <copyright file="DeviceLocationCallbacksController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
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

namespace Verizon.Standard.Controllers
{
    /// <summary>
    /// DeviceLocationCallbacksController.
    /// </summary>
    public class DeviceLocationCallbacksController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceLocationCallbacksController"/> class.
        /// </summary>
        internal DeviceLocationCallbacksController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Cancel an asynchronous report request.
        /// </summary>
        /// <param name="accountName">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="txid">Required parameter: The `transactionId` value..</param>
        /// <returns>Returns the ApiResponse of Models.TransactionID response from the API call.</returns>
        public ApiResponse<Models.TransactionID> CancelAsyncReport(
                string accountName,
                string txid)
            => CoreHelper.RunTask(CancelAsyncReportAsync(accountName, txid));

        /// <summary>
        /// Cancel an asynchronous report request.
        /// </summary>
        /// <param name="accountName">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="txid">Required parameter: The `transactionId` value..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.TransactionID response from the API call.</returns>
        public async Task<ApiResponse<Models.TransactionID>> CancelAsyncReportAsync(
                string accountName,
                string txid,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TransactionID>()
              .Server(Server.DeviceLocation)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/devicelocations/{txid}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("accountName", accountName))
                      .Template(_template => _template.Setup("txid", txid))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Unexpected error.", (_reason, _context) => new DeviceLocationResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns a list of all registered callback URLs for the account.
        /// </summary>
        /// <param name="accountName">Required parameter: Account number..</param>
        /// <returns>Returns the ApiResponse of List&lt;Models.DeviceLocationCallback&gt; response from the API call.</returns>
        public ApiResponse<List<Models.DeviceLocationCallback>> ListRegisteredCallbacks(
                string accountName)
            => CoreHelper.RunTask(ListRegisteredCallbacksAsync(accountName));

        /// <summary>
        /// Returns a list of all registered callback URLs for the account.
        /// </summary>
        /// <param name="accountName">Required parameter: Account number..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List&lt;Models.DeviceLocationCallback&gt; response from the API call.</returns>
        public async Task<ApiResponse<List<Models.DeviceLocationCallback>>> ListRegisteredCallbacksAsync(
                string accountName,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.DeviceLocationCallback>>()
              .Server(Server.DeviceLocation)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/callbacks/{accountName}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("accountName", accountName))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new DeviceLocationResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Provide a URL to receive messages from a ThingSpace callback service.
        /// </summary>
        /// <param name="accountName">Required parameter: Account number..</param>
        /// <param name="body">Required parameter: Request to register a callback..</param>
        /// <returns>Returns the ApiResponse of Models.CallbackRegistrationResult response from the API call.</returns>
        public ApiResponse<Models.CallbackRegistrationResult> RegisterCallback(
                string accountName,
                Models.DeviceLocationCallback body)
            => CoreHelper.RunTask(RegisterCallbackAsync(accountName, body));

        /// <summary>
        /// Provide a URL to receive messages from a ThingSpace callback service.
        /// </summary>
        /// <param name="accountName">Required parameter: Account number..</param>
        /// <param name="body">Required parameter: Request to register a callback..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.CallbackRegistrationResult response from the API call.</returns>
        public async Task<ApiResponse<Models.CallbackRegistrationResult>> RegisterCallbackAsync(
                string accountName,
                Models.DeviceLocationCallback body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CallbackRegistrationResult>()
              .Server(Server.DeviceLocation)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/callbacks/{accountName}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("accountName", accountName))
                      .Header(_header => _header.Setup("Content-Type", "*/*"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new DeviceLocationResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Deregister a URL to stop receiving callback messages.
        /// </summary>
        /// <param name="accountName">Required parameter: Account number..</param>
        /// <param name="service">Required parameter: Callback service name..</param>
        /// <returns>Returns the ApiResponse of Models.DeviceLocationSuccessResult response from the API call.</returns>
        public ApiResponse<Models.DeviceLocationSuccessResult> DeregisterCallback(
                string accountName,
                Models.CallbackServiceNameEnum service)
            => CoreHelper.RunTask(DeregisterCallbackAsync(accountName, service));

        /// <summary>
        /// Deregister a URL to stop receiving callback messages.
        /// </summary>
        /// <param name="accountName">Required parameter: Account number..</param>
        /// <param name="service">Required parameter: Callback service name..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeviceLocationSuccessResult response from the API call.</returns>
        public async Task<ApiResponse<Models.DeviceLocationSuccessResult>> DeregisterCallbackAsync(
                string accountName,
                Models.CallbackServiceNameEnum service,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeviceLocationSuccessResult>()
              .Server(Server.DeviceLocation)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/callbacks/{accountName}/name/{service}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("accountName", accountName))
                      .Template(_template => _template.Setup("service", ApiHelper.JsonSerialize(service).Trim('\"')))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new DeviceLocationResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}