// <copyright file="DeviceActionsController.cs" company="APIMatic">
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
    /// DeviceActionsController.
    /// </summary>
    public class DeviceActionsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceActionsController"/> class.
        /// </summary>
        internal DeviceActionsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Retrieve the aggregate usage for a device or a number of devices.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.GIORequestResponse response from the API call.</returns>
        public ApiResponse<Models.GIORequestResponse> AggregateUsage(
                Models.AggregateUsage body)
            => CoreHelper.RunTask(AggregateUsageAsync(body));

        /// <summary>
        /// Retrieve the aggregate usage for a device or a number of devices.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.GIORequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.GIORequestResponse>> AggregateUsageAsync(
                Models.AggregateUsage body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GIORequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/devices/usage/actions/list/aggregate")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new GIORestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieve the daily usage for a device, for a specified period of time, segmented by day.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.DailyUsageResponse response from the API call.</returns>
        public ApiResponse<Models.DailyUsageResponse> DailyUsage(
                Models.DailyUsage body)
            => CoreHelper.RunTask(DailyUsageAsync(body));

        /// <summary>
        /// Retrieve the daily usage for a device, for a specified period of time, segmented by day.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DailyUsageResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.DailyUsageResponse>> DailyUsageAsync(
                Models.DailyUsage body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DailyUsageResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/devices/usage/actions/list")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new GIORestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieve all of the service plans, features and carriers associated with the account specified.
        /// </summary>
        /// <param name="accountName">Required parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.AccountDetails response from the API call.</returns>
        public ApiResponse<Models.AccountDetails> ServicePlanList(
                string accountName)
            => CoreHelper.RunTask(ServicePlanListAsync(accountName));

        /// <summary>
        /// Retrieve all of the service plans, features and carriers associated with the account specified.
        /// </summary>
        /// <param name="accountName">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.AccountDetails response from the API call.</returns>
        public async Task<ApiResponse<Models.AccountDetails>> ServicePlanListAsync(
                string accountName,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AccountDetails>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/plans/{accountName}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("accountName", accountName))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new GIORestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieve all of the service plans, features and carriers associated with the account specified.
        /// </summary>
        /// <param name="accountName">Required parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.AccountDetails response from the API call.</returns>
        public ApiResponse<Models.AccountDetails> AccountInformation(
                string accountName)
            => CoreHelper.RunTask(AccountInformationAsync(accountName));

        /// <summary>
        /// Retrieve all of the service plans, features and carriers associated with the account specified.
        /// </summary>
        /// <param name="accountName">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.AccountDetails response from the API call.</returns>
        public async Task<ApiResponse<Models.AccountDetails>> AccountInformationAsync(
                string accountName,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AccountDetails>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/accounts/{accountName}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("accountName", accountName))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new GIORestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Allows the profile to fetch the complete device list. This works with Verizon US and Global profiles.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <returns>Returns the ApiResponse of Models.GIORequestResponse response from the API call.</returns>
        public ApiResponse<Models.GIORequestResponse> RetrieveTheGlobalDeviceList(
                Models.GetDeviceListWithProfilesRequest body)
            => CoreHelper.RunTask(RetrieveTheGlobalDeviceListAsync(body));

        /// <summary>
        /// Allows the profile to fetch the complete device list. This works with Verizon US and Global profiles.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.GIORequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.GIORequestResponse>> RetrieveTheGlobalDeviceListAsync(
                Models.GetDeviceListWithProfilesRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GIORequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v2/devices/actions/list")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new GIORestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieve the provisioning history of a specific device or devices.
        /// </summary>
        /// <param name="body">Required parameter: Device Provisioning History.</param>
        /// <returns>Returns the ApiResponse of Models.GIORequestResponse response from the API call.</returns>
        public ApiResponse<Models.GIORequestResponse> RetrieveDeviceProvisioningHistory(
                Models.ProvhistoryRequest body)
            => CoreHelper.RunTask(RetrieveDeviceProvisioningHistoryAsync(body));

        /// <summary>
        /// Retrieve the provisioning history of a specific device or devices.
        /// </summary>
        /// <param name="body">Required parameter: Device Provisioning History.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.GIORequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.GIORequestResponse>> RetrieveDeviceProvisioningHistoryAsync(
                Models.ProvhistoryRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GIORequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v2/devices/history/actions/list")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new GIORestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Get the status of an asynchronous request made with the Device Actions.
        /// </summary>
        /// <param name="accountName">Required parameter: Example: .</param>
        /// <param name="requestID">Required parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.StatusResponse response from the API call.</returns>
        public ApiResponse<Models.StatusResponse> GetAsynchronousRequestStatus(
                string accountName,
                string requestID)
            => CoreHelper.RunTask(GetAsynchronousRequestStatusAsync(accountName, requestID));

        /// <summary>
        /// Get the status of an asynchronous request made with the Device Actions.
        /// </summary>
        /// <param name="accountName">Required parameter: Example: .</param>
        /// <param name="requestID">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.StatusResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.StatusResponse>> GetAsynchronousRequestStatusAsync(
                string accountName,
                string requestID,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.StatusResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/m2m/v2/accounts/{accountName}/requests/{requestID}/status")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("accountName", accountName))
                      .Template(_template => _template.Setup("requestID", requestID))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new GIORestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}