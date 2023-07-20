// <copyright file="RepositoriesController.cs" company="APIMatic">
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
    /// RepositoriesController.
    /// </summary>
    public class RepositoriesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoriesController"/> class.
        /// </summary>
        internal RepositoriesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Delete the repository.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="repositoryName">Required parameter: Name of the repository which is about to be deleted..</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.EdgeServiceOnboardingDeleteResult response from the API call.</returns>
        public ApiResponse<Models.EdgeServiceOnboardingDeleteResult> DeleteRepository(
                string accountName,
                string repositoryName,
                string correlationId = null)
            => CoreHelper.RunTask(DeleteRepositoryAsync(accountName, repositoryName, correlationId));

        /// <summary>
        /// Delete the repository.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="repositoryName">Required parameter: Name of the repository which is about to be deleted..</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.EdgeServiceOnboardingDeleteResult response from the API call.</returns>
        public async Task<ApiResponse<Models.EdgeServiceOnboardingDeleteResult>> DeleteRepositoryAsync(
                string accountName,
                string repositoryName,
                string correlationId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.EdgeServiceOnboardingDeleteResult>()
              .Server(Server.Services)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/v1/config/repository/{repositoryName}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("AccountName", accountName))
                      .Template(_template => _template.Setup("repositoryName", repositoryName))
                      .Header(_header => _header.Setup("correlationId", correlationId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not found.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.EdgeServiceOnboardingDeleteResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Get all repositories in the platform.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <param name="type">Optional parameter: Repository type..</param>
        /// <returns>Returns the ApiResponse of List<Models.Repository> response from the API call.</returns>
        public ApiResponse<List<Models.Repository>> ListRepositories(
                string accountName,
                string correlationId = null,
                string type = null)
            => CoreHelper.RunTask(ListRepositoriesAsync(accountName, correlationId, type));

        /// <summary>
        /// Get all repositories in the platform.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <param name="type">Optional parameter: Repository type..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List<Models.Repository> response from the API call.</returns>
        public async Task<ApiResponse<List<Models.Repository>>> ListRepositoriesAsync(
                string accountName,
                string correlationId = null,
                string type = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.Repository>>()
              .Server(Server.Services)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/config/repository")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("AccountName", accountName))
                      .Header(_header => _header.Setup("correlationId", correlationId))
                      .Query(_query => _query.Setup("type", type))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("401", CreateErrorCase("Unauthorized.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not found.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<List<Models.Repository>>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Create a repository within user's organziation.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.Repository response from the API call.</returns>
        public ApiResponse<Models.Repository> CreateRepository(
                string accountName,
                Models.Repository body,
                string correlationId = null)
            => CoreHelper.RunTask(CreateRepositoryAsync(accountName, body, correlationId));

        /// <summary>
        /// Create a repository within user's organziation.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Repository response from the API call.</returns>
        public async Task<ApiResponse<Models.Repository>> CreateRepositoryAsync(
                string accountName,
                Models.Repository body,
                string correlationId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Repository>()
              .Server(Server.Services)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/config/repository")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("AccountName", accountName))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("correlationId", correlationId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.Repository>(_response)))
              .ExecuteAsync(cancellationToken);
    }
}