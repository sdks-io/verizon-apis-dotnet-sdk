// <copyright file="TargetsController.cs" company="APIMatic">
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
using Verizon.Standard.Http.Client;
using Verizon.Standard.Http.Response;
using Verizon.Standard.Utilities;

namespace Verizon.Standard.Controllers
{
    /// <summary>
    /// TargetsController.
    /// </summary>
    public class TargetsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TargetsController"/> class.
        /// </summary>
        internal TargetsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Search for targets by property values. Returns an array of all matching target resources.
        /// </summary>
        /// <param name="body">Required parameter: Search for targets by property values..</param>
        /// <returns>Returns the ApiResponse of List&lt;Models.Target&gt; response from the API call.</returns>
        public ApiResponse<List<Models.Target>> QueryTarget(
                Models.QueryTargetRequest body)
            => CoreHelper.RunTask(QueryTargetAsync(body));

        /// <summary>
        /// Search for targets by property values. Returns an array of all matching target resources.
        /// </summary>
        /// <param name="body">Required parameter: Search for targets by property values..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List&lt;Models.Target&gt; response from the API call.</returns>
        public async Task<ApiResponse<List<Models.Target>>> QueryTargetAsync(
                Models.QueryTargetRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.Target>>()
              .Server(Server.CloudConnector)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/targets/actions/query")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Remove a target from a ThingSpace account.
        /// </summary>
        /// <param name="body">Required parameter: The request body identifies the target to delete..</param>
        public void DeleteTarget(
                Models.DeleteTargetRequest body)
            => CoreHelper.RunVoidTask(DeleteTargetAsync(body));

        /// <summary>
        /// Remove a target from a ThingSpace account.
        /// </summary>
        /// <param name="body">Required parameter: The request body identifies the target to delete..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteTargetAsync(
                Models.DeleteTargetRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .Server(Server.CloudConnector)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/targets/actions/delete")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Define a target to receive data streams, alerts, or callbacks. After creating the target resource, use its ID in a subscription to set up a data stream.
        /// </summary>
        /// <param name="body">Required parameter: The request body provides the details of the target that you want to create..</param>
        /// <returns>Returns the ApiResponse of Models.Target response from the API call.</returns>
        public ApiResponse<Models.Target> CreateTarget(
                Models.CreateTargetRequest body)
            => CoreHelper.RunTask(CreateTargetAsync(body));

        /// <summary>
        /// Define a target to receive data streams, alerts, or callbacks. After creating the target resource, use its ID in a subscription to set up a data stream.
        /// </summary>
        /// <param name="body">Required parameter: The request body provides the details of the target that you want to create..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Target response from the API call.</returns>
        public async Task<ApiResponse<Models.Target>> CreateTargetAsync(
                Models.CreateTargetRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Target>()
              .Server(Server.CloudConnector)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/targets")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create a unique string that ThingSpace will pass to AWS for increased security.
        /// </summary>
        /// <param name="body">Required parameter: The request body only contains the authenticating account..</param>
        /// <returns>Returns the ApiResponse of Models.GenerateExternalIDResult response from the API call.</returns>
        public ApiResponse<Models.GenerateExternalIDResult> GenerateTargetExternalID(
                Models.GenerateExternalIDRequest body)
            => CoreHelper.RunTask(GenerateTargetExternalIDAsync(body));

        /// <summary>
        /// Create a unique string that ThingSpace will pass to AWS for increased security.
        /// </summary>
        /// <param name="body">Required parameter: The request body only contains the authenticating account..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.GenerateExternalIDResult response from the API call.</returns>
        public async Task<ApiResponse<Models.GenerateExternalIDResult>> GenerateTargetExternalIDAsync(
                Models.GenerateExternalIDRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GenerateExternalIDResult>()
              .Server(Server.CloudConnector)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/targets/actions/newextid")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Deploy a new Azure IoT Central application based on the Verizon ARM template within the specified Azure Active Directory account.
        /// </summary>
        /// <param name="billingaccountID">Required parameter: TThe ThingSpace ID of the authenticating billing account..</param>
        /// <param name="body">Required parameter: The request body must include the UUID of the subscription that you want to update plus any properties that you want to change..</param>
        /// <returns>Returns the ApiResponse of Models.CreateIoTApplicationResponse response from the API call.</returns>
        public ApiResponse<Models.CreateIoTApplicationResponse> CreateAzureCentralIoTApplication(
                string billingaccountID,
                Models.CreateIoTApplicationRequest body)
            => CoreHelper.RunTask(CreateAzureCentralIoTApplicationAsync(billingaccountID, body));

        /// <summary>
        /// Deploy a new Azure IoT Central application based on the Verizon ARM template within the specified Azure Active Directory account.
        /// </summary>
        /// <param name="billingaccountID">Required parameter: TThe ThingSpace ID of the authenticating billing account..</param>
        /// <param name="body">Required parameter: The request body must include the UUID of the subscription that you want to update plus any properties that you want to change..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.CreateIoTApplicationResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.CreateIoTApplicationResponse>> CreateAzureCentralIoTApplicationAsync(
                string billingaccountID,
                Models.CreateIoTApplicationRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CreateIoTApplicationResponse>()
              .Server(Server.CloudConnector)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/targets/actions/newaic")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("BillingaccountID", billingaccountID))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}