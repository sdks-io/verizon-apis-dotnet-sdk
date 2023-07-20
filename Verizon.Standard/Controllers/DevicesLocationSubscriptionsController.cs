// <copyright file="DevicesLocationSubscriptionsController.cs" company="APIMatic">
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
    /// DevicesLocationSubscriptionsController.
    /// </summary>
    public class DevicesLocationSubscriptionsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DevicesLocationSubscriptionsController"/> class.
        /// </summary>
        internal DevicesLocationSubscriptionsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// This endpoint allows user to search for billable usage for accounts based on the provided date range.
        /// </summary>
        /// <param name="body">Required parameter: Request to obtain billable usage for accounts..</param>
        /// <returns>Returns the ApiResponse of object response from the API call.</returns>
        public ApiResponse<object> GetLocationServiceUsage(
                Models.BillUsageRequest body)
            => CoreHelper.RunTask(GetLocationServiceUsageAsync(body));

        /// <summary>
        /// This endpoint allows user to search for billable usage for accounts based on the provided date range.
        /// </summary>
        /// <param name="body">Required parameter: Request to obtain billable usage for accounts..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of object response from the API call.</returns>
        public async Task<ApiResponse<object>> GetLocationServiceUsageAsync(
                Models.BillUsageRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<object>()
              .Server(Server.DeviceLocation)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/usage")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "*/*"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new DeviceLocationResultException(_reason, _context)))
                  .Deserializer(_response => _response))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// This subscriptions endpoint retrieves an account's current location subscription status.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier in "##########-#####"..</param>
        /// <returns>Returns the ApiResponse of Models.DeviceLocationSubscription response from the API call.</returns>
        public ApiResponse<Models.DeviceLocationSubscription> GetLocationServiceSubscriptionStatus(
                string account)
            => CoreHelper.RunTask(GetLocationServiceSubscriptionStatusAsync(account));

        /// <summary>
        /// This subscriptions endpoint retrieves an account's current location subscription status.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeviceLocationSubscription response from the API call.</returns>
        public async Task<ApiResponse<Models.DeviceLocationSubscription>> GetLocationServiceSubscriptionStatusAsync(
                string account,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeviceLocationSubscription>()
              .Server(Server.DeviceLocation)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions/{account}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("account", account))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new DeviceLocationResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.DeviceLocationSubscription>(_response)))
              .ExecuteAsync(cancellationToken);
    }
}