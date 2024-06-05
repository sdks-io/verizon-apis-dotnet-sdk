// <copyright file="RetrieveTheTriggersController.cs" company="APIMatic">
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
    /// RetrieveTheTriggersController.
    /// </summary>
    public class RetrieveTheTriggersController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveTheTriggersController"/> class.
        /// </summary>
        internal RetrieveTheTriggersController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Retrieves all of the available triggers for pseudo-MDN.
        /// </summary>
        /// <returns>Returns the ApiResponse of Models.TriggerValueResponse response from the API call.</returns>
        public ApiResponse<Models.TriggerValueResponse> GetAllAvailableTriggers()
            => CoreHelper.RunTask(GetAllAvailableTriggersAsync());

        /// <summary>
        /// Retrieves all of the available triggers for pseudo-MDN.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.TriggerValueResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.TriggerValueResponse>> GetAllAvailableTriggersAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TriggerValueResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/m2m/v2/triggers")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  ))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new ReadySimRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieve the triggers associated with an account name.
        /// </summary>
        /// <param name="accountName">Required parameter: The account name.</param>
        /// <returns>Returns the ApiResponse of Models.TriggerValueResponse response from the API call.</returns>
        public ApiResponse<Models.TriggerValueResponse> GetAllTriggersByAccountName(
                string accountName)
            => CoreHelper.RunTask(GetAllTriggersByAccountNameAsync(accountName));

        /// <summary>
        /// Retrieve the triggers associated with an account name.
        /// </summary>
        /// <param name="accountName">Required parameter: The account name.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.TriggerValueResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.TriggerValueResponse>> GetAllTriggersByAccountNameAsync(
                string accountName,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TriggerValueResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/m2m/v2/triggers/accounts/{accountName}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("accountName", accountName))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new ReadySimRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieves all of the triggers for the specified account associated with the PromoAlert category.
        /// </summary>
        /// <returns>Returns the ApiResponse of Models.TriggerValueResponse2 response from the API call.</returns>
        public ApiResponse<Models.TriggerValueResponse2> GetAllTriggersByTriggerCategory()
            => CoreHelper.RunTask(GetAllTriggersByTriggerCategoryAsync());

        /// <summary>
        /// Retrieves all of the triggers for the specified account associated with the PromoAlert category.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.TriggerValueResponse2 response from the API call.</returns>
        public async Task<ApiResponse<Models.TriggerValueResponse2>> GetAllTriggersByTriggerCategoryAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TriggerValueResponse2>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/m2m/v2/triggers/categories/PromoAlerts")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  ))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new ReadySimRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrives a specific trigger by its ID.
        /// </summary>
        /// <param name="triggerId">Required parameter: The ID of a specific trigger.</param>
        /// <returns>Returns the ApiResponse of Models.TriggerValueResponse2 response from the API call.</returns>
        public ApiResponse<Models.TriggerValueResponse2> GetTriggersById(
                string triggerId)
            => CoreHelper.RunTask(GetTriggersByIdAsync(triggerId));

        /// <summary>
        /// Retrives a specific trigger by its ID.
        /// </summary>
        /// <param name="triggerId">Required parameter: The ID of a specific trigger.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.TriggerValueResponse2 response from the API call.</returns>
        public async Task<ApiResponse<Models.TriggerValueResponse2>> GetTriggersByIdAsync(
                string triggerId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TriggerValueResponse2>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/m2m/v2/triggers/{triggerId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("triggerId", triggerId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new ReadySimRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}