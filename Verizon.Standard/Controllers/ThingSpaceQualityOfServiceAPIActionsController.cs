// <copyright file="ThingSpaceQualityOfServiceAPIActionsController.cs" company="APIMatic">
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
    /// ThingSpaceQualityOfServiceAPIActionsController.
    /// </summary>
    public class ThingSpaceQualityOfServiceAPIActionsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThingSpaceQualityOfServiceAPIActionsController"/> class.
        /// </summary>
        internal ThingSpaceQualityOfServiceAPIActionsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Creates a QoS elevation subscription ID and activates the subscription.
        /// </summary>
        /// <param name="body">Required parameter: The request details to create a ThingSpace Quality of Service API subscription..</param>
        /// <returns>Returns the ApiResponse of Models.M201success response from the API call.</returns>
        public ApiResponse<Models.M201success> CreateAThingSpaceQualityOfServiceAPISubscription(
                Models.SubscribeRequest body)
            => CoreHelper.RunTask(CreateAThingSpaceQualityOfServiceAPISubscriptionAsync(body));

        /// <summary>
        /// Creates a QoS elevation subscription ID and activates the subscription.
        /// </summary>
        /// <param name="body">Required parameter: The request details to create a ThingSpace Quality of Service API subscription..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.M201success response from the API call.</returns>
        public async Task<ApiResponse<Models.M201success>> CreateAThingSpaceQualityOfServiceAPISubscriptionAsync(
                Models.SubscribeRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.M201success>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/devices/actions/enhanceQoS")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error Response", (_reason, _context) => new DefaultResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Stops an active ThingSpace Quality of Service API subscription using the account name and the subscription ID.
        /// </summary>
        /// <param name="accountName">Required parameter: Example: .</param>
        /// <param name="qosSubscriptionId">Required parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.M201success response from the API call.</returns>
        public ApiResponse<Models.M201success> StopAThingSpaceQualityOfServiceAPISubscription(
                string accountName,
                string qosSubscriptionId)
            => CoreHelper.RunTask(StopAThingSpaceQualityOfServiceAPISubscriptionAsync(accountName, qosSubscriptionId));

        /// <summary>
        /// Stops an active ThingSpace Quality of Service API subscription using the account name and the subscription ID.
        /// </summary>
        /// <param name="accountName">Required parameter: Example: .</param>
        /// <param name="qosSubscriptionId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.M201success response from the API call.</returns>
        public async Task<ApiResponse<Models.M201success>> StopAThingSpaceQualityOfServiceAPISubscriptionAsync(
                string accountName,
                string qosSubscriptionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.M201success>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/m2m/v1/devices/actions/enhanceQoS")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("accountName", accountName))
                      .Query(_query => _query.Setup("qosSubscriptionId", qosSubscriptionId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error Response", (_reason, _context) => new DefaultResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}