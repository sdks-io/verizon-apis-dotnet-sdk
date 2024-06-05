// <copyright file="SoftwareManagementReportsV2Controller.cs" company="APIMatic">
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
    /// SoftwareManagementReportsV2Controller.
    /// </summary>
    public class SoftwareManagementReportsV2Controller : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoftwareManagementReportsV2Controller"/> class.
        /// </summary>
        internal SoftwareManagementReportsV2Controller(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// This endpoint allows user to list a certain type of software of an account.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="distributionType">Optional parameter: Filter distributionType to get specific type of software. Value is LWM2M, OMD-DM or HTTP..</param>
        /// <returns>Returns the ApiResponse of List<Models.SoftwarePackage> response from the API call.</returns>
        public ApiResponse<List<Models.SoftwarePackage>> ListAvailableSoftware(
                string account,
                string distributionType = null)
            => CoreHelper.RunTask(ListAvailableSoftwareAsync(account, distributionType));

        /// <summary>
        /// This endpoint allows user to list a certain type of software of an account.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="distributionType">Optional parameter: Filter distributionType to get specific type of software. Value is LWM2M, OMD-DM or HTTP..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List<Models.SoftwarePackage> response from the API call.</returns>
        public async Task<ApiResponse<List<Models.SoftwarePackage>>> ListAvailableSoftwareAsync(
                string account,
                string distributionType = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.SoftwarePackage>>()
              .Server(Server.SoftwareManagementV2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/software/{account}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("account", account))
                      .Query(_query => _query.Setup("distributionType", distributionType))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV2ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// The device endpoint gets devices information of an account.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="lastSeenDeviceId">Optional parameter: Last seen device identifier..</param>
        /// <param name="distributionType">Optional parameter: Filter distributionType to get specific type of devices. Values is LWM2M, OMD-DM or HTTP..</param>
        /// <returns>Returns the ApiResponse of Models.V2AccountDeviceList response from the API call.</returns>
        public ApiResponse<Models.V2AccountDeviceList> ListAccountDevices(
                string account,
                string lastSeenDeviceId = null,
                string distributionType = null)
            => CoreHelper.RunTask(ListAccountDevicesAsync(account, lastSeenDeviceId, distributionType));

        /// <summary>
        /// The device endpoint gets devices information of an account.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="lastSeenDeviceId">Optional parameter: Last seen device identifier..</param>
        /// <param name="distributionType">Optional parameter: Filter distributionType to get specific type of devices. Values is LWM2M, OMD-DM or HTTP..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.V2AccountDeviceList response from the API call.</returns>
        public async Task<ApiResponse<Models.V2AccountDeviceList>> ListAccountDevicesAsync(
                string account,
                string lastSeenDeviceId = null,
                string distributionType = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V2AccountDeviceList>()
              .Server(Server.SoftwareManagementV2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/devices/{account}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("account", account))
                      .Query(_query => _query.Setup("lastSeenDeviceId", lastSeenDeviceId))
                      .Query(_query => _query.Setup("distributionType", distributionType))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV2ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// The endpoint allows user to get software upgrade history of a device based on device IMEI.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="deviceId">Required parameter: Device IMEI identifier..</param>
        /// <returns>Returns the ApiResponse of List<Models.DeviceSoftwareUpgrade> response from the API call.</returns>
        public ApiResponse<List<Models.DeviceSoftwareUpgrade>> GetDeviceFirmwareUpgradeHistory(
                string account,
                string deviceId)
            => CoreHelper.RunTask(GetDeviceFirmwareUpgradeHistoryAsync(account, deviceId));

        /// <summary>
        /// The endpoint allows user to get software upgrade history of a device based on device IMEI.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="deviceId">Required parameter: Device IMEI identifier..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List<Models.DeviceSoftwareUpgrade> response from the API call.</returns>
        public async Task<ApiResponse<List<Models.DeviceSoftwareUpgrade>>> GetDeviceFirmwareUpgradeHistoryAsync(
                string account,
                string deviceId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.DeviceSoftwareUpgrade>>()
              .Server(Server.SoftwareManagementV2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/reports/{account}/devices/{deviceId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("account", account))
                      .Template(_template => _template.Setup("deviceId", deviceId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV2ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// The report endpoint allows user to get campaign history of an account for specified status.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="campaignStatus">Required parameter: Status of the campaign..</param>
        /// <param name="lastSeenCampaignId">Optional parameter: Last seen campaign Id..</param>
        /// <returns>Returns the ApiResponse of Models.V2CampaignHistory response from the API call.</returns>
        public ApiResponse<Models.V2CampaignHistory> GetCampaignHistoryByStatus(
                string account,
                string campaignStatus,
                string lastSeenCampaignId = null)
            => CoreHelper.RunTask(GetCampaignHistoryByStatusAsync(account, campaignStatus, lastSeenCampaignId));

        /// <summary>
        /// The report endpoint allows user to get campaign history of an account for specified status.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="campaignStatus">Required parameter: Status of the campaign..</param>
        /// <param name="lastSeenCampaignId">Optional parameter: Last seen campaign Id..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.V2CampaignHistory response from the API call.</returns>
        public async Task<ApiResponse<Models.V2CampaignHistory>> GetCampaignHistoryByStatusAsync(
                string account,
                string campaignStatus,
                string lastSeenCampaignId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V2CampaignHistory>()
              .Server(Server.SoftwareManagementV2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/reports/{account}/campaigns")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("account", account))
                      .Query(_query => _query.Setup("campaignStatus", campaignStatus))
                      .Query(_query => _query.Setup("lastSeenCampaignId", lastSeenCampaignId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV2ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// The report endpoint allows user to get the full list of device of a campaign.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="campaignId">Required parameter: Campaign identifier..</param>
        /// <param name="lastSeenDeviceId">Optional parameter: Last seen device identifier..</param>
        /// <returns>Returns the ApiResponse of Models.V2CampaignDevice response from the API call.</returns>
        public ApiResponse<Models.V2CampaignDevice> GetCampaignDeviceStatus(
                string account,
                string campaignId,
                string lastSeenDeviceId = null)
            => CoreHelper.RunTask(GetCampaignDeviceStatusAsync(account, campaignId, lastSeenDeviceId));

        /// <summary>
        /// The report endpoint allows user to get the full list of device of a campaign.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="campaignId">Required parameter: Campaign identifier..</param>
        /// <param name="lastSeenDeviceId">Optional parameter: Last seen device identifier..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.V2CampaignDevice response from the API call.</returns>
        public async Task<ApiResponse<Models.V2CampaignDevice>> GetCampaignDeviceStatusAsync(
                string account,
                string campaignId,
                string lastSeenDeviceId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V2CampaignDevice>()
              .Server(Server.SoftwareManagementV2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/reports/{account}/campaigns/{campaignId}/devices")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("account", account))
                      .Template(_template => _template.Setup("campaignId", campaignId))
                      .Query(_query => _query.Setup("lastSeenDeviceId", lastSeenDeviceId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV2ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}