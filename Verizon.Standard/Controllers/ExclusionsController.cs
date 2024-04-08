// <copyright file="ExclusionsController.cs" company="APIMatic">
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
    /// ExclusionsController.
    /// </summary>
    public class ExclusionsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExclusionsController"/> class.
        /// </summary>
        internal ExclusionsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// This consents endpoint sets a new exclusion list.
        /// </summary>
        /// <param name="body">Required parameter: Request to update account consent exclusion list..</param>
        /// <returns>Returns the ApiResponse of Models.DeviceLocationSuccessResult response from the API call.</returns>
        public ApiResponse<Models.DeviceLocationSuccessResult> ExcludeDevices(
                Models.ConsentRequest body)
            => CoreHelper.RunTask(ExcludeDevicesAsync(body));

        /// <summary>
        /// This consents endpoint sets a new exclusion list.
        /// </summary>
        /// <param name="body">Required parameter: Request to update account consent exclusion list..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeviceLocationSuccessResult response from the API call.</returns>
        public async Task<ApiResponse<Models.DeviceLocationSuccessResult>> ExcludeDevicesAsync(
                Models.ConsentRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeviceLocationSuccessResult>()
              .Server(Server.DeviceLocation)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/consents")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "*/*"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new DeviceLocationResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Removes devices from the exclusion list so that they can be located with Device Location Services requests.
        /// </summary>
        /// <param name="accountName">Required parameter: The numeric name of the account..</param>
        /// <param name="deviceList">Required parameter: A list of the device IDs to remove from the exclusion list..</param>
        /// <returns>Returns the ApiResponse of Models.DeviceLocationSuccessResult response from the API call.</returns>
        public ApiResponse<Models.DeviceLocationSuccessResult> RemoveDevicesFromExclusionList(
                string accountName,
                string deviceList)
            => CoreHelper.RunTask(RemoveDevicesFromExclusionListAsync(accountName, deviceList));

        /// <summary>
        /// Removes devices from the exclusion list so that they can be located with Device Location Services requests.
        /// </summary>
        /// <param name="accountName">Required parameter: The numeric name of the account..</param>
        /// <param name="deviceList">Required parameter: A list of the device IDs to remove from the exclusion list..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeviceLocationSuccessResult response from the API call.</returns>
        public async Task<ApiResponse<Models.DeviceLocationSuccessResult>> RemoveDevicesFromExclusionListAsync(
                string accountName,
                string deviceList,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeviceLocationSuccessResult>()
              .Server(Server.DeviceLocation)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/consents")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("accountName", accountName))
                      .Query(_query => _query.Setup("deviceList", deviceList))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new DeviceLocationResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This consents endpoint retrieves a list of excluded devices in an account.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="startIndex">Required parameter: Zero-based number of the first record to return..</param>
        /// <returns>Returns the ApiResponse of Models.DevicesConsentResult response from the API call.</returns>
        public ApiResponse<Models.DevicesConsentResult> ListExcludedDevices(
                string account,
                string startIndex)
            => CoreHelper.RunTask(ListExcludedDevicesAsync(account, startIndex));

        /// <summary>
        /// This consents endpoint retrieves a list of excluded devices in an account.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="startIndex">Required parameter: Zero-based number of the first record to return..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DevicesConsentResult response from the API call.</returns>
        public async Task<ApiResponse<Models.DevicesConsentResult>> ListExcludedDevicesAsync(
                string account,
                string startIndex,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DevicesConsentResult>()
              .Server(Server.DeviceLocation)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/consents/{account}/index/{startIndex}")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("account", account))
                      .Template(_template => _template.Setup("startIndex", startIndex))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new DeviceLocationResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}