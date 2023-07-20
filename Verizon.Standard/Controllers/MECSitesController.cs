// <copyright file="MECSitesController.cs" company="APIMatic">
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
    /// MECSitesController.
    /// </summary>
    public class MECSitesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MECSitesController"/> class.
        /// </summary>
        internal MECSitesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Retrieve all clusters for the customer.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="role">Required parameter: Example: .</param>
        /// <param name="customerId">Required parameter: Example: .</param>
        /// <param name="requestId">Required parameter: Example: .</param>
        /// <param name="eRN">Optional parameter: Example: .</param>
        /// <param name="name">Optional parameter: Example: .</param>
        /// <param name="offset">Optional parameter: Example: .</param>
        /// <param name="limit">Optional parameter: Example: .</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <param name="clusterState">Optional parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.ClustersNamespaces response from the API call.</returns>
        public ApiResponse<Models.ClustersNamespaces> ListERNClusterNamespaces(
                string userId,
                string role,
                string customerId,
                string requestId,
                string eRN = null,
                string name = null,
                string offset = null,
                string limit = null,
                string correlationId = null,
                Models.ClusterStateEnum? clusterState = null)
            => CoreHelper.RunTask(ListERNClusterNamespacesAsync(userId, role, customerId, requestId, eRN, name, offset, limit, correlationId, clusterState));

        /// <summary>
        /// Retrieve all clusters for the customer.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="role">Required parameter: Example: .</param>
        /// <param name="customerId">Required parameter: Example: .</param>
        /// <param name="requestId">Required parameter: Example: .</param>
        /// <param name="eRN">Optional parameter: Example: .</param>
        /// <param name="name">Optional parameter: Example: .</param>
        /// <param name="offset">Optional parameter: Example: .</param>
        /// <param name="limit">Optional parameter: Example: .</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <param name="clusterState">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ClustersNamespaces response from the API call.</returns>
        public async Task<ApiResponse<Models.ClustersNamespaces>> ListERNClusterNamespacesAsync(
                string userId,
                string role,
                string customerId,
                string requestId,
                string eRN = null,
                string name = null,
                string offset = null,
                string limit = null,
                string correlationId = null,
                Models.ClusterStateEnum? clusterState = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ClustersNamespaces>()
              .Server(Server.Services)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/platform/clusters")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("userId", userId))
                      .Header(_header => _header.Setup("role", role))
                      .Header(_header => _header.Setup("customerId", customerId))
                      .Header(_header => _header.Setup("requestId", requestId))
                      .Query(_query => _query.Setup("ERN", eRN))
                      .Query(_query => _query.Setup("name", name))
                      .Query(_query => _query.Setup("offset", offset))
                      .Query(_query => _query.Setup("limit", limit))
                      .Header(_header => _header.Setup("correlationId", correlationId))
                      .Query(_query => _query.Setup("cluster_state", (clusterState.HasValue) ? ApiHelper.JsonSerialize(clusterState.Value).Trim('\"') : null))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not found.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Unexpected error.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.ClustersNamespaces>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Supports fetching MEC locations so the user can view the city.
        /// </summary>
        /// <param name="accountName">Optional parameter: User account name..</param>
        /// <returns>Returns the ApiResponse of Models.MECSiteLocationsResult response from the API call.</returns>
        public ApiResponse<Models.MECSiteLocationsResult> ListMECSiteLocations(
                string accountName = null)
            => CoreHelper.RunTask(ListMECSiteLocationsAsync(accountName));

        /// <summary>
        /// Supports fetching MEC locations so the user can view the city.
        /// </summary>
        /// <param name="accountName">Optional parameter: User account name..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.MECSiteLocationsResult response from the API call.</returns>
        public async Task<ApiResponse<Models.MECSiteLocationsResult>> ListMECSiteLocationsAsync(
                string accountName = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.MECSiteLocationsResult>()
              .Server(Server.Services)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/mecsite/locations")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("AccountName", accountName))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error Response.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.MECSiteLocationsResult>(_response)))
              .ExecuteAsync(cancellationToken);
    }
}