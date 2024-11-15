// <copyright file="ThingSpaceQualityOfServiceAPIActionsController.cs" company="APIMatic">
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
using VerizonThingSpaceQualityOfServiceAPIEndpoints.Standard;
using VerizonThingSpaceQualityOfServiceAPIEndpoints.Standard.Exceptions;
using VerizonThingSpaceQualityOfServiceAPIEndpoints.Standard.Http.Client;
using VerizonThingSpaceQualityOfServiceAPIEndpoints.Standard.Utilities;

namespace VerizonThingSpaceQualityOfServiceAPIEndpoints.Standard.Controllers
{
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
        /// <returns>Returns the Models.M201success response from the API call.</returns>
        public Models.M201success CreateAThingSpaceQualityOfServiceAPISubscription(
                Models.SubscribeRequest body)
            => CoreHelper.RunTask(CreateAThingSpaceQualityOfServiceAPISubscriptionAsync(body));

        /// <summary>
        /// Creates a QoS elevation subscription ID and activates the subscription.
        /// </summary>
        /// <param name="body">Required parameter: The request details to create a ThingSpace Quality of Service API subscription..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.M201success response from the API call.</returns>
        public async Task<Models.M201success> CreateAThingSpaceQualityOfServiceAPISubscriptionAsync(
                Models.SubscribeRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.M201success>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/actions/enhanceQoS")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("vz-m2m-session_token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error Response", (_reason, _context) => new DefaultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Stops an active ThingSpace Quality of Service API subscription using the account name and the subscription ID.
        /// </summary>
        /// <param name="accountName">Required parameter: Example: .</param>
        /// <param name="qosSubscriptionId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.M201success response from the API call.</returns>
        public Models.M201success StopAThingSpaceQualityOfServiceAPISubscription(
                string accountName,
                string qosSubscriptionId)
            => CoreHelper.RunTask(StopAThingSpaceQualityOfServiceAPISubscriptionAsync(accountName, qosSubscriptionId));

        /// <summary>
        /// Stops an active ThingSpace Quality of Service API subscription using the account name and the subscription ID.
        /// </summary>
        /// <param name="accountName">Required parameter: Example: .</param>
        /// <param name="qosSubscriptionId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.M201success response from the API call.</returns>
        public async Task<Models.M201success> StopAThingSpaceQualityOfServiceAPISubscriptionAsync(
                string accountName,
                string qosSubscriptionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.M201success>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/actions/enhanceQoS")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("vz-m2m-session_token")
                  )
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("accountName", accountName))
                      .Query(_query => _query.Setup("qosSubscriptionId", qosSubscriptionId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error Response", (_reason, _context) => new DefaultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}