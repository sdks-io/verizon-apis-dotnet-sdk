// <copyright file="CloudConnectorSubscriptionsController.cs" company="APIMatic">
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
    /// CloudConnectorSubscriptionsController.
    /// </summary>
    public class CloudConnectorSubscriptionsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudConnectorSubscriptionsController"/> class.
        /// </summary>
        internal CloudConnectorSubscriptionsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Create a subscription to define a streaming channel that sends data from devices in the account to an endpoint defined in a target resource.
        /// </summary>
        /// <param name="body">Required parameter: The request body provides the details of the subscription that you want to create..</param>
        /// <returns>Returns the ApiResponse of Models.Subscription response from the API call.</returns>
        public ApiResponse<Models.Subscription> CreateSubscription(
                Models.CreateSubscriptionRequest body)
            => CoreHelper.RunTask(CreateSubscriptionAsync(body));

        /// <summary>
        /// Create a subscription to define a streaming channel that sends data from devices in the account to an endpoint defined in a target resource.
        /// </summary>
        /// <param name="body">Required parameter: The request body provides the details of the subscription that you want to create..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Subscription response from the API call.</returns>
        public async Task<ApiResponse<Models.Subscription>> CreateSubscriptionAsync(
                Models.CreateSubscriptionRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Subscription>()
              .Server(Server.CloudConnector)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Search for subscriptions by property values. Returns an array of all matching subscription resources.
        /// </summary>
        /// <param name="body">Required parameter: The request body specifies fields and values to match..</param>
        /// <returns>Returns the ApiResponse of List<Models.Subscription> response from the API call.</returns>
        public ApiResponse<List<Models.Subscription>> QuerySubscription(
                Models.QuerySubscriptionRequest body)
            => CoreHelper.RunTask(QuerySubscriptionAsync(body));

        /// <summary>
        /// Search for subscriptions by property values. Returns an array of all matching subscription resources.
        /// </summary>
        /// <param name="body">Required parameter: The request body specifies fields and values to match..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List<Models.Subscription> response from the API call.</returns>
        public async Task<ApiResponse<List<Models.Subscription>>> QuerySubscriptionAsync(
                Models.QuerySubscriptionRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.Subscription>>()
              .Server(Server.CloudConnector)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/actions/query")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Remove a subscription from a ThingSpace account.
        /// </summary>
        /// <param name="body">Required parameter: The request body identifies the subscription to delete..</param>
        public void DeleteSubscription(
                Models.DeleteSubscriptionRequest body)
            => CoreHelper.RunVoidTask(DeleteSubscriptionAsync(body));

        /// <summary>
        /// Remove a subscription from a ThingSpace account.
        /// </summary>
        /// <param name="body">Required parameter: The request body identifies the subscription to delete..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteSubscriptionAsync(
                Models.DeleteSubscriptionRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .Server(Server.CloudConnector)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/actions/delete")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}