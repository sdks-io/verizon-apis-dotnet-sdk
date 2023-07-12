// <copyright file="SoftwareManagementReportsV3Controller.cs" company="APIMatic">
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
    /// SoftwareManagementReportsV3Controller.
    /// </summary>
    public class SoftwareManagementReportsV3Controller : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoftwareManagementReportsV3Controller"/> class.
        /// </summary>
        internal SoftwareManagementReportsV3Controller(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Retrieve a list of campaigns for an account that have a specified campaign status.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <param name="campaignStatus">Required parameter: Campaign status..</param>
        /// <param name="lastSeenCampaignId">Optional parameter: Last seen campaign Id..</param>
        /// <returns>Returns the ApiResponse of Models.V3CampaignHistory response from the API call.</returns>
        public ApiResponse<Models.V3CampaignHistory> GetCampaignHistoryByStatus(
                string acc,
                Models.CampaignStatusEnum campaignStatus,
                string lastSeenCampaignId = null)
            => CoreHelper.RunTask(GetCampaignHistoryByStatusAsync(acc, campaignStatus, lastSeenCampaignId));

        /// <summary>
        /// Retrieve a list of campaigns for an account that have a specified campaign status.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <param name="campaignStatus">Required parameter: Campaign status..</param>
        /// <param name="lastSeenCampaignId">Optional parameter: Last seen campaign Id..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.V3CampaignHistory response from the API call.</returns>
        public async Task<ApiResponse<Models.V3CampaignHistory>> GetCampaignHistoryByStatusAsync(
                string acc,
                Models.CampaignStatusEnum campaignStatus,
                string lastSeenCampaignId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V3CampaignHistory>()
              .Server(Server.SoftwareManagementV3)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/reports/{acc}/firmware/campaigns")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("acc", acc))
                      .Query(_query => _query.Setup("campaignStatus", ApiHelper.JsonSerialize(campaignStatus).Trim('\"')))
                      .Query(_query => _query.Setup("lastSeenCampaignId", lastSeenCampaignId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV3ResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.V3CampaignHistory>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Retrieve campaign history for a specific device.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <param name="deviceId">Required parameter: Device IMEI identifier..</param>
        /// <returns>Returns the ApiResponse of List<Models.DeviceFirmwareUpgrade> response from the API call.</returns>
        public ApiResponse<List<Models.DeviceFirmwareUpgrade>> GetDeviceFirmwareUpgradeHistory(
                string acc,
                string deviceId)
            => CoreHelper.RunTask(GetDeviceFirmwareUpgradeHistoryAsync(acc, deviceId));

        /// <summary>
        /// Retrieve campaign history for a specific device.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <param name="deviceId">Required parameter: Device IMEI identifier..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List<Models.DeviceFirmwareUpgrade> response from the API call.</returns>
        public async Task<ApiResponse<List<Models.DeviceFirmwareUpgrade>>> GetDeviceFirmwareUpgradeHistoryAsync(
                string acc,
                string deviceId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.DeviceFirmwareUpgrade>>()
              .Server(Server.SoftwareManagementV3)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/reports/{acc}/devices/{deviceId}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("acc", acc))
                      .Template(_template => _template.Setup("deviceId", deviceId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV3ResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<List<Models.DeviceFirmwareUpgrade>>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Retrieve a list of all devices in a campaign and the status of each device.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <param name="campaignId">Required parameter: Campaign identifier..</param>
        /// <param name="lastSeenDeviceId">Optional parameter: Last seen device identifier..</param>
        /// <returns>Returns the ApiResponse of Models.V3CampaignDevice response from the API call.</returns>
        public ApiResponse<Models.V3CampaignDevice> GetCampaignDeviceStatus(
                string acc,
                string campaignId,
                string lastSeenDeviceId = null)
            => CoreHelper.RunTask(GetCampaignDeviceStatusAsync(acc, campaignId, lastSeenDeviceId));

        /// <summary>
        /// Retrieve a list of all devices in a campaign and the status of each device.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <param name="campaignId">Required parameter: Campaign identifier..</param>
        /// <param name="lastSeenDeviceId">Optional parameter: Last seen device identifier..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.V3CampaignDevice response from the API call.</returns>
        public async Task<ApiResponse<Models.V3CampaignDevice>> GetCampaignDeviceStatusAsync(
                string acc,
                string campaignId,
                string lastSeenDeviceId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V3CampaignDevice>()
              .Server(Server.SoftwareManagementV3)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/reports/{acc}/campaigns/{campaignId}/devices")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("acc", acc))
                      .Template(_template => _template.Setup("campaignId", campaignId))
                      .Query(_query => _query.Setup("lastSeenDeviceId", lastSeenDeviceId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV3ResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.V3CampaignDevice>(_response)))
              .ExecuteAsync(cancellationToken);
    }
}