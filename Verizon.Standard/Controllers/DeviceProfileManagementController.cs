// <copyright file="DeviceProfileManagementController.cs" company="APIMatic">
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
    /// DeviceProfileManagementController.
    /// </summary>
    public class DeviceProfileManagementController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceProfileManagementController"/> class.
        /// </summary>
        internal DeviceProfileManagementController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Uses the profile to bring the device under management.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <returns>Returns the ApiResponse of Models.RequestResponse response from the API call.</returns>
        public ApiResponse<Models.RequestResponse> ActivateDeviceThroughProfile(
                Models.ActivateDeviceProfileRequest body)
            => CoreHelper.RunTask(ActivateDeviceThroughProfileAsync(body));

        /// <summary>
        /// Uses the profile to bring the device under management.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.RequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.RequestResponse>> ActivateDeviceThroughProfileAsync(
                Models.ActivateDeviceProfileRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/devices/profile/actions/activate_enable")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new RestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Uses the profile to activate the device.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <returns>Returns the ApiResponse of Models.RequestResponse response from the API call.</returns>
        public ApiResponse<Models.RequestResponse> ProfileToActivateDevice(
                Models.ProfileRequest body)
            => CoreHelper.RunTask(ProfileToActivateDeviceAsync(body));

        /// <summary>
        /// Uses the profile to activate the device.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.RequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.RequestResponse>> ProfileToActivateDeviceAsync(
                Models.ProfileRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RequestResponse>()
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
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new RestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Uses the profile to deactivate the device.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <returns>Returns the ApiResponse of Models.RequestResponse response from the API call.</returns>
        public ApiResponse<Models.RequestResponse> ProfileToDeactivateDevice(
                Models.DeactivateDeviceProfileRequest body)
            => CoreHelper.RunTask(ProfileToDeactivateDeviceAsync(body));

        /// <summary>
        /// Uses the profile to deactivate the device.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.RequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.RequestResponse>> ProfileToDeactivateDeviceAsync(
                Models.DeactivateDeviceProfileRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RequestResponse>()
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
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new RestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Allows the profile to set the fallback attribute to the device.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <returns>Returns the ApiResponse of Models.RequestResponse response from the API call.</returns>
        public ApiResponse<Models.RequestResponse> ProfileToSetFallbackAttribute(
                Models.SetFallbackAttributeRequest body)
            => CoreHelper.RunTask(ProfileToSetFallbackAttributeAsync(body));

        /// <summary>
        /// Allows the profile to set the fallback attribute to the device.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.RequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.RequestResponse>> ProfileToSetFallbackAttributeAsync(
                Models.SetFallbackAttributeRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/devices/profile/actions/setfallbackattribute")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new RestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}