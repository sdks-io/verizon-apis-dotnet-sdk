// <copyright file="DiagnosticsSubscriptionsController.cs" company="APIMatic">
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
    /// DiagnosticsSubscriptionsController.
    /// </summary>
    public class DiagnosticsSubscriptionsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticsSubscriptionsController"/> class.
        /// </summary>
        internal DiagnosticsSubscriptionsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// This endpoint retrieves a diagnostics subscription by account.
        /// </summary>
        /// <param name="accountName">Required parameter: Account identifier..</param>
        /// <returns>Returns the ApiResponse of Models.DiagnosticsSubscription response from the API call.</returns>
        public ApiResponse<Models.DiagnosticsSubscription> GetDiagnosticsSubscription(
                string accountName)
            => CoreHelper.RunTask(GetDiagnosticsSubscriptionAsync(accountName));

        /// <summary>
        /// This endpoint retrieves a diagnostics subscription by account.
        /// </summary>
        /// <param name="accountName">Required parameter: Account identifier..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DiagnosticsSubscription response from the API call.</returns>
        public async Task<ApiResponse<Models.DiagnosticsSubscription>> GetDiagnosticsSubscriptionAsync(
                string accountName,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DiagnosticsSubscription>()
              .Server(Server.DeviceDiagnostics)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("accountName", accountName))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response.", (_reason, _context) => new DeviceDiagnosticsResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}