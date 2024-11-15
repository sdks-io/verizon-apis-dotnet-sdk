// <copyright file="SoftwareManagementLicensesV3Controller.cs" company="APIMatic">
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
    /// SoftwareManagementLicensesV3Controller.
    /// </summary>
    public class SoftwareManagementLicensesV3Controller : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoftwareManagementLicensesV3Controller"/> class.
        /// </summary>
        internal SoftwareManagementLicensesV3Controller(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// The endpoint allows user to list license usage.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <param name="lastSeenDeviceId">Optional parameter: Last seen device identifier..</param>
        /// <returns>Returns the ApiResponse of Models.V3LicenseSummary response from the API call.</returns>
        public ApiResponse<Models.V3LicenseSummary> GetAccountLicensesStatus(
                string acc,
                string lastSeenDeviceId = null)
            => CoreHelper.RunTask(GetAccountLicensesStatusAsync(acc, lastSeenDeviceId));

        /// <summary>
        /// The endpoint allows user to list license usage.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <param name="lastSeenDeviceId">Optional parameter: Last seen device identifier..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.V3LicenseSummary response from the API call.</returns>
        public async Task<ApiResponse<Models.V3LicenseSummary>> GetAccountLicensesStatusAsync(
                string acc,
                string lastSeenDeviceId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V3LicenseSummary>()
              .Server(Server.SoftwareManagementV3)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/licenses/{acc}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("acc", acc))
                      .Query(_query => _query.Setup("lastSeenDeviceId", lastSeenDeviceId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV3ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint allows user to assign licenses to a list of devices.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <param name="body">Required parameter: License assignment..</param>
        /// <returns>Returns the ApiResponse of Models.V3LicenseAssignedRemovedResult response from the API call.</returns>
        public ApiResponse<Models.V3LicenseAssignedRemovedResult> AssignLicensesToDevices(
                string acc,
                Models.V3LicenseIMEI body)
            => CoreHelper.RunTask(AssignLicensesToDevicesAsync(acc, body));

        /// <summary>
        /// This endpoint allows user to assign licenses to a list of devices.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <param name="body">Required parameter: License assignment..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.V3LicenseAssignedRemovedResult response from the API call.</returns>
        public async Task<ApiResponse<Models.V3LicenseAssignedRemovedResult>> AssignLicensesToDevicesAsync(
                string acc,
                Models.V3LicenseIMEI body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V3LicenseAssignedRemovedResult>()
              .Server(Server.SoftwareManagementV3)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/licenses/{acc}/assign")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("acc", acc))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV3ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint allows user to remove licenses from a list of devices.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <param name="body">Required parameter: License removal..</param>
        /// <returns>Returns the ApiResponse of Models.V3LicenseAssignedRemovedResult response from the API call.</returns>
        public ApiResponse<Models.V3LicenseAssignedRemovedResult> RemoveLicensesFromDevices(
                string acc,
                Models.V3LicenseIMEI body)
            => CoreHelper.RunTask(RemoveLicensesFromDevicesAsync(acc, body));

        /// <summary>
        /// This endpoint allows user to remove licenses from a list of devices.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <param name="body">Required parameter: License removal..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.V3LicenseAssignedRemovedResult response from the API call.</returns>
        public async Task<ApiResponse<Models.V3LicenseAssignedRemovedResult>> RemoveLicensesFromDevicesAsync(
                string acc,
                Models.V3LicenseIMEI body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V3LicenseAssignedRemovedResult>()
              .Server(Server.SoftwareManagementV3)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/licenses/{acc}/remove")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("acc", acc))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV3ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}