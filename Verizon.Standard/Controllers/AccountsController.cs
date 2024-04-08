// <copyright file="AccountsController.cs" company="APIMatic">
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
    /// AccountsController.
    /// </summary>
    public class AccountsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsController"/> class.
        /// </summary>
        internal AccountsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Returns information about a specified account.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <returns>Returns the ApiResponse of Models.Account response from the API call.</returns>
        public ApiResponse<Models.Account> GetAccountInformation(
                string aname)
            => CoreHelper.RunTask(GetAccountInformationAsync(aname));

        /// <summary>
        /// Returns information about a specified account.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Account response from the API call.</returns>
        public async Task<ApiResponse<Models.Account>> GetAccountInformationAsync(
                string aname,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Account>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/m2m/v1/accounts/{aname}")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("aname", aname))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns a list and details of all custom services and states defined for a specified account.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <returns>Returns the ApiResponse of Models.AccountStatesAndServices response from the API call.</returns>
        public ApiResponse<Models.AccountStatesAndServices> ListAccountStatesAndServices(
                string aname)
            => CoreHelper.RunTask(ListAccountStatesAndServicesAsync(aname));

        /// <summary>
        /// Returns a list and details of all custom services and states defined for a specified account.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.AccountStatesAndServices response from the API call.</returns>
        public async Task<ApiResponse<Models.AccountStatesAndServices>> ListAccountStatesAndServicesAsync(
                string aname,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AccountStatesAndServices>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/m2m/v1/accounts/{aname}/statesandservices")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("aname", aname))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// When HTTP status is 202, a URL will be returned in the Location header of the form /leads/{aname}?next={token}. This URL can be used to request the next set of leads.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <param name="next">Optional parameter: Continue the previous query from the pageUrl in Location Header..</param>
        /// <returns>Returns the ApiResponse of Models.AccountLeadsResult response from the API call.</returns>
        public ApiResponse<Models.AccountLeadsResult> ListAccountLeads(
                string aname,
                long? next = null)
            => CoreHelper.RunTask(ListAccountLeadsAsync(aname, next));

        /// <summary>
        /// When HTTP status is 202, a URL will be returned in the Location header of the form /leads/{aname}?next={token}. This URL can be used to request the next set of leads.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <param name="next">Optional parameter: Continue the previous query from the pageUrl in Location Header..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.AccountLeadsResult response from the API call.</returns>
        public async Task<ApiResponse<Models.AccountLeadsResult>> ListAccountLeadsAsync(
                string aname,
                long? next = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AccountLeadsResult>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/m2m/v1/leads/{aname}")
                  .WithAuth("oAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("aname", aname))
                      .Query(_query => _query.Setup("next", next))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}