// <copyright file="HyperPreciseLocationCallbacksController.cs" company="APIMatic">
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
    /// HyperPreciseLocationCallbacksController.
    /// </summary>
    public class HyperPreciseLocationCallbacksController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HyperPreciseLocationCallbacksController"/> class.
        /// </summary>
        internal HyperPreciseLocationCallbacksController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Find registered callback listener for account by account number.
        /// </summary>
        /// <param name="accountNumber">Required parameter: A unique identifier for an account..</param>
        /// <returns>Returns the ApiResponse of List<Models.CallbackCreated> response from the API call.</returns>
        public ApiResponse<List<Models.CallbackCreated>> ListRegisteredCallbacks(
                string accountNumber)
            => CoreHelper.RunTask(ListRegisteredCallbacksAsync(accountNumber));

        /// <summary>
        /// Find registered callback listener for account by account number.
        /// </summary>
        /// <param name="accountNumber">Required parameter: A unique identifier for an account..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List<Models.CallbackCreated> response from the API call.</returns>
        public async Task<ApiResponse<List<Models.CallbackCreated>>> ListRegisteredCallbacksAsync(
                string accountNumber,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.CallbackCreated>>()
              .Server(Server.HyperPreciseLocation)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/callbacks")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("accountNumber", accountNumber))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized request. Access token is missing or invalid.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden request.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Bad request. Not found.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context)))
                  .ErrorCase("409", CreateErrorCase("Bad request. Conflict state.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Registers a URL at which an account receives asynchronous responses and other messages from a ThingSpace Platform callback service. The messages are REST messages. You are responsible for creating and running a listening process on your server at that URL to receive and parse the messages.
        /// </summary>
        /// <param name="accountNumber">Required parameter: A unique identifier for an account..</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.CallbackRegistered response from the API call.</returns>
        public ApiResponse<Models.CallbackRegistered> RegisterCallback(
                string accountNumber,
                Models.HyperPreciseLocationCallback body)
            => CoreHelper.RunTask(RegisterCallbackAsync(accountNumber, body));

        /// <summary>
        /// Registers a URL at which an account receives asynchronous responses and other messages from a ThingSpace Platform callback service. The messages are REST messages. You are responsible for creating and running a listening process on your server at that URL to receive and parse the messages.
        /// </summary>
        /// <param name="accountNumber">Required parameter: A unique identifier for an account..</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.CallbackRegistered response from the API call.</returns>
        public async Task<ApiResponse<Models.CallbackRegistered>> RegisterCallbackAsync(
                string accountNumber,
                Models.HyperPreciseLocationCallback body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CallbackRegistered>()
              .Server(Server.HyperPreciseLocation)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/callbacks")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Query(_query => _query.Setup("accountNumber", accountNumber))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized request. Access token is missing or invalid.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden request.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Bad request. Not found.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context)))
                  .ErrorCase("409", CreateErrorCase("Bad request. Conflict state.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Stops ThingSpace from sending callback messages for the specified account and listener name.
        /// </summary>
        /// <param name="accountNumber">Required parameter: A unique identifier for a account..</param>
        /// <param name="service">Required parameter: The name of the callback service that will be deleted..</param>
        public void DeregisterCallback(
                string accountNumber,
                string service)
            => CoreHelper.RunVoidTask(DeregisterCallbackAsync(accountNumber, service));

        /// <summary>
        /// Stops ThingSpace from sending callback messages for the specified account and listener name.
        /// </summary>
        /// <param name="accountNumber">Required parameter: A unique identifier for a account..</param>
        /// <param name="service">Required parameter: The name of the callback service that will be deleted..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeregisterCallbackAsync(
                string accountNumber,
                string service,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .Server(Server.HyperPreciseLocation)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/callbacks")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("accountNumber", accountNumber))
                      .Query(_query => _query.Setup("service", service))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized request. Access token is missing or invalid.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden request.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Bad request. Not found.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context)))
                  .ErrorCase("409", CreateErrorCase("Bad request. Conflict state.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new HyperPreciseLocationResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}