// <copyright file="ServiceInstancesController.cs" company="APIMatic">
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
    /// ServiceInstancesController.
    /// </summary>
    public class ServiceInstancesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceInstancesController"/> class.
        /// </summary>
        internal ServiceInstancesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Retrieve information of a service instance.
        /// </summary>
        /// <param name="serviceInstanceId">Required parameter: Unique Id of the service instance..</param>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="cluster">Optional parameter: Example: false.</param>
        /// <returns>Returns the ApiResponse of Models.ServiceInstancesResultSetItem response from the API call.</returns>
        public ApiResponse<Models.ServiceInstancesResultSetItem> RetrieveServiceInstance(
                string serviceInstanceId,
                string accountName,
                bool? cluster = false)
            => CoreHelper.RunTask(RetrieveServiceInstanceAsync(serviceInstanceId, accountName, cluster));

        /// <summary>
        /// Retrieve information of a service instance.
        /// </summary>
        /// <param name="serviceInstanceId">Required parameter: Unique Id of the service instance..</param>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="cluster">Optional parameter: Example: false.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ServiceInstancesResultSetItem response from the API call.</returns>
        public async Task<ApiResponse<Models.ServiceInstancesResultSetItem>> RetrieveServiceInstanceAsync(
                string serviceInstanceId,
                string accountName,
                bool? cluster = false,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ServiceInstancesResultSetItem>()
              .Server(Server.Services)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/service/instances/{serviceInstanceId}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("serviceInstanceId", serviceInstanceId))
                      .Header(_header => _header.Setup("AccountName", accountName))
                      .Query(_query => _query.Setup("cluster", (cluster != null) ? cluster : false))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not found.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("415", CreateErrorCase("Unsupported media type.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too many requests.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Unexpected error.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.ServiceInstancesResultSetItem>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Retrieve all instances for all services.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="offset">Optional parameter: Example: .</param>
        /// <param name="state">Optional parameter: Example: .</param>
        /// <param name="limit">Optional parameter: Example: .</param>
        /// <param name="searchbyname">Optional parameter: Example: .</param>
        /// <param name="listofstate">Optional parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.ServiceInstancesResult response from the API call.</returns>
        public ApiResponse<Models.ServiceInstancesResult> ListServicesInstances(
                string accountName,
                string offset = null,
                string state = null,
                string limit = null,
                string searchbyname = null,
                List<string> listofstate = null)
            => CoreHelper.RunTask(ListServicesInstancesAsync(accountName, offset, state, limit, searchbyname, listofstate));

        /// <summary>
        /// Retrieve all instances for all services.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="offset">Optional parameter: Example: .</param>
        /// <param name="state">Optional parameter: Example: .</param>
        /// <param name="limit">Optional parameter: Example: .</param>
        /// <param name="searchbyname">Optional parameter: Example: .</param>
        /// <param name="listofstate">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ServiceInstancesResult response from the API call.</returns>
        public async Task<ApiResponse<Models.ServiceInstancesResult>> ListServicesInstancesAsync(
                string accountName,
                string offset = null,
                string state = null,
                string limit = null,
                string searchbyname = null,
                List<string> listofstate = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ServiceInstancesResult>()
              .Server(Server.Services)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/service/instances")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("AccountName", accountName))
                      .Query(_query => _query.Setup("offset", offset))
                      .Query(_query => _query.Setup("state", state))
                      .Query(_query => _query.Setup("limit", limit))
                      .Query(_query => _query.Setup("searchbyname", searchbyname))
                      .Query(_query => _query.Setup("listofstate", listofstate))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not found.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("415", CreateErrorCase("Unsupported media type.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too many requests.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Unexpected error.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.ServiceInstancesResult>(_response)))
              .ExecuteAsync(cancellationToken);
    }
}