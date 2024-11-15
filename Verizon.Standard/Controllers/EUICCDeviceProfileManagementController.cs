// <copyright file="EUICCDeviceProfileManagementController.cs" company="APIMatic">
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
    /// EUICCDeviceProfileManagementController.
    /// </summary>
    public class EUICCDeviceProfileManagementController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EUICCDeviceProfileManagementController"/> class.
        /// </summary>
        internal EUICCDeviceProfileManagementController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Downloads an eUICC local profile to devices and enables the profile.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public ApiResponse<Models.DeviceManagementResult> DownloadLocalProfileToEnable(
                Models.ProfileChangeStateRequest body)
            => CoreHelper.RunTask(DownloadLocalProfileToEnableAsync(body));

        /// <summary>
        /// Downloads an eUICC local profile to devices and enables the profile.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public async Task<ApiResponse<Models.DeviceManagementResult>> DownloadLocalProfileToEnableAsync(
                Models.ProfileChangeStateRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeviceManagementResult>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/devices/profile/actions/download_enable")
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
        /// Downloads an eUICC local profile to devices and leaves the profile disabled.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public ApiResponse<Models.DeviceManagementResult> DownloadLocalProfileToDisable(
                Models.ProfileChangeStateRequest body)
            => CoreHelper.RunTask(DownloadLocalProfileToDisableAsync(body));

        /// <summary>
        /// Downloads an eUICC local profile to devices and leaves the profile disabled.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public async Task<ApiResponse<Models.DeviceManagementResult>> DownloadLocalProfileToDisableAsync(
                Models.ProfileChangeStateRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeviceManagementResult>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/devices/profile/actions/download_disable")
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
        /// Enable a local profile that has been downloaded to eUICC devices.
        /// </summary>
        /// <param name="body">Required parameter: Update state.</param>
        /// <returns>Returns the ApiResponse of Models.RequestResponse response from the API call.</returns>
        public ApiResponse<Models.RequestResponse> EnableLocalProfile(
                Models.ProfileChangeStateRequest body)
            => CoreHelper.RunTask(EnableLocalProfileAsync(body));

        /// <summary>
        /// Enable a local profile that has been downloaded to eUICC devices.
        /// </summary>
        /// <param name="body">Required parameter: Update state.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.RequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.RequestResponse>> EnableLocalProfileAsync(
                Models.ProfileChangeStateRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/devices/profile/actions/enable")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error Response", (_reason, _context) => new RestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Disable a local profile on eUICC devices. The default or boot profile will become the enabled profile.
        /// </summary>
        /// <param name="body">Required parameter: Update state.</param>
        /// <returns>Returns the ApiResponse of Models.RequestResponse response from the API call.</returns>
        public ApiResponse<Models.RequestResponse> DisableLocalProfile(
                Models.ProfileChangeStateRequest body)
            => CoreHelper.RunTask(DisableLocalProfileAsync(body));

        /// <summary>
        /// Disable a local profile on eUICC devices. The default or boot profile will become the enabled profile.
        /// </summary>
        /// <param name="body">Required parameter: Update state.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.RequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.RequestResponse>> DisableLocalProfileAsync(
                Models.ProfileChangeStateRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/devices/profile/actions/disable")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error Response", (_reason, _context) => new RestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete a local profile from eUICC devices. If the local profile is enabled, it will first be disabled and the boot or default profile will be enabled.
        /// </summary>
        /// <param name="body">Required parameter: Update state.</param>
        /// <returns>Returns the ApiResponse of Models.RequestResponse response from the API call.</returns>
        public ApiResponse<Models.RequestResponse> DeleteLocalProfile(
                Models.ProfileChangeStateRequest body)
            => CoreHelper.RunTask(DeleteLocalProfileAsync(body));

        /// <summary>
        /// Delete a local profile from eUICC devices. If the local profile is enabled, it will first be disabled and the boot or default profile will be enabled.
        /// </summary>
        /// <param name="body">Required parameter: Update state.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.RequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.RequestResponse>> DeleteLocalProfileAsync(
                Models.ProfileChangeStateRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/devices/profile/actions/delete")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error Response", (_reason, _context) => new RestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}