// <copyright file="MECController.cs" company="APIMatic">
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
    using Verizon.Standard.Http.Client;
    using Verizon.Standard.Http.Response;
    using Verizon.Standard.Utilities;

    /// <summary>
    /// MECController.
    /// </summary>
    public class MECController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MECController"/> class.
        /// </summary>
        internal MECController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// KPIList EndPoint.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <returns>Returns the ApiResponse of Models.KPIInfoList response from the API call.</returns>
        public ApiResponse<Models.KPIInfoList> KPIList(
                string aname)
            => CoreHelper.RunTask(KPIListAsync(aname));

        /// <summary>
        /// KPIList EndPoint.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.KPIInfoList response from the API call.</returns>
        public async Task<ApiResponse<Models.KPIInfoList>> KPIListAsync(
                string aname,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.KPIInfoList>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/m2m/v1/devices/mec/kpi/list/{aname}")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("aname", aname))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// GetProfileList EndPoint.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <returns>Returns the ApiResponse of Models.MECProfileList response from the API call.</returns>
        public ApiResponse<Models.MECProfileList> GetProfileList(
                string aname)
            => CoreHelper.RunTask(GetProfileListAsync(aname));

        /// <summary>
        /// GetProfileList EndPoint.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.MECProfileList response from the API call.</returns>
        public async Task<ApiResponse<Models.MECProfileList>> GetProfileListAsync(
                string aname,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.MECProfileList>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/m2m/v1/devices/mec/profiles/list/{aname}")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("aname", aname))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// ChangePmecDeviceState-Activate EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.ChangeMecDeviceStateResponse response from the API call.</returns>
        public ApiResponse<Models.ChangeMecDeviceStateResponse> ChangePmecDeviceStateActivate(
                Models.ChangePmecDeviceStateActivateRequest body)
            => CoreHelper.RunTask(ChangePmecDeviceStateActivateAsync(body));

        /// <summary>
        /// ChangePmecDeviceState-Activate EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ChangeMecDeviceStateResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.ChangeMecDeviceStateResponse>> ChangePmecDeviceStateActivateAsync(
                Models.ChangePmecDeviceStateActivateRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ChangeMecDeviceStateResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/devices/mec/actions/state/activate")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// ChangePmecDeviceState-BulkDeactivate EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.ChangeMecDeviceStateResponse response from the API call.</returns>
        public ApiResponse<Models.ChangeMecDeviceStateResponse> ChangePmecDeviceStateBulkDeactivate(
                Models.ChangePmecDeviceStateBulkDeactivateRequest body)
            => CoreHelper.RunTask(ChangePmecDeviceStateBulkDeactivateAsync(body));

        /// <summary>
        /// ChangePmecDeviceState-BulkDeactivate EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ChangeMecDeviceStateResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.ChangeMecDeviceStateResponse>> ChangePmecDeviceStateBulkDeactivateAsync(
                Models.ChangePmecDeviceStateBulkDeactivateRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ChangeMecDeviceStateResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/devices/mec/actions/state/deactivate")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// ChangePmecDeviceProfile EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.ChangeMecDeviceProfileResponse response from the API call.</returns>
        public ApiResponse<Models.ChangeMecDeviceProfileResponse> ChangePmecDeviceProfile(
                Models.ChangePmecDeviceProfileRequest body)
            => CoreHelper.RunTask(ChangePmecDeviceProfileAsync(body));

        /// <summary>
        /// ChangePmecDeviceProfile EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ChangeMecDeviceProfileResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.ChangeMecDeviceProfileResponse>> ChangePmecDeviceProfileAsync(
                Models.ChangePmecDeviceProfileRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ChangeMecDeviceProfileResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/devices/mec/actions/profile")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// ChangePmecDeviceIPaddressBulk EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.ChangeMecDeviceIPAddressResponse response from the API call.</returns>
        public ApiResponse<Models.ChangeMecDeviceIPAddressResponse> ChangePmecDeviceIPaddressBulk(
                Models.ChangePmecDeviceStateBulkDeactivateRequest body)
            => CoreHelper.RunTask(ChangePmecDeviceIPaddressBulkAsync(body));

        /// <summary>
        /// ChangePmecDeviceIPaddressBulk EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ChangeMecDeviceIPAddressResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.ChangeMecDeviceIPAddressResponse>> ChangePmecDeviceIPaddressBulkAsync(
                Models.ChangePmecDeviceStateBulkDeactivateRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ChangeMecDeviceIPAddressResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/m2m/v1/devices/mec/actions/ipaddress")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// GetMECPerformanceConsent EndPoint.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <returns>Returns the ApiResponse of Models.GetMECPerformanceConsentResponse response from the API call.</returns>
        public ApiResponse<Models.GetMECPerformanceConsentResponse> GetMECPerformanceConsent(
                string aname)
            => CoreHelper.RunTask(GetMECPerformanceConsentAsync(aname));

        /// <summary>
        /// GetMECPerformanceConsent EndPoint.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.GetMECPerformanceConsentResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.GetMECPerformanceConsentResponse>> GetMECPerformanceConsentAsync(
                string aname,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetMECPerformanceConsentResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/m2m/v1/devices/mec/performance/consent/{aname}")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("aname", aname))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}