// <copyright file="AccountSubscriptionsController.cs" company="APIMatic">
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
    /// AccountSubscriptionsController.
    /// </summary>
    public class AccountSubscriptionsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountSubscriptionsController"/> class.
        /// </summary>
        internal AccountSubscriptionsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Retrieves the total number of SIM-Secure for IoT subscription licenses purchased for your account by license type, and lists the number of licenses assigned and available for each license type.
        /// </summary>
        /// <param name="body">Required parameter: Request for account subscription..</param>
        /// <param name="xRequestID">Optional parameter: Transaction Id..</param>
        /// <returns>Returns the ApiResponse of Models.SecuritySubscriptionResult response from the API call.</returns>
        public ApiResponse<Models.SecuritySubscriptionResult> ListAccountSubscriptions(
                Models.SecuritySubscriptionRequest body,
                string xRequestID = null)
            => CoreHelper.RunTask(ListAccountSubscriptionsAsync(body, xRequestID));

        /// <summary>
        /// Retrieves the total number of SIM-Secure for IoT subscription licenses purchased for your account by license type, and lists the number of licenses assigned and available for each license type.
        /// </summary>
        /// <param name="body">Required parameter: Request for account subscription..</param>
        /// <param name="xRequestID">Optional parameter: Transaction Id..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.SecuritySubscriptionResult response from the API call.</returns>
        public async Task<ApiResponse<Models.SecuritySubscriptionResult>> ListAccountSubscriptionsAsync(
                Models.SecuritySubscriptionRequest body,
                string xRequestID = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SecuritySubscriptionResult>()
              .Server(Server.M2m)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/accounts/subscriptions/actions/list")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("X-Request-ID", xRequestID))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request.", (_reason, _context) => new SecurityResultException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized request.", (_reason, _context) => new SecurityResultException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Request forbidden.", (_reason, _context) => new SecurityResultException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found / Does not exist.", (_reason, _context) => new SecurityResultException(_reason, _context)))
                  .ErrorCase("406", CreateErrorCase("Format / Request Unacceptable.", (_reason, _context) => new SecurityResultException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too many requests.", (_reason, _context) => new SecurityResultException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Error response.", (_reason, _context) => new SecurityResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}