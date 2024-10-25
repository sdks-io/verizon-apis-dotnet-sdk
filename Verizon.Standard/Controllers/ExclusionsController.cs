// <copyright file="ExclusionsController.cs" company="APIMatic">
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
    /// ExclusionsController.
    /// </summary>
    public class ExclusionsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExclusionsController"/> class.
        /// </summary>
        internal ExclusionsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Get the consent settings for the entire account or device list in an account.
        /// </summary>
        /// <param name="accountName">Required parameter: The numeric name of the account..</param>
        /// <param name="deviceId">Optional parameter: The IMEI of the device being queried.</param>
        /// <returns>Returns the ApiResponse of Models.GetAccountDeviceConsent response from the API call.</returns>
        public ApiResponse<Models.GetAccountDeviceConsent> DevicesLocationGetConsentAsync(
                string accountName,
                string deviceId = null)
            => CoreHelper.RunTask(DevicesLocationGetConsentAsyncAsync(accountName, deviceId));

        /// <summary>
        /// Get the consent settings for the entire account or device list in an account.
        /// </summary>
        /// <param name="accountName">Required parameter: The numeric name of the account..</param>
        /// <param name="deviceId">Optional parameter: The IMEI of the device being queried.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.GetAccountDeviceConsent response from the API call.</returns>
        public async Task<ApiResponse<Models.GetAccountDeviceConsent>> DevicesLocationGetConsentAsyncAsync(
                string accountName,
                string deviceId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetAccountDeviceConsent>()
              .Server(Server.DeviceLocation)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/devicelocations/action/consents")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("accountName", accountName))
                      .Query(_query => _query.Setup("deviceId", deviceId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Unexpected error.", (_reason, _context) => new DeviceLocationResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create a consent record to use location services as an asynchronous request.
        /// </summary>
        /// <param name="body">Optional parameter: Account details to create a consent record..</param>
        /// <returns>Returns the ApiResponse of Models.ConsentTransactionID response from the API call.</returns>
        public ApiResponse<Models.ConsentTransactionID> DevicesLocationGiveConsentAsync(
                Models.AccountConsentCreate body = null)
            => CoreHelper.RunTask(DevicesLocationGiveConsentAsyncAsync(body));

        /// <summary>
        /// Create a consent record to use location services as an asynchronous request.
        /// </summary>
        /// <param name="body">Optional parameter: Account details to create a consent record..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ConsentTransactionID response from the API call.</returns>
        public async Task<ApiResponse<Models.ConsentTransactionID>> DevicesLocationGiveConsentAsyncAsync(
                Models.AccountConsentCreate body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ConsentTransactionID>()
              .Server(Server.DeviceLocation)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/devicelocations/action/consents")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Unexpected error.", (_reason, _context) => new DeviceLocationResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Update the location services consent record for an entire account.
        /// </summary>
        /// <param name="body">Optional parameter: Account details to update a consent record..</param>
        /// <returns>Returns the ApiResponse of Models.ConsentTransactionID response from the API call.</returns>
        public ApiResponse<Models.ConsentTransactionID> DevicesLocationUpdateConsent(
                Models.AccountConsentUpdate body = null)
            => CoreHelper.RunTask(DevicesLocationUpdateConsentAsync(body));

        /// <summary>
        /// Update the location services consent record for an entire account.
        /// </summary>
        /// <param name="body">Optional parameter: Account details to update a consent record..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ConsentTransactionID response from the API call.</returns>
        public async Task<ApiResponse<Models.ConsentTransactionID>> DevicesLocationUpdateConsentAsync(
                Models.AccountConsentUpdate body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ConsentTransactionID>()
              .Server(Server.DeviceLocation)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/devicelocations/action/consents")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Unexpected error.", (_reason, _context) => new DeviceLocationResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

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
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
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
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("accountName", accountName))
                      .Query(_query => _query.Setup("deviceList", deviceList))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new DeviceLocationResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This consents endpoint retrieves a list of excluded devices in an account.
        /// </summary>
        /// <param name="accountName">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="startIndex">Required parameter: Zero-based number of the first record to return..</param>
        /// <returns>Returns the ApiResponse of Models.DevicesConsentResult response from the API call.</returns>
        public ApiResponse<Models.DevicesConsentResult> ListExcludedDevices(
                string accountName,
                string startIndex)
            => CoreHelper.RunTask(ListExcludedDevicesAsync(accountName, startIndex));

        /// <summary>
        /// This consents endpoint retrieves a list of excluded devices in an account.
        /// </summary>
        /// <param name="accountName">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="startIndex">Required parameter: Zero-based number of the first record to return..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DevicesConsentResult response from the API call.</returns>
        public async Task<ApiResponse<Models.DevicesConsentResult>> ListExcludedDevicesAsync(
                string accountName,
                string startIndex,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DevicesConsentResult>()
              .Server(Server.DeviceLocation)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/consents/{accountName}/index/{startIndex}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("accountName", accountName))
                      .Template(_template => _template.Setup("startIndex", startIndex))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new DeviceLocationResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}