// <copyright file="ServiceClaimsController.cs" company="APIMatic">
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
    /// ServiceClaimsController.
    /// </summary>
    public class ServiceClaimsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceClaimsController"/> class.
        /// </summary>
        internal ServiceClaimsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Fetch all service's claim(s) associated with a service. Service claims are generated based on service's compatibility with different cloud service provider.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="serviceId">Required parameter: Auto-generated Id of the claim whose information needs to be fetched..</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <param name="claimStatus">Optional parameter: Queries with claim status on the claims..</param>
        /// <param name="q">Optional parameter: Use the comma (,) character to separate multiple values,eg claimType=Public MEC:claims.sandBoxState=NOT_STARTED,STARTED..</param>
        /// <param name="limit">Optional parameter: Number of items to return..</param>
        /// <param name="offSet">Optional parameter: Id of the last respose value in the previous list..</param>
        /// <param name="sortKey">Optional parameter: Sorts the response by an attribute. Default is createdDate..</param>
        /// <param name="sortDir">Optional parameter: Sorts the response. Use asc for ascending or desc for descending order. The default is desc..</param>
        /// <param name="detailsFlag">Optional parameter: Default as true. If it is true then it will return all details..</param>
        /// <returns>Returns the ApiResponse of Models.ServiceClaims response from the API call.</returns>
        public ApiResponse<Models.ServiceClaims> ListServiceClaims(
                string accountName,
                string serviceId,
                string correlationId = null,
                string claimStatus = null,
                string q = null,
                long? limit = null,
                long? offSet = null,
                string sortKey = "createdDate",
                Models.SortDirectionEnum? sortDir = null,
                bool? detailsFlag = true)
            => CoreHelper.RunTask(ListServiceClaimsAsync(accountName, serviceId, correlationId, claimStatus, q, limit, offSet, sortKey, sortDir, detailsFlag));

        /// <summary>
        /// Fetch all service's claim(s) associated with a service. Service claims are generated based on service's compatibility with different cloud service provider.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="serviceId">Required parameter: Auto-generated Id of the claim whose information needs to be fetched..</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <param name="claimStatus">Optional parameter: Queries with claim status on the claims..</param>
        /// <param name="q">Optional parameter: Use the comma (,) character to separate multiple values,eg claimType=Public MEC:claims.sandBoxState=NOT_STARTED,STARTED..</param>
        /// <param name="limit">Optional parameter: Number of items to return..</param>
        /// <param name="offSet">Optional parameter: Id of the last respose value in the previous list..</param>
        /// <param name="sortKey">Optional parameter: Sorts the response by an attribute. Default is createdDate..</param>
        /// <param name="sortDir">Optional parameter: Sorts the response. Use asc for ascending or desc for descending order. The default is desc..</param>
        /// <param name="detailsFlag">Optional parameter: Default as true. If it is true then it will return all details..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ServiceClaims response from the API call.</returns>
        public async Task<ApiResponse<Models.ServiceClaims>> ListServiceClaimsAsync(
                string accountName,
                string serviceId,
                string correlationId = null,
                string claimStatus = null,
                string q = null,
                long? limit = null,
                long? offSet = null,
                string sortKey = "createdDate",
                Models.SortDirectionEnum? sortDir = null,
                bool? detailsFlag = true,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ServiceClaims>()
              .Server(Server.Services)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/service/{serviceId}/claims")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("AccountName", accountName))
                      .Template(_template => _template.Setup("serviceId", serviceId))
                      .Header(_header => _header.Setup("correlationId", correlationId))
                      .Query(_query => _query.Setup("claimStatus", claimStatus))
                      .Query(_query => _query.Setup("q", q))
                      .Query(_query => _query.Setup("limit", limit))
                      .Query(_query => _query.Setup("offSet", offSet))
                      .Query(_query => _query.Setup("sortKey", (sortKey != null) ? sortKey : "createdDate"))
                      .Query(_query => _query.Setup("sortDir", (sortDir.HasValue) ? ApiHelper.JsonSerialize(sortDir.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("detailsFlag", (detailsFlag != null) ? detailsFlag : true))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not found.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.ServiceClaims>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Associate an existing cloud credential with a service's claim which will be used to connect to user's cloud provider.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="serviceId">Required parameter: System generated unique identifier of the service which user is using..</param>
        /// <param name="claimId">Required parameter: System generated unique identifier for the claim which user is using..</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.AssociateCloudCredentialResult response from the API call.</returns>
        public ApiResponse<Models.AssociateCloudCredentialResult> AssociateCloudCredentialWithServiceClaim(
                string accountName,
                string serviceId,
                string claimId,
                Models.CSPProfileIdRequest body,
                string correlationId = null)
            => CoreHelper.RunTask(AssociateCloudCredentialWithServiceClaimAsync(accountName, serviceId, claimId, body, correlationId));

        /// <summary>
        /// Associate an existing cloud credential with a service's claim which will be used to connect to user's cloud provider.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="serviceId">Required parameter: System generated unique identifier of the service which user is using..</param>
        /// <param name="claimId">Required parameter: System generated unique identifier for the claim which user is using..</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.AssociateCloudCredentialResult response from the API call.</returns>
        public async Task<ApiResponse<Models.AssociateCloudCredentialResult>> AssociateCloudCredentialWithServiceClaimAsync(
                string accountName,
                string serviceId,
                string claimId,
                Models.CSPProfileIdRequest body,
                string correlationId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AssociateCloudCredentialResult>()
              .Server(Server.Services)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/services/{serviceId}/claims/{claimId}/associateCspProfile")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("AccountName", accountName))
                      .Template(_template => _template.Setup("serviceId", serviceId))
                      .Template(_template => _template.Setup("claimId", claimId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("correlationId", correlationId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.AssociateCloudCredentialResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Mark a service's claim status as complete post successful verification of sandbox testing in the respective sandbox environment.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="serviceId">Required parameter: System generated unique identifier of the service which user is using..</param>
        /// <param name="claimId">Required parameter: System generated unique identifier of the claim which user is using..</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        public void MarkServiceClaimStatusAsCompleted(
                string accountName,
                string serviceId,
                string claimId,
                string correlationId = null)
            => CoreHelper.RunVoidTask(MarkServiceClaimStatusAsCompletedAsync(accountName, serviceId, claimId, correlationId));

        /// <summary>
        /// Mark a service's claim status as complete post successful verification of sandbox testing in the respective sandbox environment.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="serviceId">Required parameter: System generated unique identifier of the service which user is using..</param>
        /// <param name="claimId">Required parameter: System generated unique identifier of the claim which user is using..</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task MarkServiceClaimStatusAsCompletedAsync(
                string accountName,
                string serviceId,
                string claimId,
                string correlationId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .Server(Server.Services)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/services/{serviceId}/claims/{claimId}/claimStatusCompleted")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("AccountName", accountName))
                      .Template(_template => _template.Setup("serviceId", serviceId))
                      .Template(_template => _template.Setup("claimId", claimId))
                      .Header(_header => _header.Setup("correlationId", correlationId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
)
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Using this API user can update service's claim status as complete/verified etc.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="serviceId">Required parameter: System generated unique identifier of the service which user is using..</param>
        /// <param name="claimId">Required parameter: System generated unique identifier of the claim which user is using..</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        public void UpdateServiceClaimStatus(
                string accountName,
                string serviceId,
                string claimId,
                Models.ClaimStatusRequest body,
                string correlationId = null)
            => CoreHelper.RunVoidTask(UpdateServiceClaimStatusAsync(accountName, serviceId, claimId, body, correlationId));

        /// <summary>
        /// Using this API user can update service's claim status as complete/verified etc.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="serviceId">Required parameter: System generated unique identifier of the service which user is using..</param>
        /// <param name="claimId">Required parameter: System generated unique identifier of the claim which user is using..</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task UpdateServiceClaimStatusAsync(
                string accountName,
                string serviceId,
                string claimId,
                Models.ClaimStatusRequest body,
                string correlationId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .Server(Server.Services)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/services/{serviceId}/claims/{claimId}/claimStatus")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("AccountName", accountName))
                      .Template(_template => _template.Setup("serviceId", serviceId))
                      .Template(_template => _template.Setup("claimId", claimId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("correlationId", correlationId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
)
              .ExecuteAsync(cancellationToken);
    }
}