// <copyright file="DeviceGroupsController.cs" company="APIMatic">
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
    /// DeviceGroupsController.
    /// </summary>
    public class DeviceGroupsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceGroupsController"/> class.
        /// </summary>
        internal DeviceGroupsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Create a new device group and optionally add devices to the group. Device groups can make it easier to manage similar devices and to get reports on their usage.
        /// </summary>
        /// <param name="body">Required parameter: A request to create a new device group..</param>
        /// <returns>Returns the ApiResponse of Models.ConnectivityManagementSuccessResult response from the API call.</returns>
        public ApiResponse<Models.ConnectivityManagementSuccessResult> CreateDeviceGroup(
                Models.CreateDeviceGroupRequest body)
            => CoreHelper.RunTask(CreateDeviceGroupAsync(body));

        /// <summary>
        /// Create a new device group and optionally add devices to the group. Device groups can make it easier to manage similar devices and to get reports on their usage.
        /// </summary>
        /// <param name="body">Required parameter: A request to create a new device group..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ConnectivityManagementSuccessResult response from the API call.</returns>
        public async Task<ApiResponse<Models.ConnectivityManagementSuccessResult>> CreateDeviceGroupAsync(
                Models.CreateDeviceGroupRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ConnectivityManagementSuccessResult>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/groups")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns a list of all device groups in a specified account.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <returns>Returns the ApiResponse of List<Models.DeviceGroup> response from the API call.</returns>
        public ApiResponse<List<Models.DeviceGroup>> ListDeviceGroups(
                string aname)
            => CoreHelper.RunTask(ListDeviceGroupsAsync(aname));

        /// <summary>
        /// Returns a list of all device groups in a specified account.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List<Models.DeviceGroup> response from the API call.</returns>
        public async Task<ApiResponse<List<Models.DeviceGroup>>> ListDeviceGroupsAsync(
                string aname,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.DeviceGroup>>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/m2m/v1/groups/{aname}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("aname", aname))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// When HTTP status is 202, a URL will be returned in the Location header of the form /groups/{aname}/name/{gname}/?next={token}. This URL can be used to request the next set of groups.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <param name="gname">Required parameter: Group name..</param>
        /// <param name="next">Optional parameter: Continue the previous query from the pageUrl pagetoken..</param>
        /// <returns>Returns the ApiResponse of Models.DeviceGroupDevicesData response from the API call.</returns>
        public ApiResponse<Models.DeviceGroupDevicesData> GetDeviceGroupInformation(
                string aname,
                string gname,
                long? next = null)
            => CoreHelper.RunTask(GetDeviceGroupInformationAsync(aname, gname, next));

        /// <summary>
        /// When HTTP status is 202, a URL will be returned in the Location header of the form /groups/{aname}/name/{gname}/?next={token}. This URL can be used to request the next set of groups.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <param name="gname">Required parameter: Group name..</param>
        /// <param name="next">Optional parameter: Continue the previous query from the pageUrl pagetoken..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeviceGroupDevicesData response from the API call.</returns>
        public async Task<ApiResponse<Models.DeviceGroupDevicesData>> GetDeviceGroupInformationAsync(
                string aname,
                string gname,
                long? next = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeviceGroupDevicesData>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/m2m/v1/groups/{aname}/name/{gname}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("aname", aname))
                      .Template(_template => _template.Setup("gname", gname))
                      .Query(_query => _query.Setup("next", next))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Make changes to a device group, including changing the name and description, and adding or removing devices.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <param name="gname">Required parameter: Group name..</param>
        /// <param name="body">Required parameter: Request to update device group..</param>
        /// <returns>Returns the ApiResponse of Models.ConnectivityManagementSuccessResult response from the API call.</returns>
        public ApiResponse<Models.ConnectivityManagementSuccessResult> UpdateDeviceGroup(
                string aname,
                string gname,
                Models.DeviceGroupUpdateRequest body)
            => CoreHelper.RunTask(UpdateDeviceGroupAsync(aname, gname, body));

        /// <summary>
        /// Make changes to a device group, including changing the name and description, and adding or removing devices.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <param name="gname">Required parameter: Group name..</param>
        /// <param name="body">Required parameter: Request to update device group..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ConnectivityManagementSuccessResult response from the API call.</returns>
        public async Task<ApiResponse<Models.ConnectivityManagementSuccessResult>> UpdateDeviceGroupAsync(
                string aname,
                string gname,
                Models.DeviceGroupUpdateRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ConnectivityManagementSuccessResult>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/m2m/v1/groups/{aname}/name/{gname}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("aname", aname))
                      .Template(_template => _template.Setup("gname", gname))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Deletes a device group from the account. Devices in the group are moved to the default device group and are not deleted from the account.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <param name="gname">Required parameter: Group name..</param>
        /// <returns>Returns the ApiResponse of Models.ConnectivityManagementSuccessResult response from the API call.</returns>
        public ApiResponse<Models.ConnectivityManagementSuccessResult> DeleteDeviceGroup(
                string aname,
                string gname)
            => CoreHelper.RunTask(DeleteDeviceGroupAsync(aname, gname));

        /// <summary>
        /// Deletes a device group from the account. Devices in the group are moved to the default device group and are not deleted from the account.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <param name="gname">Required parameter: Group name..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ConnectivityManagementSuccessResult response from the API call.</returns>
        public async Task<ApiResponse<Models.ConnectivityManagementSuccessResult>> DeleteDeviceGroupAsync(
                string aname,
                string gname,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ConnectivityManagementSuccessResult>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/m2m/v1/groups/{aname}/name/{gname}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("aname", aname))
                      .Template(_template => _template.Setup("gname", gname))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}