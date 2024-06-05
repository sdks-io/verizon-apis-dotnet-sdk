// <copyright file="SoftwareManagementSubscriptionsV2Controller.cs" company="APIMatic">
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
    /// SoftwareManagementSubscriptionsV2Controller.
    /// </summary>
    public class SoftwareManagementSubscriptionsV2Controller : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoftwareManagementSubscriptionsV2Controller"/> class.
        /// </summary>
        internal SoftwareManagementSubscriptionsV2Controller(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// This endpoint retrieves a FOTA subscription by account.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <returns>Returns the ApiResponse of Models.FotaV2Subscription response from the API call.</returns>
        public ApiResponse<Models.FotaV2Subscription> GetAccountSubscriptionStatus(
                string account)
            => CoreHelper.RunTask(GetAccountSubscriptionStatusAsync(account));

        /// <summary>
        /// This endpoint retrieves a FOTA subscription by account.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.FotaV2Subscription response from the API call.</returns>
        public async Task<ApiResponse<Models.FotaV2Subscription>> GetAccountSubscriptionStatusAsync(
                string account,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.FotaV2Subscription>()
              .Server(Server.SoftwareManagementV2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions/{account}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("account", account))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV2ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}