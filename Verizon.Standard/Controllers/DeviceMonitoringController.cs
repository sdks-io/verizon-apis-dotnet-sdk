// <copyright file="DeviceMonitoringController.cs" company="APIMatic">
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
    /// DeviceMonitoringController.
    /// </summary>
    public class DeviceMonitoringController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceMonitoringController"/> class.
        /// </summary>
        internal DeviceMonitoringController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Stop Device Reachability monitors.
        /// </summary>
        /// <param name="accountName">Required parameter: The numeric name of the account..</param>
        /// <param name="monitorIds">Required parameter: The array contains the monitorIDs (UUID) for which the monitor is to be deleted..</param>
        /// <returns>Returns the ApiResponse of Models.RequestResponse response from the API call.</returns>
        public ApiResponse<Models.RequestResponse> StopDeviceReachability(
                string accountName,
                List<string> monitorIds)
            => CoreHelper.RunTask(StopDeviceReachabilityAsync(accountName, monitorIds));

        /// <summary>
        /// Stop Device Reachability monitors.
        /// </summary>
        /// <param name="accountName">Required parameter: The numeric name of the account..</param>
        /// <param name="monitorIds">Required parameter: The array contains the monitorIDs (UUID) for which the monitor is to be deleted..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.RequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.RequestResponse>> StopDeviceReachabilityAsync(
                string accountName,
                List<string> monitorIds,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RequestResponse>()
              .Server(Server.M2m)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/v1/diagnostics/basic/devicereachability")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("accountName", accountName))
                      .Query(_query => _query.Setup("monitorIds", monitorIds))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error Response", (_reason, _context) => new RestErrorResponseException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.RequestResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Register for notification reports based on the request type.
        /// </summary>
        /// <param name="body">Required parameter: Create Reachability Report Request.</param>
        /// <returns>Returns the ApiResponse of Models.RequestResponse response from the API call.</returns>
        public ApiResponse<Models.RequestResponse> DeviceReachability(
                Models.NotificationReportRequest body)
            => CoreHelper.RunTask(DeviceReachabilityAsync(body));

        /// <summary>
        /// Register for notification reports based on the request type.
        /// </summary>
        /// <param name="body">Required parameter: Create Reachability Report Request.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.RequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.RequestResponse>> DeviceReachabilityAsync(
                Models.NotificationReportRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RequestResponse>()
              .Server(Server.M2m)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/diagnostics/basic/devicereachability")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error Response", (_reason, _context) => new RestErrorResponseException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.RequestResponse>(_response)))
              .ExecuteAsync(cancellationToken);
    }
}