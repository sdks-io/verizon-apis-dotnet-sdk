// <copyright file="WirelessNetworkPerformanceController.cs" company="APIMatic">
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
    /// WirelessNetworkPerformanceController.
    /// </summary>
    public class WirelessNetworkPerformanceController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WirelessNetworkPerformanceController"/> class.
        /// </summary>
        internal WirelessNetworkPerformanceController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// WNP Query for current network condition.
        /// </summary>
        /// <param name="body">Required parameter: Request for current network health..</param>
        /// <returns>Returns the ApiResponse of Models.WNPRequestResponse response from the API call.</returns>
        public ApiResponse<Models.WNPRequestResponse> NearRealTimeNetworkConditions(
                Models.GetNetworkConditionsRequest body)
            => CoreHelper.RunTask(NearRealTimeNetworkConditionsAsync(body));

        /// <summary>
        /// WNP Query for current network condition.
        /// </summary>
        /// <param name="body">Required parameter: Request for current network health..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.WNPRequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.WNPRequestResponse>> NearRealTimeNetworkConditionsAsync(
                Models.GetNetworkConditionsRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WNPRequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/intelligence/network-conditions")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new WNPRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Run a report to determine network types available and available coverage. Network types covered include: CAT-M, NB-IOT, LTE, LTE-AWS and 5GNW.
        /// </summary>
        /// <param name="body">Required parameter: Request for network coverage details..</param>
        /// <returns>Returns the ApiResponse of Models.WNPRequestResponse response from the API call.</returns>
        public ApiResponse<Models.WNPRequestResponse> Domestic4GAnd5gNationwideNetworkCoverage(
                Models.GetWirelessCoverageRequest body)
            => CoreHelper.RunTask(Domestic4GAnd5gNationwideNetworkCoverageAsync(body));

        /// <summary>
        /// Run a report to determine network types available and available coverage. Network types covered include: CAT-M, NB-IOT, LTE, LTE-AWS and 5GNW.
        /// </summary>
        /// <param name="body">Required parameter: Request for network coverage details..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.WNPRequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.WNPRequestResponse>> Domestic4GAnd5gNationwideNetworkCoverageAsync(
                Models.GetWirelessCoverageRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WNPRequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/intelligence/wireless-coverage")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new WNPRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Identify the direction and general distance of nearby cell sites and the technology supported by the equipment.
        /// </summary>
        /// <param name="body">Required parameter: Request for cell site proximity..</param>
        /// <returns>Returns the ApiResponse of Models.WNPRequestResponse response from the API call.</returns>
        public ApiResponse<Models.WNPRequestResponse> SiteProximity(
                Models.GetNetworkConditionsRequest body)
            => CoreHelper.RunTask(SiteProximityAsync(body));

        /// <summary>
        /// Identify the direction and general distance of nearby cell sites and the technology supported by the equipment.
        /// </summary>
        /// <param name="body">Required parameter: Request for cell site proximity..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.WNPRequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.WNPRequestResponse>> SiteProximityAsync(
                Models.GetNetworkConditionsRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WNPRequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/intelligence/site-proximity/action/list")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new WNPRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// A report of a specific device's service scores over a 30 day period.
        /// </summary>
        /// <param name="body">Required parameter: Request for a device's 30 day experience..</param>
        /// <returns>Returns the ApiResponse of Models.WNPRequestResponse response from the API call.</returns>
        public ApiResponse<Models.WNPRequestResponse> DeviceExperience30daysHistory(
                Models.GetDeviceExperienceScoreHistoryRequest body)
            => CoreHelper.RunTask(DeviceExperience30daysHistoryAsync(body));

        /// <summary>
        /// A report of a specific device's service scores over a 30 day period.
        /// </summary>
        /// <param name="body">Required parameter: Request for a device's 30 day experience..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.WNPRequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.WNPRequestResponse>> DeviceExperience30daysHistoryAsync(
                Models.GetDeviceExperienceScoreHistoryRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WNPRequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/intelligence/device-experience/history/30-days")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new WNPRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Run a report to view the latest device experience score for specific devices.
        /// </summary>
        /// <param name="body">Required parameter: Request for bulk latest history details..</param>
        /// <returns>Returns the ApiResponse of Models.WNPRequestResponse response from the API call.</returns>
        public ApiResponse<Models.WNPRequestResponse> DeviceExperienceBulkLatest(
                Models.GetDeviceExperienceScoreBulkRequest body)
            => CoreHelper.RunTask(DeviceExperienceBulkLatestAsync(body));

        /// <summary>
        /// Run a report to view the latest device experience score for specific devices.
        /// </summary>
        /// <param name="body">Required parameter: Request for bulk latest history details..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.WNPRequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.WNPRequestResponse>> DeviceExperienceBulkLatestAsync(
                Models.GetDeviceExperienceScoreBulkRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WNPRequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/intelligence/device-experience/bulk/latest")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new WNPRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}