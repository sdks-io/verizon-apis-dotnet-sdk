// <copyright file="SoftwareManagementLicensesV1Controller.cs" company="APIMatic">
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
    /// SoftwareManagementLicensesV1Controller.
    /// </summary>
    public class SoftwareManagementLicensesV1Controller : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoftwareManagementLicensesV1Controller"/> class.
        /// </summary>
        internal SoftwareManagementLicensesV1Controller(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Assigns licenses to a specified list of devices so that firmware upgrades can be scheduled for those devices.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="body">Required parameter: IMEIs of the devices to assign licenses to..</param>
        /// <returns>Returns the ApiResponse of Models.V1LicensesAssignedRemovedResult response from the API call.</returns>
        [Obsolete]
        public ApiResponse<Models.V1LicensesAssignedRemovedResult> AssignLicensesToDevices(
                string account,
                Models.V1LicensesAssignedRemovedRequest body)
            => CoreHelper.RunTask(AssignLicensesToDevicesAsync(account, body));

        /// <summary>
        /// Assigns licenses to a specified list of devices so that firmware upgrades can be scheduled for those devices.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="body">Required parameter: IMEIs of the devices to assign licenses to..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.V1LicensesAssignedRemovedResult response from the API call.</returns>
        [Obsolete]
        public async Task<ApiResponse<Models.V1LicensesAssignedRemovedResult>> AssignLicensesToDevicesAsync(
                string account,
                Models.V1LicensesAssignedRemovedRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1LicensesAssignedRemovedResult>()
              .Server(Server.SoftwareManagementV1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/licenses/{account}/assign")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("account", account))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV1ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Remove unused licenses from device.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="body">Required parameter: IMEIs of the devices to remove licenses from..</param>
        /// <returns>Returns the ApiResponse of Models.V1LicensesAssignedRemovedResult response from the API call.</returns>
        [Obsolete]
        public ApiResponse<Models.V1LicensesAssignedRemovedResult> RemoveLicensesFromDevices(
                string account,
                Models.V1LicensesAssignedRemovedRequest body)
            => CoreHelper.RunTask(RemoveLicensesFromDevicesAsync(account, body));

        /// <summary>
        /// Remove unused licenses from device.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="body">Required parameter: IMEIs of the devices to remove licenses from..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.V1LicensesAssignedRemovedResult response from the API call.</returns>
        [Obsolete]
        public async Task<ApiResponse<Models.V1LicensesAssignedRemovedResult>> RemoveLicensesFromDevicesAsync(
                string account,
                Models.V1LicensesAssignedRemovedRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1LicensesAssignedRemovedResult>()
              .Server(Server.SoftwareManagementV1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/licenses/{account}/remove")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("account", account))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV1ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a list of devices from which licenses will be removed if the number of MRC licenses becomes less than the number of assigned licenses.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="body">Required parameter: Cancellation candidate device list..</param>
        /// <returns>Returns the ApiResponse of Models.V1ListOfLicensesToRemoveResult response from the API call.</returns>
        [Obsolete]
        public ApiResponse<Models.V1ListOfLicensesToRemoveResult> CreateListOfLicensesToRemove(
                string account,
                Models.V1ListOfLicensesToRemoveRequest body)
            => CoreHelper.RunTask(CreateListOfLicensesToRemoveAsync(account, body));

        /// <summary>
        /// Creates a list of devices from which licenses will be removed if the number of MRC licenses becomes less than the number of assigned licenses.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="body">Required parameter: Cancellation candidate device list..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.V1ListOfLicensesToRemoveResult response from the API call.</returns>
        [Obsolete]
        public async Task<ApiResponse<Models.V1ListOfLicensesToRemoveResult>> CreateListOfLicensesToRemoveAsync(
                string account,
                Models.V1ListOfLicensesToRemoveRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1ListOfLicensesToRemoveResult>()
              .Server(Server.SoftwareManagementV1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/licenses/{account}/cancel")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("account", account))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV1ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Deletes the entire list of cancellation candidate devices.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier in "##########-#####"..</param>
        /// <returns>Returns the ApiResponse of Models.FotaV1SuccessResult response from the API call.</returns>
        [Obsolete]
        public ApiResponse<Models.FotaV1SuccessResult> DeleteListOfLicensesToRemove(
                string account)
            => CoreHelper.RunTask(DeleteListOfLicensesToRemoveAsync(account));

        /// <summary>
        /// Deletes the entire list of cancellation candidate devices.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.FotaV1SuccessResult response from the API call.</returns>
        [Obsolete]
        public async Task<ApiResponse<Models.FotaV1SuccessResult>> DeleteListOfLicensesToRemoveAsync(
                string account,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.FotaV1SuccessResult>()
              .Server(Server.SoftwareManagementV1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/licenses/{account}/cancel")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("account", account))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV1ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns a list of devices from which licenses will be removed if the number of MRC licenses becomes less than the number of assigned licenses.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="startIndex">Required parameter: The zero-based number of the first record to return. Set startIndex=0 for the first request. If there are more than 1,000 devices in the response, set startIndex=1000 for the second request, 2000 for the third request, etc..</param>
        /// <returns>Returns the ApiResponse of Models.V1ListOfLicensesToRemove response from the API call.</returns>
        [Obsolete]
        public ApiResponse<Models.V1ListOfLicensesToRemove> ListLicensesToRemove(
                string account,
                string startIndex)
            => CoreHelper.RunTask(ListLicensesToRemoveAsync(account, startIndex));

        /// <summary>
        /// Returns a list of devices from which licenses will be removed if the number of MRC licenses becomes less than the number of assigned licenses.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="startIndex">Required parameter: The zero-based number of the first record to return. Set startIndex=0 for the first request. If there are more than 1,000 devices in the response, set startIndex=1000 for the second request, 2000 for the third request, etc..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.V1ListOfLicensesToRemove response from the API call.</returns>
        [Obsolete]
        public async Task<ApiResponse<Models.V1ListOfLicensesToRemove>> ListLicensesToRemoveAsync(
                string account,
                string startIndex,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1ListOfLicensesToRemove>()
              .Server(Server.SoftwareManagementV1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/licenses/{account}/cancel/index/{startIndex}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("account", account))
                      .Template(_template => _template.Setup("startIndex", startIndex))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV1ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}