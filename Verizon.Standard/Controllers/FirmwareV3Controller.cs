// <copyright file="FirmwareV3Controller.cs" company="APIMatic">
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
    /// FirmwareV3Controller.
    /// </summary>
    public class FirmwareV3Controller : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FirmwareV3Controller"/> class.
        /// </summary>
        internal FirmwareV3Controller(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// This endpoint allows user to list the firmware of an account.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <param name="protocol">Required parameter: Filter to retrieve a specific protocol type used..</param>
        /// <returns>Returns the ApiResponse of List<Models.FirmwarePackage> response from the API call.</returns>
        public ApiResponse<List<Models.FirmwarePackage>> ListAvailableFirmware(
                string acc,
                Models.FirmwareProtocolEnum protocol)
            => CoreHelper.RunTask(ListAvailableFirmwareAsync(acc, protocol));

        /// <summary>
        /// This endpoint allows user to list the firmware of an account.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <param name="protocol">Required parameter: Filter to retrieve a specific protocol type used..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List<Models.FirmwarePackage> response from the API call.</returns>
        public async Task<ApiResponse<List<Models.FirmwarePackage>>> ListAvailableFirmwareAsync(
                string acc,
                Models.FirmwareProtocolEnum protocol,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.FirmwarePackage>>()
              .Server(Server.SoftwareManagementV3)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/firmware/{acc}")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("acc", acc))
                      .Query(_query => _query.Setup("protocol", ApiHelper.JsonSerialize(protocol).Trim('\"')))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV3ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Synchronize ThingSpace with the FOTA server for up to 100 devices.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <param name="body">Required parameter: DeviceIds to get firmware info synchronously..</param>
        /// <returns>Returns the ApiResponse of Models.DeviceFirmwareList response from the API call.</returns>
        public ApiResponse<Models.DeviceFirmwareList> SynchronizeDeviceFirmware(
                string acc,
                Models.FirmwareIMEI body)
            => CoreHelper.RunTask(SynchronizeDeviceFirmwareAsync(acc, body));

        /// <summary>
        /// Synchronize ThingSpace with the FOTA server for up to 100 devices.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <param name="body">Required parameter: DeviceIds to get firmware info synchronously..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeviceFirmwareList response from the API call.</returns>
        public async Task<ApiResponse<Models.DeviceFirmwareList>> SynchronizeDeviceFirmwareAsync(
                string acc,
                Models.FirmwareIMEI body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeviceFirmwareList>()
              .Server(Server.SoftwareManagementV3)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/firmware/{acc}/devices")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("acc", acc))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV3ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Ask a device to report its firmware version asynchronously.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <param name="deviceId">Required parameter: Device identifier..</param>
        /// <returns>Returns the ApiResponse of Models.DeviceFirmwareVersionUpdateResult response from the API call.</returns>
        public ApiResponse<Models.DeviceFirmwareVersionUpdateResult> ReportDeviceFirmware(
                string acc,
                string deviceId)
            => CoreHelper.RunTask(ReportDeviceFirmwareAsync(acc, deviceId));

        /// <summary>
        /// Ask a device to report its firmware version asynchronously.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <param name="deviceId">Required parameter: Device identifier..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeviceFirmwareVersionUpdateResult response from the API call.</returns>
        public async Task<ApiResponse<Models.DeviceFirmwareVersionUpdateResult>> ReportDeviceFirmwareAsync(
                string acc,
                string deviceId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeviceFirmwareVersionUpdateResult>()
              .Server(Server.SoftwareManagementV3)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/firmware/{acc}/async/{deviceId}")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("acc", acc))
                      .Template(_template => _template.Setup("deviceId", deviceId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV3ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}