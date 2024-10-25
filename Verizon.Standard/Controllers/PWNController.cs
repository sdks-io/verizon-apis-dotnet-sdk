// <copyright file="PWNController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
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

namespace Verizon.Standard.Controllers
{
    /// <summary>
    /// PWNController.
    /// </summary>
    public class PWNController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PWNController"/> class.
        /// </summary>
        internal PWNController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

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
                  .Setup(HttpMethod.Get, "/m2m/v1/devices/pwn/kpi/list/{aname}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("aname", aname))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// GetProfileList EndPoint.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <returns>Returns the ApiResponse of Models.PWNProfileList response from the API call.</returns>
        public ApiResponse<Models.PWNProfileList> GetProfileList(
                string aname)
            => CoreHelper.RunTask(GetProfileListAsync(aname));

        /// <summary>
        /// GetProfileList EndPoint.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.PWNProfileList response from the API call.</returns>
        public async Task<ApiResponse<Models.PWNProfileList>> GetProfileListAsync(
                string aname,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PWNProfileList>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/m2m/v1/devices/pwn/profiles/list/{aname}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("aname", aname))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// ChangePWNDeviceState-Activate EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.ChangePWNDeviceStateResponse response from the API call.</returns>
        public ApiResponse<Models.ChangePWNDeviceStateResponse> ChangePWNDeviceStateActivate(
                Models.ChangePWNDeviceStateActivateRequest body)
            => CoreHelper.RunTask(ChangePWNDeviceStateActivateAsync(body));

        /// <summary>
        /// ChangePWNDeviceState-Activate EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ChangePWNDeviceStateResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.ChangePWNDeviceStateResponse>> ChangePWNDeviceStateActivateAsync(
                Models.ChangePWNDeviceStateActivateRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ChangePWNDeviceStateResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/devices/pwn/actions/state/activate")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// ChangePWNDeviceState-Deactivate EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.ChangePWNDeviceStateResponse response from the API call.</returns>
        public ApiResponse<Models.ChangePWNDeviceStateResponse> ChangePWNDeviceStateDeactivate(
                Models.ChangePWNDeviceStateDeactivateRequest body)
            => CoreHelper.RunTask(ChangePWNDeviceStateDeactivateAsync(body));

        /// <summary>
        /// ChangePWNDeviceState-Deactivate EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ChangePWNDeviceStateResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.ChangePWNDeviceStateResponse>> ChangePWNDeviceStateDeactivateAsync(
                Models.ChangePWNDeviceStateDeactivateRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ChangePWNDeviceStateResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/devices/pwn/actions/state/deactivate")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// ChangePWNDeviceProfile EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.ChangePWNDeviceProfileResponse response from the API call.</returns>
        public ApiResponse<Models.ChangePWNDeviceProfileResponse> ChangePWNDeviceProfile(
                Models.ChangePWNDeviceProfileRequest body)
            => CoreHelper.RunTask(ChangePWNDeviceProfileAsync(body));

        /// <summary>
        /// ChangePWNDeviceProfile EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ChangePWNDeviceProfileResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.ChangePWNDeviceProfileResponse>> ChangePWNDeviceProfileAsync(
                Models.ChangePWNDeviceProfileRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ChangePWNDeviceProfileResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/devices/pwn/actions/profile")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// ChangePWNDeviceIPaddress EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.ChangePWNDeviceIpaddressResponse response from the API call.</returns>
        public ApiResponse<Models.ChangePWNDeviceIpaddressResponse> ChangePWNDeviceIpaddress(
                Models.ChangePWNDeviceIpaddressRequest body)
            => CoreHelper.RunTask(ChangePWNDeviceIpaddressAsync(body));

        /// <summary>
        /// ChangePWNDeviceIPaddress EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ChangePWNDeviceIpaddressResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.ChangePWNDeviceIpaddressResponse>> ChangePWNDeviceIpaddressAsync(
                Models.ChangePWNDeviceIpaddressRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ChangePWNDeviceIpaddressResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/m2m/v1/devices/pwn/actions/ipaddress")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// GetPWNPerformanceConsent EndPoint.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <returns>Returns the ApiResponse of Models.GetPWNPerformanceConsentResponse response from the API call.</returns>
        public ApiResponse<Models.GetPWNPerformanceConsentResponse> GetPWNPerformanceConsent(
                string aname)
            => CoreHelper.RunTask(GetPWNPerformanceConsentAsync(aname));

        /// <summary>
        /// GetPWNPerformanceConsent EndPoint.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.GetPWNPerformanceConsentResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.GetPWNPerformanceConsentResponse>> GetPWNPerformanceConsentAsync(
                string aname,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetPWNPerformanceConsentResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/m2m/v1/devices/pwn/performance/consent/{aname}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("aname", aname))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}