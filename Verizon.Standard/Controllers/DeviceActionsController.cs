// <copyright file="DeviceActionsController.cs" company="APIMatic">
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
    /// DeviceActionsController.
    /// </summary>
    public class DeviceActionsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceActionsController"/> class.
        /// </summary>
        internal DeviceActionsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

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
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new GIORestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retreive the provisioning history of a specific device or devices.
        /// </summary>
        /// <param name="body">Required parameter: Device Provisioning History.</param>
        /// <returns>Returns the ApiResponse of Models.GIORequestResponse response from the API call.</returns>
        public ApiResponse<Models.GIORequestResponse> RetrieveDeviceProvisioningHistory(
                Models.ProvhistoryRequest body)
            => CoreHelper.RunTask(RetrieveDeviceProvisioningHistoryAsync(body));

        /// <summary>
        /// Retreive the provisioning history of a specific device or devices.
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
                  .WithAuth("oAuth2")
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
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("accountName", accountName))
                      .Template(_template => _template.Setup("requestID", requestID))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new GIORestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}