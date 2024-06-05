// <copyright file="DeviceServiceManagementController.cs" company="APIMatic">
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
    /// DeviceServiceManagementController.
    /// </summary>
    public class DeviceServiceManagementController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceServiceManagementController"/> class.
        /// </summary>
        internal DeviceServiceManagementController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Gets the list of a status for hyper-precise location devices.
        /// </summary>
        /// <param name="imei">Required parameter: A unique identifier for a device..</param>
        /// <param name="accountNumber">Required parameter: A unique identifier for an account..</param>
        /// <returns>Returns the ApiResponse of Models.BullseyeServiceResult response from the API call.</returns>
        public ApiResponse<Models.BullseyeServiceResult> GetDeviceHyperPreciseStatus(
                string imei,
                string accountNumber)
            => CoreHelper.RunTask(GetDeviceHyperPreciseStatusAsync(imei, accountNumber));

        /// <summary>
        /// Gets the list of a status for hyper-precise location devices.
        /// </summary>
        /// <param name="imei">Required parameter: A unique identifier for a device..</param>
        /// <param name="accountNumber">Required parameter: A unique identifier for an account..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.BullseyeServiceResult response from the API call.</returns>
        public async Task<ApiResponse<Models.BullseyeServiceResult>> GetDeviceHyperPreciseStatusAsync(
                string imei,
                string accountNumber,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BullseyeServiceResult>()
              .Server(Server.HyperPreciseLocation)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/devices/services")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("imei", imei))
                      .Query(_query => _query.Setup("accountNumber", accountNumber))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized request. Access token is missing or invalid.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden request.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Bad request. Not found.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context)))
                  .ErrorCase("409", CreateErrorCase("Bad request. Conflict state.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Enable/disable hyper-precise service for a device.
        /// </summary>
        /// <param name="body">Required parameter: List of devices and hyper-precise required statuses..</param>
        /// <returns>Returns the ApiResponse of Models.BullseyeServiceResult response from the API call.</returns>
        public ApiResponse<Models.BullseyeServiceResult> UpdateDeviceHyperPreciseStatus(
                Models.BullseyeServiceRequest body)
            => CoreHelper.RunTask(UpdateDeviceHyperPreciseStatusAsync(body));

        /// <summary>
        /// Enable/disable hyper-precise service for a device.
        /// </summary>
        /// <param name="body">Required parameter: List of devices and hyper-precise required statuses..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.BullseyeServiceResult response from the API call.</returns>
        public async Task<ApiResponse<Models.BullseyeServiceResult>> UpdateDeviceHyperPreciseStatusAsync(
                Models.BullseyeServiceRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BullseyeServiceResult>()
              .Server(Server.HyperPreciseLocation)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/devices/services")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized request. Access token is missing or invalid.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden request.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Bad request. Not found.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context)))
                  .ErrorCase("409", CreateErrorCase("Bad request. Conflict state.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}