// <copyright file="DeviceDiagnosticsController.cs" company="APIMatic">
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
    /// DeviceDiagnosticsController.
    /// </summary>
    public class DeviceDiagnosticsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceDiagnosticsController"/> class.
        /// </summary>
        internal DeviceDiagnosticsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// If the devices do not already exist in the account, this API resource adds them before activation.
        /// </summary>
        /// <param name="body">Required parameter: Retrieve Reachability Report Status for a device..</param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public ApiResponse<Models.DeviceManagementResult> DeviceReachabilityStatusUsingPOST(
                Models.NotificationReportStatusRequest body)
            => CoreHelper.RunTask(DeviceReachabilityStatusUsingPOSTAsync(body));

        /// <summary>
        /// If the devices do not already exist in the account, this API resource adds them before activation.
        /// </summary>
        /// <param name="body">Required parameter: Retrieve Reachability Report Status for a device..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public async Task<ApiResponse<Models.DeviceManagementResult>> DeviceReachabilityStatusUsingPOSTAsync(
                Models.NotificationReportStatusRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeviceManagementResult>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/diagnostics/basic/devicereachability/status")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieve all the active monitors.
        /// </summary>
        /// <param name="body">Required parameter: Retrieve Monitor Request..</param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public ApiResponse<Models.DeviceManagementResult> RetrieveActiveMonitorsUsingPOST(
                Models.RetrieveMonitorsRequest body)
            => CoreHelper.RunTask(RetrieveActiveMonitorsUsingPOSTAsync(body));

        /// <summary>
        /// Retrieve all the active monitors.
        /// </summary>
        /// <param name="body">Required parameter: Retrieve Monitor Request..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public async Task<ApiResponse<Models.DeviceManagementResult>> RetrieveActiveMonitorsUsingPOSTAsync(
                Models.RetrieveMonitorsRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeviceManagementResult>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/diagnostics/basic/devicereachability/monitors")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}