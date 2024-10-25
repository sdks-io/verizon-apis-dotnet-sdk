// <copyright file="PromotionPeriodInformationController.cs" company="APIMatic">
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
using Verizon.Standard.Exceptions;
using Verizon.Standard.Http.Client;
using Verizon.Standard.Http.Response;
using Verizon.Standard.Utilities;

namespace Verizon.Standard.Controllers
{
    /// <summary>
    /// PromotionPeriodInformationController.
    /// </summary>
    public class PromotionPeriodInformationController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PromotionPeriodInformationController"/> class.
        /// </summary>
        internal PromotionPeriodInformationController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Retrieves the usage history of a device during the promotion period.
        /// </summary>
        /// <param name="body">Required parameter: Retrieve Aggregate Usage.</param>
        /// <returns>Returns the ApiResponse of Models.ResponseToUsageQuery response from the API call.</returns>
        public ApiResponse<Models.ResponseToUsageQuery> GetPromoDeviceUsageHistory(
                Models.ARequestBodyForUsage body)
            => CoreHelper.RunTask(GetPromoDeviceUsageHistoryAsync(body));

        /// <summary>
        /// Retrieves the usage history of a device during the promotion period.
        /// </summary>
        /// <param name="body">Required parameter: Retrieve Aggregate Usage.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ResponseToUsageQuery response from the API call.</returns>
        public async Task<ApiResponse<Models.ResponseToUsageQuery>> GetPromoDeviceUsageHistoryAsync(
                Models.ARequestBodyForUsage body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ResponseToUsageQuery>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/devices/usage/actions/promodeviceusage")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("All error responses will be in this format", (_reason, _context) => new ReadySimRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieves the aggregate usage for an account using pseudo-MDN during the promotional period using a callback.
        /// </summary>
        /// <param name="body">Required parameter: Retrieve Aggregate Usage.</param>
        /// <returns>Returns the ApiResponse of Models.UsageRequestResponse response from the API call.</returns>
        public ApiResponse<Models.UsageRequestResponse> GetPromoDeviceAggregateUsageHistory(
                Models.RequestBodyForUsage body)
            => CoreHelper.RunTask(GetPromoDeviceAggregateUsageHistoryAsync(body));

        /// <summary>
        /// Retrieves the aggregate usage for an account using pseudo-MDN during the promotional period using a callback.
        /// </summary>
        /// <param name="body">Required parameter: Retrieve Aggregate Usage.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.UsageRequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.UsageRequestResponse>> GetPromoDeviceAggregateUsageHistoryAsync(
                Models.RequestBodyForUsage body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UsageRequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/devices/usage/actions/promoaggregateusage")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new ReadySimRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}