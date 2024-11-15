// <copyright file="ServiceEndpointsController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
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
using Verizon.Standard.Exceptions;
using Verizon.Standard.Http.Client;
using Verizon.Standard.Http.Response;
using Verizon.Standard.Utilities;

namespace Verizon.Standard.Controllers
{
    /// <summary>
    /// ServiceEndpointsController.
    /// </summary>
    public class ServiceEndpointsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceEndpointsController"/> class.
        /// </summary>
        internal ServiceEndpointsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Returns a list of optimal Service Endpoints that client devices can connect to. **Note:** If a query is sent with all of the parameters, it will fail with a "400" error. You can search based on the following parameter combinations - Region plus Service Endpoints IDs and Subscriber density (density is optional but recommended), Region plus Service Endpoints IDs and UEIdentity(Including UEIdentity Type) and Service Endpoints IDs plus UEIdentity(Including UEIdentity Type).
        /// </summary>
        /// <param name="region">Optional parameter: MEC region name. Current valid values are US_WEST_2 and US_EAST_1..</param>
        /// <param name="subscriberDensity">Optional parameter: Minimum number of 4G/5G subscribers per square kilometer..</param>
        /// <param name="uEIdentityType">Optional parameter: Type of User Equipment identifier used in `UEIdentity`..</param>
        /// <param name="uEIdentity">Optional parameter: The identifier value for User Equipment. The type of identifier is defined by the 'UEIdentityType' parameter. The`IPAddress`format can be IPv4 or IPv6..</param>
        /// <param name="serviceEndpointsIds">Optional parameter: A system-defined string identifier representing one or more registered Service Endpoints..</param>
        /// <returns>Returns the ApiResponse of Models.ListOptimalServiceEndpointsResult response from the API call.</returns>
        public ApiResponse<Models.ListOptimalServiceEndpointsResult> ListOptimalServiceEndpoints(
                string region = null,
                int? subscriberDensity = null,
                Models.UserEquipmentIdentityTypeEnum? uEIdentityType = null,
                string uEIdentity = null,
                string serviceEndpointsIds = null)
            => CoreHelper.RunTask(ListOptimalServiceEndpointsAsync(region, subscriberDensity, uEIdentityType, uEIdentity, serviceEndpointsIds));

        /// <summary>
        /// Returns a list of optimal Service Endpoints that client devices can connect to. **Note:** If a query is sent with all of the parameters, it will fail with a "400" error. You can search based on the following parameter combinations - Region plus Service Endpoints IDs and Subscriber density (density is optional but recommended), Region plus Service Endpoints IDs and UEIdentity(Including UEIdentity Type) and Service Endpoints IDs plus UEIdentity(Including UEIdentity Type).
        /// </summary>
        /// <param name="region">Optional parameter: MEC region name. Current valid values are US_WEST_2 and US_EAST_1..</param>
        /// <param name="subscriberDensity">Optional parameter: Minimum number of 4G/5G subscribers per square kilometer..</param>
        /// <param name="uEIdentityType">Optional parameter: Type of User Equipment identifier used in `UEIdentity`..</param>
        /// <param name="uEIdentity">Optional parameter: The identifier value for User Equipment. The type of identifier is defined by the 'UEIdentityType' parameter. The`IPAddress`format can be IPv4 or IPv6..</param>
        /// <param name="serviceEndpointsIds">Optional parameter: A system-defined string identifier representing one or more registered Service Endpoints..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ListOptimalServiceEndpointsResult response from the API call.</returns>
        public async Task<ApiResponse<Models.ListOptimalServiceEndpointsResult>> ListOptimalServiceEndpointsAsync(
                string region = null,
                int? subscriberDensity = null,
                Models.UserEquipmentIdentityTypeEnum? uEIdentityType = null,
                string uEIdentity = null,
                string serviceEndpointsIds = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListOptimalServiceEndpointsResult>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/serviceendpoints")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("region", region))
                      .Query(_query => _query.Setup("subscriberDensity", subscriberDensity))
                      .Query(_query => _query.Setup("UEIdentityType", (uEIdentityType.HasValue) ? ApiHelper.JsonSerialize(uEIdentityType.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("UEIdentity", uEIdentity))
                      .Query(_query => _query.Setup("serviceEndpointsIds", serviceEndpointsIds))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("HTTP 400 Bad Request.", (_reason, _context) => new EdgeDiscoveryResultException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("HTTP 401 Unauthorized.", (_reason, _context) => new EdgeDiscoveryResultException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("HTTP 500 Internal Server Error.", (_reason, _context) => new EdgeDiscoveryResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Register Service Endpoints of a deployed application to specified MEC Platforms.
        /// </summary>
        /// <param name="body">Required parameter: An array of Service Endpoint data for a deployed application. The request body passes all of the needed parameters to create a service endpoint. Parameters will be edited here rather than the **Parameters** section above. The `ern`,`applicationServerProviderId`, `applicationId` and `serviceProfileID` parameters are required. **Note:** Currently, the only valid value for `applicationServerProviderId`is **AWS**. Also, if you do not know one of the optional values (i.e. URI), you can erase the line from the query by back-spacing over it..</param>
        /// <returns>Returns the ApiResponse of Models.RegisterServiceEndpointResult response from the API call.</returns>
        public ApiResponse<Models.RegisterServiceEndpointResult> RegisterServiceEndpoints(
                List<Models.ResourcesEdgeHostedServiceWithProfileId> body)
            => CoreHelper.RunTask(RegisterServiceEndpointsAsync(body));

        /// <summary>
        /// Register Service Endpoints of a deployed application to specified MEC Platforms.
        /// </summary>
        /// <param name="body">Required parameter: An array of Service Endpoint data for a deployed application. The request body passes all of the needed parameters to create a service endpoint. Parameters will be edited here rather than the **Parameters** section above. The `ern`,`applicationServerProviderId`, `applicationId` and `serviceProfileID` parameters are required. **Note:** Currently, the only valid value for `applicationServerProviderId`is **AWS**. Also, if you do not know one of the optional values (i.e. URI), you can erase the line from the query by back-spacing over it..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.RegisterServiceEndpointResult response from the API call.</returns>
        public async Task<ApiResponse<Models.RegisterServiceEndpointResult>> RegisterServiceEndpointsAsync(
                List<Models.ResourcesEdgeHostedServiceWithProfileId> body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RegisterServiceEndpointResult>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/serviceendpoints")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("HTTP 400 Bad Request.", (_reason, _context) => new EdgeDiscoveryResultException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("HTTP 401 Unauthorized.", (_reason, _context) => new EdgeDiscoveryResultException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("HTTP 500 Internal Server Error.", (_reason, _context) => new EdgeDiscoveryResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns a list of all registered service endpoints.
        /// </summary>
        /// <returns>Returns the ApiResponse of Models.ListAllServiceEndpointsResult response from the API call.</returns>
        public ApiResponse<Models.ListAllServiceEndpointsResult> ListAllServiceEndpoints()
            => CoreHelper.RunTask(ListAllServiceEndpointsAsync());

        /// <summary>
        /// Returns a list of all registered service endpoints.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ListAllServiceEndpointsResult response from the API call.</returns>
        public async Task<ApiResponse<Models.ListAllServiceEndpointsResult>> ListAllServiceEndpointsAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListAllServiceEndpointsResult>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/serviceendpointsall")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  ))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("HTTP 400 Bad Request.", (_reason, _context) => new EdgeDiscoveryResultException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("HTTP 401 Unauthorized.", (_reason, _context) => new EdgeDiscoveryResultException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("HTTP 500 Internal Server Error.", (_reason, _context) => new EdgeDiscoveryResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns endpoint information for all Service Endpoints registered to a specified serviceEndpointId.
        /// </summary>
        /// <param name="serviceEndpointsId">Required parameter: A system-defined string identifier representing one or more registered Service Endpoints..</param>
        /// <returns>Returns the ApiResponse of List&lt;Models.ResourcesEdgeHostedServiceWithProfileId&gt; response from the API call.</returns>
        public ApiResponse<List<Models.ResourcesEdgeHostedServiceWithProfileId>> GetServiceEndpoint(
                string serviceEndpointsId)
            => CoreHelper.RunTask(GetServiceEndpointAsync(serviceEndpointsId));

        /// <summary>
        /// Returns endpoint information for all Service Endpoints registered to a specified serviceEndpointId.
        /// </summary>
        /// <param name="serviceEndpointsId">Required parameter: A system-defined string identifier representing one or more registered Service Endpoints..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List&lt;Models.ResourcesEdgeHostedServiceWithProfileId&gt; response from the API call.</returns>
        public async Task<ApiResponse<List<Models.ResourcesEdgeHostedServiceWithProfileId>>> GetServiceEndpointAsync(
                string serviceEndpointsId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.ResourcesEdgeHostedServiceWithProfileId>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/serviceendpoints/{serviceEndpointsId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("serviceEndpointsId", serviceEndpointsId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("HTTP 400 Bad Request.", (_reason, _context) => new EdgeDiscoveryResultException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("HTTP 401 Unauthorized.", (_reason, _context) => new EdgeDiscoveryResultException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("HTTP 500 Internal Server Error.", (_reason, _context) => new EdgeDiscoveryResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Update registered Service Endpoint information.
        /// </summary>
        /// <param name="serviceEndpointsId">Required parameter: A system-defined string identifier representing one or more registered Service Endpoints..</param>
        /// <param name="body">Required parameter: Data needed for Service Endpoint information. The request body passes the rest of the needed parameters to create a service endpoint. Parameters other than `serviceEndpointsId` will be edited here rather than the **Parameters** section above. The `ern`,`applicationServerProviderId` and `applicationId` parameters are required. **Note:** Currently, the only valid value for `applicationServerProviderId`is **AWS**..</param>
        /// <returns>Returns the ApiResponse of Models.UpdateServiceEndpointResult response from the API call.</returns>
        public ApiResponse<Models.UpdateServiceEndpointResult> UpdateServiceEndpoint(
                string serviceEndpointsId,
                List<Models.ResourcesEdgeHostedServiceWithProfileId> body)
            => CoreHelper.RunTask(UpdateServiceEndpointAsync(serviceEndpointsId, body));

        /// <summary>
        /// Update registered Service Endpoint information.
        /// </summary>
        /// <param name="serviceEndpointsId">Required parameter: A system-defined string identifier representing one or more registered Service Endpoints..</param>
        /// <param name="body">Required parameter: Data needed for Service Endpoint information. The request body passes the rest of the needed parameters to create a service endpoint. Parameters other than `serviceEndpointsId` will be edited here rather than the **Parameters** section above. The `ern`,`applicationServerProviderId` and `applicationId` parameters are required. **Note:** Currently, the only valid value for `applicationServerProviderId`is **AWS**..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.UpdateServiceEndpointResult response from the API call.</returns>
        public async Task<ApiResponse<Models.UpdateServiceEndpointResult>> UpdateServiceEndpointAsync(
                string serviceEndpointsId,
                List<Models.ResourcesEdgeHostedServiceWithProfileId> body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UpdateServiceEndpointResult>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/serviceendpoints/{serviceEndpointsId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("serviceEndpointsId", serviceEndpointsId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("HTTP 400 Bad Request.", (_reason, _context) => new EdgeDiscoveryResultException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("HTTP 401 Unauthorized.", (_reason, _context) => new EdgeDiscoveryResultException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("HTTP 500 Internal Server Error.", (_reason, _context) => new EdgeDiscoveryResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Deregister an application's Service Endpoint from the MEC Platform(s).
        /// </summary>
        /// <param name="serviceEndpointsId">Required parameter: A system-defined string identifier representing one or more registered Service Endpoints..</param>
        /// <returns>Returns the ApiResponse of Models.DeregisterServiceEndpointResult response from the API call.</returns>
        public ApiResponse<Models.DeregisterServiceEndpointResult> DeregisterServiceEndpoint(
                string serviceEndpointsId)
            => CoreHelper.RunTask(DeregisterServiceEndpointAsync(serviceEndpointsId));

        /// <summary>
        /// Deregister an application's Service Endpoint from the MEC Platform(s).
        /// </summary>
        /// <param name="serviceEndpointsId">Required parameter: A system-defined string identifier representing one or more registered Service Endpoints..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeregisterServiceEndpointResult response from the API call.</returns>
        public async Task<ApiResponse<Models.DeregisterServiceEndpointResult>> DeregisterServiceEndpointAsync(
                string serviceEndpointsId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeregisterServiceEndpointResult>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/serviceendpoints/{serviceEndpointsId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("serviceEndpointsId", serviceEndpointsId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("HTTP 400 Bad Request.", (_reason, _context) => new EdgeDiscoveryResultException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("HTTP 401 Unauthorized.", (_reason, _context) => new EdgeDiscoveryResultException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("HTTP 500 Internal Server Error.", (_reason, _context) => new EdgeDiscoveryResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}