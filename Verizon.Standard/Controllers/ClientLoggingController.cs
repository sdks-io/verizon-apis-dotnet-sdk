// <copyright file="ClientLoggingController.cs" company="APIMatic">
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
    /// ClientLoggingController.
    /// </summary>
    public class ClientLoggingController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientLoggingController"/> class.
        /// </summary>
        internal ClientLoggingController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Returns an array of all devices in the specified account for which logging is enabled.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <returns>Returns the ApiResponse of List&lt;Models.DeviceLoggingStatus&gt; response from the API call.</returns>
        public ApiResponse<List<Models.DeviceLoggingStatus>> ListDevicesWithLoggingEnabled(
                string account)
            => CoreHelper.RunTask(ListDevicesWithLoggingEnabledAsync(account));

        /// <summary>
        /// Returns an array of all devices in the specified account for which logging is enabled.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List&lt;Models.DeviceLoggingStatus&gt; response from the API call.</returns>
        public async Task<ApiResponse<List<Models.DeviceLoggingStatus>>> ListDevicesWithLoggingEnabledAsync(
                string account,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.DeviceLoggingStatus>>()
              .Server(Server.SoftwareManagementV2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/logging/{account}/devices")
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
        /// Each customer may have a maximum of 20 devices enabled for logging.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="body">Required parameter: Device logging information..</param>
        /// <returns>Returns the ApiResponse of List&lt;Models.DeviceLoggingStatus&gt; response from the API call.</returns>
        public ApiResponse<List<Models.DeviceLoggingStatus>> EnableLoggingForDevices(
                string account,
                Models.DeviceLoggingRequest body)
            => CoreHelper.RunTask(EnableLoggingForDevicesAsync(account, body));

        /// <summary>
        /// Each customer may have a maximum of 20 devices enabled for logging.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="body">Required parameter: Device logging information..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List&lt;Models.DeviceLoggingStatus&gt; response from the API call.</returns>
        public async Task<ApiResponse<List<Models.DeviceLoggingStatus>>> EnableLoggingForDevicesAsync(
                string account,
                Models.DeviceLoggingRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.DeviceLoggingStatus>>()
              .Server(Server.SoftwareManagementV2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/logging/{account}/devices")
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
        /// Turn logging off for a list of devices.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="deviceIds">Required parameter: The list of device IDs..</param>
        public void DisableLoggingForDevices(
                string account,
                string deviceIds)
            => CoreHelper.RunVoidTask(DisableLoggingForDevicesAsync(account, deviceIds));

        /// <summary>
        /// Turn logging off for a list of devices.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="deviceIds">Required parameter: The list of device IDs..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DisableLoggingForDevicesAsync(
                string account,
                string deviceIds,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .Server(Server.SoftwareManagementV2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/logging/{account}/devices")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("account", account))
                      .Query(_query => _query.Setup("deviceIds", deviceIds))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV2ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Enables logging for a specific device.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="deviceId">Required parameter: Device IMEI identifier..</param>
        /// <returns>Returns the ApiResponse of Models.DeviceLoggingStatus response from the API call.</returns>
        public ApiResponse<Models.DeviceLoggingStatus> EnableDeviceLogging(
                string account,
                string deviceId)
            => CoreHelper.RunTask(EnableDeviceLoggingAsync(account, deviceId));

        /// <summary>
        /// Enables logging for a specific device.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="deviceId">Required parameter: Device IMEI identifier..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeviceLoggingStatus response from the API call.</returns>
        public async Task<ApiResponse<Models.DeviceLoggingStatus>> EnableDeviceLoggingAsync(
                string account,
                string deviceId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeviceLoggingStatus>()
              .Server(Server.SoftwareManagementV2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/logging/{account}/devices/{deviceId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("account", account))
                      .Template(_template => _template.Setup("deviceId", deviceId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV2ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Disables logging for a specific device.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="deviceId">Required parameter: Device IMEI identifier..</param>
        public void DisableDeviceLogging(
                string account,
                string deviceId)
            => CoreHelper.RunVoidTask(DisableDeviceLoggingAsync(account, deviceId));

        /// <summary>
        /// Disables logging for a specific device.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="deviceId">Required parameter: Device IMEI identifier..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DisableDeviceLoggingAsync(
                string account,
                string deviceId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .Server(Server.SoftwareManagementV2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/logging/{account}/devices/{deviceId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("account", account))
                      .Template(_template => _template.Setup("deviceId", deviceId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV2ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Gets logs for a specific device.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="deviceId">Required parameter: Device IMEI identifier..</param>
        /// <returns>Returns the ApiResponse of List&lt;Models.DeviceLog&gt; response from the API call.</returns>
        public ApiResponse<List<Models.DeviceLog>> ListDeviceLogs(
                string account,
                string deviceId)
            => CoreHelper.RunTask(ListDeviceLogsAsync(account, deviceId));

        /// <summary>
        /// Gets logs for a specific device.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="deviceId">Required parameter: Device IMEI identifier..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List&lt;Models.DeviceLog&gt; response from the API call.</returns>
        public async Task<ApiResponse<List<Models.DeviceLog>>> ListDeviceLogsAsync(
                string account,
                string deviceId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.DeviceLog>>()
              .Server(Server.SoftwareManagementV2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/logging/{account}/devices/{deviceId}/logs")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("account", account))
                      .Template(_template => _template.Setup("deviceId", deviceId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV2ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}