// <copyright file="CSPProfilesController.cs" company="APIMatic">
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
    /// CSPProfilesController.
    /// </summary>
    public class CSPProfilesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CSPProfilesController"/> class.
        /// </summary>
        internal CSPProfilesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Fetch available cloud credentials within user's organization.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <param name="q">Optional parameter: Use the coloumn (:) character to separate multiple query params eg type=AWS:awsCspProfile.credType=ACCESS_KEY,ROLE_ARN:state=UNVERIFIED,VERIFIED..</param>
        /// <param name="limit">Optional parameter: Number of items to return..</param>
        /// <param name="offSet">Optional parameter: Id of the last respose value in the previous list..</param>
        /// <returns>Returns the ApiResponse of Models.CSPProfileData response from the API call.</returns>
        public ApiResponse<Models.CSPProfileData> FetchCloudCredentialDetails(
                string accountName,
                string correlationId = null,
                string q = null,
                long? limit = null,
                long? offSet = null)
            => CoreHelper.RunTask(FetchCloudCredentialDetailsAsync(accountName, correlationId, q, limit, offSet));

        /// <summary>
        /// Fetch available cloud credentials within user's organization.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <param name="q">Optional parameter: Use the coloumn (:) character to separate multiple query params eg type=AWS:awsCspProfile.credType=ACCESS_KEY,ROLE_ARN:state=UNVERIFIED,VERIFIED..</param>
        /// <param name="limit">Optional parameter: Number of items to return..</param>
        /// <param name="offSet">Optional parameter: Id of the last respose value in the previous list..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.CSPProfileData response from the API call.</returns>
        public async Task<ApiResponse<Models.CSPProfileData>> FetchCloudCredentialDetailsAsync(
                string accountName,
                string correlationId = null,
                string q = null,
                long? limit = null,
                long? offSet = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CSPProfileData>()
              .Server(Server.Services)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/cspProfiles/")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("AccountName", accountName))
                      .Header(_header => _header.Setup("correlationId", correlationId))
                      .Query(_query => _query.Setup("q", q))
                      .Query(_query => _query.Setup("limit", limit))
                      .Query(_query => _query.Setup("offSet", offSet))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("401", CreateErrorCase("Unauthorized.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not found.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too many requests.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Forbidden.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.CSPProfileData>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Create a new cloud credential within user's organization.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.CSPProfile response from the API call.</returns>
        public ApiResponse<Models.CSPProfile> CreateCloudCredential(
                string accountName,
                Models.CSPProfile body,
                string correlationId = null)
            => CoreHelper.RunTask(CreateCloudCredentialAsync(accountName, body, correlationId));

        /// <summary>
        /// Create a new cloud credential within user's organization.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.CSPProfile response from the API call.</returns>
        public async Task<ApiResponse<Models.CSPProfile>> CreateCloudCredentialAsync(
                string accountName,
                Models.CSPProfile body,
                string correlationId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CSPProfile>()
              .Server(Server.Services)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/cspProfiles/")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("AccountName", accountName))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("correlationId", correlationId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too many requests.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Forbidden.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.CSPProfile>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Remove a cloud credential from user's organization.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="id">Required parameter: CSP Profile Id..</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.EdgeServiceOnboardingDeleteResult response from the API call.</returns>
        public ApiResponse<Models.EdgeServiceOnboardingDeleteResult> RemoveCloudCredential(
                string accountName,
                string id,
                string correlationId = null)
            => CoreHelper.RunTask(RemoveCloudCredentialAsync(accountName, id, correlationId));

        /// <summary>
        /// Remove a cloud credential from user's organization.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="id">Required parameter: CSP Profile Id..</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.EdgeServiceOnboardingDeleteResult response from the API call.</returns>
        public async Task<ApiResponse<Models.EdgeServiceOnboardingDeleteResult>> RemoveCloudCredentialAsync(
                string accountName,
                string id,
                string correlationId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.EdgeServiceOnboardingDeleteResult>()
              .Server(Server.Services)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/v1/cspProfiles/{id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("AccountName", accountName))
                      .Template(_template => _template.Setup("id", id))
                      .Header(_header => _header.Setup("correlationId", correlationId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("401", CreateErrorCase("Unauthorized.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.EdgeServiceOnboardingDeleteResult>(_response)))
              .ExecuteAsync(cancellationToken);
    }
}