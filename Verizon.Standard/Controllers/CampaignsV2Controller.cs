// <copyright file="CampaignsV2Controller.cs" company="APIMatic">
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
    /// CampaignsV2Controller.
    /// </summary>
    public class CampaignsV2Controller : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignsV2Controller"/> class.
        /// </summary>
        internal CampaignsV2Controller(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// This endpoint allows user to schedule a software upgrade.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="body">Required parameter: Software upgrade information..</param>
        /// <returns>Returns the ApiResponse of Models.CampaignSoftware response from the API call.</returns>
        public ApiResponse<Models.CampaignSoftware> ScheduleCampaignFirmwareUpgrade(
                string account,
                Models.CampaignSoftwareUpgrade body)
            => CoreHelper.RunTask(ScheduleCampaignFirmwareUpgradeAsync(account, body));

        /// <summary>
        /// This endpoint allows user to schedule a software upgrade.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="body">Required parameter: Software upgrade information..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.CampaignSoftware response from the API call.</returns>
        public async Task<ApiResponse<Models.CampaignSoftware>> ScheduleCampaignFirmwareUpgradeAsync(
                string account,
                Models.CampaignSoftwareUpgrade body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CampaignSoftware>()
              .Server(Server.SoftwareManagementV2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/campaigns/{account}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("account", account))
                      .Header(_header => _header.Setup("Content-Type", "*/*"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV2ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint allows user to get information of a software upgrade.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="campaignId">Required parameter: Software upgrade identifier..</param>
        /// <returns>Returns the ApiResponse of Models.CampaignSoftware response from the API call.</returns>
        public ApiResponse<Models.CampaignSoftware> GetCampaignInformation(
                string account,
                string campaignId)
            => CoreHelper.RunTask(GetCampaignInformationAsync(account, campaignId));

        /// <summary>
        /// This endpoint allows user to get information of a software upgrade.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="campaignId">Required parameter: Software upgrade identifier..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.CampaignSoftware response from the API call.</returns>
        public async Task<ApiResponse<Models.CampaignSoftware>> GetCampaignInformationAsync(
                string account,
                string campaignId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CampaignSoftware>()
              .Server(Server.SoftwareManagementV2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/campaigns/{account}/{campaignId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("account", account))
                      .Template(_template => _template.Setup("campaignId", campaignId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV2ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint allows user to Add or Remove devices to an existing software upgrade.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="campaignId">Required parameter: Software upgrade information..</param>
        /// <param name="body">Required parameter: Request to add or remove device to existing software upgrade information..</param>
        /// <returns>Returns the ApiResponse of Models.V2AddOrRemoveDeviceResult response from the API call.</returns>
        public ApiResponse<Models.V2AddOrRemoveDeviceResult> UpdateCampaignFirmwareDevices(
                string account,
                string campaignId,
                Models.V2AddOrRemoveDeviceRequest body)
            => CoreHelper.RunTask(UpdateCampaignFirmwareDevicesAsync(account, campaignId, body));

        /// <summary>
        /// This endpoint allows user to Add or Remove devices to an existing software upgrade.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="campaignId">Required parameter: Software upgrade information..</param>
        /// <param name="body">Required parameter: Request to add or remove device to existing software upgrade information..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.V2AddOrRemoveDeviceResult response from the API call.</returns>
        public async Task<ApiResponse<Models.V2AddOrRemoveDeviceResult>> UpdateCampaignFirmwareDevicesAsync(
                string account,
                string campaignId,
                Models.V2AddOrRemoveDeviceRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V2AddOrRemoveDeviceResult>()
              .Server(Server.SoftwareManagementV2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/campaigns/{account}/{campaignId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("account", account))
                      .Template(_template => _template.Setup("campaignId", campaignId))
                      .Header(_header => _header.Setup("Content-Type", "*/*"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV2ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint allows user to cancel software upgrade. A software upgrade already started can not be cancelled.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="campaignId">Required parameter: Unique identifier of campaign..</param>
        /// <returns>Returns the ApiResponse of Models.FotaV2SuccessResult response from the API call.</returns>
        public ApiResponse<Models.FotaV2SuccessResult> CancelCampaign(
                string account,
                string campaignId)
            => CoreHelper.RunTask(CancelCampaignAsync(account, campaignId));

        /// <summary>
        /// This endpoint allows user to cancel software upgrade. A software upgrade already started can not be cancelled.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="campaignId">Required parameter: Unique identifier of campaign..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.FotaV2SuccessResult response from the API call.</returns>
        public async Task<ApiResponse<Models.FotaV2SuccessResult>> CancelCampaignAsync(
                string account,
                string campaignId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.FotaV2SuccessResult>()
              .Server(Server.SoftwareManagementV2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/campaigns/{account}/{campaignId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("account", account))
                      .Template(_template => _template.Setup("campaignId", campaignId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV2ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint allows user to change campaign dates and time windows. Fields which need to remain unchanged should be also provided.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="campaignId">Required parameter: Software upgrade information..</param>
        /// <param name="body">Required parameter: New dates and time windows..</param>
        /// <returns>Returns the ApiResponse of Models.CampaignSoftware response from the API call.</returns>
        public ApiResponse<Models.CampaignSoftware> UpdateCampaignDates(
                string account,
                string campaignId,
                Models.V2ChangeCampaignDatesRequest body)
            => CoreHelper.RunTask(UpdateCampaignDatesAsync(account, campaignId, body));

        /// <summary>
        /// This endpoint allows user to change campaign dates and time windows. Fields which need to remain unchanged should be also provided.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="campaignId">Required parameter: Software upgrade information..</param>
        /// <param name="body">Required parameter: New dates and time windows..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.CampaignSoftware response from the API call.</returns>
        public async Task<ApiResponse<Models.CampaignSoftware>> UpdateCampaignDatesAsync(
                string account,
                string campaignId,
                Models.V2ChangeCampaignDatesRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CampaignSoftware>()
              .Server(Server.SoftwareManagementV2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/campaigns/{account}/{campaignId}/dates")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("account", account))
                      .Template(_template => _template.Setup("campaignId", campaignId))
                      .Header(_header => _header.Setup("Content-Type", "*/*"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV2ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// You can upload configuration files and schedule them in a campaign to devices.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <param name="body">Required parameter: Device logging information..</param>
        /// <returns>Returns the ApiResponse of Models.UploadAndScheduleFileResponse response from the API call.</returns>
        public ApiResponse<Models.UploadAndScheduleFileResponse> ScheduleFileUpgrade(
                string acc,
                Models.UploadAndScheduleFileRequest body)
            => CoreHelper.RunTask(ScheduleFileUpgradeAsync(acc, body));

        /// <summary>
        /// You can upload configuration files and schedule them in a campaign to devices.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <param name="body">Required parameter: Device logging information..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.UploadAndScheduleFileResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.UploadAndScheduleFileResponse>> ScheduleFileUpgradeAsync(
                string acc,
                Models.UploadAndScheduleFileRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UploadAndScheduleFileResponse>()
              .Server(Server.SoftwareManagementV2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/campaigns/files/{acc}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("acc", acc))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV2ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Campaign time windows for downloading and installing software are available as long as the device OEM supports this.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <param name="body">Required parameter: Device logging information..</param>
        /// <returns>Returns the ApiResponse of Models.UploadAndScheduleFileResponse response from the API call.</returns>
        public ApiResponse<Models.UploadAndScheduleFileResponse> ScheduleSWUpgradeHttpDevices(
                string acc,
                Models.SchedulesSoftwareUpgradeRequest body)
            => CoreHelper.RunTask(ScheduleSWUpgradeHttpDevicesAsync(acc, body));

        /// <summary>
        /// Campaign time windows for downloading and installing software are available as long as the device OEM supports this.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <param name="body">Required parameter: Device logging information..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.UploadAndScheduleFileResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.UploadAndScheduleFileResponse>> ScheduleSWUpgradeHttpDevicesAsync(
                string acc,
                Models.SchedulesSoftwareUpgradeRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UploadAndScheduleFileResponse>()
              .Server(Server.SoftwareManagementV2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/campaigns/software/{acc}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("acc", acc))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV2ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}