// <copyright file="ServiceLaunchRequestsController.cs" company="APIMatic">
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
    /// ServiceLaunchRequestsController.
    /// </summary>
    public class ServiceLaunchRequestsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceLaunchRequestsController"/> class.
        /// </summary>
        internal ServiceLaunchRequestsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Create a request for launching a service.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="userName">Required parameter: Example: .</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <param name="body">Optional parameter: Request for launching a service..</param>
        /// <returns>Returns the ApiResponse of Models.ServiceLaunchRequestResult response from the API call.</returns>
        public ApiResponse<Models.ServiceLaunchRequestResult> CreateServiceLaunchRequest(
                string accountName,
                string userName,
                string correlationId = null,
                Models.CreateServiceLaunchRequest body = null)
            => CoreHelper.RunTask(CreateServiceLaunchRequestAsync(accountName, userName, correlationId, body));

        /// <summary>
        /// Create a request for launching a service.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="userName">Required parameter: Example: .</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <param name="body">Optional parameter: Request for launching a service..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ServiceLaunchRequestResult response from the API call.</returns>
        public async Task<ApiResponse<Models.ServiceLaunchRequestResult>> CreateServiceLaunchRequestAsync(
                string accountName,
                string userName,
                string correlationId = null,
                Models.CreateServiceLaunchRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ServiceLaunchRequestResult>()
              .Server(Server.Services)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/service/launch/request")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("AccountName", accountName))
                      .Header(_header => _header.Setup("userName", userName))
                      .Header(_header => _header.Setup("Content-Type", "*/*"))
                      .Header(_header => _header.Setup("correlationId", correlationId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("HTTP 400 Bad Request.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("HTTP 401 Unauthorized.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("HTTP 404 Not found.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("HTTP 500 Internal Server Error.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.ServiceLaunchRequestResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Get information related to a service launch request.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="userName">Required parameter: Example: .</param>
        /// <param name="id">Optional parameter: Service launch request Id..</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <param name="name">Optional parameter: Service request name..</param>
        /// <param name="offset">Optional parameter: Example: .</param>
        /// <param name="limit">Optional parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.ServiceLaunchRequestsResult response from the API call.</returns>
        public ApiResponse<Models.ServiceLaunchRequestsResult> GetServiceLaunchRequest(
                string accountName,
                string userName,
                Guid? id = null,
                string correlationId = null,
                string name = null,
                long? offset = null,
                long? limit = null)
            => CoreHelper.RunTask(GetServiceLaunchRequestAsync(accountName, userName, id, correlationId, name, offset, limit));

        /// <summary>
        /// Get information related to a service launch request.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="userName">Required parameter: Example: .</param>
        /// <param name="id">Optional parameter: Service launch request Id..</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <param name="name">Optional parameter: Service request name..</param>
        /// <param name="offset">Optional parameter: Example: .</param>
        /// <param name="limit">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ServiceLaunchRequestsResult response from the API call.</returns>
        public async Task<ApiResponse<Models.ServiceLaunchRequestsResult>> GetServiceLaunchRequestAsync(
                string accountName,
                string userName,
                Guid? id = null,
                string correlationId = null,
                string name = null,
                long? offset = null,
                long? limit = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ServiceLaunchRequestsResult>()
              .Server(Server.Services)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/service/launch/request")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("AccountName", accountName))
                      .Header(_header => _header.Setup("userName", userName))
                      .Query(_query => _query.Setup("id", id))
                      .Header(_header => _header.Setup("correlationId", correlationId))
                      .Query(_query => _query.Setup("name", name))
                      .Query(_query => _query.Setup("offset", offset))
                      .Query(_query => _query.Setup("limit", limit))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not found.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("415", CreateErrorCase("Unsupported media type.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too many requests.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Unexpected error.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.ServiceLaunchRequestsResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// This endpoint allows the user to submit a service request that describes the resource requirements of a service. This API submit an object of the service request and moves it to STATE from “DRAFT”  to “INSTANTIATED” and triggers the launch flow.
        /// </summary>
        /// <param name="id">Required parameter: A unique Id assigned to the request by system calling API..</param>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="userName">Required parameter: Example: .</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.ServiceLaunchRequestResult response from the API call.</returns>
        public ApiResponse<Models.ServiceLaunchRequestResult> SubmitServiceLaunchRequest(
                Guid id,
                string accountName,
                string userName,
                string correlationId = null)
            => CoreHelper.RunTask(SubmitServiceLaunchRequestAsync(id, accountName, userName, correlationId));

        /// <summary>
        /// This endpoint allows the user to submit a service request that describes the resource requirements of a service. This API submit an object of the service request and moves it to STATE from “DRAFT”  to “INSTANTIATED” and triggers the launch flow.
        /// </summary>
        /// <param name="id">Required parameter: A unique Id assigned to the request by system calling API..</param>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="userName">Required parameter: Example: .</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ServiceLaunchRequestResult response from the API call.</returns>
        public async Task<ApiResponse<Models.ServiceLaunchRequestResult>> SubmitServiceLaunchRequestAsync(
                Guid id,
                string accountName,
                string userName,
                string correlationId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ServiceLaunchRequestResult>()
              .Server(Server.Services)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/v1/service/launch/request/{id}/submit")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Header(_header => _header.Setup("AccountName", accountName))
                      .Header(_header => _header.Setup("userName", userName))
                      .Header(_header => _header.Setup("correlationId", correlationId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("HTTP 400 Bad Request.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("HTTP 401 Unauthorized.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("412", CreateErrorCase("Precondition Failed.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("HTTP 500 Internal Server Error.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.ServiceLaunchRequestResult>(_response)))
              .ExecuteAsync(cancellationToken);
    }
}