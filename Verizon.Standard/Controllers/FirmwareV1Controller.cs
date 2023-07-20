// <copyright file="FirmwareV1Controller.cs" company="APIMatic">
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
    /// FirmwareV1Controller.
    /// </summary>
    public class FirmwareV1Controller : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FirmwareV1Controller"/> class.
        /// </summary>
        internal FirmwareV1Controller(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Add or remove devices from a scheduled upgrade.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="upgradeId">Required parameter: The UUID of the upgrade, returned by POST /upgrades when the upgrade was scheduled..</param>
        /// <param name="body">Required parameter: List of devices to add or remove..</param>
        /// <returns>Returns the ApiResponse of Models.FirmwareUpgradeChangeResult response from the API call.</returns>
        public ApiResponse<Models.FirmwareUpgradeChangeResult> UpdateFirmwareUpgradeDevices(
                string account,
                string upgradeId,
                Models.FirmwareUpgradeChangeRequest body)
            => CoreHelper.RunTask(UpdateFirmwareUpgradeDevicesAsync(account, upgradeId, body));

        /// <summary>
        /// Add or remove devices from a scheduled upgrade.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="upgradeId">Required parameter: The UUID of the upgrade, returned by POST /upgrades when the upgrade was scheduled..</param>
        /// <param name="body">Required parameter: List of devices to add or remove..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.FirmwareUpgradeChangeResult response from the API call.</returns>
        public async Task<ApiResponse<Models.FirmwareUpgradeChangeResult>> UpdateFirmwareUpgradeDevicesAsync(
                string account,
                string upgradeId,
                Models.FirmwareUpgradeChangeRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.FirmwareUpgradeChangeResult>()
              .Server(Server.SoftwareManagementV1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/upgrades/{account}/upgrade/{upgradeId}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("account", account))
                      .Template(_template => _template.Setup("upgradeId", upgradeId))
                      .Header(_header => _header.Setup("Content-Type", "*/*"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV1ResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.FirmwareUpgradeChangeResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Schedules a firmware upgrade for devices.
        /// </summary>
        /// <param name="body">Required parameter: Details of the firmware upgrade request..</param>
        /// <returns>Returns the ApiResponse of Models.FirmwareUpgrade response from the API call.</returns>
        public ApiResponse<Models.FirmwareUpgrade> ScheduleFirmwareUpgrade(
                Models.FirmwareUpgradeRequest body)
            => CoreHelper.RunTask(ScheduleFirmwareUpgradeAsync(body));

        /// <summary>
        /// Schedules a firmware upgrade for devices.
        /// </summary>
        /// <param name="body">Required parameter: Details of the firmware upgrade request..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.FirmwareUpgrade response from the API call.</returns>
        public async Task<ApiResponse<Models.FirmwareUpgrade>> ScheduleFirmwareUpgradeAsync(
                Models.FirmwareUpgradeRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.FirmwareUpgrade>()
              .Server(Server.SoftwareManagementV1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/upgrades")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV1ResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.FirmwareUpgrade>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Cancel a scheduled firmware upgrade.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="upgradeId">Required parameter: The UUID of the scheduled upgrade that you want to cancel..</param>
        /// <returns>Returns the ApiResponse of Models.FotaV1SuccessResult response from the API call.</returns>
        public ApiResponse<Models.FotaV1SuccessResult> CancelScheduledFirmwareUpgrade(
                string account,
                string upgradeId)
            => CoreHelper.RunTask(CancelScheduledFirmwareUpgradeAsync(account, upgradeId));

        /// <summary>
        /// Cancel a scheduled firmware upgrade.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="upgradeId">Required parameter: The UUID of the scheduled upgrade that you want to cancel..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.FotaV1SuccessResult response from the API call.</returns>
        public async Task<ApiResponse<Models.FotaV1SuccessResult>> CancelScheduledFirmwareUpgradeAsync(
                string account,
                string upgradeId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.FotaV1SuccessResult>()
              .Server(Server.SoftwareManagementV1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/upgrades/{account}/upgrade/{upgradeId}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("account", account))
                      .Template(_template => _template.Setup("upgradeId", upgradeId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV1ResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.FotaV1SuccessResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Lists all device firmware images available for an account, based on the devices registered to that account.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier in "##########-#####"..</param>
        /// <returns>Returns the ApiResponse of List<Models.Firmware> response from the API call.</returns>
        public ApiResponse<List<Models.Firmware>> ListAvailableFirmware(
                string account)
            => CoreHelper.RunTask(ListAvailableFirmwareAsync(account));

        /// <summary>
        /// Lists all device firmware images available for an account, based on the devices registered to that account.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List<Models.Firmware> response from the API call.</returns>
        public async Task<ApiResponse<List<Models.Firmware>>> ListAvailableFirmwareAsync(
                string account,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.Firmware>>()
              .Server(Server.SoftwareManagementV1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/firmware/{account}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("account", account))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV1ResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<List<Models.Firmware>>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Returns information about a specified upgrade, include the target date of the upgrade, the list of devices in the upgrade, and the status of the upgrade for each device.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="upgradeId">Required parameter: The UUID of the upgrade, returned by POST /upgrades when the upgrade was scheduled..</param>
        /// <returns>Returns the ApiResponse of Models.FirmwareUpgrade response from the API call.</returns>
        public ApiResponse<Models.FirmwareUpgrade> ListFirmwareUpgradeDetails(
                string account,
                string upgradeId)
            => CoreHelper.RunTask(ListFirmwareUpgradeDetailsAsync(account, upgradeId));

        /// <summary>
        /// Returns information about a specified upgrade, include the target date of the upgrade, the list of devices in the upgrade, and the status of the upgrade for each device.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="upgradeId">Required parameter: The UUID of the upgrade, returned by POST /upgrades when the upgrade was scheduled..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.FirmwareUpgrade response from the API call.</returns>
        public async Task<ApiResponse<Models.FirmwareUpgrade>> ListFirmwareUpgradeDetailsAsync(
                string account,
                string upgradeId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.FirmwareUpgrade>()
              .Server(Server.SoftwareManagementV1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/upgrades/{account}/upgrade/{upgradeId}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("account", account))
                      .Template(_template => _template.Setup("upgradeId", upgradeId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV1ResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.FirmwareUpgrade>(_response)))
              .ExecuteAsync(cancellationToken);
    }
}