// <copyright file="ManagingESIMProfilesController.cs" company="APIMatic">
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
    /// ManagingESIMProfilesController.
    /// </summary>
    public class ManagingESIMProfilesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManagingESIMProfilesController"/> class.
        /// </summary>
        internal ManagingESIMProfilesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Activate a device with either a lead or local profile.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <returns>Returns the ApiResponse of Models.GIORequestResponse response from the API call.</returns>
        public ApiResponse<Models.GIORequestResponse> ActivateADeviceProfile(
                Models.GIOProfileRequest body)
            => CoreHelper.RunTask(ActivateADeviceProfileAsync(body));

        /// <summary>
        /// Activate a device with either a lead or local profile.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.GIORequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.GIORequestResponse>> ActivateADeviceProfileAsync(
                Models.GIOProfileRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GIORequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/devices/profile/actions/activate")
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
        /// Enable a device lead or local profile.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <returns>Returns the ApiResponse of Models.GIORequestResponse response from the API call.</returns>
        public ApiResponse<Models.GIORequestResponse> EnableADeviceProfile(
                Models.DeviceProfileRequest body)
            => CoreHelper.RunTask(EnableADeviceProfileAsync(body));

        /// <summary>
        /// Enable a device lead or local profile.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.GIORequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.GIORequestResponse>> EnableADeviceProfileAsync(
                Models.DeviceProfileRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GIORequestResponse>()
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
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new GIORestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Deactivate the lead or local profile. **Note:** to reactivate the profile, use the **Activate** endpoint above.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <returns>Returns the ApiResponse of Models.GIORequestResponse response from the API call.</returns>
        public ApiResponse<Models.GIORequestResponse> DeactivateADeviceProfile(
                Models.GIODeactivateDeviceProfileRequest body)
            => CoreHelper.RunTask(DeactivateADeviceProfileAsync(body));

        /// <summary>
        /// Deactivate the lead or local profile. **Note:** to reactivate the profile, use the **Activate** endpoint above.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.GIORequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.GIORequestResponse>> DeactivateADeviceProfileAsync(
                Models.GIODeactivateDeviceProfileRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GIORequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/devices/profile/actions/deactivate")
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
        /// Enable the Global IoT Orchestration device profile for download.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <returns>Returns the ApiResponse of Models.GIORequestResponse response from the API call.</returns>
        public ApiResponse<Models.GIORequestResponse> EnableADeviceProfileForDownload(
                Models.DeviceProfileRequest body)
            => CoreHelper.RunTask(EnableADeviceProfileForDownloadAsync(body));

        /// <summary>
        /// Enable the Global IoT Orchestration device profile for download.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.GIORequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.GIORequestResponse>> EnableADeviceProfileForDownloadAsync(
                Models.DeviceProfileRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GIORequestResponse>()
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
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new GIORestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Download a Global IoT Orchestration device profile.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <returns>Returns the ApiResponse of Models.GIORequestResponse response from the API call.</returns>
        public ApiResponse<Models.GIORequestResponse> DownloadADeviceProfile(
                Models.DeviceProfileRequest body)
            => CoreHelper.RunTask(DownloadADeviceProfileAsync(body));

        /// <summary>
        /// Download a Global IoT Orchestration device profile.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.GIORequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.GIORequestResponse>> DownloadADeviceProfileAsync(
                Models.DeviceProfileRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GIORequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/devices/profile/actions/download")
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
        /// Delete a device profile for Global IoT Orchestration. **Note:** the profile must be deactivated first!.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <returns>Returns the ApiResponse of Models.GIORequestResponse response from the API call.</returns>
        public ApiResponse<Models.GIORequestResponse> DeleteADeviceProfile(
                Models.DeviceProfileRequest body)
            => CoreHelper.RunTask(DeleteADeviceProfileAsync(body));

        /// <summary>
        /// Delete a device profile for Global IoT Orchestration. **Note:** the profile must be deactivated first!.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.GIORequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.GIORequestResponse>> DeleteADeviceProfileAsync(
                Models.DeviceProfileRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GIORequestResponse>()
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
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new GIORestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}