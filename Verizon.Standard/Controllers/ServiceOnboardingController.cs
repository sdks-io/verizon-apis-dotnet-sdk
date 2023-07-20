// <copyright file="ServiceOnboardingController.cs" company="APIMatic">
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
    /// ServiceOnboardingController.
    /// </summary>
    public class ServiceOnboardingController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceOnboardingController"/> class.
        /// </summary>
        internal ServiceOnboardingController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Fetch all organizational services in the platform.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <param name="name">Optional parameter: Name of the service whose information needs to be fetched..</param>
        /// <param name="q">Optional parameter: Use the comma (:) character to separate multiple values eg type=myService:workloads.packageType=Helm,YAML:state=DRAFTED,VALIDATION_COMPLETED..</param>
        /// <param name="limit">Optional parameter: Number of items to return..</param>
        /// <param name="offSet">Optional parameter: Id of the last respose value in the previous list..</param>
        /// <param name="sortKey">Optional parameter: Sorts the response by an attribute. Default is createdDate..</param>
        /// <param name="sortDir">Optional parameter: Sorts the response. Use asc for ascending or desc for descending order. The default is desc..</param>
        /// <param name="detailsFlag">Optional parameter: Default as true. If it is true, then it will return all details..</param>
        /// <returns>Returns the ApiResponse of Models.Services response from the API call.</returns>
        public ApiResponse<Models.Services> ListServices(
                string accountName,
                string correlationId = null,
                string name = null,
                string q = null,
                long? limit = null,
                long? offSet = null,
                string sortKey = "createdDate",
                Models.SortDirectionEnum? sortDir = null,
                bool? detailsFlag = true)
            => CoreHelper.RunTask(ListServicesAsync(accountName, correlationId, name, q, limit, offSet, sortKey, sortDir, detailsFlag));

        /// <summary>
        /// Fetch all organizational services in the platform.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <param name="name">Optional parameter: Name of the service whose information needs to be fetched..</param>
        /// <param name="q">Optional parameter: Use the comma (:) character to separate multiple values eg type=myService:workloads.packageType=Helm,YAML:state=DRAFTED,VALIDATION_COMPLETED..</param>
        /// <param name="limit">Optional parameter: Number of items to return..</param>
        /// <param name="offSet">Optional parameter: Id of the last respose value in the previous list..</param>
        /// <param name="sortKey">Optional parameter: Sorts the response by an attribute. Default is createdDate..</param>
        /// <param name="sortDir">Optional parameter: Sorts the response. Use asc for ascending or desc for descending order. The default is desc..</param>
        /// <param name="detailsFlag">Optional parameter: Default as true. If it is true, then it will return all details..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Services response from the API call.</returns>
        public async Task<ApiResponse<Models.Services>> ListServicesAsync(
                string accountName,
                string correlationId = null,
                string name = null,
                string q = null,
                long? limit = null,
                long? offSet = null,
                string sortKey = "createdDate",
                Models.SortDirectionEnum? sortDir = null,
                bool? detailsFlag = true,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Services>()
              .Server(Server.Services)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/services")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("AccountName", accountName))
                      .Header(_header => _header.Setup("correlationId", correlationId))
                      .Query(_query => _query.Setup("name", name))
                      .Query(_query => _query.Setup("q", q))
                      .Query(_query => _query.Setup("limit", limit))
                      .Query(_query => _query.Setup("offSet", offSet))
                      .Query(_query => _query.Setup("sortKey", (sortKey != null) ? sortKey : "createdDate"))
                      .Query(_query => _query.Setup("sortDir", (sortDir.HasValue) ? ApiHelper.JsonSerialize(sortDir.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("detailsFlag", (detailsFlag != null) ? detailsFlag : true))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.Services>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Create a new service within user's organization.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.Service response from the API call.</returns>
        public ApiResponse<Models.Service> RegisterService(
                string accountName,
                Models.Service body,
                string correlationId = null)
            => CoreHelper.RunTask(RegisterServiceAsync(accountName, body, correlationId));

        /// <summary>
        /// Create a new service within user's organization.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Service response from the API call.</returns>
        public async Task<ApiResponse<Models.Service>> RegisterServiceAsync(
                string accountName,
                Models.Service body,
                string correlationId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Service>()
              .Server(Server.Services)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/services")
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
                  .ErrorCase("404", CreateErrorCase("Not found.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("415", CreateErrorCase("Unsupported media type.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too many requests.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.Service>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Upload workload payload/package in the MEC platform.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="serviceName">Required parameter: Service name to which the file is going to be associated..</param>
        /// <param name="version">Required parameter: Version of the service being used..</param>
        /// <param name="categoryType">Required parameter: Type of the file being uploaded..</param>
        /// <param name="categoryName">Required parameter: `workloadName` used in the service while creation..</param>
        /// <param name="payload">Required parameter: Payload/file which is to be uploaded should be provided in formData..</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <param name="categoryVersion">Optional parameter: It is mandatory for only service file, not mandatory for workload and workflow file..</param>
        /// <returns>Returns the ApiResponse of Models.ServiceFile response from the API call.</returns>
        public ApiResponse<Models.ServiceFile> UploadServiceWorkloadFile(
                string accountName,
                string serviceName,
                string version,
                Models.CategoryTypeEnum categoryType,
                string categoryName,
                FileStreamInfo payload,
                string correlationId = null,
                string categoryVersion = null)
            => CoreHelper.RunTask(UploadServiceWorkloadFileAsync(accountName, serviceName, version, categoryType, categoryName, payload, correlationId, categoryVersion));

        /// <summary>
        /// Upload workload payload/package in the MEC platform.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="serviceName">Required parameter: Service name to which the file is going to be associated..</param>
        /// <param name="version">Required parameter: Version of the service being used..</param>
        /// <param name="categoryType">Required parameter: Type of the file being uploaded..</param>
        /// <param name="categoryName">Required parameter: `workloadName` used in the service while creation..</param>
        /// <param name="payload">Required parameter: Payload/file which is to be uploaded should be provided in formData..</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <param name="categoryVersion">Optional parameter: It is mandatory for only service file, not mandatory for workload and workflow file..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ServiceFile response from the API call.</returns>
        public async Task<ApiResponse<Models.ServiceFile>> UploadServiceWorkloadFileAsync(
                string accountName,
                string serviceName,
                string version,
                Models.CategoryTypeEnum categoryType,
                string categoryName,
                FileStreamInfo payload,
                string correlationId = null,
                string categoryVersion = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ServiceFile>()
              .Server(Server.Services)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/files/{serviceName}/{version}/uploadAndValidate")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("AccountName", accountName))
                      .Template(_template => _template.Setup("serviceName", serviceName))
                      .Template(_template => _template.Setup("version", version))
                      .Query(_query => _query.Setup("categoryType", ApiHelper.JsonSerialize(categoryType).Trim('\"')))
                      .Query(_query => _query.Setup("categoryName", categoryName))
                      .Form(_form => _form.Setup("payload", payload))
                      .Header(_header => _header.Setup("correlationId", correlationId))
                      .Query(_query => _query.Setup("categoryVersion", categoryVersion))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not found.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.ServiceFile>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Fetch a service details within user's organization using service name and version.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="serviceName">Required parameter: Name of the service whose information needs to be fetched..</param>
        /// <param name="version">Required parameter: Version of service whose information needs to be fetched..</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.Service response from the API call.</returns>
        public ApiResponse<Models.Service> ListServiceDetails(
                string accountName,
                string serviceName,
                string version,
                string correlationId = null)
            => CoreHelper.RunTask(ListServiceDetailsAsync(accountName, serviceName, version, correlationId));

        /// <summary>
        /// Fetch a service details within user's organization using service name and version.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="serviceName">Required parameter: Name of the service whose information needs to be fetched..</param>
        /// <param name="version">Required parameter: Version of service whose information needs to be fetched..</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Service response from the API call.</returns>
        public async Task<ApiResponse<Models.Service>> ListServiceDetailsAsync(
                string accountName,
                string serviceName,
                string version,
                string correlationId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Service>()
              .Server(Server.Services)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/services/{serviceName}/{version}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("AccountName", accountName))
                      .Template(_template => _template.Setup("serviceName", serviceName))
                      .Template(_template => _template.Setup("version", version))
                      .Header(_header => _header.Setup("correlationId", correlationId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Unexpected error.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.Service>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Initiate testing of a service in sandbox environment per claim based on service's compatibility(s).
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="serviceId">Required parameter: An id of the service created e.g. UUID..</param>
        /// <param name="claimId">Required parameter: Id of the claim created e.g. UUID..</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.ServiceManagementResult response from the API call.</returns>
        public ApiResponse<Models.ServiceManagementResult> StartServiceClaimSandBoxTesting(
                string accountName,
                string serviceId,
                string claimId,
                Models.ClusterInfoDetails body,
                string correlationId = null)
            => CoreHelper.RunTask(StartServiceClaimSandBoxTestingAsync(accountName, serviceId, claimId, body, correlationId));

        /// <summary>
        /// Initiate testing of a service in sandbox environment per claim based on service's compatibility(s).
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="serviceId">Required parameter: An id of the service created e.g. UUID..</param>
        /// <param name="claimId">Required parameter: Id of the claim created e.g. UUID..</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ServiceManagementResult response from the API call.</returns>
        public async Task<ApiResponse<Models.ServiceManagementResult>> StartServiceClaimSandBoxTestingAsync(
                string accountName,
                string serviceId,
                string claimId,
                Models.ClusterInfoDetails body,
                string correlationId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ServiceManagementResult>()
              .Server(Server.Services)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/v1/services/{serviceId}/claims/{claimId}/sandBoxStart")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("AccountName", accountName))
                      .Template(_template => _template.Setup("serviceId", serviceId))
                      .Template(_template => _template.Setup("claimId", claimId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("correlationId", correlationId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Unexpected error.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.ServiceManagementResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Remove a service from user's organization.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="serviceName">Required parameter: Name of the service which is about to be deleted..</param>
        /// <param name="version">Required parameter: Version of the service which is about to be deleted..</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.EdgeServiceOnboardingDeleteResult response from the API call.</returns>
        public ApiResponse<Models.EdgeServiceOnboardingDeleteResult> RemoveService(
                string accountName,
                string serviceName,
                string version,
                string correlationId = null)
            => CoreHelper.RunTask(RemoveServiceAsync(accountName, serviceName, version, correlationId));

        /// <summary>
        /// Remove a service from user's organization.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="serviceName">Required parameter: Name of the service which is about to be deleted..</param>
        /// <param name="version">Required parameter: Version of the service which is about to be deleted..</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.EdgeServiceOnboardingDeleteResult response from the API call.</returns>
        public async Task<ApiResponse<Models.EdgeServiceOnboardingDeleteResult>> RemoveServiceAsync(
                string accountName,
                string serviceName,
                string version,
                string correlationId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.EdgeServiceOnboardingDeleteResult>()
              .Server(Server.Services)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/v1/services/{serviceName}/{version}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("AccountName", accountName))
                      .Template(_template => _template.Setup("serviceName", serviceName))
                      .Template(_template => _template.Setup("version", version))
                      .Header(_header => _header.Setup("correlationId", correlationId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("401", CreateErrorCase("Unauthorized.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not found.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.EdgeServiceOnboardingDeleteResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Start service certification process. On successful completion of this process, service's status will change to certified.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="serviceName">Required parameter: Name of the service e.g. any sub string of serviceName..</param>
        /// <param name="version">Required parameter: Version of service which is to be certified..</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.ServiceManagementResult response from the API call.</returns>
        public ApiResponse<Models.ServiceManagementResult> StopServiceTesting(
                string accountName,
                string serviceName,
                string version,
                string correlationId = null)
            => CoreHelper.RunTask(StopServiceTestingAsync(accountName, serviceName, version, correlationId));

        /// <summary>
        /// Start service certification process. On successful completion of this process, service's status will change to certified.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="serviceName">Required parameter: Name of the service e.g. any sub string of serviceName..</param>
        /// <param name="version">Required parameter: Version of service which is to be certified..</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ServiceManagementResult response from the API call.</returns>
        public async Task<ApiResponse<Models.ServiceManagementResult>> StopServiceTestingAsync(
                string accountName,
                string serviceName,
                string version,
                string correlationId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ServiceManagementResult>()
              .Server(Server.Services)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/v1/services/{serviceName}/{version}/certify")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("AccountName", accountName))
                      .Template(_template => _template.Setup("serviceName", serviceName))
                      .Template(_template => _template.Setup("version", version))
                      .Header(_header => _header.Setup("correlationId", correlationId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Unexpected error.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.ServiceManagementResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Start the process to change a service's status to "Ready to Use". On success, service's status will be changed to "Ready to Use". Only a ready to use service can be deployed in production environment.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="serviceName">Required parameter: Name of the service e.g. any sub string of serviceName..</param>
        /// <param name="version">Required parameter: Version of the service which is already certified and is ready for public use..</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.ServiceManagementResult response from the API call.</returns>
        public ApiResponse<Models.ServiceManagementResult> MarkServiceAsReadyForPublicUse(
                string accountName,
                string serviceName,
                string version,
                string correlationId = null)
            => CoreHelper.RunTask(MarkServiceAsReadyForPublicUseAsync(accountName, serviceName, version, correlationId));

        /// <summary>
        /// Start the process to change a service's status to "Ready to Use". On success, service's status will be changed to "Ready to Use". Only a ready to use service can be deployed in production environment.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="serviceName">Required parameter: Name of the service e.g. any sub string of serviceName..</param>
        /// <param name="version">Required parameter: Version of the service which is already certified and is ready for public use..</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ServiceManagementResult response from the API call.</returns>
        public async Task<ApiResponse<Models.ServiceManagementResult>> MarkServiceAsReadyForPublicUseAsync(
                string accountName,
                string serviceName,
                string version,
                string correlationId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ServiceManagementResult>()
              .Server(Server.Services)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/v1/services/{serviceName}/{version}/readyToPublicUse")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("AccountName", accountName))
                      .Template(_template => _template.Setup("serviceName", serviceName))
                      .Template(_template => _template.Setup("version", version))
                      .Header(_header => _header.Setup("correlationId", correlationId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Unexpected error.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.ServiceManagementResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Start service onboarding process to kick off service artifact validation and making the service ready for sandbox testing. On successful completion of this process system will generate claims for each selected cloud provider using which user can start sandbox testing.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="serviceName">Required parameter: Name of the service which is to be onboarded..</param>
        /// <param name="version">Required parameter: Version of service which is to be onboarded..</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.ServiceManagementResult response from the API call.</returns>
        public ApiResponse<Models.ServiceManagementResult> StartServiceOnboarding(
                string accountName,
                string serviceName,
                string version,
                string correlationId = null)
            => CoreHelper.RunTask(StartServiceOnboardingAsync(accountName, serviceName, version, correlationId));

        /// <summary>
        /// Start service onboarding process to kick off service artifact validation and making the service ready for sandbox testing. On successful completion of this process system will generate claims for each selected cloud provider using which user can start sandbox testing.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="serviceName">Required parameter: Name of the service which is to be onboarded..</param>
        /// <param name="version">Required parameter: Version of service which is to be onboarded..</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ServiceManagementResult response from the API call.</returns>
        public async Task<ApiResponse<Models.ServiceManagementResult>> StartServiceOnboardingAsync(
                string accountName,
                string serviceName,
                string version,
                string correlationId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ServiceManagementResult>()
              .Server(Server.Services)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/v1/services/{serviceName}/{version}/startOnboarding")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("AccountName", accountName))
                      .Template(_template => _template.Setup("serviceName", serviceName))
                      .Template(_template => _template.Setup("version", version))
                      .Header(_header => _header.Setup("correlationId", correlationId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not found.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("415", CreateErrorCase("Unsupported media type.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too many requests.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.ServiceManagementResult>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Check current status of job for a service using job ID.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="jobId">Required parameter: Auto-generated Id of the job..</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.CurrentStatus response from the API call.</returns>
        public ApiResponse<Models.CurrentStatus> GetServiceJobStatus(
                string accountName,
                string jobId,
                string correlationId = null)
            => CoreHelper.RunTask(GetServiceJobStatusAsync(accountName, jobId, correlationId));

        /// <summary>
        /// Check current status of job for a service using job ID.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="jobId">Required parameter: Auto-generated Id of the job..</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.CurrentStatus response from the API call.</returns>
        public async Task<ApiResponse<Models.CurrentStatus>> GetServiceJobStatusAsync(
                string accountName,
                string jobId,
                string correlationId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CurrentStatus>()
              .Server(Server.Services)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/services/{jobId}/status")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("AccountName", accountName))
                      .Template(_template => _template.Setup("jobId", jobId))
                      .Header(_header => _header.Setup("correlationId", correlationId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("401", CreateErrorCase("Unauthorized.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not found.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.CurrentStatus>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Start publishing a service. On successful completion, service's status can be marked as Publish.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="serviceName">Required parameter: Name of the service e.g. any sub string of serviceName..</param>
        /// <param name="version">Required parameter: Version of service which is to be published..</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <returns>Returns the ApiResponse of Models.ServiceManagementResult response from the API call.</returns>
        public ApiResponse<Models.ServiceManagementResult> StartServicePublishing(
                string accountName,
                string serviceName,
                string version,
                string correlationId = null)
            => CoreHelper.RunTask(StartServicePublishingAsync(accountName, serviceName, version, correlationId));

        /// <summary>
        /// Start publishing a service. On successful completion, service's status can be marked as Publish.
        /// </summary>
        /// <param name="accountName">Required parameter: User account name..</param>
        /// <param name="serviceName">Required parameter: Name of the service e.g. any sub string of serviceName..</param>
        /// <param name="version">Required parameter: Version of service which is to be published..</param>
        /// <param name="correlationId">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ServiceManagementResult response from the API call.</returns>
        public async Task<ApiResponse<Models.ServiceManagementResult>> StartServicePublishingAsync(
                string accountName,
                string serviceName,
                string version,
                string correlationId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ServiceManagementResult>()
              .Server(Server.Services)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/v1/services/{serviceName}/{version}/publish")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("AccountName", accountName))
                      .Template(_template => _template.Setup("serviceName", serviceName))
                      .Template(_template => _template.Setup("version", version))
                      .Header(_header => _header.Setup("correlationId", correlationId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Unexpected error.", (_reason, _context) => new EdgeServiceOnboardingResultErrorException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.ServiceManagementResult>(_response)))
              .ExecuteAsync(cancellationToken);
    }
}