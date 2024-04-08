// <copyright file="SoftwareManagementLicensesV2Controller.cs" company="APIMatic">
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
    /// SoftwareManagementLicensesV2Controller.
    /// </summary>
    public class SoftwareManagementLicensesV2Controller : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoftwareManagementLicensesV2Controller"/> class.
        /// </summary>
        internal SoftwareManagementLicensesV2Controller(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// The endpoint allows user to list license usage.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="lastSeenDeviceId">Optional parameter: Last seen device identifier..</param>
        /// <returns>Returns the ApiResponse of Models.V2LicenseSummary response from the API call.</returns>
        public ApiResponse<Models.V2LicenseSummary> GetAccountLicenseStatus(
                string account,
                string lastSeenDeviceId = null)
            => CoreHelper.RunTask(GetAccountLicenseStatusAsync(account, lastSeenDeviceId));

        /// <summary>
        /// The endpoint allows user to list license usage.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="lastSeenDeviceId">Optional parameter: Last seen device identifier..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.V2LicenseSummary response from the API call.</returns>
        public async Task<ApiResponse<Models.V2LicenseSummary>> GetAccountLicenseStatusAsync(
                string account,
                string lastSeenDeviceId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V2LicenseSummary>()
              .Server(Server.SoftwareManagementV2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/licenses/{account}")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("account", account))
                      .Query(_query => _query.Setup("lastSeenDeviceId", lastSeenDeviceId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV2ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint allows user to assign licenses to a list of devices.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="body">Required parameter: License assignment..</param>
        /// <returns>Returns the ApiResponse of Models.V2LicensesAssignedRemovedResult response from the API call.</returns>
        [Obsolete]
        public ApiResponse<Models.V2LicensesAssignedRemovedResult> AssignLicensesToDevices(
                string account,
                Models.V2LicenseIMEI body)
            => CoreHelper.RunTask(AssignLicensesToDevicesAsync(account, body));

        /// <summary>
        /// This endpoint allows user to assign licenses to a list of devices.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="body">Required parameter: License assignment..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.V2LicensesAssignedRemovedResult response from the API call.</returns>
        [Obsolete]
        public async Task<ApiResponse<Models.V2LicensesAssignedRemovedResult>> AssignLicensesToDevicesAsync(
                string account,
                Models.V2LicenseIMEI body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V2LicensesAssignedRemovedResult>()
              .Server(Server.SoftwareManagementV2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/licenses/{account}/assign")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("account", account))
                      .Header(_header => _header.Setup("Content-Type", "*/*"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV2ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint allows user to remove licenses from a list of devices.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="body">Required parameter: License removal..</param>
        /// <returns>Returns the ApiResponse of Models.V2LicensesAssignedRemovedResult response from the API call.</returns>
        [Obsolete]
        public ApiResponse<Models.V2LicensesAssignedRemovedResult> RemoveLicensesFromDevices(
                string account,
                Models.V2LicenseIMEI body)
            => CoreHelper.RunTask(RemoveLicensesFromDevicesAsync(account, body));

        /// <summary>
        /// This endpoint allows user to remove licenses from a list of devices.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="body">Required parameter: License removal..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.V2LicensesAssignedRemovedResult response from the API call.</returns>
        [Obsolete]
        public async Task<ApiResponse<Models.V2LicensesAssignedRemovedResult>> RemoveLicensesFromDevicesAsync(
                string account,
                Models.V2LicenseIMEI body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V2LicensesAssignedRemovedResult>()
              .Server(Server.SoftwareManagementV2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/licenses/{account}/remove")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("account", account))
                      .Header(_header => _header.Setup("Content-Type", "*/*"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV2ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// The license cancel endpoint allows user to list registered license cancellation candidate devices.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="startIndex">Optional parameter: Start index to retrieve..</param>
        /// <returns>Returns the ApiResponse of Models.V2ListOfLicensesToRemove response from the API call.</returns>
        [Obsolete]
        public ApiResponse<Models.V2ListOfLicensesToRemove> ListLicensesToRemove(
                string account,
                string startIndex = null)
            => CoreHelper.RunTask(ListLicensesToRemoveAsync(account, startIndex));

        /// <summary>
        /// The license cancel endpoint allows user to list registered license cancellation candidate devices.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="startIndex">Optional parameter: Start index to retrieve..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.V2ListOfLicensesToRemove response from the API call.</returns>
        [Obsolete]
        public async Task<ApiResponse<Models.V2ListOfLicensesToRemove>> ListLicensesToRemoveAsync(
                string account,
                string startIndex = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V2ListOfLicensesToRemove>()
              .Server(Server.SoftwareManagementV2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/licenses/{account}/cancel")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("account", account))
                      .Query(_query => _query.Setup("startIndex", startIndex))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV2ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// The license cancel endpoint allows user to create a list of license cancellation candidate devices.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="body">Required parameter: List of licensess to remove..</param>
        /// <returns>Returns the ApiResponse of Models.V2ListOfLicensesToRemoveResult response from the API call.</returns>
        [Obsolete]
        public ApiResponse<Models.V2ListOfLicensesToRemoveResult> CreateListOfLicensesToRemove(
                string account,
                Models.V2ListOfLicensesToRemoveRequest body)
            => CoreHelper.RunTask(CreateListOfLicensesToRemoveAsync(account, body));

        /// <summary>
        /// The license cancel endpoint allows user to create a list of license cancellation candidate devices.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="body">Required parameter: List of licensess to remove..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.V2ListOfLicensesToRemoveResult response from the API call.</returns>
        [Obsolete]
        public async Task<ApiResponse<Models.V2ListOfLicensesToRemoveResult>> CreateListOfLicensesToRemoveAsync(
                string account,
                Models.V2ListOfLicensesToRemoveRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V2ListOfLicensesToRemoveResult>()
              .Server(Server.SoftwareManagementV2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/licenses/{account}/cancel")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("account", account))
                      .Header(_header => _header.Setup("Content-Type", "*/*"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV2ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint allows user to delete a created cancel candidate device list.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <returns>Returns the ApiResponse of Models.FotaV2SuccessResult response from the API call.</returns>
        [Obsolete]
        public ApiResponse<Models.FotaV2SuccessResult> DeleteListOfLicensesToRemove(
                string account)
            => CoreHelper.RunTask(DeleteListOfLicensesToRemoveAsync(account));

        /// <summary>
        /// This endpoint allows user to delete a created cancel candidate device list.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.FotaV2SuccessResult response from the API call.</returns>
        [Obsolete]
        public async Task<ApiResponse<Models.FotaV2SuccessResult>> DeleteListOfLicensesToRemoveAsync(
                string account,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.FotaV2SuccessResult>()
              .Server(Server.SoftwareManagementV2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/licenses/{account}/cancel")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("account", account))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV2ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}