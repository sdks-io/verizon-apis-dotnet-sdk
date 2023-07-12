// <copyright file="ServiceLaunchProfilesController.cs" company="APIMatic">
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
    /// ServiceLaunchProfilesController.
    /// </summary>
    public class ServiceLaunchProfilesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceLaunchProfilesController"/> class.
        /// </summary>
        internal ServiceLaunchProfilesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Creates a service profile that describes the resource requirements of a service.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="body">Required parameter: Request for creation of a service profile..</param>
        /// <returns>Returns the ApiResponse of Models.ServicesProfileRegistration response from the API call.</returns>
        public ApiResponse<Models.ServicesProfileRegistration> CreateServiceProfile(
                string accountName,
                Models.CreateServiceProfileRequest body)
            => CoreHelper.RunTask(CreateServiceProfileAsync(accountName, body));

        /// <summary>
        /// Creates a service profile that describes the resource requirements of a service.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="body">Required parameter: Request for creation of a service profile..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ServicesProfileRegistration response from the API call.</returns>
        public async Task<ApiResponse<Models.ServicesProfileRegistration>> CreateServiceProfileAsync(
                string accountName,
                Models.CreateServiceProfileRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ServicesProfileRegistration>()
              .Server(Server.Services)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/service/profile")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("AccountName", accountName))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("HTTP 400 Bad Request.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("HTTP 401 Unauthorized.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("HTTP 500 Internal Server Error.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.ServicesProfileRegistration>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Update the definition of a service profile.
        /// </summary>
        /// <param name="id">Required parameter: Unique ID of the service profile..</param>
        /// <param name="body">Required parameter: Request with new information for updating the service profile..</param>
        /// <param name="accountName">Optional parameter: User account name..</param>
        /// <returns>Returns the ApiResponse of string response from the API call.</returns>
        public ApiResponse<string> UpdateServiceProfile(
                string id,
                Models.CreateServiceProfileRequest body,
                string accountName = null)
            => CoreHelper.RunTask(UpdateServiceProfileAsync(id, body, accountName));

        /// <summary>
        /// Update the definition of a service profile.
        /// </summary>
        /// <param name="id">Required parameter: Unique ID of the service profile..</param>
        /// <param name="body">Required parameter: Request with new information for updating the service profile..</param>
        /// <param name="accountName">Optional parameter: User account name..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of string response from the API call.</returns>
        public async Task<ApiResponse<string>> UpdateServiceProfileAsync(
                string id,
                Models.CreateServiceProfileRequest body,
                string accountName = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<string>()
              .Server(Server.Services)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/v1/service/profile/{Id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("Id", id))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("AccountName", accountName))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("HTTP 400 Bad Request.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("HTTP 401 Unauthorized.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("HTTP 500 Internal Server Error.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
)
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Helps register a service profile.
        /// </summary>
        /// <param name="id">Required parameter: Unique service profile ID..</param>
        /// <param name="body">Required parameter: Request for registration of a service profile..</param>
        /// <param name="accountName">Optional parameter: User account name..</param>
        /// <returns>Returns the ApiResponse of Models.ServicesProfileRegistrationResult response from the API call.</returns>
        public ApiResponse<Models.ServicesProfileRegistrationResult> SubmitServiceProfile(
                string id,
                Models.ServicesProfileRegistration body,
                string accountName = null)
            => CoreHelper.RunTask(SubmitServiceProfileAsync(id, body, accountName));

        /// <summary>
        /// Helps register a service profile.
        /// </summary>
        /// <param name="id">Required parameter: Unique service profile ID..</param>
        /// <param name="body">Required parameter: Request for registration of a service profile..</param>
        /// <param name="accountName">Optional parameter: User account name..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ServicesProfileRegistrationResult response from the API call.</returns>
        public async Task<ApiResponse<Models.ServicesProfileRegistrationResult>> SubmitServiceProfileAsync(
                string id,
                Models.ServicesProfileRegistration body,
                string accountName = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ServicesProfileRegistrationResult>()
              .Server(Server.Services)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/v1/service/profile/{id}/submit")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("id", id))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("AccountName", accountName))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("HTTP 400 Bad Request.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("HTTP 401 Unauthorized.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("412", CreateErrorCase("Precondition Failed.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("HTTP 500 Internal Server Error.", (_reason, _context) => new EdgeServiceLaunchResultException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.ServicesProfileRegistrationResult>(_response)))
              .ExecuteAsync(cancellationToken);
    }
}