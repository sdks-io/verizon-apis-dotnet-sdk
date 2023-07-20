// <copyright file="ServiceInstanceOperationsController.cs" company="APIMatic">
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
    /// ServiceInstanceOperationsController.
    /// </summary>
    public class ServiceInstanceOperationsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceInstanceOperationsController"/> class.
        /// </summary>
        internal ServiceInstanceOperationsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Suspend a service Instance.
        /// </summary>
        /// <param name="serviceInstanceId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="requestId">Required parameter: Example: .</param>
        /// <param name="userRole">Required parameter: Example: .</param>
        /// <param name="customerId">Required parameter: Example: .</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.ServiceResumeResult response from the API call.</returns>
        public ApiResponse<Models.ServiceResumeResult> ServiceSuspend(
                string serviceInstanceId,
                string userId,
                string requestId,
                Models.UserRoleEnum userRole,
                string customerId,
                string correlationId = null)
            => CoreHelper.RunTask(ServiceSuspendAsync(serviceInstanceId, userId, requestId, userRole, customerId, correlationId));

        /// <summary>
        /// Suspend a service Instance.
        /// </summary>
        /// <param name="serviceInstanceId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="requestId">Required parameter: Example: .</param>
        /// <param name="userRole">Required parameter: Example: .</param>
        /// <param name="customerId">Required parameter: Example: .</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ServiceResumeResult response from the API call.</returns>
        public async Task<ApiResponse<Models.ServiceResumeResult>> ServiceSuspendAsync(
                string serviceInstanceId,
                string userId,
                string requestId,
                Models.UserRoleEnum userRole,
                string customerId,
                string correlationId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ServiceResumeResult>()
              .Server(Server.Services)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/service/instances/{serviceInstanceId}/suspend")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("serviceInstanceId", serviceInstanceId))
                      .Header(_header => _header.Setup("userId", userId))
                      .Header(_header => _header.Setup("requestId", requestId))
                      .Header(_header => _header.Setup("user_role", ApiHelper.JsonSerialize(userRole).Trim('\"')))
                      .Header(_header => _header.Setup("customerId", customerId))
                      .Header(_header => _header.Setup("correlationId", correlationId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not found.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("415", CreateErrorCase("Unsupported media type.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too many requests.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Unexpected error.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.ServiceResumeResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// remove a service Instance.
        /// </summary>
        /// <param name="serviceInstanceId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="requestId">Required parameter: Example: .</param>
        /// <param name="userRole">Required parameter: Example: .</param>
        /// <param name="customerId">Required parameter: Example: .</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.ServiceResumeResult response from the API call.</returns>
        public ApiResponse<Models.ServiceResumeResult> ServiceRemove(
                string serviceInstanceId,
                string userId,
                string requestId,
                Models.UserRoleEnum userRole,
                string customerId,
                string correlationId = null)
            => CoreHelper.RunTask(ServiceRemoveAsync(serviceInstanceId, userId, requestId, userRole, customerId, correlationId));

        /// <summary>
        /// remove a service Instance.
        /// </summary>
        /// <param name="serviceInstanceId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="requestId">Required parameter: Example: .</param>
        /// <param name="userRole">Required parameter: Example: .</param>
        /// <param name="customerId">Required parameter: Example: .</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ServiceResumeResult response from the API call.</returns>
        public async Task<ApiResponse<Models.ServiceResumeResult>> ServiceRemoveAsync(
                string serviceInstanceId,
                string userId,
                string requestId,
                Models.UserRoleEnum userRole,
                string customerId,
                string correlationId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ServiceResumeResult>()
              .Server(Server.Services)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/v1/service/instances/{serviceInstanceId}/remove")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("serviceInstanceId", serviceInstanceId))
                      .Header(_header => _header.Setup("userId", userId))
                      .Header(_header => _header.Setup("requestId", requestId))
                      .Header(_header => _header.Setup("user_role", ApiHelper.JsonSerialize(userRole).Trim('\"')))
                      .Header(_header => _header.Setup("customerId", customerId))
                      .Header(_header => _header.Setup("correlationId", correlationId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not found.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("415", CreateErrorCase("Unsupported media type.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too many requests.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Unexpected error.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.ServiceResumeResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Resumes a suspended Service Instance.
        /// </summary>
        /// <param name="serviceInstanceId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="requestId">Required parameter: Example: .</param>
        /// <param name="userRole">Required parameter: Example: .</param>
        /// <param name="customerId">Required parameter: Example: .</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.ServiceResumeResult response from the API call.</returns>
        public ApiResponse<Models.ServiceResumeResult> ServiceResume(
                string serviceInstanceId,
                string userId,
                string requestId,
                Models.UserRoleEnum userRole,
                string customerId,
                string correlationId = null)
            => CoreHelper.RunTask(ServiceResumeAsync(serviceInstanceId, userId, requestId, userRole, customerId, correlationId));

        /// <summary>
        /// Resumes a suspended Service Instance.
        /// </summary>
        /// <param name="serviceInstanceId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="requestId">Required parameter: Example: .</param>
        /// <param name="userRole">Required parameter: Example: .</param>
        /// <param name="customerId">Required parameter: Example: .</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ServiceResumeResult response from the API call.</returns>
        public async Task<ApiResponse<Models.ServiceResumeResult>> ServiceResumeAsync(
                string serviceInstanceId,
                string userId,
                string requestId,
                Models.UserRoleEnum userRole,
                string customerId,
                string correlationId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ServiceResumeResult>()
              .Server(Server.Services)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/service/instances/{serviceInstanceId}/resume")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("serviceInstanceId", serviceInstanceId))
                      .Header(_header => _header.Setup("userId", userId))
                      .Header(_header => _header.Setup("requestId", requestId))
                      .Header(_header => _header.Setup("user_role", ApiHelper.JsonSerialize(userRole).Trim('\"')))
                      .Header(_header => _header.Setup("customerId", customerId))
                      .Header(_header => _header.Setup("correlationId", correlationId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not found.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("415", CreateErrorCase("Unsupported media type.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too many requests.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Unexpected error.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.ServiceResumeResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// upgrade a service Instance.
        /// </summary>
        /// <param name="serviceInstanceId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="requestId">Required parameter: Example: .</param>
        /// <param name="userRole">Required parameter: Example: .</param>
        /// <param name="customerId">Required parameter: Example: .</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.ServiceResumeResult response from the API call.</returns>
        public ApiResponse<Models.ServiceResumeResult> ServiceUpgrade(
                string serviceInstanceId,
                string userId,
                string requestId,
                Models.UserRoleEnum userRole,
                string customerId,
                string correlationId = null)
            => CoreHelper.RunTask(ServiceUpgradeAsync(serviceInstanceId, userId, requestId, userRole, customerId, correlationId));

        /// <summary>
        /// upgrade a service Instance.
        /// </summary>
        /// <param name="serviceInstanceId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="requestId">Required parameter: Example: .</param>
        /// <param name="userRole">Required parameter: Example: .</param>
        /// <param name="customerId">Required parameter: Example: .</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ServiceResumeResult response from the API call.</returns>
        public async Task<ApiResponse<Models.ServiceResumeResult>> ServiceUpgradeAsync(
                string serviceInstanceId,
                string userId,
                string requestId,
                Models.UserRoleEnum userRole,
                string customerId,
                string correlationId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ServiceResumeResult>()
              .Server(Server.Services)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/service/instances/{serviceInstanceId}/upgrade")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("serviceInstanceId", serviceInstanceId))
                      .Header(_header => _header.Setup("userId", userId))
                      .Header(_header => _header.Setup("requestId", requestId))
                      .Header(_header => _header.Setup("user_role", ApiHelper.JsonSerialize(userRole).Trim('\"')))
                      .Header(_header => _header.Setup("customerId", customerId))
                      .Header(_header => _header.Setup("correlationId", correlationId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not found.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("415", CreateErrorCase("Unsupported media type.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too many requests.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Unexpected error.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.ServiceResumeResult>(_response)))
              .ExecuteAsync(cancellationToken);
    }
}