// <copyright file="SoftwareManagementReportsV1Controller.cs" company="APIMatic">
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
    using Verizon.Standard.Authentication;
    using Verizon.Standard.Exceptions;
    using Verizon.Standard.Http.Client;
    using Verizon.Standard.Http.Response;
    using Verizon.Standard.Utilities;

    /// <summary>
    /// SoftwareManagementReportsV1Controller.
    /// </summary>
    public class SoftwareManagementReportsV1Controller : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoftwareManagementReportsV1Controller"/> class.
        /// </summary>
        internal SoftwareManagementReportsV1Controller(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Returns a list of all upgrades with a specified status.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="upgradeStatus">Required parameter: The status of the upgrades that you want to retrieve..</param>
        /// <param name="startIndex">Required parameter: The zero-based number of the first record to return. Set startIndex=0 for the first request. If `hasMoreFlag`=true in the response, use the `lastSeenUpgradeId` value from the response as the startIndex in the next request..</param>
        /// <returns>Returns the ApiResponse of Models.UpgradeListQueryResult response from the API call.</returns>
        public ApiResponse<Models.UpgradeListQueryResult> ListUpgradesForSpecifiedStatus(
                string account,
                Models.UpgradeStatusEnum upgradeStatus,
                string startIndex)
            => CoreHelper.RunTask(ListUpgradesForSpecifiedStatusAsync(account, upgradeStatus, startIndex));

        /// <summary>
        /// Returns a list of all upgrades with a specified status.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="upgradeStatus">Required parameter: The status of the upgrades that you want to retrieve..</param>
        /// <param name="startIndex">Required parameter: The zero-based number of the first record to return. Set startIndex=0 for the first request. If `hasMoreFlag`=true in the response, use the `lastSeenUpgradeId` value from the response as the startIndex in the next request..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.UpgradeListQueryResult response from the API call.</returns>
        public async Task<ApiResponse<Models.UpgradeListQueryResult>> ListUpgradesForSpecifiedStatusAsync(
                string account,
                Models.UpgradeStatusEnum upgradeStatus,
                string startIndex,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UpgradeListQueryResult>()
              .Server(Server.SoftwareManagementV1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/reports/{account}/status/{upgradeStatus}/index/{startIndex}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("account", account))
                      .Template(_template => _template.Setup("upgradeStatus", ApiHelper.JsonSerialize(upgradeStatus).Trim('\"')))
                      .Template(_template => _template.Setup("startIndex", startIndex))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV1ResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.UpgradeListQueryResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Returns an array of all devices in the specified account. Each device object includes information needed for managing firmware, including the device make and model, MDN and IMEI, and current firmware version.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="startIndex">Required parameter: Only return devices with IMEIs larger than this value. Use 0 for the first request. If `hasMoreData`=true in the response, use the `lastSeenDeviceId` value from the response as the startIndex in the next request..</param>
        /// <returns>Returns the ApiResponse of Models.DeviceListQueryResult response from the API call.</returns>
        public ApiResponse<Models.DeviceListQueryResult> ListAccountDevices(
                string account,
                string startIndex)
            => CoreHelper.RunTask(ListAccountDevicesAsync(account, startIndex));

        /// <summary>
        /// Returns an array of all devices in the specified account. Each device object includes information needed for managing firmware, including the device make and model, MDN and IMEI, and current firmware version.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="startIndex">Required parameter: Only return devices with IMEIs larger than this value. Use 0 for the first request. If `hasMoreData`=true in the response, use the `lastSeenDeviceId` value from the response as the startIndex in the next request..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeviceListQueryResult response from the API call.</returns>
        public async Task<ApiResponse<Models.DeviceListQueryResult>> ListAccountDevicesAsync(
                string account,
                string startIndex,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeviceListQueryResult>()
              .Server(Server.SoftwareManagementV1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/devices/{account}/index/{startIndex}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("account", account))
                      .Template(_template => _template.Setup("startIndex", startIndex))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV1ResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.DeviceListQueryResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Returns the upgrade history of the specified device from the previous six months.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="deviceId">Required parameter: The IMEI of the device..</param>
        /// <returns>Returns the ApiResponse of List<Models.DeviceUpgradeHistory> response from the API call.</returns>
        public ApiResponse<List<Models.DeviceUpgradeHistory>> GetDeviceFirmwareUpgradeHistory(
                string account,
                string deviceId)
            => CoreHelper.RunTask(GetDeviceFirmwareUpgradeHistoryAsync(account, deviceId));

        /// <summary>
        /// Returns the upgrade history of the specified device from the previous six months.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="deviceId">Required parameter: The IMEI of the device..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List<Models.DeviceUpgradeHistory> response from the API call.</returns>
        public async Task<ApiResponse<List<Models.DeviceUpgradeHistory>>> GetDeviceFirmwareUpgradeHistoryAsync(
                string account,
                string deviceId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.DeviceUpgradeHistory>>()
              .Server(Server.SoftwareManagementV1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/reports/{account}/devices/{deviceId}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("account", account))
                      .Template(_template => _template.Setup("deviceId", deviceId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV1ResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<List<Models.DeviceUpgradeHistory>>(_response)))
              .ExecuteAsync(cancellationToken);
    }
}