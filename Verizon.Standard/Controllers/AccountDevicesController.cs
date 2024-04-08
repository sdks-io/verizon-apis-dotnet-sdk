// <copyright file="AccountDevicesController.cs" company="APIMatic">
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
    /// AccountDevicesController.
    /// </summary>
    public class AccountDevicesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDevicesController"/> class.
        /// </summary>
        internal AccountDevicesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Retrieve account device information such as reported firmware on the devices.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <param name="lastSeenDeviceId">Optional parameter: Last seen device identifier..</param>
        /// <param name="protocol">Optional parameter: Filter to retrieve a specific protocol type used..</param>
        /// <returns>Returns the ApiResponse of Models.V3AccountDeviceList response from the API call.</returns>
        public ApiResponse<Models.V3AccountDeviceList> GetAccountDeviceInformation(
                string acc,
                string lastSeenDeviceId = null,
                Models.DevicesProtocolEnum? protocol = Models.DevicesProtocolEnum.LWM2m)
            => CoreHelper.RunTask(GetAccountDeviceInformationAsync(acc, lastSeenDeviceId, protocol));

        /// <summary>
        /// Retrieve account device information such as reported firmware on the devices.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <param name="lastSeenDeviceId">Optional parameter: Last seen device identifier..</param>
        /// <param name="protocol">Optional parameter: Filter to retrieve a specific protocol type used..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.V3AccountDeviceList response from the API call.</returns>
        public async Task<ApiResponse<Models.V3AccountDeviceList>> GetAccountDeviceInformationAsync(
                string acc,
                string lastSeenDeviceId = null,
                Models.DevicesProtocolEnum? protocol = Models.DevicesProtocolEnum.LWM2m,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V3AccountDeviceList>()
              .Server(Server.SoftwareManagementV3)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/devices/{acc}")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("acc", acc))
                      .Query(_query => _query.Setup("lastSeenDeviceId", lastSeenDeviceId))
                      .Query(_query => _query.Setup("protocol", (protocol.HasValue) ? ApiHelper.JsonSerialize(protocol.Value).Trim('\"') : "LWM2M"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV3ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieve device information for a list of devices on an account.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <param name="body">Required parameter: Request device list information..</param>
        /// <returns>Returns the ApiResponse of Models.DeviceListResult response from the API call.</returns>
        public ApiResponse<Models.DeviceListResult> ListAccountDevicesInformation(
                string acc,
                Models.DeviceIMEI body)
            => CoreHelper.RunTask(ListAccountDevicesInformationAsync(acc, body));

        /// <summary>
        /// Retrieve device information for a list of devices on an account.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <param name="body">Required parameter: Request device list information..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeviceListResult response from the API call.</returns>
        public async Task<ApiResponse<Models.DeviceListResult>> ListAccountDevicesInformationAsync(
                string acc,
                Models.DeviceIMEI body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeviceListResult>()
              .Server(Server.SoftwareManagementV3)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/devices/{acc}")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("acc", acc))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV3ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}