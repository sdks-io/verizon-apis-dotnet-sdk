// <copyright file="ServiceMetadataController.cs" company="APIMatic">
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
    /// ServiceMetadataController.
    /// </summary>
    public class ServiceMetadataController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceMetadataController"/> class.
        /// </summary>
        internal ServiceMetadataController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Create a new category within user's organization.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of List<Models.Category> response from the API call.</returns>
        public ApiResponse<List<Models.Category>> CreateServiceCategory(
                string accountName,
                List<Models.Category> body,
                string correlationId = null)
            => CoreHelper.RunTask(CreateServiceCategoryAsync(accountName, body, correlationId));

        /// <summary>
        /// Create a new category within user's organization.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List<Models.Category> response from the API call.</returns>
        public async Task<ApiResponse<List<Models.Category>>> CreateServiceCategoryAsync(
                string accountName,
                List<Models.Category> body,
                string correlationId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.Category>>()
              .Server(Server.Services)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/category")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("AccountName", accountName))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("correlationId", correlationId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not found.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<List<Models.Category>>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Create a new Tag within user's organization.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of List<Models.Tag> response from the API call.</returns>
        public ApiResponse<List<Models.Tag>> CreateServiceTag(
                string accountName,
                List<Models.Tag> body,
                string correlationId = null)
            => CoreHelper.RunTask(CreateServiceTagAsync(accountName, body, correlationId));

        /// <summary>
        /// Create a new Tag within user's organization.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List<Models.Tag> response from the API call.</returns>
        public async Task<ApiResponse<List<Models.Tag>>> CreateServiceTagAsync(
                string accountName,
                List<Models.Tag> body,
                string correlationId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.Tag>>()
              .Server(Server.Services)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/tag/")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("AccountName", accountName))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("correlationId", correlationId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("401", CreateErrorCase("Unauthorized.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not found.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("415", CreateErrorCase("Unsupported media type.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<List<Models.Tag>>(_response)))
              .ExecuteAsync(cancellationToken);
    }
}